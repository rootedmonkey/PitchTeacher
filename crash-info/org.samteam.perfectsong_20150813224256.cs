S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.0
Build-Number: Z130HDDU0BOB3
Build-Date: 2015.02.14 15:10:17

Crash Information
Process Name: paaaaaaaaa
PID: 7579
Date: 2015-08-13 22:42:56+0900
Executable File Path: /opt/usr/apps/org.samteam.perfectsong/bin/paaaaaaaaa
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 7579, uid 5000)

Register Information
r0   = 0xb653f4d0, r1   = 0xb4bc63cc
r2   = 0xbe9bef00, r3   = 0x00000010
r4   = 0xb4bc63a6, r5   = 0xbe9bef00
r6   = 0x00000000, r7   = 0xbe9bf094
r8   = 0xb6bada58, r9   = 0xb6bad8a0
r10  = 0xb4bc63cc, fp   = 0xbe9beeec
ip   = 0xb6c68140, sp   = 0xbe9be988
lr   = 0xb6c5eee4, pc   = 0xb6c5eee4
cpsr = 0x60000010

Memory Information
MemTotal:   730748 KB
MemFree:    187216 KB
Buffers:     43952 KB
Cached:     209508 KB
VmPeak:     185880 KB
VmSize:     184928 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       27224 KB
VmRSS:       27220 KB
VmData:     116088 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       28392 KB
VmPTE:         106 KB
VmSwap:          0 KB

Threads Information
Threads: 12
PID = 7579 TID = 7579
7579 7589 7590 7593 7624 7625 7626 7629 7630 7631 7632 7634 

Maps Information
ad3e5000 adbe4000 rwxp [stack:7634]
adbe4000 adbfe000 r-xp /usr/lib/gstreamer-0.10/libgstpulse.so
adc07000 adc10000 r-xp /usr/lib/lib_SoundBooster_ver402_wrapped.so
adc1a000 adc97000 r-xp /usr/lib/lib_SoundAlive_ver125e_wrapped.so
adcc9000 adce1000 r-xp /usr/lib/libgstcontroller-0.10.so.0.30.0
adcf0000 adcf6000 r-xp /usr/lib/gstreamer-0.10/libgstsoundalive.so
adcfe000 add06000 r-xp /usr/lib/lib_SoundAlive_SRC192_ver204_wrapped.so
add11000 add16000 r-xp /usr/lib/gstreamer-0.10/libgstvolume.so
add1e000 add21000 r-xp /usr/lib/gstreamer-0.10/libgstsecresample.so
add2a000 add35000 r-xp /usr/lib/gstreamer-0.10/libgstaudioconvert.so
add3f000 ae53e000 rwxp [stack:7632]
ae53f000 aed3e000 rwxp [stack:7631]
aed3e000 aed67000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
aed70000 aed95000 r-xp /usr/lib/libgsttag-0.10.so.0.25.0
aed9e000 aedc4000 r-xp /usr/lib/gstreamer-0.10/libgstogg.so
af28d000 afa8c000 rwxp [stack:7593]
afa90000 afa94000 r-xp /usr/lib/gstreamer-0.10/libgstaudiotp.so
afa9c000 afaa6000 r-xp /usr/lib/libgstriff-0.10.so.0.25.0
afaaf000 afac7000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
afad0000 afae6000 r-xp /usr/lib/gstreamer-0.10/libgstdecodebin2.so
afaef000 afb32000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
afb3e000 afb47000 r-xp /usr/lib/gstreamer-0.10/libgstvorbis.so
afb4f000 afb84000 r-xp /usr/lib/gstreamer-0.10/libgstcoreelements.so
afe8e000 b068d000 rwxp [stack:7590]
b0a8f000 b128e000 rwxp [stack:7589]
b128f000 b1a8e000 rwxp [stack:7624]
b1a8f000 b228e000 rwxp [stack:7625]
b2401000 b2c00000 rwxp [stack:7629]
b2c01000 b3400000 rwxp [stack:7626]
b3500000 b350a000 r-xp /usr/lib/gstreamer-0.10/libgsttypefindfunctions.so
b3598000 b3d97000 rwxp [stack:7630]
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
b72ad000 b7842000 rw-p [heap]
be9ae000 be9cf000 rwxp [stack]
b7283000 b72ad000 rw-p [heap]
b72ad000 b7842000 rw-p [heap]
be9ae000 be9cf000 rwxp [stack]
End of Maps Information

Callstack Information (PID:7579)
Call Stack Count: 3
 0: _IO_vfprintf + 0x20 (0xb6c5eee4) [/lib/libc.so.6] + 0x3cee4
 1: _IO_fprintf + 0x1c (0xb6c6815c) [/lib/libc.so.6] + 0x4615c
 2: statsInput + 0x74 (0xb4bc29d5) [/opt/usr/apps/org.samteam.perfectsong/bin/paaaaaaaaa] + 0x49d5
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
 6E
