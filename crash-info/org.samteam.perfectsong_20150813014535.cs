S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.0
Build-Number: Z130HDDU0BOB3
Build-Date: 2015.02.14 15:10:17

Crash Information
Process Name: paaaaaaaaa
PID: 14992
Date: 2015-08-13 01:45:35+0900
Executable File Path: /opt/usr/apps/org.samteam.perfectsong/bin/paaaaaaaaa
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 14992, uid 5000)

Register Information
r0   = 0xb6d7b250, r1   = 0x00000002
r2   = 0x00000000, r3   = 0xb6d7b298
r4   = 0xb6d7b250, r5   = 0x00000020
r6   = 0x00000004, r7   = 0xb8e77790
r8   = 0x00000001, r9   = 0x00010c08
r10  = 0xb92b83f8, fp   = 0x00000018
ip   = 0xb626391c, sp   = 0xbec18e10
lr   = 0xb6cc5210, pc   = 0xb6cc0eb4
cpsr = 0xa0000010

Memory Information
MemTotal:   730748 KB
MemFree:    198928 KB
Buffers:     41344 KB
Cached:     205064 KB
VmPeak:     184340 KB
VmSize:     181836 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       26836 KB
VmRSS:       26836 KB
VmData:     113000 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       28388 KB
VmPTE:         106 KB
VmSwap:          0 KB

Threads Information
Threads: 12
PID = 14992 TID = 14992
14992 14999 15000 15002 15010 15011 15012 15015 15016 15017 15018 15019 

