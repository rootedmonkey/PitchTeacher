S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.0
Build-Number: Z130HDDU0BOB3
Build-Date: 2015.02.14 15:10:17

Crash Information
Process Name: clock
PID: 10817
Date: 2015-09-11 16:48:46+0900
Executable File Path: /opt/usr/apps/org.samteam.perfectsong/bin/clock
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 10817, uid 5000)

Register Information
r0   = 0xb3e6c910, r1   = 0x00000000
r2   = 0xffd43a34, r3   = 0xb3e6c8a4
r4   = 0x00000004, r5   = 0x00000021
r6   = 0x000000ad, r7   = 0xbecddba0
r8   = 0x0000001b, r9   = 0x00000000
r10  = 0x00000000, fp   = 0x0000001b
ip   = 0xb89dd4b8, sp   = 0xbecddb50
lr   = 0xb63777b1, pc   = 0xb63691b8
cpsr = 0x00000030

Memory Information
MemTotal:   730748 KB
MemFree:    134860 KB
Buffers:     47724 KB
Cached:     236084 KB
VmPeak:     182768 KB
VmSize:     174276 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       26356 KB
VmRSS:       25664 KB
VmData:     112320 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       28480 KB
VmPTE:          98 KB
VmSwap:          0 KB

Threads Information
Threads: 12
PID = 10817 TID = 10817
10817 10824 10825 10827 10904 10905 10906 10909 10910 10912 10913 10914 

Maps Information
ad716000 adf15000 rwxp [stack:10914]
adf15000 adf2f000 r-xp /usr/lib/gstreamer-0.10/libgstpulse.so
adf38000 adf41000 r-xp /usr/lib/lib_SoundBooster_ver402_wrapped.so
adf4b000 adfc8000 r-xp /usr/lib/lib_SoundAlive_ver125e_wrapped.so
adffa000 ae012000 r-xp /usr/lib/libgstcontroller-0.10.so.0.30.0
ae021000 ae027000 r-xp /usr/lib/gstreamer-0.10/libgstsoundalive.so
ae02f000 ae034000 r-xp /usr/lib/gstreamer-0.10/libgstvolume.so
ae03c000 ae03f000 r-xp /usr/lib/gstreamer-0.10/libgstsecresample.so
ae048000 ae053000 r-xp /usr/lib/gstreamer-0.10/libgstaudioconvert.so
ae05d000 ae85c000 rwxp [stack:10913]
ae85d000 af05c000 rwxp [stack:10912]
af05c000 af085000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
af08e000 af0b3000 r-xp /usr/lib/libgsttag-0.10.so.0.25.0
af0bc000 af0c6000 r-xp /usr/lib/libgstriff-0.10.so.0.25.0
af0cf000 af0f5000 r-xp /usr/lib/gstreamer-0.10/libgstogg.so
af3ff000 afbfe000 rwxp [stack:10827]
afc04000 afc08000 r-xp /usr/lib/gstreamer-0.10/libgstaudiotp.so
afc10000 afc19000 r-xp /usr/lib/gstreamer-0.10/libgstvorbis.so
afc21000 afc39000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
afc42000 afc58000 r-xp /usr/lib/gstreamer-0.10/libgstdecodebin2.so
afc61000 afca4000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
afcae000 afcb8000 r-xp /usr/lib/gstreamer-0.10/libgsttypefindfunctions.so
afcc1000 afcf6000 r-xp /usr/lib/gstreamer-0.10/libgstcoreelements.so
b0000000 b07ff000 rwxp [stack:10825]
b0c01000 b1400000 rwxp [stack:10824]
b1401000 b1c00000 rwxp [stack:10904]
b1c01000 b2400000 rwxp [stack:10905]
b2401000 b2c00000 rwxp [stack:10909]
b2c01000 b3400000 rwxp [stack:10906]
b3500000 b3508000 r-xp /usr/lib/lib_SoundAlive_SRC192_ver204_wrapped.so
b35dc000 b3ddb000 rwxp [stack:10910]
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
b8985000 b8ecb000 rw-p [heap]
beccd000 becee000 rwxp [stack]
beccd000 becee000 rwxp [stack]
End of Maps Information

