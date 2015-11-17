S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.0
Build-Number: Z130HDDU0BOB3
Build-Date: 2015.02.14 15:10:17

Crash Information
Process Name: paaaaaaaaa
PID: 31532
Date: 2015-08-13 17:58:26+0900
Executable File Path: /opt/usr/apps/org.samteam.perfectsong/bin/paaaaaaaaa
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 31532, uid 5000)

Register Information
r0   = 0xb34bb9b0, r1   = 0x00000000
r2   = 0xb34bb9b0, r3   = 0xbe9bf448
r4   = 0xb34bb9b0, r5   = 0xb73e45f8
r6   = 0xb73fb818, r7   = 0xbe9bf1a8
r8   = 0xb64ecaac, r9   = 0x00000000
r10  = 0xb34bed60, fp   = 0xb34bed44
ip   = 0xb4bceb44, sp   = 0xbe9bf188
lr   = 0xb4bc3d03, pc   = 0x00001c84
cpsr = 0x60000010

Memory Information
MemTotal:   730748 KB
MemFree:    206868 KB
Buffers:     38732 KB
Cached:     199656 KB
VmPeak:     132760 KB
VmSize:     132756 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       18064 KB
VmRSS:       18064 KB
VmData:      75216 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       26264 KB
VmPTE:          78 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 31532 TID = 31532
31532 31546 31547 31558 

Maps Information
af28d000 afa8c000 rwxp [stack:31558]
afe8e000 b068d000 rwxp [stack:31547]
b0a8f000 b128e000 rwxp [stack:31546]
b3f19000 b3f1a000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3f22000 b3f29000 r-xp /usr/lib/libfeedback.so.0.1.4
b3f3f000 b3f40000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
b3f48000 b3f4a000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
b3f52000 b3f53000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
b3f5b000 b3f72000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b40ce000 b40d2000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b40db000 b40e5000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b441f000 b44e9000 r-xp /usr/lib/libCOREGL.so.4.0
b44fa000 b44ff000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b4507000 b450c000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4515000 b4516000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b451f000 b4537000 r-xp /usr/lib/libpng12.so.0.50.0
b453f000 b4542000 r-xp /usr/lib/libEGL.so.1.4
b454a000 b4558000 r-xp /usr/lib/libGLESv2.so.2.0
b4561000 b4565000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b456e000 b4577000 r-xp /usr/lib/libmdm-common.so.1.0.45
b457f000 b45c7000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b45c8000 b45ce000 r-xp /usr/lib/libjson.so.0.1.0
b45d6000 b4637000 r-xp /usr/lib/libasound.so.2.0.0
b4641000 b4645000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
b464d000 b4650000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b4659000 b4661000 r-xp /usr/lib/libui-extension.so.0.1.0
b4662000 b4665000 r-xp /usr/lib/libnative-buffer.so.0.1.0
b466d000 b4670000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.22
b4678000 b472e000 r-xp /usr/lib/libcairo.so.2.11200.14
b4739000 b474b000 r-xp /usr/lib/libtts.so
b4753000 b4892000 r-xp /usr/lib/libicui18n.so.51.1
b48a2000 b48a8000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b48b1000 b48be000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
b48c7000 b48cf000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b48d7000 b48d9000 r-xp /usr/lib/libdri2.so.0.0.0
b48e1000 b48e8000 r-xp /usr/lib/libdrm.so.2.4.0
b48f1000 b4904000 r-xp /usr/lib/libmdm.so.1.0.88
b490c000 b4914000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b4923000 b4925000 r-xp /usr/lib/libiniparser.so.0
b492f000 b4945000 r-xp /usr/lib/lib_SamsungRec_TizenV04009.so
b4973000 b4976000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b497e000 b49b5000 r-xp /usr/lib/libpulse.so.0.16.2
b49be000 b49d4000 r-xp /usr/lib/libavsysaudio.so.0.0.1
b49dc000 b49e3000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b49eb000 b49f5000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
b4a01000 b4a06000 r-xp /usr/lib/libmmfsession.so.0.0.0
b4a0e000 b4a24000 r-xp /usr/lib/libefl-assist.so.0.1.0
b4a2c000 b4ac7000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
b4ad3000 b4ad6000 r-xp /usr/lib/libmm_ta.so.0.0.0
b4ade000 b4b2a000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b4b32000 b4b39000 r-xp /usr/lib/libtbm.so.1.0.0
b4b41000 b4b46000 r-xp /usr/lib/libcapi-media-tool.so.0.1.3
b4b4e000 b4b62000 r-xp /usr/lib/libmmfsound.so.0.1.0
b4b6b000 b4b72000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.4
b4b7b000 b4b93000 r-xp /usr/lib/libcapi-media-player.so.0.1.75
b4b9b000 b4ba1000 r-xp /usr/lib/libcapi-media-audio-io.so.0.2.31
b4bab000 b4bb5000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
b4bbe000 b4bc7000 r-xp /opt/usr/apps/org.samteam.perfectsong/bin/paaaaaaaaa
b4da4000 b4dae000 r-xp /lib/libnss_files-2.13.so
b4db7000 b4dc9000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b4dd1000 b4de7000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b4def000 b4ebd000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b4ed4000 b4ef8000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b4f01000 b4f07000 r-xp /usr/lib/libappsvc.so.0.1.0
b4f0f000 b4f1d000 r-xp /usr/lib/libail.so.0.1.0
b4f25000 b4f27000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.3
b4f30000 b4f35000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b4f3e000 b4f40000 r-xp /usr/lib/libefl-extension.so.0.1.0
b4f48000 b4f49000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b4f52000 b4f56000 r-xp /usr/lib/libogg.so.0.7.1
b4f5e000 b4f80000 r-xp /usr/lib/libvorbis.so.0.4.3
b4f88000 b506c000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b5080000 b50b1000 r-xp /usr/lib/libFLAC.so.8.2.0
b5a4b000 b5adf000 r-xp /usr/lib/libstdc++.so.6.0.16
b5af2000 b5af4000 r-xp /usr/lib/libXau.so.6.0.0
b5afc000 b5b06000 r-xp /usr/lib/libspdy.so.0.0.0
b5b0f000 b5b5b000 r-xp /usr/lib/libssl.so.1.0.0
b5b68000 b5b96000 r-xp /usr/lib/libidn.so.11.5.44
b5b9e000 b5ba8000 r-xp /usr/lib/libcares.so.2.1.0
b5bb0000 b5bd1000 r-xp /usr/lib/libexif.so.12.3.3
b5be4000 b5c29000 r-xp /usr/lib/libsndfile.so.1.0.25
b5c37000 b5c4d000 r-xp /lib/libexpat.so.1.5.2
b5c56000 b5d3b000 r-xp /usr/lib/libicuuc.so.51.1
b5d50000 b5d84000 r-xp /usr/lib/libicule.so.51.1
b5d8d000 b5da0000 r-xp /usr/lib/libxcb.so.1.1.0
b5da8000 b5de5000 r-xp /usr/lib/libcurl.so.4.3.0
b5dee000 b5df7000 r-xp /usr/lib/libethumb.so.1.7.99
b5e00000 b5e02000 r-xp /usr/lib/libctxdata.so.0.0.0
b5e0a000 b5e17000 r-xp /usr/lib/libremix.so.0.0.0
b5e1f000 b5e20000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5e28000 b5e3f000 r-xp /usr/lib/liblua-5.1.so
b5e48000 b5e4f000 r-xp /usr/lib/libembryo.so.1.7.99
b5e57000 b5e7a000 r-xp /usr/lib/libjpeg.so.8.0.2
b5e92000 b5ee8000 r-xp /usr/lib/libpixman-1.so.0.28.2
b5ef5000 b5f48000 r-xp /usr/lib/libfreetype.so.6.8.1
b5f53000 b5f7b000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5f7c000 b5fc2000 r-xp /usr/lib/libharfbuzz.so.0.907.0
b5fcb000 b5fde000 r-xp /usr/lib/libfribidi.so.0.3.1
b5fe6000 b5fe9000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b5ff1000 b5ff5000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b5ffd000 b6002000 r-xp /usr/lib/libecore_fb.so.1.7.99
b600b000 b6015000 r-xp /usr/lib/libXext.so.6.4.0
b601d000 b60fe000 r-xp /usr/lib/libX11.so.6.3.0
b6109000 b610c000 r-xp /usr/lib/libXtst.so.6.1.0
b6114000 b611a000 r-xp /usr/lib/libXrender.so.1.3.0
b6122000 b6127000 r-xp /usr/lib/libXrandr.so.2.2.0
b612f000 b6130000 r-xp /usr/lib/libXinerama.so.1.0.0
b6139000 b6141000 r-xp /usr/lib/libXi.so.6.1.0
b6142000 b6145000 r-xp /usr/lib/libXfixes.so.3.1.0
b614d000 b614f000 r-xp /usr/lib/libXgesture.so.7.0.0
b6157000 b6159000 r-xp /usr/lib/libXcomposite.so.1.0.0
b6161000 b6162000 r-xp /usr/lib/libXdamage.so.1.1.0
b616b000 b6171000 r-xp /usr/lib/libXcursor.so.1.0.2
b617a000 b6193000 r-xp /usr/lib/libecore_con.so.1.7.99
b619d000 b61a3000 r-xp /usr/lib/libecore_imf.so.1.7.99
b61ab000 b61b3000 r-xp /usr/lib/libethumb_client.so.1.7.99
b61bb000 b61c4000 r-xp /usr/lib/libedbus.so.1.7.99
b61cc000 b6229000 r-xp /usr/lib/libedje.so.1.7.99
b6232000 b6243000 r-xp /usr/lib/libecore_input.so.1.7.99
b624b000 b6250000 r-xp /usr/lib/libecore_file.so.1.7.99
b6258000 b6271000 r-xp /usr/lib/libeet.so.1.7.99
b6282000 b6286000 r-xp /usr/lib/libappcore-common.so.1.1
b628e000 b6355000 r-xp /usr/lib/libevas.so.1.7.99
b637a000 b639b000 r-xp /usr/lib/libecore_evas.so.1.7.99
b63a4000 b63d3000 r-xp /usr/lib/libecore_x.so.1.7.99
b63dd000 b6514000 r-xp /usr/lib/libelementary.so.1.7.99
b652a000 b652b000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b6533000 b6537000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.3
b6542000 b6545000 r-xp /lib/libgpg-error.so.0.5.0
b654d000 b65a5000 r-xp /usr/lib/libgcrypt.so.11.5.3
b65af000 b65db000 r-xp /usr/lib/libsystemd.so.0.0.1
b65e4000 b65e6000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b65ef000 b66ba000 r-xp /usr/lib/libxml2.so.2.7.8
b66c8000 b66d8000 r-xp /lib/libresolv-2.13.so
b66dc000 b66f2000 r-xp /lib/libz.so.1.2.5
b66fa000 b66fc000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b6704000 b6709000 r-xp /usr/lib/libffi.so.5.0.10
b6712000 b6713000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b671b000 b671e000 r-xp /lib/libattr.so.1.1.0
b6726000 b6729000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6731000 b6738000 r-xp /usr/lib/libvconf.so.0.2.45
b6741000 b68e8000 r-xp /usr/lib/libcrypto.so.1.0.0
b690a000 b6920000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6928000 b6991000 r-xp /lib/libm-2.13.so
b699a000 b69da000 r-xp /usr/lib/libeina.so.1.7.99
b69e3000 b6a17000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b6a20000 b6af4000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b6b00000 b6b05000 r-xp /usr/lib/libcapi-base-common.so.0.1.6
b6b0e000 b6b14000 r-xp /lib/librt-2.13.so
b6b1d000 b6b24000 r-xp /lib/libcrypt-2.13.so
b6b54000 b6b57000 r-xp /lib/libcap.so.2.21
b6b5f000 b6b61000 r-xp /usr/lib/libiri.so
b6b69000 b6b88000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6b90000 b6ba6000 r-xp /usr/lib/libecore.so.1.7.99
b6bbc000 b6bc1000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6bca000 b6be1000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6bea000 b6bf5000 r-xp /lib/libunwind.so.8.0.1
b6c22000 b6d3d000 r-xp /lib/libc-2.13.so
b6d4b000 b6d53000 r-xp /lib/libgcc_s-4.6.4.so.1
b6d5b000 b6d85000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6d8e000 b6d91000 r-xp /usr/lib/libbundle.so.0.1.22
b6d99000 b6d9b000 r-xp /lib/libdl-2.13.so
b6da4000 b6da7000 r-xp /usr/lib/libsmack.so.1.0.0
b6daf000 b6e7f000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6e80000 b6ee5000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6eef000 b6f01000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6f09000 b6f1d000 r-xp /lib/libpthread-2.13.so
b6f28000 b6f2a000 r-xp /usr/lib/libdlog.so.0.0.0
b6f32000 b6f3d000 r-xp /usr/lib/libaul.so.0.1.0
b6f4f000 b6f52000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f5c000 b6f60000 r-xp /usr/lib/libsys-assert.so
b6f69000 b6f86000 r-xp /lib/ld-2.13.so
b6f8f000 b6f94000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
b7283000 b72ad000 rw-p [heap]
b72ad000 b7563000 rw-p [heap]
be9ae000 be9cf000 rwxp [stack]
b72ad000 b7563000 rw-p [heap]
be9ae000 be9cf000 rwxp [stack]
End of Maps Information

