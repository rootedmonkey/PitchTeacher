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
#include "tuning.h"

int t_level = 0;
static player_h effect_create(char *fileName)
{

	player_h effect;
    if(player_create(&effect) == PLAYER_ERROR_NONE)
    {
       char pbuffer[300];
       sprintf(pbuffer, "%s%s.wav", app_get_resource_path(),fileName);
       dlog_print(DLOG_FATAL,"rrss",pbuffer);
       player_set_uri(effect, pbuffer);
        player_set_sound_type(effect, SOUND_TYPE_MEDIA);
        player_set_volume(effect, 1.0, 1.0);
       // player_set_looping(effect, true);
        player_prepare(effect);

    }

    return effect;
}
void labels_update_cb(void *data, Ecore_Thread *thread, void *msg_data)
{
   notify_msg_data* msg = msg_data;
   char strBuffer[256];
   player_h effect;

   if(msg->isClear)
   {
      gettimeofday(&tval_end,0);
      timersub(&tval_end, &tval_start, &tval_result);

      if(tval_result.tv_sec < 5)
    	  return;

      evas_object_hide(explain);
	  evas_object_hide(detected_syllable);
	  evas_object_del(img1);evas_object_del(img2);
	  evas_object_hide(vline);
	  sprintf(strBuffer,"<font_size=50 align=center><color=#FF0000>Clear!!!</br> Time : %dsec</color></font_size>", tval_result.tv_sec);
	  dlog_print(DLOG_FATAL,"record",strBuffer);
	  elm_object_text_set(syllable, strBuffer);
	  evas_object_show(syllable);
	  elm_grid_pack(grid1, syllable,0,40, 100, 100);
	  tuning_playing_handle = NULL;
	  FILE *f;
	  char filePathBuffer[255];
	//  sprintf(filePathBuffer,"/opt/usr/media/Music/tuningStats.dat");
	  sprintf(filePathBuffer,"%s/tuningStats.dat",app_get_data_path());


	  int tempTvSec[5] = {-1,-1,-1,-1,-1};

	  f = fopen(filePathBuffer,"r");

	  if(!f)
	  {
		 f = fopen(filePathBuffer,"w");
		 for(int i=0;i<5;i++)
			 fprintf(f,"%d ",tempTvSec[5]);
	  }

	  for(int i=0;i<5;i++)
	  {
			  fscanf(f,"%d",&tempTvSec[i]);
	  }
	  fclose(f);


	  if((tempTvSec[t_level-1]>tval_result.tv_sec) || tempTvSec[t_level-1]==-1)
	  {
		  tempTvSec[t_level-1]=tval_result.tv_sec;

	  }
	  f= fopen(filePathBuffer,"w");
	  for(int i=0;i<5;i++)
	   fprintf(f,"%d ", tempTvSec[i]);
	  fclose(f);



	 return;
   }
   if(msg->isPass)
   {
	  effect = effect_create("PASS1");
	  player_start(effect);
	  //pass_step = elm_image_add(grid1);
	  //elm_image_file_set(pass_step,ICON_DIR"/pass1.png", NULL);
	  //evas_object_show(pass_step);
	  elm_grid_pack(grid1,pass_step,65,30,15,15);
	  //sleep(2);

      sprintf(strBuffer,"<font_size=53><color=#000000>%s(%s)</color></font_size>", msg->note->kor,msg->note->note);
      dlog_print(DLOG_FATAL,"record",strBuffer);
      elm_object_text_set(syllable, strBuffer);
      evas_object_show(syllable);
      elm_grid_pack(grid1, syllable, 48, 30, 100, 100);

   }
   else
   {

	 //pass_hide = elm_image_add(grid1);
	  //elm_image_file_set(pass_hide,ICON_DIR"/passhide.jpg", NULL);
	 //evas_object_show(pass_hide);
	  //elm_grid_pack(grid1,pass_hide,65,30,15,15);

      if(msg->isRight)
      {

         sprintf(strBuffer,"<font_size=53><color=#006699>%s(%s)</color></font_size>", msg->detected_note->kor,msg->detected_note->note);
         elm_object_text_set(detected_syllable, strBuffer);
         evas_object_show(detected_syllable);
         elm_grid_pack(grid1, detected_syllable, 48, 60, 100, 100);

      }
      else
      {
    	 if(msg->detected_note->midiNum == MIDINUM_START)
    		 sprintf(strBuffer,"<font_size=53><color=#FF3333>-</color></font_size>");
    	 else
    		 sprintf(strBuffer,"<font_size=53><color=#FF3333>%s(%s)</color></font_size>", msg->detected_note->kor,msg->detected_note->note);
         elm_object_text_set(detected_syllable, strBuffer);
         evas_object_show(detected_syllable);
         elm_grid_pack(grid1, detected_syllable, 48, 60, 100, 100);
      }
   }

}
Evas_Object *
create_level_view(void *data, int level)
{
	appdata_s *ad = data;
	//init_audio();
	box = elm_box_add(ad);
	evas_object_size_hint_weight_set(box, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(box, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_show(box);
	grid1 = elm_grid_add(box);
	evas_object_size_hint_weight_set(grid1, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(grid1, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_show(grid1);

	syllable = elm_label_add(grid1);
	detected_syllable = elm_label_add(grid1);


	switch(level)
	{
		case 1:
			t_level = 1;
			tuning_playing_handle = lv1_start(labels_update_cb);
			break;
		case 2:
			t_level = 2;
			tuning_playing_handle = lv2_start(labels_update_cb);
			break;
		case 3:
			t_level = 3;
			tuning_playing_handle = lv3_start(labels_update_cb);
			break;
		case 4:
			t_level = 4;
			tuning_playing_handle = lv4_start(labels_update_cb);
			break;
		case 5:
			t_level = 5;
			tuning_playing_handle = lv5_start(labels_update_cb);
			break;
	}

	ad->mainAid = tuning_playing_handle->aid;
	gettimeofday(&tval_start,0);
	char strBuffer[256];

	explain = elm_label_add(grid1);
	elm_object_text_set(explain,"<font_size=33 align=center><color=#000000>Keep Note for 1sec!</color></font_size>");
	evas_object_show(explain);
	elm_grid_pack(grid1,explain,0,10,100,100);
	// 첫 시작 화면
	syllable = elm_label_add(grid1);
	detected_syllable = elm_label_add(grid1);
	Note* ns = tuning_playing_handle->notes;
	sprintf(strBuffer,"<font_size=53><color=#000000>%s(%s)</color></font_size>", ns->kor,ns->note);
	elm_object_text_set(syllable, strBuffer);
	evas_object_show(syllable);
	elm_grid_pack(grid1, syllable, 48, 30, 100, 100);

	img1 = elm_image_add(grid1);
	elm_image_file_set(img1,ICON_DIR"/note_blue.png", NULL);
	evas_object_show(img1);
	elm_grid_pack(grid1,img1,28,30,20,20);

	img2 = elm_image_add(grid1);
	elm_image_file_set(img2,ICON_DIR"/now.png", NULL);
	evas_object_show(img2);
	elm_grid_pack(grid1,img2,28,60,20,20);

	elm_box_pack_end(box, grid1);
	return box;
}

static Evas_Object*
create_scroller(Evas_Object *parent)
{
	Evas_Object *scroller = elm_scroller_add(parent);
	elm_object_style_set(scroller, "effect");
	elm_scroller_policy_set(scroller,ELM_SCROLLER_POLICY_OFF,ELM_SCROLLER_POLICY_AUTO);
	evas_object_show(scroller);

	return scroller;
}
/*
void
label_text_styles_cb(void *data, Evas_Object *obj, void *event_info)
{
	Evas_Object *scroller, *layout_inner;
	Evas_Object *nf = data;

	scroller = create_scroller(nf);

	layout_inner = create_level_view(nf);
	elm_object_content_set(scroller, layout_inner);

	elm_naviframe_item_push(nf, "Text Styles", NULL, NULL, layout_inner, NULL);
}
*/

void
list_level1_cb(appdata_s *data, Evas_Object *obj, void *event_info)
{
	//appdata_s *ad = (appdata_s *)data;
	Evas_Object *scroller, *tuningBox;
	Evas_Object *nf = data->nf;
	data->currentPage = 1;

	scroller = create_scroller(nf);
	tuningBox = create_level_view(nf,1);
	elm_object_content_set(scroller, tuningBox);
	elm_naviframe_item_push(nf, "Level1", NULL, NULL, scroller, NULL);
//		elm_object_content_set(level1_view);
}
void
list_level2_cb(appdata_s *data, Evas_Object *obj, void *event_info)
{
	Evas_Object *scroller, *tuningBox;
	Evas_Object *nf = data->nf;

	data->currentPage = 1;

	scroller = create_scroller(nf);
	tuningBox = create_level_view(nf,2);
	elm_object_content_set(scroller, tuningBox);
	elm_naviframe_item_push(nf, "Level2", NULL, NULL, scroller, NULL);
}
void
list_level3_cb(appdata_s *data, Evas_Object *obj, void *event_info)
{
	Evas_Object *scroller, *tuningBox;
	Evas_Object *nf = data->nf;
	data->currentPage = 1;

	scroller = create_scroller(nf);
	tuningBox = create_level_view(nf,3);
	elm_object_content_set(scroller, tuningBox);
	elm_naviframe_item_push(nf, "Level3", NULL, NULL, scroller, NULL);
}
void
list_level4_cb(appdata_s *data, Evas_Object *obj, void *event_info)
{
	Evas_Object *scroller, *tuningBox;
	Evas_Object *nf = data->nf;
	data->currentPage = 1;

	scroller = create_scroller(nf);
	tuningBox = create_level_view(nf,4);
	elm_object_content_set(scroller, tuningBox);
	elm_naviframe_item_push(nf, "Level4", NULL, NULL, scroller, NULL);
}
void
list_level5_cb(appdata_s *data, Evas_Object *obj, void *event_info)
{
	Evas_Object *scroller, *tuningBox;
	Evas_Object *nf = data->nf;
	data->currentPage = 1;

	scroller = create_scroller(nf);
	tuningBox = create_level_view(nf,5);
	elm_object_content_set(scroller, tuningBox);
	elm_naviframe_item_push(nf, "Level5", NULL, NULL, scroller, NULL);
}
static Evas_Object *
create_tuning_view(appdata_s *ad)
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


		elm_list_item_append(list,"LEVEL1", NULL, NULL, list_level1_cb, ad);
		elm_list_item_append(list,"LEVEL2", NULL, NULL, list_level2_cb, ad);
		elm_list_item_append(list,"LEVEL3", NULL, NULL, list_level3_cb, ad);
		elm_list_item_append(list,"LEVEL4", NULL, NULL, list_level4_cb, ad);
		elm_list_item_append(list,"LEVEL5", NULL, NULL, list_level5_cb, ad);

		elm_list_go(list);
		/* This button is set for devices which doesn't have H/W back key. */
			btn = elm_button_add(nf);
			elm_object_style_set(btn, "naviframe/end_btn/default");

	elm_object_content_set(scroller, list);

	return list;
}

void
tuning_cb(void *data, Evas_Object *obj, void *event_info)
{
	appdata_s *ad = (appdata_s *)data;
	Evas_Object *tuning_view;

	/* No Content view */
	evas_object_del(btn_enter);
	evas_object_hide(btn_enter);
	tuning_view = create_tuning_view(ad);
	elm_naviframe_item_push(ad->nf, "Correct Pitch", NULL, NULL, tuning_view, NULL);

}
