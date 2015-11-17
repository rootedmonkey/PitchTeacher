#include "perfectsong.h"

int FILE_COUNT= 5;
int mf_numparms(int s)
{
	return ("\2\2\2\2\1\1\2"[((s) & 0x70)>>4]);
}

YourCallback func = mf_numparms;

static void
list_clicked_cb(void *data, Evas_Object *obj, void *event_info)
{
	char pbuffer[256];
//	sprintf(pbuffer, "%s" , data->fileName);
	//dlog_print(DLOG_INFO,"dir",pbuffer);


	dataSet *cb_data = (dataSet *)data;
	appdata_s *ad = cb_data->ad;
	Evas_Object *perfectsong_view = create_perfectsong_view(ad,cb_data->fileName);
	Evas_Object *voiceMark;
	Evas *e;
	e = evas_object_evas_get(ad->layout);
	voiceMark = evas_object_rectangle_add(e);
	evas_object_resize(voiceMark, 15, 25);

	playing_handle = perfect_song(converted,convertedIndex,voiceMark,interval_max, interval_min, draw_voice);
	ad->mainAid = playing_handle->aid;

	if(playing_handle == NULL)
	{
		// TODO : exception handle
	}

	ad->currentPage = 2;
	elm_naviframe_item_push(ad->nf, "", NULL, NULL, perfectsong_view, NULL);



		/* No Content view */
		//perfectsong_view = create_////////////_view(ad);
		//elm_naviframe_item_push(ad->nf, "No Content", NULL, NULL, perfectsong_view, NULL);
//dlog_print(DLOG_INFO,"dir",data->fileName);
}


static Evas_Object *
create_midiList_view(appdata_s *ad)
{
	Evas_Object *layout, *scroller;

			/* Scroller */
			scroller = elm_scroller_add(ad->nf);
			elm_scroller_bounce_set(scroller, EINA_FALSE, EINA_TRUE);
			elm_scroller_policy_set(scroller, ELM_SCROLLER_POLICY_OFF, ELM_SCROLLER_POLICY_AUTO);

			/* NoContent Layout */
			Evas_Object *list;
				Evas_Object *btn;
				Evas_Object *nf = ad->nf;
				Elm_Object_Item *nf_it;

				/* List */
				list = elm_list_add(nf);

				elm_list_mode_set(list, ELM_LIST_COMPRESS);
				evas_object_smart_callback_add(list, "selected", list_selected_cb, NULL);
				////////////////////////////////////////////////////////////////
				dataSet *cb_data[FILE_COUNT];

				for(int i=0;i<FILE_COUNT;i++)
					cb_data[i] = malloc(sizeof(dataSet));


				sprintf(cb_data[0]->fileName,"%s","JackRabbit");
				sprintf(cb_data[1]->fileName,"%s","spaceTrain999");
				sprintf(cb_data[2]->fileName,"%s","babyDinosaurDooly");

				sprintf(cb_data[3]->fileName,"%s","ThreeBears");
				sprintf(cb_data[4]->fileName,"%s","IslandBaby");

				cb_data[0]->ad = ad;
				cb_data[1]->ad = ad;
				cb_data[2]->ad = ad;
				cb_data[3]->ad = ad;
				cb_data[4]->ad = ad;


				elm_list_item_append(list,"JackRabbit", NULL, NULL, list_clicked_cb, (void *)cb_data[0]);
		      	elm_list_item_append(list,"spaceTrain999", NULL, NULL, list_clicked_cb, (void *)cb_data[1]);
		    	elm_list_item_append(list,"babyDinosaurDooly", NULL, NULL, list_clicked_cb, (void *)cb_data[2]);
		    	elm_list_item_append(list,"ThreeBears", NULL, NULL, list_clicked_cb, (void *)cb_data[3]);
		    	elm_list_item_append(list,"IslandBaby", NULL, NULL, list_clicked_cb, (void *)cb_data[4]);

		      	// strcpy(ad->fileName,dirName[cnt]);


				////////else 팝업 띄우기/////////////////////////////////////////////////////////////////


			elm_list_go(list);
			/* This button is set for devices which doesn't have H/W back key. */
			btn = elm_button_add(nf);
			elm_object_style_set(btn, "naviframe/end_btn/default");

			elm_object_content_set(scroller, list);

			return list;
}


