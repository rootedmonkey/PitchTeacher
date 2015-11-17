S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.0
Build-Number: Z130HDDU0BOB3
Build-Date: 2015.02.14 15:10:17

Crash Information
Process Name: paaaaaaaaa
PID: 822
Date: 2015-08-14 04:48:12+0900
Executable File Path: /opt/usr/apps/org.samteam.perfectsong/bin/paaaaaaaaa
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 822, uid 5000)

Register Information
r0   = 0x6e6f662f, r1   = 0xb64ff6b0
r2   = 0xbeba9dc3, r3   = 0xb6482869
r4   = 0xb64ff6b0, r5   = 0x6e6f662f
r6   = 0xb6356b70, r7   = 0xbebaa034
r8   = 0x00000000, r9   = 0xb89803d0
r10  = 0xb8b660d8, fp   = 0x00000001
ip   = 0xb6516008, sp   = 0xbeba8d98
lr   = 0xb64c8ebf, pc   = 0xb62bbc96
cpsr = 0x20000030

Memory Information
MemTotal:   730748 KB
MemFree:    183120 KB
Buffers:     40188 KB
Cached:     205652 KB
VmPeak:     188704 KB
VmSize:     154476 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       31196 KB
VmRSS:       30432 KB
VmData:      92876 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       28400 KB
VmPTE:         104 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 822 TID = 822
822 829 830 832 986 

