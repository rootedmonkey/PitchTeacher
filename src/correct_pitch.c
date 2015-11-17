#include "correct_pitch.h"

const double TIME_GAP = 0.0;
const double HIT_RATE = 0.5;

audio_in_h input;

void init_audio()
{

	audio_channel_e channel = AUDIO_CHANNEL_MONO;
	audio_sample_type_e  sample_type = AUDIO_SAMPLE_TYPE_S16_LE;
	audio_io_error_e ret;

	ret = audio_in_create(SAMPLE_RATE, channel, sample_type, &input);
	if(ret!=AUDIO_IO_ERROR_NONE)
	{
		dlog_print(DLOG_VERBOSE, LOG_TAG, "create : %d",ret);
	}
	ret = audio_in_prepare(input);
	if(ret!=AUDIO_IO_ERROR_NONE)
	{
		dlog_print(DLOG_VERBOSE, LOG_TAG, "prepare : %d",ret);
	}
}
void destroy_audio()
{
	audio_in_unprepare(input);
	audio_in_destroy(input);
}
unsigned int get_audio_buffer_size(const unsigned int sample_size, const unsigned int sample_rate)
{
	// SAMPLE_SIZE * SAMPLE_RATE * (sample_type == AUDIO_SAMPLE_TYPE_S16_LE ? 2 : 1);
	unsigned int _size = sample_size * sample_rate * 2;
	dlog_print(DLOG_ERROR, LOG_TAG, "buffer size : %d", _size);		// DEBUG

	return _size;
}
audio_input_data* create_audio_input_data()
{
	// create structure
	audio_input_data* aid = malloc(sizeof(audio_input_data));

	aid->buffer_size = get_audio_buffer_size(SAMPLE_SIZE, SAMPLE_RATE);
	aid->buffer = malloc(aid->buffer_size);
	aid->isRunning = TRUE;
	return aid;
}
correct_pitch_data* create_correct_pitch_data(audio_input_data* aid, Note* notes, unsigned int note_size)
{
	correct_pitch_data* cpd = malloc(sizeof(correct_pitch_data));

	cpd->aid = aid;
	cpd->notes = notes;
	cpd->note_size = note_size;
	return cpd;
}
perfect_song_data* create_perfect_song_data(audio_input_data* aid, noteInfo* noteInfos, unsigned int noteInfoSize, Evas_Object* mark, int max_pitch, int min_pitch)
{
	perfect_song_data* psd = malloc(sizeof(perfect_song_data));

	psd->aid = aid;
	psd->noteInfos = noteInfos;
	psd->noteInfoSize = noteInfoSize;
	psd->mark = mark;
	psd->max_pitch = max_pitch;
	psd->min_pitch = min_pitch;
	return psd;
}
void destroy_audio_input(audio_input_data* _input_data)
{
	free(_input_data->buffer);
	_input_data->buffer_size=0;
	_input_data->thread = NULL;
	free(_input_data);
}
void destroy_correct_pitch_data(correct_pitch_data* _input_data)
{
	destroy_audio_input(_input_data->aid);
	free(_input_data->notes);
	_input_data->note_size=0;
	free(_input_data);
}
void destroy_perfect_song_data(perfect_song_data* _input_data)
{
	destroy_audio_input(_input_data->aid);
	_input_data->noteInfos = NULL;
	//free(_input_data->noteInfos);
	_input_data->noteInfoSize=0;
	evas_object_del(_input_data->mark);
	_input_data->mark=NULL;
	_input_data->max_pitch=0;
	_input_data->min_pitch=0;
	free(_input_data);
}
void pitch_detect_routine(void *data, Ecore_Thread *thread)
{
	dlog_print(DLOG_ERROR, LOG_TAG, "pitch_detect_routine start");

	correct_pitch_data* cpd = data;
	audio_input_data* aid = cpd->aid;
	unsigned int capacity = aid->buffer_size;
	unsigned int dump_size = FRAME_SIZE*2;		// 1 frame = 16bit = 2byte
	short* samples = aid->buffer;
	Note* notes = cpd->notes;
	unsigned int note_size = cpd->note_size;

	int bytes = 0;
	int read_bytes  = 0;
	int note_index = 0;
	struct timeval tval_start, tval_end, tval_result;
	Bool isDetected = FALSE;
	// auto-correlation frame
	double* acr = (double*)malloc(sizeof(double)*FRAME_SIZE);
	double frequency;
	Note detected_note;

	notify_msg_data msg_data;
	msg_data.note = notes;
	msg_data.isRight=FALSE;
	msg_data.isPass=FALSE;
	msg_data.isClear=FALSE;

	unsigned int beforeNum = 0;
	// 중첩률 50%
	while(aid->isRunning)
	{
		if(read_bytes == 0)		// first
		{
			bytes = audio_in_read(input, samples, dump_size*2);
		}
		else
		{
			bytes = audio_in_read(input, samples, dump_size*2);
		}

		//assert(bytes >= 0);
		if(bytes)
		{
			frequency = get_frequency(samples, acr, FRAME_SIZE, SAMPLE_RATE, ENERGY_LIMIT, ZERO_CROSS_LIMIT);
			detected_note = getNoteObject(frequency);

			dlog_print(DLOG_INFO, LOG_TAG, "[%s] [%s] [%.2lf Hz]",detected_note.note, detected_note.kor, detected_note.freq);
			// counting
			if(!isDetected)
			{
				msg_data.detected_note = &detected_note;
				if(notes->midiNum == detected_note.midiNum)
				{
					isDetected = TRUE;
					msg_data.isRight = TRUE;
					gettimeofday(&tval_start,0);
				}
				else
				{
					// wrong
					msg_data.isRight = FALSE;
				}

				if(beforeNum!=detected_note.midiNum)
				{
					ecore_thread_feedback(aid->thread, &msg_data);
					beforeNum=detected_note.midiNum;
				}
			}
			else
			{
				if(notes->midiNum == detected_note.midiNum)
				{
					// right
					msg_data.detected_note = &detected_note;
					msg_data.isRight = TRUE;
					ecore_thread_feedback(aid->thread, &msg_data);

					gettimeofday(&tval_end,0);
					timersub(&tval_end, &tval_start, &tval_result);

					if(tval_result.tv_sec >= PASS_TIME_SEC)
					{
						// pass
						dlog_print(DLOG_FATAL,LOG_TAG,"pass! [%s] [%s]",notes->note,notes->kor);
						msg_data.isPass = TRUE;
						isDetected = FALSE;

						if(note_index<note_size-1)
						{
							notes++;
							msg_data.note = notes;
						}

						// pass notify
						ecore_thread_feedback(aid->thread, &msg_data);

						// clear msg_data
						usleep(MSG_NOTIFY_TERM);

						msg_data.isPass = FALSE;
						msg_data.isRight = FALSE;
						if(++note_index == note_size)
						{
							// clear
							msg_data.isClear = TRUE;
							ecore_thread_feedback(aid->thread, &msg_data);
							usleep(MSG_CLEAR_TERM);
							dlog_print(DLOG_FATAL,LOG_TAG,"clear!");
							free(acr);
							return;
						}
					}
				}
				else	// broken
				{
					isDetected = FALSE;
				}
			}

			samples += bytes/2;		// 1 frame = 16bit = 2byte
			read_bytes += bytes;

			if(read_bytes + dump_size >= capacity)
			{
				// set first point
				samples = aid->buffer;
				read_bytes=0;
			}
		}
	}
}
void pitch_detect_end_cb(void *data, Ecore_Thread *thread)
{
	correct_pitch_data* cpd = data;
	destroy_correct_pitch_data(cpd);
	dlog_print(DLOG_ERROR, LOG_TAG, "pitch_detect_end");
}