void
pop_midiList_cb(void *data, Evas_Object *obj, void *event_info)
{
	appdata_s *ad = (appdata_s *)data;
	Evas_Object *list_view;

	/* No Content view */
	list_view = create_midiList_view(ad);
	elm_naviframe_item_push(ad->nf, "", NULL, NULL, list_view, NULL);
}




static long readvar(mf_reader *mfile)
{
  long v = 0;
  int c;

  if ((c = fgetc(mfile->file)) == EOF) return -1;

  while (c & 0x80 ) {
    v = (v << 7) | (c & 0x7f);
    if ((c = fgetc(mfile->file)) == EOF) return -1;
  }
  v = (v << 7) | c;
  return (v);
}

static long readnum(mf_reader *mfile,int k)
{
  long x = 0, v = 0;

  if (k == 0) return(readvar(mfile));

  while (k-- > 0) {
    if ((x = fgetc(mfile->file)) == EOF) return -1;
    v = (v << 8) | x;
  }


  return v;
}

//Made By MIDI Three Reader Team
static long getMidBitTimeTempo(mf_reader *mfile)
{
	long bitcal = 0;
	int n = 3;
	long c;
	while (n-- > 0 ) {

		if((c = fgetc(mfile->file))==EOF) return NULL;
	    bitcal = bitcal | c;
	    if(n!=0)
	    	bitcal = bitcal << 8;

	}

	return bitcal;

}



static unsigned char *chrbuf_set(mf_reader *mfile, long sz)
{
  unsigned char *t = NULL;
  if (sz > mfile->chrbuf_sz) {
    t = realloc(mfile->chrbuf, sz);
    if (t) {
      mfile->chrbuf    = t;
      mfile->chrbuf_sz = sz;
    }
  }
  return mfile->chrbuf;
}

static unsigned char *readmsg(mf_reader *mfile, long n)
{
  int   c;
  unsigned char *s;

  if (n == 0) return (unsigned char *)"";

  chrbuf_set(mfile, n);
  if (mfile->chrbuf_sz < n) return NULL;

  s = mfile->chrbuf;
  while (n-- > 0) {   /*** Read the message ***/
    if ((c = fgetc(mfile->file)) == EOF) return NULL;
    *s++ = c;
  }

  return mfile->chrbuf;
}



