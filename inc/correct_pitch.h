/*
 * correct_pitch.h
 *
 *  Created on: Aug 9, 2015
 *      Author: dgssm
 */

#ifndef CORRECT_PITCH_H_
#define CORRECT_PITCH_H_

#include <tizen.h>
#include <audio_io.h>
#include <sound_manager.h>
#include <assert.h>
#include <Ecore.h>
#include <time.h>
#include <unistd.h>
#include <Evas.h>

#include "pitch_detector.h"
#include "note.h"

audio_in_h input;

// constant
#define SAMPLE_RATE 22050
#define SAMPLE_SIZE 100
#define FRAME_SIZE 2048
#define ENERGY_LIMIT 20000
#define ZERO_CROSS_LIMIT 0.5

#define TRUE 1
#define FALSE 0

#define PASS_TIME_SEC 1
#define CLEAR_TIME_SEC 2
// microsec
#define MSG_NOTIFY_TERM 50000
#define MSG_CLEAR_TERM 100000


#define LOG_TAG "record"

typedef struct _audio_input_data
{
	void* buffer;
	unsigned int buffer_size;
	Ecore_Thread* thread;
	Bool isPause;
	Bool isRunning;
}audio_input_data;

typedef struct _correct_pitch_data
{
	audio_input_data* aid;
	Note* notes;
	unsigned int note_size;
}correct_pitch_data;

typedef struct _noteInfo
{
   double appearTime;
   double existTime;
   long intervals;
}noteInfo;	// Test

typedef struct _perfect_song_data
{
	audio_input_data* aid;
	noteInfo* noteInfos;
	unsigned int noteInfoSize;
	Evas_Object* mark;
	int max_pitch;
	int min_pitch;
}perfect_song_data;

typedef int Bool;

typedef enum
{
	HIT = 1,
	WRONG = 0,
	UPPER = -1,
	LOWER = -2,
	NONE = 3
}Hit_e;

typedef struct _notify_msg_data
{
	Note* note;
	Note* detected_note;
	Bool isRight;
	Bool isPass;
	Bool isClear;
	int level;
}notify_msg_data;

typedef struct _perfect_song_notify_msg_data
{
	Note* detected_note;
	Hit_e isHit;
	Bool isClear;
	int score;
	double percent;
}perfect_song_notify_msg_data;

unsigned int get_audio_buffer_size(const unsigned int sample_size, const unsigned int sample_rate);

audio_in_h* create_audio_input(const unsigned int sample_rate);
audio_input_data* create_audio_input_data();
correct_pitch_data* create_correct_pitch_data(audio_input_data* aid, Note* notes, unsigned int note_size);
perfect_song_data* create_perfect_song_data(audio_input_data* aid, noteInfo* noteInfos, unsigned int noteInfoSize, Evas_Object* mark, int max_pitch, int min_pitch);

void destroy_perfect_song_data(perfect_song_data* _input_data);
void destroy_correct_pitch_data(correct_pitch_data* _input_data);
void destroy_audio_input(audio_input_data* _input_data);

void init_audio();
void destroy_audio();

void pitch_detect_routine(void *data, Ecore_Thread *thread);
void pitch_detect_end_cb(void *data, Ecore_Thread *thread);
correct_pitch_data* correct_note(Note* notes, int note_size, Ecore_Thread_Notify_Cb notify_cb);

correct_pitch_data* lv1_start(Ecore_Thread_Notify_Cb notify_cb);
correct_pitch_data* lv2_start(Ecore_Thread_Notify_Cb notify_cb);
correct_pitch_data* lv3_start(Ecore_Thread_Notify_Cb notify_cb);
correct_pitch_data* lv4_start(Ecore_Thread_Notify_Cb notify_cb);
correct_pitch_data* lv5_start(Ecore_Thread_Notify_Cb notify_cb);

perfect_song_data* perfect_song(noteInfo* noteInfos, int noteInfoSize, Evas_Object* mark, int max_pitch, int min_pitch, Ecore_Thread_Notify_Cb notify_cb);
void perfect_song_routine(void *data, Ecore_Thread *thread);
void perfect_song_end_cb(void *data, Ecore_Thread *thread);

double timeval2double(struct timeval tv);
Bool check_tick(noteInfo* ni, double dtime);
#endif /* CORRECT_PITCH_H_ */