Callstack Information (PID:31532)
Call Stack Count: 1
 0: (0x1c84) (null)
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
ator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 213 654 5 28 25"
08-13 17:57:48.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 682 5 28 25"
08-13 17:57:48.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 710 5 28 25"
08-13 17:57:48.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 738 5 28 25"
08-13 17:57:48.890+0900 I/record  (25942): [A#2] [라#] [116.50 Hz]
08-13 17:57:49.050+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:57:49.270+0900 I/record  (25942): [F#3] [파#] [185.00 Hz]
08-13 17:57:49.430+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:57:49.630+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:57:49.830+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:57:49.860+0900 I/Tizen::Net::Wifi(  970): (1072) > _WifiService is not registered.
08-13 17:57:49.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 17:57:49.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 17:57:49.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 17:57:49.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 306 5 28 25"
08-13 17:57:49.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 213 334 5 28 25"
08-13 17:57:49.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 362 5 28 25"
08-13 17:57:49.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 390 5 28 25"
08-13 17:57:49.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 418 5 28 25"
08-13 17:57:49.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 17:57:49.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 17:57:49.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 17:57:49.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 598 5 28 25"
08-13 17:57:49.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 626 5 28 25"
08-13 17:57:49.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 213 654 5 28 25"
08-13 17:57:49.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 682 5 28 25"
08-13 17:57:49.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 710 5 28 25"
08-13 17:57:49.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 738 5 28 25"
08-13 17:57:50.000+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:57:50.190+0900 I/record  (25942): [A#2] [라#] [116.50 Hz]
08-13 17:57:50.350+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:57:50.550+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:57:50.750+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:57:50.910+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:57:51.110+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:57:51.310+0900 I/record  (25942): [F#3] [파#] [185.00 Hz]
08-13 17:57:51.470+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:57:51.680+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:57:51.870+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:57:52.030+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:57:52.230+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:57:52.390+0900 I/record  (25942): [F#3] [파#] [185.00 Hz]
08-13 17:57:52.590+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:57:52.790+0900 I/record  (25942): [F2] [파] [87.30 Hz]
08-13 17:57:52.860+0900 I/Tizen::Net::Wifi(  970): (1072) > _WifiService is not registered.
08-13 17:57:52.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 17:57:52.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 17:57:52.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 17:57:52.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 306 5 28 25"
08-13 17:57:52.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 213 334 5 28 25"
08-13 17:57:52.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 362 5 28 25"
08-13 17:57:52.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 390 5 28 25"
08-13 17:57:52.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 418 5 28 25"
08-13 17:57:52.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 17:57:52.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 17:57:52.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 17:57:52.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 598 5 28 25"
08-13 17:57:52.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 626 5 28 25"
08-13 17:57:52.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 213 654 5 28 25"
08-13 17:57:52.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 682 5 28 25"
08-13 17:57:52.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 710 5 28 25"
08-13 17:57:52.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 738 5 28 25"
08-13 17:57:52.960+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:57:53.160+0900 I/record  (25942): [F3] [파] [174.60 Hz]
08-13 17:57:53.350+0900 I/record  (25942): [F3] [파] [174.60 Hz]
08-13 17:57:53.520+0900 I/record  (25942): [A#2] [라#] [116.50 Hz]
08-13 17:57:53.710+0900 I/record  (25942): [F3] [파] [174.60 Hz]
08-13 17:57:53.910+0900 I/record  (25942): [A#2] [라#] [116.50 Hz]
08-13 17:57:54.080+0900 I/record  (25942): [A#2] [라#] [116.50 Hz]
08-13 17:57:54.270+0900 I/record  (25942): [A#2] [라#] [116.50 Hz]
08-13 17:57:54.440+0900 I/record  (25942): [F5] [파] [698.50 Hz]
08-13 17:57:54.440+0900 I/CAPI_APPFW_APPLICATION( 1124): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 17:57:54.440+0900 I/CAPI_APPFW_APPLICATION(24095): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 17:57:54.440+0900 I/CAPI_APPFW_APPLICATION(  700): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 17:57:54.440+0900 W/CAM_APP ( 1124): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-13 17:57:54.450+0900 I/CAPI_APPFW_APPLICATION(25942): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 17:57:54.520+0900 I/CAPI_APPFW_APPLICATION( 1122): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 17:57:54.640+0900 I/record  (25942): [F#5] [파#] [740.00 Hz]
08-13 17:57:54.840+0900 I/record  (25942): [G#3] [솔#] [207.70 Hz]
08-13 17:57:55.000+0900 I/record  (25942): [C#2] [도#] [69.30 Hz]
08-13 17:57:55.190+0900 I/record  (25942): [G3] [솔] [196.00 Hz]
08-13 17:57:55.390+0900 I/record  (25942): [D4] [레] [293.70 Hz]
08-13 17:57:55.550+0900 I/record  (25942): [F3] [파] [174.60 Hz]
08-13 17:57:55.750+0900 I/record  (25942): [D#7] [레#] [2489.00 Hz]
08-13 17:57:55.950+0900 I/record  (25942): [D#7] [레#] [2489.00 Hz]
08-13 17:57:56.110+0900 I/record  (25942): [G7] [솔] [3136.00 Hz]
08-13 17:57:56.230+0900 I/record  (25942): [A0] [라] [27.50 Hz]
08-13 17:57:56.430+0900 I/record  (25942): [A0] [라] [27.50 Hz]
08-13 17:57:56.590+0900 I/record  (25942): [A0] [라] [27.50 Hz]
08-13 17:57:56.770+0900 I/record  (25942): [A0] [라] [27.50 Hz]
08-13 17:57:56.930+0900 I/CAPI_APPFW_APPLICATION( 1124): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 17:57:56.930+0900 I/CAPI_APPFW_APPLICATION(25942): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 17:57:56.930+0900 I/CAPI_APPFW_APPLICATION(24095): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 17:57:56.930+0900 I/CAPI_APPFW_APPLICATION(  700): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 17:57:56.940+0900 W/CAM_APP ( 1124): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-13 17:57:57.010+0900 I/CAPI_APPFW_APPLICATION( 1122): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 17:57:57.060+0900 I/record  (25942): [G#6] [솔#] [1661.20 Hz]
08-13 17:57:57.110+0900 I/CAPI_APPFW_APPLICATION( 1124): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 17:57:57.110+0900 I/CAPI_APPFW_APPLICATION(24095): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 17:57:57.110+0900 I/CAPI_APPFW_APPLICATION(  700): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 17:57:57.110+0900 W/CAM_APP ( 1124): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-13 17:57:57.120+0900 I/CAPI_APPFW_APPLICATION(25942): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 17:57:57.180+0900 I/record  (25942): [A0] [라] [27.50 Hz]
08-13 17:57:57.210+0900 I/CAPI_APPFW_APPLICATION( 1122): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 17:57:57.230+0900 I/CAPI_APPFW_APPLICATION( 1124): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 17:57:57.230+0900 I/CAPI_APPFW_APPLICATION(25942): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 17:57:57.230+0900 I/CAPI_APPFW_APPLICATION(24095): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 17:57:57.230+0900 I/CAPI_APPFW_APPLICATION(  700): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 17:57:57.230+0900 W/CAM_APP ( 1124): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-13 17:57:57.340+0900 I/record  (25942): [A0] [라] [27.50 Hz]
08-13 17:57:57.350+0900 I/CAPI_APPFW_APPLICATION( 1122): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 17:57:57.550+0900 I/record  (25942): [A0] [라] [27.50 Hz]
08-13 17:57:57.700+0900 I/record  (25942): [A0] [라] [27.50 Hz]
08-13 17:57:57.900+0900 I/record  (25942): [A0] [라] [27.50 Hz]
08-13 17:57:58.190+0900 I/record  (25942): [A4] [라] [440.00 Hz]
08-13 17:57:58.350+0900 I/record  (25942): [C3] [도] [130.80 Hz]
08-13 17:57:58.560+0900 I/record  (25942): [D#3] [레#] [155.60 Hz]
08-13 17:57:58.720+0900 I/record  (25942): [D#4] [레#] [311.10 Hz]
08-13 17:57:58.920+0900 I/record  (25942): [D#4] [레#] [311.10 Hz]
08-13 17:57:59.110+0900 I/record  (25942): [D4] [레] [293.70 Hz]
08-13 17:57:59.280+0900 I/record  (25942): [A2] [라] [110.00 Hz]
08-13 17:57:59.470+0900 I/record  (25942): [A2] [라] [110.00 Hz]
08-13 17:57:59.670+0900 I/record  (25942): [A3] [라] [220.00 Hz]
08-13 17:57:59.860+0900 I/record  (25942): [A#3] [라#] [233.10 Hz]
08-13 17:58:00.020+0900 I/record  (25942): [B3] [시] [246.90 Hz]
08-13 17:58:00.220+0900 I/record  (25942): [C4] [도] [261.60 Hz]
08-13 17:58:00.430+0900 I/record  (25942): [C#4] [도#] [277.20 Hz]
08-13 17:58:00.580+0900 I/record  (25942): [C#4] [도#] [277.20 Hz]
08-13 17:58:00.770+0900 I/record  (25942): [D4] [레] [293.70 Hz]
08-13 17:58:00.940+0900 I/record  (25942): [D#4] [레#] [311.10 Hz]
08-13 17:58:01.140+0900 I/record  (25942): [D4] [레] [293.70 Hz]
08-13 17:58:01.340+0900 I/record  (25942): [D#4] [레#] [311.10 Hz]
08-13 17:58:01.500+0900 I/record  (25942): [D#3] [레#] [155.60 Hz]
08-13 17:58:01.700+0900 I/record  (25942): [D#4] [레#] [311.10 Hz]
08-13 17:58:01.900+0900 I/record  (25942): [D#3] [레#] [155.60 Hz]
08-13 17:58:02.060+0900 I/record  (25942): [E4] [미] [329.60 Hz]
08-13 17:58:02.260+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:58:02.420+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:58:02.620+0900 I/record  (25942): [F4] [파] [349.20 Hz]
08-13 17:58:02.820+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:58:02.980+0900 I/record  (25942): [F3] [파] [174.60 Hz]
08-13 17:58:03.190+0900 I/record  (25942): [F3] [파] [174.60 Hz]
08-13 17:58:03.390+0900 I/record  (25942): [F#3] [파#] [185.00 Hz]
08-13 17:58:03.540+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:58:03.750+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:58:03.950+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:58:04.110+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:58:04.310+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:58:04.470+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:58:04.670+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:58:04.870+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:58:05.030+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:58:05.230+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:58:05.430+0900 I/record  (25942): [B4] [시] [493.90 Hz]
08-13 17:58:05.590+0900 I/record  (25942): [A#7] [라#] [3729.30 Hz]
08-13 17:58:05.780+0900 I/record  (25942): [A#2] [라#] [116.50 Hz]
08-13 17:58:05.900+0900 I/record  (25942): [A0] [라] [27.50 Hz]
08-13 17:58:06.140+0900 I/record  (25942): [A#2] [라#] [116.50 Hz]
08-13 17:58:06.340+0900 I/record  (25942): [C3] [도] [130.80 Hz]
08-13 17:58:06.540+0900 I/record  (25942): [C#7] [도#] [2217.50 Hz]
08-13 17:58:06.620+0900 I/record  (25942): [A0] [라] [27.50 Hz]
08-13 17:58:06.900+0900 I/record  (25942): [G3] [솔] [196.00 Hz]
08-13 17:58:07.100+0900 I/record  (25942): [F#3] [파#] [185.00 Hz]
08-13 17:58:07.260+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:58:07.460+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:58:07.630+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:58:07.830+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:58:08.030+0900 I/record  (25942): [F#3] [파#] [185.00 Hz]
08-13 17:58:08.190+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:58:08.390+0900 I/record  (25942): [F#3] [파#] [185.00 Hz]
08-13 17:58:08.550+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:58:08.740+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:58:08.940+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:58:09.140+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:58:09.310+0900 I/record  (25942): [F#3] [파#] [185.00 Hz]
08-13 17:58:09.510+0900 I/record  (25942): [F3] [파] [174.60 Hz]
08-13 17:58:09.670+0900 I/record  (25942): [F#3] [파#] [185.00 Hz]
08-13 17:58:09.880+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:58:10.070+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:58:10.230+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:58:10.430+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:58:10.600+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:58:10.790+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:58:11.010+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:58:11.160+0900 I/record  (25942): [F#3] [파#] [185.00 Hz]
08-13 17:58:11.360+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:58:11.560+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:58:11.740+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:58:11.900+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:58:12.100+0900 I/record  (25942): [F#3] [파#] [185.00 Hz]
08-13 17:58:12.300+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:58:12.460+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:58:12.660+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:58:12.860+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:58:13.020+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:58:13.200+0900 I/record  (25942): [F#3] [파#] [185.00 Hz]
08-13 17:58:13.400+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:58:13.600+0900 I/record  (25942): [F#4] [파#] [370.00 Hz]
08-13 17:58:13.760+0900 I/record  (25942): [D#4] [레#] [311.10 Hz]
08-13 17:58:13.960+0900 I/record  (25942): [G#3] [솔#] [207.70 Hz]
08-13 17:58:14.050+0900 I/CAPI_APPFW_APPLICATION(25942): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 17:58:14.050+0900 I/CAPI_APPFW_APPLICATION(24095): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 17:58:14.050+0900 I/CAPI_APPFW_APPLICATION( 1124): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 17:58:14.050+0900 I/CAPI_APPFW_APPLICATION(  700): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 17:58:14.050+0900 W/CAM_APP ( 1124): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-13 17:58:14.120+0900 I/CAPI_APPFW_APPLICATION( 1122): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 17:58:14.160+0900 I/record  (25942): [A#6] [라#] [1864.70 Hz]
08-13 17:58:14.330+0900 I/record  (25942): [A#6] [라#] [1864.70 Hz]
08-13 17:58:14.530+0900 I/record  (25942): [E6] [미] [1318.50 Hz]
08-13 17:58:14.690+0900 I/record  (25942): [G#6] [솔#] [1661.20 Hz]
08-13 17:58:14.890+0900 I/record  (25942): [C#3] [도#] [138.60 Hz]
08-13 17:58:15.090+0900 I/record  (25942): [D#3] [레#] [155.60 Hz]
08-13 17:58:15.250+0900 I/record  (25942): [A0] [라] [27.50 Hz]
08-13 17:58:15.370+0900 I/record  (25942): [A0] [라] [27.50 Hz]
08-13 17:58:15.620+0900 I/CAPI_APPFW_APPLICATION( 1124): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 17:58:15.620+0900 I/CAPI_APPFW_APPLICATION(25942): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 17:58:15.620+0900 I/CAPI_APPFW_APPLICATION(24095): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 17:58:15.620+0900 I/CAPI_APPFW_APPLICATION(  700): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 17:58:15.620+0900 W/CAM_APP ( 1124): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-13 17:58:15.670+0900 I/record  (25942): [F#6] [파#] [1480.00 Hz]
08-13 17:58:15.680+0900 I/CAPI_APPFW_APPLICATION( 1124): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 17:58:15.680+0900 I/CAPI_APPFW_APPLICATION(24095): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 17:58:15.680+0900 I/CAPI_APPFW_APPLICATION(  700): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 17:58:15.680+0900 W/CAM_APP ( 1124): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-13 17:58:15.690+0900 I/CAPI_APPFW_APPLICATION( 1122): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 17:58:15.690+0900 I/CAPI_APPFW_APPLICATION(25942): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 17:58:15.820+0900 I/record  (25942): [A#3] [라#] [233.10 Hz]
08-13 17:58:15.820+0900 I/CAPI_APPFW_APPLICATION( 1122): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 17:58:16.020+0900 I/record  (25942): [G#3] [솔#] [207.70 Hz]
08-13 17:58:16.180+0900 I/record  (25942): [D#7] [레#] [2489.00 Hz]
08-13 17:58:16.370+0900 I/record  (25942): [F#5] [파#] [740.00 Hz]
08-13 17:58:16.570+0900 I/record  (25942): [E5] [미] [659.30 Hz]
08-13 17:58:16.770+0900 I/record  (25942): [E5] [미] [659.30 Hz]
08-13 17:58:16.950+0900 I/record  (25942): [A2] [라] [110.00 Hz]
08-13 17:58:17.120+0900 I/record  (25942): [G#2] [솔#] [103.80 Hz]
08-13 17:58:17.240+0900 I/record  (25942): [A0] [라] [27.50 Hz]
08-13 17:58:17.480+0900 I/record  (25942): [C5] [도] [523.30 Hz]
08-13 17:58:17.600+0900 I/record  (25942): [A0] [라] [27.50 Hz]
08-13 17:58:17.870+0900 I/record  (25942): [G#2] [솔#] [103.80 Hz]
08-13 17:58:17.950+0900 I/record  (25942): [A0] [라] [27.50 Hz]
08-13 17:58:18.230+0900 I/record  (25942): [C4] [도] [261.60 Hz]
08-13 17:58:18.430+0900 I/record  (25942): [A2] [라] [110.00 Hz]
08-13 17:58:18.510+0900 I/record  (25942): [A0] [라] [27.50 Hz]
08-13 17:58:18.800+0900 I/record  (25942): [G7] [솔] [3136.00 Hz]
08-13 17:58:19.000+0900 I/record  (25942): [C#6] [도#] [1108.70 Hz]
08-13 17:58:19.180+0900 I/record  (25942): [A5] [라] [880.00 Hz]
08-13 17:58:19.280+0900 I/CAPI_APPFW_APPLICATION( 1124): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 17:58:19.280+0900 I/CAPI_APPFW_APPLICATION(25942): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 17:58:19.280+0900 I/CAPI_APPFW_APPLICATION(24095): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 17:58:19.280+0900 I/CAPI_APPFW_APPLICATION(  700): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 17:58:19.280+0900 W/CAM_APP ( 1124): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-13 17:58:19.350+0900 I/CAPI_APPFW_APPLICATION( 1122): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 17:58:19.360+0900 I/record  (25942): [B2] [시] [123.50 Hz]
08-13 17:58:19.440+0900 I/record  (25942): [A0] [라] [27.50 Hz]
08-13 17:58:19.640+0900 I/record  (25942): [A0] [라] [27.50 Hz]
08-13 17:58:19.840+0900 I/record  (25942): [A0] [라] [27.50 Hz]
08-13 17:58:19.850+0900 I/Tizen::Net::Wifi(  970): (1072) > _WifiService is not registered.
08-13 17:58:19.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 17:58:19.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 17:58:19.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 17:58:19.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 306 5 28 25"
08-13 17:58:19.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 213 334 5 28 25"
08-13 17:58:19.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 362 5 28 25"
08-13 17:58:19.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 390 5 28 25"
08-13 17:58:19.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 418 5 28 25"
08-13 17:58:19.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 17:58:19.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 17:58:19.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 17:58:19.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 598 5 28 25"
08-13 17:58:19.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 626 5 28 25"
08-13 17:58:19.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 213 654 5 28 25"
08-13 17:58:19.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 682 5 28 25"
08-13 17:58:19.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 710 5 28 25"
08-13 17:58:19.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 738 5 28 25"
08-13 17:58:20.020+0900 I/AUL_PAD (  492): sigchild.h: __launchpad_sig_child(142) > dead_pid = 25942 pgid = 25942
08-13 17:58:20.020+0900 I/AUL_PAD (  492): sigchild.h: __sigchild_action(123) > dead_pid(25942)
08-13 17:58:20.020+0900 I/AUL_PAD (  492): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
08-13 17:58:20.020+0900 I/AUL_PAD (  492): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
08-13 17:58:20.030+0900 W/AUL_AMD (  438): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
08-13 17:58:20.030+0900 W/AUL_AMD (  438): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
08-13 17:58:20.030+0900 I/Tizen::System(  940): (246) > Terminated app [org.samteam.perfectsong]
08-13 17:58:20.030+0900 I/Tizen::Io(  940): (729) > Entry not found
08-13 17:58:20.030+0900 I/Tizen::App(  902): (243) > App[org.samteam.perfectsong] pid[25942] terminate event is forwarded
08-13 17:58:20.030+0900 I/Tizen::System(  902): (256) > osp.accessorymanager.service provider is found.
08-13 17:58:20.030+0900 I/Tizen::System(  902): (196) > Accessory Owner is removed [org.samteam.perfectsong, 25942, ]
08-13 17:58:20.030+0900 I/Tizen::System(  902): (256) > osp.system.service provider is found.
08-13 17:58:20.030+0900 I/Tizen::App(  902): (506) > TerminatedApp(org.samteam.perfectsong)
08-13 17:58:20.030+0900 I/Tizen::App(  902): (512) > Not registered pid(25942)
08-13 17:58:20.030+0900 I/Tizen::App(  902): (782) > Finished invoking application event listener for org.samteam.perfectsong, 25942.
08-13 17:58:20.040+0900 I/AUL_AMD (  438): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 25942
08-13 17:58:20.050+0900 I/Tizen::System(  940): (157) > change brightness system value.
08-13 17:58:20.050+0900 I/Tizen::App(  940): (782) > Finished invoking application event listener for org.samteam.perfectsong, 25942.
08-13 17:58:20.090+0900 W/PROCESSMGR(  378): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=588
08-13 17:58:20.100+0900 I/QUICKPANEL(  666): sound-profile.c: _view_update(106) > [_view_update : 106] sound : 1, vibration : 0
08-13 17:58:20.120+0900 I/QUICKPANEL(  666): quickpanel-ui.c: _ui_handler_input_region_set(172) > [_ui_handler_input_region_set : 172] win_input_0:0
08-13 17:58:20.120+0900 I/QUICKPANEL(  666): win_input_1:758
08-13 17:58:20.120+0900 I/QUICKPANEL(  666): win_input_2:480
08-13 17:58:20.120+0900 I/QUICKPANEL(  666): win_input_3:42
08-13 17:58:20.120+0900 I/QUICKPANEL(  666): 
08-13 17:58:20.130+0900 I/CAPI_APPFW_APPLICATION(  588): app_main.c: app_appcore_resume(223) > app_appcore_resume
08-13 17:58:20.130+0900 E/cluster-home(  588): homescreen-main.cpp: app_resume(422) >  app resume
08-13 17:58:20.150+0900 E/weather-common(24095): weather-engine-db.c: dbf_weather_engine_db_get_city_index_of_location_id(2884) > [0;40;31m(NULL == loc_id) [return][0;m
08-13 17:58:20.160+0900 I/CAPI_NETWORK_CONNECTION(24095): connection.c: connection_create(363) > New handle created[0xb73c5140]
08-13 17:58:20.160+0900 I/CAPI_NETWORK_CONNECTION(24095): connection.c: connection_get_type(412) > Connected Network = 2
08-13 17:58:20.180+0900 I/Tizen::System(  940): (259) > Active app [com.samsun], current [org.samtea] 
08-13 17:58:20.180+0900 I/Tizen::Io(  940): (729) > Entry not found
08-13 17:58:20.180+0900 I/CAPI_NETWORK_CONNECTION(24095): connection.c: connection_destroy(379) > Destroy handle: 0xb73c5140
08-13 17:58:20.180+0900 E/weather-common(24095): weather-engine-db.c: dbf_weather_engine_db_get_is_mylocation(2860) > [0;40;31mFailed:: sqlite3_step failed, rc = 101[0;m
08-13 17:58:20.190+0900 E/weather-common(24095): weather-engine-db.c: dbf_weather_engine_db_get_network_error_flag(1774) > [0;40;31mFailed:: sqlite3_step failed, rc = 101[0;m
08-13 17:58:20.190+0900 I/Tizen::System(  940): (157) > change brightness system value.
08-13 17:58:20.420+0900 I/CAPI_APPFW_APPLICATION( 1124): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 17:58:20.420+0900 I/CAPI_APPFW_APPLICATION(  700): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 17:58:20.420+0900 W/CAM_APP ( 1124): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-13 17:58:20.420+0900 I/CAPI_APPFW_APPLICATION(24095): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 17:58:20.490+0900 I/CAPI_APPFW_APPLICATION( 1122): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 17:58:20.600+0900 I/CAPI_APPFW_APPLICATION( 1124): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 17:58:20.600+0900 I/CAPI_APPFW_APPLICATION(24095): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 17:58:20.600+0900 I/CAPI_APPFW_APPLICATION(  700): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 17:58:20.600+0900 W/CAM_APP ( 1124): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-13 17:58:20.690+0900 I/CAPI_APPFW_APPLICATION( 1122): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 17:58:20.720+0900 I/CAPI_APPFW_APPLICATION( 1124): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 17:58:20.720+0900 I/CAPI_APPFW_APPLICATION(24095): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 17:58:20.720+0900 I/CAPI_APPFW_APPLICATION(  700): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 17:58:20.720+0900 W/CAM_APP ( 1124): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-13 17:58:20.820+0900 I/CAPI_APPFW_APPLICATION( 1122): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 17:58:21.200+0900 W/STARTER (  525): hw_key.c: _key_press_cb(673) > [_key_press_cb:673] Home Key is pressed
08-13 17:58:21.200+0900 W/STARTER (  525): hw_key.c: _key_press_cb(691) > [_key_press_cb:691] homekey count : 1
08-13 17:58:21.590+0900 I/SYSPOPUP(  576): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
08-13 17:58:21.590+0900 I/SYSPOPUP(  576): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
08-13 17:58:21.590+0900 E/VOLUME  (  576): volume_x_event.c: volume_x_input_event_unregister(351) > [volume_x_input_event_unregister:351] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
08-13 17:58:21.590+0900 E/VOLUME  (  576): volume_control.c: volume_control_close(708) > [volume_control_close:708] Failed to unregister x input event handler
08-13 17:58:21.590+0900 E/VOLUME  (  576): volume_view.c: volume_view_setting_icon_callback_del(533) > [volume_view_setting_icon_callback_del:533] (!s_info.is_registered_callback) -> volume_view_setting_icon_callback_del() return
08-13 17:58:21.630+0900 W/AUL_AMD (  438): amd_request.c: __request_handler(601) > __request_handler: 0
08-13 17:58:21.640+0900 I/AUL     (  438): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/starter, ret : 0
08-13 17:58:21.640+0900 E/AUL_AMD (  438): amd_appinfo.c: appinfo_get_value(791) > appinfo get value: Invalid argument, 24
08-13 17:58:21.770+0900 E/RESOURCED(  766): proc-main.c: find_pid_info(96) > [find_pid_info,96] Please provide valid pointer.
08-13 17:58:21.790+0900 I/Tizen::App(  902): (499) > LaunchedApp(com.samsung.task-mgr)
08-13 17:58:21.800+0900 I/Tizen::App(  902): (733) > Finished invoking application event listener for com.samsung.task-mgr, 31469.
08-13 17:58:21.810+0900 I/Tizen::App(  940): (733) > Finished invoking application event listener for com.samsung.task-mgr, 31469.
08-13 17:58:21.840+0900 I/UXT     (31469): uxt_object_manager.cpp: on_initialized(287) > Initialized.
08-13 17:58:21.870+0900 E/RESOURCED(  766): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 448
08-13 17:58:21.940+0900 W/STARTER (  525): hw_key.c: _key_release_cb(503) > [_key_release_cb:503] Home Key is released
08-13 17:58:22.070+0900 I/SYSPOPUP(  576): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
08-13 17:58:22.070+0900 I/SYSPOPUP(  576): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
08-13 17:58:22.070+0900 E/VOLUME  (  576): volume_x_event.c: volume_x_input_event_unregister(351) > [volume_x_input_event_unregister:351] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
08-13 17:58:22.070+0900 E/VOLUME  (  576): volume_control.c: volume_control_close(708) > [volume_control_close:708] Failed to unregister x input event handler
08-13 17:58:22.080+0900 E/VOLUME  (  576): volume_view.c: volume_view_setting_icon_callback_del(533) > [volume_view_setting_icon_callback_del:533] (!s_info.is_registered_callback) -> volume_view_setting_icon_callback_del() return
08-13 17:58:22.130+0900 I/EFL-ASSIST(31469): efl_assist_theme.c: _theme_changeable_ui_data_set(222) > changeable state [1] is set to ecore_evas [b72f92b0]
08-13 17:58:22.150+0900 I/EFL-ASSIST(31469): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (b7427a90) from (/usr/share/themes/ChangeableColorTable2.xml) is created
08-13 17:58:22.160+0900 I/EFL-ASSIST(31469): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (b7427a90) is freed
08-13 17:58:22.270+0900 W/AUL_AMD (  438): amd_request.c: __request_handler(601) > __request_handler: 12
08-13 17:58:22.280+0900 E/RUA     (31469): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 14, ncols : 5
08-13 17:58:22.280+0900 E/TASK_MGR_LITE(31469): recent_apps.c: list_retrieve_item(350) > Fail to get ai table !!
08-13 17:58:22.280+0900 E/TASK_MGR_LITE(31469): recent_apps.c: list_retrieve_item(350) > Fail to get ai table !!
08-13 17:58:22.280+0900 E/TASK_MGR_LITE(31469): recent_apps.c: list_retrieve_item(350) > Fail to get ai table !!
08-13 17:58:22.280+0900 E/TASK_MGR_LITE(31469): recent_apps.c: list_retrieve_item(350) > Fail to get ai table !!
08-13 17:58:22.280+0900 E/TASK_MGR_LITE(31469): recent_apps.c: list_retrieve_item(350) > Fail to get ai table !!
08-13 17:58:22.280+0900 E/TASK_MGR_LITE(31469): recent_apps.c: list_retrieve_item(350) > Fail to get ai table !!
08-13 17:58:22.280+0900 E/TASK_MGR_LITE(31469): recent_apps.c: list_retrieve_item(350) > Fail to get ai table !!
08-13 17:58:22.280+0900 E/TASK_MGR_LITE(31469): recent_apps.c: list_retrieve_item(350) > Fail to get ai table !!
08-13 17:58:22.280+0900 E/TASK_MGR_LITE(31469): recent_apps.c: list_retrieve_item(350) > Fail to get ai table !!
08-13 17:58:22.280+0900 E/TASK_MGR_LITE(31469): recent_apps.c: list_retrieve_item(350) > Fail to get ai table !!
08-13 17:58:22.340+0900 W/AUL_AMD (  438): amd_request.c: __request_handler(601) > __request_handler: 12
08-13 17:58:22.340+0900 W/AUL_AMD (  438): amd_request.c: __request_handler(601) > __request_handler: 12
08-13 17:58:22.340+0900 W/AUL_AMD (  438): amd_request.c: __request_handler(601) > __request_handler: 12
08-13 17:58:22.360+0900 I/APP_CORE(31469): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
08-13 17:58:22.360+0900 I/APP_CORE(31469): appcore-efl.c: __do_app(511) > [APP 31469] Initial Launching, call the resume_cb
08-13 17:58:22.380+0900 W/PROCESSMGR(  378): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=31469
08-13 17:58:22.390+0900 W/APP_CORE(31469): appcore-efl.c: __show_cb(822) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3600008
08-13 17:58:22.390+0900 E/EFL     (31469): evas_main<31469> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
08-13 17:58:22.410+0900 I/Tizen::System(  940): (259) > Active app [com.samsun], current [com.samsun] 
08-13 17:58:22.410+0900 I/Tizen::System(  940): (273) > Current App[com.samsun] is already actived.
08-13 17:58:22.430+0900 E/EFL     (31469): evas_main<31469> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
08-13 17:58:22.480+0900 W/AUL_AMD (  438): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
08-13 17:58:22.480+0900 W/AUL_AMD (  438): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
08-13 17:58:22.530+0900 E/TASK_MGR_LITE(31469): genlist_item.c: del_cb(758) > Deleted
08-13 17:58:22.540+0900 E/TASK_MGR_LITE(31469): genlist_item.c: del_cb(758) > Deleted
08-13 17:58:22.540+0900 E/TASK_MGR_LITE(31469): genlist_item.c: del_cb(758) > Deleted
08-13 17:58:23.710+0900 E/TASK_MGR_LITE(31469): genlist_item.c: _icon_mouse_up(624) > Mouse up
08-13 17:58:23.720+0900 W/AUL_AMD (  438): amd_request.c: __request_handler(601) > __request_handler: 14
08-13 17:58:23.720+0900 W/AUL_AMD (  438): amd_request.c: __send_result_to_client(79) > __send_result_to_client, pid: -1
08-13 17:58:23.720+0900 W/AUL_AMD (  438): amd_request.c: __request_handler(601) > __request_handler: 0
08-13 17:58:23.850+0900 I/CAPI_APPFW_APPLICATION(31532): app_main.c: ui_app_main(699) > app_efl_main
08-13 17:58:23.880+0900 I/UXT     (31532): uxt_object_manager.cpp: on_initialized(287) > Initialized.
08-13 17:58:23.920+0900 I/CAPI_APPFW_APPLICATION(31532): app_main.c: _ui_app_appcore_create(560) > app_appcore_create
08-13 17:58:23.950+0900 E/RESOURCED(  766): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 443
08-13 17:58:23.960+0900 E/TASK_MGR_LITE(31469): genlist_item.c: del_cb(758) > Deleted
08-13 17:58:23.960+0900 E/TASK_MGR_LITE(31469): genlist_item.c: on_icon_clicked(530) > Running / Recent on_icon_clicked 0 -1
08-13 17:58:23.960+0900 W/AUL_AMD (  438): amd_request.c: __request_handler(601) > __request_handler: 22
08-13 17:58:23.960+0900 W/AUL_AMD (  438): amd_request.c: __request_handler(803) > app status : 5
08-13 17:58:23.960+0900 I/APP_CORE(31469): appcore-efl.c: __after_loop(1057) > Legacy lifecycle: 0
08-13 17:58:23.970+0900 I/APP_CORE(31469): appcore-efl.c: __after_loop(1059) > [APP 31469] PAUSE before termination
08-13 17:58:23.970+0900 E/TASK_MGR_LITE(31469): genlist_item.c: del_cb(758) > Deleted
08-13 17:58:23.970+0900 E/TASK_MGR_LITE(31469): genlist_item.c: del_cb(758) > Deleted
08-13 17:58:23.980+0900 I/Tizen::App(  940): (733) > Finished invoking application event listener for org.samteam.perfectsong, 31532.
08-13 17:58:23.990+0900 I/Tizen::App(  902): (499) > LaunchedApp(org.samteam.perfectsong)
08-13 17:58:23.990+0900 I/Tizen::App(  902): (733) > Finished invoking application event listener for org.samteam.perfectsong, 31532.
08-13 17:58:23.990+0900 E/APP_CORE(31469): appcore.c: appcore_flush_memory(631) > Appcore not initialized
08-13 17:58:24.000+0900 W/PROCESSMGR(  378): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=588
08-13 17:58:24.020+0900 I/MALI    (31469): egl_platform_x11.c: __egl_platform_terminate(306) > [EGL-X11] ################################################
08-13 17:58:24.020+0900 I/MALI    (31469): egl_platform_x11.c: __egl_platform_terminate(307) > [EGL-X11] PID=31469   close drm_fd=21 
08-13 17:58:24.020+0900 I/MALI    (31469): egl_platform_x11.c: __egl_platform_terminate(308) > [EGL-X11] ################################################
08-13 17:58:24.110+0900 I/Tizen::System(  940): (259) > Active app [com.samsun], current [com.samsun] 
08-13 17:58:24.110+0900 I/Tizen::System(  940): (273) > Current App[com.samsun] is already actived.
08-13 17:58:24.140+0900 I/UXT     (31469): uxt_object_manager.cpp: on_terminating(301) > Terminating.
08-13 17:58:24.270+0900 E/EFL     (31532): elementary<31532> elm_layout.c:833 _elm_layout_smart_content_set() could not swallow 0xb73e20d8 into part ''
08-13 17:58:24.290+0900 I/AUL_PAD (  492): sigchild.h: __launchpad_sig_child(142) > dead_pid = 31469 pgid = 31469
08-13 17:58:24.290+0900 I/AUL_PAD (  492): sigchild.h: __sigchild_action(123) > dead_pid(31469)
08-13 17:58:24.290+0900 I/AUL_PAD (  492): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
08-13 17:58:24.290+0900 I/AUL_PAD (  492): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
08-13 17:58:24.290+0900 I/Tizen::App(  902): (243) > App[com.samsung.task-mgr] pid[31469] terminate event is forwarded
08-13 17:58:24.290+0900 I/Tizen::System(  902): (256) > osp.accessorymanager.service provider is found.
08-13 17:58:24.290+0900 I/Tizen::System(  902): (196) > Accessory Owner is removed [com.samsung.task-mgr, 31469, ]
08-13 17:58:24.290+0900 I/Tizen::System(  902): (256) > osp.system.service provider is found.
08-13 17:58:24.290+0900 I/Tizen::App(  902): (506) > TerminatedApp(com.samsung.task-mgr)
08-13 17:58:24.290+0900 I/Tizen::App(  902): (512) > Not registered pid(31469)
08-13 17:58:24.290+0900 I/Tizen::App(  902): (782) > Finished invoking application event listener for com.samsung.task-mgr, 31469.
08-13 17:58:24.290+0900 I/Tizen::System(  940): (246) > Terminated app [com.samsung.task-mgr]
08-13 17:58:24.290+0900 I/Tizen::Io(  940): (729) > Entry not found
08-13 17:58:24.290+0900 I/AUL_AMD (  438): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 31469
08-13 17:58:24.300+0900 I/Tizen::System(  940): (157) > change brightness system value.
08-13 17:58:24.300+0900 I/Tizen::App(  940): (782) > Finished invoking application event listener for com.samsung.task-mgr, 31469.
08-13 17:58:24.350+0900 E/EFL     (31532): evas_main<31532> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
08-13 17:58:24.370+0900 E/EFL     (31532): evas_main<31532> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
08-13 17:58:24.580+0900 I/TIZEN_N_AUDIO_IO(31532): audio_io_private.c: audio_in_create_private(267) > mm_sound_pcm_capture_open_ex() success
08-13 17:58:24.580+0900 I/TIZEN_N_AUDIO_IO(31532): audio_io_private.c: audio_in_create_private(285) > mm_sound_pcm_set_message_callback() success
08-13 17:58:24.590+0900 I/TIZEN_N_AUDIO_IO(31532): audio_io.c: audio_in_prepare(88) > [audio_in_prepare] mm_sound_pcm_capture_start() success
08-13 17:58:24.590+0900 I/CAPI_APPFW_APPLICATION(31532): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
08-13 17:58:24.610+0900 I/APP_CORE(31532): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
08-13 17:58:24.610+0900 I/APP_CORE(31532): appcore-efl.c: __do_app(511) > [APP 31532] Initial Launching, call the resume_cb
08-13 17:58:24.610+0900 I/CAPI_APPFW_APPLICATION(31532): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
08-13 17:58:24.700+0900 W/PROCESSMGR(  378): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=31532
08-13 17:58:24.770+0900 I/QUICKPANEL(  666): sound-profile.c: _view_update(106) > [_view_update : 106] sound : 1, vibration : 0
08-13 17:58:24.790+0900 I/QUICKPANEL(  666): quickpanel-ui.c: _ui_handler_input_region_set(172) > [_ui_handler_input_region_set : 172] win_input_0:0
08-13 17:58:24.790+0900 I/QUICKPANEL(  666): win_input_1:0
08-13 17:58:24.790+0900 I/QUICKPANEL(  666): win_input_2:42
08-13 17:58:24.790+0900 I/QUICKPANEL(  666): win_input_3:800
08-13 17:58:24.790+0900 I/QUICKPANEL(  666): 
08-13 17:58:24.790+0900 I/Tizen::System(  940): (259) > Active app [org.samtea], current [com.samsun] 
08-13 17:58:24.800+0900 I/Tizen::Io(  940): (729) > Entry not found
08-13 17:58:24.810+0900 I/Tizen::System(  940): (157) > change brightness system value.
08-13 17:58:24.820+0900 W/APP_CORE(31532): appcore-efl.c: __show_cb(822) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5600002
08-13 17:58:24.840+0900 I/CAPI_APPFW_APPLICATION(  588): app_main.c: app_appcore_pause(202) > app_appcore_pause
08-13 17:58:24.840+0900 E/cluster-home(  588): homescreen-main.cpp: app_pause(355) >  app pause
08-13 17:58:25.120+0900 E/PKGMGR  (31560): pkgmgr-internal.c: _get_type_from_zip(634) > can not access to [org.samteam.perfectsong]
08-13 17:58:25.130+0900 E/PKGMGR_SERVER(31560): pkgmgr-server.c: __get_type_from_msg(283) > [0;31m[__get_type_from_msg(): 283](pkgtype == NULL) pkgtype is null for org.samteam.perfectsong 
08-13 17:58:25.130+0900 E/PKGMGR_SERVER(31560): [0;m
08-13 17:58:25.300+0900 I/Tizen::App(  902): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.samteam.perfectsong, key: start, val: update
08-13 17:58:25.300+0900 I/Tizen::App(  902): (1584) > Package = [org.samteam.perfectsong], Key = [start], Value = [update], install = [96]
08-13 17:58:25.310+0900 W/AUL_AMD (  438): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(580) > __amd_pkgmgrinfo_start_handler
08-13 17:58:25.310+0900 I/Tizen::App(  902): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.samteam.perfectsong, key: install_percent, val: 30
08-13 17:58:25.310+0900 I/Tizen::App(  902): (119) > InstallationInProgress [30]
08-13 17:58:25.310+0900 I/Tizen::App(  902): (1584) > Package = [org.samteam.perfectsong], Key = [install_percent], Value = [30], install = [1]
08-13 17:58:25.960+0900 W/AUL_AMD (  438): amd_status.c: __app_terminate_timer_cb(136) > send SIGKILL: No such process
08-13 17:58:26.550+0900 W/AUL_AMD (  438): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
08-13 17:58:26.550+0900 W/AUL_AMD (  438): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
08-13 17:58:26.550+0900 I/AUL_PAD (  492): sigchild.h: __launchpad_sig_child(142) > dead_pid = 31532 pgid = 31532
08-13 17:58:26.550+0900 I/AUL_PAD (  492): sigchild.h: __sigchild_action(123) > dead_pid(31532)
08-13 17:58:26.550+0900 I/AUL_PAD (  492): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
08-13 17:58:26.550+0900 I/AUL_PAD (  492): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
08-13 17:58:26.570+0900 W/PROCESSMGR(  378): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=588
08-13 17:58:26.570+0900 I/Tizen::System(  940): (246) > Terminated app [org.samteam.perfectsong]
08-13 17:58:26.570+0900 I/Tizen::Io(  940): (729) > Entry not found
08-13 17:58:26.570+0900 I/Tizen::App(  902): (243) > App[org.samteam.perfectsong] pid[31532] terminate event is forwarded
08-13 17:58:26.570+0900 I/Tizen::System(  902): (256) > osp.accessorymanager.service provider is found.
08-13 17:58:26.570+0900 I/Tizen::System(  902): (196) > Accessory Owner is removed [org.samteam.perfectsong, 31532, ]
08-13 17:58:26.570+0900 I/Tizen::System(  902): (256) > osp.system.service provider is found.
08-13 17:58:26.570+0900 I/Tizen::App(  902): (506) > TerminatedApp(org.samteam.perfectsong)
08-13 17:58:26.570+0900 I/Tizen::App(  902): (512) > Not registered pid(31532)
08-13 17:58:26.570+0900 I/Tizen::App(  902): (782) > Finished invoking application event listener for org.samteam.perfectsong, 31532.
08-13 17:58:26.580+0900 I/AUL_AMD (  438): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 31532
08-13 17:58:26.590+0900 I/QUICKPANEL(  666): sound-profile.c: _view_update(106) > [_view_update : 106] sound : 1, vibration : 0
08-13 17:58:26.600+0900 I/CAPI_APPFW_APPLICATION(  588): app_main.c: app_appcore_resume(223) > app_appcore_resume
08-13 17:58:26.600+0900 E/cluster-home(  588): homescreen-main.cpp: app_resume(422) >  app resume
08-13 17:58:26.600+0900 I/Tizen::System(  940): (157) > change brightness system value.
08-13 17:58:26.600+0900 I/Tizen::App(  940): (782) > Finished invoking application event listener for org.samteam.perfectsong, 31532.
08-13 17:58:26.620+0900 I/QUICKPANEL(  666): quickpanel-ui.c: _ui_handler_input_region_set(172) > [_ui_handler_input_region_set : 172] win_input_0:0
08-13 17:58:26.620+0900 I/QUICKPANEL(  666): win_input_1:758
08-13 17:58:26.620+0900 I/QUICKPANEL(  666): win_input_2:480
08-13 17:58:26.620+0900 I/QUICKPANEL(  666): win_input_3:42
08-13 17:58:26.620+0900 I/QUICKPANEL(  666): 
08-13 17:58:26.640+0900 I/Tizen::System(  940): (259) > Active app [com.samsun], current [org.samtea] 
08-13 17:58:26.640+0900 I/Tizen::Io(  940): (729) > Entry not found
08-13 17:58:26.680+0900 I/Tizen::System(  940): (157) > change brightness system value.
08-13 17:58:26.750+0900 W/CRASH_MANAGER(31568): worker.c: worker_job(1198) > 1131532706161143945630