Maps Information
adead000 adec7000 r-xp /usr/lib/gstreamer-0.10/libgstpulse.so
aded0000 aded9000 r-xp /usr/lib/lib_SoundBooster_ver402_wrapped.so
adee3000 adf60000 r-xp /usr/lib/lib_SoundAlive_ver125e_wrapped.so
adf92000 adfaa000 r-xp /usr/lib/libgstcontroller-0.10.so.0.30.0
adfb9000 adfbf000 r-xp /usr/lib/gstreamer-0.10/libgstsoundalive.so
adfc7000 adfcc000 r-xp /usr/lib/gstreamer-0.10/libgstvolume.so
adfd4000 adfdf000 r-xp /usr/lib/gstreamer-0.10/libgstaudioconvert.so
afa8d000 b028c000 rwxp [stack:832]
b028c000 b028f000 r-xp /usr/lib/gstreamer-0.10/libgstsecresample.so
b0298000 b029c000 r-xp /usr/lib/gstreamer-0.10/libgstaudiotp.so
b02a4000 b02cd000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
b039f000 b03a7000 r-xp /usr/lib/lib_SoundAlive_SRC192_ver204_wrapped.so
b03aa000 b03cf000 r-xp /usr/lib/libgsttag-0.10.so.0.25.0
b03d8000 b03e2000 r-xp /usr/lib/libgstriff-0.10.so.0.25.0
b03ef000 b03f8000 r-xp /usr/lib/gstreamer-0.10/libgstvorbis.so
b0400000 b0426000 r-xp /usr/lib/gstreamer-0.10/libgstogg.so
b042f000 b0447000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
b0450000 b0466000 r-xp /usr/lib/gstreamer-0.10/libgstdecodebin2.so
b046f000 b04b2000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
b04bc000 b04c6000 r-xp /usr/lib/gstreamer-0.10/libgsttypefindfunctions.so
b04cf000 b0504000 r-xp /usr/lib/gstreamer-0.10/libgstcoreelements.so
b068e000 b0e8d000 rwxp [stack:830]
b128f000 b1a8e000 rwxp [stack:829]
b358f000 b3d8e000 rwxp [stack:986]
b3f10000 b3f11000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3f19000 b3f20000 r-xp /usr/lib/libfeedback.so.0.1.4
b3f36000 b3f37000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
b3f3f000 b3f41000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
b3f49000 b3f4a000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
b3f52000 b3f69000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b40c5000 b40c9000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b40d2000 b40dc000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b4416000 b44e0000 r-xp /usr/lib/libCOREGL.so.4.0
b44f1000 b44f6000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b44fe000 b4503000 r-xp /usr/lib/libxcb-render.so.0.0.0
b450c000 b450d000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4516000 b452e000 r-xp /usr/lib/libpng12.so.0.50.0
b4536000 b4539000 r-xp /usr/lib/libEGL.so.1.4
b4541000 b454f000 r-xp /usr/lib/libGLESv2.so.2.0
b4558000 b455c000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b4565000 b456e000 r-xp /usr/lib/libmdm-common.so.1.0.45
b4576000 b45be000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b45bf000 b45c5000 r-xp /usr/lib/libjson.so.0.1.0
b45cd000 b462e000 r-xp /usr/lib/libasound.so.2.0.0
b4638000 b463c000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
b4644000 b4647000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b4650000 b4658000 r-xp /usr/lib/libui-extension.so.0.1.0
b4659000 b465c000 r-xp /usr/lib/libnative-buffer.so.0.1.0
b4664000 b4667000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.22
b466f000 b4725000 r-xp /usr/lib/libcairo.so.2.11200.14
b4730000 b4742000 r-xp /usr/lib/libtts.so
b474a000 b4889000 r-xp /usr/lib/libicui18n.so.51.1
b4899000 b489f000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b48a8000 b48b5000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
b48be000 b48c6000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b48ce000 b48d0000 r-xp /usr/lib/libdri2.so.0.0.0
b48d8000 b48df000 r-xp /usr/lib/libdrm.so.2.4.0
b48e8000 b48fb000 r-xp /usr/lib/libmdm.so.1.0.88
b4903000 b490b000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b491a000 b491c000 r-xp /usr/lib/libiniparser.so.0
b4926000 b493c000 r-xp /usr/lib/lib_SamsungRec_TizenV04009.so
b496a000 b496d000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b4975000 b49ac000 r-xp /usr/lib/libpulse.so.0.16.2
b49b5000 b49cb000 r-xp /usr/lib/libavsysaudio.so.0.0.1
b49d3000 b49da000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b49e2000 b49ec000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
b49f8000 b49fd000 r-xp /usr/lib/libmmfsession.so.0.0.0
b4a05000 b4a1b000 r-xp /usr/lib/libefl-assist.so.0.1.0
b4a23000 b4abe000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
b4aca000 b4acd000 r-xp /usr/lib/libmm_ta.so.0.0.0
b4ad5000 b4b21000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b4b29000 b4b30000 r-xp /usr/lib/libtbm.so.1.0.0
b4b38000 b4b3d000 r-xp /usr/lib/libcapi-media-tool.so.0.1.3
b4b45000 b4b59000 r-xp /usr/lib/libmmfsound.so.0.1.0
b4b62000 b4b69000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.4
b4b72000 b4b8a000 r-xp /usr/lib/libcapi-media-player.so.0.1.75
b4b92000 b4b98000 r-xp /usr/lib/libcapi-media-audio-io.so.0.2.31
b4ba2000 b4bac000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
b4bb5000 b4bc0000 r-xp /opt/usr/apps/org.samteam.perfectsong/bin/paaaaaaaaa
b4d9d000 b4da7000 r-xp /lib/libnss_files-2.13.so
b4db0000 b4dc2000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b4dca000 b4de0000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b4de8000 b4eb6000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b4ecd000 b4ef1000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b4efa000 b4f00000 r-xp /usr/lib/libappsvc.so.0.1.0
b4f08000 b4f16000 r-xp /usr/lib/libail.so.0.1.0
b4f1e000 b4f20000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.3
b4f29000 b4f2e000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b4f37000 b4f39000 r-xp /usr/lib/libefl-extension.so.0.1.0
b4f41000 b4f42000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b4f4b000 b4f4f000 r-xp /usr/lib/libogg.so.0.7.1
b4f57000 b4f79000 r-xp /usr/lib/libvorbis.so.0.4.3
b4f81000 b5065000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b5079000 b50aa000 r-xp /usr/lib/libFLAC.so.8.2.0
b5a44000 b5ad8000 r-xp /usr/lib/libstdc++.so.6.0.16
b5aeb000 b5aed000 r-xp /usr/lib/libXau.so.6.0.0
b5af5000 b5aff000 r-xp /usr/lib/libspdy.so.0.0.0
b5b08000 b5b54000 r-xp /usr/lib/libssl.so.1.0.0
b5b61000 b5b8f000 r-xp /usr/lib/libidn.so.11.5.44
b5b97000 b5ba1000 r-xp /usr/lib/libcares.so.2.1.0
b5ba9000 b5bca000 r-xp /usr/lib/libexif.so.12.3.3
b5bdd000 b5c22000 r-xp /usr/lib/libsndfile.so.1.0.25
b5c30000 b5c46000 r-xp /lib/libexpat.so.1.5.2
b5c4f000 b5d34000 r-xp /usr/lib/libicuuc.so.51.1
b5d49000 b5d7d000 r-xp /usr/lib/libicule.so.51.1
b5d86000 b5d99000 r-xp /usr/lib/libxcb.so.1.1.0
b5da1000 b5dde000 r-xp /usr/lib/libcurl.so.4.3.0
b5de7000 b5df0000 r-xp /usr/lib/libethumb.so.1.7.99
b5df9000 b5dfb000 r-xp /usr/lib/libctxdata.so.0.0.0
b5e03000 b5e10000 r-xp /usr/lib/libremix.so.0.0.0
b5e18000 b5e19000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5e21000 b5e38000 r-xp /usr/lib/liblua-5.1.so
b5e41000 b5e48000 r-xp /usr/lib/libembryo.so.1.7.99
b5e50000 b5e73000 r-xp /usr/lib/libjpeg.so.8.0.2
b5e8b000 b5ee1000 r-xp /usr/lib/libpixman-1.so.0.28.2
b5eee000 b5f41000 r-xp /usr/lib/libfreetype.so.6.8.1
b5f4c000 b5f74000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5f75000 b5fbb000 r-xp /usr/lib/libharfbuzz.so.0.907.0
b5fc4000 b5fd7000 r-xp /usr/lib/libfribidi.so.0.3.1
b5fdf000 b5fe2000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b5fea000 b5fee000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b5ff6000 b5ffb000 r-xp /usr/lib/libecore_fb.so.1.7.99
b6004000 b600e000 r-xp /usr/lib/libXext.so.6.4.0
b6016000 b60f7000 r-xp /usr/lib/libX11.so.6.3.0
b6102000 b6105000 r-xp /usr/lib/libXtst.so.6.1.0
b610d000 b6113000 r-xp /usr/lib/libXrender.so.1.3.0
b611b000 b6120000 r-xp /usr/lib/libXrandr.so.2.2.0
b6128000 b6129000 r-xp /usr/lib/libXinerama.so.1.0.0
b6132000 b613a000 r-xp /usr/lib/libXi.so.6.1.0
b613b000 b613e000 r-xp /usr/lib/libXfixes.so.3.1.0
b6146000 b6148000 r-xp /usr/lib/libXgesture.so.7.0.0
b6150000 b6152000 r-xp /usr/lib/libXcomposite.so.1.0.0
b615a000 b615b000 r-xp /usr/lib/libXdamage.so.1.1.0
b6164000 b616a000 r-xp /usr/lib/libXcursor.so.1.0.2
b6173000 b618c000 r-xp /usr/lib/libecore_con.so.1.7.99
b6196000 b619c000 r-xp /usr/lib/libecore_imf.so.1.7.99
b61a4000 b61ac000 r-xp /usr/lib/libethumb_client.so.1.7.99
b61b4000 b61bd000 r-xp /usr/lib/libedbus.so.1.7.99
b61c5000 b6222000 r-xp /usr/lib/libedje.so.1.7.99
b622b000 b623c000 r-xp /usr/lib/libecore_input.so.1.7.99
b6244000 b6249000 r-xp /usr/lib/libecore_file.so.1.7.99
b6251000 b626a000 r-xp /usr/lib/libeet.so.1.7.99
b627b000 b627f000 r-xp /usr/lib/libappcore-common.so.1.1
b6287000 b634e000 r-xp /usr/lib/libevas.so.1.7.99
b6373000 b6394000 r-xp /usr/lib/libecore_evas.so.1.7.99
b639d000 b63cc000 r-xp /usr/lib/libecore_x.so.1.7.99
b63d6000 b650d000 r-xp /usr/lib/libelementary.so.1.7.99
b6523000 b6524000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b652c000 b6530000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.3
b653b000 b653e000 r-xp /lib/libgpg-error.so.0.5.0
b6546000 b659e000 r-xp /usr/lib/libgcrypt.so.11.5.3
b65a8000 b65d4000 r-xp /usr/lib/libsystemd.so.0.0.1
b65dd000 b65df000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b65e8000 b66b3000 r-xp /usr/lib/libxml2.so.2.7.8
b66c1000 b66d1000 r-xp /lib/libresolv-2.13.so
b66d5000 b66eb000 r-xp /lib/libz.so.1.2.5
b66f3000 b66f5000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b66fd000 b6702000 r-xp /usr/lib/libffi.so.5.0.10
b670b000 b670c000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b6714000 b6717000 r-xp /lib/libattr.so.1.1.0
b671f000 b6722000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b672a000 b6731000 r-xp /usr/lib/libvconf.so.0.2.45
b673a000 b68e1000 r-xp /usr/lib/libcrypto.so.1.0.0
b6903000 b6919000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6921000 b698a000 r-xp /lib/libm-2.13.so
b6993000 b69d3000 r-xp /usr/lib/libeina.so.1.7.99
b69dc000 b6a10000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b6a19000 b6aed000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b6af9000 b6afe000 r-xp /usr/lib/libcapi-base-common.so.0.1.6
b6b07000 b6b0d000 r-xp /lib/librt-2.13.so
b6b16000 b6b1d000 r-xp /lib/libcrypt-2.13.so
b6b4d000 b6b50000 r-xp /lib/libcap.so.2.21
b6b58000 b6b5a000 r-xp /usr/lib/libiri.so
b6b62000 b6b81000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6b89000 b6b9f000 r-xp /usr/lib/libecore.so.1.7.99
b6bb5000 b6bba000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6bc3000 b6bda000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6be3000 b6bee000 r-xp /lib/libunwind.so.8.0.1
b6c1b000 b6d36000 r-xp /lib/libc-2.13.so
b6d44000 b6d4c000 r-xp /lib/libgcc_s-4.6.4.so.1
b6d54000 b6d7e000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6d87000 b6d8a000 r-xp /usr/lib/libbundle.so.0.1.22
b6d92000 b6d94000 r-xp /lib/libdl-2.13.so
b6d9d000 b6da0000 r-xp /usr/lib/libsmack.so.1.0.0
b6da8000 b6e78000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6e79000 b6ede000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6ee8000 b6efa000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6f02000 b6f16000 r-xp /lib/libpthread-2.13.so
b6f21000 b6f23000 r-xp /usr/lib/libdlog.so.0.0.0
b6f2b000 b6f36000 r-xp /usr/lib/libaul.so.0.1.0
b6f48000 b6f4b000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f55000 b6f59000 r-xp /usr/lib/libsys-assert.so
b6f62000 b6f7f000 r-xp /lib/ld-2.13.so
b6f88000 b6f8d000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
b87d3000 b87fd000 rw-p [heap]
b87fd000 b90fc000 rw-p [heap]
beb99000 bebba000 rwxp [stack]
End of Maps Information

