/*
 * record.h
 *
 *  Created on: Aug 13, 2015
 *      Author: dgssm
 */

#ifndef RECORD_H_
#define RECORD_H_

#include <tizen.h>
#include "project.h"
void tuning_stats_cb(void *data, Evas_Object *obj, void *event_info);
void perfectsong_stats_cb(void *data, Evas_Object *obj, void *event_info);

static Evas_Object *create_tuning_stats_view(appdata_s *data);
static Evas_Object *create_perfectsong_stats_view(appdata_s *data);
Evas_Object *create_scroller(Evas_Object *parent);

#endif