int mf_scan(mf_reader *mfile)
{
  long tmp;
  long v1, v2;
  long PPQN;
  int ERROR = 0;
  long track_time;
  long tracklen;
  long ntracks;
  long curtrack = 0;
  long status = 0;
  unsigned char *msg;
  long chan;
  long midiTimeTempo = 0;
  double midiTime;

  STATE(mthd) {
    if (readnum(mfile, 4) != MThd) FAIL(110);
    tmp = readnum(mfile, 4); /* chunk length */
    if (tmp < 6) FAIL(111);
    v1 = readnum(mfile,2);
    ntracks = readnum(mfile,2);
    PPQN = readnum(mfile,2);
    ERROR = mfile->on_header(v1, ntracks, PPQN);
    if (ERROR) FAIL(ERROR);
    if (tmp > 6) readnum(mfile,tmp-6);
    GOTO(mtrk);
  }

  STATE(mtrk) {
    if (curtrack++ == ntracks) GOTOEND;
    if (readnum(mfile,4) != MTrk) FAIL(120);
    tracklen = readnum(mfile,4);
    if (tracklen < 0) FAIL(121);
    track_time = 0;
    status = 0;
    ERROR = mfile->on_track(0, curtrack, tracklen);
    if (ERROR) FAIL(ERROR);
    GOTO(event);
  }

  STATE(event) {
    tmp = readnum(mfile,0); if (tmp < 0) FAIL(211);
    track_time += tmp;

    tmp = readnum(mfile,1); if (tmp < 0) FAIL(212);

    if ((tmp & 0x80) == 0) {
      if (status == 0) FAIL(223); /* running status not allowed! */
      GOTO(midi_evt);
    }

    status = tmp;
    v1 = -1;
    if (status == 0xFF) GOTO(meta_evt);
    if (status == 0xF0) GOTO(sys_evt);
    if (status == 0xF7) GOTO(sys_evt);
    if (status >  0xF0) FAIL(543);
    tmp = readnum(mfile,1);
    GOTO(midi_evt);
  }

  STATE(midi_evt) {
    chan = 1+(status & 0x0F);
    v1 = tmp;
    v2 = -1;
    if (mf_numparms(status) == 2) {
      v2 = readnum(mfile,1);
      if (v2 < 0) FAIL(212);
    }

    /////////////////////악기 체인지 부분/////////////////////////////

    if(chan==1)
    {
    	tickEvent[eventIndex].tick = track_time;
    	tickEvent[eventIndex].time = midiTime*track_time;
    	tickEvent[eventIndex].tempo = midiTimeTempo;
    	tickEvent[eventIndex].intervel = v1;
    	tickEvent[eventIndex++].power = v2;
    }

    playTime += midiTime;

    ERROR = mfile->on_midi_evt(track_time, status & 0xF0, chan, v1, v2);
    if (ERROR) FAIL(ERROR);

    GOTO(event);
  }

  STATE(meta_evt) {
    v1 = readnum(mfile,1);
    if (v1 < 0) FAIL(214);
    GOTO(sys_evt);
  }

  STATE(sys_evt) {
    v2 = readnum(mfile,0);
    if (v2 < 0) FAIL(215);
////////////////////MPQN//////////////////////
    if (v1 != me_set_tempo)
    {
    	 msg = readmsg(mfile,v2);
   	     if (msg == NULL) FAIL(216);

    }
/////////////////////////////////////////////

    if (v1 == me_end_of_track) {
      ERROR = mfile->on_track(1, curtrack, track_time);
      if (ERROR) FAIL(ERROR);
      GOTO(mtrk);
    }


////////////////////MPQN////////////////////////
    if(v1 == me_set_tempo)
    {
    	midiTimeTempo = getMidBitTimeTempo(mfile);
    	midiTime = (double)midiTimeTempo/1000000/(double)PPQN;

    	tickEvent[eventIndex].tick = track_time;
    	tickEvent[eventIndex].time = midiTime;
    	tickEvent[eventIndex++].tempo = midiTimeTempo;

    }

///////////////////////////////////////////

    ERROR = mfile->on_sys_evt(track_time, status, v1, v2, msg);
    if (ERROR) FAIL(ERROR);
    status = 0;
    GOTO(event);
  }

  ON_FAIL {
    if (ERROR < 0) ERROR = -ERROR;
    mfile->on_error(ERROR, NULL);
    GOTOEND;
  }

  ON_END {
    return ERROR;
  }
}



static int mf_dmp_header (short type, short ntracks, short division)
{


  char pbuffer[100];
  sprintf(pbuffer,"HEADER: %u, %u, %u\n", type, ntracks, division);
  dlog_print(DLOG_INFO,"header",pbuffer);

  return 0;
}

static int mf_dmp_track (short eot, short tracknum, unsigned long tracklen)
{
	  char pbuffer[100];

	  sprintf(pbuffer,"TRACK %s: %d (%lu %s)\n", eot?"END":"START", tracknum, tracklen,eot?"ticks":"bytes");
	  dlog_print(DLOG_INFO,"TRACK",pbuffer);
  return 0;
}

