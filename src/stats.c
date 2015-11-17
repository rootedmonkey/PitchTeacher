#include "stats.h"
Evas_Object*
create_scroller(Evas_Object *parent)
{
	Evas_Object *scroller = elm_scroller_add(parent);
	elm_object_style_set(scroller, "effect");
	elm_scroller_policy_set(scroller,ELM_SCROLLER_POLICY_OFF,ELM_SCROLLER_POLICY_AUTO);
	evas_object_show(scroller);

	return scroller;
}

static
Evas_Object *create_tuning_stats_view(appdata_s *ad)
{

	   Evas_Object *scroller,*explain;
	   Evas *e;

	   /* Scroller */
	   scroller = elm_scroller_add(ad->nf);
	   elm_scroller_bounce_set(scroller, EINA_FALSE, EINA_TRUE);
	   elm_scroller_policy_set(scroller, ELM_SCROLLER_POLICY_OFF, ELM_SCROLLER_POLICY_AUTO);
	   evas_object_color_set(scroller, 254, 242, 216, 255);

	   /* NoContent Layout */
	   ad->layout = elm_layout_add(scroller);
	   evas_object_size_hint_weight_set(ad->layout, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	   evas_object_size_hint_align_set(ad->layout, EVAS_HINT_FILL, EVAS_HINT_FILL);
	   elm_object_part_text_set(ad->layout, "elm.text", "");


	   elm_object_content_set(scroller, ad->layout);

	   e = evas_object_evas_get(ad->layout);


	   ad->perfect_bg_top=evas_object_rectangle_add(e);
	   evas_object_color_set(ad->perfect_bg_top, 255, 136, 120, 255); // opaque white background
	   evas_object_resize(ad->perfect_bg_top, 800, 80); // covers full canvas
	   evas_object_move(ad->perfect_bg_top,0,0);
	   evas_object_show(ad->perfect_bg_top);

	   ad->perfect_bg_bottom=evas_object_rectangle_add(e);
	   evas_object_color_set(ad->perfect_bg_bottom, 254, 242, 216, 255); // opaque white background
	   evas_object_resize(ad->perfect_bg_bottom, 800, 400); // covers full canvas
	   evas_object_move(ad->perfect_bg_bottom,0,80);
	   evas_object_show(ad->perfect_bg_bottom);

	   ad->stat_perfect_title = elm_label_add(ad->layout);
	   elm_object_text_set(ad->stat_perfect_title, "<font_size=40 align=center><color=#FEF2D8>Correct Pitch Record</color></font_size>");
	   evas_object_move(ad->stat_perfect_title, 0, 15);
	   evas_object_resize(ad->stat_perfect_title, 800, 480/7);
	   evas_object_show(ad->stat_perfect_title);
	   FILE *f;
	   char filePathBuffer[255];
       sprintf(filePathBuffer,"%s/tuningStats.dat",app_get_data_path());

       char levelText[5][255]={0,};
	   f = fopen(filePathBuffer,"r");
	   if(!f)
	   {
		   for(int i=0;i<5;i++)
			   sprintf(levelText[i],"<font_size=40 align=center><color=#000000>None</color></font_size>");
	   }
	   else
	   {
		  int tempTvSec[5];

	  	  for(int i=0;i<5;i++)
	  	  {
	  		  fscanf(f,"%d",&tempTvSec[i]);
	  	  }
		  fclose(f);
		  for(int i=0;i<5;i++)
		  {
			  if(tempTvSec[i]!=-1)
			  {
				  sprintf(levelText[i],"<font_size=40 align=center><color=#000000>%d sec</color></font_size>",tempTvSec[i]);

			  }
			  else
			  {
				  sprintf(levelText[i],"<font_size=40 align=center><color=#000000>None</color></font_size>");
			  }
		  }

	   }
	   ad->level[0] = elm_label_add(ad->layout);
	   elm_object_text_set(ad->level[0], "<font_size=40 align=center><color=#000000>LEVEL1</color></font_size>");
	   evas_object_move(ad->level[0], 120, 130);
	   evas_object_resize(ad->level[0], 300, 60);
	   evas_object_show(ad->level[0]);
	   ad->value[0] = elm_label_add(ad->layout);
	   elm_object_text_set(ad->value[0], levelText[0]);
	   evas_object_move(ad->value[0], 320, 130);
	   evas_object_resize(ad->value[0], 300, 60);
	   evas_object_show(ad->value[0]);

	   ad->level[1] = elm_label_add(ad->layout);
	   elm_object_text_set(ad->level[1], "<font_size=40 align=center><color=#000000>LEVEL2</color></font_size>");
	   evas_object_move(ad->level[1], 120, 190);
	   evas_object_resize(ad->level[1], 300, 60);
	   evas_object_show(ad->level[1]);
	   ad->value[1] = elm_label_add(ad->layout);
	   elm_object_text_set(ad->value[1], levelText[1]);
	   evas_object_move(ad->value[1], 320, 190);
	   evas_object_resize(ad->value[1], 300, 60);
	   evas_object_show(ad->value[1]);

	   ad->level[2] = elm_label_add(ad->layout);
	   elm_object_text_set(ad->level[2], "<font_size=40 align=center><color=#000000>LEVEL3</color></font_size>");
	   evas_object_move(ad->level[2], 120, 250);
	   evas_object_resize(ad->level[2], 300, 60);
	   evas_object_show(ad->level[2]);
	   ad->value[2] = elm_label_add(ad->layout);
	   elm_object_text_set(ad->value[2], levelText[2]);
	   evas_object_move(ad->value[2], 320, 250);
	   evas_object_resize(ad->value[2], 300, 60);
	   evas_object_show(ad->value[2]);

	   ad->level[3] = elm_label_add(ad->layout);
	   elm_object_text_set(ad->level[3], "<font_size=40 align=center><color=#000000>LEVEL4</color></font_size>");
	   evas_object_move(ad->level[3], 120, 310);
	   evas_object_resize(ad->level[3], 300, 60);
	   evas_object_show(ad->level[3]);
	   ad->value[3] = elm_label_add(ad->layout);
	   elm_object_text_set(ad->value[3], levelText[3]);
	   evas_object_move(ad->value[3], 320, 310);
	   evas_object_resize(ad->value[3], 300, 60);
	   evas_object_show(ad->value[3]);

	   ad->level[4] = elm_label_add(ad->layout);
	   elm_object_text_set(ad->level[4], "<font_size=40 align=center><color=#000000>LEVEL5</color></font_size>");
	   evas_object_move(ad->level[4], 120, 370);
	   evas_object_resize(ad->level[4], 300, 60);
	   evas_object_show(ad->level[4]);
	   ad->value[4] = elm_label_add(ad->layout);
	   elm_object_text_set(ad->value[4], levelText[4]);
	   evas_object_move(ad->value[4], 320, 370);
	   evas_object_resize(ad->value[4], 300, 60);
	   evas_object_show(ad->value[4]);

	   return scroller;

}
static
Evas_Object *create_perfectsong_stats_view(appdata_s *ad)
{


	 Evas_Object *scroller,*explain;

	   Evas *e;

	   /* Scroller */
	   scroller = elm_scroller_add(ad->nf);
	   elm_scroller_bounce_set(scroller, EINA_FALSE, EINA_TRUE);
	   elm_scroller_policy_set(scroller, ELM_SCROLLER_POLICY_OFF, ELM_SCROLLER_POLICY_AUTO);
	   evas_object_color_set(scroller, 254, 242, 216, 255);

	   /* NoContent Layout */
	   ad->layout = elm_layout_add(scroller);

	   evas_object_size_hint_weight_set(ad->layout, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	   evas_object_size_hint_align_set(ad->layout, EVAS_HINT_FILL, EVAS_HINT_FILL);
	   elm_object_part_text_set(ad->layout, "elm.text", "");


	   elm_object_content_set(scroller, ad->layout);

	   e = evas_object_evas_get(ad->layout);


	   ad->perfect_bg_top=evas_object_rectangle_add(e);
	   evas_object_color_set(ad->perfect_bg_top, 255, 136, 120, 255); // opaque white background
	   evas_object_resize(ad->perfect_bg_top, 800, 80); // covers full canvas
	   evas_object_move(ad->perfect_bg_top,0,0);
	   evas_object_show(ad->perfect_bg_top);

	   ad->perfect_bg_bottom=evas_object_rectangle_add(e);
	   evas_object_color_set(ad->perfect_bg_bottom, 254, 242, 216, 255); // opaque white background
	   evas_object_resize(ad->perfect_bg_bottom, 800, 400); // covers full canvas
	   evas_object_move(ad->perfect_bg_bottom,0,80);
	   evas_object_show(ad->perfect_bg_bottom);

	   ad->stat_perfect_title = elm_label_add(ad->layout);
	   elm_object_text_set(ad->stat_perfect_title, "<font_size=40 align=center><color=#FEF2D8>Perfect Song Record</color></font_size>");
	   evas_object_move(ad->stat_perfect_title, 0, 15);
	   evas_object_resize(ad->stat_perfect_title, 800, 480/7);
	   evas_object_show(ad->stat_perfect_title);

	   ad->recent_list = elm_label_add(ad->layout);
	   elm_object_text_set(ad->recent_list, "<font_size=50 align=center><color=#000000>Recent</color></font_size>");
	   evas_object_move(ad->recent_list, 50, 100);
	   evas_object_resize(ad->recent_list, 300, 60);
	   evas_object_show(ad->recent_list);

	   ad->col_title = elm_label_add(ad->layout);
	   elm_object_text_set(ad->col_title, "<font_size=30 align=center><color=#000000>Music</color></font_size>");
	   evas_object_move(ad->col_title, 50, 160);
	   evas_object_resize(ad->col_title, 100, 50);
	   evas_object_show(ad->col_title);

	   ad->col_score = elm_label_add(ad->layout);
	   elm_object_text_set(ad->col_score, "<font_size=30 align=center><color=#000000>Score</color></font_size>");
	   evas_object_move(ad->col_score, 150, 160);
	   evas_object_resize(ad->col_score, 100, 50);
	   evas_object_show(ad->col_score);

	   ad->col_grade = elm_label_add(ad->layout);
	   elm_object_text_set(ad->col_grade, "<font_size=30 align=center><color=#000000>Grade</color></font_size>");
	   evas_object_move(ad->col_grade, 250, 160);
	   evas_object_resize(ad->col_grade, 100, 50);
	   evas_object_show(ad->col_grade);

	   ad->title_1 = elm_label_add(ad->layout);ad->score_1 = elm_label_add(ad->layout);ad->grade_1 = elm_label_add(ad->layout);
	   ad->title_2 = elm_label_add(ad->layout);ad->score_2 = elm_label_add(ad->layout);ad->grade_2 = elm_label_add(ad->layout);
	   ad->title_3 = elm_label_add(ad->layout);ad->score_3 = elm_label_add(ad->layout);ad->grade_3 = elm_label_add(ad->layout);

	   evas_object_resize(ad->title_1, 100, 50);evas_object_resize(ad->score_1, 100, 50);evas_object_resize(ad->grade_1, 100, 50);
	   evas_object_resize(ad->title_2, 100, 50);evas_object_resize(ad->score_2, 100, 50);evas_object_resize(ad->grade_2, 100, 50);
	   evas_object_resize(ad->title_3, 100, 50);evas_object_resize(ad->score_3, 100, 50);evas_object_resize(ad->grade_3, 100, 50);

	   evas_object_move(ad->title_1, 50, 200);evas_object_move(ad->score_1, 150, 200);evas_object_move(ad->grade_1, 250, 200);
	   evas_object_move(ad->title_2, 50, 250);evas_object_move(ad->score_2, 150, 250);evas_object_move(ad->grade_2, 250, 250);
	   evas_object_move(ad->title_3, 50, 300);evas_object_move(ad->score_3, 150, 300);evas_object_move(ad->grade_3, 250, 300);

	   char titleLabel[3][255] = {0,};
	   char scoreLabel[3][255] = {0,};
	   char gradeLabel[3][255] = {0,};
	   char kingLabel[3][255]={0,};//0 ->tltle /1->score/ 2->grade
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
	   		for(int i=0;i<3;i++)
	   		{
	   			sprintf(scoreLabel[i],"<font_size=20 align=center><color=#000000>None</color></font_size>");
	   		}
				sprintf(kingLabel[1],"<font_size=20 align=center><color=#000000>None</color></font_size>");

	   	}
	   	else
	   	{
	   		int fScore[4];
	   		char fGrade[4];
	   		char fName[4][255]={0,};

	   		for(int i=0;i<4;i++)
	   			fscanf(f,"%d %c %s",&fScore[i], &fGrade[i], &fName[i]);
	   		for(int i=0;i<3;i++)
	   		{
	   			if(fScore[i+1]!=-1)
	   		 	{
	   				if(strlen(fName[i+1])<12)
	   					sprintf(titleLabel[i],"<font_size=22 ><color=#000000>%s</color></font_size>",fName[i+1]);
	   				else
	   				{
	   					fName[i+1][9]='.';
	   					fName[i+1][10]='.';
	   					fName[i+1][11]='.';
	   					fName[i+1][12]='.';
	   					fName[i+1][13]='.';

	   					sprintf(titleLabel[i],"<font_size=20 ><color=#000000>%s</color></font_size>",fName[i+1]);
	   				}
	   				sprintf(scoreLabel[i],"<font_size=20 align=center><color=#000000>%d</color></font_size>",fScore[i+1]);
	   				sprintf(gradeLabel[i],"<font_size=20 align=center><color=#000000>%c</color></font_size>",fGrade[i+1]);
	   		 	}
	   			else
	   			{
	   				sprintf(scoreLabel[i],"<font_size=30 align=center><color=#000000>None</color></font_size>");
	   			}
	   		}
	   		if(strlen(fName[0])<12)
	   			sprintf(kingLabel[0],"<font_size=22 ><color=#000000>%s</color></font_size>",fName[0]);
	   		else
	   		{

	   			fName[0][9]='.';
	   			fName[0][10]='.';
	   			fName[0][11]='.';
	   			fName[0][12]='.';
	   			fName[0][13]='.';

	   			sprintf(kingLabel[0],"<font_size=20 ><color=#000000>%s</color></font_size>",fName[0]);

	   		}
	   		sprintf(kingLabel[1],"<font_size=20 align=center><color=#000000>%d</color></font_size>",fScore[0]);
	   		sprintf(kingLabel[2],"<font_size=20 align=center><color=#000000>%c</color></font_size>",fGrade[0]);

	   	}


	   elm_object_text_set(ad->title_1, titleLabel[0]);
	   elm_object_text_set(ad->title_2, titleLabel[1]);
	   elm_object_text_set(ad->title_3, titleLabel[2]);

	   elm_object_text_set(ad->score_1, scoreLabel[0]);
	   elm_object_text_set(ad->score_2, scoreLabel[1]);
	   elm_object_text_set(ad->score_3, scoreLabel[2]);
	   elm_object_text_set(ad->grade_1, gradeLabel[0]);
	   elm_object_text_set(ad->grade_2, gradeLabel[1]);
	   elm_object_text_set(ad->grade_3, gradeLabel[2]);

	   evas_object_show(ad->title_1);evas_object_show(ad->score_1);evas_object_show(ad->grade_1);
	   evas_object_show(ad->title_2);evas_object_show(ad->score_2);evas_object_show(ad->grade_2);
	   evas_object_show(ad->title_3);evas_object_show(ad->score_3);evas_object_show(ad->grade_3);

	   ad->section_king=elm_label_add(ad->layout);
	   evas_object_resize(ad->section_king,400,100);
	   evas_object_move(ad->section_king,400,150);
	   elm_object_text_set(ad->section_king, "<font_size=50 align=center><color=#000000>High Score</color></font_size>");
	   evas_object_show(ad->section_king);

	   ad->img_king = elm_image_add(ad->layout);
	   elm_image_file_set(ad->img_king, "/opt/usr/apps/org.samteam.perfectsong/res/crown.png", NULL);
	   evas_object_move(ad->img_king, 420, 155); //이쪽 손봐줘~!~!
	   evas_object_resize(ad->img_king, 50, 50);
	   evas_object_show(ad->img_king);



	   ad->col_title_king = elm_label_add(ad->layout);ad->col_score_king = elm_label_add(ad->layout);ad->col_grade_king = elm_label_add(ad->layout);
	   ad->title_king = elm_label_add(ad->layout);ad->score_king = elm_label_add(ad->layout);ad->grade_king = elm_label_add(ad->layout);
	   evas_object_resize(ad->col_title_king, 100, 50);evas_object_resize(ad->col_score_king, 100, 50);evas_object_resize(ad->col_grade_king, 100, 50);
	   evas_object_resize(ad->title_king, 100, 50);evas_object_resize(ad->score_king, 100, 50);evas_object_resize(ad->grade_king, 100, 50);
	   evas_object_move(ad->col_title_king, 450, 210);evas_object_move(ad->col_score_king, 550,210);evas_object_move(ad->col_grade_king, 650, 210);
	   evas_object_move(ad->title_king, 450, 250);evas_object_move(ad->score_king, 550, 250);evas_object_move(ad->grade_king, 650, 250);
	   elm_object_text_set(ad->col_title_king, "<font_size=30 align=center><color=#000000>Music</color></font_size>");
	   elm_object_text_set(ad->col_score_king, "<font_size=30 align=center><color=#000000>Score</color></font_size>");
	   elm_object_text_set(ad->col_grade_king, "<font_size=30 align=center><color=#000000>Grade</color></font_size>");

	   elm_object_text_set(ad->title_king, kingLabel[0]);

	   elm_object_text_set(ad->score_king, kingLabel[1]);
	   elm_object_text_set(ad->grade_king, kingLabel[2]);
	   evas_object_show(ad->col_title_king);evas_object_show(ad->col_score_king);evas_object_show(ad->col_grade_king);
	   evas_object_show(ad->title_king);evas_object_show(ad->score_king);evas_object_show(ad->grade_king);

	   return scroller;
}

void
tuning_stats_cb(void *data, Evas_Object *obj, void *event_info)
{
	Evas_Object *tuningBox;
	appdata_s *ad = (appdata_s *)data;
	tuningBox = create_tuning_stats_view(ad);
	elm_naviframe_item_push(ad->nf, "", NULL, NULL, tuningBox, NULL);
	ad->currentPage=3;
}


void
perfectsong_stats_cb(void *data, Evas_Object *obj, void *event_info)
{
	Evas_Object *perfectsongStatsBox;
	appdata_s *ad = (appdata_s *)data;
	perfectsongStatsBox = create_perfectsong_stats_view(ad);
	elm_naviframe_item_push(ad->nf, "", NULL, NULL, perfectsongStatsBox, NULL);
	ad->currentPage=3;

}