correct_pitch_data* correct_note(Note* notes, int note_size, Ecore_Thread_Notify_Cb notify_cb)
{
	audio_input_data* aid = create_audio_input_data();
	if(aid == NULL)
	{
		dlog_print(DLOG_ERROR, LOG_TAG, "fail! create_audio_input_data()");
		return NULL;
	}
	correct_pitch_data* cpd = create_correct_pitch_data(aid,notes,note_size);
	if(cpd == NULL)
	{
		dlog_print(DLOG_ERROR, LOG_TAG, "fail! create_correct_pitch_data()");
		return NULL;
	}
	else
	{
		// thread run
		aid->thread = ecore_thread_feedback_run(pitch_detect_routine, notify_cb, pitch_detect_end_cb, NULL, cpd, EINA_TRUE);
		return cpd;
	}
}
/***
 *  Correct Pitch Levels
 */
correct_pitch_data* lv1_start(Ecore_Thread_Notify_Cb notify_cb)
{
	unsigned int lv1_note_size = 5;
	Note* lv1_notes = malloc(sizeof(Note)*lv1_note_size);


	lv1_notes[0] = getNoteFromMidinum(48);
	lv1_notes[1] = getNoteFromMidinum(50);
	lv1_notes[2] = getNoteFromMidinum(52);
	lv1_notes[3] = getNoteFromMidinum(53);
	lv1_notes[4] = getNoteFromMidinum(55);

	correct_pitch_data* cpd = correct_note(lv1_notes, lv1_note_size, notify_cb);
	if(cpd == NULL)
	{
		// TODO : exception handle
	}

	return cpd;
}
correct_pitch_data* lv2_start(Ecore_Thread_Notify_Cb notify_cb)
{
	unsigned int lv2_note_size = 7;
	Note* lv2_notes = malloc(sizeof(Note)*lv2_note_size);


	lv2_notes[0] = getNoteFromMidinum(48);
	lv2_notes[1] = getNoteFromMidinum(52);
	lv2_notes[2] = getNoteFromMidinum(55);
	lv2_notes[3] = getNoteFromMidinum(60);
	lv2_notes[4] = getNoteFromMidinum(59);
	lv2_notes[5] = getNoteFromMidinum(55);
	lv2_notes[6] = getNoteFromMidinum(50);


	correct_pitch_data* cpd = correct_note(lv2_notes, lv2_note_size, notify_cb);
	if(cpd == NULL)
	{
		// TODO : exception handle
	}

	return cpd;
}
correct_pitch_data* lv3_start(Ecore_Thread_Notify_Cb notify_cb)
{
	unsigned int lv3_note_size = 7;
	Note* lv3_notes = malloc(sizeof(Note)*lv3_note_size);

	lv3_notes[0] = getNoteFromMidinum(49);
	lv3_notes[1] = getNoteFromMidinum(53);
	lv3_notes[2] = getNoteFromMidinum(56);
	lv3_notes[3] = getNoteFromMidinum(51);
	lv3_notes[4] = getNoteFromMidinum(59);
	lv3_notes[5] = getNoteFromMidinum(58);
	lv3_notes[6] = getNoteFromMidinum(54);

	correct_pitch_data* cpd = correct_note(lv3_notes, lv3_note_size, notify_cb);
	if(cpd == NULL)
	{
		// TODO : exception handle
	}

	return cpd;
}
correct_pitch_data* lv4_start(Ecore_Thread_Notify_Cb notify_cb)
{
	unsigned int lv4_note_size = 7;
	Note* lv4_notes = malloc(sizeof(Note)*lv4_note_size);

	srand(time(NULL));
	int random;
	for(int i=0;i<lv4_note_size;i++)
	{
		random = rand()%12;
		lv4_notes[i] = getNoteFromMidinum(48+random);
	}

	correct_pitch_data* cpd = correct_note(lv4_notes, lv4_note_size, notify_cb);
	if(cpd == NULL)
	{
		// TODO : exception handle
	}

	return cpd;
}
correct_pitch_data* lv5_start(Ecore_Thread_Notify_Cb notify_cb)
{
	unsigned int lv5_note_size = 8;
	Note* lv5_notes = malloc(sizeof(Note)*lv5_note_size);

	srand(time(NULL));
	int random;
	for(int i=0;i<lv5_note_size;i++)
	{
		random = rand()%20;
		lv5_notes[i] = getNoteFromMidinum(44+random);
	}

	correct_pitch_data* cpd = correct_note(lv5_notes, lv5_note_size, notify_cb);
	if(cpd == NULL)
	{
		// TODO : exception handle
	}

	return cpd;
}

