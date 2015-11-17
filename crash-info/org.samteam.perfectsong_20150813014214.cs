S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.0
Build-Number: Z130HDDU0BOB3
Build-Date: 2015.02.14 15:10:17

Crash Information
Process Name: paaaaaaaaa
PID: 13521
Date: 2015-08-13 01:42:14+0900
Executable File Path: /opt/usr/apps/org.samteam.perfectsong/bin/paaaaaaaaa
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 13521, uid 5000)

Register Information
r0   = 0xb3400010, r1   = 0x00000002
r2   = 0x00000000, r3   = 0xb3400058
r4   = 0xb3400010, r5   = 0x00000020
r6   = 0x00000004, r7   = 0xb341cd78
r8   = 0x00000001, r9   = 0x000209f0
r10  = 0xb34d5610, fp   = 0x00000018
ip   = 0xb626391c, sp   = 0xbec18fe0
lr   = 0xb6cc5210, pc   = 0xb6cc0eb4
cpsr = 0xa0000010

Memory Information
MemTotal:   730748 KB
MemFree:    198680 KB
Buffers:     41044 KB
Cached:     204272 KB
VmPeak:     184180 KB
VmSize:     182268 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       27968 KB
VmRSS:       27968 KB
VmData:     113432 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       28388 KB
VmPTE:         106 KB
VmSwap:          0 KB

Threads Information
Threads: 12
PID = 13521 TID = 13521
13521 13528 13529 13533 13543 13544 13545 13548 13549 13551 13552 13554 

Maps Information
ad91b000 ae11a000 rwxp [stack:13554]
ae11a000 ae197000 r-xp /usr/lib/lib_SoundAlive_ver125e_wrapped.so
ae1b5000 ae9b4000 rwxp [stack:13552]
ae9b5000 af1b4000 rwxp [stack:13551]
af2d9000 afad8000 rwxp [stack:13533]
afae6000 afb00000 r-xp /usr/lib/gstreamer-0.10/libgstpulse.so
afb09000 afb12000 r-xp /usr/lib/lib_SoundBooster_ver402_wrapped.so
afb31000 afb49000 r-xp /usr/lib/libgstcontroller-0.10.so.0.30.0
afb58000 afb5e000 r-xp /usr/lib/gstreamer-0.10/libgstsoundalive.so
afb66000 afb6e000 r-xp /usr/lib/lib_SoundAlive_SRC192_ver204_wrapped.so
afb79000 afb7e000 r-xp /usr/lib/gstreamer-0.10/libgstvolume.so
afb86000 afb89000 r-xp /usr/lib/gstreamer-0.10/libgstsecresample.so
afb92000 afbbb000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
afd6b000 afd76000 r-xp /usr/lib/gstreamer-0.10/libgstaudioconvert.so
afd7f000 afd83000 r-xp /usr/lib/gstreamer-0.10/libgstaudiotp.so
afd8b000 afdb0000 r-xp /usr/lib/libgsttag-0.10.so.0.25.0
afdb9000 afdc3000 r-xp /usr/lib/libgstriff-0.10.so.0.25.0
afdd0000 afdd9000 r-xp /usr/lib/gstreamer-0.10/libgstvorbis.so
afde1000 afe07000 r-xp /usr/lib/gstreamer-0.10/libgstogg.so
afe10000 afe28000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
afe31000 afe47000 r-xp /usr/lib/gstreamer-0.10/libgstdecodebin2.so
afe50000 afe93000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
afe9b000 afed0000 r-xp /usr/lib/gstreamer-0.10/libgstcoreelements.so
afeda000 b06d9000 rwxp [stack:13529]
b0adb000 b12da000 rwxp [stack:13528]
b12db000 b1ada000 rwxp [stack:13543]
b1adb000 b22da000 rwxp [stack:13544]
b2401000 b2c00000 rwxp [stack:13548]
b2c01000 b3400000 rwxp [stack:13545]
b3505000 b350f000 r-xp /usr/lib/gstreamer-0.10/libgsttypefindfunctions.so
b35cc000 b3dcb000 rwxp [stack:13549]
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
b8cd6000 b9577000 rw-p [heap]
bec08000 bec29000 rwxp [stack]
b8cac000 b8cd6000 rw-p [heap]
b8cd6000 b9577000 rw-p [heap]
bec08000 bec29000 rwxp [stack]
End of Maps Information