static int mf_dmp_midi_evt(unsigned long tick, short type, short chan,
                                                  short data1, short data2)
{


	  char pbuffer[100];


  if (data2 >= 0)
  {
	  sprintf(pbuffer,"%8ld %02X %02X %02X  %02X", tick, type, chan, data1, data2);

  }
  else
	  sprintf(pbuffer,"%8ld %02X %02X %02X", tick, type, chan, data1);

  dlog_print(DLOG_INFO,"EVT",pbuffer);

  printf("\n");
  return 0;
}

static int mf_dmp_sys_evt(unsigned long tick, short type, short aux,
                                               long len, unsigned char *data)
{
  printf("%8ld %02X ", tick, type);
  if (aux >= 0) printf("%02X ", aux);
  printf("%04lX ", (unsigned long)len);
  type = (type == 0xFF && (0x01 <= aux && aux <= 0x09));
  if (type) {  while (len-- > 0) printf("%c", *data++);   }  /* ASCII */
  else      {  while (len-- > 0) printf("%02X", *data++); }  /* DATA */
  printf("\n");

  return 0;
}

static int mf_dmp_error(short err, char *msg)
{
  if (msg == NULL) msg = "";
  fprintf(stderr, "Error %03d - %s\n", err, msg);
  return err;
};

/*************************************************************/

void mf_reader_close(mf_reader *mr)
{
  if (mr) {
    if (mr->file)   fclose(mr->file);
    if (mr->chrbuf) free(mr->chrbuf);
    free(mr);
  }
}


mf_reader *mf_reader_new(char  *fname)
{
  mf_reader *mr = NULL;
  FILE      *f  = NULL;

  f = fopen(fname,"rb");
  if (f) {
    mr = malloc(sizeof(mf_reader));
    if (mr) {
      mr->file = f;

      mr->on_error    = mf_dmp_error    ;
      mr->on_header   = mf_dmp_header   ;
      mr->on_track    = mf_dmp_track    ;
      mr->on_midi_evt = mf_dmp_midi_evt ;
      mr->on_sys_evt  = mf_dmp_sys_evt  ;

      mr->chrbuf      = NULL;
      mr->chrbuf_sz   = 0;

      mr->aux = NULL;
    }
  }
  return mr;
}


int mf_read( char          *fname      , mf_fn_error   fn_error   ,
             mf_fn_header   fn_header  , mf_fn_track   fn_track   ,
             mf_fn_midi_evt fn_midi_evt, mf_fn_sys_evt fn_sys_evt  )
{
  int ret = 0;
  mf_reader  *mr;

  mr = mf_reader_new(fname);

  if (!mr) return 79;

  if (fn_error)    mr->on_error    = fn_error;
  if (fn_header)   mr->on_header   = fn_header;
  if (fn_track)    mr->on_track    = fn_track;
  if (fn_midi_evt) mr->on_midi_evt = fn_midi_evt;
  if (fn_sys_evt)  mr->on_sys_evt  = fn_sys_evt;

  ret = mf_scan(mr);

  mf_reader_close(mr);

  return ret;
}




static Eina_Bool
_my_animation_callback(void *data, double pos)
{
   Evas_Object *obj = data; // Get the target object
   int x, y, w, h; // Target object geometry
   double frame = pos; // Actual position variation
   // Get frame relative position depending on desired effect
   frame = ecore_animator_pos_map(pos, ECORE_POS_MAP_BOUNCE, 1.8, 7);
   evas_object_geometry_get(obj, &x, &y, &w, &h); // Get current object position and size attributes
   evas_object_move(obj,x-SPEED, y); // Move the Evas object according to desired effect
   return EINA_TRUE;
}

