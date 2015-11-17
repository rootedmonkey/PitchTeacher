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

#include <tizen.h>
#include "project.h"
#include "perfectsong.h"
#include "tuning.h"
#include "stats.h"
#include "mf_rw.h"

static Evas_Object*
create_bg(Evas_Object *parent, int r,int g,int b)
{
	Evas_Object *bg;

	bg = elm_bg_add(parent);
	evas_object_size_hint_weight_set(bg, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(bg, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_bg_color_set(bg, r, g, b);
	evas_object_show(bg);

	return bg;
}

static Evas_Object*
create_img(Evas_Object *parent, char *filename)
{
	Evas_Object *img;
	char buf[PATH_MAX];

	img = elm_image_add(parent);
	snprintf(buf, sizeof(buf), "%s/%s", ICON_DIR, filename);
	elm_image_file_set(img, buf, NULL);
	evas_object_show(img);

	return img;
}


static Evas_Object*
create_btn(Evas_Object *parent, char *text)
{
	Evas_Object *btn,*img;
	Evas *e;
	char buf[PATH_MAX];


	btn = elm_button_add(parent);
	evas_object_size_hint_weight_set(btn, EVAS_HINT_EXPAND, 0.0);
	//evas_object_size_hint_align_set(btn, 0.5, 1);
	evas_object_size_hint_align_set(btn, EVAS_HINT_FILL,EVAS_HINT_FILL);
	evas_object_size_hint_min_set(btn,800,0);
	snprintf(buf, sizeof(buf), "%s", text);
	elm_object_text_set(btn, buf);
	evas_object_show(btn);


/*	e = evas_object_evas_get(parent);
	// Create an image object
	img = evas_object_image_filled_add(e);
	// Set a source file to fetch pixel data
	evas_object_image_file_set(img, ICON_DIR"/icon_mic_1.png", NULL);
	// Set the size and position of the image on the image object area
	evas_object_move(img, 0, 0);
	evas_object_resize(img, 100, 100);
	evas_object_show(img);*/

	return btn;
}

static Eina_Bool
naviframe_pop_cb(void *data, Elm_Object_Item *it)
{
	Evas_Object *win = (Evas_Object *)data;

	elm_win_lower(win);

	return EINA_FALSE;
}

static char*
gl_text_get_cb(void *data, Evas_Object *obj, const char *part)
{
	item_data_s *id = data;
	char buf[1024];

	if (id->index == 0) {
		if (!strcmp(part, "elm.text.main.left.top")) {
			snprintf(buf, 1023, "%s", "07:26");
			return strdup(buf);
		}
		else if (!strcmp(part, "elm.text.sub.right.top")) {
			snprintf(buf, 1023, "%s", "Cardiff");
			return strdup(buf);
		}
		else if (!strcmp(part, "elm.text.sub.left.bottom")) {
			snprintf(buf, 1023, "%s", "Wed, Jan 1");
			return strdup(buf);
		}
		else if (!strcmp(part, "elm.text.sub.right.bottom")) {
			snprintf(buf, 1023, "%s", "wales");
			return strdup(buf);
		}
	}

	if (id->index == 1) {
			if (!strcmp(part, "elm.text.main.left.top")) {
				snprintf(buf, 1023, "%s", "08:26");
				return strdup(buf);
			}
			else if (!strcmp(part, "elm.text.sub.right.top")) {
				snprintf(buf, 1023, "%s", "Hong Kong");
				return strdup(buf);
			}
			else if (!strcmp(part, "elm.text.sub.left.bottom")) {
				snprintf(buf, 1023, "%s", "Wed, Jan 1");
				return strdup(buf);
			}
			else if (!strcmp(part, "elm.text.sub.right.bottom")) {
				snprintf(buf, 1023, "%s", "China");
				return strdup(buf);
			}
		}

	if (id->index == 2) {
			if (!strcmp(part, "elm.text.main.left.top")) {
				snprintf(buf, 1023, "%s", "09:26");
				return strdup(buf);
			}
			else if (!strcmp(part, "elm.text.sub.right.top")) {
				snprintf(buf, 1023, "%s", "Tokyo");
				return strdup(buf);
			}
			else if (!strcmp(part, "elm.text.sub.left.bottom")) {
				snprintf(buf, 1023, "%s", "Wed, Jan 1");
				return strdup(buf);
			}
			else if (!strcmp(part, "elm.text.sub.right.bottom")) {
				snprintf(buf, 1023, "%s", "Japan");
				return strdup(buf);
			}
		}

	return NULL;
}


static Evas_Object*
create_stats_ready_view(appdata_s *ad)
{
   Evas_Object *box, *grid1, *bg1, *label1, *label2, *grid2, *label3, *btn1,*btn2;
   Evas_Object *img;

   box = elm_box_add(ad->nf);
   evas_object_size_hint_weight_set(box, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
   evas_object_size_hint_align_set(box, EVAS_HINT_FILL, EVAS_HINT_FILL);

   grid1 = elm_grid_add(box);
   evas_object_size_hint_weight_set(grid1, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
   evas_object_size_hint_align_set(grid1, EVAS_HINT_FILL, EVAS_HINT_FILL);
   //evas_object_size_hint_min_set(grid1, -1, ELM_SCALE_SIZE(265));
   evas_object_show(grid1);

   bg1 = create_bg(grid1, 25,189,196);
   elm_grid_pack(grid1, bg1, 0, 0, 100, 200);
   img = elm_image_add(grid1);
   elm_image_file_set(img,ICON_DIR"/stats_main.png", NULL);
   evas_object_show(img);
   elm_grid_pack(grid1,img,8,10,80,80);

   elm_box_pack_end(box, grid1);
   btn1 = create_btn(box, "Perfect Song Score");
   btn2 = create_btn(box, "Correct Pitch Score");

   elm_grid_pack(grid1,btn1,0,86,50,14);
   elm_grid_pack(grid1,btn2,50,86,50,14);


   evas_object_smart_callback_add(btn1, "clicked", perfectsong_stats_cb, ad);
   evas_object_smart_callback_add(btn2, "clicked", tuning_stats_cb, ad);
   elm_object_content_set(box,bg1);
   //elm_box_pack_end(box, btn1);
   //elm_box_pack_end(box, btn2);

   return box;
}




static Evas_Object*
create_perfectsong_ready_view(appdata_s *ad)
{

	Evas_Object *box, *grid1,*grid2,*btn;
	Evas_Object *image;
	Evas_Object *bg1,*img1,*img2,*img3;
	Evas_Object *flip;
	Evas *e;

	box = elm_box_add(ad->nf);
	evas_object_size_hint_weight_set(box, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(box, EVAS_HINT_FILL, EVAS_HINT_FILL);


	grid1 = elm_grid_add(box);
	evas_object_size_hint_weight_set(grid1, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(grid1, EVAS_HINT_FILL, EVAS_HINT_FILL);
	//evas_object_size_hint_min_set(grid1, -1, ELM_SCALE_SIZE(265));
	evas_object_show(grid1);
	bg1 = create_bg(box,25,189,196);
	elm_grid_pack(grid1, bg1, 0, 0, 100, 200);

	img1 = elm_image_add(grid1);
	elm_image_file_set(img1,ICON_DIR"/explain2-2.png", NULL);
	evas_object_show(img1);
	elm_grid_pack(grid1,img1,3,10,50,80);


	img2 = elm_image_add(grid1);
	elm_image_file_set(img2,ICON_DIR"/explain3-3.png", NULL);
	evas_object_show(img2);
	elm_grid_pack(grid1,img2,47,10,50,80);
/*	dlog_print(DLOG_FATAL,"rrss","flip before");
	flip = elm_flip_add(grid1);
	evas_object_show(flip);

	elm_grid_pack(grid1, flip, 0, 0, 100, 100);
	elm_object_part_content_set(flip, "front", img1);
	elm_object_part_content_set(flip, "back", img2);
	elm_flip_interaction_set(flip, ELM_FLIP_INTERACTION_CUBE);
	elm_flip_interaction_direction_enabled_set(flip, ELM_FLIP_DIRECTION_LEFT, EINA_TRUE);
	elm_flip_interaction_direction_enabled_set(flip, ELM_FLIP_DIRECTION_RIGHT, EINA_TRUE);
	elm_flip_interaction_direction_hitsize_set(flip, ELM_FLIP_DIRECTION_LEFT, 1);
	elm_flip_interaction_direction_hitsize_set(flip, ELM_FLIP_DIRECTION_RIGHT, 1);*/
	//elm_flip_go_to(flip,EINA_FALSE,ELM_FLIP_CUBE_LEFT);

	btn = create_btn(box, "START!");
	evas_object_smart_callback_add(btn, "clicked", pop_perfectsong_cb, ad);
	//evas_object_size_hint_max_set(btn,800,50);
	elm_object_content_set(box,bg1);
	elm_box_pack_end(box, grid1);
	//elm_box_pack_end(box, grid2);
	elm_box_pack_end(box, btn);


	// Create an image object
	return box;
}

static Evas_Object*
create_tuning_ready_view(appdata_s *ad)
{
	Evas_Object *list, *box, *grid1, *bg1, *label1, *label2, *grid2, *label3, *btn;
	Evas_Object *img;

	box = elm_box_add(ad->nf);
	evas_object_size_hint_weight_set(box, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(box, EVAS_HINT_FILL, EVAS_HINT_FILL);

	grid1 = elm_grid_add(box);
	evas_object_size_hint_weight_set(grid1, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(grid1, EVAS_HINT_FILL, EVAS_HINT_FILL);
	//evas_object_size_hint_min_set(grid1, -1, ELM_SCALE_SIZE(265));
	evas_object_show(grid1);

	bg1 = create_bg(grid1, 25,189,196);
	elm_grid_pack(grid1, bg1, 0, 0, 100, 200);

	img = elm_image_add(grid1);
	elm_image_file_set(img,ICON_DIR"/tune_main.png", NULL);
	evas_object_show(img);
	elm_grid_pack(grid1,img,8,10,80,80);



	elm_box_pack_end(box, grid1);
	//elm_box_pack_end(box, grid2);

/*	e = evas_object_evas_get(box);
	btn_enter = evas_object_image_filled_add(e);
	// Set a source file to fetch pixel data
	evas_object_image_file_set(btn_enter, ICON_DIR"/moo.png", NULL);
	// Set the size and position of the image on the image object area
	evas_object_move(btn_enter,0, 400);
	evas_object_resize(btn_enter, 800, 80);
	evas_object_show(btn_enter);
	evas_object_event_callback_add(btn_enter,EVAS_CALLBACK_MOUSE_UP,tuning_cb,ad);*/

	btn = create_btn(box, "START!");
	evas_object_smart_callback_add(btn, "clicked", tuning_cb, ad);
	//evas_object_size_hint_max_set(btn,800,50);
	elm_object_content_set(box,bg1);
	//elm_box_pack_end(box, grid2);
	elm_box_pack_end(box, btn);

	viewdata_s *vd = calloc(1, sizeof(viewdata_s));
	ad->vd = vd;
	ad->vd->grid1 = grid1;
	ad->vd->grid2 = grid2;
	ad->vd->label1 = label1;
	ad->vd->label2 = label2;
	ad->vd->label3 = label3;

	return box;
}

Evas_Object*
create_content(Evas_Object* parent,char* str)
{
	Evas_Object* item = create_btn(parent,str);
	return item;
}

static void
tabbar_item_selected(appdata_s *ad, Elm_Object_Item *it)
{
	Evas_Object *sub_view;
	const char *str = NULL;

	str = elm_object_item_text_get(it);

	if (str && !strcmp(str, " Correct Pitch")) {
		sub_view = create_tuning_ready_view(ad);
	}
	else if (str && !strcmp(str, " My Record")) {
			sub_view = create_stats_ready_view(ad);
	}
	else {
			sub_view = create_perfectsong_ready_view(ad);
	}

	elm_object_content_set(ad->nf, sub_view);
}

static void
tabbar_item_cb(void *data, Evas_Object *obj, void *event_info)
{
	appdata_s *ad = data;
	Elm_Object_Item *it;

	it = event_info;

	tabbar_item_selected(ad, it);
}

static void
rotation_cb(void *data, Evas_Object *obj, void *event_info)
{
	appdata_s *ad = data;
	Elm_Object_Item *it;
	const char *str = NULL;
	ad->current_degree = elm_win_rotation_get(obj);

	it = elm_toolbar_selected_item_get(ad->tabbar);
	str = elm_object_item_text_get(it);

	if (ad->current_degree != 0 && ad->current_degree != 180 && !strcmp(str, "World Clock")) {
		elm_grid_pack_set(ad->vd->label1, 33, 16, 100, 100);
		elm_grid_pack_set(ad->vd->label2, 40, 58, 100, 100);
		elm_grid_pack_set(ad->vd->label3, 41, 69, 100, 100);
	}
	else
		tabbar_item_selected(ad, it);
}

static Evas_Object*
create_toolbar(appdata_s *ad)
{
	Evas_Object *tabbar;

	Evas_Object *bg; //

	tabbar = elm_toolbar_add(ad->nf);
	elm_object_style_set(tabbar, "tabbar");

	// Use red color for background
	elm_toolbar_shrink_mode_set(tabbar, ELM_TOOLBAR_SHRINK_NONE);
	elm_toolbar_transverse_expanded_set(tabbar, EINA_TRUE);
	elm_toolbar_select_mode_set(tabbar, ELM_OBJECT_SELECT_MODE_ALWAYS);

	elm_toolbar_item_append(tabbar, ICON_DIR"/icon_mic_1.png", " Perfect Song", tabbar_item_cb, ad);
	elm_toolbar_item_append(tabbar, ICON_DIR"/icon_tune_1.png", " Correct Pitch", tabbar_item_cb, ad);
	elm_toolbar_item_append(tabbar, ICON_DIR"/icon_rank_1.png", " My Record", tabbar_item_cb, ad);

	return tabbar;
}
static inline void
eext_naviframe_back2_cb(void *data, Evas_Object *obj, void *event_info)
{
	int i;
	void* res = NULL;
	appdata_s *ad = (appdata_s *)data;
	if(ad->currentPage == 1)
	{
		dlog_print(DLOG_FATAL,"record","tunning button Callback");
		// tuning back btn callback
		if(tuning_playing_handle!=NULL)
		{
			tuning_playing_handle->aid->isRunning = FALSE;
			usleep(200000);	// 0.2 sec
			//destroy_correct_pitch_data(tuning_playing_handle);


		}

	}
	else if(ad->currentPage==2)
	{
		dlog_print(DLOG_FATAL,"record","perfectsong button Callback");
		if(playing_handle!=NULL)
		{
			playing_handle->aid->isRunning = FALSE;
			usleep(200000);
		}
		for(i=0;i<convertedIndex;i++)
		{
			evas_object_hide(img[i]);
		}
		for(i=0;i<convertedIndex;i++)
		{
			do
			{
				res=ecore_animator_del(animator[i]);
			}while(res==NULL);
			evas_object_del(img[i]);
		}

		dlog_print(DLOG_ERROR,"asdf","%d",vline);
		evas_object_del(vline);
		evas_object_del(perfect_bg_bottom);
		evas_object_del(perfect_bg_top);
		evas_object_del(perfect_title);
		evas_object_del(perfect_bg_canvas);
		dlog_print(DLOG_ERROR,"asdf","%d",vline);
		player_stop(ad->player);
		player_destroy(ad->player);
	}
	elm_naviframe_item_pop(obj);
	if(ad->currentPage==3)
	{
		for(int i=0;i<5;i++)
		{
			evas_object_hide(ad->level[i]);
			evas_object_hide(ad->value[i]);
		}
		evas_object_hide(ad->recent_list);
		evas_object_hide(ad->col_title);
		evas_object_hide(ad->col_score);
		evas_object_hide(ad->col_grade);
		evas_object_hide(ad->title_1);
		evas_object_hide(ad->score_1);
		evas_object_hide(ad->grade_1);
		evas_object_hide(ad->title_2);
		evas_object_hide(ad->score_2);
		evas_object_hide(ad->grade_2);
		evas_object_hide(ad->title_3);
		evas_object_hide(ad->score_3);
		evas_object_hide(ad->grade_3);
		evas_object_hide(ad->title_king);
		evas_object_hide(ad->score_king);
		evas_object_hide(ad->grade_king);
		evas_object_hide(ad->img_king);
		evas_object_hide(ad->col_title_king);
		evas_object_hide(ad->col_score_king);
		evas_object_hide(ad->col_grade_king);
		//evas_object_hide(ad->stat_perfect_title_king);
		evas_object_hide(ad->section_king);
		evas_object_hide(ad->stat_perfect_title);
		evas_object_hide(ad->perfect_bg_bottom);
		evas_object_hide(ad->perfect_bg_top);
	}

	ad->currentPage = 0;

	pageCount--;
	dlog_print(DLOG_ERROR,"asdf","escape");
}



static void
win_back_cb(void *data, Evas_Object *obj, void *event_info)
{
	appdata_s *ad = data;
	/* Let window go to hide state. */

	elm_win_lower(ad->win);
}

static void
win_delete_request_cb(void *data, Evas_Object *obj, void *event_info)
{
	ui_app_exit();
}

static void
create_base_gui(appdata_s *ad)
{
	Evas_Object *bg = NULL;
	Elm_Object_Item *nf_it, *tabbar_it;

	/* Window */
	ad->win = elm_win_util_standard_add(PACKAGE, PACKAGE);
	elm_win_conformant_set(ad->win, EINA_TRUE);
	elm_win_autodel_set(ad->win, EINA_TRUE);

	if (elm_win_wm_rotation_supported_get(ad->win)) {
		int rots[4] = { 270, 270, 270, 270 };
		elm_win_wm_rotation_available_rotations_set(ad->win, (const int *)(&rots), 4);
	}

	evas_object_smart_callback_add(ad->win, "wm,rotation,changed", rotation_cb, ad);
	evas_object_smart_callback_add(ad->win, "delete,request", win_delete_request_cb, NULL);
	//eext_object_event_callback_add(ad->win, EEXT_CALLBACK_BACK, win_back_cb, ad);

	/* Conformant */
	ad->conform = elm_conformant_add(ad->win);
	elm_win_indicator_mode_set(ad->win, ELM_WIN_INDICATOR_SHOW);
	elm_win_indicator_opacity_set(ad->win, ELM_WIN_INDICATOR_OPAQUE);
	evas_object_size_hint_weight_set(ad->conform, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_win_resize_object_add(ad->win, ad->conform);
	evas_object_show(ad->conform);

	/* Indicator BG */
	bg = elm_bg_add(ad->conform);
	elm_object_style_set(bg, "indicator/headerbg");
	elm_object_part_content_set(ad->conform, "", bg);
	evas_object_show(bg);

	/* Naviframe */
	ad->nf = elm_naviframe_add(ad->conform);
	eext_object_event_callback_add(ad->nf, EEXT_CALLBACK_BACK, eext_naviframe_back2_cb, ad);
	evas_object_size_hint_weight_set(ad->nf, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_object_content_set(ad->conform, ad->nf);


	nf_it = elm_naviframe_item_push(ad->nf, NULL, NULL, NULL, NULL, "tabbar/icon/notitle");
	elm_naviframe_item_pop_cb_set(nf_it, naviframe_pop_cb, ad->win);

	/* Tabbar */
	ad->tabbar = create_toolbar(ad);
	elm_object_item_part_content_set(nf_it, "tabbar", ad->tabbar);

	/* Set the first view */
	tabbar_it = elm_toolbar_first_item_get(ad->tabbar);
	elm_toolbar_item_selected_set(tabbar_it, EINA_TRUE);


	/* Show window after base gui is set up */
	evas_object_show(ad->win);
}

static void *
changed_callback(device_callback_e type, void *value, void *user_data)
{
	 device_display_change_state(DISPLAY_STATE_NORMAL);

}

static bool
app_create(void *data)
{
	/* Hook to take necessary actions before main event loop starts
		Initialize UI resources and application's data
		If this function returns true, the main loop of application starts
		If this function returns false, the application is terminated */
	appdata_s *ad = data;

	elm_app_base_scale_set(1.8);
    create_base_gui(ad);
    init_audio();
	device_add_callback(DISPLAY_STATE_SCREEN_DIM,changed_callback,&ad);
    device_power_wakeup(false);
    device_power_release_lock(POWER_LOCK_DISPLAY_DIM);
    device_power_request_lock(POWER_LOCK_DISPLAY,0);
    return true;
}

static void
app_control(app_control_h app_control, void *data)
{
	/* Handle the launch request. */
}

static void
app_pause(void *data)
{
	int i;
	appdata_s *ad = data;
	//ad->mainAid
	/* Take necessary actions when application becomes invisible. */
	if(ad->ing==1)
	{
		eext_naviframe_back2_cb(data,ad->nf,NULL);
	}
}

static void
app_resume(void *data)
{
	appdata_s *ad = data;
	/* Take necessary actions when application becomes visible. */
	if(ad->ing==1)
	{
		Evas_Object *popup;
		popup = elm_popup_add(ad->nf);
		elm_object_style_set(popup, "toast");
		elm_object_part_text_set(popup, "default", "detector is canceled because of  interruption");
		elm_popup_timeout_set(popup, 3.0);
		evas_object_show(popup);
		ad->ing=0;
	}
}

static void
app_terminate(void *data)
{
	appdata_s *ad = data;
	if(ad->stat_perfect_title!=0)
		{
			for(int i=0;i<5;i++)
			{
				evas_object_del(ad->level[i]);
				evas_object_del(ad->value[i]);
			}
			evas_object_del(ad->recent_list);
			evas_object_del(ad->col_title);
			evas_object_del(ad->col_score);
			evas_object_del(ad->col_grade);
			evas_object_del(ad->title_1);
			evas_object_del(ad->score_1);
			evas_object_del(ad->grade_1);
			evas_object_del(ad->title_2);
			evas_object_del(ad->score_2);
			evas_object_del(ad->grade_2);
			evas_object_del(ad->title_3);
			evas_object_del(ad->score_3);
			evas_object_del(ad->grade_3);
			evas_object_del(ad->title_king);
			evas_object_del(ad->score_king);
			evas_object_del(ad->grade_king);
			evas_object_del(ad->img_king);
			evas_object_del(ad->col_title_king);
			evas_object_del(ad->col_score_king);
			evas_object_del(ad->col_grade_king);
			//evas_object_del(ad->stat_perfect_title_king);
			evas_object_del(ad->section_king);
			evas_object_del(ad->stat_perfect_title);
			evas_object_del(ad->perfect_bg_bottom);
			evas_object_del(ad->perfect_bg_top);
		}

	/* Release all resources. */
	destroy_audio();
}

static void
ui_app_lang_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LANGUAGE_CHANGED*/
	char *locale = NULL;
	system_settings_get_value_string(SYSTEM_SETTINGS_KEY_LOCALE_LANGUAGE, &locale);
	elm_language_set(locale);
	free(locale);
	return;
}

static void
ui_app_orient_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_DEVICE_ORIENTATION_CHANGED*/
	return;
}

static void
ui_app_region_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_REGION_FORMAT_CHANGED*/
}

static void
ui_app_low_battery(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LOW_BATTERY*/
}

static void
ui_app_low_memory(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LOW_MEMORY*/
}

int
main(int argc, char *argv[])
{
	appdata_s ad = {0,};
	int ret = 0;

	ui_app_lifecycle_callback_s event_callback = {0,};
	app_event_handler_h handlers[5] = {NULL, };

	event_callback.create = app_create;
	event_callback.terminate = app_terminate;
	event_callback.pause = app_pause;
	event_callback.resume = app_resume;
	event_callback.app_control = app_control;

	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_BATTERY], APP_EVENT_LOW_BATTERY, ui_app_low_battery, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_MEMORY], APP_EVENT_LOW_MEMORY, ui_app_low_memory, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_DEVICE_ORIENTATION_CHANGED], APP_EVENT_DEVICE_ORIENTATION_CHANGED, ui_app_orient_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LANGUAGE_CHANGED], APP_EVENT_LANGUAGE_CHANGED, ui_app_lang_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_REGION_FORMAT_CHANGED], APP_EVENT_REGION_FORMAT_CHANGED, ui_app_region_changed, &ad);
	ui_app_remove_event_handler(handlers[APP_EVENT_LOW_MEMORY]);

	ret = ui_app_main(argc, argv, &event_callback, &ad);
	if (ret != APP_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "ui_app_main() is failed. err = %d", ret);
	}

	return ret;
}
