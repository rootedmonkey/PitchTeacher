/*
 * mf_rw.h
 *
 *  Created on: Jul 7, 2015
 *      Author: dgssm
 */

#ifndef MF_RW_H
#define MF_RW_H

#include <stdio.h>
#include <stdlib.h>
#include <ctype.h>
#include <strings.h>

typedef int (*mf_fn_error   ) (short err, char *msg);
typedef int (*mf_fn_header  ) (short type, short ntracks, short division);
typedef int (*mf_fn_track   ) (short eot, short tracknum, unsigned long tracklen);
typedef int (*mf_fn_midi_evt) (unsigned long delta, short type, short chan,
                                              short data1, short data2);
typedef int (*mf_fn_sys_evt ) (unsigned long delta, short type, short aux,
                                              long len, unsigned char *data);


typedef struct {
  FILE            *file        ;
  unsigned char   *chrbuf      ;
  unsigned long    chrbuf_sz   ;
  mf_fn_error      on_error    ;
  mf_fn_header     on_header   ;
  mf_fn_track      on_track    ;
  mf_fn_midi_evt   on_midi_evt ;
  mf_fn_sys_evt    on_sys_evt  ;
  void            *aux;
} mf_reader;


static double _initial_time = 0;

typedef struct {

	long tick; //midi tick
	double time; // 미디 플레이 할때 실제 시간
	long tempo; // FF 51 XX XX XX 의 정보
    long intervel; // 음정
    long power; // 세기
    long status; // 90 등등

} TickEvent;

int mf_scan(mf_reader *mfile);

void mf_reader_close(mf_reader *mr);

int mf_read( char           *fname       ,
             mf_fn_error     fn_error    ,
             mf_fn_header    fn_header   ,
             mf_fn_track     fn_track    ,
             mf_fn_midi_evt  fn_midi_evt ,
             mf_fn_sys_evt   fn_sys_evt
           );


#define cc_bank_select                     0x00
#define cc_modulation_wheel                0x01
#define cc_breath_controller               0x02
#define cc_foot_controller                 0x04
#define cc_portamento_time                 0x05
#define cc_data_entry                      0x06
#define cc_channel_volume                  0x07
#define cc_balance                         0x08
#define cc_pan                             0x0a
#define cc_expression_controller           0x0b
#define cc_effect_control1                 0x0c
#define cc_effect_control2                 0x0d
#define cc_bank_select_lsb                 0x20
#define cc_modulation_wheel_lsb            0x21
#define cc_breath_controller_lsb           0x22
#define cc_foot_controller_lsb             0x24
#define cc_portamento_lsb                  0x25
#define cc_data_entry_lsb                  0x26
#define cc_channel_volume_lsb              0x27
#define cc_balance_lsb                     0x28
#define cc_pan_lsb                         0x2a
#define cc_expression_controller_lsb       0x2b
#define cc_effect_control1_lsb             0x2c
#define cc_effect_control2_lsb             0x2d
#define cc_damper_pedal                    0x40
#define cc_portamento                      0x41
#define cc_sostenuto                       0x42
#define cc_soft_pedal                      0x43
#define cc_legato                          0x44
#define cc_hold_2                          0x45
#define cc_sound_variation                 0x46
#define cc_timbre_intensity                0x47
#define cc_harmonic_intensity              0x47
#define cc_release_time                    0x48
#define cc_attack_time                     0x49
#define cc_brightness                      0x4a
#define cc_decay_time                      0x4b
#define cc_vibrato_rate                    0x4c
#define cc_vibrato_depth                   0x4d
#define cc_vibrato_delay                   0x4e
#define cc_portamento_control              0x54
#define cc_reverb_send                     0x5b
#define cc_tremolo_depth                   0x5c
#define cc_chorus_send                     0x5d
#define cc_detune                          0x5e
#define cc_phaser_depth                    0x5f
#define cc_data_increment                  0x60
#define cc_data_decrement                  0x61
#define cc_non_registered_number_lsb       0x62
#define cc_non_registered_number           0x63
#define cc_registered_number_lsb           0x64
#define cc_registered_number               0x65
#define cc_all_sound_off                   0x78
#define cc_reset_all_controllers           0x79
#define cc_local_control                   0x7a
#define cc_all_notes_off                   0x7b
#define cc_omni_mode_off                   0x7c
#define cc_omni_mode_on                    0x7d
#define cc_mono_mode_on                    0x7e
#define cc_poly_mode_off                   0x7e
#define cc_poly_mode_on                    0x7f
#define cc_mono_mode_off                   0x7f

/* Registered parameter number */
#define cc_pitch_bend_sensitivity          0x80
#define cc_channel_fine_tuning             0x81
#define cc_channel_coarse_tuning           0x82
#define cc_tuning_program                  0x83
#define cc_tuning_bank                     0x84
#define cc_modulation_depth_range          0x85
#define cc_rpn_reset                       0xFF


#define cc_nrpn(h,l) ((((h) &0x7F)<<8) | ((l)&0x7F) | 0x8000)
#define cc_rpn(h,l)  ((((h) &0x7F)<<8) | ((l)&0x7F) | 0x0080)

#define st_note_off                0x80
#define st_note_on                 0x90
#define st_key_pressure            0xA0
#define st_control_change          0xB0
#define st_program_change          0xC0
#define st_channel_pressure        0xD0
#define st_pitch_bend              0xE0
#define st_system_exclusive        0xF0
#define st_system_continue         0xF7
#define st_meta_event              0xFF

#define me_sequence_number         0x00

#define me_text                    0x01
#define me_copyright_notice        0x02
#define me_sequence_name           0x03
#define me_track_name              0x03
#define me_instrument_name         0x04
#define me_lyric                   0x05
#define me_marker                  0x06
#define me_cue_point               0x07
#define me_device_name             0x08
#define me_program_name            0x09

#define me_end_of_track            0x2f
#define me_set_tempo               0x51
#define me_smpte_offset            0x54
#define me_time_signature          0x58
#define me_key_signature           0x59
#define me_sequencer_specific      0x7F
#define me_channel_prefix          0x20
#define me_port_prefix             0x21


int mf_numparms(int s);

#endif