static
create_ball(Evas_Object *layout,double x,long y,double width,int count)
{
	Evas *e;
	Evas_Object *label,*bg;

	e = evas_object_evas_get(layout);
	img[count] = evas_object_rectangle_add(e);
	//Here we set the rectangles red, green, blue and opacity levels
	evas_object_color_set(img[count], 132, 205, 194, 255); // opaque white background
	evas_object_resize(img[count], width, 25); // covers full canvas
	evas_object_move(img[count],x,430-y);
	evas_object_show(img[count]);

	animator[count]=ecore_animator_timeline_add(200,_my_animation_callback, img[count]);

}
void statsInput(int score, char grade, char *fileName)
{
	FILE *f;
	char filePathBuffer[255];
	 // sprintf(filePathBuffer,"/opt/usr/media/Music/perfectStats.dat");
    sprintf(filePathBuffer,"%s/perfectStats.dat",app_get_data_path());

		//dlog_print(DLOG_INFO,"June",fileName);
		//dlog_print(DLOG_INFO,"June",score);
		//dlog_print(DLOG_INFO,"June",grade);

	f = fopen(filePathBuffer,"r");
	if(!f)
	{

		f= fopen(filePathBuffer,"w");
		fprintf(f,"%d %c %s \r\n",score,grade,fileName);
		fprintf(f,"-1 F -1 \r\n");
		fprintf(f,"-1 F -1 \r\n");
		fprintf(f,"%d %c %s \r\n",score,grade,fileName);
		fclose(f);
	}
	else
	{
		int fScore[4];
		char fGrade[4];
		//char fName[4][255];
		char fName[4][255]={0,};



		for(int i=0;i<4;i++)
			fscanf(f,"%d %c %s",&fScore[i], &fGrade[i], &fName[i]);

		if(grade=='S')
		{
			if(fGrade[0]==grade)
			{
				if(fScore[0] < score)
				{
					fScore[0]=score;
					fGrade[0]=grade;
					strcpy(fName[0],fileName);
				}
			}
			else
			{

				fScore[0]=score;
				fGrade[0]=grade;
				strcpy(fName[0],fileName);
			}

		}
		else if(fGrade[0]>=grade)
		{
			if(fScore[0]<score)
			{
				fScore[0]=score;
				fGrade[0]=grade;
				strcpy(fName[0],fileName);

			}
		}

		for(int i=1;i<=2;i++)
		{
			fScore[i] = fScore[i+1];
			fGrade[i] = fGrade[i+1];
			strcpy(fName[i],fName[i+1]);

		}

		fScore[3]=score;
		fGrade[3]=grade;
		strcpy(fName[3],fileName);
		fclose(f);

		f=fopen(filePathBuffer,"w");
		for(int i=0;i<4;i++)
		{
			fprintf(f, "%d %c %s \r\n", fScore[i], fGrade[i], fName[i]);
		}
		fclose(f);

	}

}
static Evas_Object * draw_voice(void *data, Ecore_Thread *thread, void *msg_data)
{
	appdata_s *ad = data;
	Evas_Object* clear_text;
	perfect_song_notify_msg_data* msg = msg_data;

	Evas_Object *voiceMark = ((perfect_song_data*)(data))->mark;
	int state = msg->isHit;

	long interval = msg->detected_note->midiNum;
	Bool isClear = msg->isClear;
	//dlog_print(DLOG_INFO,"record","interval : %d state : %d",interval, state);

	bool direction;
	if(isClear)
	{
		evas_object_del(vline);
		playing_handle = NULL;
		clear_text = elm_label_add(songview);
		char text[300];
		int score;
		char grade;
		if(msg->percent >= 0.9)
		{
			sprintf(text,"<font_size=60, align=center><color=#9cd5c2>Score : %d</color></font_size></br><font_size=150, align=center>S</font_size>",msg->score);
			//gusgh
			statsInput(msg->score,'S',worldFileName);
		}
		else if(msg->percent >= 0.8)
		{
			sprintf(text,"<font_size=60, align=center><color=#52C627>Score : %d</color></font_size></br><font_size=150, align=center>A</font_size>",msg->score);
			statsInput(msg->score,'A',worldFileName);
		}
		else if(msg->percent >= 0.6)
		{
			sprintf(text,"<font_size=60, align=center><color=#406FDA>Score : %d</color></font_size></br><font_size=150, align=center>B</font_size>",msg->score);
			statsInput(msg->score,'B',worldFileName);

		}
		else if(msg->percent >= 0.5)
		{
			sprintf(text,"<font_size=60, align=center><color=#F0C809>Score : %d</color></font_size></br><font_size=150, align=center>C</font_size>",msg->score);
			statsInput(msg->score,'C',worldFileName);

		}
		else if(msg->percent >= 0.2)
		{
			sprintf(text,"<font_size=60, align=center><color=#EE6D8E>Score : %d</color></font_size></br><font_size=150, align=center>D</font_size>",msg->score);
			statsInput(msg->score,'D',worldFileName);

		}
		else
		{
			sprintf(text,"<font_size=60, align=center><color=#D43A34>Score : %d</color></font_size></br><font_size=150, align=center>F</font_size>",msg->score);
			statsInput(msg->score,'F',worldFileName);
		}

		dlog_print(DLOG_FATAL,"record","%s",text);

		elm_object_text_set(clear_text, text);
		evas_object_move(clear_text, 0, 150);
		evas_object_resize(clear_text, 800, 250);
		evas_object_show(clear_text);
		dlog_print(DLOG_ERROR,"record","Perfect song Clear");
	}
	else
	{
		evas_object_move(voiceMark,135,430-(interval-interval_min)*rate);
		if(state == UPPER)
		{
			evas_object_color_set(voiceMark, 66, 59, 59, 255);
			evas_object_move(voiceMark,135,80);

		}
		else if(state==LOWER)
		{
			evas_object_color_set(voiceMark, 66, 59, 59, 255);
			if(interval == MIDINUM_START)
			{
				dlog_print(DLOG_ERROR,"record","!! interval");
				evas_object_move(voiceMark,-50,-50);
			}
			else
				evas_object_move(voiceMark,135,455);
		}
		else if(state == WRONG)
		{
			evas_object_color_set(voiceMark, 255, 47, 47, 255);

		}
		else if(state == HIT)
		{
			evas_object_color_set(voiceMark, 126, 255, 135, 255);

		}
	}

	evas_object_show(voiceMark);
}
static player_h _player_create(char *fileName, appdata_s *ad)
{


    if(player_create(&ad->player) == PLAYER_ERROR_NONE)
    {
       char pbuffer[300];
       sprintf(pbuffer, "%s/%s.ogg", app_get_resource_path(),fileName);
        player_set_uri(ad->player, pbuffer);
        player_set_sound_type(ad->player, SOUND_TYPE_MEDIA);
        player_set_volume(ad->player, 1.0, 1.0);
        //player_set_looping(player, true);
        player_prepare(ad->player);

    }

    return ad->player;
}


