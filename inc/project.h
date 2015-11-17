/*
 * Copyright (c) 2014 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the License);
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an AS IS BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

#ifndef __PROJECT_H__
#define __PROJECT_H__



#include <app.h>
#include <system_settings.h>
#include <Elementary.h>
#include <efl_extension.h>
#include <dlog.h>
#include <player.h>
#include "correct_pitch.h"
#include <device/display.h>
#include <device/callback.h>
#include <device/power.h>
#if !defined(PACKAGE)
#define PACKAGE "org.tizen.clock"
#define ICON_DIR "/opt/usr/apps/org.samteam.perfectsong/res/images"


typedef struct posData{

	int x;
	int y;
	double startTime;

} Pos;


typedef struct viewdata {
	Evas_Object *grid1;
	Evas_Object *grid2;
	Evas_Object *label1;
	Evas_Object *label2;
	Evas_Object *label3;
} viewdata_s;

typedef struct appdata {
	Evas_Object *win;
	Evas_Object *layout;
	Evas_Object *conform;
	Evas_Object *label;
	Evas_Object *nf;
	Evas_Object *tabbar;
	Evas_Object *flip;
	Evas_Object *btn_enter;
	Evas_Object *perfect_bg_bottom;
	Evas_Object *perfect_bg_top;
    player_h player;
    char fileName[255];
    int currentPage;
	int current_degree;
	viewdata_s *vd;
	Evas_Object *interval[3000];//음정
	Pos pos[3000];//음정의 애니메이션 좌표
	Ecore_Animator *anim; //애니메이션 관련 객체
	Evas_Object *layout2;
	Evas_Object *col_title,*col_score,*col_grade,*stat_perfect_title,*recent_list;
	Evas_Object *level[5],*value[5];
   Evas_Object *title_1,*score_1,*grade_1;
   Evas_Object *title_2,*score_2,*grade_2;
  Evas_Object *title_3,*score_3,*grade_3;
	Evas_Object *title_king,*score_king,*grade_king,*img_king;
	Evas_Object *col_title_king,*col_score_king,*col_grade_king,*stat_perfect_title_king,*section_king;
	audio_input_data* mainAid;
	int ing;
} appdata_s;


typedef struct item_data {
	int index;
	Elm_Object_Item *item;
} item_data_s;

static Ecore_Animator* animator[30000];
static Evas_Object *img[30000];
static Evas_Object *perfect_bg_bottom,*perfect_bg_top, *perfect_title,*vline,*perfect_bg_canvas,*btn_enter;
static int convertedIndex=0;
static int eventIndex = 0;
static double playTime = 0;
static int animation_complete=0;
static int pageCount=0;
static void
list_selected_cb(void *data, Evas_Object *obj, void *event_info)
{
	Elm_Object_Item *it = event_info;
	elm_list_item_selected_set(it, EINA_FALSE);
}

#endif

#ifdef  LOG_TAG
#undef  LOG_TAG
#endif
#define LOG_TAG "clock"




#endif
