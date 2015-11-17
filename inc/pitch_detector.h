/*
 * pitch_detector.h
 *
 *  Created on: Jul 30, 2015
 *      Author: SungHoon
 */

#ifndef PITCH_DETECTOR_H_
#define PITCH_DETECTOR_H_

#include <dlog.h>
#include <stdlib.h>

typedef int Bool;

#define TRUE 1
#define FALSE 0

#define MIN_SAMPLES 4

double avreage(short* buffer,const int FRAME_SIZE);
double short_time_energy(short* buffer, const int FRAME_SIZE, double avg);
double zero_crossing_rate(short* buffer, const int FRAME_SIZE);
void lowpass_filter();	// TODO:
void envelop();			// TODO:
void half_rectifier(short* buffer, const int FRAME_SIZE);
void autocorrelation(short* buffer, double* acr, const int FRAME_SIZE);
int get_peak_index(short* buffer, double* acr, const int FRAME_SIZE);
double get_frequency(short* samples, double* acr, const int FRAME_SIZE, const int SAMPLE_RATE, const int ENERGY_LIMIT, const double ZERO_CROSS_LIMIT);


#endif /* PITCH_DETECTOR_H_ */