Callstack Information (PID:13521)
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
21):     9120 90 0A 2A  6E
08-13 01:40:41.120+0900 I/EVT     (13521):     9200 90 0A 2A  00
08-13 01:40:41.120+0900 I/TRACK   (13521): TRACK END: 7 (9200 ticks)
08-13 01:40:41.120+0900 I/June    (13521): asdfasdf 최대 60  최소48  비율27
08-13 01:40:41.250+0900 I/TIZEN_N_PLAYER(13521): player.c: player_create(1091) > [player_create] new handle : 0xb90605c8
08-13 01:40:41.250+0900 I/TIZEN_N_PLAYER(13521): player.c: player_prepare(1272) > [player_prepare] Start
08-13 01:40:41.290+0900 W/TIZEN_N_PLAYER(13521): player.c: __msg_callback(660) > [__msg_callback] Got message type : 0x3
08-13 01:40:41.290+0900 I/TIZEN_N_PLAYER(13521): player.c: __msg_callback(686) > STATE CHANGED INTERNALLY - from : 0,  to : 1 (CAPI State : 1)
08-13 01:40:41.290+0900 W/TIZEN_N_PLAYER(13521): player.c: __msg_callback(859) > [__msg_callback] End
08-13 01:40:41.630+0900 W/TIZEN_N_PLAYER(13521): player.c: __msg_callback(660) > [__msg_callback] Got message type : 0x3
08-13 01:40:41.630+0900 I/TIZEN_N_PLAYER(13521): player.c: __msg_callback(686) > STATE CHANGED INTERNALLY - from : 1,  to : 3 (CAPI State : 1)
08-13 01:40:41.630+0900 W/TIZEN_N_PLAYER(13521): player.c: __msg_callback(859) > [__msg_callback] End
08-13 01:40:41.630+0900 I/TIZEN_N_PLAYER(13521): player.c: player_prepare(1343) > [player_prepare] End
08-13 01:40:41.630+0900 I/TIZEN_N_PLAYER(13521): player.c: player_start(1582) > [player_start] Start
08-13 01:40:41.640+0900 W/TIZEN_N_PLAYER(13521): player.c: __msg_callback(660) > [__msg_callback] Got message type : 0x3
08-13 01:40:41.640+0900 I/TIZEN_N_PLAYER(13521): player.c: __msg_callback(686) > STATE CHANGED INTERNALLY - from : 3,  to : 2 (CAPI State : 2)
08-13 01:40:41.640+0900 W/TIZEN_N_PLAYER(13521): player.c: __msg_callback(859) > [__msg_callback] End
08-13 01:40:41.640+0900 W/TIZEN_N_PLAYER(13521): player.c: __msg_callback(660) > [__msg_callback] Got message type : 0x104
08-13 01:40:41.640+0900 I/TIZEN_N_PLAYER(13521): player.c: __msg_callback(708) > [__msg_callback] Ready to streaming information (BOS) [current state : 2]
08-13 01:40:41.640+0900 W/TIZEN_N_PLAYER(13521): player.c: __msg_callback(859) > [__msg_callback] End
08-13 01:40:41.640+0900 I/TIZEN_N_PLAYER(13521): player.c: player_start(1632) > [player_start] End
08-13 01:40:41.640+0900 E/record  (13521): buffer size : 4410000
08-13 01:40:41.650+0900 E/record  (13521): perfect_song_routine start
08-13 01:40:41.670+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:41.720+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:41.770+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:41.820+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:41.880+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:41.920+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:41.970+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:42.030+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:42.080+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:42.130+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:42.180+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:42.230+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:42.280+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:42.340+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:42.380+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:42.430+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:42.480+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:42.530+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:42.580+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:42.640+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:42.690+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:42.740+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:42.790+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:42.840+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:42.890+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:42.940+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:43.010+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:43.200+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:43.360+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:43.550+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:43.750+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:43.950+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:44.110+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:44.310+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:44.480+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:44.680+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:44.870+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:45.030+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:45.230+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:45.430+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:45.600+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:45.800+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:46.000+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:46.160+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:46.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 01:40:46.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 01:40:46.260+0900 I/Tizen::Net::Wifi(  961): (1072) > _WifiService is not registered.
08-13 01:40:46.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 01:40:46.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
08-13 01:40:46.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 303 5 28 25"
08-13 01:40:46.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 331 5 28 25"
08-13 01:40:46.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 359 5 28 25"
08-13 01:40:46.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 387 5 28 25"
08-13 01:40:46.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 01:40:46.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 01:40:46.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 01:40:46.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
08-13 01:40:46.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 198 567 5 28 25"
08-13 01:40:46.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 200 595 5 28 25"
08-13 01:40:46.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 623 5 28 25"
08-13 01:40:46.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 651 5 28 25"
08-13 01:40:46.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 679 5 28 25"
08-13 01:40:46.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 707 5 28 25"
08-13 01:40:46.360+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:46.520+0900 I/record  (13521): note : 55 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:40:46.710+0900 I/record  (13521): note : 55 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:40:46.910+0900 F/record  (13521): ===next node===
08-13 01:40:46.910+0900 I/record  (13521): note : 52 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:47.080+0900 I/record  (13521): note : 52 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:40:47.260+0900 I/Tizen::Net::Wifi(  961): (1072) > _WifiService is not registered.
08-13 01:40:47.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 01:40:47.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 01:40:47.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 01:40:47.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
08-13 01:40:47.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 303 5 28 25"
08-13 01:40:47.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 331 5 28 25"
08-13 01:40:47.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 359 5 28 25"
08-13 01:40:47.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 387 5 28 25"
08-13 01:40:47.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 01:40:47.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 01:40:47.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 01:40:47.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
08-13 01:40:47.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 198 567 5 28 25"
08-13 01:40:47.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 200 595 5 28 25"
08-13 01:40:47.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 623 5 28 25"
08-13 01:40:47.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 651 5 28 25"
08-13 01:40:47.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 679 5 28 25"
08-13 01:40:47.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 707 5 28 25"
08-13 01:40:47.290+0900 I/record  (13521): note : 52 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:40:47.480+0900 F/record  (13521): ===next node===
08-13 01:40:47.480+0900 I/record  (13521): note : 52 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:40:47.640+0900 I/record  (13521): note : 52 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:40:47.840+0900 F/record  (13521): ===next node===
08-13 01:40:47.840+0900 I/record  (13521): note : 55 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:40:48.000+0900 F/record  (13521): ===next node===
08-13 01:40:48.000+0900 I/record  (13521): note : 52 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:40:48.200+0900 I/record  (13521): note : 52 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:40:48.410+0900 F/record  (13521): ===next node===
08-13 01:40:48.410+0900 I/record  (13521): note : 48 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:40:48.570+0900 F/record  (13521): ===next node===
08-13 01:40:48.570+0900 I/record  (13521): note : 50 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:48.770+0900 I/record  (13521): note : 50 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:48.970+0900 I/record  (13521): note : 50 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:40:49.130+0900 I/record  (13521): note : 50 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:40:49.330+0900 F/record  (13521): ===next node===
08-13 01:40:49.330+0900 I/record  (13521): note : 52 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:49.490+0900 I/record  (13521): note : 52 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:40:49.700+0900 I/record  (13521): note : 52 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:40:49.900+0900 F/record  (13521): ===next node===
08-13 01:40:49.900+0900 I/record  (13521): note : 50 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:40:50.060+0900 F/record  (13521): ===next node===
08-13 01:40:50.060+0900 I/record  (13521): note : 48 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:40:50.260+0900 I/record  (13521): note : 48 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:40:50.420+0900 F/record  (13521): ===next node===
08-13 01:40:50.420+0900 I/record  (13521): note : 52 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:40:50.620+0900 I/record  (13521): note : 52 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:40:50.820+0900 F/record  (13521): ===next node===
08-13 01:40:50.820+0900 I/record  (13521): note : 55 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:40:50.990+0900 F/record  (13521): ===next node===
08-13 01:40:50.990+0900 I/record  (13521): note : 60 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:51.180+0900 I/record  (13521): note : 60 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:51.380+0900 I/record  (13521): note : 60 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:40:51.540+0900 I/record  (13521): note : 60 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:40:51.740+0900 F/record  (13521): ===next node===
08-13 01:40:51.740+0900 I/record  (13521): note : 55 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:40:51.940+0900 F/record  (13521): ===next node===
08-13 01:40:51.940+0900 I/record  (13521): note : 60 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:40:52.100+0900 I/record  (13521): note : 60 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:40:52.300+0900 I/record  (13521): note : 60 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:40:52.460+0900 F/record  (13521): ===next node===
08-13 01:40:52.460+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:52.660+0900 F/record  (13521): ===next node===
08-13 01:40:52.660+0900 I/record  (13521): note : 60 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:40:52.870+0900 F/record  (13521): ===next node===
08-13 01:40:52.870+0900 I/record  (13521): note : 55 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:40:53.020+0900 I/record  (13521): note : 55 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:40:53.230+0900 F/record  (13521): ===next node===
08-13 01:40:53.230+0900 I/record  (13521): note : 52 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:40:53.430+0900 F/record  (13521): ===next node===
08-13 01:40:53.430+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:53.590+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:53.790+0900 I/record  (13521): note : 55 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:40:53.950+0900 I/record  (13521): note : 55 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:40:54.130+0900 F/record  (13521): ===next node===
08-13 01:40:54.130+0900 I/record  (13521): note : 50 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:54.340+0900 I/record  (13521): note : 50 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:40:54.540+0900 I/record  (13521): note : 50 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:40:54.700+0900 F/record  (13521): ===next node===
08-13 01:40:54.700+0900 I/record  (13521): note : 53 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:40:54.900+0900 F/record  (13521): ===next node===
08-13 01:40:54.900+0900 I/record  (13521): note : 52 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:40:55.060+0900 I/record  (13521): note : 52 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:40:55.260+0900 F/record  (13521): ===next node===
08-13 01:40:55.260+0900 I/record  (13521): note : 50 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:40:55.460+0900 F/record  (13521): ===next node===
08-13 01:40:55.470+0900 I/record  (13521): note : 48 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:40:55.630+0900 I/record  (13521): note : 48 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:40:55.830+0900 I/record  (13521): note : 48 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:40:55.990+0900 I/record  (13521): note : 48 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:40:56.190+0900 F/record  (13521): ===next node===
08-13 01:40:56.190+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:56.390+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:56.560+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:56.760+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:56.950+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:57.120+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:57.320+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:57.480+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:57.680+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:57.880+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:58.050+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:58.250+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:58.410+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:58.600+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:58.800+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:59.010+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:59.160+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:59.360+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:59.520+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:59.730+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:40:59.920+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:41:00.090+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:41:00.280+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:41:00.490+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:41:00.650+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:41:00.850+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:41:01.020+0900 I/record  (13521): note : 55 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:41:01.220+0900 F/record  (13521): ===next node===
08-13 01:41:01.220+0900 I/record  (13521): note : 52 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:41:01.380+0900 I/record  (13521): note : 52 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:41:01.580+0900 I/record  (13521): note : 52 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:41:01.780+0900 F/record  (13521): ===next node===
08-13 01:41:01.780+0900 I/record  (13521): note : 52 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:41:01.940+0900 I/record  (13521): note : 52 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:41:02.150+0900 F/record  (13521): ===next node===
08-13 01:41:02.150+0900 I/record  (13521): note : 55 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:41:02.340+0900 I/record  (13521): note : 55 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:41:02.500+0900 F/record  (13521): ===next node===
08-13 01:41:02.500+0900 I/record  (13521): note : 52 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:41:02.710+0900 F/record  (13521): ===next node===
08-13 01:41:02.710+0900 I/record  (13521): note : 48 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:41:02.860+0900 I/record  (13521): note : 48 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:41:03.060+0900 F/record  (13521): ===next node===
08-13 01:41:03.060+0900 I/record  (13521): note : 50 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:41:03.260+0900 I/record  (13521): note : 50 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:41:03.460+0900 I/record  (13521): note : 50 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:41:03.620+0900 F/record  (13521): ===next node===
08-13 01:41:03.620+0900 I/record  (13521): note : 52 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:41:03.820+0900 I/record  (13521): note : 52 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:41:03.980+0900 I/record  (13521): note : 52 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:41:04.190+0900 F/record  (13521): ===next node===
08-13 01:41:04.190+0900 I/record  (13521): note : 50 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:41:04.260+0900 I/Tizen::Net::Wifi(  961): (1072) > _WifiService is not registered.
08-13 01:41:04.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 01:41:04.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 01:41:04.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 01:41:04.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
08-13 01:41:04.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 303 5 28 25"
08-13 01:41:04.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 331 5 28 25"
08-13 01:41:04.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 359 5 28 25"
08-13 01:41:04.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 387 5 28 25"
08-13 01:41:04.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 01:41:04.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 01:41:04.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 01:41:04.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
08-13 01:41:04.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 198 567 5 28 25"
08-13 01:41:04.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 200 595 5 28 25"
08-13 01:41:04.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 623 5 28 25"
08-13 01:41:04.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 651 5 28 25"
08-13 01:41:04.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 679 5 28 25"
08-13 01:41:04.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 707 5 28 25"
08-13 01:41:04.380+0900 I/record  (13521): note : 50 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:41:04.550+0900 F/record  (13521): ===next node===
08-13 01:41:04.550+0900 I/record  (13521): note : 48 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:41:04.750+0900 I/record  (13521): note : 48 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:41:04.910+0900 F/record  (13521): ===next node===
08-13 01:41:04.910+0900 I/record  (13521): note : 52 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:41:05.110+0900 F/record  (13521): ===next node===
08-13 01:41:05.110+0900 I/record  (13521): note : 55 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:41:05.260+0900 I/Tizen::Net::Wifi(  961): (1072) > _WifiService is not registered.
08-13 01:41:05.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 01:41:05.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 01:41:05.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 01:41:05.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
08-13 01:41:05.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 303 5 28 25"
08-13 01:41:05.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 331 5 28 25"
08-13 01:41:05.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 359 5 28 25"
08-13 01:41:05.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 387 5 28 25"
08-13 01:41:05.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 01:41:05.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 01:41:05.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 01:41:05.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
08-13 01:41:05.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 198 567 5 28 25"
08-13 01:41:05.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 200 595 5 28 25"
08-13 01:41:05.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 623 5 28 25"
08-13 01:41:05.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 651 5 28 25"
08-13 01:41:05.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 679 5 28 25"
08-13 01:41:05.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 707 5 28 25"
08-13 01:41:05.310+0900 I/record  (13521): note : 55 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:41:05.470+0900 F/record  (13521): ===next node===
08-13 01:41:05.470+0900 I/record  (13521): note : 60 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:41:05.670+0900 I/record  (13521): note : 60 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:41:05.870+0900 I/record  (13521): note : 60 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:41:06.030+0900 I/record  (13521): note : 60 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:41:06.220+0900 F/record  (13521): ===next node===
08-13 01:41:06.220+0900 I/record  (13521): note : 55 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:41:06.420+0900 F/record  (13521): ===next node===
08-13 01:41:06.420+0900 I/record  (13521): note : 60 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:41:06.580+0900 I/record  (13521): note : 60 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:41:06.790+0900 F/record  (13521): ===next node===
08-13 01:41:06.790+0900 I/record  (13521): note : 55 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:41:06.950+0900 F/record  (13521): ===next node===
08-13 01:41:06.950+0900 I/record  (13521): note : 60 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:41:07.150+0900 I/record  (13521): note : 60 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:41:07.350+0900 F/record  (13521): ===next node===
08-13 01:41:07.350+0900 I/record  (13521): note : 55 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:41:07.510+0900 F/record  (13521): ===next node===
08-13 01:41:07.510+0900 I/record  (13521): note : 52 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:41:07.710+0900 I/record  (13521): note : 52 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:41:07.910+0900 F/record  (13521): ===next node===
08-13 01:41:07.910+0900 I/record  (13521): note : 55 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:41:08.080+0900 I/record  (13521): note : 55 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:41:08.270+0900 I/record  (13521): note : 55 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:41:08.480+0900 F/record  (13521): ===next node===
08-13 01:41:08.480+0900 I/record  (13521): note : 50 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:41:08.630+0900 I/record  (13521): note : 50 detect :21 isHit : 3 [0: 1071644672/-1391580316]
08-13 01:41:08.840+0900 I/record  (13521): note : 50 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:41:09.000+0900 F/record  (13521): ===next node===
08-13 01:41:09.000+0900 I/record  (13521): note : 53 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:41:09.190+0900 I/record  (13521): note : 53 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:41:09.380+0900 F/record  (13521): ===next node===
08-13 01:41:09.380+0900 I/record  (13521): note : 52 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:41:09.580+0900 F/record  (13521): ===next node===
08-13 01:41:09.580+0900 I/record  (13521): note : 50 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:41:09.750+0900 I/record  (13521): note : 50 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:41:09.950+0900 F/record  (13521): ===next node===
08-13 01:41:09.950+0900 I/record  (13521): note : 48 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:41:10.110+0900 I/record  (13521): note : 48 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:41:10.310+0900 I/record  (13521): note : 48 detect :21 isHit : -2 [0: 1071644672/-1391580316]
08-13 01:41:13.510+0900 E/record  (13521): perfect_song_end
08-13 01:41:16.540+0900 W/TIZEN_N_PLAYER(13521): player.c: __msg_callback(660) > [__msg_callback] Got message type : 0x105
08-13 01:41:16.540+0900 W/TIZEN_N_PLAYER(13521): player.c: __msg_callback(859) > [__msg_callback] End
08-13 01:41:26.260+0900 I/Tizen::Net::Wifi(  961): (1072) > _WifiService is not registered.
08-13 01:41:26.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 01:41:26.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 01:41:26.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 01:41:26.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
08-13 01:41:26.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 303 5 28 25"
08-13 01:41:26.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 331 5 28 25"
08-13 01:41:26.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 359 5 28 25"
08-13 01:41:26.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 387 5 28 25"
08-13 01:41:26.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 01:41:26.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 01:41:26.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 01:41:26.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
08-13 01:41:26.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 198 567 5 28 25"
08-13 01:41:26.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 200 595 5 28 25"
08-13 01:41:26.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 623 5 28 25"
08-13 01:41:26.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 651 5 28 25"
08-13 01:41:26.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 679 5 28 25"
08-13 01:41:26.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 707 5 28 25"
08-13 01:41:27.260+0900 I/Tizen::Net::Wifi(  961): (1072) > _WifiService is not registered.
08-13 01:41:27.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 01:41:27.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 01:41:27.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 01:41:27.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
08-13 01:41:27.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 303 5 28 25"
08-13 01:41:27.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 331 5 28 25"
08-13 01:41:27.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 359 5 28 25"
08-13 01:41:27.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 387 5 28 25"
08-13 01:41:27.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 01:41:27.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 01:41:27.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 01:41:27.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
08-13 01:41:27.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 198 567 5 28 25"
08-13 01:41:27.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 200 595 5 28 25"
08-13 01:41:27.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 623 5 28 25"
08-13 01:41:27.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 651 5 28 25"
08-13 01:41:27.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 679 5 28 25"
08-13 01:41:27.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 707 5 28 25"
08-13 01:41:28.250+0900 I/Tizen::Net::Wifi(  961): (1072) > _WifiService is not registered.
08-13 01:41:28.250+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 01:41:28.250+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 01:41:28.250+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 01:41:28.250+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
08-13 01:41:28.250+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 303 5 28 25"
08-13 01:41:28.250+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 331 5 28 25"
08-13 01:41:28.250+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 359 5 28 25"
08-13 01:41:28.250+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 387 5 28 25"
08-13 01:41:28.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 01:41:28.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 01:41:28.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 01:41:28.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
08-13 01:41:28.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 198 567 5 28 25"
08-13 01:41:28.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 200 595 5 28 25"
08-13 01:41:28.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 623 5 28 25"
08-13 01:41:28.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 651 5 28 25"
08-13 01:41:28.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 679 5 28 25"
08-13 01:41:28.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 707 5 28 25"
08-13 01:41:34.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 01:41:34.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 01:41:34.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 01:41:34.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
08-13 01:41:34.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 303 5 28 25"
08-13 01:41:34.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 331 5 28 25"
08-13 01:41:34.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 359 5 28 25"
08-13 01:41:34.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 387 5 28 25"
08-13 01:41:34.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 01:41:34.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 01:41:34.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 01:41:34.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
08-13 01:41:34.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 198 567 5 28 25"
08-13 01:41:34.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 200 595 5 28 25"
08-13 01:41:34.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 623 5 28 25"
08-13 01:41:34.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 651 5 28 25"
08-13 01:41:34.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 679 5 28 25"
08-13 01:41:34.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 707 5 28 25"
08-13 01:41:34.270+0900 I/Tizen::Net::Wifi(  961): (1072) > _WifiService is not registered.
08-13 01:41:47.260+0900 I/Tizen::Net::Wifi(  961): (1072) > _WifiService is not registered.
08-13 01:41:47.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 01:41:47.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 01:41:47.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 01:41:47.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
08-13 01:41:47.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 303 5 28 25"
08-13 01:41:47.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 331 5 28 25"
08-13 01:41:47.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 359 5 28 25"
08-13 01:41:47.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 387 5 28 25"
08-13 01:41:47.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 01:41:47.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 01:41:47.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 01:41:47.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
08-13 01:41:47.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 198 567 5 28 25"
08-13 01:41:47.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 200 595 5 28 25"
08-13 01:41:47.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 623 5 28 25"
08-13 01:41:47.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 651 5 28 25"
08-13 01:41:47.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 679 5 28 25"
08-13 01:41:47.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 707 5 28 25"
08-13 01:41:48.260+0900 I/Tizen::Net::Wifi(  961): (1072) > _WifiService is not registered.
08-13 01:41:48.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 01:41:48.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 01:41:48.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 01:41:48.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
08-13 01:41:48.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 303 5 28 25"
08-13 01:41:48.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 331 5 28 25"
08-13 01:41:48.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 359 5 28 25"
08-13 01:41:48.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 387 5 28 25"
08-13 01:41:48.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 01:41:48.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 01:41:48.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 01:41:48.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
08-13 01:41:48.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 198 567 5 28 25"
08-13 01:41:48.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 200 595 5 28 25"
08-13 01:41:48.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 623 5 28 25"
08-13 01:41:48.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 651 5 28 25"
08-13 01:41:48.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 679 5 28 25"
08-13 01:41:48.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 707 5 28 25"
08-13 01:42:14.250+0900 F/record  (13521): perfectsong button Callback
08-13 01:42:14.450+0900 E/asdf    (13521): -1190792272
08-13 01:42:14.450+0900 E/asdf    (13521): -1190792272
08-13 01:42:14.450+0900 I/TIZEN_N_PLAYER(13521): player.c: player_stop(1639) > [player_stop] Start
08-13 01:42:14.490+0900 W/TIZEN_N_PLAYER(13521): player.c: __msg_callback(660) > [__msg_callback] Got message type : 0x3
08-13 01:42:14.490+0900 I/TIZEN_N_PLAYER(13521): player.c: __msg_callback(686) > STATE CHANGED INTERNALLY - from : 2,  to : 1 (CAPI State : 3)
08-13 01:42:14.490+0900 W/TIZEN_N_PLAYER(13521): player.c: __msg_callback(859) > [__msg_callback] End
08-13 01:42:14.490+0900 I/TIZEN_N_PLAYER(13521): player.c: player_stop(1665) > [player_stop] End
08-13 01:42:14.660+0900 W/AUL_AMD (  444): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
08-13 01:42:14.660+0900 W/AUL_AMD (  444): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
08-13 01:42:14.700+0900 I/AUL_PAD (  498): sigchild.h: __launchpad_sig_child(142) > dead_pid = 13521 pgid = 13521
08-13 01:42:14.700+0900 I/AUL_PAD (  498): sigchild.h: __sigchild_action(123) > dead_pid(13521)
08-13 01:42:14.700+0900 I/AUL_PAD (  498): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
08-13 01:42:14.700+0900 I/AUL_PAD (  498): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
08-13 01:42:14.710+0900 I/Tizen::System(  937): (246) > Terminated app [org.samteam.perfectsong]
08-13 01:42:14.710+0900 I/Tizen::Io(  937): (729) > Entry not found
08-13 01:42:14.710+0900 I/Tizen::App(  887): (243) > App[org.samteam.perfectsong] pid[13521] terminate event is forwarded
08-13 01:42:14.710+0900 I/Tizen::System(  887): (256) > osp.accessorymanager.service provider is found.
08-13 01:42:14.710+0900 I/Tizen::System(  887): (196) > Accessory Owner is removed [org.samteam.perfectsong, 13521, ]
08-13 01:42:14.710+0900 I/Tizen::System(  887): (256) > osp.system.service provider is found.
08-13 01:42:14.710+0900 I/Tizen::App(  887): (506) > TerminatedApp(org.samteam.perfectsong)
08-13 01:42:14.710+0900 I/Tizen::App(  887): (512) > Not registered pid(13521)
08-13 01:42:14.710+0900 I/Tizen::App(  887): (782) > Finished invoking application event listener for org.samteam.perfectsong, 13521.
08-13 01:42:14.710+0900 I/AUL_AMD (  444): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 13521
08-13 01:42:14.720+0900 I/Tizen::System(  937): (157) > change brightness system value.
08-13 01:42:14.720+0900 I/Tizen::App(  937): (782) > Finished invoking application event listener for org.samteam.perfectsong, 13521.
08-13 01:42:14.740+0900 W/PROCESSMGR(  407): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=589
08-13 01:42:14.750+0900 W/CRASH_MANAGER(13938): worker.c: worker_job(1198) > 1113521706161143939773
