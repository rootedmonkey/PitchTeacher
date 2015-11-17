/*
 * pitch_detector.c
 *
 *  Created on: Jul 30, 2015
 *      Author: SungHoon
 *
 *   1. voiced/unvoiced Decision
 *   2. pre-processing
 *   3. autocorrelation
 *   4. pitch detect
 */

//TODO: envelope, lowpass filter, pitch detect

#include "pitch_detector.h"

/*
 *  pre-processing
 */
double avreage(short* buffer,const int FRAME_SIZE)
{
	double avg = 0;
	for(int i=0;i<FRAME_SIZE;i++)
	{
		avg+=buffer[i];
	}
	avg/=FRAME_SIZE;
	return avg;
}
double short_time_energy(short* buffer, const int FRAME_SIZE, double avg)
{
	double eng = 0;
	double tmp;
	for(int i=0;i<FRAME_SIZE;i++)
	{
		tmp = buffer[i]-avg;
		eng+= (tmp*tmp)/FRAME_SIZE;
	}

	return eng;
}
double zero_crossing_rate(short* buffer, const int FRAME_SIZE)
{
	double zcr = 0;
	for(int i=0;i<FRAME_SIZE;i++)
	{
		if( (buffer[i])*(buffer[i+1]) < 0)
			zcr++;
	}
	zcr/=FRAME_SIZE;
	return zcr;
}
void lowpass_filter()
{

}
void envelop()
{

}
void half_rectifier(short* buffer, const int FRAME_SIZE)
{
	for(int i=0;i<FRAME_SIZE;i++)
	{
		if(buffer[i] < 0)
			buffer[i] = 0;
	}
}
void autocorrelation(short* buffer, double* acr, const int FRAME_SIZE)
{
	double tmp;

	for(int k=0;k<FRAME_SIZE;k++)
	{
		tmp = 0;
		for(int m=0;m<FRAME_SIZE-k-1;m++)
		{
			tmp += buffer[m]*buffer[m+k];
		}
		acr[k] = tmp / FRAME_SIZE;
	}
}
int get_peak_index(short* buffer, double* acr, const int FRAME_SIZE)
{
	int max_peak_value=0, max_peak_index=0;
		Bool peak = FALSE;

		for(int i=MIN_SAMPLES;i<FRAME_SIZE-1;i++)
		{
			if(peak)
			{
				if(acr[i] < acr[i+1])
				{
					peak=FALSE;
					if(acr[i]>max_peak_value)
					{
						max_peak_value = acr[i];
						max_peak_index = i;
					}
				}
			}
			else
			{
				if(acr[i] >= acr[i+1])
					continue;
				else
					peak=TRUE;
			}
		}

	return max_peak_index;
}
double get_frequency(short* samples, double* acr, const int FRAME_SIZE, const int SAMPLE_RATE, const int ENERGY_LIMIT, const double ZERO_CROSS_LIMIT)
{
	short* buffer = (short*)malloc(sizeof(short)*FRAME_SIZE);
	for(int i=0;i<FRAME_SIZE;i++)
	{
		buffer[i] = samples[i];
	}

	double avg = avreage(buffer,FRAME_SIZE);

	double eng = short_time_energy(buffer,FRAME_SIZE,avg);
	if(eng < ENERGY_LIMIT)
	{
		//dlog_print(DLOG_INFO,"record","[eng] = eng : %lf zcr : x",eng);
		return -1;
	}
	double zcr = zero_crossing_rate(buffer,FRAME_SIZE);

	if(zcr > ZERO_CROSS_LIMIT)
	{
		//dlog_print(DLOG_INFO,"record","[zcr] = eng : %lf zcr : %lf",eng,zcr);
		return -1;
	}

	half_rectifier(buffer,FRAME_SIZE);
	autocorrelation(buffer,acr,FRAME_SIZE);

	int peak_index = get_peak_index(buffer,acr,FRAME_SIZE);

	double freq = SAMPLE_RATE/peak_index;

	//dlog_print(DLOG_INFO,"record","freq : %.2lf Hz eng : %lf zcr : %lf",freq,eng,zcr);

	free(buffer);
	return freq;
}
