/*
 * note.c
 *
 *  Created on: Aug 6, 2015
 *      Author: SungHoon
 */


#include "note.h"
#include <math.h>

/**
 * Note Lookup Table
 **/
const Note _const_notes[]=
	{
	// 0 Octav
	{27.5,"A0","La",21},{29.1,"A#0","La#",22},{30.8,"B0","Si",23},
	// 1 Octav
	{32.7,"C1","Do",24},{34.6,"C#1","Do#",25},{36.7,"D1","Re",26},{38.8,"D#1","Re#",27},{41.2,"E1","Mi",28},{43.6,"F1","Fa",29},
	{46.2,"F#1","Fa#",30},{49.0,"G1","Sol",31},{51.9,"G#1","Sol#",32},{55.0,"A1","La",33},{58.3,"A#1","La#",34},{61.7,"B1","Si",35},
	// 2 Octav
	{65.4,"C2","Do",36},{69.3,"C#2","Do#",37},{73.4,"D2","Re",38},{77.8,"D#2","Re#",39},{82.4,"E2","Mi",40},{87.3,"F2","Fa",41},
	{92.5,"F#2","Fa#",42},{98.0,"G2","Sol",43},{103.8,"G#2","Sol#",44},{110.0,"A2","La",45},{116.5,"A#2","La#",46},{123.5,"B2","Si",47},
	// 3 Octav
	{130.8,"C3","Do",48},{138.6,"C#3","Do#",49},{146.8,"D3","Re ",50},{155.6,"D#3","Re#",51},{164.8,"E3","Mi",52},{174.6,"F3","Fa",53},
	{185.0,"F#3","Fa#",54},{196.0,"G3","Sol",55},{207.7,"G#3","Sol#",56},{220.0,"A3","La",57},{233.1,"A#3","La#",58},{246.9,"B3","Si",59},
	// 4 Octav
	{261.6,"C4","Do",60},{277.2,"C#4","Do#",61},{293.7,"D4","Re",62},{311.1,"D#4","Re#",63},{329.6,"E4","Mi",64},{349.2,"F4","Fa",65},
	{370.0,"F#4","Fa#",66},{392.0,"G4","Sol",67},{415.3,"G#4","Sol#",68},{440.0,"A4","La",69},{466.2,"A#4","La#",70},{493.9,"B4","Si",71},
	// 5 Octav
	{523.3,"C5","Do",72},{554.4,"C#5","Do#",73},{587.3,"D5","Re",74},{622.3,"D#5","Re#",75},{659.3,"E5","Mi",76},{698.5,"F5","Fa",77},
	{740.0,"F#5","Fa#",78},{784.0,"G5","Sol",79},{830.6,"G#5","Sol#",80},{880.0,"A5","La",81},{932.3,"A#5","La#",82},{987.8,"B5","Si",83},
	// 6 Octav
	{1046.5,"C6","Do",84},{1108.7,"C#6","Do#",85},{1174.7,"D6","Re",86},{1244.5,"D#6","Re#",87},{1318.5,"E6","Mi",88},{1396.9,"F6","Fa",89},
	{1480.0,"F#6","Fa#",90},{1568.0,"G6","Sol",91},{1661.2,"G#6","Sol#",91},{1760.0,"A6","La",93},{1864.7,"A#6","La#",94},{1975.5,"B6","Si",95},
	// 7 Octav
	{2093.0,"C7","Do",96},{2217.5,"C#7","Do#",97},{2349.3,"D7","Re",98},{2489.0,"D#7","Re#",99},{2637.0,"E7","Mi",100},{2793.8,"F7","Fa",101},
	{2960.0,"F#7","Fa#",102},{3136.0,"G7","Sol",103},{3322.4,"G#7","Sol#",104},{3520.0,"A7","La",105},{3729.3,"A#7","La#",106},{3951.1,"B7","Si",107}
	};

const Note NULL_NOTE = {0,"","",0};

Note getNoteObject(double freq)
{
	int size = sizeof(_const_notes) / sizeof(Note);
	double bef, aft;
	for (int i = 1; i < size; i++) {
		if (freq >  _const_notes[i].freq)
			continue;

		aft = _const_notes[i].freq - freq;
		bef = abs(_const_notes[i-1].freq - freq);

		if (bef < aft)
			return _const_notes[i-1];
		else
			return _const_notes[i];
	}
	return _const_notes[0];
}
Note getNoteFromMidinum(unsigned int midinum)
{
	if(midinum >= MIDINUM_START && midinum <= MIDINUM_END)
		return _const_notes[midinum-MIDINUM_START];
	else
		return NULL_NOTE;
}