Callstack Information (PID:822)
Call Stack Count: 3
 0: evas_object_smart_type_check_ptr + 0xd (0xb62bbc96) [/usr/lib/libevas.so.1] + 0x34c96
 1: elm_widget_text_part_set + 0x12 (0xb64c8ebf) [/usr/lib/libelementary.so.1] + 0xf2ebf
 2: create_perfectsong_stats_view + 0x64e (0xb4bbd56b) [/opt/usr/apps/org.samteam.perfectsong/bin/paaaaaaaaa] + 0x856b
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
900 E/record  (  822): !! interval
08-14 04:46:51.940+0900 F/record  (  822): ===next node===
08-14 04:46:51.940+0900 I/record  (  822): note : 40 detect :21 isHit : 3 [0: 1071644672/0]
08-14 04:46:52.100+0900 I/record  (  822): note : 40 detect :21 isHit : 3 [0: 1071644672/0]
08-14 04:46:52.300+0900 I/record  (  822): note : 40 detect :21 isHit : 3 [0: 1071644672/0]
08-14 04:46:52.500+0900 I/record  (  822): note : 40 detect :21 isHit : 3 [0: 1071644672/0]
08-14 04:46:52.670+0900 I/record  (  822): note : 40 detect :21 isHit : 3 [0: 1071644672/0]
08-14 04:46:52.870+0900 I/record  (  822): note : 40 detect :21 isHit : 3 [0: 1071644672/0]
08-14 04:46:53.030+0900 I/record  (  822): note : 40 detect :21 isHit : 3 [0: 1071644672/0]
08-14 04:46:53.230+0900 I/record  (  822): note : 40 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:46:53.230+0900 E/record  (  822): !! interval
08-14 04:46:53.430+0900 I/record  (  822): note : 40 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:46:53.430+0900 E/record  (  822): !! interval
08-14 04:46:53.590+0900 I/record  (  822): note : 40 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:46:53.590+0900 E/record  (  822): !! interval
08-14 04:46:53.790+0900 I/record  (  822): note : 40 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:46:53.790+0900 E/record  (  822): !! interval
08-14 04:46:53.990+0900 F/record  (  822): ===next node===
08-14 04:46:53.990+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:46:53.990+0900 E/record  (  822): !! interval
08-14 04:46:54.150+0900 F/record  (  822): ===next node===
08-14 04:46:54.150+0900 I/record  (  822): note : 38 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:46:54.150+0900 E/record  (  822): !! interval
08-14 04:46:54.330+0900 I/record  (  822): note : 38 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:46:54.330+0900 E/record  (  822): !! interval
08-14 04:46:54.530+0900 F/record  (  822): ===next node===
08-14 04:46:54.530+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:46:54.530+0900 E/record  (  822): !! interval
08-14 04:46:54.730+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:46:54.730+0900 E/record  (  822): !! interval
08-14 04:46:54.890+0900 F/record  (  822): ===next node===
08-14 04:46:54.890+0900 I/record  (  822): note : 45 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:46:54.890+0900 E/record  (  822): !! interval
08-14 04:46:55.100+0900 I/record  (  822): note : 45 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:46:55.100+0900 E/record  (  822): !! interval
08-14 04:46:55.260+0900 F/record  (  822): ===next node===
08-14 04:46:55.260+0900 I/record  (  822): note : 45 detect :21 isHit : 3 [0: 1071644672/0]
08-14 04:46:55.460+0900 I/record  (  822): note : 45 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:46:55.460+0900 E/record  (  822): !! interval
08-14 04:46:55.660+0900 I/record  (  822): note : 45 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:46:55.660+0900 E/record  (  822): !! interval
08-14 04:46:55.820+0900 F/record  (  822): ===next node===
08-14 04:46:55.820+0900 I/record  (  822): note : 45 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:46:55.820+0900 E/record  (  822): !! interval
08-14 04:46:56.020+0900 I/record  (  822): note : 45 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:46:56.020+0900 E/record  (  822): !! interval
08-14 04:46:56.220+0900 F/record  (  822): ===next node===
08-14 04:46:56.220+0900 I/record  (  822): note : 40 detect :21 isHit : 3 [0: 1071644672/0]
08-14 04:46:56.380+0900 I/record  (  822): note : 40 detect :21 isHit : 3 [0: 1071644672/0]
08-14 04:46:56.590+0900 I/record  (  822): note : 40 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:46:56.590+0900 E/record  (  822): !! interval
08-14 04:46:56.750+0900 I/record  (  822): note : 40 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:46:56.750+0900 E/record  (  822): !! interval
08-14 04:46:56.950+0900 F/record  (  822): ===next node===
08-14 04:46:56.950+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:46:56.950+0900 E/record  (  822): !! interval
08-14 04:46:57.150+0900 F/record  (  822): ===next node===
08-14 04:46:57.150+0900 I/record  (  822): note : 43 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:46:57.150+0900 E/record  (  822): !! interval
08-14 04:46:57.330+0900 F/record  (  822): ===next node===
08-14 04:46:57.330+0900 I/record  (  822): note : 42 detect :21 isHit : 3 [0: 1071644672/0]
08-14 04:46:57.500+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:46:57.500+0900 E/record  (  822): !! interval
08-14 04:46:57.700+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:46:57.700+0900 E/record  (  822): !! interval
08-14 04:46:57.860+0900 F/record  (  822): ===next node===
08-14 04:46:57.860+0900 I/record  (  822): note : 40 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:46:57.860+0900 E/record  (  822): !! interval
08-14 04:46:58.060+0900 I/record  (  822): note : 40 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:46:58.060+0900 E/record  (  822): !! interval
08-14 04:46:58.260+0900 F/record  (  822): ===next node===
08-14 04:46:58.260+0900 I/record  (  822): note : 38 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:46:58.260+0900 E/record  (  822): !! interval
08-14 04:46:58.420+0900 I/record  (  822): note : 38 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:46:58.430+0900 E/record  (  822): !! interval
08-14 04:46:58.620+0900 I/record  (  822): note : 38 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:46:58.630+0900 E/record  (  822): !! interval
08-14 04:46:58.830+0900 I/record  (  822): note : 38 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:46:58.830+0900 E/record  (  822): !! interval
08-14 04:46:58.980+0900 I/record  (  822): note : 38 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:46:58.980+0900 E/record  (  822): !! interval
08-14 04:46:59.180+0900 I/record  (  822): note : 38 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:46:59.180+0900 E/record  (  822): !! interval
08-14 04:46:59.340+0900 I/record  (  822): note : 38 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:46:59.340+0900 E/record  (  822): !! interval
08-14 04:46:59.540+0900 F/record  (  822): ===next node===
08-14 04:46:59.540+0900 I/record  (  822): note : 50 detect :21 isHit : 3 [0: 1071644672/0]
08-14 04:46:59.750+0900 F/record  (  822): ===next node===
08-14 04:46:59.750+0900 I/record  (  822): note : 50 detect :21 isHit : 3 [0: 1071644672/0]
08-14 04:46:59.910+0900 F/record  (  822): ===next node===
08-14 04:46:59.910+0900 I/record  (  822): note : 50 detect :21 isHit : 3 [0: 1071644672/0]
08-14 04:47:00.110+0900 F/record  (  822): ===next node===
08-14 04:47:00.110+0900 I/record  (  822): note : 38 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:00.110+0900 E/record  (  822): !! interval
08-14 04:47:00.300+0900 F/record  (  822): ===next node===
08-14 04:47:00.300+0900 I/record  (  822): note : 40 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:00.300+0900 E/record  (  822): !! interval
08-14 04:47:00.500+0900 I/record  (  822): note : 40 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:00.500+0900 E/record  (  822): !! interval
08-14 04:47:00.660+0900 I/record  (  822): note : 40 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:00.660+0900 E/record  (  822): !! interval
08-14 04:47:00.860+0900 F/record  (  822): ===next node===
08-14 04:47:00.860+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:00.860+0900 E/record  (  822): !! interval
08-14 04:47:01.020+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:01.020+0900 E/record  (  822): !! interval
08-14 04:47:01.220+0900 F/record  (  822): ===next node===
08-14 04:47:01.220+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:01.220+0900 E/record  (  822): !! interval
08-14 04:47:01.420+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:01.420+0900 E/record  (  822): !! interval
08-14 04:47:01.580+0900 F/record  (  822): ===next node===
08-14 04:47:01.580+0900 I/record  (  822): note : 38 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:01.580+0900 E/record  (  822): !! interval
08-14 04:47:01.780+0900 I/record  (  822): note : 38 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:01.780+0900 E/record  (  822): !! interval
08-14 04:47:01.940+0900 F/record  (  822): ===next node===
08-14 04:47:01.940+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:01.940+0900 E/record  (  822): !! interval
08-14 04:47:02.150+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:02.150+0900 E/record  (  822): !! interval
08-14 04:47:02.350+0900 F/record  (  822): ===next node===
08-14 04:47:02.350+0900 I/record  (  822): note : 45 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:02.350+0900 E/record  (  822): !! interval
08-14 04:47:02.510+0900 I/record  (  822): note : 45 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:02.510+0900 E/record  (  822): !! interval
08-14 04:47:02.710+0900 F/record  (  822): ===next node===
08-14 04:47:02.710+0900 I/record  (  822): note : 47 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:02.710+0900 E/record  (  822): !! interval
08-14 04:47:02.910+0900 F/record  (  822): ===next node===
08-14 04:47:02.910+0900 I/record  (  822): note : 45 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:02.910+0900 E/record  (  822): !! interval
08-14 04:47:03.070+0900 I/record  (  822): note : 45 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:03.070+0900 E/record  (  822): !! interval
08-14 04:47:03.260+0900 F/record  (  822): ===next node===
08-14 04:47:03.260+0900 I/record  (  822): note : 38 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:03.260+0900 E/record  (  822): !! interval
08-14 04:47:03.460+0900 I/record  (  822): note : 38 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:03.460+0900 E/record  (  822): !! interval
08-14 04:47:03.620+0900 F/record  (  822): ===next node===
08-14 04:47:03.620+0900 I/record  (  822): note : 40 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:03.620+0900 E/record  (  822): !! interval
08-14 04:47:03.820+0900 I/record  (  822): note : 40 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:03.820+0900 E/record  (  822): !! interval
08-14 04:47:04.020+0900 F/record  (  822): ===next node===
08-14 04:47:04.020+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:04.020+0900 E/record  (  822): !! interval
08-14 04:47:04.180+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:04.180+0900 E/record  (  822): !! interval
08-14 04:47:04.390+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:04.390+0900 E/record  (  822): !! interval
08-14 04:47:04.540+0900 F/record  (  822): ===next node===
08-14 04:47:04.540+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:04.540+0900 E/record  (  822): !! interval
08-14 04:47:04.750+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:04.750+0900 E/record  (  822): !! interval
08-14 04:47:04.950+0900 F/record  (  822): ===next node===
08-14 04:47:04.950+0900 I/record  (  822): note : 38 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:04.950+0900 E/record  (  822): !! interval
08-14 04:47:05.110+0900 I/record  (  822): note : 38 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:05.110+0900 E/record  (  822): !! interval
08-14 04:47:05.310+0900 F/record  (  822): ===next node===
08-14 04:47:05.310+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:05.310+0900 E/record  (  822): !! interval
08-14 04:47:05.510+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:05.510+0900 E/record  (  822): !! interval
08-14 04:47:05.670+0900 F/record  (  822): ===next node===
08-14 04:47:05.670+0900 I/record  (  822): note : 45 detect :21 isHit : 3 [0: 1071644672/0]
08-14 04:47:05.870+0900 I/record  (  822): note : 45 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:05.870+0900 E/record  (  822): !! interval
08-14 04:47:06.030+0900 F/record  (  822): ===next node===
08-14 04:47:06.030+0900 I/record  (  822): note : 47 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:06.030+0900 E/record  (  822): !! interval
08-14 04:47:06.220+0900 F/record  (  822): ===next node===
08-14 04:47:06.220+0900 I/record  (  822): note : 45 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:06.220+0900 E/record  (  822): !! interval
08-14 04:47:06.420+0900 I/record  (  822): note : 45 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:06.420+0900 E/record  (  822): !! interval
08-14 04:47:06.620+0900 F/record  (  822): ===next node===
08-14 04:47:06.620+0900 I/record  (  822): note : 47 detect :21 isHit : 3 [0: 1071644672/0]
08-14 04:47:06.780+0900 F/record  (  822): ===next node===
08-14 04:47:06.780+0900 I/record  (  822): note : 47 detect :21 isHit : 3 [0: 1071644672/0]
08-14 04:47:06.980+0900 F/record  (  822): ===next node===
08-14 04:47:06.980+0900 I/record  (  822): note : 47 detect :21 isHit : 3 [0: 1071644672/0]
08-14 04:47:07.150+0900 F/record  (  822): ===next node===
08-14 04:47:07.150+0900 I/record  (  822): note : 47 detect :21 isHit : 3 [0: 1071644672/0]
08-14 04:47:07.350+0900 F/record  (  822): ===next node===
08-14 04:47:07.350+0900 I/record  (  822): note : 47 detect :21 isHit : 3 [0: 1071644672/0]
08-14 04:47:07.550+0900 F/record  (  822): ===next node===
08-14 04:47:07.550+0900 I/record  (  822): note : 47 detect :21 isHit : 3 [0: 1071644672/0]
08-14 04:47:07.710+0900 F/record  (  822): ===next node===
08-14 04:47:07.710+0900 I/record  (  822): note : 45 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:07.710+0900 E/record  (  822): !! interval
08-14 04:47:07.910+0900 F/record  (  822): ===next node===
08-14 04:47:07.910+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:07.910+0900 E/record  (  822): !! interval
08-14 04:47:08.110+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:08.110+0900 E/record  (  822): !! interval
08-14 04:47:08.270+0900 F/record  (  822): ===next node===
08-14 04:47:08.270+0900 I/record  (  822): note : 47 detect :21 isHit : 3 [0: 1071644672/0]
08-14 04:47:08.470+0900 F/record  (  822): ===next node===
08-14 04:47:08.470+0900 I/record  (  822): note : 47 detect :21 isHit : 3 [0: 1071644672/0]
08-14 04:47:08.630+0900 F/record  (  822): ===next node===
08-14 04:47:08.630+0900 I/record  (  822): note : 47 detect :21 isHit : 3 [0: 1071644672/0]
08-14 04:47:08.830+0900 F/record  (  822): ===next node===
08-14 04:47:08.830+0900 I/record  (  822): note : 45 detect :21 isHit : 3 [0: 1071644672/0]
08-14 04:47:09.030+0900 I/record  (  822): note : 45 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:09.040+0900 E/record  (  822): !! interval
08-14 04:47:09.190+0900 I/record  (  822): note : 45 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:09.190+0900 E/record  (  822): !! interval
08-14 04:47:09.380+0900 I/record  (  822): note : 45 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:09.380+0900 E/record  (  822): !! interval
08-14 04:47:09.580+0900 F/record  (  822): ===next node===
08-14 04:47:09.580+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:09.580+0900 E/record  (  822): !! interval
08-14 04:47:09.780+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:09.780+0900 E/record  (  822): !! interval
08-14 04:47:09.940+0900 F/record  (  822): ===next node===
08-14 04:47:09.940+0900 I/record  (  822): note : 40 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:09.940+0900 E/record  (  822): !! interval
08-14 04:47:10.140+0900 I/record  (  822): note : 40 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:10.140+0900 E/record  (  822): !! interval
08-14 04:47:10.300+0900 F/record  (  822): ===next node===
08-14 04:47:10.300+0900 I/record  (  822): note : 40 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:10.300+0900 E/record  (  822): !! interval
08-14 04:47:10.510+0900 I/record  (  822): note : 40 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:10.510+0900 E/record  (  822): !! interval
08-14 04:47:10.710+0900 F/record  (  822): ===next node===
08-14 04:47:10.710+0900 I/record  (  822): note : 38 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:10.710+0900 E/record  (  822): !! interval
08-14 04:47:10.870+0900 I/record  (  822): note : 38 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:10.870+0900 E/record  (  822): !! interval
08-14 04:47:11.070+0900 I/record  (  822): note : 38 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:11.070+0900 E/record  (  822): !! interval
08-14 04:47:11.270+0900 F/record  (  822): ===next node===
08-14 04:47:11.270+0900 I/record  (  822): note : 40 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:11.270+0900 E/record  (  822): !! interval
08-14 04:47:11.430+0900 I/record  (  822): note : 40 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:11.430+0900 E/record  (  822): !! interval
08-14 04:47:11.630+0900 F/record  (  822): ===next node===
08-14 04:47:11.630+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:11.630+0900 E/record  (  822): !! interval
08-14 04:47:11.790+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:11.790+0900 E/record  (  822): !! interval
08-14 04:47:11.990+0900 F/record  (  822): ===next node===
08-14 04:47:11.990+0900 I/record  (  822): note : 40 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:11.990+0900 E/record  (  822): !! interval
08-14 04:47:12.200+0900 I/record  (  822): note : 40 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:12.200+0900 E/record  (  822): !! interval
08-14 04:47:12.380+0900 F/record  (  822): ===next node===
08-14 04:47:12.380+0900 I/record  (  822): note : 38 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:12.380+0900 E/record  (  822): !! interval
08-14 04:47:12.540+0900 I/record  (  822): note : 38 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:12.540+0900 E/record  (  822): !! interval
08-14 04:47:12.750+0900 I/record  (  822): note : 38 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:12.750+0900 E/record  (  822): !! interval
08-14 04:47:12.910+0900 F/record  (  822): ===next node===
08-14 04:47:12.910+0900 I/record  (  822): note : 38 detect :21 isHit : 3 [0: 1071644672/0]
08-14 04:47:13.110+0900 I/record  (  822): note : 38 detect :21 isHit : 3 [0: 1071644672/0]
08-14 04:47:13.310+0900 I/record  (  822): note : 38 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:13.310+0900 E/record  (  822): !! interval
08-14 04:47:13.470+0900 I/record  (  822): note : 38 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:13.470+0900 E/record  (  822): !! interval
08-14 04:47:13.680+0900 F/record  (  822): ===next node===
08-14 04:47:13.680+0900 I/record  (  822): note : 40 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:13.680+0900 E/record  (  822): !! interval
08-14 04:47:13.840+0900 I/record  (  822): note : 40 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:13.840+0900 E/record  (  822): !! interval
08-14 04:47:14.040+0900 F/record  (  822): ===next node===
08-14 04:47:14.040+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:14.040+0900 E/record  (  822): !! interval
08-14 04:47:14.200+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:14.200+0900 E/record  (  822): !! interval
08-14 04:47:14.400+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:14.400+0900 E/record  (  822): !! interval
08-14 04:47:14.610+0900 F/record  (  822): ===next node===
08-14 04:47:14.610+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:14.610+0900 E/record  (  822): !! interval
08-14 04:47:14.770+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:14.770+0900 E/record  (  822): !! interval
08-14 04:47:14.970+0900 F/record  (  822): ===next node===
08-14 04:47:14.970+0900 I/record  (  822): note : 38 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:14.970+0900 E/record  (  822): !! interval
08-14 04:47:15.170+0900 I/record  (  822): note : 38 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:15.170+0900 E/record  (  822): !! interval
08-14 04:47:15.330+0900 F/record  (  822): ===next node===
08-14 04:47:15.330+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:15.330+0900 E/record  (  822): !! interval
08-14 04:47:15.530+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:15.530+0900 E/record  (  822): !! interval
08-14 04:47:15.690+0900 F/record  (  822): ===next node===
08-14 04:47:15.690+0900 I/record  (  822): note : 45 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:15.690+0900 E/record  (  822): !! interval
08-14 04:47:15.890+0900 F/record  (  822): ===next node===
08-14 04:47:15.890+0900 I/record  (  822): note : 47 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:15.890+0900 E/record  (  822): !! interval
08-14 04:47:16.090+0900 F/record  (  822): ===next node===
08-14 04:47:16.090+0900 I/record  (  822): note : 45 detect :21 isHit : 3 [0: 1071644672/0]
08-14 04:47:16.250+0900 I/record  (  822): note : 45 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:16.250+0900 E/record  (  822): !! interval
08-14 04:47:16.450+0900 I/record  (  822): note : 45 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:16.460+0900 E/record  (  822): !! interval
08-14 04:47:16.650+0900 F/record  (  822): ===next node===
08-14 04:47:16.650+0900 I/record  (  822): note : 38 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:16.660+0900 E/record  (  822): !! interval
08-14 04:47:16.810+0900 I/record  (  822): note : 38 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:16.810+0900 E/record  (  822): !! interval
08-14 04:47:17.010+0900 F/record  (  822): ===next node===
08-14 04:47:17.010+0900 I/record  (  822): note : 40 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:17.010+0900 E/record  (  822): !! interval
08-14 04:47:17.210+0900 I/record  (  822): note : 40 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:17.210+0900 E/record  (  822): !! interval
08-14 04:47:17.370+0900 F/record  (  822): ===next node===
08-14 04:47:17.370+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:17.370+0900 E/record  (  822): !! interval
08-14 04:47:17.570+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:17.570+0900 E/record  (  822): !! interval
08-14 04:47:17.730+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:17.740+0900 E/record  (  822): !! interval
08-14 04:47:17.940+0900 F/record  (  822): ===next node===
08-14 04:47:17.940+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:17.940+0900 E/record  (  822): !! interval
08-14 04:47:18.130+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:18.140+0900 E/record  (  822): !! interval
08-14 04:47:18.300+0900 F/record  (  822): ===next node===
08-14 04:47:18.300+0900 I/record  (  822): note : 38 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:18.300+0900 E/record  (  822): !! interval
08-14 04:47:18.500+0900 I/record  (  822): note : 38 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:18.500+0900 E/record  (  822): !! interval
08-14 04:47:18.700+0900 F/record  (  822): ===next node===
08-14 04:47:18.700+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:18.700+0900 E/record  (  822): !! interval
08-14 04:47:18.860+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:18.860+0900 E/record  (  822): !! interval
08-14 04:47:19.060+0900 F/record  (  822): ===next node===
08-14 04:47:19.060+0900 I/record  (  822): note : 45 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:19.060+0900 E/record  (  822): !! interval
08-14 04:47:19.220+0900 F/record  (  822): ===next node===
08-14 04:47:19.220+0900 I/record  (  822): note : 47 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:19.220+0900 E/record  (  822): !! interval
08-14 04:47:19.420+0900 F/record  (  822): ===next node===
08-14 04:47:19.420+0900 I/record  (  822): note : 45 detect :21 isHit : 3 [0: 1071644672/0]
08-14 04:47:19.620+0900 I/record  (  822): note : 45 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:19.620+0900 E/record  (  822): !! interval
08-14 04:47:19.810+0900 I/record  (  822): note : 45 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:19.810+0900 E/record  (  822): !! interval
08-14 04:47:19.970+0900 F/record  (  822): ===next node===
08-14 04:47:19.970+0900 I/record  (  822): note : 47 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:19.970+0900 E/record  (  822): !! interval
08-14 04:47:20.170+0900 I/record  (  822): note : 47 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:20.170+0900 E/record  (  822): !! interval
08-14 04:47:20.370+0900 I/record  (  822): note : 47 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:20.370+0900 E/record  (  822): !! interval
08-14 04:47:20.530+0900 I/record  (  822): note : 47 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:20.530+0900 E/record  (  822): !! interval
08-14 04:47:20.730+0900 F/record  (  822): ===next node===
08-14 04:47:20.730+0900 I/record  (  822): note : 45 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:20.730+0900 E/record  (  822): !! interval
08-14 04:47:20.930+0900 I/record  (  822): note : 45 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:20.930+0900 E/record  (  822): !! interval
08-14 04:47:21.090+0900 F/record  (  822): ===next node===
08-14 04:47:21.090+0900 I/record  (  822): note : 42 detect :21 isHit : 3 [0: 1071644672/0]
08-14 04:47:21.290+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:21.290+0900 E/record  (  822): !! interval
08-14 04:47:21.450+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:21.460+0900 E/record  (  822): !! interval
08-14 04:47:21.660+0900 F/record  (  822): ===next node===
08-14 04:47:21.660+0900 I/record  (  822): note : 47 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:21.660+0900 E/record  (  822): !! interval
08-14 04:47:21.860+0900 I/record  (  822): note : 47 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:21.860+0900 E/record  (  822): !! interval
08-14 04:47:22.020+0900 I/record  (  822): note : 47 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:22.020+0900 E/record  (  822): !! interval
08-14 04:47:22.220+0900 I/record  (  822): note : 47 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:22.220+0900 E/record  (  822): !! interval
08-14 04:47:22.380+0900 F/record  (  822): ===next node===
08-14 04:47:22.380+0900 I/record  (  822): note : 45 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:22.380+0900 E/record  (  822): !! interval
08-14 04:47:22.580+0900 I/record  (  822): note : 45 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:22.580+0900 E/record  (  822): !! interval
08-14 04:47:22.770+0900 F/record  (  822): ===next node===
08-14 04:47:22.770+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:22.770+0900 E/record  (  822): !! interval
08-14 04:47:22.970+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:22.970+0900 E/record  (  822): !! interval
08-14 04:47:23.130+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:23.130+0900 E/record  (  822): !! interval
08-14 04:47:23.330+0900 F/record  (  822): ===next node===
08-14 04:47:23.330+0900 I/record  (  822): note : 40 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:23.330+0900 E/record  (  822): !! interval
08-14 04:47:23.530+0900 I/record  (  822): note : 40 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:23.530+0900 E/record  (  822): !! interval
08-14 04:47:23.690+0900 F/record  (  822): ===next node===
08-14 04:47:23.690+0900 I/record  (  822): note : 40 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:23.690+0900 E/record  (  822): !! interval
08-14 04:47:23.890+0900 I/record  (  822): note : 40 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:23.900+0900 E/record  (  822): !! interval
08-14 04:47:24.050+0900 F/record  (  822): ===next node===
08-14 04:47:24.060+0900 I/record  (  822): note : 38 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:24.060+0900 E/record  (  822): !! interval
08-14 04:47:24.250+0900 I/record  (  822): note : 38 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:24.250+0900 E/record  (  822): !! interval
08-14 04:47:24.460+0900 F/record  (  822): ===next node===
08-14 04:47:24.460+0900 I/record  (  822): note : 40 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:24.460+0900 E/record  (  822): !! interval
08-14 04:47:24.620+0900 I/record  (  822): note : 40 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:24.620+0900 E/record  (  822): !! interval
08-14 04:47:24.820+0900 I/record  (  822): note : 40 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:24.820+0900 E/record  (  822): !! interval
08-14 04:47:24.980+0900 F/record  (  822): ===next node===
08-14 04:47:24.980+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:24.980+0900 E/record  (  822): !! interval
08-14 04:47:25.180+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:25.180+0900 E/record  (  822): !! interval
08-14 04:47:25.380+0900 F/record  (  822): ===next node===
08-14 04:47:25.380+0900 I/record  (  822): note : 45 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:25.380+0900 E/record  (  822): !! interval
08-14 04:47:25.540+0900 I/record  (  822): note : 45 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:25.540+0900 E/record  (  822): !! interval
08-14 04:47:25.730+0900 F/record  (  822): ===next node===
08-14 04:47:25.730+0900 I/record  (  822): note : 45 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:25.730+0900 E/record  (  822): !! interval
08-14 04:47:25.930+0900 I/record  (  822): note : 45 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:25.930+0900 E/record  (  822): !! interval
08-14 04:47:26.090+0900 F/record  (  822): ===next node===
08-14 04:47:26.090+0900 I/record  (  822): note : 47 detect :21 isHit : 3 [0: 1071644672/0]
08-14 04:47:26.290+0900 I/record  (  822): note : 47 detect :21 isHit : 3 [0: 1071644672/0]
08-14 04:47:26.490+0900 I/record  (  822): note : 47 detect :21 isHit : 3 [0: 1071644672/0]
08-14 04:47:26.650+0900 I/record  (  822): note : 47 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:26.650+0900 E/record  (  822): !! interval
08-14 04:47:26.850+0900 I/record  (  822): note : 47 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:26.850+0900 E/record  (  822): !! interval
08-14 04:47:27.060+0900 I/record  (  822): note : 47 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:27.060+0900 E/record  (  822): !! interval
08-14 04:47:27.220+0900 F/record  (  822): ===next node===
08-14 04:47:27.220+0900 I/record  (  822): note : 47 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:27.220+0900 E/record  (  822): !! interval
08-14 04:47:27.420+0900 F/record  (  822): ===next node===
08-14 04:47:27.420+0900 I/record  (  822): note : 45 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:27.420+0900 E/record  (  822): !! interval
08-14 04:47:27.580+0900 I/record  (  822): note : 45 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:27.580+0900 E/record  (  822): !! interval
08-14 04:47:27.780+0900 F/record  (  822): ===next node===
08-14 04:47:27.780+0900 I/record  (  822): note : 47 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:27.780+0900 E/record  (  822): !! interval
08-14 04:47:27.990+0900 I/record  (  822): note : 47 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:27.990+0900 E/record  (  822): !! interval
08-14 04:47:28.150+0900 I/record  (  822): note : 47 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:28.150+0900 E/record  (  822): !! interval
08-14 04:47:28.350+0900 F/record  (  822): ===next node===
08-14 04:47:28.350+0900 I/record  (  822): note : 50 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:28.350+0900 E/record  (  822): !! interval
08-14 04:47:28.510+0900 I/record  (  822): note : 50 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:28.510+0900 E/record  (  822): !! interval
08-14 04:47:28.710+0900 F/record  (  822): ===next node===
08-14 04:47:28.710+0900 I/record  (  822): note : 50 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:28.710+0900 E/record  (  822): !! interval
08-14 04:47:28.890+0900 I/record  (  822): note : 50 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:28.890+0900 E/record  (  822): !! interval
08-14 04:47:29.090+0900 F/record  (  822): ===next node===
08-14 04:47:29.090+0900 I/record  (  822): note : 50 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:29.100+0900 E/record  (  822): !! interval
08-14 04:47:29.250+0900 I/record  (  822): note : 50 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:29.250+0900 E/record  (  822): !! interval
08-14 04:47:29.460+0900 F/record  (  822): ===next node===
08-14 04:47:29.460+0900 I/record  (  822): note : 45 detect :21 isHit : 3 [0: 1071644672/0]
08-14 04:47:29.660+0900 I/record  (  822): note : 45 detect :21 isHit : 3 [0: 1071644672/0]
08-14 04:47:29.820+0900 I/record  (  822): note : 45 detect :21 isHit : 3 [0: 1071644672/0]
08-14 04:47:30.020+0900 I/record  (  822): note : 45 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:30.020+0900 E/record  (  822): !! interval
08-14 04:47:30.180+0900 I/record  (  822): note : 45 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:30.180+0900 E/record  (  822): !! interval
08-14 04:47:30.380+0900 I/record  (  822): note : 45 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:30.380+0900 E/record  (  822): !! interval
08-14 04:47:30.580+0900 F/record  (  822): ===next node===
08-14 04:47:30.580+0900 I/record  (  822): note : 45 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:30.580+0900 E/record  (  822): !! interval
08-14 04:47:30.740+0900 F/record  (  822): ===next node===
08-14 04:47:30.740+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:30.740+0900 E/record  (  822): !! interval
08-14 04:47:30.940+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:30.940+0900 E/record  (  822): !! interval
08-14 04:47:31.150+0900 F/record  (  822): ===next node===
08-14 04:47:31.150+0900 I/record  (  822): note : 40 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:31.150+0900 E/record  (  822): !! interval
08-14 04:47:31.310+0900 I/record  (  822): note : 40 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:31.310+0900 E/record  (  822): !! interval
08-14 04:47:31.510+0900 F/record  (  822): ===next node===
08-14 04:47:31.510+0900 I/record  (  822): note : 38 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:31.510+0900 E/record  (  822): !! interval
08-14 04:47:31.670+0900 I/record  (  822): note : 38 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:31.670+0900 E/record  (  822): !! interval
08-14 04:47:31.850+0900 I/record  (  822): note : 38 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:31.850+0900 E/record  (  822): !! interval
08-14 04:47:32.050+0900 F/record  (  822): ===next node===
08-14 04:47:32.050+0900 I/record  (  822): note : 40 detect :21 isHit : 3 [0: 1071644672/0]
08-14 04:47:32.260+0900 I/record  (  822): note : 40 detect :21 isHit : 3 [0: 1071644672/0]
08-14 04:47:32.420+0900 I/record  (  822): note : 40 detect :21 isHit : 3 [0: 1071644672/0]
08-14 04:47:32.620+0900 I/record  (  822): note : 40 detect :21 isHit : 3 [0: 1071644672/0]
08-14 04:47:32.780+0900 I/record  (  822): note : 40 detect :21 isHit : 3 [0: 1071644672/0]
08-14 04:47:32.980+0900 I/record  (  822): note : 40 detect :21 isHit : 3 [0: 1071644672/0]
08-14 04:47:33.180+0900 I/record  (  822): note : 40 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:33.180+0900 E/record  (  822): !! interval
08-14 04:47:33.340+0900 I/record  (  822): note : 40 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:33.350+0900 E/record  (  822): !! interval
08-14 04:47:33.540+0900 I/record  (  822): note : 40 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:33.540+0900 E/record  (  822): !! interval
08-14 04:47:33.750+0900 I/record  (  822): note : 40 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:33.750+0900 E/record  (  822): !! interval
08-14 04:47:33.910+0900 F/record  (  822): ===next node===
08-14 04:47:33.910+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:33.910+0900 E/record  (  822): !! interval
08-14 04:47:34.110+0900 F/record  (  822): ===next node===
08-14 04:47:34.110+0900 I/record  (  822): note : 38 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:34.110+0900 E/record  (  822): !! interval
08-14 04:47:34.270+0900 I/record  (  822): note : 38 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:34.270+0900 E/record  (  822): !! interval
08-14 04:47:34.470+0900 F/record  (  822): ===next node===
08-14 04:47:34.470+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:34.470+0900 E/record  (  822): !! interval
08-14 04:47:34.670+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:34.670+0900 E/record  (  822): !! interval
08-14 04:47:34.850+0900 F/record  (  822): ===next node===
08-14 04:47:34.850+0900 I/record  (  822): note : 45 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:34.860+0900 E/record  (  822): !! interval
08-14 04:47:35.010+0900 I/record  (  822): note : 45 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:35.010+0900 E/record  (  822): !! interval
08-14 04:47:35.210+0900 I/record  (  822): note : 45 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:35.210+0900 E/record  (  822): !! interval
08-14 04:47:35.420+0900 F/record  (  822): ===next node===
08-14 04:47:35.420+0900 I/record  (  822): note : 45 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:35.420+0900 E/record  (  822): !! interval
08-14 04:47:35.580+0900 I/record  (  822): note : 45 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:35.580+0900 E/record  (  822): !! interval
08-14 04:47:35.770+0900 F/record  (  822): ===next node===
08-14 04:47:35.770+0900 I/record  (  822): note : 45 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:35.780+0900 E/record  (  822): !! interval
08-14 04:47:35.980+0900 I/record  (  822): note : 45 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:35.980+0900 E/record  (  822): !! interval
08-14 04:47:36.140+0900 F/record  (  822): ===next node===
08-14 04:47:36.140+0900 I/record  (  822): note : 40 detect :21 isHit : 3 [0: 1071644672/0]
08-14 04:47:36.340+0900 I/record  (  822): note : 40 detect :21 isHit : 3 [0: 1071644672/0]
08-14 04:47:36.500+0900 I/record  (  822): note : 40 detect :21 isHit : 3 [0: 1071644672/0]
08-14 04:47:36.700+0900 I/record  (  822): note : 40 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:36.700+0900 E/record  (  822): !! interval
08-14 04:47:36.900+0900 I/record  (  822): note : 40 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:36.900+0900 E/record  (  822): !! interval
08-14 04:47:37.060+0900 F/record  (  822): ===next node===
08-14 04:47:37.060+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:37.060+0900 E/record  (  822): !! interval
08-14 04:47:37.260+0900 F/record  (  822): ===next node===
08-14 04:47:37.260+0900 I/record  (  822): note : 43 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:37.260+0900 E/record  (  822): !! interval
08-14 04:47:37.420+0900 F/record  (  822): ===next node===
08-14 04:47:37.420+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:37.420+0900 E/record  (  822): !! interval
08-14 04:47:37.630+0900 I/record  (  822): note : 42 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:37.630+0900 E/record  (  822): !! interval
08-14 04:47:37.820+0900 F/record  (  822): ===next node===
08-14 04:47:37.820+0900 I/record  (  822): note : 40 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:37.820+0900 E/record  (  822): !! interval
08-14 04:47:38.020+0900 I/record  (  822): note : 40 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:38.020+0900 E/record  (  822): !! interval
08-14 04:47:38.180+0900 F/record  (  822): ===next node===
08-14 04:47:38.180+0900 I/record  (  822): note : 38 detect :21 isHit : 3 [0: 1071644672/0]
08-14 04:47:38.370+0900 I/record  (  822): note : 38 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:38.370+0900 E/record  (  822): !! interval
08-14 04:47:38.580+0900 I/record  (  822): note : 38 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:38.580+0900 E/record  (  822): !! interval
08-14 04:47:38.740+0900 I/record  (  822): note : 38 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:38.740+0900 E/record  (  822): !! interval
08-14 04:47:38.940+0900 I/record  (  822): note : 38 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:38.940+0900 E/record  (  822): !! interval
08-14 04:47:39.100+0900 I/record  (  822): note : 38 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:39.100+0900 E/record  (  822): !! interval
08-14 04:47:39.300+0900 I/record  (  822): note : 38 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:39.300+0900 E/record  (  822): !! interval
08-14 04:47:39.460+0900 F/record  (  822): ===next node===
08-14 04:47:39.460+0900 I/record  (  822): note : 50 detect :21 isHit : -2 [0: 1071644672/0]
08-14 04:47:39.470+0900 E/record  (  822): !! interval
08-14 04:47:39.670+0900 F/record  (  822): ===next node===
08-14 04:47:39.670+0900 I/record  (  822): note : 50 detect :21 isHit : 3 [0: 1071644672/0]
08-14 04:47:39.870+0900 F/record  (  822): ===next node===
08-14 04:47:39.870+0900 I/record  (  822): note : 50 detect :21 isHit : 3 [0: 1071644672/0]
08-14 04:47:42.030+0900 F/record  (  822): <font_size=60, align=center><color=#D43A34>Score : 0</color></font_size></br><font_size=150, align=center>F</font_size>
08-14 04:47:42.040+0900 E/record  (  822): Perfect song Clear
08-14 04:47:42.040+0900 E/record  (  822): perfect_song_end
08-14 04:47:43.060+0900 W/TIZEN_N_PLAYER(  822): player.c: __msg_callback(660) > [__msg_callback] Got message type : 0x105
08-14 04:47:43.060+0900 W/TIZEN_N_PLAYER(  822): player.c: __msg_callback(859) > [__msg_callback] End
08-14 04:48:08.560+0900 F/record  (  822): perfectsong button Callback
08-14 04:48:08.570+0900 E/asdf    (  822): -1193253240
08-14 04:48:08.570+0900 F/EFL     (  822): evas_main<822> main.c:101 evas_debug_magic_null() Input object is zero'ed out (maybe a freed object or zero-filled RAM)!
08-14 04:48:08.570+0900 E/asdf    (  822): -1193253240
08-14 04:48:08.570+0900 I/TIZEN_N_PLAYER(  822): player.c: player_stop(1639) > [player_stop] Start
08-14 04:48:08.600+0900 W/TIZEN_N_PLAYER(  822): player.c: __msg_callback(660) > [__msg_callback] Got message type : 0x3
08-14 04:48:08.600+0900 I/TIZEN_N_PLAYER(  822): player.c: __msg_callback(686) > STATE CHANGED INTERNALLY - from : 2,  to : 1 (CAPI State : 3)
08-14 04:48:08.610+0900 W/TIZEN_N_PLAYER(  822): player.c: __msg_callback(859) > [__msg_callback] End
08-14 04:48:08.610+0900 I/TIZEN_N_PLAYER(  822): player.c: player_stop(1665) > [player_stop] End
08-14 04:48:08.610+0900 I/TIZEN_N_PLAYER(  822): player.c: player_destroy(1098) > [player_destroy] Start, handle to destroy : 0xb8c45800
08-14 04:48:08.610+0900 I/TIZEN_N_PLAYER(  822): player.c: __message_cb_loop(575) > Retrived  message [5] from queue
08-14 04:48:08.610+0900 W/TIZEN_N_PLAYER(  822): player.c: __message_cb_loop(638) > PLAYER_MESSAGE_LOOP_EXIT
08-14 04:48:08.610+0900 I/TIZEN_N_PLAYER(  822): player.c: player_destroy(1114) > Adding message [5] to queue
08-14 04:48:08.610+0900 I/TIZEN_N_PLAYER(  822): player.c: player_destroy(1119) > message thread released
08-14 04:48:08.640+0900 I/TIZEN_N_PLAYER(  822): player.c: player_destroy(1129) > [player_destroy] Done mm_player_destroy
08-14 04:48:08.640+0900 I/TIZEN_N_PLAYER(  822): player.c: player_destroy(1157) > [player_destroy] End
08-14 04:48:08.640+0900 E/asdf    (  822): escape
08-14 04:48:09.280+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-14 04:48:09.280+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-14 04:48:09.280+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-14 04:48:09.280+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 306 5 28 25"
08-14 04:48:09.280+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 267 334 5 28 25"
08-14 04:48:09.280+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 279 362 5 28 25"
08-14 04:48:09.280+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 390 5 28 25"
08-14 04:48:09.280+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 282 418 5 28 25"
08-14 04:48:09.280+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-14 04:48:09.280+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-14 04:48:09.280+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-14 04:48:09.280+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 598 5 28 25"
08-14 04:48:09.290+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 265 626 5 28 25"
08-14 04:48:09.290+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 267 654 5 28 25"
08-14 04:48:09.290+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 279 682 5 28 25"
08-14 04:48:09.290+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 710 5 28 25"
08-14 04:48:09.290+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 282 738 5 28 25"
08-14 04:48:09.290+0900 I/Tizen::Net::Wifi( 1076): (1072) > _WifiService is not registered.
08-14 04:48:09.320+0900 E/asdf    (  822): escape
08-14 04:48:12.940+0900 W/AUL_AMD (  449): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
08-14 04:48:12.940+0900 W/AUL_AMD (  449): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
08-14 04:48:12.960+0900 I/AUL_PAD (  496): sigchild.h: __launchpad_sig_child(142) > dead_pid = 822 pgid = 822
08-14 04:48:12.960+0900 I/AUL_PAD (  496): sigchild.h: __sigchild_action(123) > dead_pid(822)
08-14 04:48:12.960+0900 I/AUL_PAD (  496): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
08-14 04:48:12.960+0900 I/AUL_PAD (  496): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
08-14 04:48:12.970+0900 W/PROCESSMGR(  418): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=591
08-14 04:48:12.970+0900 I/Tizen::System( 1060): (246) > Terminated app [org.samteam.perfectsong]
08-14 04:48:12.970+0900 I/Tizen::Io( 1060): (729) > Entry not found
08-14 04:48:12.970+0900 I/Tizen::App(  882): (243) > App[org.samteam.perfectsong] pid[822] terminate event is forwarded
08-14 04:48:12.970+0900 I/Tizen::System(  882): (256) > osp.accessorymanager.service provider is found.
08-14 04:48:12.970+0900 I/Tizen::System(  882): (196) > Accessory Owner is removed [org.samteam.perfectsong, 822, ]
08-14 04:48:12.970+0900 I/Tizen::System(  882): (256) > osp.system.service provider is found.
08-14 04:48:12.970+0900 I/Tizen::App(  882): (506) > TerminatedApp(org.samteam.perfectsong)
08-14 04:48:12.970+0900 I/Tizen::App(  882): (512) > Not registered pid(822)
08-14 04:48:12.970+0900 I/Tizen::App(  882): (782) > Finished invoking application event listener for org.samteam.perfectsong, 822.
08-14 04:48:12.970+0900 I/AUL_AMD (  449): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 822
08-14 04:48:12.990+0900 I/Tizen::System( 1060): (157) > change brightness system value.
08-14 04:48:12.990+0900 I/Tizen::App( 1060): (782) > Finished invoking application event listener for org.samteam.perfectsong, 822.
08-14 04:48:13.010+0900 I/CAPI_APPFW_APPLICATION(  591): app_main.c: app_appcore_resume(223) > app_appcore_resume
08-14 04:48:13.010+0900 E/cluster-home(  591): homescreen-main.cpp: app_resume(422) >  app resume
08-14 04:48:13.030+0900 W/CRASH_MANAGER( 1766): worker.c: worker_job(1198) > 1100822706161143949529