Maps Information
ad7c0000 adfbf000 rwxp [stack:15019]
adfbf000 adfd9000 r-xp /usr/lib/gstreamer-0.10/libgstpulse.so
adfe2000 adfeb000 r-xp /usr/lib/lib_SoundBooster_ver402_wrapped.so
adff5000 ae072000 r-xp /usr/lib/lib_SoundAlive_ver125e_wrapped.so
ae0a4000 ae0bc000 r-xp /usr/lib/libgstcontroller-0.10.so.0.30.0
ae0cb000 ae0d1000 r-xp /usr/lib/gstreamer-0.10/libgstsoundalive.so
ae0d9000 ae0e1000 r-xp /usr/lib/lib_SoundAlive_SRC192_ver204_wrapped.so
ae0ec000 ae0f1000 r-xp /usr/lib/gstreamer-0.10/libgstvolume.so
ae0f9000 ae0fc000 r-xp /usr/lib/gstreamer-0.10/libgstsecresample.so
ae105000 ae110000 r-xp /usr/lib/gstreamer-0.10/libgstaudioconvert.so
ae119000 ae11d000 r-xp /usr/lib/gstreamer-0.10/libgstaudiotp.so
ae126000 ae925000 rwxp [stack:15018]
ae926000 af125000 rwxp [stack:15017]
af125000 af14e000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
af157000 af17c000 r-xp /usr/lib/libgsttag-0.10.so.0.25.0
af185000 af1ab000 r-xp /usr/lib/gstreamer-0.10/libgstogg.so
af1b5000 af9b4000 rwxp [stack:15016]
afad9000 b02d8000 rwxp [stack:15002]
b02dc000 b02e6000 r-xp /usr/lib/libgstriff-0.10.so.0.25.0
b02f3000 b02fc000 r-xp /usr/lib/gstreamer-0.10/libgstvorbis.so
b0304000 b031c000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
b0325000 b033b000 r-xp /usr/lib/gstreamer-0.10/libgstdecodebin2.so
b0344000 b0387000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
b038f000 b03c4000 r-xp /usr/lib/gstreamer-0.10/libgstcoreelements.so
b06da000 b0ed9000 rwxp [stack:15000]
b12db000 b1ada000 rwxp [stack:14999]
b1adb000 b22da000 rwxp [stack:15010]
b22db000 b2ada000 rwxp [stack:15011]
b2c01000 b3400000 rwxp [stack:15012]
b3505000 b350f000 r-xp /usr/lib/gstreamer-0.10/libgsttypefindfunctions.so
b35cc000 b3dcb000 rwxp [stack:15015]
b3f4d000 b3f4e000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3f56000 b3f5d000 r-xp /usr/lib/libfeedback.so.0.1.4
b3f73000 b3f74000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
b3f7c000 b3f7e000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
b3f86000 b3f87000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
b3f8f000 b3fa6000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b4102000 b4106000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b410f000 b4119000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b4453000 b451d000 r-xp /usr/lib/libCOREGL.so.4.0
b452e000 b4533000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b453b000 b4540000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4549000 b454a000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4553000 b456b000 r-xp /usr/lib/libpng12.so.0.50.0
b4573000 b4576000 r-xp /usr/lib/libEGL.so.1.4
b457e000 b458c000 r-xp /usr/lib/libGLESv2.so.2.0
b4595000 b4599000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b45a2000 b45ab000 r-xp /usr/lib/libmdm-common.so.1.0.45
b45b3000 b45fb000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b45fc000 b4602000 r-xp /usr/lib/libjson.so.0.1.0
b460a000 b466b000 r-xp /usr/lib/libasound.so.2.0.0
b4675000 b4679000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
b4681000 b4684000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b468d000 b4695000 r-xp /usr/lib/libui-extension.so.0.1.0
b4696000 b4699000 r-xp /usr/lib/libnative-buffer.so.0.1.0
b46a1000 b46a4000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.22
b46ac000 b4762000 r-xp /usr/lib/libcairo.so.2.11200.14
b476d000 b477f000 r-xp /usr/lib/libtts.so
b4787000 b48c6000 r-xp /usr/lib/libicui18n.so.51.1
b48d6000 b48dc000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b48e5000 b48f2000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
b48fb000 b4903000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b490b000 b490d000 r-xp /usr/lib/libdri2.so.0.0.0
b4915000 b491c000 r-xp /usr/lib/libdrm.so.2.4.0
b4925000 b4938000 r-xp /usr/lib/libmdm.so.1.0.88
b4940000 b4948000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b4957000 b4959000 r-xp /usr/lib/libiniparser.so.0
b4963000 b4979000 r-xp /usr/lib/lib_SamsungRec_TizenV04009.so
b49a7000 b49aa000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b49b2000 b49e9000 r-xp /usr/lib/libpulse.so.0.16.2
b49f2000 b4a08000 r-xp /usr/lib/libavsysaudio.so.0.0.1
b4a10000 b4a17000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b4a1f000 b4a29000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
b4a35000 b4a3a000 r-xp /usr/lib/libmmfsession.so.0.0.0
b4a42000 b4a58000 r-xp /usr/lib/libefl-assist.so.0.1.0
b4a60000 b4afb000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
b4b07000 b4b0a000 r-xp /usr/lib/libmm_ta.so.0.0.0
b4b12000 b4b5e000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b4b66000 b4b6d000 r-xp /usr/lib/libtbm.so.1.0.0
b4b75000 b4b7a000 r-xp /usr/lib/libcapi-media-tool.so.0.1.3
b4b82000 b4b96000 r-xp /usr/lib/libmmfsound.so.0.1.0
b4b9f000 b4ba6000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.4
b4baf000 b4bc7000 r-xp /usr/lib/libcapi-media-player.so.0.1.75
b4bcf000 b4bd5000 r-xp /usr/lib/libcapi-media-audio-io.so.0.2.31
b4bdf000 b4be9000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
b4bf2000 b4bfa000 r-xp /opt/usr/apps/org.samteam.perfectsong/bin/paaaaaaaaa
b4dd7000 b4de1000 r-xp /lib/libnss_files-2.13.so
b4dea000 b4dfc000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b4e04000 b4e1a000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b4e22000 b4ef0000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b4f07000 b4f2b000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b4f34000 b4f3a000 r-xp /usr/lib/libappsvc.so.0.1.0
b4f42000 b4f50000 r-xp /usr/lib/libail.so.0.1.0
b4f58000 b4f5a000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.3
b4f63000 b4f68000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b4f71000 b4f73000 r-xp /usr/lib/libefl-extension.so.0.1.0
b4f7b000 b4f7c000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b4f85000 b4f89000 r-xp /usr/lib/libogg.so.0.7.1
b4f91000 b4fb3000 r-xp /usr/lib/libvorbis.so.0.4.3
b4fbb000 b509f000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b50b3000 b50e4000 r-xp /usr/lib/libFLAC.so.8.2.0
b5a7e000 b5b12000 r-xp /usr/lib/libstdc++.so.6.0.16
b5b25000 b5b27000 r-xp /usr/lib/libXau.so.6.0.0
b5b2f000 b5b39000 r-xp /usr/lib/libspdy.so.0.0.0
b5b42000 b5b8e000 r-xp /usr/lib/libssl.so.1.0.0
b5b9b000 b5bc9000 r-xp /usr/lib/libidn.so.11.5.44
b5bd1000 b5bdb000 r-xp /usr/lib/libcares.so.2.1.0
b5be3000 b5c04000 r-xp /usr/lib/libexif.so.12.3.3
b5c17000 b5c5c000 r-xp /usr/lib/libsndfile.so.1.0.25
b5c6a000 b5c80000 r-xp /lib/libexpat.so.1.5.2
b5c89000 b5d6e000 r-xp /usr/lib/libicuuc.so.51.1
b5d83000 b5db7000 r-xp /usr/lib/libicule.so.51.1
b5dc0000 b5dd3000 r-xp /usr/lib/libxcb.so.1.1.0
b5ddb000 b5e18000 r-xp /usr/lib/libcurl.so.4.3.0
b5e21000 b5e2a000 r-xp /usr/lib/libethumb.so.1.7.99
b5e33000 b5e35000 r-xp /usr/lib/libctxdata.so.0.0.0
b5e3d000 b5e4a000 r-xp /usr/lib/libremix.so.0.0.0
b5e52000 b5e53000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5e5b000 b5e72000 r-xp /usr/lib/liblua-5.1.so
b5e7b000 b5e82000 r-xp /usr/lib/libembryo.so.1.7.99
b5e8a000 b5ead000 r-xp /usr/lib/libjpeg.so.8.0.2
b5ec5000 b5f1b000 r-xp /usr/lib/libpixman-1.so.0.28.2
b5f28000 b5f7b000 r-xp /usr/lib/libfreetype.so.6.8.1
b5f86000 b5fae000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5faf000 b5ff5000 r-xp /usr/lib/libharfbuzz.so.0.907.0
b5ffe000 b6011000 r-xp /usr/lib/libfribidi.so.0.3.1
b6019000 b601c000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b6024000 b6028000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b6030000 b6035000 r-xp /usr/lib/libecore_fb.so.1.7.99
b603e000 b6048000 r-xp /usr/lib/libXext.so.6.4.0
b6050000 b6131000 r-xp /usr/lib/libX11.so.6.3.0
b613c000 b613f000 r-xp /usr/lib/libXtst.so.6.1.0
b6147000 b614d000 r-xp /usr/lib/libXrender.so.1.3.0
b6155000 b615a000 r-xp /usr/lib/libXrandr.so.2.2.0
b6162000 b6163000 r-xp /usr/lib/libXinerama.so.1.0.0
b616c000 b6174000 r-xp /usr/lib/libXi.so.6.1.0
b6175000 b6178000 r-xp /usr/lib/libXfixes.so.3.1.0
b6180000 b6182000 r-xp /usr/lib/libXgesture.so.7.0.0
b618a000 b618c000 r-xp /usr/lib/libXcomposite.so.1.0.0
b6194000 b6195000 r-xp /usr/lib/libXdamage.so.1.1.0
b619e000 b61a4000 r-xp /usr/lib/libXcursor.so.1.0.2
b61ad000 b61c6000 r-xp /usr/lib/libecore_con.so.1.7.99
b61d0000 b61d6000 r-xp /usr/lib/libecore_imf.so.1.7.99
b61de000 b61e6000 r-xp /usr/lib/libethumb_client.so.1.7.99
b61ee000 b61f7000 r-xp /usr/lib/libedbus.so.1.7.99
b61ff000 b625c000 r-xp /usr/lib/libedje.so.1.7.99
b6265000 b6276000 r-xp /usr/lib/libecore_input.so.1.7.99
b627e000 b6283000 r-xp /usr/lib/libecore_file.so.1.7.99
b628b000 b62a4000 r-xp /usr/lib/libeet.so.1.7.99
b62b5000 b62b9000 r-xp /usr/lib/libappcore-common.so.1.1
b62c1000 b6388000 r-xp /usr/lib/libevas.so.1.7.99
b63ad000 b63ce000 r-xp /usr/lib/libecore_evas.so.1.7.99
b63d7000 b6406000 r-xp /usr/lib/libecore_x.so.1.7.99
b6410000 b6547000 r-xp /usr/lib/libelementary.so.1.7.99
b655d000 b655e000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b6566000 b656a000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.3
b6575000 b6578000 r-xp /lib/libgpg-error.so.0.5.0
b6580000 b65d8000 r-xp /usr/lib/libgcrypt.so.11.5.3
b65e2000 b660e000 r-xp /usr/lib/libsystemd.so.0.0.1
b6617000 b6619000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b6622000 b66ed000 r-xp /usr/lib/libxml2.so.2.7.8
b66fb000 b670b000 r-xp /lib/libresolv-2.13.so
b670f000 b6725000 r-xp /lib/libz.so.1.2.5
b672d000 b672f000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b6737000 b673c000 r-xp /usr/lib/libffi.so.5.0.10
b6745000 b6746000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b674e000 b6751000 r-xp /lib/libattr.so.1.1.0
b6759000 b675c000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6764000 b676b000 r-xp /usr/lib/libvconf.so.0.2.45
b6774000 b691b000 r-xp /usr/lib/libcrypto.so.1.0.0
b693d000 b6953000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b695b000 b69c4000 r-xp /lib/libm-2.13.so
b69cd000 b6a0d000 r-xp /usr/lib/libeina.so.1.7.99
b6a16000 b6a4a000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b6a53000 b6b27000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b6b33000 b6b38000 r-xp /usr/lib/libcapi-base-common.so.0.1.6
b6b41000 b6b47000 r-xp /lib/librt-2.13.so
b6b50000 b6b57000 r-xp /lib/libcrypt-2.13.so
b6b87000 b6b8a000 r-xp /lib/libcap.so.2.21
b6b92000 b6b94000 r-xp /usr/lib/libiri.so
b6b9c000 b6bbb000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6bc3000 b6bd9000 r-xp /usr/lib/libecore.so.1.7.99
b6bef000 b6bf4000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6bfd000 b6c14000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c1d000 b6c28000 r-xp /lib/libunwind.so.8.0.1
b6c55000 b6d70000 r-xp /lib/libc-2.13.so
b6d7e000 b6d86000 r-xp /lib/libgcc_s-4.6.4.so.1
b6d8e000 b6db8000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6dc1000 b6dc4000 r-xp /usr/lib/libbundle.so.0.1.22
b6dcc000 b6dce000 r-xp /lib/libdl-2.13.so
b6dd7000 b6dda000 r-xp /usr/lib/libsmack.so.1.0.0
b6de2000 b6eb2000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6eb3000 b6f18000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6f22000 b6f34000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6f3c000 b6f50000 r-xp /lib/libpthread-2.13.so
b6f5b000 b6f5d000 r-xp /usr/lib/libdlog.so.0.0.0
b6f65000 b6f70000 r-xp /usr/lib/libaul.so.0.1.0
b6f82000 b6f85000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f8f000 b6f93000 r-xp /usr/lib/libsys-assert.so
b6f9c000 b6fb9000 r-xp /lib/ld-2.13.so
b6fc2000 b6fc7000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
b8cac000 b8cd6000 rw-p [heap]
b8cd6000 b92c9000 rw-p [heap]
bec08000 bec29000 rwxp [stack]
End of Maps Information