/****
 * Perfect Song
 */
perfect_song_data* perfect_song(noteInfo* noteInfos, int noteInfoSize, Evas_Object* mark, int max_pitch, int min_pitch, Ecore_Thread_Notify_Cb notify_cb)
{
	audio_input_data* aid = create_audio_input_data();
	if(aid == NULL)
	{
		dlog_print(DLOG_ERROR, LOG_TAG, "fail! create_audio_input_data()");
		return NULL;
	}
	perfect_song_data* psd = create_perfect_song_data(aid,noteInfos,noteInfoSize,mark, max_pitch, min_pitch);
	if(psd == NULL)
	{
		dlog_print(DLOG_ERROR, LOG_TAG, "fail! create_correct_pitch_data()");
		return NULL;
	}
	else
	{
		// thread run
		aid->thread = ecore_thread_feedback_run(perfect_song_routine, notify_cb, perfect_song_end_cb, NULL, psd, EINA_TRUE);
		return psd;
	}
}
void perfect_song_routine(void *data, Ecore_Thread *thread)
{
	dlog_print(DLOG_ERROR, LOG_TAG, "perfect_song_routine start");

	perfect_song_data* psd = data;
	audio_input_data* aid = psd->aid;
	unsigned int capacity = aid->buffer_size;
	unsigned int dump_size = FRAME_SIZE*2;		// 1 frame = 16bit = 2byte
	short* samples = aid->buffer;
	noteInfo* noteInfos = psd->noteInfos;
	unsigned int noteInfoSize = psd->noteInfoSize;
	int max_pitch = psd->max_pitch;
	int min_pitch = psd->min_pitch;

	int bytes = 0;
	int read_bytes  = 0;

	int noteInfo_index = 0;
	struct timeval tval_start, tval_now, tval_result;
	double playing_time;

	// auto-correlation frame
	double* acr = (double*)malloc(sizeof(double)*FRAME_SIZE);
	double frequency;
	Note detected_note;

	// score counting
	int score = 0;

	gettimeofday(&tval_start,0);

	perfect_song_notify_msg_data msg_data;
	msg_data.isHit = NONE;
	msg_data.isClear = FALSE;
	msg_data.score = 0;
	msg_data.percent = 0.0;

	// 중첩률 50%
	aid->isPause=false;
	while(aid->isRunning)
	{
		if(read_bytes == 0)		// first
		{
			bytes = audio_in_read(input, samples, dump_size*2);
		}
		else
		{
			bytes = audio_in_read(input, samples, dump_size*2);
		}

		//assert(bytes >= 0);
		if(bytes)
		{
			frequency = get_frequency(samples, acr, FRAME_SIZE, SAMPLE_RATE, ENERGY_LIMIT, ZERO_CROSS_LIMIT);
			detected_note = getNoteObject(frequency);
			msg_data.detected_note = &detected_note;

			// get playing time
			gettimeofday(&tval_now,0);
			timersub(&tval_now, &tval_start, &tval_result);
			playing_time = timeval2double(tval_result);

			msg_data.isHit = NONE;

			if(playing_time > noteInfos->appearTime + noteInfos->existTime)
			{
				noteInfo_index++;
				if(noteInfo_index==noteInfoSize)
				{
					// clear
					sleep(CLEAR_TIME_SEC);
					msg_data.isClear = TRUE;
					msg_data.score = score;
					msg_data.percent = (double)score / noteInfo_index;
					ecore_thread_feedback(aid->thread,&msg_data);
					return;
				}
				else	// next note
				{
					dlog_print(DLOG_FATAL,"record","===next node===");
					noteInfos++;
				}
			}

			if(check_tick(noteInfos,playing_time) == TRUE)
			{
				if(detected_note.midiNum == noteInfos->intervals)
				{
					msg_data.isHit = HIT;
					score++;
					dlog_print(DLOG_INFO, LOG_TAG, "score : %d",score);
				}
				else if(detected_note.midiNum < min_pitch)
					msg_data.isHit = LOWER;
				else if(detected_note.midiNum > max_pitch)
					msg_data.isHit = UPPER;
				else
					msg_data.isHit = WRONG;
			}

			dlog_print(DLOG_INFO, LOG_TAG, "note : %d detect :%d isHit : %d [%d: %d/%d]",noteInfos->intervals,detected_note.midiNum, msg_data.isHit);
			ecore_thread_feedback(aid->thread,&msg_data);
			usleep(MSG_NOTIFY_TERM);

			samples += bytes/2;		// 1 frame = 16bit = 2byte
			read_bytes += bytes;

			if(read_bytes + dump_size >= capacity)
			{
				// set first point
				samples = aid->buffer;
				read_bytes=0;
			}
		}
	}
}
void perfect_song_end_cb(void *data, Ecore_Thread *thread)
{
	perfect_song_data* psd = data;
	destroy_perfect_song_data(psd);
	dlog_print(DLOG_ERROR, LOG_TAG, "perfect_song_end");
}
double timeval2double(struct timeval tv)
{
	double result = 0;
	result = tv.tv_sec+(tv.tv_usec/1000000.0);
	return result;
}
Bool check_tick(noteInfo* ni, double dtime)
{
	// enable tick : TIME_GAP-[apper ~ exist]
	double temp = ni->appearTime - dtime;

	if(temp>0)
	{
		if(temp < TIME_GAP)
			return TRUE;
		else
			return FALSE;
	}
	else
	{
		if(dtime >= ni->appearTime && dtime <= ni->appearTime + ni->existTime + TIME_GAP)
			return TRUE;
		else
			return FALSE;
	}
}
