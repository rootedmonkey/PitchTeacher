S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.0
Build-Number: Z130HDDU0BOB3
Build-Date: 2015.02.14 15:10:17

Crash Information
Process Name: paaaaaaaaa
PID: 24947
Date: 2015-08-13 23:41:29+0900
Executable File Path: /opt/usr/apps/org.samteam.perfectsong/bin/paaaaaaaaa
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 24947, uid 5000)

Register Information
r0   = 0x00000006, r1   = 0x00000025
r2   = 0xbe9bedbc, r3   = 0x00000006
r4   = 0xfbad8001, r5   = 0xbe9bedbc
r6   = 0xbe9be888, r7   = 0xb6d47000
r8   = 0x00000000, r9   = 0xb653f4d0
r10  = 0x00000006, fp   = 0xbe9be87c
ip   = 0xb6f31a18, sp   = 0xbe9be308
lr   = 0xb6c5ef5c, pc   = 0xb6c995d8
cpsr = 0x20000010

Memory Information
MemTotal:   730748 KB
MemFree:    178316 KB
Buffers:     46532 KB
Cached:     215588 KB
VmPeak:     184908 KB
VmSize:     184904 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       26652 KB
VmRSS:       26648 KB
VmData:     116064 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       28392 KB
VmPTE:         104 KB
VmSwap:          0 KB

Threads Information
Threads: 12
PID = 24947 TID = 24947
24947 24954 24955 24958 24971 24972 24973 24976 24977 24978 24979 24981 

Maps Information
ad8cf000 ae0ce000 rwxp [stack:24981]
ae0ce000 ae14b000 r-xp /usr/lib/lib_SoundAlive_ver125e_wrapped.so
ae169000 ae968000 rwxp [stack:24979]
ae969000 af168000 rwxp [stack:24978]
af28d000 afa8c000 rwxp [stack:24958]
afab8000 afad2000 r-xp /usr/lib/gstreamer-0.10/libgstpulse.so
afadb000 afae4000 r-xp /usr/lib/lib_SoundBooster_ver402_wrapped.so
afb03000 afb1b000 r-xp /usr/lib/libgstcontroller-0.10.so.0.30.0
afb2a000 afb30000 r-xp /usr/lib/gstreamer-0.10/libgstsoundalive.so
afb38000 afb40000 r-xp /usr/lib/lib_SoundAlive_SRC192_ver204_wrapped.so
afb4b000 afb50000 r-xp /usr/lib/gstreamer-0.10/libgstvolume.so
afb58000 afb5b000 r-xp /usr/lib/gstreamer-0.10/libgstsecresample.so
afb64000 afb6f000 r-xp /usr/lib/gstreamer-0.10/libgstaudioconvert.so
afb78000 afba1000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
afbaa000 afbcf000 r-xp /usr/lib/libgsttag-0.10.so.0.25.0
afbd8000 afbe2000 r-xp /usr/lib/libgstriff-0.10.so.0.25.0
afbf4000 afbf8000 r-xp /usr/lib/gstreamer-0.10/libgstaudiotp.so
afc00000 afc26000 r-xp /usr/lib/gstreamer-0.10/libgstogg.so
afc2f000 afc47000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
afc50000 afc66000 r-xp /usr/lib/gstreamer-0.10/libgstdecodebin2.so
afc6f000 afcb2000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
afcbc000 afcc6000 r-xp /usr/lib/gstreamer-0.10/libgsttypefindfunctions.so
afccf000 afd04000 r-xp /usr/lib/gstreamer-0.10/libgstcoreelements.so
afe8e000 b068d000 rwxp [stack:24955]
b0a8f000 b128e000 rwxp [stack:24954]
b128f000 b1a8e000 rwxp [stack:24971]
b1a8f000 b228e000 rwxp [stack:24972]
b2401000 b2c00000 rwxp [stack:24973]
b2c01000 b3400000 rwxp [stack:24976]
b3501000 b350a000 r-xp /usr/lib/gstreamer-0.10/libgstvorbis.so
b3597000 b3d96000 rwxp [stack:24977]
b3f18000 b3f19000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3f21000 b3f28000 r-xp /usr/lib/libfeedback.so.0.1.4
b3f3e000 b3f3f000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
b3f47000 b3f49000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
b3f51000 b3f52000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
b3f5a000 b3f71000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b40cd000 b40d1000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b40da000 b40e4000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b441e000 b44e8000 r-xp /usr/lib/libCOREGL.so.4.0
b44f9000 b44fe000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b4506000 b450b000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4514000 b4515000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b451e000 b4536000 r-xp /usr/lib/libpng12.so.0.50.0
b453e000 b4541000 r-xp /usr/lib/libEGL.so.1.4
b4549000 b4557000 r-xp /usr/lib/libGLESv2.so.2.0
b4560000 b4564000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b456d000 b4576000 r-xp /usr/lib/libmdm-common.so.1.0.45
b457e000 b45c6000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b45c7000 b45cd000 r-xp /usr/lib/libjson.so.0.1.0
b45d5000 b4636000 r-xp /usr/lib/libasound.so.2.0.0
b4640000 b4644000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
b464c000 b464f000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b4658000 b4660000 r-xp /usr/lib/libui-extension.so.0.1.0
b4661000 b4664000 r-xp /usr/lib/libnative-buffer.so.0.1.0
b466c000 b466f000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.22
b4677000 b472d000 r-xp /usr/lib/libcairo.so.2.11200.14
b4738000 b474a000 r-xp /usr/lib/libtts.so
b4752000 b4891000 r-xp /usr/lib/libicui18n.so.51.1
b48a1000 b48a7000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b48b0000 b48bd000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
b48c6000 b48ce000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b48d6000 b48d8000 r-xp /usr/lib/libdri2.so.0.0.0
b48e0000 b48e7000 r-xp /usr/lib/libdrm.so.2.4.0
b48f0000 b4903000 r-xp /usr/lib/libmdm.so.1.0.88
b490b000 b4913000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b4922000 b4924000 r-xp /usr/lib/libiniparser.so.0
b492e000 b4944000 r-xp /usr/lib/lib_SamsungRec_TizenV04009.so
b4972000 b4975000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b497d000 b49b4000 r-xp /usr/lib/libpulse.so.0.16.2
b49bd000 b49d3000 r-xp /usr/lib/libavsysaudio.so.0.0.1
b49db000 b49e2000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b49ea000 b49f4000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
b4a00000 b4a05000 r-xp /usr/lib/libmmfsession.so.0.0.0
b4a0d000 b4a23000 r-xp /usr/lib/libefl-assist.so.0.1.0
b4a2b000 b4ac6000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
b4ad2000 b4ad5000 r-xp /usr/lib/libmm_ta.so.0.0.0
b4add000 b4b29000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b4b31000 b4b38000 r-xp /usr/lib/libtbm.so.1.0.0
b4b40000 b4b45000 r-xp /usr/lib/libcapi-media-tool.so.0.1.3
b4b4d000 b4b61000 r-xp /usr/lib/libmmfsound.so.0.1.0
b4b6a000 b4b71000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.4
b4b7a000 b4b92000 r-xp /usr/lib/libcapi-media-player.so.0.1.75
b4b9a000 b4ba0000 r-xp /usr/lib/libcapi-media-audio-io.so.0.2.31
b4baa000 b4bb4000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
b4bbd000 b4bc6000 r-xp /opt/usr/apps/org.samteam.perfectsong/bin/paaaaaaaaa
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
b72ad000 b77d2000 rw-p [heap]
be9ae000 be9cf000 rwxp [stack]
b7283000 b72ad000 rw-p [heap]
b72ad000 b77d2000 rw-p [heap]
be9ae000 be9cf000 rwxp [stack]
End of Maps Information