Callstack Information (PID:10817)
Call Stack Count: 1
 0: (0xb63691b8) [/usr/lib/libevas.so.1] + 0x711b8
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
next node===
09-11 16:48:17.675+0900 I/record  (10817): note : 55 detect :21 isHit : -2 [0: 1071644672/-1262293874]
09-11 16:48:17.675+0900 E/record  (10817): !! interval
09-11 16:48:17.725+0900 I/record  (10817): note : 55 detect :21 isHit : -2 [0: 1071644672/-1262293874]
09-11 16:48:17.725+0900 E/record  (10817): !! interval
09-11 16:48:17.775+0900 I/record  (10817): note : 55 detect :21 isHit : -2 [0: 1071644672/-1262293874]
09-11 16:48:17.775+0900 E/record  (10817): !! interval
09-11 16:48:17.825+0900 I/record  (10817): note : 55 detect :21 isHit : -2 [0: 1071644672/-1262293874]
09-11 16:48:17.835+0900 E/record  (10817): !! interval
09-11 16:48:17.875+0900 I/record  (10817): note : 55 detect :21 isHit : -2 [0: 1071644672/-1262293874]
09-11 16:48:17.875+0900 E/record  (10817): !! interval
09-11 16:48:17.925+0900 I/record  (10817): note : 55 detect :21 isHit : -2 [0: 1071644672/-1262293874]
09-11 16:48:17.925+0900 E/record  (10817): !! interval
09-11 16:48:18.005+0900 F/record  (10817): ===next node===
09-11 16:48:18.005+0900 I/record  (10817): note : 52 detect :106 isHit : -1 [0: 1071644672/-1262293874]
09-11 16:48:18.055+0900 I/record  (10817): note : 52 detect :21 isHit : -2 [0: 1071644672/-1262293874]
09-11 16:48:18.065+0900 E/record  (10817): !! interval
09-11 16:48:18.105+0900 I/record  (10817): note : 52 detect :21 isHit : -2 [0: 1071644672/-1262293874]
09-11 16:48:18.115+0900 E/record  (10817): !! interval
09-11 16:48:18.155+0900 I/record  (10817): note : 52 detect :21 isHit : -2 [0: 1071644672/-1262293874]
09-11 16:48:18.165+0900 E/record  (10817): !! interval
09-11 16:48:18.205+0900 I/record  (10817): note : 52 detect :21 isHit : -2 [0: 1071644672/-1262293874]
09-11 16:48:18.215+0900 E/record  (10817): !! interval
09-11 16:48:18.285+0900 F/record  (10817): ===next node===
09-11 16:48:18.285+0900 I/record  (10817): note : 48 detect :106 isHit : -1 [0: 1071644672/-1262293874]
09-11 16:48:18.335+0900 I/record  (10817): note : 48 detect :21 isHit : -2 [0: 1071644672/-1262293874]
09-11 16:48:18.345+0900 E/record  (10817): !! interval
09-11 16:48:18.385+0900 I/record  (10817): note : 48 detect :21 isHit : -2 [0: 1071644672/-1262293874]
09-11 16:48:18.395+0900 E/record  (10817): !! interval
09-11 16:48:18.465+0900 I/record  (10817): note : 48 detect :106 isHit : -1 [0: 1071644672/-1262293874]
09-11 16:48:18.515+0900 I/record  (10817): note : 48 detect :21 isHit : -2 [0: 1071644672/-1262293874]
09-11 16:48:18.525+0900 E/record  (10817): !! interval
09-11 16:48:18.565+0900 F/record  (10817): ===next node===
09-11 16:48:18.565+0900 I/record  (10817): note : 50 detect :21 isHit : 3 [0: 1071644672/-1262293874]
09-11 16:48:18.615+0900 I/record  (10817): note : 50 detect :21 isHit : 3 [0: 1071644672/-1262293874]
09-11 16:48:18.665+0900 I/record  (10817): note : 50 detect :21 isHit : 3 [0: 1071644672/-1262293874]
09-11 16:48:18.745+0900 I/record  (10817): note : 50 detect :103 isHit : 3 [0: 1071644672/-1262293874]
09-11 16:48:18.795+0900 I/record  (10817): note : 50 detect :21 isHit : 3 [0: 1071644672/-1262293874]
09-11 16:48:18.855+0900 I/record  (10817): note : 50 detect :21 isHit : -2 [0: 1071644672/-1262293874]
09-11 16:48:18.855+0900 E/record  (10817): !! interval
09-11 16:48:18.935+0900 I/record  (10817): note : 50 detect :106 isHit : -1 [0: 1071644672/-1262293874]
09-11 16:48:18.985+0900 I/record  (10817): note : 50 detect :21 isHit : -2 [0: 1071644672/-1262293874]
09-11 16:48:18.995+0900 E/record  (10817): !! interval
09-11 16:48:19.065+0900 I/record  (10817): note : 50 detect :106 isHit : -1 [0: 1071644672/-1262293874]
09-11 16:48:19.115+0900 I/record  (10817): note : 50 detect :21 isHit : -2 [0: 1071644672/-1262293874]
09-11 16:48:19.125+0900 E/record  (10817): !! interval
09-11 16:48:19.165+0900 F/record  (10817): ===next node===
09-11 16:48:19.165+0900 I/record  (10817): note : 52 detect :21 isHit : 3 [0: 1071644672/-1262293874]
09-11 16:48:19.245+0900 I/record  (10817): note : 52 detect :106 isHit : 3 [0: 1071644672/-1262293874]
09-11 16:48:19.295+0900 I/record  (10817): note : 52 detect :21 isHit : 3 [0: 1071644672/-1262293874]
09-11 16:48:19.345+0900 I/record  (10817): note : 52 detect :21 isHit : 3 [0: 1071644672/-1262293874]
09-11 16:48:19.575+0900 I/record  (10817): note : 52 detect :106 isHit : -1 [0: 1071644672/-1262293874]
09-11 16:48:19.715+0900 I/record  (10817): note : 52 detect :21 isHit : -2 [0: 1071644672/-1262293874]
09-11 16:48:19.725+0900 E/record  (10817): !! interval
09-11 16:48:19.935+0900 F/record  (10817): ===next node===
09-11 16:48:19.935+0900 I/record  (10817): note : 50 detect :106 isHit : -1 [0: 1071644672/-1262293874]
09-11 16:48:20.075+0900 F/record  (10817): ===next node===
09-11 16:48:20.075+0900 I/record  (10817): note : 48 detect :21 isHit : -2 [0: 1071644672/-1262293874]
09-11 16:48:20.085+0900 E/record  (10817): !! interval
09-11 16:48:20.295+0900 I/record  (10817): note : 48 detect :21 isHit : -2 [0: 1071644672/-1262293874]
09-11 16:48:20.305+0900 E/record  (10817): !! interval
09-11 16:48:20.485+0900 F/record  (10817): ===next node===
09-11 16:48:20.485+0900 I/record  (10817): note : 52 detect :106 isHit : -1 [0: 1071644672/-1262293874]
09-11 16:48:20.655+0900 F/record  (10817): ===next node===
09-11 16:48:20.655+0900 I/record  (10817): note : 55 detect :21 isHit : -2 [0: 1071644672/-1262293874]
09-11 16:48:20.665+0900 E/record  (10817): !! interval
09-11 16:48:20.825+0900 I/record  (10817): note : 55 detect :21 isHit : -2 [0: 1071644672/-1262293874]
09-11 16:48:20.835+0900 E/record  (10817): !! interval
09-11 16:48:21.015+0900 F/record  (10817): ===next node===
09-11 16:48:21.015+0900 I/record  (10817): note : 60 detect :21 isHit : 3 [0: 1071644672/-1262293874]
09-11 16:48:21.215+0900 I/record  (10817): note : 60 detect :21 isHit : 3 [0: 1071644672/-1262293874]
09-11 16:48:21.405+0900 I/record  (10817): note : 60 detect :106 isHit : -1 [0: 1071644672/-1262293874]
09-11 16:48:21.585+0900 I/record  (10817): note : 60 detect :21 isHit : -2 [0: 1071644672/-1262293874]
09-11 16:48:21.595+0900 E/record  (10817): !! interval
09-11 16:48:21.785+0900 F/record  (10817): ===next node===
09-11 16:48:21.785+0900 I/record  (10817): note : 55 detect :21 isHit : -2 [0: 1071644672/-1262293874]
09-11 16:48:21.795+0900 E/record  (10817): !! interval
09-11 16:48:21.945+0900 F/record  (10817): ===next node===
09-11 16:48:21.945+0900 I/record  (10817): note : 60 detect :21 isHit : -2 [0: 1071644672/-1262293874]
09-11 16:48:21.945+0900 E/record  (10817): !! interval
09-11 16:48:22.145+0900 I/record  (10817): note : 60 detect :21 isHit : -2 [0: 1071644672/-1262293874]
09-11 16:48:22.145+0900 E/record  (10817): !! interval
09-11 16:48:22.305+0900 F/record  (10817): ===next node===
09-11 16:48:22.305+0900 I/record  (10817): note : 55 detect :21 isHit : -2 [0: 1071644672/-1262293874]
09-11 16:48:22.315+0900 E/record  (10817): !! interval
09-11 16:48:22.505+0900 F/record  (10817): ===next node===
09-11 16:48:22.505+0900 I/record  (10817): note : 60 detect :21 isHit : -2 [0: 1071644672/-1262293874]
09-11 16:48:22.515+0900 E/record  (10817): !! interval
09-11 16:48:22.705+0900 I/record  (10817): note : 60 detect :21 isHit : -2 [0: 1071644672/-1262293874]
09-11 16:48:22.715+0900 E/record  (10817): !! interval
09-11 16:48:22.895+0900 F/record  (10817): ===next node===
09-11 16:48:22.895+0900 I/record  (10817): note : 55 detect :106 isHit : -1 [0: 1071644672/-1262293874]
09-11 16:48:23.075+0900 F/record  (10817): ===next node===
09-11 16:48:23.075+0900 I/record  (10817): note : 52 detect :21 isHit : -2 [0: 1071644672/-1262293874]
09-11 16:48:23.075+0900 E/record  (10817): !! interval
09-11 16:48:23.275+0900 I/record  (10817): note : 52 detect :106 isHit : -1 [0: 1071644672/-1262293874]
09-11 16:48:23.445+0900 F/record  (10817): ===next node===
09-11 16:48:23.445+0900 I/record  (10817): note : 55 detect :21 isHit : 3 [0: 1071644672/-1262293874]
09-11 16:48:23.615+0900 I/record  (10817): note : 55 detect :21 isHit : 3 [0: 1071644672/-1262293874]
09-11 16:48:23.845+0900 I/record  (10817): note : 55 detect :106 isHit : -1 [0: 1071644672/-1262293874]
09-11 16:48:23.975+0900 F/record  (10817): ===next node===
09-11 16:48:23.975+0900 I/record  (10817): note : 50 detect :21 isHit : 3 [0: 1071644672/-1262293874]
09-11 16:48:23.995+0900 W/ALARM_MANAGER(  402): alarm-manager.c: __alarm_expired(1210) > alarm_id[983717587] is expired.
09-11 16:48:23.995+0900 W/ALARM_MANAGER(  402): alarm-manager.c: __alarm_remove_from_list(388) > [alarm-server]:Remove alarm id(983717587)
09-11 16:48:23.995+0900 W/ALARM_MANAGER(  402): alarm-manager.c: __rtc_set(192) > Setted RTC Alarm date/time is 11-9-2015, 10:06:07 (UTC).
09-11 16:48:23.995+0900 W/ALARM_MANAGER(  402): alarm-manager.c: __rtc_set(204) > [alarm-server]RTC alarm is set and it's ON.
09-11 16:48:23.995+0900 W/ALARM_MANAGER(  892): alarm-lib.c: __expire_alarm_filter(141) > [alarm-lib] : Alarm expired for [ALARM.apush] : Alarm id [983717587]
09-11 16:48:24.015+0900 I/AUL     (  892): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
09-11 16:48:24.025+0900 I/AUL     (  892): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
09-11 16:48:24.025+0900 W/ALARM_MANAGER(  892): alarm-lib.c: alarmmgr_add_alarm_withcb(1143) > trigger_at_time(15), start(11-9-2015, 16:48:39), repeat(0), interval(0), type(-1073741822)
09-11 16:48:24.035+0900 I/AUL     (  402): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
09-11 16:48:24.045+0900 I/AUL     (  402): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
09-11 16:48:24.055+0900 I/AUL     (  402): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
09-11 16:48:24.065+0900 I/AUL     (  402): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
09-11 16:48:24.075+0900 I/AUL     (  402): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
09-11 16:48:24.085+0900 I/AUL     (  402): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
09-11 16:48:24.085+0900 W/ALARM_MANAGER(  402): alarm-manager-schedule.c: __alarm_next_duetime_once(183) > current_dst = 0
09-11 16:48:24.085+0900 W/ALARM_MANAGER(  402): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1441957719, Fri Sep 11 16:48:39 2015
09-11 16:48:24.085+0900 W/ALARM_MANAGER(  402): alarm-manager-schedule.c: _alarm_next_duetime(505) > alarm_id: 1124972107, next duetime: 1441957719
09-11 16:48:24.095+0900 W/ALARM_MANAGER(  402): alarm-manager.c: __alarm_add_to_list(309) > [alarm-server]: After add alarm_id(1124972107)
09-11 16:48:24.095+0900 W/ALARM_MANAGER(  402): alarm-manager.c: __alarm_create(860) > [alarm-server]:alarm_context.c_due_time(1441965967), due_time(1441957719)
09-11 16:48:24.095+0900 W/ALARM_MANAGER(  402): alarm-manager.c: __rtc_set(192) > Setted RTC Alarm date/time is 11-9-2015, 07:48:39 (UTC).
09-11 16:48:24.155+0900 W/ALARM_MANAGER(  402): alarm-manager.c: __rtc_set(204) > [alarm-server]RTC alarm is set and it's ON.
09-11 16:48:24.185+0900 I/record  (10817): note : 50 detect :21 isHit : 3 [0: 1071644672/-1262293874]
09-11 16:48:24.385+0900 I/record  (10817): note : 50 detect :103 isHit : -1 [0: 1071644672/-1262293874]
09-11 16:48:24.545+0900 F/record  (10817): ===next node===
09-11 16:48:24.545+0900 I/record  (10817): note : 53 detect :21 isHit : -2 [0: 1071644672/-1262293874]
09-11 16:48:24.545+0900 W/ALARM_MANAGER(  402): alarm-manager.c: __alarm_remove_from_list(388) > [alarm-server]:Remove alarm id(1124972107)
09-11 16:48:24.545+0900 W/ALARM_MANAGER(  402): alarm-manager.c: __rtc_set(192) > Setted RTC Alarm date/time is 11-9-2015, 10:06:07 (UTC).
09-11 16:48:24.555+0900 W/ALARM_MANAGER(  402): alarm-manager.c: __rtc_set(204) > [alarm-server]RTC alarm is set and it's ON.
09-11 16:48:24.555+0900 W/ALARM_MANAGER(  402): alarm-manager.c: alarm_manager_alarm_delete(1737) > alarm_id[1124972107] is removed.
09-11 16:48:24.555+0900 E/PUSHD   (  892): ping.c: ping_success(351) > = PING_SUCCESS = avg[240] inc[240] min[240] max[1440] interval[1440] successes[3] max[2] EXLORE[true]
09-11 16:48:24.555+0900 E/record  (10817): !! interval
09-11 16:48:24.565+0900 I/AUL     (  892): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
09-11 16:48:24.575+0900 I/AUL     (  892): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
09-11 16:48:24.575+0900 W/ALARM_MANAGER(  892): alarm-lib.c: alarmmgr_add_alarm_withcb(1143) > trigger_at_time(1440), start(11-9-2015, 17:12:25), repeat(0), interval(0), type(-1073741822)
09-11 16:48:24.585+0900 I/AUL     (  402): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
09-11 16:48:24.595+0900 I/AUL     (  402): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
09-11 16:48:24.605+0900 I/AUL     (  402): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
09-11 16:48:24.615+0900 I/AUL     (  402): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
09-11 16:48:24.625+0900 I/AUL     (  402): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
09-11 16:48:24.645+0900 I/AUL     (  402): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/pushd, ret : 0
09-11 16:48:24.645+0900 W/ALARM_MANAGER(  402): alarm-manager-schedule.c: __alarm_next_duetime_once(183) > current_dst = 0
09-11 16:48:24.645+0900 W/ALARM_MANAGER(  402): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1441959145, Fri Sep 11 17:12:25 2015
09-11 16:48:24.645+0900 W/ALARM_MANAGER(  402): alarm-manager-schedule.c: _alarm_next_duetime(505) > alarm_id: 1124972107, next duetime: 1441959145
09-11 16:48:24.645+0900 W/ALARM_MANAGER(  402): alarm-manager.c: __alarm_add_to_list(309) > [alarm-server]: After add alarm_id(1124972107)
09-11 16:48:24.645+0900 W/ALARM_MANAGER(  402): alarm-manager.c: __alarm_create(860) > [alarm-server]:alarm_context.c_due_time(1441965967), due_time(1441959145)
09-11 16:48:24.645+0900 W/ALARM_MANAGER(  402): alarm-manager.c: __rtc_set(192) > Setted RTC Alarm date/time is 11-9-2015, 08:12:25 (UTC).
09-11 16:48:24.715+0900 W/ALARM_MANAGER(  402): alarm-manager.c: __rtc_set(204) > [alarm-server]RTC alarm is set and it's ON.
09-11 16:48:24.775+0900 I/record  (10817): note : 53 detect :106 isHit : -1 [0: 1071644672/-1262293874]
09-11 16:48:24.915+0900 F/record  (10817): ===next node===
09-11 16:48:24.915+0900 I/record  (10817): note : 52 detect :21 isHit : -2 [0: 1071644672/-1262293874]
09-11 16:48:24.915+0900 E/record  (10817): !! interval
09-11 16:48:25.125+0900 I/record  (10817): note : 52 detect :103 isHit : -1 [0: 1071644672/-1262293874]
09-11 16:48:25.305+0900 F/record  (10817): ===next node===
09-11 16:48:25.305+0900 I/record  (10817): note : 50 detect :103 isHit : -1 [0: 1071644672/-1262293874]
09-11 16:48:25.455+0900 F/record  (10817): ===next node===
09-11 16:48:25.455+0900 I/record  (10817): note : 48 detect :21 isHit : -2 [0: 1071644672/-1262293874]
09-11 16:48:25.465+0900 E/record  (10817): !! interval
09-11 16:48:25.685+0900 I/record  (10817): note : 48 detect :103 isHit : -1 [0: 1071644672/-1262293874]
09-11 16:48:25.845+0900 I/record  (10817): note : 48 detect :21 isHit : -2 [0: 1071644672/-1262293874]
09-11 16:48:25.845+0900 E/record  (10817): !! interval
09-11 16:48:26.035+0900 I/record  (10817): note : 48 detect :21 isHit : -2 [0: 1071644672/-1262293874]
09-11 16:48:26.045+0900 E/record  (10817): !! interval
09-11 16:48:26.235+0900 F/record  (10817): ===next node===
09-11 16:48:26.235+0900 I/record  (10817): note : 55 detect :106 isHit : 3 [0: 1071644672/-1262293874]
09-11 16:48:26.395+0900 I/record  (10817): note : 55 detect :21 isHit : 3 [0: 1071644672/-1262293874]
09-11 16:48:26.575+0900 I/record  (10817): note : 55 detect :21 isHit : 3 [0: 1071644672/-1262293874]
09-11 16:48:26.795+0900 I/record  (10817): note : 55 detect :106 isHit : 3 [0: 1071644672/-1262293874]
09-11 16:48:26.945+0900 I/record  (10817): note : 55 detect :21 isHit : 3 [0: 1071644672/-1262293874]
09-11 16:48:27.155+0900 I/record  (10817): note : 55 detect :106 isHit : 3 [0: 1071644672/-1262293874]
09-11 16:48:27.315+0900 I/record  (10817): note : 55 detect :21 isHit : 3 [0: 1071644672/-1262293874]
09-11 16:48:27.525+0900 I/record  (10817): note : 55 detect :21 isHit : 3 [0: 1071644672/-1262293874]
09-11 16:48:27.715+0900 I/record  (10817): note : 55 detect :106 isHit : 3 [0: 1071644672/-1262293874]
09-11 16:48:27.875+0900 I/record  (10817): note : 55 detect :21 isHit : 3 [0: 1071644672/-1262293874]
09-11 16:48:28.075+0900 I/record  (10817): note : 55 detect :21 isHit : 3 [0: 1071644672/-1262293874]
09-11 16:48:28.255+0900 I/record  (10817): note : 55 detect :21 isHit : 3 [0: 1071644672/-1262293874]
09-11 16:48:28.435+0900 I/record  (10817): note : 55 detect :21 isHit : 3 [0: 1071644672/-1262293874]
09-11 16:48:28.495+0900 I/CAPI_APPFW_APPLICATION(  780): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
09-11 16:48:28.495+0900 I/CAPI_APPFW_APPLICATION( 6213): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
09-11 16:48:28.495+0900 I/CAPI_APPFW_APPLICATION(10817): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
09-11 16:48:28.495+0900 W/CAM_APP ( 6213): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
09-11 16:48:28.615+0900 I/CAPI_APPFW_APPLICATION(10817): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
09-11 16:48:28.615+0900 I/CAPI_APPFW_APPLICATION( 6213): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
09-11 16:48:28.615+0900 I/CAPI_APPFW_APPLICATION(  780): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
09-11 16:48:28.615+0900 W/CAM_APP ( 6213): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
09-11 16:48:28.625+0900 I/record  (10817): note : 55 detect :21 isHit : 3 [0: 1071644672/-1262293874]
09-11 16:48:28.825+0900 I/record  (10817): note : 55 detect :21 isHit : 3 [0: 1071644672/-1262293874]
09-11 16:48:29.005+0900 I/record  (10817): note : 55 detect :21 isHit : 3 [0: 1071644672/-1262293874]
09-11 16:48:29.175+0900 I/record  (10817): note : 55 detect :21 isHit : 3 [0: 1071644672/-1262293874]
09-11 16:48:29.365+0900 I/record  (10817): note : 55 detect :21 isHit : 3 [0: 1071644672/-1262293874]
09-11 16:48:29.565+0900 I/record  (10817): note : 55 detect :21 isHit : 3 [0: 1071644672/-1262293874]
09-11 16:48:29.735+0900 I/record  (10817): note : 55 detect :21 isHit : 3 [0: 1071644672/-1262293874]
09-11 16:48:29.945+0900 I/record  (10817): note : 55 detect :49 isHit : 3 [0: 1071644672/-1262293874]
09-11 16:48:30.015+0900 I/CAPI_APPFW_APPLICATION(  780): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
09-11 16:48:30.015+0900 I/CAPI_APPFW_APPLICATION( 6213): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
09-11 16:48:30.015+0900 W/CAM_APP ( 6213): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
09-11 16:48:30.015+0900 I/CAPI_APPFW_APPLICATION(10817): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
09-11 16:48:30.135+0900 I/record  (10817): note : 55 detect :48 isHit : 3 [0: 1071644672/-1262293874]
09-11 16:48:30.195+0900 I/Tizen::Net::Wifi( 1024): (1072) > _WifiService is not registered.
09-11 16:48:30.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
09-11 16:48:30.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
09-11 16:48:30.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
09-11 16:48:30.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 348 306 5 28 25"
09-11 16:48:30.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 360 334 5 28 25"
09-11 16:48:30.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 381 362 5 28 25"
09-11 16:48:30.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 390 5 28 25"
09-11 16:48:30.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 397 418 5 28 25"
09-11 16:48:30.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
09-11 16:48:30.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
09-11 16:48:30.195+0900 I/indicator(  543): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
09-11 16:48:30.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 348 626 5 28 25"
09-11 16:48:30.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 360 654 5 28 25"
09-11 16:48:30.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 381 682 5 28 25"
09-11 16:48:30.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 710 5 28 25"
09-11 16:48:30.205+0900 I/indicator(  543): indicator_box_util.c: _update_display(585) > "Noti Icon : 397 738 5 28 25"
09-11 16:48:30.315+0900 I/record  (10817): note : 55 detect :97 isHit : 3 [0: 1071644672/-1262293874]
09-11 16:48:30.485+0900 I/record  (10817): note : 55 detect :21 isHit : 3 [0: 1071644672/-1262293874]
09-11 16:48:30.665+0900 I/record  (10817): note : 55 detect :21 isHit : 3 [0: 1071644672/-1262293874]
09-11 16:48:30.855+0900 I/record  (10817): note : 55 detect :21 isHit : -2 [0: 1071644672/-1262293874]
09-11 16:48:30.865+0900 E/record  (10817): !! interval
09-11 16:48:31.055+0900 I/record  (10817): note : 55 detect :47 isHit : -2 [0: 1071644672/-1262293874]
09-11 16:48:31.245+0900 F/record  (10817): ===next node===
09-11 16:48:31.245+0900 I/record  (10817): note : 52 detect :60 isHit : 3 [0: 1071644672/-1262293874]
09-11 16:48:31.445+0900 I/record  (10817): note : 52 detect :61 isHit : -1 [0: 1071644672/-1262293874]
09-11 16:48:31.595+0900 I/record  (10817): note : 52 detect :21 isHit : -2 [0: 1071644672/-1262293874]
09-11 16:48:31.605+0900 E/record  (10817): !! interval
09-11 16:48:31.785+0900 F/record  (10817): ===next node===
09-11 16:48:31.785+0900 I/record  (10817): note : 52 detect :21 isHit : -2 [0: 1071644672/-1262293874]
09-11 16:48:31.795+0900 E/record  (10817): !! interval
09-11 16:48:32.005+0900 I/record  (10817): note : 52 detect :65 isHit : -1 [0: 1071644672/-1262293874]
09-11 16:48:32.155+0900 F/record  (10817): ===next node===
09-11 16:48:32.155+0900 I/record  (10817): note : 55 detect :21 isHit : -2 [0: 1071644672/-1262293874]
09-11 16:48:32.155+0900 E/record  (10817): !! interval
09-11 16:48:32.365+0900 F/record  (10817): ===next node===
09-11 16:48:32.365+0900 I/record  (10817): note : 52 detect :67 isHit : -1 [0: 1071644672/-1262293874]
09-11 16:48:32.545+0900 I/record  (10817): note : 52 detect :65 isHit : -1 [0: 1071644672/-1262293874]
09-11 16:48:32.745+0900 F/record  (10817): ===next node===
09-11 16:48:32.745+0900 I/record  (10817): note : 48 detect :64 isHit : -1 [0: 1071644672/-1262293874]
09-11 16:48:32.925+0900 I/record  (10817): note : 48 detect :60 isHit : 0 [0: 1071644672/-1262293874]
09-11 16:48:33.115+0900 F/record  (10817): ===next node===
09-11 16:48:33.115+0900 I/record  (10817): note : 50 detect :47 isHit : 3 [0: 1071644672/-1262293874]
09-11 16:48:33.295+0900 I/record  (10817): note : 50 detect :21 isHit : -2 [0: 1071644672/-1262293874]
09-11 16:48:33.305+0900 E/record  (10817): !! interval
09-11 16:48:33.475+0900 I/record  (10817): note : 50 detect :47 isHit : -2 [0: 1071644672/-1262293874]
09-11 16:48:33.665+0900 F/record  (10817): ===next node===
09-11 16:48:33.665+0900 I/record  (10817): note : 52 detect :47 isHit : 3 [0: 1071644672/-1262293874]
09-11 16:48:33.845+0900 I/record  (10817): note : 52 detect :49 isHit : 0 [0: 1071644672/-1262293874]
09-11 16:48:34.045+0900 I/record  (10817): note : 52 detect :103 isHit : -1 [0: 1071644672/-1262293874]
09-11 16:48:34.235+0900 F/record  (10817): ===next node===
09-11 16:48:34.235+0900 I/record  (10817): note : 50 detect :51 isHit : 0 [0: 1071644672/-1262293874]
09-11 16:48:34.405+0900 I/record  (10817): note : 50 detect :49 isHit : 0 [0: 1071644672/-1262293874]
09-11 16:48:34.605+0900 F/record  (10817): ===next node===
09-11 16:48:34.605+0900 I/record  (10817): note : 48 detect :49 isHit : 0 [0: 1071644672/-1262293874]
09-11 16:48:34.775+0900 F/record  (10817): ===next node===
09-11 16:48:34.775+0900 I/record  (10817): note : 52 detect :103 isHit : -1 [0: 1071644672/-1262293874]
09-11 16:48:34.975+0900 I/record  (10817): note : 52 detect :99 isHit : -1 [0: 1071644672/-1262293874]
09-11 16:48:35.145+0900 F/record  (10817): ===next node===
09-11 16:48:35.145+0900 I/record  (10817): note : 55 detect :51 isHit : 0 [0: 1071644672/-1262293874]
09-11 16:48:35.315+0900 I/record  (10817): note : 55 detect :21 isHit : -2 [0: 1071644672/-1262293874]
09-11 16:48:35.325+0900 E/record  (10817): !! interval
09-11 16:48:35.495+0900 F/record  (10817): ===next node===
09-11 16:48:35.495+0900 I/record  (10817): note : 60 detect :21 isHit : 3 [0: 1071644672/-1262293874]
09-11 16:48:35.715+0900 I/record  (10817): note : 60 detect :63 isHit : -1 [0: 1071644672/-1262293874]
09-11 16:48:35.895+0900 I/record  (10817): score : 1
09-11 16:48:35.895+0900 I/record  (10817): note : 60 detect :60 isHit : 1 [0: 1071644672/-1262293874]
09-11 16:48:36.095+0900 F/record  (10817): ===next node===
09-11 16:48:36.095+0900 I/record  (10817): note : 55 detect :60 isHit : 0 [0: 1071644672/-1262293874]
09-11 16:48:36.275+0900 F/record  (10817): ===next node===
09-11 16:48:36.275+0900 I/record  (10817): note : 60 detect :76 isHit : -1 [0: 1071644672/-1262293874]
09-11 16:48:36.445+0900 I/record  (10817): note : 60 detect :59 isHit : 0 [0: 1071644672/-1262293874]
09-11 16:48:36.645+0900 I/record  (10817): score : 2
09-11 16:48:36.645+0900 I/record  (10817): note : 60 detect :60 isHit : 1 [0: 1071644672/-1262293874]
09-11 16:48:36.835+0900 F/record  (10817): ===next node===
09-11 16:48:36.835+0900 I/record  (10817): note : 55 detect :21 isHit : -2 [0: 1071644672/-1262293874]
09-11 16:48:36.835+0900 E/record  (10817): !! interval
09-11 16:48:37.015+0900 F/record  (10817): ===next node===
09-11 16:48:37.015+0900 I/record  (10817): note : 60 detect :85 isHit : -1 [0: 1071644672/-1262293874]
09-11 16:48:37.205+0900 F/record  (10817): ===next node===
09-11 16:48:37.205+0900 I/record  (10817): note : 55 detect :60 isHit : 0 [0: 1071644672/-1262293874]
09-11 16:48:37.375+0900 I/record  (10817): note : 55 detect :54 isHit : 0 [0: 1071644672/-1262293874]
09-11 16:48:37.565+0900 F/record  (10817): ===next node===
09-11 16:48:37.565+0900 I/record  (10817): note : 52 detect :55 isHit : 0 [0: 1071644672/-1262293874]
09-11 16:48:37.755+0900 F/record  (10817): ===next node===
09-11 16:48:37.755+0900 I/record  (10817): note : 55 detect :52 isHit : 3 [0: 1071644672/-1262293874]
09-11 16:48:37.925+0900 I/record  (10817): note : 55 detect :91 isHit : 3 [0: 1071644672/-1262293874]
09-11 16:48:38.135+0900 I/record  (10817): note : 55 detect :67 isHit : -1 [0: 1071644672/-1262293874]
09-11 16:48:38.305+0900 I/record  (10817): score : 3
09-11 16:48:38.305+0900 I/record  (10817): note : 55 detect :55 isHit : 1 [0: 1071644672/-1262293874]
09-11 16:48:38.485+0900 F/record  (10817): ===next node===
09-11 16:48:38.485+0900 I/record  (10817): note : 50 detect :56 isHit : 3 [0: 1071644672/-1262293874]
09-11 16:48:38.685+0900 I/record  (10817): note : 50 detect :55 isHit : 0 [0: 1071644672/-1262293874]
09-11 16:48:38.875+0900 I/record  (10817): note : 50 detect :103 isHit : -1 [0: 1071644672/-1262293874]
09-11 16:48:39.025+0900 F/record  (10817): ===next node===
09-11 16:48:39.025+0900 I/record  (10817): note : 53 detect :21 isHit : -2 [0: 1071644672/-1262293874]
09-11 16:48:39.035+0900 E/record  (10817): !! interval
09-11 16:48:39.205+0900 I/record  (10817): note : 53 detect :21 isHit : -2 [0: 1071644672/-1262293874]
09-11 16:48:39.215+0900 E/record  (10817): !! interval
09-11 16:48:39.395+0900 F/record  (10817): ===next node===
09-11 16:48:39.395+0900 I/record  (10817): note : 52 detect :21 isHit : -2 [0: 1071644672/-1262293874]
09-11 16:48:39.395+0900 E/record  (10817): !! interval
09-11 16:48:39.595+0900 F/record  (10817): ===next node===
09-11 16:48:39.595+0900 I/record  (10817): note : 50 detect :21 isHit : -2 [0: 1071644672/-1262293874]
09-11 16:48:39.595+0900 E/record  (10817): !! interval
09-11 16:48:39.775+0900 I/record  (10817): note : 50 detect :21 isHit : -2 [0: 1071644672/-1262293874]
09-11 16:48:39.795+0900 E/record  (10817): !! interval
09-11 16:48:39.795+0900 W/STARTER (  553): hw_key.c: _key_press_cb(673) > [_key_press_cb:673] Home Key is pressed
09-11 16:48:39.795+0900 W/STARTER (  553): hw_key.c: _key_press_cb(691) > [_key_press_cb:691] homekey count : 1
09-11 16:48:39.945+0900 W/STARTER (  553): hw_key.c: _key_release_cb(503) > [_key_release_cb:503] Home Key is released
09-11 16:48:39.995+0900 F/record  (10817): ===next node===
09-11 16:48:39.995+0900 I/record  (10817): note : 48 detect :106 isHit : -1 [0: 1071644672/-1262293874]
09-11 16:48:40.045+0900 I/SYSPOPUP(  627): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
09-11 16:48:40.045+0900 I/SYSPOPUP(  627): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
09-11 16:48:40.045+0900 E/VOLUME  (  627): volume_x_event.c: volume_x_input_event_unregister(351) > [volume_x_input_event_unregister:351] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-11 16:48:40.045+0900 E/VOLUME  (  627): volume_control.c: volume_control_close(708) > [volume_control_close:708] Failed to unregister x input event handler
09-11 16:48:40.045+0900 E/VOLUME  (  627): volume_view.c: volume_view_setting_icon_callback_del(533) > [volume_view_setting_icon_callback_del:533] (!s_info.is_registered_callback) -> volume_view_setting_icon_callback_del() return
09-11 16:48:40.155+0900 I/record  (10817): note : 48 detect :21 isHit : -2 [0: 1071644672/-1262293874]
09-11 16:48:40.155+0900 E/record  (10817): !! interval
09-11 16:48:40.205+0900 W/STARTER (  553): hw_key.c: _homekey_timer_cb(404) > [_homekey_timer_cb:404] _homekey_timer_cb, homekey count[1], lock state[0]
09-11 16:48:40.225+0900 W/AUL_AMD (  432): amd_request.c: __request_handler(601) > __request_handler: 0
09-11 16:48:40.235+0900 I/AUL     (  432): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/starter, ret : 0
09-11 16:48:40.235+0900 E/AUL_AMD (  432): amd_appinfo.c: appinfo_get_value(791) > appinfo get value: Invalid argument, 24
09-11 16:48:40.245+0900 W/AUL_AMD (  432): amd_launch.c: __nofork_processing(1083) > __nofork_processing, cmd: 0, pid: 634
09-11 16:48:40.245+0900 I/CAPI_APPFW_APPLICATION(  634): app_main.c: app_appcore_reset(245) > app_appcore_reset
09-11 16:48:40.255+0900 W/AUL_AMD (  432): amd_request.c: __send_home_launch_signal(441) > send a home launch signal
09-11 16:48:40.255+0900 W/AUL_AMD (  432): amd_launch.c: __reply_handler(851) > listen fd(32) , send fd(27), pid(634), cmd(0)
09-11 16:48:40.265+0900 E/STARTER (  553): dbus-util.c: starter_dbus_home_raise_signal_send(168) > [starter_dbus_home_raise_signal_send:168] Sending HOME RAISE signal, result:0
09-11 16:48:40.265+0900 I/APP_CORE(  634): appcore-efl.c: __do_app(516) > Legacy lifecycle: 1
09-11 16:48:40.265+0900 W/AUL_AMD (  432): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
09-11 16:48:40.265+0900 W/AUL_AMD (  432): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
09-11 16:48:40.285+0900 W/test-log(  634): mainmenu-page-impl.cpp: SetPageEditMode(524) >  editState:[1]
09-11 16:48:40.285+0900 W/test-log(  634): mainmenu-page-impl.cpp: SetPageEditMode(524) >  editState:[1]
09-11 16:48:40.285+0900 W/test-log(  634): mainmenu-page-impl.cpp: SetPageEditMode(524) >  editState:[1]
09-11 16:48:40.285+0900 W/test-log(  634): mainmenu-page-impl.cpp: SetPageEditMode(524) >  editState:[1]
09-11 16:48:40.335+0900 I/record  (10817): note : 48 detect :21 isHit : -2 [0: 1071644672/-1262293874]
09-11 16:48:40.365+0900 E/record  (10817): !! interval
09-11 16:48:40.365+0900 W/PROCESSMGR(  376): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=634
09-11 16:48:40.395+0900 I/QUICKPANEL(  712): sound-profile.c: _view_update(106) > [_view_update : 106] sound : 1, vibration : 0
09-11 16:48:40.405+0900 I/QUICKPANEL(  712): quickpanel-ui.c: _ui_handler_input_region_set(172) > [_ui_handler_input_region_set : 172] win_input_0:0
09-11 16:48:40.405+0900 I/QUICKPANEL(  712): win_input_1:758
09-11 16:48:40.405+0900 I/QUICKPANEL(  712): win_input_2:480
09-11 16:48:40.405+0900 I/QUICKPANEL(  712): win_input_3:42
09-11 16:48:40.405+0900 I/QUICKPANEL(  712): 
09-11 16:48:40.445+0900 I/Tizen::System( 1005): (259) > Active app [com.samsun], current [org.samtea] 
09-11 16:48:40.445+0900 I/Tizen::Io( 1005): (729) > Entry not found
09-11 16:48:40.455+0900 I/Tizen::System( 1005): (157) > change brightness system value.
09-11 16:48:40.495+0900 I/CAPI_APPFW_APPLICATION(10817): app_main.c: _ui_app_appcore_pause(607) > app_appcore_pause
09-11 16:48:40.495+0900 I/TIZEN_N_PLAYER(10817): player.c: player_pause(1678) > [player_pause] Start
09-11 16:48:40.565+0900 W/TIZEN_N_PLAYER(10817): player.c: __msg_callback(660) > [__msg_callback] Got message type : 0x3
09-11 16:48:40.565+0900 I/TIZEN_N_PLAYER(10817): player.c: __msg_callback(686) > STATE CHANGED INTERNALLY - from : 2,  to : 3 (CAPI State : 3)
09-11 16:48:40.565+0900 W/TIZEN_N_PLAYER(10817): player.c: __msg_callback(859) > [__msg_callback] End
09-11 16:48:40.565+0900 I/TIZEN_N_PLAYER(10817): player.c: player_pause(1691) > [player_pause] End
09-11 16:48:42.545+0900 F/record  (10817): <font_size=60, align=center><color=#D43A34>Score : 96</color></font_size></br><font_size=150, align=center>F</font_size>
09-11 16:48:42.545+0900 E/record  (10817): Perfect song Clear
09-11 16:48:42.545+0900 E/record  (10817): perfect_song_end
09-11 16:48:42.755+0900 I/MALI    (  634): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xb8aad528] swap changed from async to sync
09-11 16:48:43.815+0900 W/STARTER (  553): hw_key.c: _key_press_cb(673) > [_key_press_cb:673] Home Key is pressed
09-11 16:48:43.815+0900 W/STARTER (  553): hw_key.c: _key_press_cb(691) > [_key_press_cb:691] homekey count : 1
09-11 16:48:44.205+0900 I/SYSPOPUP(  627): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
09-11 16:48:44.205+0900 I/SYSPOPUP(  627): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
09-11 16:48:44.205+0900 E/VOLUME  (  627): volume_x_event.c: volume_x_input_event_unregister(351) > [volume_x_input_event_unregister:351] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-11 16:48:44.205+0900 E/VOLUME  (  627): volume_control.c: volume_control_close(708) > [volume_control_close:708] Failed to unregister x input event handler
09-11 16:48:44.215+0900 E/VOLUME  (  627): volume_view.c: volume_view_setting_icon_callback_del(533) > [volume_view_setting_icon_callback_del:533] (!s_info.is_registered_callback) -> volume_view_setting_icon_callback_del() return
09-11 16:48:44.245+0900 W/AUL_AMD (  432): amd_request.c: __request_handler(601) > __request_handler: 0
09-11 16:48:44.265+0900 I/AUL     (  432): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/starter, ret : 0
09-11 16:48:44.265+0900 E/AUL_AMD (  432): amd_appinfo.c: appinfo_get_value(791) > appinfo get value: Invalid argument, 24
09-11 16:48:44.385+0900 E/RESOURCED(  812): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 416
09-11 16:48:44.405+0900 I/UXT     (11049): uxt_object_manager.cpp: on_initialized(287) > Initialized.
09-11 16:48:44.435+0900 I/Tizen::App( 1005): (733) > Finished invoking application event listener for com.samsung.task-mgr, 11049.
09-11 16:48:44.435+0900 I/Tizen::App(  992): (499) > LaunchedApp(com.samsung.task-mgr)
09-11 16:48:44.435+0900 I/Tizen::App(  992): (733) > Finished invoking application event listener for com.samsung.task-mgr, 11049.
09-11 16:48:44.695+0900 I/EFL-ASSIST(11049): efl_assist_theme.c: _theme_changeable_ui_data_set(222) > changeable state [1] is set to ecore_evas [b89d13b0]
09-11 16:48:44.705+0900 I/EFL-ASSIST(11049): efl_assist_theme_color.cpp: ea_theme_color_table_new(763) > color table (b8affca0) from (/usr/share/themes/ChangeableColorTable2.xml) is created
09-11 16:48:44.725+0900 I/EFL-ASSIST(11049): efl_assist_theme_color.cpp: ea_theme_color_table_free(781) > color table (b8affca0) is freed
09-11 16:48:44.825+0900 W/AUL_AMD (  432): amd_request.c: __request_handler(601) > __request_handler: 12
09-11 16:48:44.825+0900 E/RUA     (11049): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 3, ncols : 5
09-11 16:48:44.825+0900 E/TASK_MGR_LITE(11049): recent_apps.c: list_retrieve_item(350) > Fail to get ai table !!
09-11 16:48:44.885+0900 W/AUL_AMD (  432): amd_request.c: __request_handler(601) > __request_handler: 12
09-11 16:48:44.895+0900 I/APP_CORE(11049): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
09-11 16:48:44.895+0900 I/APP_CORE(11049): appcore-efl.c: __do_app(511) > [APP 11049] Initial Launching, call the resume_cb
09-11 16:48:44.905+0900 W/APP_CORE(11049): appcore-efl.c: __show_cb(822) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4000008
09-11 16:48:44.905+0900 E/EFL     (11049): evas_main<11049> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
09-11 16:48:44.915+0900 W/PROCESSMGR(  376): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=11049
09-11 16:48:44.925+0900 E/EFL     (11049): evas_main<11049> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
09-11 16:48:44.945+0900 I/Tizen::System( 1005): (259) > Active app [com.samsun], current [com.samsun] 
09-11 16:48:44.955+0900 I/Tizen::System( 1005): (273) > Current App[com.samsun] is already actived.
09-11 16:48:45.005+0900 I/MALI    (  634): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0xb8aad528] swap changed from sync to async
09-11 16:48:45.045+0900 W/AUL_AMD (  432): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
09-11 16:48:45.045+0900 W/AUL_AMD (  432): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
09-11 16:48:45.055+0900 E/TASK_MGR_LITE(11049): genlist_item.c: del_cb(758) > Deleted
09-11 16:48:45.415+0900 W/STARTER (  553): hw_key.c: _key_release_cb(503) > [_key_release_cb:503] Home Key is released
09-11 16:48:45.505+0900 I/SYSPOPUP(  627): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
09-11 16:48:45.505+0900 I/SYSPOPUP(  627): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
09-11 16:48:45.505+0900 E/VOLUME  (  627): volume_x_event.c: volume_x_input_event_unregister(351) > [volume_x_input_event_unregister:351] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
09-11 16:48:45.505+0900 E/VOLUME  (  627): volume_control.c: volume_control_close(708) > [volume_control_close:708] Failed to unregister x input event handler
09-11 16:48:45.515+0900 E/VOLUME  (  627): volume_view.c: volume_view_setting_icon_callback_del(533) > [volume_view_setting_icon_callback_del:533] (!s_info.is_registered_callback) -> volume_view_setting_icon_callback_del() return
09-11 16:48:46.165+0900 E/TASK_MGR_LITE(11049): genlist_item.c: _icon_mouse_up(624) > Mouse up
09-11 16:48:46.175+0900 W/AUL_AMD (  432): amd_request.c: __request_handler(601) > __request_handler: 14
09-11 16:48:46.175+0900 W/AUL_AMD (  432): amd_request.c: __send_result_to_client(79) > __send_result_to_client, pid: 10817
09-11 16:48:46.185+0900 W/AUL_AMD (  432): amd_request.c: __request_handler(601) > __request_handler: 1
09-11 16:48:46.205+0900 W/AUL_AMD (  432): amd_launch.c: __nofork_processing(1083) > __nofork_processing, cmd: 1, pid: 10817
09-11 16:48:46.205+0900 W/AUL_AMD (  432): amd_launch.c: _resume_app(728) > resume done
09-11 16:48:46.215+0900 W/AUL_AMD (  432): amd_launch.c: __reply_handler(851) > listen fd(32) , send fd(27), pid(10817), cmd(3)
09-11 16:48:46.225+0900 W/AUL_AMD (  432): amd_request.c: __request_handler(601) > __request_handler: 22
09-11 16:48:46.225+0900 W/AUL_AMD (  432): amd_request.c: __request_handler(803) > app status : 5
09-11 16:48:46.225+0900 I/APP_CORE(11049): appcore-efl.c: __after_loop(1057) > Legacy lifecycle: 0
09-11 16:48:46.225+0900 I/APP_CORE(11049): appcore-efl.c: __after_loop(1059) > [APP 11049] PAUSE before termination
09-11 16:48:46.235+0900 E/TASK_MGR_LITE(11049): genlist_item.c: del_cb(758) > Deleted
09-11 16:48:46.255+0900 E/APP_CORE(11049): appcore.c: appcore_flush_memory(631) > Appcore not initialized
09-11 16:48:46.265+0900 W/PROCESSMGR(  376): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=634
09-11 16:48:46.275+0900 I/MALI    (11049): egl_platform_x11.c: __egl_platform_terminate(306) > [EGL-X11] ################################################
09-11 16:48:46.275+0900 I/MALI    (11049): egl_platform_x11.c: __egl_platform_terminate(307) > [EGL-X11] PID=11049   close drm_fd=21 
09-11 16:48:46.275+0900 I/MALI    (11049): egl_platform_x11.c: __egl_platform_terminate(308) > [EGL-X11] ################################################
09-11 16:48:46.325+0900 I/Tizen::System( 1005): (259) > Active app [com.samsun], current [com.samsun] 
09-11 16:48:46.325+0900 I/Tizen::System( 1005): (273) > Current App[com.samsun] is already actived.
09-11 16:48:46.325+0900 W/PROCESSMGR(  376): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=10817
09-11 16:48:46.345+0900 I/QUICKPANEL(  712): sound-profile.c: _view_update(106) > [_view_update : 106] sound : 1, vibration : 0
09-11 16:48:46.375+0900 I/QUICKPANEL(  712): quickpanel-ui.c: _ui_handler_input_region_set(172) > [_ui_handler_input_region_set : 172] win_input_0:0
09-11 16:48:46.375+0900 I/QUICKPANEL(  712): win_input_1:0
09-11 16:48:46.375+0900 I/QUICKPANEL(  712): win_input_2:42
09-11 16:48:46.375+0900 I/QUICKPANEL(  712): win_input_3:800
09-11 16:48:46.375+0900 I/QUICKPANEL(  712): 
09-11 16:48:46.385+0900 I/Tizen::System( 1005): (259) > Active app [org.samtea], current [com.samsun] 
09-11 16:48:46.385+0900 I/Tizen::Io( 1005): (729) > Entry not found
09-11 16:48:46.395+0900 I/UXT     (11049): uxt_object_manager.cpp: on_terminating(301) > Terminating.
09-11 16:48:46.395+0900 I/CAPI_APPFW_APPLICATION(  634): app_main.c: app_appcore_pause(202) > app_appcore_pause
09-11 16:48:46.395+0900 E/cluster-home(  634): homescreen-main.cpp: app_pause(355) >  app pause
09-11 16:48:46.395+0900 I/CAPI_APPFW_APPLICATION(10817): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
09-11 16:48:46.395+0900 I/TIZEN_N_PLAYER(10817): player.c: player_start(1582) > [player_start] Start
09-11 16:48:46.415+0900 W/TIZEN_N_PLAYER(10817): player.c: __msg_callback(660) > [__msg_callback] Got message type : 0x3
09-11 16:48:46.415+0900 I/TIZEN_N_PLAYER(10817): player.c: __msg_callback(686) > STATE CHANGED INTERNALLY - from : 3,  to : 2 (CAPI State : 4)
09-11 16:48:46.415+0900 W/TIZEN_N_PLAYER(10817): player.c: __msg_callback(859) > [__msg_callback] End
09-11 16:48:46.415+0900 I/TIZEN_N_PLAYER(10817): player.c: player_start(1632) > [player_start] End
09-11 16:48:46.465+0900 I/Tizen::System( 1005): (157) > change brightness system value.
09-11 16:48:46.555+0900 I/AUL_PAD (  437): sigchild.h: __launchpad_sig_child(142) > dead_pid = 11049 pgid = 11049
09-11 16:48:46.555+0900 I/AUL_PAD (  437): sigchild.h: __sigchild_action(123) > dead_pid(11049)
09-11 16:48:46.555+0900 I/AUL_PAD (  437): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
09-11 16:48:46.555+0900 I/AUL_PAD (  437): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
09-11 16:48:46.555+0900 I/Tizen::System( 1005): (246) > Terminated app [com.samsung.task-mgr]
09-11 16:48:46.555+0900 I/Tizen::App(  992): (243) > App[com.samsung.task-mgr] pid[11049] terminate event is forwarded
09-11 16:48:46.555+0900 I/Tizen::System(  992): (256) > osp.accessorymanager.service provider is found.
09-11 16:48:46.555+0900 I/Tizen::System(  992): (196) > Accessory Owner is removed [com.samsung.task-mgr, 11049, ]
09-11 16:48:46.555+0900 I/Tizen::System(  992): (256) > osp.system.service provider is found.
09-11 16:48:46.555+0900 I/Tizen::App(  992): (506) > TerminatedApp(com.samsung.task-mgr)
09-11 16:48:46.555+0900 I/Tizen::App(  992): (512) > Not registered pid(11049)
09-11 16:48:46.555+0900 I/Tizen::App(  992): (782) > Finished invoking application event listener for com.samsung.task-mgr, 11049.
09-11 16:48:46.555+0900 I/Tizen::Io( 1005): (729) > Entry not found
09-11 16:48:46.555+0900 I/AUL_AMD (  432): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 11049
09-11 16:48:46.565+0900 I/Tizen::System( 1005): (157) > change brightness system value.
09-11 16:48:46.565+0900 I/Tizen::App( 1005): (782) > Finished invoking application event listener for com.samsung.task-mgr, 11049.
09-11 16:48:46.625+0900 I/AUL_PAD (  437): sigchild.h: __launchpad_sig_child(142) > dead_pid = 10817 pgid = 10817
09-11 16:48:46.625+0900 I/AUL_PAD (  437): sigchild.h: __sigchild_action(123) > dead_pid(10817)
09-11 16:48:46.625+0900 I/AUL_PAD (  437): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
09-11 16:48:46.625+0900 I/AUL_PAD (  437): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
09-11 16:48:46.645+0900 I/Tizen::System( 1005): (246) > Terminated app [org.samteam.perfectsong]
09-11 16:48:46.645+0900 I/Tizen::Io( 1005): (729) > Entry not found
09-11 16:48:46.645+0900 I/Tizen::App(  992): (243) > App[org.samteam.perfectsong] pid[10817] terminate event is forwarded
09-11 16:48:46.645+0900 I/Tizen::System(  992): (256) > osp.accessorymanager.service provider is found.
09-11 16:48:46.645+0900 I/Tizen::System(  992): (196) > Accessory Owner is removed [org.samteam.perfectsong, 10817, ]
09-11 16:48:46.645+0900 I/Tizen::System(  992): (256) > osp.system.service provider is found.
09-11 16:48:46.645+0900 I/Tizen::App(  992): (506) > TerminatedApp(org.samteam.perfectsong)
09-11 16:48:46.645+0900 I/Tizen::App(  992): (512) > Not registered pid(10817)
09-11 16:48:46.645+0900 I/Tizen::App(  992): (782) > Finished invoking application event listener for org.samteam.perfectsong, 10817.
09-11 16:48:46.645+0900 I/AUL_AMD (  432): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 10817
09-11 16:48:46.655+0900 W/AUL_AMD (  432): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
09-11 16:48:46.655+0900 W/AUL_AMD (  432): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
09-11 16:48:46.655+0900 W/PROCESSMGR(  376): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=634
09-11 16:48:46.665+0900 I/Tizen::System( 1005): (157) > change brightness system value.
09-11 16:48:46.665+0900 I/Tizen::App( 1005): (782) > Finished invoking application event listener for org.samteam.perfectsong, 10817.
09-11 16:48:46.685+0900 I/CAPI_APPFW_APPLICATION(  634): app_main.c: app_appcore_resume(223) > app_appcore_resume
09-11 16:48:46.685+0900 E/cluster-home(  634): homescreen-main.cpp: app_resume(422) >  app resume
09-11 16:48:46.685+0900 I/QUICKPANEL(  712): sound-profile.c: _view_update(106) > [_view_update : 106] sound : 1, vibration : 0
09-11 16:48:46.725+0900 I/Tizen::System( 1005): (259) > Active app [com.samsun], current [org.samtea] 
09-11 16:48:46.725+0900 I/Tizen::Io( 1005): (729) > Entry not found
09-11 16:48:46.725+0900 I/QUICKPANEL(  712): quickpanel-ui.c: _ui_handler_input_region_set(172) > [_ui_handler_input_region_set : 172] win_input_0:0
09-11 16:48:46.725+0900 I/QUICKPANEL(  712): win_input_1:758
09-11 16:48:46.725+0900 I/QUICKPANEL(  712): win_input_2:480
09-11 16:48:46.725+0900 I/QUICKPANEL(  712): win_input_3:42
09-11 16:48:46.725+0900 I/QUICKPANEL(  712): 
09-11 16:48:46.735+0900 I/Tizen::System( 1005): (157) > change brightness system value.
09-11 16:48:46.795+0900 W/CRASH_MANAGER(11061): worker.c: worker_job(1198) > 1110817636c6f144195772
