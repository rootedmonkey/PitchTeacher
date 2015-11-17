S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.0
Build-Number: Z130HDDU0BOB3
Build-Date: 2015.02.14 15:10:17

Crash Information
Process Name: paaaaaaaaa
PID: 9285
Date: 2015-08-12 21:08:55+0900
Executable File Path: /opt/usr/apps/org.samteam.perfectsong/bin/paaaaaaaaa
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 9285, uid 5000)

Register Information
r0   = 0xb3400010, r1   = 0x00000000
r2   = 0x00000000, r3   = 0xb3400048
r4   = 0xb3400010, r5   = 0x00000010
r6   = 0x00000002, r7   = 0xb3498ec0
r8   = 0xb784e418, r9   = 0xbe8b9efc
r10  = 0x0000000c, fp   = 0xbe8b9e64
ip   = 0xb610da88, sp   = 0xbe8b9d88
lr   = 0xb6c97a80, pc   = 0xb6c94eb4
cpsr = 0xa0000010

Memory Information
MemTotal:   730748 KB
MemFree:    169608 KB
Buffers:     37412 KB
Cached:     237316 KB
VmPeak:     143684 KB
VmSize:     140240 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       21808 KB
VmRSS:       21676 KB
VmData:      78388 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       26264 KB
VmPTE:          88 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 9285 TID = 9285
9285 9293 9294 9298 

Maps Information
af2d2000 afad1000 rwxp [stack:9298]
afed3000 b06d2000 rwxp [stack:9294]
b0adb000 b12da000 rwxp [stack:9293]
b3f20000 b3f21000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3f29000 b3f30000 r-xp /usr/lib/libfeedback.so.0.1.4
b3f46000 b3f47000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
b3f4f000 b3f51000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
b3f59000 b3f5a000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
b3f62000 b3f79000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b40d5000 b40d9000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b40e2000 b40ec000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b4426000 b44f0000 r-xp /usr/lib/libCOREGL.so.4.0
b4501000 b4506000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b450e000 b4513000 r-xp /usr/lib/libxcb-render.so.0.0.0
b451c000 b451d000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4526000 b453e000 r-xp /usr/lib/libpng12.so.0.50.0
b4546000 b4549000 r-xp /usr/lib/libEGL.so.1.4
b4551000 b455f000 r-xp /usr/lib/libGLESv2.so.2.0
b4568000 b456c000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b4575000 b457e000 r-xp /usr/lib/libmdm-common.so.1.0.45
b4586000 b45ce000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b45cf000 b45d5000 r-xp /usr/lib/libjson.so.0.1.0
b45dd000 b463e000 r-xp /usr/lib/libasound.so.2.0.0
b4648000 b464c000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
b4654000 b4657000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b4660000 b4668000 r-xp /usr/lib/libui-extension.so.0.1.0
b4669000 b466c000 r-xp /usr/lib/libnative-buffer.so.0.1.0
b4674000 b4677000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.22
b467f000 b4735000 r-xp /usr/lib/libcairo.so.2.11200.14
b4740000 b4752000 r-xp /usr/lib/libtts.so
b475a000 b4899000 r-xp /usr/lib/libicui18n.so.51.1
b48a9000 b48af000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b48b8000 b48c5000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
b48ce000 b48d6000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b48de000 b48e0000 r-xp /usr/lib/libdri2.so.0.0.0
b48e8000 b48ef000 r-xp /usr/lib/libdrm.so.2.4.0
b48f8000 b490b000 r-xp /usr/lib/libmdm.so.1.0.88
b4913000 b491b000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b492a000 b492c000 r-xp /usr/lib/libiniparser.so.0
b4936000 b494c000 r-xp /usr/lib/lib_SamsungRec_TizenV04009.so
b497a000 b497d000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b4985000 b49bc000 r-xp /usr/lib/libpulse.so.0.16.2
b49c5000 b49db000 r-xp /usr/lib/libavsysaudio.so.0.0.1
b49e3000 b49ea000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b49f2000 b49fc000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
b4a08000 b4a0d000 r-xp /usr/lib/libmmfsession.so.0.0.0
b4a15000 b4a2b000 r-xp /usr/lib/libefl-assist.so.0.1.0
b4a33000 b4ace000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
b4ada000 b4add000 r-xp /usr/lib/libmm_ta.so.0.0.0
b4ae5000 b4b31000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b4b39000 b4b40000 r-xp /usr/lib/libtbm.so.1.0.0
b4b48000 b4b4d000 r-xp /usr/lib/libcapi-media-tool.so.0.1.3
b4b55000 b4b69000 r-xp /usr/lib/libmmfsound.so.0.1.0
b4b72000 b4b79000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.4
b4b82000 b4b9a000 r-xp /usr/lib/libcapi-media-player.so.0.1.75
b4ba2000 b4ba8000 r-xp /usr/lib/libcapi-media-audio-io.so.0.2.31
b4bb2000 b4bbc000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
b4bc5000 b4bce000 r-xp /opt/usr/apps/org.samteam.perfectsong/bin/paaaaaaaaa
b4dab000 b4db5000 r-xp /lib/libnss_files-2.13.so
b4dbe000 b4dd0000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b4dd8000 b4dee000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b4df6000 b4ec4000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b4edb000 b4eff000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b4f08000 b4f0e000 r-xp /usr/lib/libappsvc.so.0.1.0
b4f16000 b4f24000 r-xp /usr/lib/libail.so.0.1.0
b4f2c000 b4f2e000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.3
b4f37000 b4f3c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b4f45000 b4f47000 r-xp /usr/lib/libefl-extension.so.0.1.0
b4f4f000 b4f50000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b4f59000 b4f5d000 r-xp /usr/lib/libogg.so.0.7.1
b4f65000 b4f87000 r-xp /usr/lib/libvorbis.so.0.4.3
b4f8f000 b5073000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b5087000 b50b8000 r-xp /usr/lib/libFLAC.so.8.2.0
b5a52000 b5ae6000 r-xp /usr/lib/libstdc++.so.6.0.16
b5af9000 b5afb000 r-xp /usr/lib/libXau.so.6.0.0
b5b03000 b5b0d000 r-xp /usr/lib/libspdy.so.0.0.0
b5b16000 b5b62000 r-xp /usr/lib/libssl.so.1.0.0
b5b6f000 b5b9d000 r-xp /usr/lib/libidn.so.11.5.44
b5ba5000 b5baf000 r-xp /usr/lib/libcares.so.2.1.0
b5bb7000 b5bd8000 r-xp /usr/lib/libexif.so.12.3.3
b5beb000 b5c30000 r-xp /usr/lib/libsndfile.so.1.0.25
b5c3e000 b5c54000 r-xp /lib/libexpat.so.1.5.2
b5c5d000 b5d42000 r-xp /usr/lib/libicuuc.so.51.1
b5d57000 b5d8b000 r-xp /usr/lib/libicule.so.51.1
b5d94000 b5da7000 r-xp /usr/lib/libxcb.so.1.1.0
b5daf000 b5dec000 r-xp /usr/lib/libcurl.so.4.3.0
b5df5000 b5dfe000 r-xp /usr/lib/libethumb.so.1.7.99
b5e07000 b5e09000 r-xp /usr/lib/libctxdata.so.0.0.0
b5e11000 b5e1e000 r-xp /usr/lib/libremix.so.0.0.0
b5e26000 b5e27000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5e2f000 b5e46000 r-xp /usr/lib/liblua-5.1.so
b5e4f000 b5e56000 r-xp /usr/lib/libembryo.so.1.7.99
b5e5e000 b5e81000 r-xp /usr/lib/libjpeg.so.8.0.2
b5e99000 b5eef000 r-xp /usr/lib/libpixman-1.so.0.28.2
b5efc000 b5f4f000 r-xp /usr/lib/libfreetype.so.6.8.1
b5f5a000 b5f82000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5f83000 b5fc9000 r-xp /usr/lib/libharfbuzz.so.0.907.0
b5fd2000 b5fe5000 r-xp /usr/lib/libfribidi.so.0.3.1
b5fed000 b5ff0000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b5ff8000 b5ffc000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b6004000 b6009000 r-xp /usr/lib/libecore_fb.so.1.7.99
b6012000 b601c000 r-xp /usr/lib/libXext.so.6.4.0
b6024000 b6105000 r-xp /usr/lib/libX11.so.6.3.0
b6110000 b6113000 r-xp /usr/lib/libXtst.so.6.1.0
b611b000 b6121000 r-xp /usr/lib/libXrender.so.1.3.0
b6129000 b612e000 r-xp /usr/lib/libXrandr.so.2.2.0
b6136000 b6137000 r-xp /usr/lib/libXinerama.so.1.0.0
b6140000 b6148000 r-xp /usr/lib/libXi.so.6.1.0
b6149000 b614c000 r-xp /usr/lib/libXfixes.so.3.1.0
b6154000 b6156000 r-xp /usr/lib/libXgesture.so.7.0.0
b615e000 b6160000 r-xp /usr/lib/libXcomposite.so.1.0.0
b6168000 b6169000 r-xp /usr/lib/libXdamage.so.1.1.0
b6172000 b6178000 r-xp /usr/lib/libXcursor.so.1.0.2
b6181000 b619a000 r-xp /usr/lib/libecore_con.so.1.7.99
b61a4000 b61aa000 r-xp /usr/lib/libecore_imf.so.1.7.99
b61b2000 b61ba000 r-xp /usr/lib/libethumb_client.so.1.7.99
b61c2000 b61cb000 r-xp /usr/lib/libedbus.so.1.7.99
b61d3000 b6230000 r-xp /usr/lib/libedje.so.1.7.99
b6239000 b624a000 r-xp /usr/lib/libecore_input.so.1.7.99
b6252000 b6257000 r-xp /usr/lib/libecore_file.so.1.7.99
b625f000 b6278000 r-xp /usr/lib/libeet.so.1.7.99
b6289000 b628d000 r-xp /usr/lib/libappcore-common.so.1.1
b6295000 b635c000 r-xp /usr/lib/libevas.so.1.7.99
b6381000 b63a2000 r-xp /usr/lib/libecore_evas.so.1.7.99
b63ab000 b63da000 r-xp /usr/lib/libecore_x.so.1.7.99
b63e4000 b651b000 r-xp /usr/lib/libelementary.so.1.7.99
b6531000 b6532000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b653a000 b653e000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.3
b6549000 b654c000 r-xp /lib/libgpg-error.so.0.5.0
b6554000 b65ac000 r-xp /usr/lib/libgcrypt.so.11.5.3
b65b6000 b65e2000 r-xp /usr/lib/libsystemd.so.0.0.1
b65eb000 b65ed000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b65f6000 b66c1000 r-xp /usr/lib/libxml2.so.2.7.8
b66cf000 b66df000 r-xp /lib/libresolv-2.13.so
b66e3000 b66f9000 r-xp /lib/libz.so.1.2.5
b6701000 b6703000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b670b000 b6710000 r-xp /usr/lib/libffi.so.5.0.10
b6719000 b671a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b6722000 b6725000 r-xp /lib/libattr.so.1.1.0
b672d000 b6730000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6738000 b673f000 r-xp /usr/lib/libvconf.so.0.2.45
b6748000 b68ef000 r-xp /usr/lib/libcrypto.so.1.0.0
b6911000 b6927000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b692f000 b6998000 r-xp /lib/libm-2.13.so
b69a1000 b69e1000 r-xp /usr/lib/libeina.so.1.7.99
b69ea000 b6a1e000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b6a27000 b6afb000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b6b07000 b6b0c000 r-xp /usr/lib/libcapi-base-common.so.0.1.6
b6b15000 b6b1b000 r-xp /lib/librt-2.13.so
b6b24000 b6b2b000 r-xp /lib/libcrypt-2.13.so
b6b5b000 b6b5e000 r-xp /lib/libcap.so.2.21
b6b66000 b6b68000 r-xp /usr/lib/libiri.so
b6b70000 b6b8f000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6b97000 b6bad000 r-xp /usr/lib/libecore.so.1.7.99
b6bc3000 b6bc8000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6bd1000 b6be8000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6bf1000 b6bfc000 r-xp /lib/libunwind.so.8.0.1
b6c29000 b6d44000 r-xp /lib/libc-2.13.so
b6d52000 b6d5a000 r-xp /lib/libgcc_s-4.6.4.so.1
b6d62000 b6d8c000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6d95000 b6d98000 r-xp /usr/lib/libbundle.so.0.1.22
b6da0000 b6da2000 r-xp /lib/libdl-2.13.so
b6dab000 b6dae000 r-xp /usr/lib/libsmack.so.1.0.0
b6db6000 b6e86000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6e87000 b6eec000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6ef6000 b6f08000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6f10000 b6f24000 r-xp /lib/libpthread-2.13.so
b6f2f000 b6f31000 r-xp /usr/lib/libdlog.so.0.0.0
b6f39000 b6f44000 r-xp /usr/lib/libaul.so.0.1.0
b6f56000 b6f59000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f63000 b6f67000 r-xp /usr/lib/libsys-assert.so
b6f70000 b6f8d000 r-xp /lib/ld-2.13.so
b6f96000 b6f9b000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
b77e7000 b7811000 rw-p [heap]
b7811000 b7b33000 rw-p [heap]
be8a9000 be8ca000 rwxp [stack]
End of Maps Information