Callstack Information (PID:24947)
Call Stack Count: 5
 0: strchrnul + 0x14 (0xb6c995d8) [/lib/libc.so.6] + 0x775d8
 1: _IO_vfprintf + 0x98 (0xb6c5ef5c) [/lib/libc.so.6] + 0x3cf5c
 2: __vsnprintf_chk + 0xa0 (0xb6cf9c68) [/lib/libc.so.6] + 0xd7c68
 3: dlog_print + 0x42 (0xb6f29063) [/usr/lib/libdlog.so.0] + 0x1063
 4: statsInput + 0x62 (0xb4bc19cb) [/opt/usr/apps/org.samteam.perfectsong/bin/paaaaaaaaa] + 0x49cb
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
58.440+0900 I/EVT     (24947):     9024 90 0A 2A  6E
08-13 23:40:58.440+0900 I/EVT     (24947):     9104 90 0A 2A  00
08-13 23:40:58.440+0900 I/EVT     (24947):     9120 90 0A 2A  6E
08-13 23:40:58.440+0900 I/EVT     (24947):     9200 90 0A 2A  00
08-13 23:40:58.440+0900 I/TRACK   (24947): TRACK END: 7 (9200 ticks)
08-13 23:40:58.440+0900 I/June    (24947): asdfasdf 최대 60  최소48  비율27
08-13 23:40:58.580+0900 I/TIZEN_N_PLAYER(24947): player.c: player_create(1091) > [player_create] new handle : 0xb741f140
08-13 23:40:58.580+0900 I/TIZEN_N_PLAYER(24947): player.c: player_prepare(1272) > [player_prepare] Start
08-13 23:40:58.620+0900 W/TIZEN_N_PLAYER(24947): player.c: __msg_callback(660) > [__msg_callback] Got message type : 0x3
08-13 23:40:58.620+0900 I/TIZEN_N_PLAYER(24947): player.c: __msg_callback(686) > STATE CHANGED INTERNALLY - from : 0,  to : 1 (CAPI State : 1)
08-13 23:40:58.620+0900 W/TIZEN_N_PLAYER(24947): player.c: __msg_callback(859) > [__msg_callback] End
08-13 23:40:58.860+0900 I/Tizen::Net::Wifi(  970): (1072) > _WifiService is not registered.
08-13 23:40:58.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 23:40:58.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 23:40:58.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 23:40:58.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 306 5 28 25"
08-13 23:40:58.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 334 5 28 25"
08-13 23:40:58.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 362 5 28 25"
08-13 23:40:58.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 241 390 5 28 25"
08-13 23:40:58.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 418 5 28 25"
08-13 23:40:58.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 23:40:58.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 23:40:58.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 23:40:58.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 626 5 28 25"
08-13 23:40:58.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 654 5 28 25"
08-13 23:40:58.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 682 5 28 25"
08-13 23:40:58.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 241 710 5 28 25"
08-13 23:40:58.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 738 5 28 25"
08-13 23:40:58.910+0900 W/TIZEN_N_PLAYER(24947): player.c: __msg_callback(660) > [__msg_callback] Got message type : 0x3
08-13 23:40:58.910+0900 I/TIZEN_N_PLAYER(24947): player.c: __msg_callback(686) > STATE CHANGED INTERNALLY - from : 1,  to : 3 (CAPI State : 1)
08-13 23:40:58.910+0900 W/TIZEN_N_PLAYER(24947): player.c: __msg_callback(859) > [__msg_callback] End
08-13 23:40:58.910+0900 I/TIZEN_N_PLAYER(24947): player.c: player_prepare(1343) > [player_prepare] End
08-13 23:40:58.910+0900 I/TIZEN_N_PLAYER(24947): player.c: player_start(1582) > [player_start] Start
08-13 23:40:58.920+0900 W/TIZEN_N_PLAYER(24947): player.c: __msg_callback(660) > [__msg_callback] Got message type : 0x3
08-13 23:40:58.920+0900 I/TIZEN_N_PLAYER(24947): player.c: __msg_callback(686) > STATE CHANGED INTERNALLY - from : 3,  to : 2 (CAPI State : 2)
08-13 23:40:58.920+0900 W/TIZEN_N_PLAYER(24947): player.c: __msg_callback(859) > [__msg_callback] End
08-13 23:40:58.920+0900 W/TIZEN_N_PLAYER(24947): player.c: __msg_callback(660) > [__msg_callback] Got message type : 0x104
08-13 23:40:58.920+0900 I/TIZEN_N_PLAYER(24947): player.c: __msg_callback(708) > [__msg_callback] Ready to streaming information (BOS) [current state : 2]
08-13 23:40:58.920+0900 W/TIZEN_N_PLAYER(24947): player.c: __msg_callback(859) > [__msg_callback] End
08-13 23:40:58.920+0900 I/TIZEN_N_PLAYER(24947): player.c: player_start(1632) > [player_start] End
08-13 23:40:58.920+0900 E/record  (24947): buffer size : 4410000
08-13 23:40:58.920+0900 E/record  (24947): perfect_song_routine start
08-13 23:40:58.920+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:40:58.970+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:40:59.020+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:40:59.080+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:40:59.130+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:40:59.180+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:40:59.230+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:40:59.280+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:40:59.330+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:40:59.380+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:40:59.430+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:40:59.480+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:40:59.530+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:40:59.580+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:40:59.630+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:40:59.680+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:40:59.730+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:40:59.780+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:40:59.840+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:40:59.860+0900 I/Tizen::Net::Wifi(  970): (1072) > _WifiService is not registered.
08-13 23:40:59.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 23:40:59.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 23:40:59.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 23:40:59.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 306 5 28 25"
08-13 23:40:59.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 334 5 28 25"
08-13 23:40:59.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 362 5 28 25"
08-13 23:40:59.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 241 390 5 28 25"
08-13 23:40:59.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 418 5 28 25"
08-13 23:40:59.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 23:40:59.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 23:40:59.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 23:40:59.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 626 5 28 25"
08-13 23:40:59.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 654 5 28 25"
08-13 23:40:59.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 682 5 28 25"
08-13 23:40:59.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 241 710 5 28 25"
08-13 23:40:59.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 738 5 28 25"
08-13 23:40:59.890+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:40:59.940+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:40:59.990+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:00.040+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:00.100+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:00.140+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:00.190+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:00.240+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:00.300+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:00.440+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:00.650+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:00.800+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:00.860+0900 I/Tizen::Net::Wifi(  970): (1072) > _WifiService is not registered.
08-13 23:41:00.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 23:41:00.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 23:41:00.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 23:41:00.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 306 5 28 25"
08-13 23:41:00.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 334 5 28 25"
08-13 23:41:00.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 362 5 28 25"
08-13 23:41:00.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 241 390 5 28 25"
08-13 23:41:00.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 418 5 28 25"
08-13 23:41:00.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 23:41:00.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 23:41:00.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 23:41:00.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 626 5 28 25"
08-13 23:41:00.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 654 5 28 25"
08-13 23:41:00.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 682 5 28 25"
08-13 23:41:00.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 241 710 5 28 25"
08-13 23:41:00.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 738 5 28 25"
08-13 23:41:01.010+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:01.200+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:01.370+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:01.570+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:01.730+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:01.930+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:02.120+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:02.320+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:02.480+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:02.680+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:02.860+0900 I/Tizen::Net::Wifi(  970): (1072) > _WifiService is not registered.
08-13 23:41:02.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 23:41:02.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 23:41:02.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 23:41:02.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 306 5 28 25"
08-13 23:41:02.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 334 5 28 25"
08-13 23:41:02.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 362 5 28 25"
08-13 23:41:02.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 241 390 5 28 25"
08-13 23:41:02.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 418 5 28 25"
08-13 23:41:02.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 23:41:02.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 23:41:02.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 23:41:02.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 626 5 28 25"
08-13 23:41:02.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 654 5 28 25"
08-13 23:41:02.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 682 5 28 25"
08-13 23:41:02.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 241 710 5 28 25"
08-13 23:41:02.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 738 5 28 25"
08-13 23:41:02.880+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:03.050+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:03.240+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:03.410+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:03.600+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:03.810+0900 I/record  (24947): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393779868]
08-13 23:41:03.810+0900 E/record  (24947): !! interval
08-13 23:41:04.060+0900 F/record  (24947): ===next node===
08-13 23:41:04.060+0900 I/record  (24947): note : 52 detect :53 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:04.260+0900 I/record  (24947): note : 52 detect :54 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:04.330+0900 I/record  (24947): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393779868]
08-13 23:41:04.350+0900 E/record  (24947): !! interval
08-13 23:41:04.620+0900 F/record  (24947): ===next node===
08-13 23:41:04.620+0900 I/record  (24947): note : 52 detect :50 isHit : 0 [0: 1071644672/-1393779868]
08-13 23:41:04.730+0900 I/record  (24947): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393779868]
08-13 23:41:04.730+0900 E/record  (24947): !! interval
08-13 23:41:04.990+0900 F/record  (24947): ===next node===
08-13 23:41:04.990+0900 I/record  (24947): note : 55 detect :51 isHit : 0 [0: 1071644672/-1393779868]
08-13 23:41:05.180+0900 I/record  (24947): note : 55 detect :80 isHit : -1 [0: 1071644672/-1393779868]
08-13 23:41:05.280+0900 F/record  (24947): ===next node===
08-13 23:41:05.280+0900 I/record  (24947): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393779868]
08-13 23:41:05.280+0900 E/record  (24947): !! interval
08-13 23:41:05.520+0900 F/record  (24947): ===next node===
08-13 23:41:05.520+0900 I/record  (24947): note : 48 detect :51 isHit : 0 [0: 1071644672/-1393779868]
08-13 23:41:05.730+0900 I/record  (24947): note : 48 detect :103 isHit : -1 [0: 1071644672/-1393779868]
08-13 23:41:05.840+0900 F/record  (24947): ===next node===
08-13 23:41:05.840+0900 I/record  (24947): note : 50 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:06.010+0900 I/record  (24947): note : 50 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:06.020+0900 I/CAPI_APPFW_APPLICATION(17310): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:41:06.020+0900 I/CAPI_APPFW_APPLICATION(  700): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:41:06.020+0900 W/CAM_APP (17310): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-13 23:41:06.140+0900 I/CAPI_APPFW_APPLICATION(17310): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:41:06.140+0900 I/CAPI_APPFW_APPLICATION(  700): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:41:06.140+0900 W/CAM_APP (17310): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-13 23:41:06.160+0900 I/CAPI_APPFW_APPLICATION(24947): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:41:06.210+0900 I/record  (24947): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393779868]
08-13 23:41:06.230+0900 E/record  (24947): !! interval
08-13 23:41:06.490+0900 F/record  (24947): ===next node===
08-13 23:41:06.490+0900 I/record  (24947): note : 52 detect :73 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:06.560+0900 I/record  (24947): note : 52 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:06.770+0900 I/record  (24947): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393779868]
08-13 23:41:06.770+0900 E/record  (24947): !! interval
08-13 23:41:07.010+0900 I/record  (24947): note : 52 detect :51 isHit : 0 [0: 1071644672/-1393779868]
08-13 23:41:07.140+0900 F/record  (24947): ===next node===
08-13 23:41:07.140+0900 I/record  (24947): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393779868]
08-13 23:41:07.140+0900 E/record  (24947): !! interval
08-13 23:41:07.410+0900 F/record  (24947): ===next node===
08-13 23:41:07.410+0900 I/record  (24947): note : 48 detect :49 isHit : 0 [0: 1071644672/-1393779868]
08-13 23:41:07.580+0900 I/record  (24947): note : 48 detect :97 isHit : -1 [0: 1071644672/-1393779868]
08-13 23:41:07.770+0900 F/record  (24947): ===next node===
08-13 23:41:07.780+0900 I/record  (24947): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393779868]
08-13 23:41:07.780+0900 E/record  (24947): !! interval
08-13 23:41:07.990+0900 F/record  (24947): ===next node===
08-13 23:41:07.990+0900 I/record  (24947): note : 55 detect :51 isHit : 0 [0: 1071644672/-1393779868]
08-13 23:41:08.050+0900 I/record  (24947): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393779868]
08-13 23:41:08.070+0900 E/record  (24947): !! interval
08-13 23:41:08.240+0900 F/record  (24947): ===next node===
08-13 23:41:08.240+0900 I/record  (24947): note : 60 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:08.440+0900 I/record  (24947): note : 60 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:08.600+0900 I/record  (24947): note : 60 detect :21 isHit : -2 [0: 1071644672/-1393779868]
08-13 23:41:08.610+0900 E/record  (24947): !! interval
08-13 23:41:08.890+0900 I/record  (24947): note : 60 detect :62 isHit : -1 [0: 1071644672/-1393779868]
08-13 23:41:09.100+0900 F/record  (24947): ===next node===
08-13 23:41:09.100+0900 I/record  (24947): note : 55 detect :91 isHit : -1 [0: 1071644672/-1393779868]
08-13 23:41:09.250+0900 F/record  (24947): ===next node===
08-13 23:41:09.250+0900 I/record  (24947): note : 60 detect :57 isHit : 0 [0: 1071644672/-1393779868]
08-13 23:41:09.460+0900 I/record  (24947): note : 60 detect :62 isHit : -1 [0: 1071644672/-1393779868]
08-13 23:41:09.530+0900 I/record  (24947): note : 60 detect :21 isHit : -2 [0: 1071644672/-1393779868]
08-13 23:41:09.540+0900 E/record  (24947): !! interval
08-13 23:41:09.730+0900 F/record  (24947): ===next node===
08-13 23:41:09.730+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:10.020+0900 F/record  (24947): ===next node===
08-13 23:41:10.020+0900 I/record  (24947): note : 60 detect :82 isHit : -1 [0: 1071644672/-1393779868]
08-13 23:41:10.100+0900 F/record  (24947): ===next node===
08-13 23:41:10.100+0900 I/record  (24947): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393779868]
08-13 23:41:10.100+0900 E/record  (24947): !! interval
08-13 23:41:10.380+0900 F/record  (24947): ===next node===
08-13 23:41:10.380+0900 I/record  (24947): note : 52 detect :59 isHit : 0 [0: 1071644672/-1393779868]
08-13 23:41:10.490+0900 I/record  (24947): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393779868]
08-13 23:41:10.510+0900 E/record  (24947): !! interval
08-13 23:41:10.660+0900 F/record  (24947): ===next node===
08-13 23:41:10.660+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:10.850+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:11.020+0900 I/record  (24947): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393779868]
08-13 23:41:11.020+0900 E/record  (24947): !! interval
08-13 23:41:11.330+0900 F/record  (24947): ===next node===
08-13 23:41:11.330+0900 I/record  (24947): note : 50 detect :58 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:11.490+0900 I/record  (24947): note : 50 detect :46 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:11.690+0900 I/record  (24947): note : 50 detect :58 isHit : 0 [0: 1071644672/-1393779868]
08-13 23:41:11.850+0900 F/record  (24947): ===next node===
08-13 23:41:11.850+0900 I/record  (24947): note : 53 detect :57 isHit : 0 [0: 1071644672/-1393779868]
08-13 23:41:11.960+0900 I/record  (24947): note : 53 detect :21 isHit : -2 [0: 1071644672/-1393779868]
08-13 23:41:11.970+0900 E/record  (24947): !! interval
08-13 23:41:12.170+0900 F/record  (24947): ===next node===
08-13 23:41:12.170+0900 I/record  (24947): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393779868]
08-13 23:41:12.170+0900 E/record  (24947): !! interval
08-13 23:41:12.330+0900 I/record  (24947): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393779868]
08-13 23:41:12.330+0900 E/record  (24947): !! interval
08-13 23:41:12.530+0900 F/record  (24947): ===next node===
08-13 23:41:12.530+0900 I/record  (24947): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393779868]
08-13 23:41:12.530+0900 E/record  (24947): !! interval
08-13 23:41:12.730+0900 F/record  (24947): ===next node===
08-13 23:41:12.730+0900 I/record  (24947): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393779868]
08-13 23:41:12.730+0900 E/record  (24947): !! interval
08-13 23:41:12.980+0900 I/record  (24947): note : 48 detect :46 isHit : -2 [0: 1071644672/-1393779868]
08-13 23:41:13.170+0900 I/record  (24947): note : 48 detect :46 isHit : -2 [0: 1071644672/-1393779868]
08-13 23:41:13.330+0900 F/record  (24947): ===next node===
08-13 23:41:13.330+0900 I/record  (24947): note : 55 detect :46 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:13.450+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:13.660+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:13.810+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:14.090+0900 I/record  (24947): note : 55 detect :48 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:14.280+0900 I/record  (24947): note : 55 detect :48 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:14.360+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:14.560+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:14.760+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:14.860+0900 I/Tizen::Net::Wifi(  970): (1072) > _WifiService is not registered.
08-13 23:41:14.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 23:41:14.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 23:41:14.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 23:41:14.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 306 5 28 25"
08-13 23:41:14.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 334 5 28 25"
08-13 23:41:14.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 362 5 28 25"
08-13 23:41:14.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 241 390 5 28 25"
08-13 23:41:14.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 418 5 28 25"
08-13 23:41:14.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 23:41:14.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 23:41:14.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 23:41:14.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 626 5 28 25"
08-13 23:41:14.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 654 5 28 25"
08-13 23:41:14.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 682 5 28 25"
08-13 23:41:14.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 241 710 5 28 25"
08-13 23:41:14.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 738 5 28 25"
08-13 23:41:14.920+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:15.130+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:15.290+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:15.490+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:15.700+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:15.850+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:16.050+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:16.260+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:16.420+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:16.620+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:16.820+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:16.980+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:17.170+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:17.370+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:17.530+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:17.730+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:17.860+0900 I/Tizen::Net::Wifi(  970): (1072) > _WifiService is not registered.
08-13 23:41:17.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 23:41:17.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 23:41:17.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 23:41:17.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 306 5 28 25"
08-13 23:41:17.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 334 5 28 25"
08-13 23:41:17.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 362 5 28 25"
08-13 23:41:17.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 241 390 5 28 25"
08-13 23:41:17.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 418 5 28 25"
08-13 23:41:17.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 23:41:17.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 23:41:17.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 23:41:17.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 626 5 28 25"
08-13 23:41:17.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 654 5 28 25"
08-13 23:41:17.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 682 5 28 25"
08-13 23:41:17.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 241 710 5 28 25"
08-13 23:41:17.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 738 5 28 25"
08-13 23:41:17.890+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:18.090+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:18.290+0900 I/record  (24947): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393779868]
08-13 23:41:18.290+0900 E/record  (24947): !! interval
08-13 23:41:18.560+0900 F/record  (24947): ===next node===
08-13 23:41:18.560+0900 I/record  (24947): note : 52 detect :53 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:18.750+0900 I/record  (24947): note : 52 detect :54 isHit : 0 [0: 1071644672/-1393779868]
08-13 23:41:18.860+0900 I/Tizen::Net::Wifi(  970): (1072) > _WifiService is not registered.
08-13 23:41:18.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 23:41:18.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 23:41:18.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 23:41:18.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 306 5 28 25"
08-13 23:41:18.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 334 5 28 25"
08-13 23:41:18.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 362 5 28 25"
08-13 23:41:18.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 241 390 5 28 25"
08-13 23:41:18.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 418 5 28 25"
08-13 23:41:18.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 23:41:18.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 23:41:18.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 23:41:18.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 626 5 28 25"
08-13 23:41:18.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 654 5 28 25"
08-13 23:41:18.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 682 5 28 25"
08-13 23:41:18.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 241 710 5 28 25"
08-13 23:41:18.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 738 5 28 25"
08-13 23:41:18.970+0900 I/record  (24947): score : 1
08-13 23:41:18.970+0900 I/record  (24947): note : 52 detect :52 isHit : 1 [0: 1071644672/-1393779868]
08-13 23:41:19.020+0900 I/record  (24947): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393779868]
08-13 23:41:19.020+0900 E/record  (24947): !! interval
08-13 23:41:19.300+0900 F/record  (24947): ===next node===
08-13 23:41:19.300+0900 I/record  (24947): score : 2
08-13 23:41:19.300+0900 I/record  (24947): note : 52 detect :52 isHit : 1 [0: 1071644672/-1393779868]
08-13 23:41:19.410+0900 F/record  (24947): ===next node===
08-13 23:41:19.410+0900 I/record  (24947): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393779868]
08-13 23:41:19.420+0900 E/record  (24947): !! interval
08-13 23:41:19.670+0900 F/record  (24947): ===next node===
08-13 23:41:19.670+0900 I/record  (24947): note : 52 detect :56 isHit : 0 [0: 1071644672/-1393779868]
08-13 23:41:19.860+0900 I/record  (24947): note : 52 detect :51 isHit : 0 [0: 1071644672/-1393779868]
08-13 23:41:19.940+0900 F/record  (24947): ===next node===
08-13 23:41:19.940+0900 I/record  (24947): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393779868]
08-13 23:41:19.940+0900 E/record  (24947): !! interval
08-13 23:41:20.210+0900 I/record  (24947): score : 3
08-13 23:41:20.220+0900 I/record  (24947): note : 48 detect :48 isHit : 1 [0: 1071644672/-1393779868]
08-13 23:41:20.320+0900 F/record  (24947): ===next node===
08-13 23:41:20.320+0900 I/record  (24947): note : 50 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:20.530+0900 I/record  (24947): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393779868]
08-13 23:41:20.530+0900 E/record  (24947): !! interval
08-13 23:41:20.770+0900 I/record  (24947): note : 50 detect :51 isHit : 0 [0: 1071644672/-1393779868]
08-13 23:41:20.890+0900 F/record  (24947): ===next node===
08-13 23:41:20.890+0900 I/record  (24947): note : 52 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:21.050+0900 I/record  (24947): note : 52 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:21.250+0900 I/record  (24947): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393779868]
08-13 23:41:21.250+0900 E/record  (24947): !! interval
08-13 23:41:21.450+0900 F/record  (24947): ===next node===
08-13 23:41:21.450+0900 I/record  (24947): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393779868]
08-13 23:41:21.460+0900 E/record  (24947): !! interval
08-13 23:41:21.700+0900 I/record  (24947): score : 4
08-13 23:41:21.700+0900 I/record  (24947): note : 50 detect :50 isHit : 1 [0: 1071644672/-1393779868]
08-13 23:41:21.820+0900 F/record  (24947): ===next node===
08-13 23:41:21.820+0900 I/record  (24947): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393779868]
08-13 23:41:21.820+0900 E/record  (24947): !! interval
08-13 23:41:22.020+0900 I/record  (24947): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393779868]
08-13 23:41:22.020+0900 E/record  (24947): !! interval
08-13 23:41:22.270+0900 F/record  (24947): ===next node===
08-13 23:41:22.270+0900 I/record  (24947): note : 52 detect :51 isHit : 0 [0: 1071644672/-1393779868]
08-13 23:41:22.380+0900 F/record  (24947): ===next node===
08-13 23:41:22.380+0900 I/record  (24947): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393779868]
08-13 23:41:22.380+0900 E/record  (24947): !! interval
08-13 23:41:22.630+0900 F/record  (24947): ===next node===
08-13 23:41:22.630+0900 I/record  (24947): note : 60 detect :55 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:22.740+0900 I/record  (24947): note : 60 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:22.860+0900 I/Tizen::Net::Wifi(  970): (1072) > _WifiService is not registered.
08-13 23:41:22.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 23:41:22.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 23:41:22.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 23:41:22.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 306 5 28 25"
08-13 23:41:22.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 334 5 28 25"
08-13 23:41:22.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 362 5 28 25"
08-13 23:41:22.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 241 390 5 28 25"
08-13 23:41:22.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 418 5 28 25"
08-13 23:41:22.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 23:41:22.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 23:41:22.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 23:41:22.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 626 5 28 25"
08-13 23:41:22.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 654 5 28 25"
08-13 23:41:22.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 682 5 28 25"
08-13 23:41:22.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 241 710 5 28 25"
08-13 23:41:22.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 738 5 28 25"
08-13 23:41:22.940+0900 I/record  (24947): note : 60 detect :21 isHit : -2 [0: 1071644672/-1393779868]
08-13 23:41:22.940+0900 E/record  (24947): !! interval
08-13 23:41:23.190+0900 I/record  (24947): note : 60 detect :59 isHit : 0 [0: 1071644672/-1393779868]
08-13 23:41:23.290+0900 I/record  (24947): note : 60 detect :21 isHit : -2 [0: 1071644672/-1393779868]
08-13 23:41:23.290+0900 E/record  (24947): !! interval
08-13 23:41:23.490+0900 F/record  (24947): ===next node===
08-13 23:41:23.490+0900 I/record  (24947): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393779868]
08-13 23:41:23.490+0900 E/record  (24947): !! interval
08-13 23:41:23.690+0900 F/record  (24947): ===next node===
08-13 23:41:23.690+0900 I/record  (24947): note : 60 detect :21 isHit : -2 [0: 1071644672/-1393779868]
08-13 23:41:23.690+0900 E/record  (24947): !! interval
08-13 23:41:23.850+0900 I/Tizen::Net::Wifi(  970): (1072) > _WifiService is not registered.
08-13 23:41:23.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 23:41:23.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 23:41:23.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 23:41:23.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 306 5 28 25"
08-13 23:41:23.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 334 5 28 25"
08-13 23:41:23.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 362 5 28 25"
08-13 23:41:23.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 241 390 5 28 25"
08-13 23:41:23.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 418 5 28 25"
08-13 23:41:23.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 23:41:23.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 23:41:23.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 23:41:23.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 626 5 28 25"
08-13 23:41:23.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 654 5 28 25"
08-13 23:41:23.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 682 5 28 25"
08-13 23:41:23.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 241 710 5 28 25"
08-13 23:41:23.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 738 5 28 25"
08-13 23:41:23.940+0900 I/record  (24947): score : 5
08-13 23:41:23.940+0900 I/record  (24947): note : 60 detect :60 isHit : 1 [0: 1071644672/-1393779868]
08-13 23:41:24.060+0900 F/record  (24947): ===next node===
08-13 23:41:24.060+0900 I/record  (24947): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393779868]
08-13 23:41:24.060+0900 E/record  (24947): !! interval
08-13 23:41:24.300+0900 F/record  (24947): ===next node===
08-13 23:41:24.300+0900 I/record  (24947): note : 60 detect :55 isHit : 0 [0: 1071644672/-1393779868]
08-13 23:41:24.500+0900 F/record  (24947): ===next node===
08-13 23:41:24.500+0900 I/record  (24947): note : 55 detect :59 isHit : 0 [0: 1071644672/-1393779868]
08-13 23:41:24.610+0900 I/record  (24947): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393779868]
08-13 23:41:24.620+0900 E/record  (24947): !! interval
08-13 23:41:24.770+0900 F/record  (24947): ===next node===
08-13 23:41:24.770+0900 I/record  (24947): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393779868]
08-13 23:41:24.780+0900 E/record  (24947): !! interval
08-13 23:41:24.860+0900 I/Tizen::Net::Wifi(  970): (1072) > _WifiService is not registered.
08-13 23:41:24.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 23:41:24.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 23:41:24.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 23:41:24.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 306 5 28 25"
08-13 23:41:24.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 334 5 28 25"
08-13 23:41:24.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 362 5 28 25"
08-13 23:41:24.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 241 390 5 28 25"
08-13 23:41:24.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 418 5 28 25"
08-13 23:41:24.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 23:41:24.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 23:41:24.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 23:41:24.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 626 5 28 25"
08-13 23:41:24.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 654 5 28 25"
08-13 23:41:24.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 682 5 28 25"
08-13 23:41:24.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 241 710 5 28 25"
08-13 23:41:24.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 738 5 28 25"
08-13 23:41:25.060+0900 F/record  (24947): ===next node===
08-13 23:41:25.060+0900 I/record  (24947): note : 55 detect :52 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:25.140+0900 I/record  (24947): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:25.340+0900 I/record  (24947): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393779868]
08-13 23:41:25.350+0900 E/record  (24947): !! interval
08-13 23:41:25.630+0900 F/record  (24947): ===next node===
08-13 23:41:25.630+0900 I/record  (24947): note : 50 detect :55 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:25.780+0900 I/record  (24947): note : 50 detect :55 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:25.900+0900 I/record  (24947): note : 50 detect :21 isHit : 3 [0: 1071644672/-1393779868]
08-13 23:41:26.100+0900 I/record  (24947): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393779868]
08-13 23:41:26.110+0900 E/record  (24947): !! interval
08-13 23:41:26.340+0900 F/record  (24947): ===next node===
08-13 23:41:26.340+0900 I/record  (24947): note : 53 detect :50 isHit : 0 [0: 1071644672/-1393779868]
08-13 23:41:26.530+0900 F/record  (24947): ===next node===
08-13 23:41:26.530+0900 I/record  (24947): note : 52 detect :53 isHit : 0 [0: 1071644672/-1393779868]
08-13 23:41:26.660+0900 I/record  (24947): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393779868]
08-13 23:41:26.660+0900 E/record  (24947): !! interval
08-13 23:41:26.900+0900 F/record  (24947): ===next node===
08-13 23:41:26.900+0900 I/record  (24947): note : 50 detect :51 isHit : 0 [0: 1071644672/-1393779868]
08-13 23:41:27.110+0900 I/record  (24947): score : 6
08-13 23:41:27.110+0900 I/record  (24947): note : 50 detect :50 isHit : 1 [0: 1071644672/-1393779868]
08-13 23:41:27.180+0900 F/record  (24947): ===next node===
08-13 23:41:27.180+0900 I/record  (24947): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393779868]
08-13 23:41:27.190+0900 E/record  (24947): !! interval
08-13 23:41:27.470+0900 I/record  (24947): note : 48 detect :47 isHit : -2 [0: 1071644672/-1393779868]
08-13 23:41:27.580+0900 I/record  (24947): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393779868]
08-13 23:41:27.590+0900 E/record  (24947): !! interval
08-13 23:41:29.740+0900 I/June    (24947): 산토끼
08-13 23:41:29.930+0900 I/AUL_PAD (  492): sigchild.h: __launchpad_sig_child(142) > dead_pid = 24947 pgid = 24947
08-13 23:41:29.930+0900 I/AUL_PAD (  492): sigchild.h: __sigchild_action(123) > dead_pid(24947)
08-13 23:41:29.930+0900 I/AUL_PAD (  492): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
08-13 23:41:29.930+0900 I/AUL_PAD (  492): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
08-13 23:41:29.940+0900 I/Tizen::App(  902): (243) > App[org.samteam.perfectsong] pid[24947] terminate event is forwarded
08-13 23:41:29.940+0900 I/Tizen::System(  902): (256) > osp.accessorymanager.service provider is found.
08-13 23:41:29.940+0900 I/Tizen::System(  902): (196) > Accessory Owner is removed [org.samteam.perfectsong, 24947, ]
08-13 23:41:29.940+0900 I/Tizen::System(  902): (256) > osp.system.service provider is found.
08-13 23:41:29.940+0900 I/Tizen::App(  902): (506) > TerminatedApp(org.samteam.perfectsong)
08-13 23:41:29.940+0900 I/Tizen::App(  902): (512) > Not registered pid(24947)
08-13 23:41:29.940+0900 I/Tizen::App(  902): (782) > Finished invoking application event listener for org.samteam.perfectsong, 24947.
08-13 23:41:29.940+0900 I/Tizen::System(  940): (246) > Terminated app [org.samteam.perfectsong]
08-13 23:41:29.940+0900 I/Tizen::Io(  940): (729) > Entry not found
08-13 23:41:29.950+0900 I/AUL_AMD (  438): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 24947
08-13 23:41:29.960+0900 W/AUL_AMD (  438): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
08-13 23:41:29.960+0900 W/AUL_AMD (  438): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
08-13 23:41:29.970+0900 I/Tizen::System(  940): (157) > change brightness system value.
08-13 23:41:29.970+0900 I/Tizen::App(  940): (782) > Finished invoking application event listener for org.samteam.perfectsong, 24947.
08-13 23:41:30.030+0900 W/PROCESSMGR(  378): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=588
08-13 23:41:30.040+0900 W/CRASH_MANAGER(25079): worker.c: worker_job(1198) > 1124947706161143947688