08-13 22:42:24.850+0900 I/EVT     ( 7579):     6032 90 0A 2A  00
08-13 22:42:24.850+0900 I/EVT     ( 7579):     6048 90 0A 2A  6E
08-13 22:42:24.850+0900 I/EVT     ( 7579):     6128 90 0A 2A  00
08-13 22:42:24.850+0900 I/EVT     ( 7579):     6144 90 0A 2A  6E
08-13 22:42:24.850+0900 I/EVT     ( 7579):     6224 90 0A 2A  00
08-13 22:42:24.850+0900 I/EVT     ( 7579):     6240 90 0A 2A  6E
08-13 22:42:24.850+0900 I/EVT     ( 7579):     6320 90 0A 2A  00
08-13 22:42:24.850+0900 I/EVT     ( 7579):     6336 90 0A 2A  6E
08-13 22:42:24.850+0900 I/EVT     ( 7579):     6416 90 0A 2A  00
08-13 22:42:24.850+0900 I/EVT     ( 7579):     6432 90 0A 2A  6E
08-13 22:42:24.850+0900 I/EVT     ( 7579):     6512 90 0A 2A  00
08-13 22:42:24.850+0900 I/EVT     ( 7579):     6528 90 0A 2A  6E
08-13 22:42:24.850+0900 I/EVT     ( 7579):     6608 90 0A 2A  00
08-13 22:42:24.850+0900 I/EVT     ( 7579):     6624 90 0A 2A  6E
08-13 22:42:24.850+0900 I/EVT     ( 7579):     6704 90 0A 2A  00
08-13 22:42:24.850+0900 I/EVT     ( 7579):     6720 90 0A 2A  6E
08-13 22:42:24.850+0900 I/EVT     ( 7579):     6800 90 0A 2A  00
08-13 22:42:24.850+0900 I/EVT     ( 7579):     6816 90 0A 2A  6E
08-13 22:42:24.850+0900 I/EVT     ( 7579):     6896 90 0A 2A  00
08-13 22:42:24.850+0900 I/EVT     ( 7579):     6912 90 0A 2A  6E
08-13 22:42:24.850+0900 I/EVT     ( 7579):     6992 90 0A 2A  00
08-13 22:42:24.860+0900 I/EVT     ( 7579):     7008 90 0A 2A  6E
08-13 22:42:24.860+0900 I/EVT     ( 7579):     7088 90 0A 2A  00
08-13 22:42:24.860+0900 I/EVT     ( 7579):     7104 90 0A 2A  6E
08-13 22:42:24.860+0900 I/EVT     ( 7579):     7184 90 0A 2A  00
08-13 22:42:24.860+0900 I/EVT     ( 7579):     7200 90 0A 2A  6E
08-13 22:42:24.860+0900 I/EVT     ( 7579):     7280 90 0A 2A  00
08-13 22:42:24.860+0900 I/EVT     ( 7579):     7296 90 0A 2A  6E
08-13 22:42:24.860+0900 I/EVT     ( 7579):     7376 90 0A 2A  00
08-13 22:42:24.860+0900 I/EVT     ( 7579):     7392 90 0A 2A  6E
08-13 22:42:24.860+0900 I/EVT     ( 7579):     7472 90 0A 2A  00
08-13 22:42:24.860+0900 I/EVT     ( 7579):     7488 90 0A 2A  6E
08-13 22:42:24.860+0900 I/EVT     ( 7579):     7568 90 0A 2A  00
08-13 22:42:24.860+0900 I/EVT     ( 7579):     7584 90 0A 2A  6E
08-13 22:42:24.860+0900 I/EVT     ( 7579):     7664 90 0A 2A  00
08-13 22:42:24.860+0900 I/EVT     ( 7579):     7680 90 0A 2A  6E
08-13 22:42:24.860+0900 I/EVT     ( 7579):     7760 90 0A 2A  00
08-13 22:42:24.860+0900 I/EVT     ( 7579):     7776 90 0A 2A  6E
08-13 22:42:24.860+0900 I/EVT     ( 7579):     7856 90 0A 2A  00
08-13 22:42:24.860+0900 I/EVT     ( 7579):     7872 90 0A 2A  6E
08-13 22:42:24.860+0900 I/EVT     ( 7579):     7952 90 0A 2A  00
08-13 22:42:24.860+0900 I/EVT     ( 7579):     7968 90 0A 2A  6E
08-13 22:42:24.860+0900 I/EVT     ( 7579):     8048 90 0A 2A  00
08-13 22:42:24.860+0900 I/EVT     ( 7579):     8064 90 0A 2A  6E
08-13 22:42:24.860+0900 I/EVT     ( 7579):     8144 90 0A 2A  00
08-13 22:42:24.860+0900 I/EVT     ( 7579):     8160 90 0A 2A  6E
08-13 22:42:24.860+0900 I/EVT     ( 7579):     8240 90 0A 2A  00
08-13 22:42:24.860+0900 I/EVT     ( 7579):     8256 90 0A 2A  6E
08-13 22:42:24.860+0900 I/EVT     ( 7579):     8336 90 0A 2A  00
08-13 22:42:24.860+0900 I/EVT     ( 7579):     8352 90 0A 2A  6E
08-13 22:42:24.860+0900 I/EVT     ( 7579):     8432 90 0A 2A  00
08-13 22:42:24.860+0900 I/EVT     ( 7579):     8448 90 0A 2A  6E
08-13 22:42:24.860+0900 I/EVT     ( 7579):     8528 90 0A 2A  00
08-13 22:42:24.860+0900 I/EVT     ( 7579):     8544 90 0A 2A  6E
08-13 22:42:24.860+0900 I/EVT     ( 7579):     8624 90 0A 2A  00
08-13 22:42:24.860+0900 I/EVT     ( 7579):     8640 90 0A 2A  6E
08-13 22:42:24.860+0900 I/EVT     ( 7579):     8720 90 0A 2A  00
08-13 22:42:24.860+0900 I/EVT     ( 7579):     8736 90 0A 2A  6E
08-13 22:42:24.860+0900 I/EVT     ( 7579):     8816 90 0A 2A  00
08-13 22:42:24.860+0900 I/EVT     ( 7579):     8832 90 0A 2A  6E
08-13 22:42:24.860+0900 I/EVT     ( 7579):     8912 90 0A 2A  00
08-13 22:42:24.860+0900 I/EVT     ( 7579):     8928 90 0A 2A  6E
08-13 22:42:24.860+0900 I/EVT     ( 7579):     9008 90 0A 2A  00
08-13 22:42:24.860+0900 I/EVT     ( 7579):     9024 90 0A 2A  6E
08-13 22:42:24.860+0900 I/EVT     ( 7579):     9104 90 0A 2A  00
08-13 22:42:24.860+0900 I/EVT     ( 7579):     9120 90 0A 2A  6E
08-13 22:42:24.860+0900 I/EVT     ( 7579):     9200 90 0A 2A  00
08-13 22:42:24.860+0900 I/TRACK   ( 7579): TRACK END: 7 (9200 ticks)
08-13 22:42:24.860+0900 I/June    ( 7579): asdfasdf 최대 60  최소48  비율27
08-13 22:42:25.030+0900 I/TIZEN_N_PLAYER( 7579): player.c: player_create(1091) > [player_create] new handle : 0xb75e7868
08-13 22:42:25.030+0900 I/TIZEN_N_PLAYER( 7579): player.c: player_prepare(1272) > [player_prepare] Start
08-13 22:42:25.060+0900 W/TIZEN_N_PLAYER( 7579): player.c: __msg_callback(660) > [__msg_callback] Got message type : 0x3
08-13 22:42:25.060+0900 I/TIZEN_N_PLAYER( 7579): player.c: __msg_callback(686) > STATE CHANGED INTERNALLY - from : 0,  to : 1 (CAPI State : 1)
08-13 22:42:25.060+0900 W/TIZEN_N_PLAYER( 7579): player.c: __msg_callback(859) > [__msg_callback] End
08-13 22:42:25.380+0900 W/TIZEN_N_PLAYER( 7579): player.c: __msg_callback(660) > [__msg_callback] Got message type : 0x3
08-13 22:42:25.380+0900 I/TIZEN_N_PLAYER( 7579): player.c: __msg_callback(686) > STATE CHANGED INTERNALLY - from : 1,  to : 3 (CAPI State : 1)
08-13 22:42:25.380+0900 W/TIZEN_N_PLAYER( 7579): player.c: __msg_callback(859) > [__msg_callback] End
08-13 22:42:25.380+0900 I/TIZEN_N_PLAYER( 7579): player.c: player_prepare(1343) > [player_prepare] End
08-13 22:42:25.380+0900 I/TIZEN_N_PLAYER( 7579): player.c: player_start(1582) > [player_start] Start
08-13 22:42:25.400+0900 W/TIZEN_N_PLAYER( 7579): player.c: __msg_callback(660) > [__msg_callback] Got message type : 0x3
08-13 22:42:25.400+0900 I/TIZEN_N_PLAYER( 7579): player.c: __msg_callback(686) > STATE CHANGED INTERNALLY - from : 3,  to : 2 (CAPI State : 2)
08-13 22:42:25.400+0900 W/TIZEN_N_PLAYER( 7579): player.c: __msg_callback(859) > [__msg_callback] End
08-13 22:42:25.400+0900 W/TIZEN_N_PLAYER( 7579): player.c: __msg_callback(660) > [__msg_callback] Got message type : 0x104
08-13 22:42:25.400+0900 I/TIZEN_N_PLAYER( 7579): player.c: __msg_callback(708) > [__msg_callback] Ready to streaming information (BOS) [current state : 2]
08-13 22:42:25.400+0900 W/TIZEN_N_PLAYER( 7579): player.c: __msg_callback(859) > [__msg_callback] End
08-13 22:42:25.400+0900 I/TIZEN_N_PLAYER( 7579): player.c: player_start(1632) > [player_start] End
08-13 22:42:25.400+0900 E/record  ( 7579): buffer size : 4410000
08-13 22:42:25.410+0900 E/record  ( 7579): perfect_song_routine start
08-13 22:42:25.410+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:25.460+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:25.510+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:25.560+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:25.620+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:25.660+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:25.710+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:25.760+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:25.810+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:25.860+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:25.920+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:26.050+0900 I/record  ( 7579): note : 55 detect :90 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:26.100+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:26.150+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:26.280+0900 I/record  ( 7579): note : 55 detect :103 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:26.330+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:26.460+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:26.510+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:26.570+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:26.620+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:26.670+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:26.720+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:26.770+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:26.820+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:26.870+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:26.920+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:26.970+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:27.020+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:27.080+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:27.130+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:27.170+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:27.230+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:27.280+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:27.330+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:27.380+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:27.430+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:27.480+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:27.530+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:27.580+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:27.630+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:27.680+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:27.740+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:27.780+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:27.830+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:27.880+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:27.930+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:27.980+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:28.030+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:28.090+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:28.140+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:28.190+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:28.240+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:28.290+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:28.340+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:28.390+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:28.440+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:28.490+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:28.630+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:28.690+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:28.730+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:28.910+0900 I/record  ( 7579): note : 55 detect :97 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:29.030+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:29.220+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:29.380+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:29.590+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:29.750+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:29.870+0900 I/Tizen::Net::Wifi(  970): (1072) > _WifiService is not registered.
08-13 22:42:29.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 22:42:29.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 22:42:29.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 22:42:29.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 306 5 28 25"
08-13 22:42:29.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 334 5 28 25"
08-13 22:42:29.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 237 362 5 28 25"
08-13 22:42:29.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 390 5 28 25"
08-13 22:42:29.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 418 5 28 25"
08-13 22:42:29.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 22:42:29.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 22:42:29.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 22:42:29.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 626 5 28 25"
08-13 22:42:29.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 654 5 28 25"
08-13 22:42:29.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 682 5 28 25"
08-13 22:42:29.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 237 710 5 28 25"
08-13 22:42:29.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 738 5 28 25"
08-13 22:42:29.940+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:30.080+0900 I/CAPI_APPFW_APPLICATION( 9203): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 22:42:30.090+0900 I/CAPI_APPFW_APPLICATION(  700): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 22:42:30.090+0900 W/CAM_APP ( 9203): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-13 22:42:30.140+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:30.150+0900 I/CAPI_APPFW_APPLICATION( 7579): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 22:42:30.300+0900 I/record  ( 7579): note : 55 detect :21 isHit : -2 [0: 1071644672/-1397044380]
08-13 22:42:30.320+0900 E/record  ( 7579): !! interval
08-13 22:42:30.580+0900 F/record  ( 7579): ===next node===
08-13 22:42:30.580+0900 I/record  ( 7579): note : 52 detect :53 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:30.700+0900 I/record  ( 7579): note : 52 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:30.860+0900 I/Tizen::Net::Wifi(  970): (1072) > _WifiService is not registered.
08-13 22:42:30.870+0900 I/record  ( 7579): note : 52 detect :21 isHit : -2 [0: 1071644672/-1397044380]
08-13 22:42:30.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 22:42:30.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 22:42:30.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 22:42:30.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 306 5 28 25"
08-13 22:42:30.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 334 5 28 25"
08-13 22:42:30.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 237 362 5 28 25"
08-13 22:42:30.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 390 5 28 25"
08-13 22:42:30.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 418 5 28 25"
08-13 22:42:30.880+0900 E/record  ( 7579): !! interval
08-13 22:42:30.880+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 22:42:30.880+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 22:42:30.880+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 22:42:30.880+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 626 5 28 25"
08-13 22:42:30.880+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 654 5 28 25"
08-13 22:42:30.880+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 682 5 28 25"
08-13 22:42:30.890+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 237 710 5 28 25"
08-13 22:42:30.890+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 738 5 28 25"
08-13 22:42:31.150+0900 F/record  ( 7579): ===next node===
08-13 22:42:31.150+0900 I/record  ( 7579): note : 52 detect :103 isHit : -1 [0: 1071644672/-1397044380]
08-13 22:42:31.230+0900 I/record  ( 7579): note : 52 detect :21 isHit : -2 [0: 1071644672/-1397044380]
08-13 22:42:31.240+0900 E/record  ( 7579): !! interval
08-13 22:42:31.430+0900 F/record  ( 7579): ===next node===
08-13 22:42:31.430+0900 I/record  ( 7579): note : 55 detect :21 isHit : -2 [0: 1071644672/-1397044380]
08-13 22:42:31.440+0900 E/record  ( 7579): !! interval
08-13 22:42:31.720+0900 F/record  ( 7579): ===next node===
08-13 22:42:31.720+0900 I/record  ( 7579): note : 52 detect :55 isHit : 0 [0: 1071644672/-1397044380]
08-13 22:42:31.790+0900 I/record  ( 7579): note : 52 detect :21 isHit : -2 [0: 1071644672/-1397044380]
08-13 22:42:31.810+0900 E/record  ( 7579): !! interval
08-13 22:42:32.080+0900 F/record  ( 7579): ===next node===
08-13 22:42:32.080+0900 I/record  ( 7579): note : 48 detect :51 isHit : 0 [0: 1071644672/-1397044380]
08-13 22:42:32.280+0900 I/record  ( 7579): note : 48 detect :103 isHit : -1 [0: 1071644672/-1397044380]
08-13 22:42:32.420+0900 F/record  ( 7579): ===next node===
08-13 22:42:32.420+0900 I/record  ( 7579): note : 50 detect :36 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:32.540+0900 I/record  ( 7579): note : 50 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:32.740+0900 I/record  ( 7579): note : 50 detect :21 isHit : -2 [0: 1071644672/-1397044380]
08-13 22:42:32.740+0900 E/record  ( 7579): !! interval
08-13 22:42:32.980+0900 F/record  ( 7579): ===next node===
08-13 22:42:32.980+0900 I/record  ( 7579): note : 52 detect :49 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:33.180+0900 I/record  ( 7579): note : 52 detect :37 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:33.390+0900 I/record  ( 7579): note : 52 detect :74 isHit : -1 [0: 1071644672/-1397044380]
08-13 22:42:33.550+0900 F/record  ( 7579): ===next node===
08-13 22:42:33.550+0900 I/record  ( 7579): note : 50 detect :97 isHit : -1 [0: 1071644672/-1397044380]
08-13 22:42:33.760+0900 I/record  ( 7579): note : 50 detect :49 isHit : 0 [0: 1071644672/-1397044380]
08-13 22:42:33.950+0900 F/record  ( 7579): ===next node===
08-13 22:42:33.950+0900 I/record  ( 7579): note : 48 detect :49 isHit : 0 [0: 1071644672/-1397044380]
08-13 22:42:34.030+0900 I/record  ( 7579): note : 48 detect :21 isHit : -2 [0: 1071644672/-1397044380]
08-13 22:42:34.030+0900 E/record  ( 7579): !! interval
08-13 22:42:34.310+0900 F/record  ( 7579): ===next node===
08-13 22:42:34.310+0900 I/record  ( 7579): note : 52 detect :35 isHit : -2 [0: 1071644672/-1397044380]
08-13 22:42:34.390+0900 I/record  ( 7579): note : 52 detect :21 isHit : -2 [0: 1071644672/-1397044380]
08-13 22:42:34.400+0900 E/record  ( 7579): !! interval
08-13 22:42:34.670+0900 F/record  ( 7579): ===next node===
08-13 22:42:34.670+0900 I/record  ( 7579): note : 55 detect :75 isHit : -1 [0: 1071644672/-1397044380]
08-13 22:42:34.780+0900 F/record  ( 7579): ===next node===
08-13 22:42:34.780+0900 I/record  ( 7579): note : 60 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:34.950+0900 I/record  ( 7579): note : 60 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:35.220+0900 I/record  ( 7579): note : 60 detect :65 isHit : -1 [0: 1071644672/-1397044380]
08-13 22:42:35.430+0900 I/record  ( 7579): note : 60 detect :63 isHit : -1 [0: 1071644672/-1397044380]
08-13 22:42:35.500+0900 F/record  ( 7579): ===next node===
08-13 22:42:35.500+0900 I/record  ( 7579): note : 55 detect :21 isHit : -2 [0: 1071644672/-1397044380]
08-13 22:42:35.510+0900 E/record  ( 7579): !! interval
08-13 22:42:35.700+0900 F/record  ( 7579): ===next node===
08-13 22:42:35.700+0900 I/record  ( 7579): note : 60 detect :21 isHit : -2 [0: 1071644672/-1397044380]
08-13 22:42:35.710+0900 E/record  ( 7579): !! interval
08-13 22:42:35.990+0900 I/record  ( 7579): note : 60 detect :80 isHit : -1 [0: 1071644672/-1397044380]
08-13 22:42:36.160+0900 F/record  ( 7579): ===next node===
08-13 22:42:36.160+0900 I/record  ( 7579): note : 55 detect :91 isHit : -1 [0: 1071644672/-1397044380]
08-13 22:42:36.270+0900 F/record  ( 7579): ===next node===
08-13 22:42:36.270+0900 I/record  ( 7579): note : 60 detect :21 isHit : -2 [0: 1071644672/-1397044380]
08-13 22:42:36.270+0900 E/record  ( 7579): !! interval
08-13 22:42:36.470+0900 I/record  ( 7579): note : 60 detect :21 isHit : -2 [0: 1071644672/-1397044380]
08-13 22:42:36.470+0900 E/record  ( 7579): !! interval
08-13 22:42:36.710+0900 F/record  ( 7579): ===next node===
08-13 22:42:36.710+0900 I/record  ( 7579): note : 55 detect :106 isHit : -1 [0: 1071644672/-1397044380]
08-13 22:42:36.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 22:42:36.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 22:42:36.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 22:42:36.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 306 5 28 25"
08-13 22:42:36.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 334 5 28 25"
08-13 22:42:36.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 237 362 5 28 25"
08-13 22:42:36.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 390 5 28 25"
08-13 22:42:36.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 418 5 28 25"
08-13 22:42:36.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 22:42:36.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 22:42:36.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 22:42:36.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 626 5 28 25"
08-13 22:42:36.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 654 5 28 25"
08-13 22:42:36.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 682 5 28 25"
08-13 22:42:36.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 237 710 5 28 25"
08-13 22:42:36.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 738 5 28 25"
08-13 22:42:36.860+0900 I/Tizen::Net::Wifi(  970): (1072) > _WifiService is not registered.
08-13 22:42:36.910+0900 F/record  ( 7579): ===next node===
08-13 22:42:36.910+0900 I/record  ( 7579): note : 52 detect :45 isHit : -2 [0: 1071644672/-1397044380]
08-13 22:42:36.990+0900 I/record  ( 7579): note : 52 detect :21 isHit : -2 [0: 1071644672/-1397044380]
08-13 22:42:36.990+0900 E/record  ( 7579): !! interval
08-13 22:42:37.270+0900 F/record  ( 7579): ===next node===
08-13 22:42:37.270+0900 I/record  ( 7579): note : 55 detect :54 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:37.400+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:37.640+0900 I/record  ( 7579): note : 55 detect :82 isHit : -1 [0: 1071644672/-1397044380]
08-13 22:42:37.840+0900 F/record  ( 7579): ===next node===
08-13 22:42:37.840+0900 I/record  ( 7579): note : 50 detect :55 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:37.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 22:42:37.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 22:42:37.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 22:42:37.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 306 5 28 25"
08-13 22:42:37.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 334 5 28 25"
08-13 22:42:37.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 237 362 5 28 25"
08-13 22:42:37.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 390 5 28 25"
08-13 22:42:37.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 418 5 28 25"
08-13 22:42:37.860+0900 I/Tizen::Net::Wifi(  970): (1072) > _WifiService is not registered.
08-13 22:42:37.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 22:42:37.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 22:42:37.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 22:42:37.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 626 5 28 25"
08-13 22:42:37.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 654 5 28 25"
08-13 22:42:37.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 682 5 28 25"
08-13 22:42:37.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 237 710 5 28 25"
08-13 22:42:37.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 738 5 28 25"
08-13 22:42:38.000+0900 I/record  ( 7579): note : 50 detect :44 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:38.190+0900 I/record  ( 7579): note : 50 detect :44 isHit : -2 [0: 1071644672/-1397044380]
08-13 22:42:38.390+0900 F/record  ( 7579): ===next node===
08-13 22:42:38.390+0900 I/record  ( 7579): note : 53 detect :103 isHit : -1 [0: 1071644672/-1397044380]
08-13 22:42:38.590+0900 I/record  ( 7579): note : 53 detect :40 isHit : -2 [0: 1071644672/-1397044380]
08-13 22:42:38.750+0900 F/record  ( 7579): ===next node===
08-13 22:42:38.750+0900 I/record  ( 7579): note : 52 detect :41 isHit : -2 [0: 1071644672/-1397044380]
08-13 22:42:38.950+0900 F/record  ( 7579): ===next node===
08-13 22:42:38.950+0900 I/record  ( 7579): note : 50 detect :77 isHit : -1 [0: 1071644672/-1397044380]
08-13 22:42:39.110+0900 I/record  ( 7579): note : 50 detect :40 isHit : -2 [0: 1071644672/-1397044380]
08-13 22:42:39.310+0900 F/record  ( 7579): ===next node===
08-13 22:42:39.310+0900 I/record  ( 7579): note : 48 detect :50 isHit : 0 [0: 1071644672/-1397044380]
08-13 22:42:39.520+0900 I/record  ( 7579): note : 48 detect :47 isHit : -2 [0: 1071644672/-1397044380]
08-13 22:42:39.670+0900 I/record  ( 7579): score : 1
08-13 22:42:39.670+0900 I/record  ( 7579): note : 48 detect :48 isHit : 1 [0: 1071644672/-1397044380]
08-13 22:42:39.790+0900 I/record  ( 7579): note : 48 detect :21 isHit : -2 [0: 1071644672/-1397044380]
08-13 22:42:39.790+0900 E/record  ( 7579): !! interval
08-13 22:42:39.990+0900 F/record  ( 7579): ===next node===
08-13 22:42:39.990+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:40.150+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:40.350+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:40.550+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:40.720+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:40.910+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:41.110+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:41.260+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:41.470+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:41.670+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:41.830+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:41.860+0900 I/Tizen::Net::Wifi(  970): (1072) > _WifiService is not registered.
08-13 22:42:41.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 22:42:41.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 22:42:41.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 22:42:41.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 306 5 28 25"
08-13 22:42:41.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 334 5 28 25"
08-13 22:42:41.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 237 362 5 28 25"
08-13 22:42:41.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 390 5 28 25"
08-13 22:42:41.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 418 5 28 25"
08-13 22:42:41.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 22:42:41.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 22:42:41.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 22:42:41.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 626 5 28 25"
08-13 22:42:41.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 654 5 28 25"
08-13 22:42:41.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 682 5 28 25"
08-13 22:42:41.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 237 710 5 28 25"
08-13 22:42:41.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 738 5 28 25"
08-13 22:42:42.030+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:42.190+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:42.390+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:42.590+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:42.760+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:42.960+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:43.120+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:43.320+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:43.520+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:43.680+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:43.880+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:44.060+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:44.270+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:44.430+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:44.630+0900 I/record  ( 7579): note : 55 detect :21 isHit : -2 [0: 1071644672/-1397044380]
08-13 22:42:44.630+0900 E/record  ( 7579): !! interval
08-13 22:42:44.870+0900 I/record  ( 7579): note : 55 detect :52 isHit : 0 [0: 1071644672/-1397044380]
08-13 22:42:45.070+0900 F/record  ( 7579): ===next node===
08-13 22:42:45.070+0900 I/record  ( 7579): note : 52 detect :78 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:45.280+0900 I/record  ( 7579): note : 52 detect :36 isHit : -2 [0: 1071644672/-1397044380]
08-13 22:42:45.350+0900 I/record  ( 7579): note : 52 detect :21 isHit : -2 [0: 1071644672/-1397044380]
08-13 22:42:45.350+0900 E/record  ( 7579): !! interval
08-13 22:42:45.550+0900 F/record  ( 7579): ===next node===
08-13 22:42:45.550+0900 I/record  ( 7579): note : 52 detect :21 isHit : -2 [0: 1071644672/-1397044380]
08-13 22:42:45.550+0900 E/record  ( 7579): !! interval
08-13 22:42:45.840+0900 F/record  ( 7579): ===next node===
08-13 22:42:45.840+0900 I/record  ( 7579): note : 55 detect :21 isHit : -2 [0: 1071644672/-1397044380]
08-13 22:42:45.850+0900 E/record  ( 7579): !! interval
08-13 22:42:45.920+0900 I/record  ( 7579): note : 55 detect :21 isHit : -2 [0: 1071644672/-1397044380]
08-13 22:42:45.920+0900 E/record  ( 7579): !! interval
08-13 22:42:46.200+0900 F/record  ( 7579): ===next node===
08-13 22:42:46.200+0900 I/record  ( 7579): note : 52 detect :55 isHit : 0 [0: 1071644672/-1397044380]
08-13 22:42:46.380+0900 I/record  ( 7579): note : 52 detect :103 isHit : -1 [0: 1071644672/-1397044380]
08-13 22:42:46.560+0900 F/record  ( 7579): ===next node===
08-13 22:42:46.560+0900 I/record  ( 7579): note : 48 detect :38 isHit : -2 [0: 1071644672/-1397044380]
08-13 22:42:46.770+0900 F/record  ( 7579): ===next node===
08-13 22:42:46.770+0900 I/record  ( 7579): note : 50 detect :36 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:46.930+0900 I/record  ( 7579): note : 50 detect :78 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:47.040+0900 I/record  ( 7579): note : 50 detect :21 isHit : -2 [0: 1071644672/-1397044380]
08-13 22:42:47.050+0900 E/record  ( 7579): !! interval
08-13 22:42:47.310+0900 F/record  ( 7579): ===next node===
08-13 22:42:47.310+0900 I/record  ( 7579): note : 52 detect :75 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:47.470+0900 I/record  ( 7579): note : 52 detect :50 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:47.670+0900 I/record  ( 7579): note : 52 detect :39 isHit : -2 [0: 1071644672/-1397044380]
08-13 22:42:47.790+0900 I/record  ( 7579): note : 52 detect :21 isHit : -2 [0: 1071644672/-1397044380]
08-13 22:42:47.790+0900 E/record  ( 7579): !! interval
08-13 22:42:47.860+0900 I/Tizen::Net::Wifi(  970): (1072) > _WifiService is not registered.
08-13 22:42:47.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 22:42:47.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 22:42:47.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 22:42:47.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 306 5 28 25"
08-13 22:42:47.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 334 5 28 25"
08-13 22:42:47.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 237 362 5 28 25"
08-13 22:42:47.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 390 5 28 25"
08-13 22:42:47.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 418 5 28 25"
08-13 22:42:47.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 22:42:47.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 22:42:47.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 22:42:47.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 626 5 28 25"
08-13 22:42:47.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 654 5 28 25"
08-13 22:42:47.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 682 5 28 25"
08-13 22:42:47.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 237 710 5 28 25"
08-13 22:42:47.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 738 5 28 25"
08-13 22:42:48.040+0900 F/record  ( 7579): ===next node===
08-13 22:42:48.040+0900 I/record  ( 7579): note : 50 detect :39 isHit : -2 [0: 1071644672/-1397044380]
08-13 22:42:48.240+0900 F/record  ( 7579): ===next node===
08-13 22:42:48.240+0900 I/record  ( 7579): note : 48 detect :39 isHit : -2 [0: 1071644672/-1397044380]
08-13 22:42:48.400+0900 I/record  ( 7579): note : 48 detect :39 isHit : -2 [0: 1071644672/-1397044380]
08-13 22:42:48.600+0900 F/record  ( 7579): ===next node===
08-13 22:42:48.600+0900 I/record  ( 7579): note : 52 detect :77 isHit : -1 [0: 1071644672/-1397044380]
08-13 22:42:48.810+0900 F/record  ( 7579): ===next node===
08-13 22:42:48.810+0900 I/record  ( 7579): note : 55 detect :103 isHit : -1 [0: 1071644672/-1397044380]
08-13 22:42:48.860+0900 I/Tizen::Net::Wifi(  970): (1072) > _WifiService is not registered.
08-13 22:42:48.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 22:42:48.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 22:42:48.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 22:42:48.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 306 5 28 25"
08-13 22:42:48.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 334 5 28 25"
08-13 22:42:48.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 237 362 5 28 25"
08-13 22:42:48.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 390 5 28 25"
08-13 22:42:48.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 418 5 28 25"
08-13 22:42:48.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 22:42:48.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 22:42:48.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 22:42:48.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 626 5 28 25"
08-13 22:42:48.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 654 5 28 25"
08-13 22:42:48.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 682 5 28 25"
08-13 22:42:48.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 237 710 5 28 25"
08-13 22:42:48.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 738 5 28 25"
08-13 22:42:48.980+0900 I/record  ( 7579): note : 55 detect :41 isHit : -2 [0: 1071644672/-1397044380]
08-13 22:42:49.160+0900 F/record  ( 7579): ===next node===
08-13 22:42:49.160+0900 I/record  ( 7579): note : 60 detect :44 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:49.280+0900 I/record  ( 7579): note : 60 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:49.440+0900 I/record  ( 7579): note : 60 detect :21 isHit : -2 [0: 1071644672/-1397044380]
08-13 22:42:49.440+0900 E/record  ( 7579): !! interval
08-13 22:42:49.730+0900 I/record  ( 7579): note : 60 detect :58 isHit : 0 [0: 1071644672/-1397044380]
08-13 22:42:49.840+0900 I/record  ( 7579): note : 60 detect :21 isHit : -2 [0: 1071644672/-1397044380]
08-13 22:42:49.850+0900 E/record  ( 7579): !! interval
08-13 22:42:50.090+0900 F/record  ( 7579): ===next node===
08-13 22:42:50.090+0900 I/record  ( 7579): note : 55 detect :72 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:50.270+0900 F/record  ( 7579): ===next node===
08-13 22:42:50.270+0900 I/record  ( 7579): note : 60 detect :55 isHit : 0 [0: 1071644672/-1397044380]
08-13 22:42:50.470+0900 F/record  ( 7579): ===next node===
08-13 22:42:50.470+0900 I/record  ( 7579): note : 55 detect :49 isHit : 0 [0: 1071644672/-1397044380]
08-13 22:42:50.560+0900 I/record  ( 7579): note : 55 detect :21 isHit : -2 [0: 1071644672/-1397044380]
08-13 22:42:50.560+0900 E/record  ( 7579): !! interval
08-13 22:42:50.840+0900 F/record  ( 7579): ===next node===
08-13 22:42:50.840+0900 I/record  ( 7579): note : 60 detect :103 isHit : -1 [0: 1071644672/-1397044380]
08-13 22:42:51.040+0900 F/record  ( 7579): ===next node===
08-13 22:42:51.040+0900 I/record  ( 7579): note : 55 detect :47 isHit : -2 [0: 1071644672/-1397044380]
08-13 22:42:51.200+0900 I/record  ( 7579): note : 55 detect :76 isHit : -1 [0: 1071644672/-1397044380]
08-13 22:42:51.400+0900 F/record  ( 7579): ===next node===
08-13 22:42:51.400+0900 I/record  ( 7579): note : 52 detect :76 isHit : -1 [0: 1071644672/-1397044380]
08-13 22:42:51.480+0900 I/record  ( 7579): note : 52 detect :21 isHit : -2 [0: 1071644672/-1397044380]
08-13 22:42:51.480+0900 E/record  ( 7579): !! interval
08-13 22:42:51.680+0900 F/record  ( 7579): ===next node===
08-13 22:42:51.680+0900 I/record  ( 7579): note : 55 detect :21 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:51.870+0900 I/record  ( 7579): note : 55 detect :21 isHit : -2 [0: 1071644672/-1397044380]
08-13 22:42:51.880+0900 E/record  ( 7579): !! interval
08-13 22:42:52.120+0900 F/record  ( 7579): ===next node===
08-13 22:42:52.120+0900 I/record  ( 7579): note : 50 detect :54 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:52.320+0900 I/record  ( 7579): note : 50 detect :54 isHit : 3 [0: 1071644672/-1397044380]
08-13 22:42:52.530+0900 I/record  ( 7579): note : 50 detect :54 isHit : 0 [0: 1071644672/-1397044380]
08-13 22:42:52.690+0900 I/record  ( 7579): note : 50 detect :51 isHit : 0 [0: 1071644672/-1397044380]
08-13 22:42:52.890+0900 F/record  ( 7579): ===next node===
08-13 22:42:52.890+0900 I/record  ( 7579): note : 53 detect :51 isHit : 0 [0: 1071644672/-1397044380]
08-13 22:42:53.090+0900 F/record  ( 7579): ===next node===
08-13 22:42:53.090+0900 I/record  ( 7579): note : 52 detect :53 isHit : 0 [0: 1071644672/-1397044380]
08-13 22:42:53.230+0900 I/record  ( 7579): note : 52 detect :51 isHit : 0 [0: 1071644672/-1397044380]
08-13 22:42:53.440+0900 F/record  ( 7579): ===next node===
08-13 22:42:53.440+0900 I/record  ( 7579): note : 50 detect :51 isHit : 0 [0: 1071644672/-1397044380]
08-13 22:42:53.640+0900 F/record  ( 7579): ===next node===
08-13 22:42:53.640+0900 I/record  ( 7579): note : 48 detect :49 isHit : 0 [0: 1071644672/-1397044380]
08-13 22:42:53.800+0900 I/record  ( 7579): score : 2
08-13 22:42:53.800+0900 I/record  ( 7579): note : 48 detect :48 isHit : 1 [0: 1071644672/-1397044380]
08-13 22:42:54.000+0900 I/record  ( 7579): score : 3
08-13 22:42:54.000+0900 I/record  ( 7579): note : 48 detect :48 isHit : 1 [0: 1071644672/-1397044380]
08-13 22:42:54.110+0900 I/record  ( 7579): note : 48 detect :21 isHit : -2 [0: 1071644672/-1397044380]
08-13 22:42:54.120+0900 E/record  ( 7579): !! interval
08-13 22:42:55.970+0900 I/CAPI_APPFW_APPLICATION( 9203): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 22:42:55.970+0900 I/CAPI_APPFW_APPLICATION(  700): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 22:42:55.970+0900 W/CAM_APP ( 9203): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-13 22:42:55.980+0900 I/CAPI_APPFW_APPLICATION( 7579): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 22:42:56.470+0900 W/AUL_AMD (  438): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
08-13 22:42:56.470+0900 W/AUL_AMD (  438): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
08-13 22:42:56.510+0900 I/AUL_PAD (  492): sigchild.h: __launchpad_sig_child(142) > dead_pid = 7579 pgid = 7579
08-13 22:42:56.510+0900 I/AUL_PAD (  492): sigchild.h: __sigchild_action(123) > dead_pid(7579)
08-13 22:42:56.510+0900 I/AUL_PAD (  492): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
08-13 22:42:56.510+0900 I/AUL_PAD (  492): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
08-13 22:42:56.520+0900 I/Tizen::System(  940): (246) > Terminated app [org.samteam.perfectsong]
08-13 22:42:56.520+0900 I/Tizen::Io(  940): (729) > Entry not found
08-13 22:42:56.520+0900 I/Tizen::App(  902): (243) > App[org.samteam.perfectsong] pid[7579] terminate event is forwarded
08-13 22:42:56.520+0900 I/Tizen::System(  902): (256) > osp.accessorymanager.service provider is found.
08-13 22:42:56.520+0900 I/Tizen::System(  902): (196) > Accessory Owner is removed [org.samteam.perfectsong, 7579, ]
08-13 22:42:56.520+0900 I/Tizen::System(  902): (256) > osp.system.service provider is found.
08-13 22:42:56.520+0900 I/Tizen::App(  902): (506) > TerminatedApp(org.samteam.perfectsong)
08-13 22:42:56.520+0900 I/Tizen::App(  902): (512) > Not registered pid(7579)
08-13 22:42:56.520+0900 I/Tizen::App(  902): (782) > Finished invoking application event listener for org.samteam.perfectsong, 7579.
08-13 22:42:56.530+0900 I/AUL_AMD (  438): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 7579
08-13 22:42:56.540+0900 I/Tizen::System(  940): (157) > change brightness system value.
08-13 22:42:56.540+0900 I/Tizen::App(  940): (782) > Finished invoking application event listener for org.samteam.perfectsong, 7579.
08-13 22:42:56.540+0900 W/PROCESSMGR(  378): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=588
08-13 22:42:56.560+0900 I/QUICKPANEL(  666): sound-profile.c: _view_update(106) > [_view_update : 106] sound : 1, vibration : 0
08-13 22:42:56.570+0900 I/QUICKPANEL(  666): quickpanel-ui.c: _ui_handler_input_region_set(172) > [_ui_handler_input_region_set : 172] win_input_0:0
08-13 22:42:56.570+0900 I/QUICKPANEL(  666): win_input_1:758
08-13 22:42:56.570+0900 I/QUICKPANEL(  666): win_input_2:480
08-13 22:42:56.570+0900 I/QUICKPANEL(  666): win_input_3:42
08-13 22:42:56.570+0900 I/QUICKPANEL(  666): 
08-13 22:42:56.580+0900 W/CRASH_MANAGER( 7762): worker.c: worker_job(1198) > 1107579706161143947337
