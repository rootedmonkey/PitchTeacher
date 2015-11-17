/*
 * note.h
 *
 *  Created on: Aug 6, 2015
 *      Author: SungHoon
 */

#ifndef NOTE_H_
#define NOTE_H_

#define MIDINUM_START 21
#define MIDINUM_END 107

typedef struct Note{
	double freq;
	char note[4];
	char kor[8];
	unsigned int midiNum;
}Note;

Note getNoteObject(double freq);
Note getNoteFromMidinum(unsigned int midinum);

#endif /* NOTE_H_ */