static Evas_Object *
create_perfectsong_view(appdata_s *ad, char *fileName)
{
	Evas_Object *scroller;
	Evas *e;
	char pbuffer[100];
	int i;
	/* Scroller */
	scroller = elm_scroller_add(ad->nf);
	elm_scroller_bounce_set(scroller, EINA_FALSE, EINA_TRUE);
	elm_scroller_policy_set(scroller, ELM_SCROLLER_POLICY_OFF, ELM_SCROLLER_POLICY_AUTO);

	/* NoContent Layout */
	ad->layout = elm_layout_add(scroller);
	songview=ad->layout;
	//elm_layout_theme_set(layout, "layout", "application" , "default");
	//evas_object_color_set(layout,17,53,114,10);
	//evas_object_image_file_set(layout,"/opt/usr/apps/org.tizen.clock/res/images/icon_point_3.png",NULL);

	evas_object_size_hint_weight_set(ad->layout, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(ad->layout, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_object_part_text_set(ad->layout, "elm.text", "");


	elm_object_content_set(scroller, ad->layout);

	e = evas_object_evas_get(ad->layout);


	perfect_bg_top=evas_object_rectangle_add(e);
	evas_object_color_set(perfect_bg_top, 255, 136, 120, 255); // opaque white background
	evas_object_resize(perfect_bg_top, 800, 80); // covers full canvas
	evas_object_move(perfect_bg_top,0,0);
	evas_object_show(perfect_bg_top);

	perfect_bg_bottom=evas_object_rectangle_add(e);
	evas_object_color_set(perfect_bg_bottom, 254, 242, 216, 255); // opaque white background
	evas_object_resize(perfect_bg_bottom, 800, 480); // covers full canvas
	evas_object_move(perfect_bg_bottom,0,80);
	evas_object_show(perfect_bg_bottom);

	perfect_bg_canvas=evas_object_rectangle_add(e);
	evas_object_color_set(perfect_bg_canvas, 255, 255, 255, 255); // opaque white background
	evas_object_resize(perfect_bg_canvas, 800, 350); // covers full canvas
	evas_object_move(perfect_bg_canvas,0,105);
	evas_object_show(perfect_bg_canvas);

	perfect_title = elm_label_add(ad->layout);
	char text[300];
	sprintf(text,"<font_size=40><color=#FEF2D8>%s</color></font_size>",fileName);
	elm_object_text_set(perfect_title, text);
	evas_object_move(perfect_title, 345, 15);
	evas_object_resize(perfect_title, 800, 480/7);
	evas_object_show(perfect_title);
	sprintf(worldFileName,"%s",fileName);

	sprintf(pbuffer,"%s/%s.mid",app_get_resource_path(),fileName);
	eventIndex=0;
	mf_read(pbuffer,NULL,NULL,NULL,NULL,NULL);

	convertedIndex=0;
	for(i = 0; i < eventIndex; i++)
    {
		if(tickEvent[i].power>0 && tickEvent[i+1].power==0 && tickEvent[i].intervel==tickEvent[i+1].intervel)
		{
			converted[convertedIndex].appearTime=tickEvent[i].time;
			converted[convertedIndex].existTime=tickEvent[i+1].time-tickEvent[i].time;
			converted[convertedIndex].intervals=tickEvent[i].intervel-24;
			convertedIndex++;
		}
    }

	interval_min=9999;
	interval_max=0;

	for(i = 0; i < convertedIndex; i++)
    {
		if(interval_min>converted[i].intervals)
			interval_min=converted[i].intervals;
    }
	for(i = 0; i < convertedIndex; i++)
    {
		if(interval_max<converted[i].intervals)
			interval_max=converted[i].intervals;
    }
	rate = (350-25)/(interval_max-interval_min);

	//sprintf(pbuffer,"asdfasdf 최대 %ld  최소%ld  비율%ld",interval_max,interval_min,rate);
	//dlog_print(DLOG_INFO,"June",pbuffer);


	for(i = 0; i < convertedIndex; i++)
    {
		char pbuffer[200];
		//sprintf(pbuffer,"등장 : %f, 걸리는시간 : %f, 음정 : %ld\n", converted[i].appearTime,converted[i].existTime,converted[i].intervals);
		create_ball(ad->layout,120+converted[i].appearTime*(SPEED*60), (converted[i].intervals-interval_min)*rate,converted[i].existTime*160,i);
		//240
		//dlog_print(DLOG_INFO,"June",pbuffer);
    }
	//sleep(10);
	_player_create(fileName,ad);
    player_start(ad->player);
	vline = evas_object_rectangle_add(e);
	//Here we set the rectangles red, green, blue and opacity levels
	evas_object_color_set(vline, 0, 0, 0, 255); // opaque white background
	evas_object_resize(vline, 5, 350); // covers full canvas
	evas_object_move(vline,140,105);
	evas_object_show(vline);
	ad->ing=1;
	return scroller;
}
void
pop_perfectsong_cb(void *data, Evas_Object *obj, void *event_info)
{
	appdata_s *ad = (appdata_s *)data;
	Evas_Object *list_view;

	/* No Content view */

	list_view = create_midiList_view(ad);

	elm_naviframe_item_push(ad->nf, "Music List", NULL, NULL, list_view, NULL);
	pageCount++;

}

