
#ifndef PERGECT_SONG_H_
#define PERGECT_SONG_H_

#include <tizen.h>
#include "project.h"
#include "mf_rw.h"
#include "mididl.h"
#include "correct_pitch.h"
#include <player.h>

#define SPEED 5
#define MThd 0x4d546864
#define MTrk 0x4d54726b

static TickEvent tickEvent[30000];
static noteInfo converted[30000];
Evas_Object *songview;
long rate;
long interval_min,interval_max;
char worldFileName[255];

perfect_song_data* playing_handle;



typedef struct message
{
		appdata_s* ad;
		char fileName[256];
}dataSet;

typedef int (*YourCallback)(int s);
void pop_midiList_cb(void *data, Evas_Object *obj, void *event_info);

//Made By MIDI Three Reader Team



#define STATE(x)     x##_: if (0) goto x##_;
#define GOTO(x)      goto x##_
#define FAIL(e)      do {ERROR = e; goto fail_; } while(0)
#define ON_FAIL      fail_:
#define ON_END       FINAL_:
#define FINAL        FINAL_
#define GOTOEND      GOTO(FINAL)
#define FALLTHROUGH  do {ERROR=ERROR;} while (0)

int mf_scan(mf_reader *mfile);

void mf_reader_close(mf_reader *mr);
mf_reader *mf_reader_new(char  *fname);
int mf_read( char          *fname      , mf_fn_error   fn_error   ,
             mf_fn_header   fn_header  , mf_fn_track   fn_track   ,
             mf_fn_midi_evt fn_midi_evt, mf_fn_sys_evt fn_sys_evt  );
void statsInput(int score, char grade, char *fileName);
static Evas_Object *draw_voice(void *data, Ecore_Thread *thread, void *msg_data);
static Evas_Object *create_perfectsong_view(appdata_s *ad, char *fileName);
void pop_perfectsong_cb(void *data, Evas_Object *obj, void *event_info);

#endif	// PERGECT_SONG_H_