Callstack Information (PID:9285)
Call Stack Count: 17
 0: (0xb6c94eb4) [/lib/libc.so.6] + 0x6beb4
 1: __libc_malloc + 0x80 (0xb6c97a80) [/lib/libc.so.6] + 0x6ea80
 2: (0xb604ed31) [/usr/lib/libX11.so.6] + 0x2ad31
 3: _XReply + 0x52 (0xb604f61b) [/usr/lib/libX11.so.6] + 0x2b61b
 4: DRI2GetBuffers + 0x84 (0xb48df20d) [/usr/lib/libdri2.so.0] + 0x120d
 5: (0xb4bba731) [/usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so] + 0x8731
 6: (0xb4bbac51) [/usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so] + 0x8c51
 7: (0xb4bb4821) [/usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so] + 0x2821
 8: (0xb62ecc89) [/usr/lib/libevas.so.1] + 0x57c89
 9: (0xb63921b5) [/usr/lib/libecore_evas.so.1] + 0x111b5
10: (0xb638f965) [/usr/lib/libecore_evas.so.1] + 0xe965
11: (0xb6ba0cfd) [/usr/lib/libecore.so.1] + 0x9cfd
12: (0xb6ba2127) [/usr/lib/libecore.so.1] + 0xb127
13: ecore_main_loop_begin + 0x30 (0xb6ba2691) [/usr/lib/libecore.so.1] + 0xb691
14: appcore_efl_main + 0x17e (0xb6f58387) [/usr/lib/libappcore-efl.so.1] + 0x2387
15: ui_app_main + 0xb0 (0xb653c499) [/usr/lib/libcapi-appfw-application.so.0] + 0x2499
16: main + 0x11e (0xb4bca44f) [/opt/usr/apps/org.samteam.perfectsong/bin/paaaaaaaaa] + 0x544f
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