Callstack Information (PID:14992)
Call Stack Count: 3
 0: (0xb6cc0eb4) [/lib/libc.so.6] + 0x6beb4
 1: __libc_calloc + 0xcc (0xb6cc5210) [/lib/libc.so.6] + 0x70210
 2: (0xb624332b) [/usr/lib/libedje.so.1] + 0x4432b
End of Call Stack

Package Information
Package Name: org.samteam.perfectsong
Package ID : org.samteam.perfectsong
Version: 1.0.0
Package Type: rpm
App Name: paaaaaaaaa
App ID: org.samteam.perfectsong
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
99): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 707 5 28 25"
08-13 01:44:57.300+0900 W/TIZEN_N_PLAYER(14992): player.c: __msg_callback(660) > [__msg_callback] Got message type : 0x3
08-13 01:44:57.300+0900 I/TIZEN_N_PLAYER(14992): player.c: __msg_callback(686) > STATE CHANGED INTERNALLY - from : 0,  to : 1 (CAPI State : 1)
08-13 01:44:57.300+0900 W/TIZEN_N_PLAYER(14992): player.c: __msg_callback(859) > [__msg_callback] End
08-13 01:44:57.590+0900 W/TIZEN_N_PLAYER(14992): player.c: __msg_callback(660) > [__msg_callback] Got message type : 0x3
08-13 01:44:57.590+0900 I/TIZEN_N_PLAYER(14992): player.c: __msg_callback(686) > STATE CHANGED INTERNALLY - from : 1,  to : 3 (CAPI State : 1)
08-13 01:44:57.590+0900 W/TIZEN_N_PLAYER(14992): player.c: __msg_callback(859) > [__msg_callback] End
08-13 01:44:57.590+0900 I/TIZEN_N_PLAYER(14992): player.c: player_prepare(1343) > [player_prepare] End
08-13 01:44:57.590+0900 I/TIZEN_N_PLAYER(14992): player.c: player_start(1582) > [player_start] Start
08-13 01:44:57.590+0900 W/TIZEN_N_PLAYER(14992): player.c: __msg_callback(660) > [__msg_callback] Got message type : 0x3
08-13 01:44:57.600+0900 I/TIZEN_N_PLAYER(14992): player.c: __msg_callback(686) > STATE CHANGED INTERNALLY - from : 3,  to : 2 (CAPI State : 2)
08-13 01:44:57.600+0900 W/TIZEN_N_PLAYER(14992): player.c: __msg_callback(859) > [__msg_callback] End
08-13 01:44:57.600+0900 W/TIZEN_N_PLAYER(14992): player.c: __msg_callback(660) > [__msg_callback] Got message type : 0x104
08-13 01:44:57.600+0900 I/TIZEN_N_PLAYER(14992): player.c: __msg_callback(708) > [__msg_callback] Ready to streaming information (BOS) [current state : 2]
08-13 01:44:57.600+0900 W/TIZEN_N_PLAYER(14992): player.c: __msg_callback(859) > [__msg_callback] End
08-13 01:44:57.600+0900 I/TIZEN_N_PLAYER(14992): player.c: player_start(1632) > [player_start] End
08-13 01:44:57.600+0900 E/record  (14992): buffer size : 4410000
08-13 01:44:57.610+0900 E/record  (14992): perfect_song_routine start
08-13 01:44:57.620+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:44:57.680+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:44:57.740+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:44:57.790+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:44:57.840+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:44:57.890+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:44:57.940+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:44:57.990+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:44:58.040+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:44:58.090+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:44:58.140+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:44:58.200+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:44:58.240+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:44:58.290+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:44:58.340+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:44:58.400+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:44:58.450+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:44:58.500+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:44:58.550+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:44:58.600+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:44:58.650+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:44:58.700+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:44:58.750+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:44:58.810+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:44:59.010+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:44:59.170+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:44:59.370+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:44:59.570+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:44:59.730+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:44:59.910+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:00.120+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:00.250+0900 I/Tizen::Net::Wifi(  961): (1072) > _WifiService is not registered.
08-13 01:45:00.250+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 01:45:00.250+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 01:45:00.250+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 01:45:00.250+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
08-13 01:45:00.250+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 303 5 28 25"
08-13 01:45:00.250+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 331 5 28 25"
08-13 01:45:00.250+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 359 5 28 25"
08-13 01:45:00.250+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 387 5 28 25"
08-13 01:45:00.250+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 01:45:00.250+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 01:45:00.250+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 01:45:00.250+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
08-13 01:45:00.250+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 198 567 5 28 25"
08-13 01:45:00.250+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 200 595 5 28 25"
08-13 01:45:00.250+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 623 5 28 25"
08-13 01:45:00.250+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 651 5 28 25"
08-13 01:45:00.250+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 679 5 28 25"
08-13 01:45:00.250+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 707 5 28 25"
08-13 01:45:00.320+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:00.470+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:00.670+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:00.880+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:01.040+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:01.240+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:01.260+0900 I/Tizen::Net::Wifi(  961): (1072) > _WifiService is not registered.
08-13 01:45:01.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 01:45:01.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 01:45:01.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 01:45:01.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
08-13 01:45:01.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 303 5 28 25"
08-13 01:45:01.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 331 5 28 25"
08-13 01:45:01.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 359 5 28 25"
08-13 01:45:01.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 387 5 28 25"
08-13 01:45:01.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 01:45:01.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 01:45:01.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 01:45:01.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
08-13 01:45:01.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 198 567 5 28 25"
08-13 01:45:01.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 200 595 5 28 25"
08-13 01:45:01.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 623 5 28 25"
08-13 01:45:01.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 651 5 28 25"
08-13 01:45:01.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 679 5 28 25"
08-13 01:45:01.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 707 5 28 25"
08-13 01:45:01.400+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:01.600+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:01.800+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:01.960+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:02.160+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:02.360+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:02.520+0900 I/record  (14992): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:02.520+0900 E/record  (14992): !! interval
08-13 01:45:02.730+0900 F/record  (14992): ===next node===
08-13 01:45:02.730+0900 I/record  (14992): note : 52 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:02.890+0900 I/record  (14992): note : 52 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:03.080+0900 I/record  (14992): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:03.080+0900 E/record  (14992): !! interval
08-13 01:45:03.260+0900 I/Tizen::Net::Wifi(  961): (1072) > _WifiService is not registered.
08-13 01:45:03.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 01:45:03.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 01:45:03.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 01:45:03.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
08-13 01:45:03.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 303 5 28 25"
08-13 01:45:03.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 331 5 28 25"
08-13 01:45:03.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 359 5 28 25"
08-13 01:45:03.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 387 5 28 25"
08-13 01:45:03.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 01:45:03.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 01:45:03.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 01:45:03.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
08-13 01:45:03.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 198 567 5 28 25"
08-13 01:45:03.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 200 595 5 28 25"
08-13 01:45:03.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 623 5 28 25"
08-13 01:45:03.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 651 5 28 25"
08-13 01:45:03.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 679 5 28 25"
08-13 01:45:03.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 707 5 28 25"
08-13 01:45:03.270+0900 I/record  (14992): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:03.280+0900 E/record  (14992): !! interval
08-13 01:45:03.480+0900 F/record  (14992): ===next node===
08-13 01:45:03.480+0900 I/record  (14992): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:03.480+0900 E/record  (14992): !! interval
08-13 01:45:03.640+0900 F/record  (14992): ===next node===
08-13 01:45:03.640+0900 I/record  (14992): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:03.640+0900 E/record  (14992): !! interval
08-13 01:45:03.840+0900 I/record  (14992): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:03.840+0900 E/record  (14992): !! interval
08-13 01:45:04.000+0900 F/record  (14992): ===next node===
08-13 01:45:04.000+0900 I/record  (14992): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:04.010+0900 E/record  (14992): !! interval
08-13 01:45:04.200+0900 I/record  (14992): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:04.210+0900 E/record  (14992): !! interval
08-13 01:45:04.400+0900 F/record  (14992): ===next node===
08-13 01:45:04.400+0900 I/record  (14992): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:04.400+0900 E/record  (14992): !! interval
08-13 01:45:04.570+0900 F/record  (14992): ===next node===
08-13 01:45:04.570+0900 I/record  (14992): note : 50 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:04.770+0900 I/record  (14992): note : 50 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:04.960+0900 I/record  (14992): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:04.970+0900 E/record  (14992): !! interval
08-13 01:45:05.130+0900 F/record  (14992): ===next node===
08-13 01:45:05.130+0900 I/record  (14992): note : 52 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:05.260+0900 I/Tizen::Net::Wifi(  961): (1072) > _WifiService is not registered.
08-13 01:45:05.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 01:45:05.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 01:45:05.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 01:45:05.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
08-13 01:45:05.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 303 5 28 25"
08-13 01:45:05.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 331 5 28 25"
08-13 01:45:05.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 359 5 28 25"
08-13 01:45:05.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 387 5 28 25"
08-13 01:45:05.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 01:45:05.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 01:45:05.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 01:45:05.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
08-13 01:45:05.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 198 567 5 28 25"
08-13 01:45:05.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 200 595 5 28 25"
08-13 01:45:05.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 623 5 28 25"
08-13 01:45:05.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 651 5 28 25"
08-13 01:45:05.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 679 5 28 25"
08-13 01:45:05.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 707 5 28 25"
08-13 01:45:05.330+0900 I/record  (14992): note : 52 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:05.490+0900 I/record  (14992): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:05.490+0900 E/record  (14992): !! interval
08-13 01:45:05.690+0900 I/record  (14992): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:05.690+0900 E/record  (14992): !! interval
08-13 01:45:05.890+0900 F/record  (14992): ===next node===
08-13 01:45:05.890+0900 I/record  (14992): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:05.890+0900 E/record  (14992): !! interval
08-13 01:45:06.080+0900 F/record  (14992): ===next node===
08-13 01:45:06.080+0900 I/record  (14992): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:06.080+0900 E/record  (14992): !! interval
08-13 01:45:06.240+0900 I/record  (14992): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:06.240+0900 E/record  (14992): !! interval
08-13 01:45:06.440+0900 F/record  (14992): ===next node===
08-13 01:45:06.440+0900 I/record  (14992): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:06.440+0900 E/record  (14992): !! interval
08-13 01:45:06.640+0900 F/record  (14992): ===next node===
08-13 01:45:06.640+0900 I/record  (14992): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:06.640+0900 E/record  (14992): !! interval
08-13 01:45:06.800+0900 I/record  (14992): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:06.800+0900 E/record  (14992): !! interval
08-13 01:45:07.000+0900 F/record  (14992): ===next node===
08-13 01:45:07.000+0900 I/record  (14992): note : 60 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:07.160+0900 I/record  (14992): note : 60 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:07.360+0900 I/record  (14992): note : 60 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:07.360+0900 E/record  (14992): !! interval
08-13 01:45:07.560+0900 I/record  (14992): note : 60 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:07.560+0900 E/record  (14992): !! interval
08-13 01:45:07.730+0900 F/record  (14992): ===next node===
08-13 01:45:07.730+0900 I/record  (14992): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:07.730+0900 E/record  (14992): !! interval
08-13 01:45:07.920+0900 F/record  (14992): ===next node===
08-13 01:45:07.920+0900 I/record  (14992): note : 60 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:07.920+0900 E/record  (14992): !! interval
08-13 01:45:08.090+0900 I/record  (14992): note : 60 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:08.090+0900 E/record  (14992): !! interval
08-13 01:45:08.290+0900 F/record  (14992): ===next node===
08-13 01:45:08.290+0900 I/record  (14992): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:08.290+0900 E/record  (14992): !! interval
08-13 01:45:08.490+0900 F/record  (14992): ===next node===
08-13 01:45:08.490+0900 I/record  (14992): note : 60 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:08.490+0900 E/record  (14992): !! interval
08-13 01:45:08.650+0900 I/record  (14992): note : 60 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:08.650+0900 E/record  (14992): !! interval
08-13 01:45:08.850+0900 F/record  (14992): ===next node===
08-13 01:45:08.850+0900 I/record  (14992): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:08.850+0900 E/record  (14992): !! interval
08-13 01:45:09.040+0900 F/record  (14992): ===next node===
08-13 01:45:09.040+0900 I/record  (14992): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:09.040+0900 E/record  (14992): !! interval
08-13 01:45:09.200+0900 I/record  (14992): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:09.200+0900 E/record  (14992): !! interval
08-13 01:45:09.400+0900 F/record  (14992): ===next node===
08-13 01:45:09.400+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:09.600+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:09.770+0900 I/record  (14992): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:09.770+0900 E/record  (14992): !! interval
08-13 01:45:09.970+0900 F/record  (14992): ===next node===
08-13 01:45:09.970+0900 I/record  (14992): note : 50 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:10.170+0900 I/record  (14992): note : 50 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:10.330+0900 I/record  (14992): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:10.330+0900 E/record  (14992): !! interval
08-13 01:45:10.530+0900 F/record  (14992): ===next node===
08-13 01:45:10.530+0900 I/record  (14992): note : 53 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:10.530+0900 E/record  (14992): !! interval
08-13 01:45:10.690+0900 I/record  (14992): note : 53 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:10.690+0900 E/record  (14992): !! interval
08-13 01:45:10.890+0900 F/record  (14992): ===next node===
08-13 01:45:10.890+0900 I/record  (14992): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:10.890+0900 E/record  (14992): !! interval
08-13 01:45:11.090+0900 I/record  (14992): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:11.090+0900 E/record  (14992): !! interval
08-13 01:45:11.250+0900 F/record  (14992): ===next node===
08-13 01:45:11.250+0900 I/record  (14992): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:11.250+0900 E/record  (14992): !! interval
08-13 01:45:11.460+0900 F/record  (14992): ===next node===
08-13 01:45:11.460+0900 I/record  (14992): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:11.460+0900 E/record  (14992): !! interval
08-13 01:45:11.620+0900 I/record  (14992): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:11.620+0900 E/record  (14992): !! interval
08-13 01:45:11.820+0900 I/record  (14992): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:11.820+0900 E/record  (14992): !! interval
08-13 01:45:12.010+0900 I/record  (14992): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:12.010+0900 E/record  (14992): !! interval
08-13 01:45:12.210+0900 F/record  (14992): ===next node===
08-13 01:45:12.210+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:12.370+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:12.570+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:12.770+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:12.930+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:13.130+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:13.290+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:13.500+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:13.690+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:13.850+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:14.050+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:14.220+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:14.420+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:14.620+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:14.780+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:14.960+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:15.170+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:15.460+0900 I/record  (14992): note : 55 detect :46 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:15.530+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:15.730+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:15.930+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:16.090+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:16.290+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:16.470+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:16.670+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:16.830+0900 I/record  (14992): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:16.830+0900 E/record  (14992): !! interval
08-13 01:45:17.030+0900 I/record  (14992): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:17.030+0900 E/record  (14992): !! interval
08-13 01:45:17.190+0900 F/record  (14992): ===next node===
08-13 01:45:17.190+0900 I/record  (14992): note : 52 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:17.390+0900 I/record  (14992): note : 52 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:17.590+0900 I/record  (14992): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:17.590+0900 E/record  (14992): !! interval
08-13 01:45:17.750+0900 F/record  (14992): ===next node===
08-13 01:45:17.750+0900 I/record  (14992): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:17.750+0900 E/record  (14992): !! interval
08-13 01:45:17.950+0900 I/record  (14992): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:17.950+0900 E/record  (14992): !! interval
08-13 01:45:18.150+0900 F/record  (14992): ===next node===
08-13 01:45:18.150+0900 I/record  (14992): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:18.150+0900 E/record  (14992): !! interval
08-13 01:45:18.310+0900 I/record  (14992): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:18.310+0900 E/record  (14992): !! interval
08-13 01:45:18.510+0900 F/record  (14992): ===next node===
08-13 01:45:18.510+0900 I/record  (14992): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:18.520+0900 E/record  (14992): !! interval
08-13 01:45:18.670+0900 F/record  (14992): ===next node===
08-13 01:45:18.670+0900 I/record  (14992): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:18.670+0900 E/record  (14992): !! interval
08-13 01:45:18.880+0900 I/record  (14992): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:18.880+0900 E/record  (14992): !! interval
08-13 01:45:19.080+0900 F/record  (14992): ===next node===
08-13 01:45:19.080+0900 I/record  (14992): note : 50 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:19.240+0900 I/record  (14992): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:19.240+0900 E/record  (14992): !! interval
08-13 01:45:19.430+0900 I/record  (14992): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:19.430+0900 E/record  (14992): !! interval
08-13 01:45:19.630+0900 F/record  (14992): ===next node===
08-13 01:45:19.630+0900 I/record  (14992): note : 52 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:19.790+0900 I/record  (14992): note : 52 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:19.990+0900 I/record  (14992): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:19.990+0900 E/record  (14992): !! interval
08-13 01:45:20.190+0900 F/record  (14992): ===next node===
08-13 01:45:20.190+0900 I/record  (14992): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:20.190+0900 E/record  (14992): !! interval
08-13 01:45:20.350+0900 I/record  (14992): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:20.350+0900 E/record  (14992): !! interval
08-13 01:45:20.550+0900 F/record  (14992): ===next node===
08-13 01:45:20.550+0900 I/record  (14992): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:20.550+0900 E/record  (14992): !! interval
08-13 01:45:20.750+0900 F/record  (14992): ===next node===
08-13 01:45:20.750+0900 I/record  (14992): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:20.750+0900 E/record  (14992): !! interval
08-13 01:45:20.910+0900 I/record  (14992): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:20.910+0900 E/record  (14992): !! interval
08-13 01:45:21.120+0900 F/record  (14992): ===next node===
08-13 01:45:21.120+0900 I/record  (14992): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:21.120+0900 E/record  (14992): !! interval
08-13 01:45:21.280+0900 I/record  (14992): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:21.280+0900 E/record  (14992): !! interval
08-13 01:45:21.480+0900 F/record  (14992): ===next node===
08-13 01:45:21.480+0900 I/record  (14992): note : 60 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:21.680+0900 I/record  (14992): note : 60 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:21.680+0900 E/record  (14992): !! interval
08-13 01:45:21.840+0900 I/record  (14992): note : 60 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:21.840+0900 E/record  (14992): !! interval
08-13 01:45:22.040+0900 I/record  (14992): note : 60 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:22.040+0900 E/record  (14992): !! interval
08-13 01:45:22.240+0900 F/record  (14992): ===next node===
08-13 01:45:22.240+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:22.400+0900 F/record  (14992): ===next node===
08-13 01:45:22.400+0900 I/record  (14992): note : 60 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:22.400+0900 E/record  (14992): !! interval
08-13 01:45:22.600+0900 I/record  (14992): note : 60 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:22.600+0900 E/record  (14992): !! interval
08-13 01:45:22.790+0900 F/record  (14992): ===next node===
08-13 01:45:22.790+0900 I/record  (14992): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:22.790+0900 E/record  (14992): !! interval
08-13 01:45:22.960+0900 F/record  (14992): ===next node===
08-13 01:45:22.960+0900 I/record  (14992): note : 60 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:22.960+0900 E/record  (14992): !! interval
08-13 01:45:23.160+0900 F/record  (14992): ===next node===
08-13 01:45:23.160+0900 I/record  (14992): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:23.160+0900 E/record  (14992): !! interval
08-13 01:45:23.360+0900 I/record  (14992): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:23.360+0900 E/record  (14992): !! interval
08-13 01:45:23.520+0900 F/record  (14992): ===next node===
08-13 01:45:23.520+0900 I/record  (14992): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:23.520+0900 E/record  (14992): !! interval
08-13 01:45:23.720+0900 F/record  (14992): ===next node===
08-13 01:45:23.720+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:23.880+0900 I/record  (14992): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:24.080+0900 I/record  (14992): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:24.080+0900 E/record  (14992): !! interval
08-13 01:45:24.280+0900 I/record  (14992): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:24.280+0900 E/record  (14992): !! interval
08-13 01:45:24.440+0900 F/record  (14992): ===next node===
08-13 01:45:24.440+0900 I/record  (14992): note : 50 detect :21 isHit : 3 [0: 1071644672/-1393001628]
08-13 01:45:24.640+0900 I/record  (14992): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:24.640+0900 E/record  (14992): !! interval
08-13 01:45:24.840+0900 I/record  (14992): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:24.840+0900 E/record  (14992): !! interval
08-13 01:45:25.000+0900 F/record  (14992): ===next node===
08-13 01:45:25.000+0900 I/record  (14992): note : 53 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:25.000+0900 E/record  (14992): !! interval
08-13 01:45:25.210+0900 I/record  (14992): note : 53 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:25.210+0900 E/record  (14992): !! interval
08-13 01:45:25.370+0900 F/record  (14992): ===next node===
08-13 01:45:25.370+0900 I/record  (14992): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:25.370+0900 E/record  (14992): !! interval
08-13 01:45:25.550+0900 F/record  (14992): ===next node===
08-13 01:45:25.550+0900 I/record  (14992): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:25.560+0900 E/record  (14992): !! interval
08-13 01:45:25.750+0900 I/record  (14992): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:25.750+0900 E/record  (14992): !! interval
08-13 01:45:25.950+0900 F/record  (14992): ===next node===
08-13 01:45:25.950+0900 I/record  (14992): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:25.960+0900 E/record  (14992): !! interval
08-13 01:45:26.210+0900 I/record  (14992): note : 48 detect :41 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:26.260+0900 I/Tizen::Net::Wifi(  961): (1072) > _WifiService is not registered.
08-13 01:45:26.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 01:45:26.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 01:45:26.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 01:45:26.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
08-13 01:45:26.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 303 5 28 25"
08-13 01:45:26.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 331 5 28 25"
08-13 01:45:26.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 359 5 28 25"
08-13 01:45:26.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 387 5 28 25"
08-13 01:45:26.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 01:45:26.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 01:45:26.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 01:45:26.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
08-13 01:45:26.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 198 567 5 28 25"
08-13 01:45:26.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 200 595 5 28 25"
08-13 01:45:26.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 623 5 28 25"
08-13 01:45:26.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 651 5 28 25"
08-13 01:45:26.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 679 5 28 25"
08-13 01:45:26.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 707 5 28 25"
08-13 01:45:26.410+0900 I/record  (14992): note : 48 detect :40 isHit : -2 [0: 1071644672/-1393001628]
08-13 01:45:27.250+0900 I/Tizen::Net::Wifi(  961): (1072) > _WifiService is not registered.
08-13 01:45:27.250+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 01:45:27.250+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 01:45:27.250+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 01:45:27.250+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
08-13 01:45:27.250+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 303 5 28 25"
08-13 01:45:27.250+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 331 5 28 25"
08-13 01:45:27.250+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 359 5 28 25"
08-13 01:45:27.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 387 5 28 25"
08-13 01:45:27.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 01:45:27.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 01:45:27.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 01:45:27.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
08-13 01:45:27.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 198 567 5 28 25"
08-13 01:45:27.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 200 595 5 28 25"
08-13 01:45:27.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 623 5 28 25"
08-13 01:45:27.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 651 5 28 25"
08-13 01:45:27.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 679 5 28 25"
08-13 01:45:27.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 707 5 28 25"
08-13 01:45:28.260+0900 I/Tizen::Net::Wifi(  961): (1072) > _WifiService is not registered.
08-13 01:45:28.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 01:45:28.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 01:45:28.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 01:45:28.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
08-13 01:45:28.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 303 5 28 25"
08-13 01:45:28.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 331 5 28 25"
08-13 01:45:28.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 359 5 28 25"
08-13 01:45:28.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 387 5 28 25"
08-13 01:45:28.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 01:45:28.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 01:45:28.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 01:45:28.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
08-13 01:45:28.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 198 567 5 28 25"
08-13 01:45:28.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 200 595 5 28 25"
08-13 01:45:28.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 623 5 28 25"
08-13 01:45:28.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 651 5 28 25"
08-13 01:45:28.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 679 5 28 25"
08-13 01:45:28.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 707 5 28 25"
08-13 01:45:29.560+0900 E/record  (14992): perfect_song_end
08-13 01:45:30.270+0900 I/Tizen::Net::Wifi(  961): (1072) > _WifiService is not registered.
08-13 01:45:30.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 01:45:30.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 01:45:30.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 01:45:30.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
08-13 01:45:30.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 303 5 28 25"
08-13 01:45:30.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 331 5 28 25"
08-13 01:45:30.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 359 5 28 25"
08-13 01:45:30.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 387 5 28 25"
08-13 01:45:30.280+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 01:45:30.280+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 01:45:30.280+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 01:45:30.280+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
08-13 01:45:30.280+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 198 567 5 28 25"
08-13 01:45:30.280+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 200 595 5 28 25"
08-13 01:45:30.280+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 623 5 28 25"
08-13 01:45:30.280+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 651 5 28 25"
08-13 01:45:30.280+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 679 5 28 25"
08-13 01:45:30.280+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 707 5 28 25"
08-13 01:45:32.500+0900 W/TIZEN_N_PLAYER(14992): player.c: __msg_callback(660) > [__msg_callback] Got message type : 0x105
08-13 01:45:32.500+0900 W/TIZEN_N_PLAYER(14992): player.c: __msg_callback(859) > [__msg_callback] End
08-13 01:45:35.600+0900 F/record  (14992): perfectsong button Callback
08-13 01:45:35.800+0900 E/asdf    (14992): -1190792640
08-13 01:45:35.800+0900 E/asdf    (14992): -1190792640
08-13 01:45:35.800+0900 I/TIZEN_N_PLAYER(14992): player.c: player_stop(1639) > [player_stop] Start
08-13 01:45:35.840+0900 W/TIZEN_N_PLAYER(14992): player.c: __msg_callback(660) > [__msg_callback] Got message type : 0x3
08-13 01:45:35.840+0900 I/TIZEN_N_PLAYER(14992): player.c: __msg_callback(686) > STATE CHANGED INTERNALLY - from : 2,  to : 1 (CAPI State : 3)
08-13 01:45:35.840+0900 W/TIZEN_N_PLAYER(14992): player.c: __msg_callback(859) > [__msg_callback] End
08-13 01:45:35.840+0900 I/TIZEN_N_PLAYER(14992): player.c: player_stop(1665) > [player_stop] End
08-13 01:45:35.840+0900 E/asdf    (14992): escape
08-13 01:45:36.050+0900 W/AUL_AMD (  444): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
08-13 01:45:36.050+0900 W/AUL_AMD (  444): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
08-13 01:45:36.070+0900 I/AUL_PAD (  498): sigchild.h: __launchpad_sig_child(142) > dead_pid = 14992 pgid = 14992
08-13 01:45:36.070+0900 I/AUL_PAD (  498): sigchild.h: __sigchild_action(123) > dead_pid(14992)
08-13 01:45:36.070+0900 I/AUL_PAD (  498): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
08-13 01:45:36.070+0900 I/AUL_PAD (  498): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
08-13 01:45:36.080+0900 I/Tizen::System(  937): (246) > Terminated app [org.samteam.perfectsong]
08-13 01:45:36.080+0900 I/Tizen::Io(  937): (729) > Entry not found
08-13 01:45:36.080+0900 I/Tizen::App(  887): (243) > App[org.samteam.perfectsong] pid[14992] terminate event is forwarded
08-13 01:45:36.080+0900 I/Tizen::System(  887): (256) > osp.accessorymanager.service provider is found.
08-13 01:45:36.080+0900 I/Tizen::System(  887): (196) > Accessory Owner is removed [org.samteam.perfectsong, 14992, ]
08-13 01:45:36.080+0900 I/Tizen::System(  887): (256) > osp.system.service provider is found.
08-13 01:45:36.080+0900 I/Tizen::App(  887): (506) > TerminatedApp(org.samteam.perfectsong)
08-13 01:45:36.080+0900 I/Tizen::App(  887): (512) > Not registered pid(14992)
08-13 01:45:36.080+0900 I/Tizen::App(  887): (782) > Finished invoking application event listener for org.samteam.perfectsong, 14992.
08-13 01:45:36.090+0900 I/AUL_AMD (  444): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 14992
08-13 01:45:36.090+0900 I/Tizen::System(  937): (157) > change brightness system value.
08-13 01:45:36.090+0900 I/Tizen::App(  937): (782) > Finished invoking application event listener for org.samteam.perfectsong, 14992.
08-13 01:45:36.130+0900 W/PROCESSMGR(  407): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=589
08-13 01:45:36.150+0900 I/QUICKPANEL(  661): sound-profile.c: _view_update(106) > [_view_update : 106] sound : 0, vibration : 1
08-13 01:45:36.160+0900 I/CAPI_APPFW_APPLICATION(  589): app_main.c: app_appcore_resume(223) > app_appcore_resume
08-13 01:45:36.160+0900 E/cluster-home(  589): homescreen-main.cpp: app_resume(422) >  app resume
08-13 01:45:36.200+0900 I/QUICKPANEL(  661): quickpanel-ui.c: _ui_handler_input_region_set(172) > [_ui_handler_input_region_set : 172] win_input_0:0
08-13 01:45:36.200+0900 I/QUICKPANEL(  661): win_input_1:758
08-13 01:45:36.200+0900 I/QUICKPANEL(  661): win_input_2:480
08-13 01:45:36.200+0900 I/QUICKPANEL(  661): win_input_3:42
08-13 01:45:36.200+0900 I/QUICKPANEL(  661): 
08-13 01:45:36.210+0900 W/CRASH_MANAGER(15142): worker.c: worker_job(1198) > 1114992706161143939793
