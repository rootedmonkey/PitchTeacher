S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.0
Build-Number: Z130HDDU0BOB3
Build-Date: 2015.02.14 15:10:17

Crash Information
Process Name: clock
PID: 20425
Date: 2015-09-11 17:22:57+0900
Executable File Path: /opt/usr/apps/org.samteam.perfectsong/bin/clock
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 20425, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000001
r2   = 0xa33e3f00, r3   = 0xa33e3f00
r4   = 0xbecde264, r5   = 0xb659f938
r6   = 0x0000025f, r7   = 0xbecddef4
r8   = 0xbecde2b8, r9   = 0x00000002
r10  = 0xb6c179dc, fp   = 0xb6c179dc
ip   = 0xb6f9ba58, sp   = 0xbecddee8
lr   = 0xb4bf23a7, pc   = 0xb4c2c628
cpsr = 0x20000030

Memory Information
MemTotal:   730748 KB
MemFree:    128280 KB
Buffers:     48092 KB
Cached:     240244 KB
VmPeak:     130700 KB
VmSize:     129488 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       17736 KB
VmRSS:       17736 KB
VmData:      74472 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       26352 KB
VmPTE:          80 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 20425 TID = 20425
20425 20433 20434 20436 

Maps Information
af3ff000 afbfe000 rwxp [stack:20436]
b0000000 b07ff000 rwxp [stack:20434]
b0c01000 b1400000 rwxp [stack:20433]
b3f5d000 b3f5e000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3f66000 b3f6d000 r-xp /usr/lib/libfeedback.so.0.1.4
b3f83000 b3f84000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
b3f8c000 b3f8e000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
b3f96000 b3f97000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
b3f9f000 b3fb6000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b4112000 b4116000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b411f000 b4129000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b4463000 b452d000 r-xp /usr/lib/libCOREGL.so.4.0
b453e000 b4543000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b454b000 b4550000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4559000 b455a000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4563000 b457b000 r-xp /usr/lib/libpng12.so.0.50.0
b4583000 b4586000 r-xp /usr/lib/libEGL.so.1.4
b458e000 b459c000 r-xp /usr/lib/libGLESv2.so.2.0
b45a5000 b45ae000 r-xp /usr/lib/libmdm-common.so.1.0.45
b45b6000 b45fe000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b45ff000 b4605000 r-xp /usr/lib/libjson.so.0.1.0
b460d000 b466e000 r-xp /usr/lib/libasound.so.2.0.0
b4678000 b467c000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
b4684000 b4687000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b4690000 b4698000 r-xp /usr/lib/libui-extension.so.0.1.0
b4699000 b469c000 r-xp /usr/lib/libnative-buffer.so.0.1.0
b46a4000 b46a7000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.22
b46af000 b4765000 r-xp /usr/lib/libcairo.so.2.11200.14
b4770000 b4782000 r-xp /usr/lib/libtts.so
b478a000 b48c9000 r-xp /usr/lib/libicui18n.so.51.1
b48d9000 b48df000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b48e8000 b48f5000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
b48fe000 b4906000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b490e000 b4910000 r-xp /usr/lib/libdri2.so.0.0.0
b4918000 b491f000 r-xp /usr/lib/libdrm.so.2.4.0
b4928000 b493b000 r-xp /usr/lib/libmdm.so.1.0.88
b4943000 b494b000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b495a000 b495c000 r-xp /usr/lib/libiniparser.so.0
b4966000 b497c000 r-xp /usr/lib/lib_SamsungRec_TizenV04009.so
b49aa000 b49ad000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b49b5000 b49ec000 r-xp /usr/lib/libpulse.so.0.16.2
b49f5000 b4a0b000 r-xp /usr/lib/libavsysaudio.so.0.0.1
b4a13000 b4a1a000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b4a22000 b4a2c000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
b4a38000 b4a3d000 r-xp /usr/lib/libmmfsession.so.0.0.0
b4a45000 b4a5b000 r-xp /usr/lib/libefl-assist.so.0.1.0
b4a63000 b4a67000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b4a70000 b4a80000 r-xp /usr/lib/libdeviced.so.0.1.0
b4a88000 b4b23000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
b4b2f000 b4b32000 r-xp /usr/lib/libmm_ta.so.0.0.0
b4b3a000 b4b86000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b4b8e000 b4b95000 r-xp /usr/lib/libtbm.so.1.0.0
b4b9d000 b4ba2000 r-xp /usr/lib/libcapi-media-tool.so.0.1.3
b4baa000 b4bbe000 r-xp /usr/lib/libmmfsound.so.0.1.0
b4bc7000 b4bce000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.4
b4bd7000 b4bdc000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
b4be4000 b4bfc000 r-xp /usr/lib/libcapi-media-player.so.0.1.75
b4c04000 b4c0a000 r-xp /usr/lib/libcapi-media-audio-io.so.0.2.31
b4c14000 b4c1e000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
b4c27000 b4c31000 r-xp /opt/usr/apps/org.samteam.perfectsong/bin/clock
b4e0e000 b4e18000 r-xp /lib/libnss_files-2.13.so
b4e21000 b4e33000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b4e3b000 b4e51000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b4e59000 b4f27000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b4f3e000 b4f62000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b4f6b000 b4f71000 r-xp /usr/lib/libappsvc.so.0.1.0
b4f79000 b4f87000 r-xp /usr/lib/libail.so.0.1.0
b4f8f000 b4f91000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.3
b4f9a000 b4f9f000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b4fa8000 b4faa000 r-xp /usr/lib/libefl-extension.so.0.1.0
b4fb2000 b4fb3000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b4fbc000 b4fc0000 r-xp /usr/lib/libogg.so.0.7.1
b4fc8000 b4fea000 r-xp /usr/lib/libvorbis.so.0.4.3
b4ff2000 b50d6000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b50ea000 b511b000 r-xp /usr/lib/libFLAC.so.8.2.0
b5ab5000 b5b49000 r-xp /usr/lib/libstdc++.so.6.0.16
b5b5c000 b5b5e000 r-xp /usr/lib/libXau.so.6.0.0
b5b66000 b5b70000 r-xp /usr/lib/libspdy.so.0.0.0
b5b79000 b5bc5000 r-xp /usr/lib/libssl.so.1.0.0
b5bd2000 b5c00000 r-xp /usr/lib/libidn.so.11.5.44
b5c08000 b5c12000 r-xp /usr/lib/libcares.so.2.1.0
b5c1a000 b5c3b000 r-xp /usr/lib/libexif.so.12.3.3
b5c4e000 b5c93000 r-xp /usr/lib/libsndfile.so.1.0.25
b5ca1000 b5cb7000 r-xp /lib/libexpat.so.1.5.2
b5cc0000 b5da5000 r-xp /usr/lib/libicuuc.so.51.1
b5dba000 b5dee000 r-xp /usr/lib/libicule.so.51.1
b5df7000 b5e0a000 r-xp /usr/lib/libxcb.so.1.1.0
b5e12000 b5e4f000 r-xp /usr/lib/libcurl.so.4.3.0
b5e58000 b5e61000 r-xp /usr/lib/libethumb.so.1.7.99
b5e6a000 b5e6c000 r-xp /usr/lib/libctxdata.so.0.0.0
b5e74000 b5e81000 r-xp /usr/lib/libremix.so.0.0.0
b5e89000 b5e8a000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5e92000 b5ea9000 r-xp /usr/lib/liblua-5.1.so
b5eb2000 b5eb9000 r-xp /usr/lib/libembryo.so.1.7.99
b5ec1000 b5ee4000 r-xp /usr/lib/libjpeg.so.8.0.2
b5efc000 b5f52000 r-xp /usr/lib/libpixman-1.so.0.28.2
b5f5f000 b5fb2000 r-xp /usr/lib/libfreetype.so.6.8.1
b5fbd000 b5fe5000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5fe6000 b602c000 r-xp /usr/lib/libharfbuzz.so.0.907.0
b6035000 b6048000 r-xp /usr/lib/libfribidi.so.0.3.1
b6050000 b6053000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b605b000 b605f000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b6067000 b606c000 r-xp /usr/lib/libecore_fb.so.1.7.99
b6075000 b607f000 r-xp /usr/lib/libXext.so.6.4.0
b6087000 b6168000 r-xp /usr/lib/libX11.so.6.3.0
b6173000 b6176000 r-xp /usr/lib/libXtst.so.6.1.0
b617e000 b6184000 r-xp /usr/lib/libXrender.so.1.3.0
b618c000 b6191000 r-xp /usr/lib/libXrandr.so.2.2.0
b6199000 b619a000 r-xp /usr/lib/libXinerama.so.1.0.0
b61a3000 b61ab000 r-xp /usr/lib/libXi.so.6.1.0
b61ac000 b61af000 r-xp /usr/lib/libXfixes.so.3.1.0
b61b7000 b61b9000 r-xp /usr/lib/libXgesture.so.7.0.0
b61c1000 b61c3000 r-xp /usr/lib/libXcomposite.so.1.0.0
b61cb000 b61cc000 r-xp /usr/lib/libXdamage.so.1.1.0
b61d5000 b61db000 r-xp /usr/lib/libXcursor.so.1.0.2
b61e4000 b61fd000 r-xp /usr/lib/libecore_con.so.1.7.99
b6207000 b620d000 r-xp /usr/lib/libecore_imf.so.1.7.99
b6215000 b621d000 r-xp /usr/lib/libethumb_client.so.1.7.99
b6225000 b622e000 r-xp /usr/lib/libedbus.so.1.7.99
b6236000 b6293000 r-xp /usr/lib/libedje.so.1.7.99
b629c000 b62ad000 r-xp /usr/lib/libecore_input.so.1.7.99
b62b5000 b62ba000 r-xp /usr/lib/libecore_file.so.1.7.99
b62c2000 b62db000 r-xp /usr/lib/libeet.so.1.7.99
b62ec000 b62f0000 r-xp /usr/lib/libappcore-common.so.1.1
b62f8000 b63bf000 r-xp /usr/lib/libevas.so.1.7.99
b63e4000 b6405000 r-xp /usr/lib/libecore_evas.so.1.7.99
b640e000 b643d000 r-xp /usr/lib/libecore_x.so.1.7.99
b6447000 b657e000 r-xp /usr/lib/libelementary.so.1.7.99
b6594000 b6595000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b659d000 b65a1000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.3
b65ac000 b65af000 r-xp /lib/libgpg-error.so.0.5.0
b65b7000 b660f000 r-xp /usr/lib/libgcrypt.so.11.5.3
b6619000 b6645000 r-xp /usr/lib/libsystemd.so.0.0.1
b664e000 b6650000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b6659000 b6724000 r-xp /usr/lib/libxml2.so.2.7.8
b6732000 b6742000 r-xp /lib/libresolv-2.13.so
b6746000 b675c000 r-xp /lib/libz.so.1.2.5
b6764000 b6766000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b676e000 b6773000 r-xp /usr/lib/libffi.so.5.0.10
b677c000 b677d000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b6785000 b6788000 r-xp /lib/libattr.so.1.1.0
b6790000 b6793000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b679b000 b67a2000 r-xp /usr/lib/libvconf.so.0.2.45
b67ab000 b6952000 r-xp /usr/lib/libcrypto.so.1.0.0
b6974000 b698a000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6992000 b69fb000 r-xp /lib/libm-2.13.so
b6a04000 b6a44000 r-xp /usr/lib/libeina.so.1.7.99
b6a4d000 b6a81000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b6a8a000 b6b5e000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b6b6a000 b6b6f000 r-xp /usr/lib/libcapi-base-common.so.0.1.6
b6b78000 b6b7e000 r-xp /lib/librt-2.13.so
b6b87000 b6b8e000 r-xp /lib/libcrypt-2.13.so
b6bbe000 b6bc1000 r-xp /lib/libcap.so.2.21
b6bc9000 b6bcb000 r-xp /usr/lib/libiri.so
b6bd3000 b6bf2000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6bfa000 b6c10000 r-xp /usr/lib/libecore.so.1.7.99
b6c26000 b6c2b000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c34000 b6c4b000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c54000 b6c5f000 r-xp /lib/libunwind.so.8.0.1
b6c8c000 b6da7000 r-xp /lib/libc-2.13.so
b6db5000 b6dbd000 r-xp /lib/libgcc_s-4.6.4.so.1
b6dc5000 b6def000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6df8000 b6dfb000 r-xp /usr/lib/libbundle.so.0.1.22
b6e03000 b6e05000 r-xp /lib/libdl-2.13.so
b6e0e000 b6e11000 r-xp /usr/lib/libsmack.so.1.0.0
b6e19000 b6ee9000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6eea000 b6f4f000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6f59000 b6f6b000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6f73000 b6f87000 r-xp /lib/libpthread-2.13.so
b6f92000 b6f94000 r-xp /usr/lib/libdlog.so.0.0.0
b6f9c000 b6fa7000 r-xp /usr/lib/libaul.so.0.1.0
b6fb9000 b6fbc000 r-xp /usr/lib/libappcore-efl.so.1.1
b6fc6000 b6fca000 r-xp /usr/lib/libsys-assert.so
b6fd3000 b6ff0000 r-xp /lib/ld-2.13.so
b6ff9000 b6ffe000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
b895b000 b8985000 rw-p [heap]
b8985000 b8c88000 rw-p [heap]
beccd000 becee000 rwxp [stack]
End of Maps Information