08-12 21:08:07.856+0900 I/CAPI_APPFW_APPLICATION(28265): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:07.856+0900 I/CAPI_APPFW_APPLICATION(  698): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:07.856+0900 W/CAM_APP (28265): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-12 21:08:07.976+0900 I/CAPI_APPFW_APPLICATION(29276): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:07.976+0900 I/CAPI_APPFW_APPLICATION(28265): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:07.976+0900 I/CAPI_APPFW_APPLICATION(  698): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:07.976+0900 W/CAM_APP (28265): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-12 21:08:08.316+0900 E/rpm-installer( 9214): coretpk-installer.c: _coretpk_installer_get_smack_label_access(964) > Error in getting smack ACCESS label failed. result[-1] (path:[/opt/usr/apps/org.samteam.perfectsong/shared/data]))
08-12 21:08:08.336+0900 I/CAPI_APPFW_APPLICATION(28265): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:08.336+0900 I/CAPI_APPFW_APPLICATION(  698): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:08.336+0900 I/CAPI_APPFW_APPLICATION(29276): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:08.336+0900 W/CAM_APP (28265): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-12 21:08:08.996+0900 E/PKGMGR_INFO( 9214): pkgmgrinfo_feature.c: pkgmgrinfo_updateinfo_remove(528) > (strstr(vconf_str, pkgid_is) == NULL) pkgid is already removed
08-12 21:08:09.006+0900 I/Tizen::App(  886): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.samteam.perfectsong, key: install_percent, val: 100
08-12 21:08:09.006+0900 I/Tizen::App(  886): (119) > InstallationInProgress [100]
08-12 21:08:09.006+0900 I/Tizen::App(  886): (1584) > Package = [org.samteam.perfectsong], Key = [install_percent], Value = [100], install = [1]
08-12 21:08:09.006+0900 I/Tizen::App(  886): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.samteam.perfectsong, key: end, val: ok
08-12 21:08:09.006+0900 I/Tizen::App(  886): (78) > Installation is Completed. [Package = org.samteam.perfectsong]
08-12 21:08:09.006+0900 I/Tizen::App(  886): (663) > Enter. package(org.samteam.perfectsong), installationResult(0)
08-12 21:08:09.016+0900 E/cluster-home(  591): mainmenu-package-manager.cpp: OnClientListenCb(535) >  #Step 1
08-12 21:08:09.016+0900 E/cluster-home(  591): mainmenu-package-manager.cpp: OnClientListenCb(539) >  #Step 2
08-12 21:08:09.016+0900 E/cluster-home(  591): mainmenu-package-manager.cpp: _GetAppIds(344) >  BEGIN
08-12 21:08:09.026+0900 E/PKGMGR_INSTALLER( 9214): pkgmgr_installer.c: __send_event(114) > fail to remove update-service
08-12 21:08:09.026+0900 I/Tizen::App(  886): (1360) > package(org.samteam.perfectsong), version(1.0.0), type(rpm), displayName(paaaaaaaaa), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.samteam.perfectsong), storeClient(), appRootPath(/opt/usr/apps/org.samteam.perfectsong)
08-12 21:08:09.056+0900 E/cluster-home(  591): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(246) >  ##### [org.samteam.perfectsong]
08-12 21:08:09.056+0900 E/cluster-home(  591): mainmenu-package-manager.cpp: _GetAppIds(365) >  ##### [org.samteam.perfectsong]
08-12 21:08:09.056+0900 E/cluster-home(  591): mainmenu-package-manager.cpp: _GetAppIds(369) >  END
08-12 21:08:09.056+0900 E/cluster-home(  591): mainmenu-package-manager.cpp: _DoPkgJob(448) >  #Step 3 size[1]
08-12 21:08:09.056+0900 E/cluster-home(  591): mainmenu-package-manager.cpp: _DoPkgJob(452) >  appId[org.samteam.perfectsong]
08-12 21:08:09.066+0900 I/Tizen::App(  886): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.samteam.perfectsong]
08-12 21:08:09.076+0900 E/cluster-home(  591): mainmenu-package-manager.cpp: _GetAppInfo(941) >  AppId[org.samteam.perfectsong] Name[paaaaaaaaa] Icon[/opt/usr/apps/org.samteam.perfectsong/shared/res/mainIcon.png] enable[1] system[0]
08-12 21:08:09.076+0900 E/cluster-home(  591): mainmenu-package-manager.cpp: GetAppInfo(595) >  Find a App Info AppId[org.samteam.perfectsong] Name[paaaaaaaaa] Icon[/opt/usr/apps/org.samteam.perfectsong/shared/res/mainIcon.png] enable[1] system[0]
08-12 21:08:09.086+0900 I/Tizen::App(  886): (416) > appName = [paaaaaaaaa]
08-12 21:08:09.086+0900 I/Tizen::App(  886): (509) > exe = [/opt/usr/apps/org.samteam.perfectsong/bin/paaaaaaaaa], displayName = [paaaaaaaaa], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
08-12 21:08:09.086+0900 E/PKGMGR_INFO(  886): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(717) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
08-12 21:08:09.086+0900 I/Tizen::App(  886): (675) > Application count(1) in this package
08-12 21:08:09.086+0900 I/Tizen::App(  886): (855) > Enter.
08-12 21:08:09.086+0900 I/Tizen::App(  886): (695) > Exit.
08-12 21:08:09.086+0900 I/Tizen::App(  886): (1584) > Package = [org.samteam.perfectsong], Key = [end], Value = [ok], install = [96]
08-12 21:08:09.096+0900 I/Tizen::App(  886): (416) > appName = [paaaaaaaaa]
08-12 21:08:09.096+0900 I/Tizen::App(  886): (509) > exe = [/opt/usr/apps/org.samteam.perfectsong/bin/paaaaaaaaa], displayName = [paaaaaaaaa], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
08-12 21:08:09.096+0900 I/Tizen::App(  886): (2343) > info file is not existed. [/opt/usr/apps/org.samtea/info/org.samteam.perfectsong.info]
08-12 21:08:09.096+0900 I/Tizen::App(  886): (131) > Enter
08-12 21:08:09.106+0900 I/Tizen::App(  886): (137) > org.samteam.perfectsong does not have launch condition
08-12 21:08:09.106+0900 I/Tizen::App(  886): (898) > Exit.
08-12 21:08:11.126+0900 W/AUL_AMD (  433): amd_request.c: __request_handler(601) > __request_handler: 0
08-12 21:08:11.136+0900 I/AUL     (  433): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/launch_app, ret : 0
08-12 21:08:11.136+0900 I/AUL     (  433): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /bin/bash, ret : 0
08-12 21:08:11.136+0900 E/AUL_AMD (  433): amd_appinfo.c: appinfo_get_value(791) > appinfo get value: Invalid argument, 24
08-12 21:08:11.246+0900 I/CAPI_APPFW_APPLICATION( 9285): app_main.c: ui_app_main(699) > app_efl_main
08-12 21:08:11.256+0900 E/RESOURCED(  765): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 447
08-12 21:08:11.266+0900 I/Tizen::App(  918): (733) > Finished invoking application event listener for org.samteam.perfectsong, 9285.
08-12 21:08:11.266+0900 I/Tizen::App(  886): (499) > LaunchedApp(org.samteam.perfectsong)
08-12 21:08:11.266+0900 I/Tizen::App(  886): (733) > Finished invoking application event listener for org.samteam.perfectsong, 9285.
08-12 21:08:11.296+0900 I/UXT     ( 9285): uxt_object_manager.cpp: on_initialized(287) > Initialized.
08-12 21:08:11.336+0900 I/CAPI_APPFW_APPLICATION( 9285): app_main.c: _ui_app_appcore_create(560) > app_appcore_create
08-12 21:08:11.526+0900 E/EFL     ( 9285): elementary<9285> elm_layout.c:833 _elm_layout_smart_content_set() could not swallow 0xb7945d48 into part ''
08-12 21:08:11.586+0900 E/EFL     ( 9285): evas_main<9285> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
08-12 21:08:11.596+0900 E/EFL     ( 9285): evas_main<9285> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
08-12 21:08:11.796+0900 I/TIZEN_N_AUDIO_IO( 9285): audio_io_private.c: audio_in_create_private(267) > mm_sound_pcm_capture_open_ex() success
08-12 21:08:11.796+0900 I/TIZEN_N_AUDIO_IO( 9285): audio_io_private.c: audio_in_create_private(285) > mm_sound_pcm_set_message_callback() success
08-12 21:08:11.806+0900 I/TIZEN_N_AUDIO_IO( 9285): audio_io.c: audio_in_prepare(88) > [audio_in_prepare] mm_sound_pcm_capture_start() success
08-12 21:08:11.806+0900 I/CAPI_APPFW_APPLICATION( 9285): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
08-12 21:08:11.816+0900 I/APP_CORE( 9285): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
08-12 21:08:11.816+0900 I/APP_CORE( 9285): appcore-efl.c: __do_app(511) > [APP 9285] Initial Launching, call the resume_cb
08-12 21:08:11.816+0900 I/CAPI_APPFW_APPLICATION( 9285): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
08-12 21:08:11.956+0900 W/PROCESSMGR(  406): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=9285
08-12 21:08:11.996+0900 W/APP_CORE( 9285): appcore-efl.c: __show_cb(822) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4200002
08-12 21:08:12.006+0900 I/QUICKPANEL(  667): sound-profile.c: _view_update(106) > [_view_update : 106] sound : 0, vibration : 1
08-12 21:08:12.016+0900 I/QUICKPANEL(  667): quickpanel-ui.c: _ui_handler_input_region_set(172) > [_ui_handler_input_region_set : 172] win_input_0:0
08-12 21:08:12.016+0900 I/QUICKPANEL(  667): win_input_1:0
08-12 21:08:12.016+0900 I/QUICKPANEL(  667): win_input_2:42
08-12 21:08:12.016+0900 I/QUICKPANEL(  667): win_input_3:800
08-12 21:08:12.016+0900 I/QUICKPANEL(  667): 
08-12 21:08:12.026+0900 I/MALI    (  591): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0xb0635910] swap changed from sync to async
08-12 21:08:12.146+0900 I/Tizen::System(  918): (259) > Active app [org.samtea], current [com.samsun] 
08-12 21:08:12.146+0900 I/Tizen::Io(  918): (729) > Entry not found
08-12 21:08:12.156+0900 I/Tizen::System(  918): (157) > change brightness system value.
08-12 21:08:12.176+0900 I/CAPI_APPFW_APPLICATION(  591): app_main.c: app_appcore_pause(202) > app_appcore_pause
08-12 21:08:12.176+0900 E/cluster-home(  591): homescreen-main.cpp: app_pause(355) >  app pause
08-12 21:08:12.196+0900 W/AUL_AMD (  433): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
08-12 21:08:12.196+0900 W/AUL_AMD (  433): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
08-12 21:08:12.356+0900 I/CAPI_APPFW_APPLICATION(29276): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:12.356+0900 I/CAPI_APPFW_APPLICATION(28265): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:12.356+0900 W/CAM_APP (28265): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-12 21:08:12.356+0900 I/CAPI_APPFW_APPLICATION(  698): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:12.356+0900 I/CAPI_APPFW_APPLICATION( 9285): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:15.716+0900 I/CAPI_APPFW_APPLICATION(29276): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:15.716+0900 I/CAPI_APPFW_APPLICATION(28265): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:15.716+0900 I/CAPI_APPFW_APPLICATION(  698): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:15.716+0900 W/CAM_APP (28265): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-12 21:08:15.776+0900 I/CAPI_APPFW_APPLICATION( 9285): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:15.776+0900 I/CAPI_APPFW_APPLICATION(28265): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:15.776+0900 I/CAPI_APPFW_APPLICATION(29276): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:15.776+0900 W/CAM_APP (28265): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-12 21:08:15.776+0900 I/CAPI_APPFW_APPLICATION(  698): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:15.816+0900 I/CAPI_APPFW_APPLICATION( 9285): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:15.836+0900 I/CAPI_APPFW_APPLICATION( 9285): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:15.836+0900 I/CAPI_APPFW_APPLICATION(28265): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:15.836+0900 I/CAPI_APPFW_APPLICATION(29276): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:15.836+0900 I/CAPI_APPFW_APPLICATION(  698): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:15.836+0900 W/CAM_APP (28265): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-12 21:08:16.486+0900 E/TIZEN_N_AUDIO_IO( 9285): audio_io_private.c: audio_in_create_private(264) > mm_sound_pcm_capture_open_ex() failed [0x80000b03]
08-12 21:08:16.486+0900 E/TIZEN_N_AUDIO_IO( 9285): audio_io_private.c: __convert_audio_io_error_code(76) > [audio_in_create_private] AUDIO_IO_ERROR_SOUND_POLICY(0xfe700004) : core fw error(0x80000b03)
08-12 21:08:16.486+0900 I/TIZEN_N_AUDIO_IO( 9285): audio_io.c: audio_in_prepare(88) > [audio_in_prepare] mm_sound_pcm_capture_start() success
08-12 21:08:16.506+0900 E/record  ( 9285): buffer size : 4410000
08-12 21:08:16.526+0900 E/record  ( 9285): pitch_detect_routine start
08-12 21:08:16.526+0900 I/record  ( 9285): [A0] [라] [27.50 Hz]
08-12 21:08:16.526+0900 I/record  ( 9285): [A0] [라] [27.50 Hz]
08-12 21:08:16.526+0900 I/record  ( 9285): [A0] [라] [27.50 Hz]
08-12 21:08:16.526+0900 I/record  ( 9285): [A0] [라] [27.50 Hz]
08-12 21:08:16.526+0900 I/record  ( 9285): [A0] [라] [27.50 Hz]
08-12 21:08:16.536+0900 I/record  ( 9285): [A0] [라] [27.50 Hz]
08-12 21:08:16.536+0900 I/record  ( 9285): [A0] [라] [27.50 Hz]
08-12 21:08:16.536+0900 I/record  ( 9285): [A0] [라] [27.50 Hz]
08-12 21:08:16.536+0900 I/record  ( 9285): [A0] [라] [27.50 Hz]
08-12 21:08:16.536+0900 I/record  ( 9285): [A0] [라] [27.50 Hz]
08-12 21:08:16.536+0900 I/record  ( 9285): [A0] [라] [27.50 Hz]
08-12 21:08:16.546+0900 I/record  ( 9285): [A0] [라] [27.50 Hz]
08-12 21:08:16.546+0900 I/record  ( 9285): [A0] [라] [27.50 Hz]
08-12 21:08:16.546+0900 I/record  ( 9285): [A0] [라] [27.50 Hz]
08-12 21:08:16.546+0900 I/record  ( 9285): [A0] [라] [27.50 Hz]
08-12 21:08:16.546+0900 I/record  ( 9285): [A0] [라] [27.50 Hz]
08-12 21:08:16.556+0900 I/record  ( 9285): [A0] [라] [27.50 Hz]
08-12 21:08:16.556+0900 I/record  ( 9285): [A0] [라] [27.50 Hz]
08-12 21:08:16.556+0900 I/record  ( 9285): [A0] [라] [27.50 Hz]
08-12 21:08:16.556+0900 I/record  ( 9285): [A0] [라] [27.50 Hz]
08-12 21:08:16.556+0900 I/record  ( 9285): [A0] [라] [27.50 Hz]
08-12 21:08:16.566+0900 I/record  ( 9285): [A0] [라] [27.50 Hz]
08-12 21:08:16.566+0900 I/record  ( 9285): [A0] [라] [27.50 Hz]
08-12 21:08:16.566+0900 I/record  ( 9285): [A0] [라] [27.50 Hz]
08-12 21:08:16.576+0900 I/record  ( 9285): [A0] [라] [27.50 Hz]
08-12 21:08:16.646+0900 I/record  ( 9285): [A0] [라] [27.50 Hz]
08-12 21:08:16.846+0900 I/record  ( 9285): [A0] [라] [27.50 Hz]
08-12 21:08:17.036+0900 I/record  ( 9285): [A0] [라] [27.50 Hz]
08-12 21:08:17.206+0900 I/record  ( 9285): [A0] [라] [27.50 Hz]
08-12 21:08:17.406+0900 I/record  ( 9285): [A0] [라] [27.50 Hz]
08-12 21:08:17.606+0900 I/record  ( 9285): [A0] [라] [27.50 Hz]
08-12 21:08:17.766+0900 I/record  ( 9285): [A0] [라] [27.50 Hz]
08-12 21:08:17.966+0900 I/record  ( 9285): [A0] [라] [27.50 Hz]
08-12 21:08:18.206+0900 I/record  ( 9285): [A2] [라] [110.00 Hz]
08-12 21:08:18.406+0900 I/record  ( 9285): [A#2] [라#] [116.50 Hz]
08-12 21:08:18.606+0900 I/record  ( 9285): [A#2] [라#] [116.50 Hz]
08-12 21:08:18.756+0900 I/record  ( 9285): [A#2] [라#] [116.50 Hz]
08-12 21:08:18.966+0900 I/record  ( 9285): [B2] [시] [123.50 Hz]
08-12 21:08:19.166+0900 I/record  ( 9285): [B2] [시] [123.50 Hz]
08-12 21:08:19.326+0900 I/record  ( 9285): [B2] [시] [123.50 Hz]
08-12 21:08:19.526+0900 I/record  ( 9285): [C#3] [도#] [138.60 Hz]
08-12 21:08:19.726+0900 I/record  ( 9285): [C#3] [도#] [138.60 Hz]
08-12 21:08:19.886+0900 I/record  ( 9285): [C#3] [도#] [138.60 Hz]
08-12 21:08:20.086+0900 I/record  ( 9285): [C#3] [도#] [138.60 Hz]
08-12 21:08:20.286+0900 I/record  ( 9285): [C#3] [도#] [138.60 Hz]
08-12 21:08:20.446+0900 I/record  ( 9285): [C#3] [도#] [138.60 Hz]
08-12 21:08:20.636+0900 I/record  ( 9285): [C3] [도] [130.80 Hz]
08-12 21:08:20.836+0900 I/record  ( 9285): [C3] [도] [130.80 Hz]
08-12 21:08:20.986+0900 I/record  ( 9285): [C#3] [도#] [138.60 Hz]
08-12 21:08:21.196+0900 I/record  ( 9285): [C#3] [도#] [138.60 Hz]
08-12 21:08:21.386+0900 I/record  ( 9285): [C3] [도] [130.80 Hz]
08-12 21:08:21.546+0900 I/record  ( 9285): [C#3] [도#] [138.60 Hz]
08-12 21:08:21.746+0900 I/record  ( 9285): [C#3] [도#] [138.60 Hz]
08-12 21:08:21.956+0900 I/record  ( 9285): [C#3] [도#] [138.60 Hz]
08-12 21:08:22.106+0900 I/record  ( 9285): [C#3] [도#] [138.60 Hz]
08-12 21:08:22.296+0900 I/record  ( 9285): [C#3] [도#] [138.60 Hz]
08-12 21:08:22.486+0900 I/record  ( 9285): [C#3] [도#] [138.60 Hz]
08-12 21:08:22.696+0900 I/record  ( 9285): [C#3] [도#] [138.60 Hz]
08-12 21:08:22.846+0900 I/record  ( 9285): [C#3] [도#] [138.60 Hz]
08-12 21:08:23.056+0900 I/record  ( 9285): [D3] [레 ] [146.80 Hz]
08-12 21:08:23.246+0900 I/record  ( 9285): [D3] [레 ] [146.80 Hz]
08-12 21:08:23.306+0900 I/Tizen::Net::Wifi(  950): (1072) > _WifiService is not registered.
08-12 21:08:23.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-12 21:08:23.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-12 21:08:23.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-12 21:08:23.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
08-12 21:08:23.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(585) > "Noti Icon : 187 331 5 28 25"
08-12 21:08:23.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(585) > "Noti Icon : 191 359 5 28 25"
08-12 21:08:23.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 387 5 28 25"
08-12 21:08:23.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-12 21:08:23.316+0900 I/indicator(  517): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-12 21:08:23.316+0900 I/indicator(  517): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-12 21:08:23.316+0900 I/indicator(  517): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
08-12 21:08:23.316+0900 I/indicator(  517): indicator_box_util.c: _update_display(585) > "Noti Icon : 187 651 5 28 25"
08-12 21:08:23.316+0900 I/indicator(  517): indicator_box_util.c: _update_display(585) > "Noti Icon : 191 679 5 28 25"
08-12 21:08:23.316+0900 I/indicator(  517): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 707 5 28 25"
08-12 21:08:23.426+0900 I/record  ( 9285): [C3] [도] [130.80 Hz]
08-12 21:08:23.606+0900 I/record  ( 9285): [C3] [도] [130.80 Hz]
08-12 21:08:23.786+0900 I/record  ( 9285): [C3] [도] [130.80 Hz]
08-12 21:08:23.996+0900 I/record  ( 9285): [C3] [도] [130.80 Hz]
08-12 21:08:24.146+0900 I/record  ( 9285): [C3] [도] [130.80 Hz]
08-12 21:08:24.356+0900 I/record  ( 9285): [C3] [도] [130.80 Hz]
08-12 21:08:24.556+0900 I/record  ( 9285): [C3] [도] [130.80 Hz]
08-12 21:08:24.556+0900 F/record  ( 9285): pass! [C3] [도]
08-12 21:08:24.556+0900 F/record  ( 9285): <font_size=53><color=#000000>레 (D3)</color></font_size>
08-12 21:08:24.556+0900 F/record  ( 9285): <font_size=53><color=#000000>레 (D3)</color></font_size>
08-12 21:08:24.716+0900 I/record  ( 9285): [C3] [도] [130.80 Hz]
08-12 21:08:24.916+0900 I/record  ( 9285): [C3] [도] [130.80 Hz]
08-12 21:08:25.076+0900 I/record  ( 9285): [C#3] [도#] [138.60 Hz]
08-12 21:08:25.276+0900 I/record  ( 9285): [D3] [레 ] [146.80 Hz]
08-12 21:08:25.476+0900 I/record  ( 9285): [C#3] [도#] [138.60 Hz]
08-12 21:08:25.636+0900 I/record  ( 9285): [D3] [레 ] [146.80 Hz]
08-12 21:08:25.836+0900 I/record  ( 9285): [D3] [레 ] [146.80 Hz]
08-12 21:08:26.006+0900 I/record  ( 9285): [D3] [레 ] [146.80 Hz]
08-12 21:08:26.206+0900 I/record  ( 9285): [D3] [레 ] [146.80 Hz]
08-12 21:08:26.406+0900 I/record  ( 9285): [D3] [레 ] [146.80 Hz]
08-12 21:08:26.566+0900 I/record  ( 9285): [D3] [레 ] [146.80 Hz]
08-12 21:08:26.746+0900 I/record  ( 9285): [D3] [레 ] [146.80 Hz]
08-12 21:08:26.746+0900 F/record  ( 9285): pass! [D3] [레 ]
08-12 21:08:26.746+0900 F/record  ( 9285): <font_size=53><color=#000000>미(E3)</color></font_size>
08-12 21:08:26.746+0900 F/record  ( 9285): <font_size=53><color=#000000>미(E3)</color></font_size>
08-12 21:08:26.956+0900 I/record  ( 9285): [D3] [레 ] [146.80 Hz]
08-12 21:08:27.156+0900 I/record  ( 9285): [D3] [레 ] [146.80 Hz]
08-12 21:08:27.236+0900 I/record  ( 9285): [A0] [라] [27.50 Hz]
08-12 21:08:27.296+0900 I/Tizen::Net::Wifi(  950): (1072) > _WifiService is not registered.
08-12 21:08:27.296+0900 I/indicator(  517): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-12 21:08:27.296+0900 I/indicator(  517): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-12 21:08:27.296+0900 I/indicator(  517): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-12 21:08:27.296+0900 I/indicator(  517): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
08-12 21:08:27.296+0900 I/indicator(  517): indicator_box_util.c: _update_display(585) > "Noti Icon : 187 331 5 28 25"
08-12 21:08:27.296+0900 I/indicator(  517): indicator_box_util.c: _update_display(585) > "Noti Icon : 191 359 5 28 25"
08-12 21:08:27.296+0900 I/indicator(  517): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 387 5 28 25"
08-12 21:08:27.296+0900 I/indicator(  517): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-12 21:08:27.296+0900 I/indicator(  517): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-12 21:08:27.296+0900 I/indicator(  517): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-12 21:08:27.296+0900 I/indicator(  517): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
08-12 21:08:27.296+0900 I/indicator(  517): indicator_box_util.c: _update_display(585) > "Noti Icon : 187 651 5 28 25"
08-12 21:08:27.296+0900 I/indicator(  517): indicator_box_util.c: _update_display(585) > "Noti Icon : 191 679 5 28 25"
08-12 21:08:27.296+0900 I/indicator(  517): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 707 5 28 25"
08-12 21:08:27.436+0900 I/record  ( 9285): [A0] [라] [27.50 Hz]
08-12 21:08:27.626+0900 I/record  ( 9285): [A0] [라] [27.50 Hz]
08-12 21:08:27.796+0900 I/record  ( 9285): [A0] [라] [27.50 Hz]
08-12 21:08:27.996+0900 I/record  ( 9285): [A0] [라] [27.50 Hz]
08-12 21:08:28.176+0900 I/record  ( 9285): [A0] [라] [27.50 Hz]
08-12 21:08:28.336+0900 I/record  ( 9285): [A0] [라] [27.50 Hz]
08-12 21:08:28.536+0900 I/record  ( 9285): [A0] [라] [27.50 Hz]
08-12 21:08:28.736+0900 I/record  ( 9285): [A0] [라] [27.50 Hz]
08-12 21:08:28.976+0900 I/record  ( 9285): [D#3] [레#] [155.60 Hz]
08-12 21:08:29.176+0900 I/record  ( 9285): [D#3] [레#] [155.60 Hz]
08-12 21:08:29.406+0900 I/record  ( 9285): [D#3] [레#] [155.60 Hz]
08-12 21:08:29.546+0900 I/record  ( 9285): [D#3] [레#] [155.60 Hz]
08-12 21:08:29.746+0900 I/record  ( 9285): [E3] [미] [164.80 Hz]
08-12 21:08:29.906+0900 I/record  ( 9285): [E3] [미] [164.80 Hz]
08-12 21:08:30.106+0900 I/record  ( 9285): [E3] [미] [164.80 Hz]
08-12 21:08:30.316+0900 I/record  ( 9285): [E3] [미] [164.80 Hz]
08-12 21:08:30.466+0900 I/record  ( 9285): [E3] [미] [164.80 Hz]
08-12 21:08:30.676+0900 I/record  ( 9285): [E3] [미] [164.80 Hz]
08-12 21:08:30.876+0900 I/record  ( 9285): [E3] [미] [164.80 Hz]
08-12 21:08:30.876+0900 F/record  ( 9285): pass! [E3] [미]
08-12 21:08:30.876+0900 F/record  ( 9285): <font_size=53><color=#000000>파(F3)</color></font_size>
08-12 21:08:31.036+0900 I/record  ( 9285): [E3] [미] [164.80 Hz]
08-12 21:08:31.216+0900 I/record  ( 9285): [E3] [미] [164.80 Hz]
08-12 21:08:31.436+0900 I/record  ( 9285): [F3] [파] [174.60 Hz]
08-12 21:08:31.616+0900 I/record  ( 9285): [F3] [파] [174.60 Hz]
08-12 21:08:31.776+0900 I/record  ( 9285): [F3] [파] [174.60 Hz]
08-12 21:08:31.976+0900 I/record  ( 9285): [F3] [파] [174.60 Hz]
08-12 21:08:32.136+0900 I/record  ( 9285): [F3] [파] [174.60 Hz]
08-12 21:08:32.336+0900 I/record  ( 9285): [F3] [파] [174.60 Hz]
08-12 21:08:32.536+0900 I/record  ( 9285): [F3] [파] [174.60 Hz]
08-12 21:08:32.536+0900 F/record  ( 9285): pass! [F3] [파]
08-12 21:08:32.546+0900 F/record  ( 9285): <font_size=53><color=#000000>솔(G3)</color></font_size>
08-12 21:08:32.696+0900 I/record  ( 9285): [F3] [파] [174.60 Hz]
08-12 21:08:32.896+0900 I/record  ( 9285): [F3] [파] [174.60 Hz]
08-12 21:08:33.096+0900 I/record  ( 9285): [F#3] [파#] [185.00 Hz]
08-12 21:08:33.256+0900 I/record  ( 9285): [F#3] [파#] [185.00 Hz]
08-12 21:08:33.466+0900 I/record  ( 9285): [G3] [솔] [196.00 Hz]
08-12 21:08:33.616+0900 I/record  ( 9285): [F#3] [파#] [185.00 Hz]
08-12 21:08:33.826+0900 I/record  ( 9285): [G3] [솔] [196.00 Hz]
08-12 21:08:34.026+0900 I/record  ( 9285): [G3] [솔] [196.00 Hz]
08-12 21:08:34.216+0900 I/record  ( 9285): [G3] [솔] [196.00 Hz]
08-12 21:08:34.376+0900 I/record  ( 9285): [G3] [솔] [196.00 Hz]
08-12 21:08:34.576+0900 I/record  ( 9285): [G3] [솔] [196.00 Hz]
08-12 21:08:34.736+0900 I/record  ( 9285): [F#3] [파#] [185.00 Hz]
08-12 21:08:34.936+0900 I/record  ( 9285): [G3] [솔] [196.00 Hz]
08-12 21:08:35.136+0900 I/record  ( 9285): [F#3] [파#] [185.00 Hz]
08-12 21:08:35.296+0900 I/record  ( 9285): [F#3] [파#] [185.00 Hz]
08-12 21:08:35.496+0900 I/record  ( 9285): [F#3] [파#] [185.00 Hz]
08-12 21:08:35.696+0900 I/record  ( 9285): [F#3] [파#] [185.00 Hz]
08-12 21:08:35.866+0900 I/record  ( 9285): [G3] [솔] [196.00 Hz]
08-12 21:08:36.066+0900 I/record  ( 9285): [F#3] [파#] [185.00 Hz]
08-12 21:08:36.226+0900 I/record  ( 9285): [F3] [파] [174.60 Hz]
08-12 21:08:36.426+0900 I/record  ( 9285): [F3] [파] [174.60 Hz]
08-12 21:08:36.626+0900 I/record  ( 9285): [F#3] [파#] [185.00 Hz]
08-12 21:08:36.786+0900 I/record  ( 9285): [F#3] [파#] [185.00 Hz]
08-12 21:08:36.986+0900 I/record  ( 9285): [F#3] [파#] [185.00 Hz]
08-12 21:08:37.176+0900 I/record  ( 9285): [F#3] [파#] [185.00 Hz]
08-12 21:08:37.336+0900 I/record  ( 9285): [F#3] [파#] [185.00 Hz]
08-12 21:08:37.536+0900 I/record  ( 9285): [F#3] [파#] [185.00 Hz]
08-12 21:08:37.736+0900 I/record  ( 9285): [G3] [솔] [196.00 Hz]
08-12 21:08:37.896+0900 I/record  ( 9285): [G3] [솔] [196.00 Hz]
08-12 21:08:38.096+0900 I/record  ( 9285): [G3] [솔] [196.00 Hz]
08-12 21:08:38.296+0900 I/record  ( 9285): [G3] [솔] [196.00 Hz]
08-12 21:08:38.456+0900 I/record  ( 9285): [G3] [솔] [196.00 Hz]
08-12 21:08:38.656+0900 I/record  ( 9285): [G3] [솔] [196.00 Hz]
08-12 21:08:38.856+0900 I/record  ( 9285): [G3] [솔] [196.00 Hz]
08-12 21:08:38.856+0900 F/record  ( 9285): pass! [G3] [솔]
08-12 21:08:38.856+0900 F/record  ( 9285): <font_size=53><color=#000000>솔(G3)</color></font_size>
08-12 21:08:38.856+0900 F/record  ( 9285): <font_size=53><color=#000000>솔(G3)</color></font_size>
08-12 21:08:38.906+0900 F/record  ( 9285): <font_size=50 ><color=#000000>클리어 시간 </br> 22 초</color></font_size>
08-12 21:08:39.006+0900 F/record  ( 9285): clear!
08-12 21:08:39.006+0900 E/record  ( 9285): pitch_detect_end
08-12 21:08:40.166+0900 I/CAPI_APPFW_APPLICATION( 9285): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:40.166+0900 I/CAPI_APPFW_APPLICATION(29276): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:40.166+0900 I/CAPI_APPFW_APPLICATION(28265): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:40.166+0900 I/CAPI_APPFW_APPLICATION(  698): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:40.166+0900 W/CAM_APP (28265): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-12 21:08:40.226+0900 I/CAPI_APPFW_APPLICATION( 9285): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:40.226+0900 I/CAPI_APPFW_APPLICATION(29276): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:40.226+0900 I/CAPI_APPFW_APPLICATION(28265): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:40.226+0900 W/CAM_APP (28265): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-12 21:08:40.236+0900 I/CAPI_APPFW_APPLICATION(  698): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:40.296+0900 I/Tizen::Net::Wifi(  950): (1072) > _WifiService is not registered.
08-12 21:08:40.296+0900 I/indicator(  517): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-12 21:08:40.296+0900 I/indicator(  517): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-12 21:08:40.296+0900 I/indicator(  517): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-12 21:08:40.296+0900 I/indicator(  517): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
08-12 21:08:40.296+0900 I/indicator(  517): indicator_box_util.c: _update_display(585) > "Noti Icon : 187 331 5 28 25"
08-12 21:08:40.296+0900 I/indicator(  517): indicator_box_util.c: _update_display(585) > "Noti Icon : 191 359 5 28 25"
08-12 21:08:40.296+0900 I/indicator(  517): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 387 5 28 25"
08-12 21:08:40.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-12 21:08:40.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-12 21:08:40.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-12 21:08:40.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
08-12 21:08:40.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(585) > "Noti Icon : 187 651 5 28 25"
08-12 21:08:40.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(585) > "Noti Icon : 191 679 5 28 25"
08-12 21:08:40.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 707 5 28 25"
08-12 21:08:42.306+0900 I/Tizen::Net::Wifi(  950): (1072) > _WifiService is not registered.
08-12 21:08:42.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-12 21:08:42.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-12 21:08:42.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-12 21:08:42.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
08-12 21:08:42.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(585) > "Noti Icon : 187 331 5 28 25"
08-12 21:08:42.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(585) > "Noti Icon : 191 359 5 28 25"
08-12 21:08:42.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 387 5 28 25"
08-12 21:08:42.316+0900 I/indicator(  517): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-12 21:08:42.316+0900 I/indicator(  517): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-12 21:08:42.316+0900 I/indicator(  517): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-12 21:08:42.316+0900 I/indicator(  517): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
08-12 21:08:42.316+0900 I/indicator(  517): indicator_box_util.c: _update_display(585) > "Noti Icon : 187 651 5 28 25"
08-12 21:08:42.316+0900 I/indicator(  517): indicator_box_util.c: _update_display(585) > "Noti Icon : 191 679 5 28 25"
08-12 21:08:42.316+0900 I/indicator(  517): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 707 5 28 25"
08-12 21:08:43.886+0900 I/CAPI_APPFW_APPLICATION( 9285): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:43.886+0900 I/CAPI_APPFW_APPLICATION(29276): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:43.886+0900 I/CAPI_APPFW_APPLICATION(28265): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:43.886+0900 I/CAPI_APPFW_APPLICATION(  698): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:43.886+0900 W/CAM_APP (28265): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-12 21:08:45.026+0900 I/CAPI_APPFW_APPLICATION( 9285): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:45.026+0900 I/CAPI_APPFW_APPLICATION(29276): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:45.026+0900 I/CAPI_APPFW_APPLICATION(28265): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:45.026+0900 I/CAPI_APPFW_APPLICATION(  698): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:45.036+0900 W/CAM_APP (28265): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-12 21:08:45.266+0900 I/CAPI_APPFW_APPLICATION( 9285): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:45.266+0900 I/CAPI_APPFW_APPLICATION(29276): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:45.266+0900 I/CAPI_APPFW_APPLICATION(28265): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:45.266+0900 I/CAPI_APPFW_APPLICATION(  698): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:45.276+0900 W/CAM_APP (28265): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-12 21:08:45.386+0900 I/CAPI_APPFW_APPLICATION( 9285): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:45.386+0900 I/CAPI_APPFW_APPLICATION(29276): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:45.386+0900 I/CAPI_APPFW_APPLICATION(28265): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:45.386+0900 I/CAPI_APPFW_APPLICATION(  698): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:45.386+0900 W/CAM_APP (28265): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-12 21:08:46.306+0900 I/Tizen::Net::Wifi(  950): (1072) > _WifiService is not registered.
08-12 21:08:46.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-12 21:08:46.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-12 21:08:46.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-12 21:08:46.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
08-12 21:08:46.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(585) > "Noti Icon : 187 331 5 28 25"
08-12 21:08:46.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(585) > "Noti Icon : 191 359 5 28 25"
08-12 21:08:46.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 387 5 28 25"
08-12 21:08:46.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-12 21:08:46.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-12 21:08:46.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-12 21:08:46.316+0900 I/indicator(  517): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
08-12 21:08:46.316+0900 I/indicator(  517): indicator_box_util.c: _update_display(585) > "Noti Icon : 187 651 5 28 25"
08-12 21:08:46.316+0900 I/indicator(  517): indicator_box_util.c: _update_display(585) > "Noti Icon : 191 679 5 28 25"
08-12 21:08:46.316+0900 I/indicator(  517): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 707 5 28 25"
08-12 21:08:48.306+0900 I/Tizen::Net::Wifi(  950): (1072) > _WifiService is not registered.
08-12 21:08:48.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-12 21:08:48.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-12 21:08:48.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-12 21:08:48.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
08-12 21:08:48.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(585) > "Noti Icon : 187 331 5 28 25"
08-12 21:08:48.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(585) > "Noti Icon : 191 359 5 28 25"
08-12 21:08:48.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 387 5 28 25"
08-12 21:08:48.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-12 21:08:48.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-12 21:08:48.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-12 21:08:48.316+0900 I/indicator(  517): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
08-12 21:08:48.316+0900 I/indicator(  517): indicator_box_util.c: _update_display(585) > "Noti Icon : 187 651 5 28 25"
08-12 21:08:48.316+0900 I/indicator(  517): indicator_box_util.c: _update_display(585) > "Noti Icon : 191 679 5 28 25"
08-12 21:08:48.316+0900 I/indicator(  517): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 707 5 28 25"
08-12 21:08:48.866+0900 I/CAPI_APPFW_APPLICATION( 9285): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:48.866+0900 I/CAPI_APPFW_APPLICATION(29276): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:48.866+0900 I/CAPI_APPFW_APPLICATION(28265): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:48.866+0900 I/CAPI_APPFW_APPLICATION(  698): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:48.866+0900 W/CAM_APP (28265): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-12 21:08:49.946+0900 I/CAPI_APPFW_APPLICATION( 9285): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:49.946+0900 I/CAPI_APPFW_APPLICATION(29276): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:49.946+0900 I/CAPI_APPFW_APPLICATION(28265): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:49.946+0900 I/CAPI_APPFW_APPLICATION(  698): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:49.946+0900 W/CAM_APP (28265): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-12 21:08:51.306+0900 I/Tizen::Net::Wifi(  950): (1072) > _WifiService is not registered.
08-12 21:08:51.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-12 21:08:51.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-12 21:08:51.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-12 21:08:51.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
08-12 21:08:51.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(585) > "Noti Icon : 187 331 5 28 25"
08-12 21:08:51.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(585) > "Noti Icon : 191 359 5 28 25"
08-12 21:08:51.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 387 5 28 25"
08-12 21:08:51.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-12 21:08:51.316+0900 I/indicator(  517): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-12 21:08:51.316+0900 I/indicator(  517): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-12 21:08:51.316+0900 I/indicator(  517): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
08-12 21:08:51.316+0900 I/indicator(  517): indicator_box_util.c: _update_display(585) > "Noti Icon : 187 651 5 28 25"
08-12 21:08:51.316+0900 I/indicator(  517): indicator_box_util.c: _update_display(585) > "Noti Icon : 191 679 5 28 25"
08-12 21:08:51.316+0900 I/indicator(  517): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 707 5 28 25"
08-12 21:08:51.746+0900 I/CAPI_APPFW_APPLICATION( 9285): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:51.746+0900 I/CAPI_APPFW_APPLICATION(29276): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:51.746+0900 I/CAPI_APPFW_APPLICATION(28265): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:51.746+0900 I/CAPI_APPFW_APPLICATION(  698): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:51.746+0900 W/CAM_APP (28265): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-12 21:08:53.306+0900 I/CAPI_APPFW_APPLICATION( 9285): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:53.306+0900 I/CAPI_APPFW_APPLICATION(29276): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:53.306+0900 I/CAPI_APPFW_APPLICATION(28265): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:53.306+0900 I/CAPI_APPFW_APPLICATION(  698): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-12 21:08:53.306+0900 W/CAM_APP (28265): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-12 21:08:54.306+0900 I/Tizen::Net::Wifi(  950): (1072) > _WifiService is not registered.
08-12 21:08:54.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-12 21:08:54.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-12 21:08:54.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-12 21:08:54.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
08-12 21:08:54.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(585) > "Noti Icon : 187 331 5 28 25"
08-12 21:08:54.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(585) > "Noti Icon : 191 359 5 28 25"
08-12 21:08:54.306+0900 I/indicator(  517): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 387 5 28 25"
08-12 21:08:54.316+0900 I/indicator(  517): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-12 21:08:54.316+0900 I/indicator(  517): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-12 21:08:54.316+0900 I/indicator(  517): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-12 21:08:54.316+0900 I/indicator(  517): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
08-12 21:08:54.316+0900 I/indicator(  517): indicator_box_util.c: _update_display(585) > "Noti Icon : 187 651 5 28 25"
08-12 21:08:54.316+0900 I/indicator(  517): indicator_box_util.c: _update_display(585) > "Noti Icon : 191 679 5 28 25"
08-12 21:08:54.316+0900 I/indicator(  517): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 707 5 28 25"
08-12 21:08:54.776+0900 F/record  ( 9285): Back button Callback
08-12 21:08:54.976+0900 E/asdf    ( 9285): escape
08-12 21:08:55.176+0900 W/AUL_AMD (  433): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
08-12 21:08:55.176+0900 W/AUL_AMD (  433): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
08-12 21:08:55.206+0900 I/AUL_PAD (  478): sigchild.h: __launchpad_sig_child(142) > dead_pid = 9285 pgid = 9285
08-12 21:08:55.206+0900 I/AUL_PAD (  478): sigchild.h: __sigchild_action(123) > dead_pid(9285)
08-12 21:08:55.206+0900 I/AUL_PAD (  478): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
08-12 21:08:55.206+0900 I/AUL_PAD (  478): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
08-12 21:08:55.216+0900 I/Tizen::System(  918): (246) > Terminated app [org.samteam.perfectsong]
08-12 21:08:55.216+0900 I/Tizen::Io(  918): (729) > Entry not found
08-12 21:08:55.226+0900 I/Tizen::App(  886): (243) > App[org.samteam.perfectsong] pid[9285] terminate event is forwarded
08-12 21:08:55.226+0900 I/Tizen::System(  886): (256) > osp.accessorymanager.service provider is found.
08-12 21:08:55.226+0900 I/Tizen::System(  886): (196) > Accessory Owner is removed [org.samteam.perfectsong, 9285, ]
08-12 21:08:55.226+0900 I/Tizen::System(  886): (256) > osp.system.service provider is found.
08-12 21:08:55.226+0900 I/Tizen::App(  886): (506) > TerminatedApp(org.samteam.perfectsong)
08-12 21:08:55.226+0900 I/Tizen::App(  886): (512) > Not registered pid(9285)
08-12 21:08:55.226+0900 I/Tizen::App(  886): (782) > Finished invoking application event listener for org.samteam.perfectsong, 9285.
08-12 21:08:55.226+0900 I/AUL_AMD (  433): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 9285
08-12 21:08:55.236+0900 W/PROCESSMGR(  406): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=591
08-12 21:08:55.236+0900 I/Tizen::System(  918): (157) > change brightness system value.
08-12 21:08:55.236+0900 I/Tizen::App(  918): (782) > Finished invoking application event listener for org.samteam.perfectsong, 9285.
08-12 21:08:55.256+0900 I/QUICKPANEL(  667): sound-profile.c: _view_update(106) > [_view_update : 106] sound : 0, vibration : 1
08-12 21:08:55.256+0900 I/QUICKPANEL(  667): quickpanel-ui.c: _ui_handler_input_region_set(172) > [_ui_handler_input_region_set : 172] win_input_0:0
08-12 21:08:55.256+0900 I/QUICKPANEL(  667): win_input_1:758
08-12 21:08:55.256+0900 I/QUICKPANEL(  667): win_input_2:480
08-12 21:08:55.256+0900 I/QUICKPANEL(  667): win_input_3:42
08-12 21:08:55.256+0900 I/QUICKPANEL(  667): 
08-12 21:08:55.266+0900 I/CAPI_APPFW_APPLICATION(  591): app_main.c: app_appcore_resume(223) > app_appcore_resume
08-12 21:08:55.266+0900 E/cluster-home(  591): homescreen-main.cpp: app_resume(422) >  app resume
08-12 21:08:55.306+0900 I/Tizen::System(  918): (259) > Active app [com.samsun], current [org.samtea] 
08-12 21:08:55.316+0900 I/Tizen::Io(  918): (729) > Entry not found
08-12 21:08:55.326+0900 I/Tizen::System(  918): (157) > change brightness system value.
08-12 21:08:55.396+0900 W/CRASH_MANAGER( 9476): worker.c: worker_job(1198) > 1109285706161143938133
