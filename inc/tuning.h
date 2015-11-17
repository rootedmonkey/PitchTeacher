/*
 * Copyright (c) 2013 Samsung Electronics Co., Ltd All Rights Reserved
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

#include <tizen.h>
#include "project.h"

Evas_Object *box, *grid1, *bg1, *syllable, *detected_syllable,*explain,*img1,*img2,*clear;
Evas_Object *pass_step,*pass_level,*pass_hide;
struct timeval tval_start, tval_end, tval_result;

correct_pitch_data* tuning_playing_handle;

void labels_update_cb(void *data, Ecore_Thread *thread, void *msg_data);
Evas_Object *create_level_view(void *data, int level);
void list_level1_cb(appdata_s *data, Evas_Object *obj, void *event_info);
void list_level2_cb(appdata_s *data, Evas_Object *obj, void *event_info);
void list_level3_cb(appdata_s *data, Evas_Object *obj, void *event_info);
void list_level4_cb(appdata_s *data, Evas_Object *obj, void *event_info);
void list_level5_cb(appdata_s *data, Evas_Object *obj, void *event_info);
void tuning_cb(void *data, Evas_Object *obj, void *event_info);