Callstack Information (PID:20425)
Call Stack Count: 1
 0: app_pause + 0x43 (0xb4c2c628) [/opt/usr/apps/org.samteam.perfectsong/bin/clock] + 0x5628
End of Call Stack

Package Information
Package Name: org.samteam.perfectsong
Package ID : org.samteam.perfectsong
Version: 1.0.0
Package Type: rpm
App Name: pitchTeacher
App ID: org.samteam.perfectsong
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
5+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 397 418 5 28 25"
09-11 17:22:04.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
09-11 17:22:04.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
09-11 17:22:04.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
09-11 17:22:04.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 348 626 5 28 25"
09-11 17:22:04.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 360 654 5 28 25"
09-11 17:22:04.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 381 682 5 28 25"
09-11 17:22:04.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 710 5 28 25"
09-11 17:22:04.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 397 738 5 28 25"
09-11 17:22:05.195+0900 I/Tizen::Net::Wifi( 1024): (1072) > _WifiService is not registered.
09-11 17:22:05.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
09-11 17:22:05.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
09-11 17:22:05.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
09-11 17:22:05.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 348 306 5 28 25"
09-11 17:22:05.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 360 334 5 28 25"
09-11 17:22:05.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 381 362 5 28 25"
09-11 17:22:05.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 390 5 28 25"
09-11 17:22:05.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 397 418 5 28 25"
09-11 17:22:05.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
09-11 17:22:05.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
09-11 17:22:05.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
09-11 17:22:05.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 348 626 5 28 25"
09-11 17:22:05.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 360 654 5 28 25"
09-11 17:22:05.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 381 682 5 28 25"
09-11 17:22:05.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 710 5 28 25"
09-11 17:22:05.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 397 738 5 28 25"
09-11 17:22:10.185+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
09-11 17:22:10.185+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
09-11 17:22:10.185+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
09-11 17:22:10.185+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 348 306 5 28 25"
09-11 17:22:10.185+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 360 334 5 28 25"
09-11 17:22:10.185+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 381 362 5 28 25"
09-11 17:22:10.185+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 390 5 28 25"
09-11 17:22:10.185+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 397 418 5 28 25"
09-11 17:22:10.185+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
09-11 17:22:10.185+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
09-11 17:22:10.185+0900 I/Tizen::Net::Wifi( 1024): (1072) > _WifiService is not registered.
09-11 17:22:10.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
09-11 17:22:10.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 348 626 5 28 25"
09-11 17:22:10.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 360 654 5 28 25"
09-11 17:22:10.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 381 682 5 28 25"
09-11 17:22:10.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 710 5 28 25"
09-11 17:22:10.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 397 738 5 28 25"
09-11 17:22:11.195+0900 I/Tizen::Net::Wifi( 1024): (1072) > _WifiService is not registered.
09-11 17:22:11.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
09-11 17:22:11.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
09-11 17:22:11.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
09-11 17:22:11.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 348 306 5 28 25"
09-11 17:22:11.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 360 334 5 28 25"
09-11 17:22:11.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 381 362 5 28 25"
09-11 17:22:11.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 390 5 28 25"
09-11 17:22:11.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 397 418 5 28 25"
09-11 17:22:11.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
09-11 17:22:11.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
09-11 17:22:11.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
09-11 17:22:11.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 348 626 5 28 25"
09-11 17:22:11.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 360 654 5 28 25"
09-11 17:22:11.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 381 682 5 28 25"
09-11 17:22:11.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 710 5 28 25"
09-11 17:22:11.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 397 738 5 28 25"
09-11 17:22:13.195+0900 I/Tizen::Net::Wifi( 1024): (1072) > _WifiService is not registered.
09-11 17:22:13.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
09-11 17:22:13.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
09-11 17:22:13.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
09-11 17:22:13.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 348 306 5 28 25"
09-11 17:22:13.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 360 334 5 28 25"
09-11 17:22:13.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 381 362 5 28 25"
09-11 17:22:13.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 390 5 28 25"
09-11 17:22:13.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 397 418 5 28 25"
09-11 17:22:13.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
09-11 17:22:13.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
09-11 17:22:13.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
09-11 17:22:13.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 348 626 5 28 25"
09-11 17:22:13.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 360 654 5 28 25"
09-11 17:22:13.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 381 682 5 28 25"
09-11 17:22:13.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 710 5 28 25"
09-11 17:22:13.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 397 738 5 28 25"
09-11 17:22:15.195+0900 I/Tizen::Net::Wifi( 1024): (1072) > _WifiService is not registered.
09-11 17:22:15.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
09-11 17:22:15.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
09-11 17:22:15.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
09-11 17:22:15.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 348 306 5 28 25"
09-11 17:22:15.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 360 334 5 28 25"
09-11 17:22:15.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 381 362 5 28 25"
09-11 17:22:15.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 390 5 28 25"
09-11 17:22:15.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 397 418 5 28 25"
09-11 17:22:15.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
09-11 17:22:15.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
09-11 17:22:15.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
09-11 17:22:15.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 348 626 5 28 25"
09-11 17:22:15.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 360 654 5 28 25"
09-11 17:22:15.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 381 682 5 28 25"
09-11 17:22:15.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 710 5 28 25"
09-11 17:22:15.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 397 738 5 28 25"
09-11 17:22:18.195+0900 I/Tizen::Net::Wifi( 1024): (1072) > _WifiService is not registered.
09-11 17:22:18.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
09-11 17:22:18.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
09-11 17:22:18.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
09-11 17:22:18.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 348 306 5 28 25"
09-11 17:22:18.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 360 334 5 28 25"
09-11 17:22:18.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 381 362 5 28 25"
09-11 17:22:18.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 390 5 28 25"
09-11 17:22:18.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 397 418 5 28 25"
09-11 17:22:18.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
09-11 17:22:18.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
09-11 17:22:18.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
09-11 17:22:18.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 348 626 5 28 25"
09-11 17:22:18.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 360 654 5 28 25"
09-11 17:22:18.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 381 682 5 28 25"
09-11 17:22:18.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 710 5 28 25"
09-11 17:22:18.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 397 738 5 28 25"
09-11 17:22:20.195+0900 I/Tizen::Net::Wifi( 1024): (1072) > _WifiService is not registered.
09-11 17:22:20.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
09-11 17:22:20.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
09-11 17:22:20.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
09-11 17:22:20.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 348 306 5 28 25"
09-11 17:22:20.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 360 334 5 28 25"
09-11 17:22:20.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 381 362 5 28 25"
09-11 17:22:20.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 390 5 28 25"
09-11 17:22:20.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 397 418 5 28 25"
09-11 17:22:20.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
09-11 17:22:20.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
09-11 17:22:20.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
09-11 17:22:20.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 348 626 5 28 25"
09-11 17:22:20.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 360 654 5 28 25"
09-11 17:22:20.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 381 682 5 28 25"
09-11 17:22:20.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 710 5 28 25"
09-11 17:22:20.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 397 738 5 28 25"
09-11 17:22:22.195+0900 I/Tizen::Net::Wifi( 1024): (1072) > _WifiService is not registered.
09-11 17:22:22.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
09-11 17:22:22.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
09-11 17:22:22.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
09-11 17:22:22.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 348 306 5 28 25"
09-11 17:22:22.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 360 334 5 28 25"
09-11 17:22:22.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 381 362 5 28 25"
09-11 17:22:22.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 390 5 28 25"
09-11 17:22:22.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 397 418 5 28 25"
09-11 17:22:22.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
09-11 17:22:22.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
09-11 17:22:22.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
09-11 17:22:22.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 348 626 5 28 25"
09-11 17:22:22.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 360 654 5 28 25"
09-11 17:22:22.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 381 682 5 28 25"
09-11 17:22:22.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 710 5 28 25"
09-11 17:22:22.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 397 738 5 28 25"
09-11 17:22:26.195+0900 I/Tizen::Net::Wifi( 1024): (1072) > _WifiService is not registered.
09-11 17:22:26.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
09-11 17:22:26.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
09-11 17:22:26.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
09-11 17:22:26.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 348 306 5 28 25"
09-11 17:22:26.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 360 334 5 28 25"
09-11 17:22:26.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 381 362 5 28 25"
09-11 17:22:26.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 390 5 28 25"
09-11 17:22:26.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 397 418 5 28 25"
09-11 17:22:26.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
09-11 17:22:26.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
09-11 17:22:26.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
09-11 17:22:26.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 348 626 5 28 25"
09-11 17:22:26.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 360 654 5 28 25"
09-11 17:22:26.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 381 682 5 28 25"
09-11 17:22:26.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 710 5 28 25"
09-11 17:22:26.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 397 738 5 28 25"
09-11 17:22:30.195+0900 I/Tizen::Net::Wifi( 1024): (1072) > _WifiService is not registered.
09-11 17:22:30.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
09-11 17:22:30.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
09-11 17:22:30.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
09-11 17:22:30.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 348 306 5 28 25"
09-11 17:22:30.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 360 334 5 28 25"
09-11 17:22:30.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 381 362 5 28 25"
09-11 17:22:30.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 390 5 28 25"
09-11 17:22:30.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 397 418 5 28 25"
09-11 17:22:30.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
09-11 17:22:30.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
09-11 17:22:30.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
09-11 17:22:30.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 348 626 5 28 25"
09-11 17:22:30.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 360 654 5 28 25"
09-11 17:22:30.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 381 682 5 28 25"
09-11 17:22:30.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 710 5 28 25"
09-11 17:22:30.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 397 738 5 28 25"
09-11 17:22:43.815+0900 I/AUL_PAD (  437): sigchild.h: __launchpad_sig_child(142) > dead_pid = 19774 pgid = 19774
09-11 17:22:43.815+0900 I/AUL_PAD (  437): sigchild.h: __sigchild_action(123) > dead_pid(19774)
09-11 17:22:43.815+0900 I/AUL_PAD (  437): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
09-11 17:22:43.815+0900 I/AUL_PAD (  437): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
09-11 17:22:43.815+0900 I/Tizen::System( 1005): (246) > Terminated app [org.samteam.perfectsong]
09-11 17:22:43.825+0900 I/Tizen::App(  992): (243) > App[org.samteam.perfectsong] pid[19774] terminate event is forwarded
09-11 17:22:43.825+0900 I/Tizen::System(  992): (256) > osp.accessorymanager.service provider is found.
09-11 17:22:43.825+0900 I/Tizen::System(  992): (196) > Accessory Owner is removed [org.samteam.perfectsong, 19774, ]
09-11 17:22:43.825+0900 I/Tizen::System(  992): (256) > osp.system.service provider is found.
09-11 17:22:43.825+0900 I/Tizen::App(  992): (506) > TerminatedApp(org.samteam.perfectsong)
09-11 17:22:43.825+0900 I/Tizen::App(  992): (512) > Not registered pid(19774)
09-11 17:22:43.825+0900 I/Tizen::App(  992): (782) > Finished invoking application event listener for org.samteam.perfectsong, 19774.
09-11 17:22:43.835+0900 I/AUL_AMD (  432): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 19774
09-11 17:22:43.835+0900 I/Tizen::Io( 1005): (729) > Entry not found
09-11 17:22:43.845+0900 W/AUL_AMD (  432): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
09-11 17:22:43.845+0900 W/AUL_AMD (  432): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
09-11 17:22:43.855+0900 I/Tizen::System( 1005): (157) > change brightness system value.
09-11 17:22:43.855+0900 I/Tizen::App( 1005): (782) > Finished invoking application event listener for org.samteam.perfectsong, 19774.
09-11 17:22:43.915+0900 W/PROCESSMGR(  376): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=634
09-11 17:22:43.935+0900 I/QUICKPANEL(  712): sound-profile.c: _view_update(106) > [_view_update : 106] sound : 1, vibration : 0
09-11 17:22:43.945+0900 I/QUICKPANEL(  712): quickpanel-ui.c: _ui_handler_input_region_set(172) > [_ui_handler_input_region_set : 172] win_input_0:0
09-11 17:22:43.945+0900 I/QUICKPANEL(  712): win_input_1:758
09-11 17:22:43.945+0900 I/QUICKPANEL(  712): win_input_2:480
09-11 17:22:43.945+0900 I/QUICKPANEL(  712): win_input_3:42
09-11 17:22:43.945+0900 I/QUICKPANEL(  712): 
09-11 17:22:43.945+0900 I/CAPI_APPFW_APPLICATION(  634): app_main.c: app_appcore_resume(223) > app_appcore_resume
09-11 17:22:43.945+0900 E/cluster-home(  634): homescreen-main.cpp: app_resume(422) >  app resume
09-11 17:22:43.965+0900 E/weather-common(17802): weather-engine-db.c: dbf_weather_engine_db_get_city_index_of_location_id(2884) > [0;40;31m(NULL == loc_id) [return][0;m
09-11 17:22:43.965+0900 I/CAPI_NETWORK_CONNECTION(17802): connection.c: connection_create(363) > New handle created[0xb8a77f28]
09-11 17:22:43.965+0900 I/CAPI_NETWORK_CONNECTION(17802): connection.c: connection_get_type(412) > Connected Network = 2
09-11 17:22:43.965+0900 I/CAPI_NETWORK_CONNECTION(17802): connection.c: connection_destroy(379) > Destroy handle: 0xb8a77f28
09-11 17:22:43.965+0900 E/weather-common(17802): weather-engine-db.c: dbf_weather_engine_db_get_is_mylocation(2860) > [0;40;31mFailed:: sqlite3_step failed, rc = 101[0;m
09-11 17:22:43.965+0900 E/weather-common(17802): weather-engine-db.c: dbf_weather_engine_db_get_network_error_flag(1774) > [0;40;31mFailed:: sqlite3_step failed, rc = 101[0;m
09-11 17:22:43.965+0900 I/Tizen::System( 1005): (259) > Active app [com.samsun], current [org.samtea] 
09-11 17:22:43.965+0900 I/Tizen::Io( 1005): (729) > Entry not found
09-11 17:22:43.995+0900 I/Tizen::System( 1005): (157) > change brightness system value.
09-11 17:22:44.825+0900 W/CAM_APP (10809): cam_app.c: __cam_app_display_state_changed_cb(7902) > [33mapp state is PRELAUNCH. ignore this[0m
09-11 17:22:46.305+0900 I/MALI    (  634): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xb8aad528] swap changed from async to sync
09-11 17:22:47.145+0900 E/PKGMGR  (20345): pkgmgr-internal.c: _get_type_from_zip(634) > can not access to [org.samteam.perfectsong]
09-11 17:22:47.145+0900 E/PKGMGR_SERVER(20345): pkgmgr-server.c: __get_type_from_msg(283) > [0;31m[__get_type_from_msg(): 283](pkgtype == NULL) pkgtype is null for org.samteam.perfectsong 
09-11 17:22:47.145+0900 E/PKGMGR_SERVER(20345): [0;m
09-11 17:22:47.315+0900 I/Tizen::App(  992): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.samteam.perfectsong, key: start, val: update
09-11 17:22:47.315+0900 I/Tizen::App(  992): (1584) > Package = [org.samteam.perfectsong], Key = [start], Value = [update], install = [1]
09-11 17:22:47.325+0900 W/AUL_AMD (  432): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(580) > __amd_pkgmgrinfo_start_handler
09-11 17:22:47.325+0900 I/Tizen::App(  992): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.samteam.perfectsong, key: install_percent, val: 30
09-11 17:22:47.325+0900 I/Tizen::App(  992): (119) > InstallationInProgress [30]
09-11 17:22:47.325+0900 I/Tizen::App(  992): (1584) > Package = [org.samteam.perfectsong], Key = [install_percent], Value = [30], install = [1]
09-11 17:22:47.335+0900 E/PKGMGR  ( 1050): pkgmgr.c: __find_op_cbinfo(301) > tmp is NULL
09-11 17:22:47.335+0900 E/PKGMGR  ( 1050): pkgmgr.c: __find_op_cbinfo(301) > tmp is NULL
09-11 17:22:47.335+0900 E/PKGMGR  ( 1050): pkgmgr.c: __find_op_cbinfo(301) > tmp is NULL
09-11 17:22:47.345+0900 E/PKGMGR  ( 1050): pkgmgr.c: __find_op_cbinfo(301) > tmp is NULL
09-11 17:22:49.315+0900 E/PKGMGR_CERT(20348): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
09-11 17:22:49.315+0900 E/PKGMGR_CERT(20348): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 106
09-11 17:22:49.315+0900 I/Tizen::App(  992): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.samteam.perfectsong, key: install_percent, val: 60
09-11 17:22:49.315+0900 I/Tizen::App(  992): (119) > InstallationInProgress [60]
09-11 17:22:49.315+0900 I/Tizen::App(  992): (1584) > Package = [org.samteam.perfectsong], Key = [install_percent], Value = [60], install = [1]
09-11 17:22:49.325+0900 E/PKGMGR_CERT(20348): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 106
09-11 17:22:49.325+0900 E/PKGMGR_CERT(20348): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 30 1
09-11 17:22:49.325+0900 E/PKGMGR  ( 1050): pkgmgr.c: __find_op_cbinfo(301) > tmp is NULL
09-11 17:22:49.325+0900 E/PKGMGR  ( 1050): pkgmgr.c: __find_op_cbinfo(301) > tmp is NULL
09-11 17:22:49.325+0900 E/PKGMGR_CERT(20348): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 22 19
09-11 17:22:49.325+0900 E/PKGMGR_CERT(20348): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 23 19
09-11 17:22:49.325+0900 E/PKGMGR_CERT(20348): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 31 1
09-11 17:22:49.345+0900 E/PKGMGR_CERT(20348): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(571) > Transaction Commit and End
09-11 17:22:49.345+0900 E/rpm-installer(20348): coretpk-installer.c: _coretpk_installer_make_directory(1784) > mkdir failed. appdir=[/usr/apps/org.samteam.perfectsong/shared], errno=[2][No such file or directory]
09-11 17:22:49.345+0900 E/rpm-installer(20348): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1406) > skip! empty dirpath=[/usr/apps/org.samteam.perfectsong/shared]
09-11 17:22:49.345+0900 E/rpm-installer(20348): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1406) > skip! empty dirpath=[/opt/usr/apps/org.samteam.perfectsong/shared/data]
09-11 17:22:49.345+0900 E/rpm-installer(20348): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1406) > skip! empty dirpath=[/usr/apps/org.samteam.perfectsong/shared/res]
09-11 17:22:49.345+0900 E/rpm-installer(20348): coretpk-installer.c: _coretpk_installer_apply_file_policy(1391) > skip! empty filepath=[/usr/apps/org.samteam.perfectsong/tizen-manifest.xml]
09-11 17:22:49.345+0900 E/rpm-installer(20348): coretpk-installer.c: _coretpk_installer_apply_file_policy(1391) > skip! empty filepath=[/usr/apps/org.samteam.perfectsong/author-signature.xml]
09-11 17:22:49.345+0900 E/rpm-installer(20348): coretpk-installer.c: _coretpk_installer_apply_file_policy(1391) > skip! empty filepath=[/usr/apps/org.samteam.perfectsong/signature1.xml]
09-11 17:22:49.355+0900 E/rpm-installer(20348): coretpk-installer.c: _coretpk_installer_apply_file_policy(1391) > skip! empty filepath=[/usr/share/packages/org.samteam.perfectsong.xml]
09-11 17:22:49.855+0900 E/rpm-installer(20348): coretpk-installer.c: _coretpk_installer_get_smack_label_access(964) > Error in getting smack ACCESS label failed. result[-1] (path:[/opt/usr/apps/org.samteam.perfectsong/shared/data]))
09-11 17:22:50.015+0900 E/VOLUME  (  627): volume_x_event.c: volume_x_input_event_unregister(351) > [volume_x_input_event_unregister:351] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-11 17:22:50.015+0900 E/VOLUME  (  627): volume_control.c: volume_control_close(708) > [volume_control_close:708] Failed to unregister x input event handler
09-11 17:22:50.015+0900 W/CAM_APP (10809): cam_app.c: __cam_app_display_state_changed_cb(7902) > [33mapp state is PRELAUNCH. ignore this[0m
09-11 17:22:50.025+0900 E/VOLUME  (  627): volume_view.c: volume_view_setting_icon_callback_del(533) > [volume_view_setting_icon_callback_del:533] (!s_info.is_registered_callback) -> volume_view_setting_icon_callback_del() return
09-11 17:22:51.055+0900 E/PKGMGR_INFO(20348): pkgmgrinfo_feature.c: pkgmgrinfo_updateinfo_remove(528) > (strstr(vconf_str, pkgid_is) == NULL) pkgid is already removed
09-11 17:22:51.055+0900 E/PKGMGR_INSTALLER(20348): pkgmgr_installer.c: __send_event(114) > fail to remove update-service
09-11 17:22:51.055+0900 E/PKGMGR  ( 1050): pkgmgr.c: __find_op_cbinfo(301) > tmp is NULL
09-11 17:22:51.055+0900 I/Tizen::App(  992): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.samteam.perfectsong, key: install_percent, val: 100
09-11 17:22:51.055+0900 I/Tizen::App(  992): (119) > InstallationInProgress [100]
09-11 17:22:51.055+0900 I/Tizen::App(  992): (1584) > Package = [org.samteam.perfectsong], Key = [install_percent], Value = [100], install = [1]
09-11 17:22:51.055+0900 I/Tizen::App(  992): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.samteam.perfectsong, key: end, val: ok
09-11 17:22:51.055+0900 I/Tizen::App(  992): (78) > Installation is Completed. [Package = org.samteam.perfectsong]
09-11 17:22:51.055+0900 I/Tizen::App(  992): (663) > Enter. package(org.samteam.perfectsong), installationResult(0)
09-11 17:22:51.065+0900 E/cluster-home(  634): mainmenu-package-manager.cpp: OnClientListenCb(535) >  #Step 1
09-11 17:22:51.065+0900 E/cluster-home(  634): mainmenu-package-manager.cpp: OnClientListenCb(539) >  #Step 2
09-11 17:22:51.065+0900 E/cluster-home(  634): mainmenu-package-manager.cpp: _GetAppIds(344) >  BEGIN
09-11 17:22:51.085+0900 E/PKGMGR  ( 1050): pkgmgr.c: __find_op_cbinfo(301) > tmp is NULL
09-11 17:22:51.085+0900 E/PKGMGR  ( 1050): pkgmgr.c: __find_op_cbinfo(301) > tmp is NULL
09-11 17:22:51.085+0900 E/PKGMGR  ( 1050): pkgmgr.c: __find_op_cbinfo(301) > tmp is NULL
09-11 17:22:51.085+0900 E/cluster-home(  634): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(246) >  ##### [org.samteam.perfectsong]
09-11 17:22:51.085+0900 I/Tizen::App(  992): (1360) > package(org.samteam.perfectsong), version(1.0.0), type(rpm), displayName(pitchTeacher), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.samteam.perfectsong), storeClient(), appRootPath(/opt/usr/apps/org.samteam.perfectsong)
09-11 17:22:51.085+0900 E/cluster-home(  634): mainmenu-package-manager.cpp: _GetAppIds(365) >  ##### [org.samteam.perfectsong]
09-11 17:22:51.085+0900 E/cluster-home(  634): mainmenu-package-manager.cpp: _GetAppIds(369) >  END
09-11 17:22:51.085+0900 E/cluster-home(  634): mainmenu-package-manager.cpp: _DoPkgJob(448) >  #Step 3 size[1]
09-11 17:22:51.085+0900 E/cluster-home(  634): mainmenu-package-manager.cpp: _DoPkgJob(452) >  appId[org.samteam.perfectsong]
09-11 17:22:51.105+0900 I/Tizen::App(  992): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.samteam.perfectsong]
09-11 17:22:51.105+0900 E/cluster-home(  634): mainmenu-package-manager.cpp: _GetAppInfo(941) >  AppId[org.samteam.perfectsong] Name[pitchTeacher] Icon[/opt/usr/apps/org.samteam.perfectsong/shared/res/mainIcon.png] enable[1] system[0]
09-11 17:22:51.125+0900 E/cluster-home(  634): mainmenu-package-manager.cpp: GetAppInfo(595) >  Find a App Info AppId[org.samteam.perfectsong] Name[pitchTeacher] Icon[/opt/usr/apps/org.samteam.perfectsong/shared/res/mainIcon.png] enable[1] system[0]
09-11 17:22:51.145+0900 I/Tizen::App(  992): (416) > appName = [clock]
09-11 17:22:51.155+0900 I/Tizen::App(  992): (509) > exe = [/opt/usr/apps/org.samteam.perfectsong/bin/clock], displayName = [pitchTeacher], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
09-11 17:22:51.155+0900 E/PKGMGR_INFO(  992): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(717) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
09-11 17:22:51.155+0900 I/Tizen::App(  992): (675) > Application count(1) in this package
09-11 17:22:51.155+0900 I/Tizen::App(  992): (855) > Enter.
09-11 17:22:51.155+0900 I/Tizen::App(  992): (695) > Exit.
09-11 17:22:51.155+0900 I/Tizen::App(  992): (1584) > Package = [org.samteam.perfectsong], Key = [end], Value = [ok], install = [96]
09-11 17:22:51.165+0900 I/Tizen::App(  992): (416) > appName = [clock]
09-11 17:22:51.165+0900 I/Tizen::App(  992): (509) > exe = [/opt/usr/apps/org.samteam.perfectsong/bin/clock], displayName = [pitchTeacher], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
09-11 17:22:51.165+0900 I/Tizen::App(  992): (2343) > info file is not existed. [/opt/usr/apps/org.samtea/info/org.samteam.perfectsong.info]
09-11 17:22:51.165+0900 I/Tizen::App(  992): (131) > Enter
09-11 17:22:51.165+0900 I/Tizen::App(  992): (137) > org.samteam.perfectsong does not have launch condition
09-11 17:22:51.165+0900 I/Tizen::App(  992): (898) > Exit.
09-11 17:22:53.185+0900 W/AUL_AMD (  432): amd_request.c: __request_handler(601) > __request_handler: 0
09-11 17:22:53.195+0900 I/AUL     (  432): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/launch_app, ret : 0
09-11 17:22:53.195+0900 I/AUL     (  432): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /bin/bash, ret : 0
09-11 17:22:53.195+0900 E/AUL_AMD (  432): amd_appinfo.c: appinfo_get_value(791) > appinfo get value: Invalid argument, 24
09-11 17:22:53.315+0900 I/CAPI_APPFW_APPLICATION(20425): app_main.c: ui_app_main(699) > app_efl_main
09-11 17:22:53.325+0900 I/Tizen::App( 1005): (733) > Finished invoking application event listener for org.samteam.perfectsong, 20425.
09-11 17:22:53.335+0900 E/RESOURCED(  812): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 414
09-11 17:22:53.335+0900 I/Tizen::App(  992): (499) > LaunchedApp(org.samteam.perfectsong)
09-11 17:22:53.335+0900 I/Tizen::App(  992): (733) > Finished invoking application event listener for org.samteam.perfectsong, 20425.
09-11 17:22:53.365+0900 I/UXT     (20425): uxt_object_manager.cpp: on_initialized(287) > Initialized.
09-11 17:22:53.405+0900 I/CAPI_APPFW_APPLICATION(20425): app_main.c: _ui_app_appcore_create(560) > app_appcore_create
09-11 17:22:53.595+0900 E/EFL     (20425): elementary<20425> elm_layout.c:833 _elm_layout_smart_content_set() could not swallow 0xb8aba508 into part ''
09-11 17:22:53.655+0900 E/EFL     (20425): evas_main<20425> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
09-11 17:22:53.675+0900 E/EFL     (20425): evas_main<20425> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
09-11 17:22:53.865+0900 I/TIZEN_N_AUDIO_IO(20425): audio_io_private.c: audio_in_create_private(267) > mm_sound_pcm_capture_open_ex() success
09-11 17:22:53.865+0900 I/TIZEN_N_AUDIO_IO(20425): audio_io_private.c: audio_in_create_private(285) > mm_sound_pcm_set_message_callback() success
09-11 17:22:53.875+0900 I/TIZEN_N_AUDIO_IO(20425): audio_io.c: audio_in_prepare(88) > [audio_in_prepare] mm_sound_pcm_capture_start() success
09-11 17:22:53.905+0900 I/Tizen::System( 1005): (280) > The screen has been turned on.
09-11 17:22:53.905+0900 I/Tizen::Io( 1005): (729) > Entry not found
09-11 17:22:53.905+0900 W/CAM_APP (10809): cam_app.c: __cam_app_display_state_changed_cb(7902) > [33mapp state is PRELAUNCH. ignore this[0m
09-11 17:22:53.925+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
09-11 17:22:53.925+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
09-11 17:22:53.925+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
09-11 17:22:53.925+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 348 306 5 28 25"
09-11 17:22:53.925+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 360 334 5 28 25"
09-11 17:22:53.925+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 381 362 5 28 25"
09-11 17:22:53.925+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 390 5 28 25"
09-11 17:22:53.925+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 397 418 5 28 25"
09-11 17:22:53.925+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
09-11 17:22:53.925+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
09-11 17:22:53.925+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
09-11 17:22:53.925+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 348 626 5 28 25"
09-11 17:22:53.925+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 360 654 5 28 25"
09-11 17:22:53.925+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 381 682 5 28 25"
09-11 17:22:53.925+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 710 5 28 25"
09-11 17:22:53.925+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 397 738 5 28 25"
09-11 17:22:53.935+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
09-11 17:22:53.945+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
09-11 17:22:53.945+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
09-11 17:22:53.945+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 348 306 5 28 25"
09-11 17:22:53.945+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 360 334 5 28 25"
09-11 17:22:53.945+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 381 362 5 28 25"
09-11 17:22:53.945+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 390 5 28 25"
09-11 17:22:53.945+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 397 418 5 28 25"
09-11 17:22:53.945+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
09-11 17:22:53.945+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
09-11 17:22:53.945+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
09-11 17:22:53.945+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 348 626 5 28 25"
09-11 17:22:53.945+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 360 654 5 28 25"
09-11 17:22:53.945+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 381 682 5 28 25"
09-11 17:22:53.945+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 710 5 28 25"
09-11 17:22:53.945+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 397 738 5 28 25"
09-11 17:22:54.015+0900 I/indicator(  543): indicator_ui.c: on_changed_receive(1388) > "LCD On handling"
09-11 17:22:54.465+0900 W/AUL_AMD (  432): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
09-11 17:22:54.465+0900 W/AUL_AMD (  432): amd_launch.c: __grab_timeout_handler(1309) > back key ungrab error
09-11 17:22:54.565+0900 I/CAPI_APPFW_APPLICATION(20425): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
09-11 17:22:54.585+0900 I/Tizen::System( 1005): (157) > change brightness system value.
09-11 17:22:54.595+0900 I/APP_CORE(20425): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
09-11 17:22:54.595+0900 I/APP_CORE(20425): appcore-efl.c: __do_app(511) > [APP 20425] Initial Launching, call the resume_cb
09-11 17:22:54.595+0900 I/CAPI_APPFW_APPLICATION(20425): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
09-11 17:22:54.595+0900 I/TIZEN_N_PLAYER(20425): player.c: player_start(1582) > [player_start] Start
09-11 17:22:54.595+0900 E/TIZEN_N_PLAYER(20425): player.c: player_start(1583) > [player_start] PLAYER_ERROR_INVALID_PARAMETER(0xffffffea)
09-11 17:22:54.675+0900 W/PROCESSMGR(  376): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=20425
09-11 17:22:54.715+0900 I/QUICKPANEL(  712): sound-profile.c: _view_update(106) > [_view_update : 106] sound : 1, vibration : 0
09-11 17:22:54.725+0900 I/QUICKPANEL(  712): quickpanel-ui.c: _ui_handler_input_region_set(172) > [_ui_handler_input_region_set : 172] win_input_0:0
09-11 17:22:54.725+0900 I/QUICKPANEL(  712): win_input_1:0
09-11 17:22:54.725+0900 I/QUICKPANEL(  712): win_input_2:42
09-11 17:22:54.725+0900 I/QUICKPANEL(  712): win_input_3:800
09-11 17:22:54.725+0900 I/QUICKPANEL(  712): 
09-11 17:22:54.735+0900 I/MALI    (  634): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0xb8aad528] swap changed from sync to async
09-11 17:22:54.805+0900 W/APP_CORE(20425): appcore-efl.c: __show_cb(822) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4800002
09-11 17:22:54.845+0900 I/Tizen::System( 1005): (259) > Active app [org.samtea], current [com.samsun] 
09-11 17:22:54.855+0900 I/Tizen::Io( 1005): (729) > Entry not found
09-11 17:22:54.855+0900 I/Tizen::System( 1005): (157) > change brightness system value.
09-11 17:22:54.875+0900 I/CAPI_APPFW_APPLICATION(  634): app_main.c: app_appcore_pause(202) > app_appcore_pause
09-11 17:22:54.875+0900 E/cluster-home(  634): homescreen-main.cpp: app_pause(355) >  app pause
09-11 17:22:54.885+0900 W/AUL_AMD (  432): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
09-11 17:22:54.885+0900 W/AUL_AMD (  432): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
09-11 17:22:57.125+0900 W/STARTER (  553): hw_key.c: _key_press_cb(673) > [_key_press_cb:673] Home Key is pressed
09-11 17:22:57.125+0900 W/STARTER (  553): hw_key.c: _key_press_cb(691) > [_key_press_cb:691] homekey count : 1
09-11 17:22:57.275+0900 W/STARTER (  553): hw_key.c: _key_release_cb(503) > [_key_release_cb:503] Home Key is released
09-11 17:22:57.365+0900 I/SYSPOPUP(  627): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
09-11 17:22:57.365+0900 I/SYSPOPUP(  627): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
09-11 17:22:57.365+0900 E/VOLUME  (  627): volume_x_event.c: volume_x_input_event_unregister(351) > [volume_x_input_event_unregister:351] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-11 17:22:57.365+0900 E/VOLUME  (  627): volume_control.c: volume_control_close(708) > [volume_control_close:708] Failed to unregister x input event handler
09-11 17:22:57.375+0900 E/VOLUME  (  627): volume_view.c: volume_view_setting_icon_callback_del(533) > [volume_view_setting_icon_callback_del:533] (!s_info.is_registered_callback) -> volume_view_setting_icon_callback_del() return
09-11 17:22:57.515+0900 W/STARTER (  553): hw_key.c: _homekey_timer_cb(404) > [_homekey_timer_cb:404] _homekey_timer_cb, homekey count[1], lock state[0]
09-11 17:22:57.535+0900 W/AUL_AMD (  432): amd_request.c: __request_handler(601) > __request_handler: 0
09-11 17:22:57.545+0900 I/AUL     (  432): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/starter, ret : 0
09-11 17:22:57.545+0900 E/AUL_AMD (  432): amd_appinfo.c: appinfo_get_value(791) > appinfo get value: Invalid argument, 24
09-11 17:22:57.555+0900 W/AUL_AMD (  432): amd_launch.c: __nofork_processing(1083) > __nofork_processing, cmd: 0, pid: 634
09-11 17:22:57.565+0900 W/AUL_AMD (  432): amd_request.c: __send_home_launch_signal(441) > send a home launch signal
09-11 17:22:57.565+0900 I/CAPI_APPFW_APPLICATION(  634): app_main.c: app_appcore_reset(245) > app_appcore_reset
09-11 17:22:57.575+0900 I/APP_CORE(  634): appcore-efl.c: __do_app(516) > Legacy lifecycle: 1
09-11 17:22:57.575+0900 W/AUL_AMD (  432): amd_launch.c: __reply_handler(851) > listen fd(32) , send fd(31), pid(634), cmd(0)
09-11 17:22:57.575+0900 W/AUL_AMD (  432): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
09-11 17:22:57.575+0900 W/AUL_AMD (  432): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
09-11 17:22:57.595+0900 E/STARTER (  553): dbus-util.c: starter_dbus_home_raise_signal_send(168) > [starter_dbus_home_raise_signal_send:168] Sending HOME RAISE signal, result:0
09-11 17:22:57.635+0900 W/PROCESSMGR(  376): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=634
09-11 17:22:57.695+0900 I/QUICKPANEL(  712): sound-profile.c: _view_update(106) > [_view_update : 106] sound : 1, vibration : 0
09-11 17:22:57.715+0900 I/QUICKPANEL(  712): quickpanel-ui.c: _ui_handler_input_region_set(172) > [_ui_handler_input_region_set : 172] win_input_0:0
09-11 17:22:57.715+0900 I/QUICKPANEL(  712): win_input_1:758
09-11 17:22:57.715+0900 I/QUICKPANEL(  712): win_input_2:480
09-11 17:22:57.715+0900 I/QUICKPANEL(  712): win_input_3:42
09-11 17:22:57.715+0900 I/QUICKPANEL(  712): 
09-11 17:22:57.735+0900 I/Tizen::System( 1005): (259) > Active app [com.samsun], current [org.samtea] 
09-11 17:22:57.735+0900 I/Tizen::Io( 1005): (729) > Entry not found
09-11 17:22:57.735+0900 I/Tizen::System( 1005): (157) > change brightness system value.
09-11 17:22:57.765+0900 I/CAPI_APPFW_APPLICATION(20425): app_main.c: _ui_app_appcore_pause(607) > app_appcore_pause
09-11 17:22:57.765+0900 I/TIZEN_N_PLAYER(20425): player.c: player_pause(1678) > [player_pause] Start
09-11 17:22:57.765+0900 E/TIZEN_N_PLAYER(20425): player.c: player_pause(1679) > [player_pause] PLAYER_ERROR_INVALID_PARAMETER(0xffffffea)
09-11 17:22:58.025+0900 I/AUL_PAD (  437): sigchild.h: __launchpad_sig_child(142) > dead_pid = 20425 pgid = 20425
09-11 17:22:58.025+0900 I/AUL_PAD (  437): sigchild.h: __sigchild_action(123) > dead_pid(20425)
09-11 17:22:58.025+0900 I/AUL_PAD (  437): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
09-11 17:22:58.025+0900 I/AUL_PAD (  437): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
09-11 17:22:58.045+0900 W/CRASH_MANAGER(20451): worker.c: worker_job(1198) > 1120425636c6f144195977
