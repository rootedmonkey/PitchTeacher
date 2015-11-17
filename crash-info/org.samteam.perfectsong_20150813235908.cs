S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.0
Build-Number: Z130HDDU0BOB3
Build-Date: 2015.02.14 15:10:17

Crash Information
Process Name: paaaaaaaaa
PID: 30062
Date: 2015-08-13 23:59:08+0900
Executable File Path: /opt/usr/apps/org.samteam.perfectsong/bin/paaaaaaaaa
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 30062, uid 5000)

Register Information
r0   = 0xb653f4d0, r1   = 0xb4bc54a3
r2   = 0xbe9bedc8, r3   = 0x00000010
r4   = 0xb4bc547b, r5   = 0xbe9bedc8
r6   = 0x00000000, r7   = 0xbe9bef6c
r8   = 0xb6bada58, r9   = 0xb6bad8a0
r10  = 0xb4bc54a3, fp   = 0xbe9bedb4
ip   = 0xb6c68140, sp   = 0xbe9be850
lr   = 0xb6c5eee4, pc   = 0xb6c5eee4
cpsr = 0x60000010

Memory Information
MemTotal:   730748 KB
MemFree:    175324 KB
Buffers:     47044 KB
Cached:     213596 KB
VmPeak:     185644 KB
VmSize:     184620 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       26408 KB
VmRSS:       26404 KB
VmData:     115780 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       28392 KB
VmPTE:         108 KB
VmSwap:          0 KB

Threads Information
Threads: 12
PID = 30062 TID = 30062
30062 30068 30069 30073 30085 30086 30087 30090 30091 30092 30093 30096 

Maps Information
ad787000 adf86000 rwxp [stack:30096]
adf86000 adfa0000 r-xp /usr/lib/gstreamer-0.10/libgstpulse.so
adfa9000 adfb2000 r-xp /usr/lib/lib_SoundBooster_ver402_wrapped.so
adfbc000 ae039000 r-xp /usr/lib/lib_SoundAlive_ver125e_wrapped.so
ae06b000 ae083000 r-xp /usr/lib/libgstcontroller-0.10.so.0.30.0
ae092000 ae098000 r-xp /usr/lib/gstreamer-0.10/libgstsoundalive.so
ae0a0000 ae0a8000 r-xp /usr/lib/lib_SoundAlive_SRC192_ver204_wrapped.so
ae0b3000 ae0b8000 r-xp /usr/lib/gstreamer-0.10/libgstvolume.so
ae0c0000 ae0c3000 r-xp /usr/lib/gstreamer-0.10/libgstsecresample.so
ae0cc000 ae0d7000 r-xp /usr/lib/gstreamer-0.10/libgstaudioconvert.so
ae0e1000 ae8e0000 rwxp [stack:30093]
ae8e1000 af0e0000 rwxp [stack:30092]
af0e0000 af109000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
af112000 af137000 r-xp /usr/lib/libgsttag-0.10.so.0.25.0
af140000 af14a000 r-xp /usr/lib/libgstriff-0.10.so.0.25.0
af15c000 af160000 r-xp /usr/lib/gstreamer-0.10/libgstaudiotp.so
af28d000 afa8c000 rwxp [stack:30073]
afa92000 afab8000 r-xp /usr/lib/gstreamer-0.10/libgstogg.so
afac1000 afad9000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
afae2000 afaf8000 r-xp /usr/lib/gstreamer-0.10/libgstdecodebin2.so
afb01000 afb44000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
afb4e000 afb58000 r-xp /usr/lib/gstreamer-0.10/libgsttypefindfunctions.so
afb61000 afb96000 r-xp /usr/lib/gstreamer-0.10/libgstcoreelements.so
afe8e000 b068d000 rwxp [stack:30069]
b0a8f000 b128e000 rwxp [stack:30068]
b128f000 b1a8e000 rwxp [stack:30085]
b1a8f000 b228e000 rwxp [stack:30086]
b2401000 b2c00000 rwxp [stack:30090]
b2c01000 b3400000 rwxp [stack:30087]
b3501000 b350a000 r-xp /usr/lib/gstreamer-0.10/libgstvorbis.so
b3597000 b3d96000 rwxp [stack:30091]
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
b72ad000 b7893000 rw-p [heap]
be9ae000 be9cf000 rwxp [stack]
b6f8f000 b6f94000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
b7283000 b72ad000 rw-p [heap]
b72ad000 b7893000 rw-p [heap]
be9ae000 be9cf000 rwxp [stack]
End of Maps Information

Callstack Information (PID:30062)
Call Stack Count: 3
 0: _IO_vfprintf + 0x20 (0xb6c5eee4) [/lib/libc.so.6] + 0x3cee4
 1: _IO_fprintf + 0x1c (0xb6c6815c) [/lib/libc.so.6] + 0x4615c
 2: statsInput + 0x1f6 (0xb4bc1b5f) [/opt/usr/apps/org.samteam.perfectsong/bin/paaaaaaaaa] + 0x4b5f
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
16 90 0A 26  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     4416 90 0A 31  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     4576 90 0A 26  00
08-13 23:58:37.250+0900 I/EVT     (30062):     4576 90 0A 31  00
08-13 23:58:37.250+0900 I/EVT     (30062):     4608 90 0A 23  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     4608 90 0A 31  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     4768 90 0A 23  00
08-13 23:58:37.250+0900 I/EVT     (30062):     4768 90 0A 31  00
08-13 23:58:37.250+0900 I/EVT     (30062):     4800 90 0A 26  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     4960 90 0A 26  00
08-13 23:58:37.250+0900 I/EVT     (30062):     4992 90 0A 23  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     5072 90 0A 23  00
08-13 23:58:37.250+0900 I/EVT     (30062):     5088 90 0A 23  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     5168 90 0A 23  00
08-13 23:58:37.250+0900 I/EVT     (30062):     5184 90 0A 26  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     5344 90 0A 26  00
08-13 23:58:37.250+0900 I/EVT     (30062):     5376 90 0A 23  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     5536 90 0A 23  00
08-13 23:58:37.250+0900 I/EVT     (30062):     5568 90 0A 26  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     5728 90 0A 26  00
08-13 23:58:37.250+0900 I/EVT     (30062):     5760 90 0A 23  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     5840 90 0A 23  00
08-13 23:58:37.250+0900 I/EVT     (30062):     5856 90 0A 26  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     5896 90 0A 26  00
08-13 23:58:37.250+0900 I/EVT     (30062):     5904 90 0A 23  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     5904 90 0A 26  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     5944 90 0A 23  00
08-13 23:58:37.250+0900 I/EVT     (30062):     5944 90 0A 26  00
08-13 23:58:37.250+0900 I/EVT     (30062):     5952 90 0A 26  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     5952 90 0A 31  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     6112 90 0A 26  00
08-13 23:58:37.250+0900 I/EVT     (30062):     6112 90 0A 31  00
08-13 23:58:37.250+0900 I/EVT     (30062):     6144 90 0A 23  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     6304 90 0A 23  00
08-13 23:58:37.250+0900 I/EVT     (30062):     6336 90 0A 26  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     6496 90 0A 26  00
08-13 23:58:37.250+0900 I/EVT     (30062):     6528 90 0A 23  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     6608 90 0A 23  00
08-13 23:58:37.250+0900 I/EVT     (30062):     6624 90 0A 23  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     6704 90 0A 23  00
08-13 23:58:37.250+0900 I/EVT     (30062):     6720 90 0A 26  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     6880 90 0A 26  00
08-13 23:58:37.250+0900 I/EVT     (30062):     6912 90 0A 23  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     7072 90 0A 23  00
08-13 23:58:37.250+0900 I/EVT     (30062):     7104 90 0A 26  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     7264 90 0A 26  00
08-13 23:58:37.250+0900 I/EVT     (30062):     7296 90 0A 23  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     7376 90 0A 23  00
08-13 23:58:37.250+0900 I/EVT     (30062):     7392 90 0A 23  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     7472 90 0A 23  00
08-13 23:58:37.250+0900 I/EVT     (30062):     7488 90 0A 26  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     7648 90 0A 26  00
08-13 23:58:37.250+0900 I/EVT     (30062):     7680 90 0A 23  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     7840 90 0A 23  00
08-13 23:58:37.250+0900 I/EVT     (30062):     7872 90 0A 26  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     8032 90 0A 26  00
08-13 23:58:37.250+0900 I/EVT     (30062):     8064 90 0A 23  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     8144 90 0A 23  00
08-13 23:58:37.250+0900 I/EVT     (30062):     8160 90 0A 23  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     8240 90 0A 23  00
08-13 23:58:37.250+0900 I/EVT     (30062):     8256 90 0A 26  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     8416 90 0A 26  00
08-13 23:58:37.250+0900 I/EVT     (30062):     8448 90 0A 23  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     8608 90 0A 23  00
08-13 23:58:37.250+0900 I/EVT     (30062):     8640 90 0A 26  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     8800 90 0A 26  00
08-13 23:58:37.250+0900 I/EVT     (30062):     8832 90 0A 23  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     8912 90 0A 23  00
08-13 23:58:37.250+0900 I/EVT     (30062):     8928 90 0A 26  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     8968 90 0A 26  00
08-13 23:58:37.250+0900 I/EVT     (30062):     8976 90 0A 23  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     8976 90 0A 26  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     9016 90 0A 23  00
08-13 23:58:37.250+0900 I/EVT     (30062):     9016 90 0A 26  00
08-13 23:58:37.250+0900 I/EVT     (30062):     9024 90 0A 26  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     9024 90 0A 31  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     9184 90 0A 26  00
08-13 23:58:37.250+0900 I/EVT     (30062):     9184 90 0A 31  00
08-13 23:58:37.250+0900 I/TRACK   (30062): TRACK END: 6 (9184 ticks)
08-13 23:58:37.250+0900 I/TRACK   (30062): TRACK START: 7 (796 bytes)
08-13 23:58:37.250+0900 I/EVT     (30062):        0 B0 0A 07  7F
08-13 23:58:37.250+0900 I/EVT     (30062):        0 B0 0A 0A  40
08-13 23:58:37.250+0900 I/EVT     (30062):        0 90 0A 2A  6E
08-13 23:58:37.250+0900 I/EVT     (30062):       80 90 0A 2A  00
08-13 23:58:37.250+0900 I/EVT     (30062):       96 90 0A 2A  6E
08-13 23:58:37.250+0900 I/EVT     (30062):      176 90 0A 2A  00
08-13 23:58:37.250+0900 I/EVT     (30062):      192 90 0A 2A  6E
08-13 23:58:37.250+0900 I/EVT     (30062):      272 90 0A 2A  00
08-13 23:58:37.250+0900 I/EVT     (30062):      288 90 0A 2A  6E
08-13 23:58:37.250+0900 I/EVT     (30062):      368 90 0A 2A  00
08-13 23:58:37.250+0900 I/EVT     (30062):      384 90 0A 2A  6E
08-13 23:58:37.250+0900 I/EVT     (30062):      464 90 0A 2A  00
08-13 23:58:37.250+0900 I/EVT     (30062):      480 90 0A 2A  6E
08-13 23:58:37.250+0900 I/EVT     (30062):      560 90 0A 2A  00
08-13 23:58:37.250+0900 I/EVT     (30062):      576 90 0A 2A  6E
08-13 23:58:37.250+0900 I/EVT     (30062):      656 90 0A 2A  00
08-13 23:58:37.250+0900 I/EVT     (30062):      672 90 0A 2A  6E
08-13 23:58:37.250+0900 I/EVT     (30062):      752 90 0A 2A  00
08-13 23:58:37.250+0900 I/EVT     (30062):      768 90 0A 2A  6E
08-13 23:58:37.250+0900 I/EVT     (30062):      848 90 0A 2A  00
08-13 23:58:37.250+0900 I/EVT     (30062):      864 90 0A 2A  6E
08-13 23:58:37.250+0900 I/EVT     (30062):      944 90 0A 2A  00
08-13 23:58:37.250+0900 I/EVT     (30062):      960 90 0A 2A  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     1040 90 0A 2A  00
08-13 23:58:37.250+0900 I/EVT     (30062):     1056 90 0A 2A  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     1136 90 0A 2A  00
08-13 23:58:37.250+0900 I/EVT     (30062):     1152 90 0A 2A  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     1232 90 0A 2A  00
08-13 23:58:37.250+0900 I/EVT     (30062):     1248 90 0A 2A  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     1328 90 0A 2A  00
08-13 23:58:37.250+0900 I/EVT     (30062):     1344 90 0A 2A  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     1424 90 0A 2A  00
08-13 23:58:37.250+0900 I/EVT     (30062):     1440 90 0A 2A  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     1520 90 0A 2A  00
08-13 23:58:37.250+0900 I/EVT     (30062):     1536 90 0A 2A  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     1616 90 0A 2A  00
08-13 23:58:37.250+0900 I/EVT     (30062):     1632 90 0A 2A  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     1712 90 0A 2A  00
08-13 23:58:37.250+0900 I/EVT     (30062):     1728 90 0A 2A  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     1808 90 0A 2A  00
08-13 23:58:37.250+0900 I/EVT     (30062):     1824 90 0A 2A  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     1904 90 0A 2A  00
08-13 23:58:37.250+0900 I/EVT     (30062):     1920 90 0A 2A  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     2000 90 0A 2A  00
08-13 23:58:37.250+0900 I/EVT     (30062):     2016 90 0A 2A  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     2096 90 0A 2A  00
08-13 23:58:37.250+0900 I/EVT     (30062):     2112 90 0A 2A  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     2192 90 0A 2A  00
08-13 23:58:37.250+0900 I/EVT     (30062):     2208 90 0A 2A  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     2288 90 0A 2A  00
08-13 23:58:37.250+0900 I/EVT     (30062):     2304 90 0A 2A  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     2384 90 0A 2A  00
08-13 23:58:37.250+0900 I/EVT     (30062):     2400 90 0A 2A  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     2480 90 0A 2A  00
08-13 23:58:37.250+0900 I/EVT     (30062):     2496 90 0A 2A  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     2576 90 0A 2A  00
08-13 23:58:37.250+0900 I/EVT     (30062):     2592 90 0A 2A  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     2672 90 0A 2A  00
08-13 23:58:37.250+0900 I/EVT     (30062):     2688 90 0A 2A  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     2768 90 0A 2A  00
08-13 23:58:37.250+0900 I/EVT     (30062):     2784 90 0A 2A  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     2864 90 0A 2A  00
08-13 23:58:37.250+0900 I/EVT     (30062):     2880 90 0A 2A  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     2960 90 0A 2A  00
08-13 23:58:37.250+0900 I/EVT     (30062):     2976 90 0A 2A  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     3056 90 0A 2A  00
08-13 23:58:37.250+0900 I/EVT     (30062):     3072 90 0A 2A  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     3152 90 0A 2A  00
08-13 23:58:37.250+0900 I/EVT     (30062):     3168 90 0A 2A  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     3248 90 0A 2A  00
08-13 23:58:37.250+0900 I/EVT     (30062):     3264 90 0A 2A  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     3344 90 0A 2A  00
08-13 23:58:37.250+0900 I/EVT     (30062):     3360 90 0A 2A  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     3440 90 0A 2A  00
08-13 23:58:37.250+0900 I/EVT     (30062):     3456 90 0A 2A  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     3536 90 0A 2A  00
08-13 23:58:37.250+0900 I/EVT     (30062):     3552 90 0A 2A  6E
08-13 23:58:37.250+0900 I/EVT     (30062):     3632 90 0A 2A  00
08-13 23:58:37.250+0900 I/EVT     (30062):     3648 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     3728 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     3744 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     3824 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     3840 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     3920 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     3936 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     4016 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     4032 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     4112 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     4128 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     4208 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     4224 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     4304 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     4320 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     4400 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     4416 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     4496 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     4512 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     4592 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     4608 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     4688 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     4704 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     4784 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     4800 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     4880 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     4896 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     4976 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     4992 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     5072 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     5088 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     5168 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     5184 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     5264 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     5280 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     5360 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     5376 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     5456 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     5472 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     5552 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     5568 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     5648 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     5664 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     5744 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     5760 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     5840 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     5856 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     5936 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     5952 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     6032 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     6048 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     6128 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     6144 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     6224 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     6240 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     6320 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     6336 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     6416 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     6432 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     6512 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     6528 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     6608 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     6624 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     6704 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     6720 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     6800 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     6816 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     6896 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     6912 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     6992 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     7008 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     7088 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     7104 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     7184 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     7200 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     7280 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     7296 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     7376 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     7392 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     7472 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     7488 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     7568 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     7584 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     7664 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     7680 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     7760 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     7776 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     7856 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     7872 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     7952 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     7968 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     8048 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     8064 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     8144 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     8160 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     8240 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     8256 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     8336 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     8352 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     8432 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     8448 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     8528 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     8544 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     8624 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     8640 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     8720 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     8736 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     8816 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     8832 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     8912 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     8928 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     9008 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     9024 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     9104 90 0A 2A  00
08-13 23:58:37.260+0900 I/EVT     (30062):     9120 90 0A 2A  6E
08-13 23:58:37.260+0900 I/EVT     (30062):     9200 90 0A 2A  00
08-13 23:58:37.260+0900 I/TRACK   (30062): TRACK END: 7 (9200 ticks)
08-13 23:58:37.260+0900 I/June    (30062): asdfasdf 최대 60  최소48  비율27
08-13 23:58:37.320+0900 I/CAPI_APPFW_APPLICATION( 8596): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:58:37.360+0900 I/CAPI_APPFW_APPLICATION(17310): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:58:37.360+0900 I/CAPI_APPFW_APPLICATION(  700): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:58:37.360+0900 W/CAM_APP (17310): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-13 23:58:37.380+0900 I/TIZEN_N_PLAYER(30062): player.c: player_create(1091) > [player_create] new handle : 0xb75dc768
08-13 23:58:37.380+0900 I/TIZEN_N_PLAYER(30062): player.c: player_prepare(1272) > [player_prepare] Start
08-13 23:58:37.410+0900 W/TIZEN_N_PLAYER(30062): player.c: __msg_callback(660) > [__msg_callback] Got message type : 0x3
08-13 23:58:37.410+0900 I/TIZEN_N_PLAYER(30062): player.c: __msg_callback(686) > STATE CHANGED INTERNALLY - from : 0,  to : 1 (CAPI State : 1)
08-13 23:58:37.410+0900 W/TIZEN_N_PLAYER(30062): player.c: __msg_callback(859) > [__msg_callback] End
08-13 23:58:37.420+0900 I/CAPI_APPFW_APPLICATION(17310): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:58:37.420+0900 I/CAPI_APPFW_APPLICATION(  700): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:58:37.420+0900 W/CAM_APP (17310): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-13 23:58:37.450+0900 I/CAPI_APPFW_APPLICATION( 8596): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:58:37.480+0900 I/CAPI_APPFW_APPLICATION(17310): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:58:37.480+0900 I/CAPI_APPFW_APPLICATION(  700): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:58:37.480+0900 W/CAM_APP (17310): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-13 23:58:37.590+0900 I/CAPI_APPFW_APPLICATION( 8596): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:58:37.710+0900 W/TIZEN_N_PLAYER(30062): player.c: __msg_callback(660) > [__msg_callback] Got message type : 0x3
08-13 23:58:37.710+0900 I/TIZEN_N_PLAYER(30062): player.c: __msg_callback(686) > STATE CHANGED INTERNALLY - from : 1,  to : 3 (CAPI State : 1)
08-13 23:58:37.710+0900 W/TIZEN_N_PLAYER(30062): player.c: __msg_callback(859) > [__msg_callback] End
08-13 23:58:37.710+0900 I/TIZEN_N_PLAYER(30062): player.c: player_prepare(1343) > [player_prepare] End
08-13 23:58:37.710+0900 I/TIZEN_N_PLAYER(30062): player.c: player_start(1582) > [player_start] Start
08-13 23:58:37.710+0900 W/TIZEN_N_PLAYER(30062): player.c: __msg_callback(660) > [__msg_callback] Got message type : 0x3
08-13 23:58:37.710+0900 I/TIZEN_N_PLAYER(30062): player.c: __msg_callback(686) > STATE CHANGED INTERNALLY - from : 3,  to : 2 (CAPI State : 2)
08-13 23:58:37.710+0900 W/TIZEN_N_PLAYER(30062): player.c: __msg_callback(859) > [__msg_callback] End
08-13 23:58:37.710+0900 W/TIZEN_N_PLAYER(30062): player.c: __msg_callback(660) > [__msg_callback] Got message type : 0x104
08-13 23:58:37.710+0900 I/TIZEN_N_PLAYER(30062): player.c: __msg_callback(708) > [__msg_callback] Ready to streaming information (BOS) [current state : 2]
08-13 23:58:37.710+0900 W/TIZEN_N_PLAYER(30062): player.c: __msg_callback(859) > [__msg_callback] End
08-13 23:58:37.710+0900 I/TIZEN_N_PLAYER(30062): player.c: player_start(1632) > [player_start] End
08-13 23:58:37.710+0900 E/record  (30062): buffer size : 4410000
08-13 23:58:37.730+0900 I/CAPI_APPFW_APPLICATION( 8596): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:58:37.730+0900 E/record  (30062): perfect_song_routine start
08-13 23:58:37.730+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:37.780+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:37.810+0900 I/CAPI_APPFW_APPLICATION(30062): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:58:37.830+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:37.850+0900 I/CAPI_APPFW_APPLICATION(30062): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:58:37.880+0900 I/CAPI_APPFW_APPLICATION(30062): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:58:37.880+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:37.930+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:37.980+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:38.030+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:38.080+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:38.140+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:38.180+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:38.230+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:38.280+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:38.340+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:38.390+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:38.440+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:38.490+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:38.540+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:38.590+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:38.640+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:38.690+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:38.740+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:38.790+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:38.840+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:38.890+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:38.920+0900 I/CAPI_APPFW_APPLICATION(17310): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:58:38.920+0900 I/CAPI_APPFW_APPLICATION(30062): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:58:38.920+0900 I/CAPI_APPFW_APPLICATION(  700): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:58:38.920+0900 W/CAM_APP (17310): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-13 23:58:38.990+0900 I/CAPI_APPFW_APPLICATION( 8596): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:58:39.090+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:39.250+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:39.450+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:39.650+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:39.810+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:40.000+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:40.200+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:40.400+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:40.560+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:40.760+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:40.920+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:41.130+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:41.330+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:41.490+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:41.690+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:41.890+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:42.050+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:42.330+0900 I/record  (30062): note : 55 detect :47 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:42.500+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:42.700+0900 I/record  (30062): note : 55 detect :45 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:58:42.910+0900 F/record  (30062): ===next node===
08-13 23:58:42.910+0900 I/record  (30062): note : 52 detect :42 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:43.070+0900 I/record  (30062): note : 52 detect :44 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:43.240+0900 I/record  (30062): note : 52 detect :43 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:58:43.440+0900 F/record  (30062): ===next node===
08-13 23:58:43.440+0900 I/record  (30062): note : 52 detect :43 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:58:43.520+0900 I/record  (30062): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:58:43.530+0900 E/record  (30062): !! interval
08-13 23:58:43.810+0900 F/record  (30062): ===next node===
08-13 23:58:43.810+0900 I/record  (30062): note : 55 detect :43 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:58:44.020+0900 I/record  (30062): note : 55 detect :43 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:58:44.180+0900 F/record  (30062): ===next node===
08-13 23:58:44.180+0900 I/record  (30062): note : 52 detect :79 isHit : -1 [0: 1071644672/-1393235100]
08-13 23:58:44.370+0900 F/record  (30062): ===next node===
08-13 23:58:44.370+0900 I/record  (30062): note : 48 detect :44 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:58:44.500+0900 I/record  (30062): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:58:44.500+0900 E/record  (30062): !! interval
08-13 23:58:44.650+0900 F/record  (30062): ===next node===
08-13 23:58:44.650+0900 I/record  (30062): note : 50 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:44.850+0900 I/record  (30062): note : 50 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:45.020+0900 I/record  (30062): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:58:45.020+0900 E/record  (30062): !! interval
08-13 23:58:45.300+0900 F/record  (30062): ===next node===
08-13 23:58:45.300+0900 I/record  (30062): note : 52 detect :46 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:45.490+0900 I/record  (30062): note : 52 detect :47 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:45.660+0900 I/record  (30062): note : 52 detect :49 isHit : 0 [0: 1071644672/-1393235100]
08-13 23:58:45.860+0900 F/record  (30062): ===next node===
08-13 23:58:45.860+0900 I/record  (30062): note : 50 detect :49 isHit : 0 [0: 1071644672/-1393235100]
08-13 23:58:46.060+0900 I/record  (30062): note : 50 detect :53 isHit : 0 [0: 1071644672/-1393235100]
08-13 23:58:46.240+0900 F/record  (30062): ===next node===
08-13 23:58:46.240+0900 I/record  (30062): note : 48 detect :52 isHit : 0 [0: 1071644672/-1393235100]
08-13 23:58:46.410+0900 I/record  (30062): note : 48 detect :50 isHit : 0 [0: 1071644672/-1393235100]
08-13 23:58:46.610+0900 F/record  (30062): ===next node===
08-13 23:58:46.610+0900 I/record  (30062): note : 52 detect :48 isHit : 0 [0: 1071644672/-1393235100]
08-13 23:58:46.770+0900 F/record  (30062): ===next node===
08-13 23:58:46.770+0900 I/record  (30062): note : 55 detect :48 isHit : 0 [0: 1071644672/-1393235100]
08-13 23:58:46.960+0900 I/record  (30062): note : 55 detect :51 isHit : 0 [0: 1071644672/-1393235100]
08-13 23:58:47.170+0900 F/record  (30062): ===next node===
08-13 23:58:47.170+0900 I/record  (30062): note : 60 detect :54 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:47.330+0900 I/record  (30062): note : 60 detect :55 isHit : 0 [0: 1071644672/-1393235100]
08-13 23:58:47.540+0900 I/record  (30062): note : 60 detect :56 isHit : 0 [0: 1071644672/-1393235100]
08-13 23:58:47.700+0900 I/record  (30062): score : 1
08-13 23:58:47.700+0900 I/record  (30062): note : 60 detect :60 isHit : 1 [0: 1071644672/-1393235100]
08-13 23:58:47.900+0900 F/record  (30062): ===next node===
08-13 23:58:47.900+0900 I/record  (30062): note : 55 detect :48 isHit : 0 [0: 1071644672/-1393235100]
08-13 23:58:48.100+0900 F/record  (30062): ===next node===
08-13 23:58:48.100+0900 I/record  (30062): score : 2
08-13 23:58:48.100+0900 I/record  (30062): note : 60 detect :60 isHit : 1 [0: 1071644672/-1393235100]
08-13 23:58:48.260+0900 I/record  (30062): note : 60 detect :56 isHit : 0 [0: 1071644672/-1393235100]
08-13 23:58:48.450+0900 F/record  (30062): ===next node===
08-13 23:58:48.450+0900 I/record  (30062): note : 55 detect :47 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:58:48.670+0900 F/record  (30062): ===next node===
08-13 23:58:48.670+0900 I/record  (30062): note : 60 detect :48 isHit : 0 [0: 1071644672/-1393235100]
08-13 23:58:48.830+0900 F/record  (30062): ===next node===
08-13 23:58:48.830+0900 I/record  (30062): note : 55 detect :54 isHit : 0 [0: 1071644672/-1393235100]
08-13 23:58:49.030+0900 I/record  (30062): note : 55 detect :60 isHit : 0 [0: 1071644672/-1393235100]
08-13 23:58:49.220+0900 F/record  (30062): ===next node===
08-13 23:58:49.220+0900 I/record  (30062): note : 52 detect :79 isHit : -1 [0: 1071644672/-1393235100]
08-13 23:58:49.370+0900 I/record  (30062): note : 52 detect :56 isHit : 0 [0: 1071644672/-1393235100]
08-13 23:58:49.560+0900 F/record  (30062): ===next node===
08-13 23:58:49.560+0900 I/record  (30062): note : 55 detect :50 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:49.780+0900 I/record  (30062): note : 55 detect :39 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:58:49.850+0900 I/record  (30062): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:58:49.860+0900 E/record  (30062): !! interval
08-13 23:58:50.140+0900 F/record  (30062): ===next node===
08-13 23:58:50.140+0900 I/record  (30062): note : 50 detect :54 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:50.300+0900 I/record  (30062): note : 50 detect :55 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:50.490+0900 I/record  (30062): note : 50 detect :56 isHit : 0 [0: 1071644672/-1393235100]
08-13 23:58:50.700+0900 F/record  (30062): ===next node===
08-13 23:58:50.700+0900 I/record  (30062): note : 53 detect :49 isHit : 0 [0: 1071644672/-1393235100]
08-13 23:58:50.860+0900 I/record  (30062): note : 53 detect :50 isHit : 0 [0: 1071644672/-1393235100]
08-13 23:58:51.060+0900 F/record  (30062): ===next node===
08-13 23:58:51.060+0900 I/record  (30062): note : 52 detect :51 isHit : 0 [0: 1071644672/-1393235100]
08-13 23:58:51.260+0900 F/record  (30062): ===next node===
08-13 23:58:51.260+0900 I/record  (30062): note : 50 detect :53 isHit : 0 [0: 1071644672/-1393235100]
08-13 23:58:51.420+0900 I/record  (30062): note : 50 detect :52 isHit : 0 [0: 1071644672/-1393235100]
08-13 23:58:51.620+0900 F/record  (30062): ===next node===
08-13 23:58:51.620+0900 I/record  (30062): note : 48 detect :39 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:58:51.780+0900 I/record  (30062): note : 48 detect :50 isHit : 0 [0: 1071644672/-1393235100]
08-13 23:58:51.980+0900 I/record  (30062): note : 48 detect :47 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:58:52.090+0900 I/record  (30062): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:58:52.110+0900 E/record  (30062): !! interval
08-13 23:58:52.290+0900 F/record  (30062): ===next node===
08-13 23:58:52.290+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:52.450+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:52.650+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:52.850+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:53.010+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:53.110+0900 I/CAPI_APPFW_APPLICATION(17310): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:58:53.110+0900 I/CAPI_APPFW_APPLICATION(  700): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:58:53.110+0900 W/CAM_APP (17310): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-13 23:58:53.110+0900 I/CAPI_APPFW_APPLICATION(30062): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:58:53.170+0900 I/CAPI_APPFW_APPLICATION( 8596): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:58:53.210+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:53.450+0900 I/record  (30062): note : 55 detect :97 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:53.570+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:53.770+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:53.940+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:54.140+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:54.300+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:54.500+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:54.700+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:54.970+0900 I/record  (30062): note : 55 detect :50 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:55.050+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:55.250+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:55.450+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:55.610+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:55.810+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:55.970+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:56.170+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:56.370+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:56.540+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:56.730+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:56.940+0900 I/record  (30062): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:58:56.940+0900 E/record  (30062): !! interval
08-13 23:58:57.100+0900 I/record  (30062): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:58:57.100+0900 E/record  (30062): !! interval
08-13 23:58:57.300+0900 F/record  (30062): ===next node===
08-13 23:58:57.300+0900 I/record  (30062): note : 52 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:57.470+0900 I/record  (30062): note : 52 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:57.660+0900 I/record  (30062): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:58:57.660+0900 E/record  (30062): !! interval
08-13 23:58:57.860+0900 F/record  (30062): ===next node===
08-13 23:58:57.860+0900 I/record  (30062): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:58:57.860+0900 E/record  (30062): !! interval
08-13 23:58:58.050+0900 I/record  (30062): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:58:58.050+0900 E/record  (30062): !! interval
08-13 23:58:58.210+0900 F/record  (30062): ===next node===
08-13 23:58:58.210+0900 I/record  (30062): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:58:58.210+0900 E/record  (30062): !! interval
08-13 23:58:58.410+0900 I/record  (30062): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:58:58.410+0900 E/record  (30062): !! interval
08-13 23:58:58.570+0900 F/record  (30062): ===next node===
08-13 23:58:58.570+0900 I/record  (30062): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:58:58.570+0900 E/record  (30062): !! interval
08-13 23:58:58.770+0900 F/record  (30062): ===next node===
08-13 23:58:58.770+0900 I/record  (30062): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:58:58.780+0900 E/record  (30062): !! interval
08-13 23:58:58.980+0900 I/record  (30062): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:58:58.980+0900 E/record  (30062): !! interval
08-13 23:58:59.140+0900 F/record  (30062): ===next node===
08-13 23:58:59.140+0900 I/record  (30062): note : 50 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:59.340+0900 I/record  (30062): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:58:59.340+0900 E/record  (30062): !! interval
08-13 23:58:59.500+0900 I/record  (30062): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:58:59.500+0900 E/record  (30062): !! interval
08-13 23:58:59.700+0900 F/record  (30062): ===next node===
08-13 23:58:59.700+0900 I/record  (30062): note : 52 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:58:59.900+0900 I/record  (30062): note : 52 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:59:00.070+0900 I/record  (30062): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:59:00.070+0900 E/record  (30062): !! interval
08-13 23:59:00.270+0900 F/record  (30062): ===next node===
08-13 23:59:00.270+0900 I/record  (30062): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:59:00.270+0900 E/record  (30062): !! interval
08-13 23:59:00.460+0900 I/record  (30062): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:59:00.460+0900 E/record  (30062): !! interval
08-13 23:59:00.630+0900 F/record  (30062): ===next node===
08-13 23:59:00.630+0900 I/record  (30062): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:59:00.630+0900 E/record  (30062): !! interval
08-13 23:59:00.830+0900 F/record  (30062): ===next node===
08-13 23:59:00.830+0900 I/record  (30062): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:59:00.830+0900 E/record  (30062): !! interval
08-13 23:59:01.080+0900 I/record  (30062): note : 52 detect :87 isHit : -1 [0: 1071644672/-1393235100]
08-13 23:59:01.170+0900 F/record  (30062): ===next node===
08-13 23:59:01.170+0900 I/record  (30062): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:59:01.180+0900 E/record  (30062): !! interval
08-13 23:59:01.370+0900 I/record  (30062): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:59:01.380+0900 E/record  (30062): !! interval
08-13 23:59:01.570+0900 F/record  (30062): ===next node===
08-13 23:59:01.570+0900 I/record  (30062): note : 60 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:59:01.730+0900 I/record  (30062): note : 60 detect :21 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:59:01.750+0900 E/record  (30062): !! interval
08-13 23:59:01.930+0900 I/record  (30062): note : 60 detect :21 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:59:01.950+0900 E/record  (30062): !! interval
08-13 23:59:02.130+0900 I/record  (30062): note : 60 detect :21 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:59:02.130+0900 E/record  (30062): !! interval
08-13 23:59:02.300+0900 F/record  (30062): ===next node===
08-13 23:59:02.300+0900 I/record  (30062): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:59:02.300+0900 E/record  (30062): !! interval
08-13 23:59:02.500+0900 F/record  (30062): ===next node===
08-13 23:59:02.500+0900 I/record  (30062): note : 60 detect :21 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:59:02.510+0900 E/record  (30062): !! interval
08-13 23:59:02.660+0900 I/record  (30062): note : 60 detect :21 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:59:02.660+0900 E/record  (30062): !! interval
08-13 23:59:02.860+0900 F/record  (30062): ===next node===
08-13 23:59:02.860+0900 I/record  (30062): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:59:02.860+0900 E/record  (30062): !! interval
08-13 23:59:03.060+0900 F/record  (30062): ===next node===
08-13 23:59:03.060+0900 I/record  (30062): note : 60 detect :21 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:59:03.060+0900 E/record  (30062): !! interval
08-13 23:59:03.220+0900 I/record  (30062): note : 60 detect :21 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:59:03.230+0900 E/record  (30062): !! interval
08-13 23:59:03.420+0900 F/record  (30062): ===next node===
08-13 23:59:03.420+0900 I/record  (30062): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:59:03.420+0900 E/record  (30062): !! interval
08-13 23:59:03.620+0900 F/record  (30062): ===next node===
08-13 23:59:03.620+0900 I/record  (30062): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:59:03.630+0900 E/record  (30062): !! interval
08-13 23:59:03.780+0900 I/record  (30062): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:59:03.790+0900 E/record  (30062): !! interval
08-13 23:59:03.980+0900 F/record  (30062): ===next node===
08-13 23:59:03.980+0900 I/record  (30062): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:59:04.170+0900 I/record  (30062): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:59:04.170+0900 E/record  (30062): !! interval
08-13 23:59:04.340+0900 I/record  (30062): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:59:04.340+0900 E/record  (30062): !! interval
08-13 23:59:04.530+0900 F/record  (30062): ===next node===
08-13 23:59:04.530+0900 I/record  (30062): note : 50 detect :21 isHit : 3 [0: 1071644672/-1393235100]
08-13 23:59:04.730+0900 I/record  (30062): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:59:04.740+0900 E/record  (30062): !! interval
08-13 23:59:04.890+0900 I/record  (30062): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:59:04.900+0900 E/record  (30062): !! interval
08-13 23:59:05.100+0900 F/record  (30062): ===next node===
08-13 23:59:05.100+0900 I/record  (30062): note : 53 detect :21 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:59:05.110+0900 E/record  (30062): !! interval
08-13 23:59:05.250+0900 I/record  (30062): note : 53 detect :21 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:59:05.270+0900 E/record  (30062): !! interval
08-13 23:59:05.460+0900 F/record  (30062): ===next node===
08-13 23:59:05.460+0900 I/record  (30062): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:59:05.470+0900 E/record  (30062): !! interval
08-13 23:59:05.660+0900 F/record  (30062): ===next node===
08-13 23:59:05.660+0900 I/record  (30062): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:59:05.670+0900 E/record  (30062): !! interval
08-13 23:59:05.820+0900 I/record  (30062): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:59:05.830+0900 E/record  (30062): !! interval
08-13 23:59:06.020+0900 F/record  (30062): ===next node===
08-13 23:59:06.020+0900 I/record  (30062): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:59:06.030+0900 E/record  (30062): !! interval
08-13 23:59:06.220+0900 I/record  (30062): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:59:06.230+0900 E/record  (30062): !! interval
08-13 23:59:06.380+0900 I/record  (30062): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393235100]
08-13 23:59:06.390+0900 E/record  (30062): !! interval
08-13 23:59:08.740+0900 W/AUL_AMD (  438): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
08-13 23:59:08.740+0900 W/AUL_AMD (  438): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
08-13 23:59:08.750+0900 I/AUL_PAD (  492): sigchild.h: __launchpad_sig_child(142) > dead_pid = 30062 pgid = 30062
08-13 23:59:08.750+0900 I/AUL_PAD (  492): sigchild.h: __sigchild_action(123) > dead_pid(30062)
08-13 23:59:08.750+0900 I/AUL_PAD (  492): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
08-13 23:59:08.750+0900 I/AUL_PAD (  492): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
08-13 23:59:08.790+0900 I/Tizen::System(  940): (246) > Terminated app [org.samteam.perfectsong]
08-13 23:59:08.790+0900 I/Tizen::Io(  940): (729) > Entry not found
08-13 23:59:08.800+0900 I/Tizen::App(  902): (243) > App[org.samteam.perfectsong] pid[30062] terminate event is forwarded
08-13 23:59:08.800+0900 I/Tizen::System(  902): (256) > osp.accessorymanager.service provider is found.
08-13 23:59:08.800+0900 I/Tizen::System(  902): (196) > Accessory Owner is removed [org.samteam.perfectsong, 30062, ]
08-13 23:59:08.800+0900 I/Tizen::System(  902): (256) > osp.system.service provider is found.
08-13 23:59:08.800+0900 I/Tizen::App(  902): (506) > TerminatedApp(org.samteam.perfectsong)
08-13 23:59:08.800+0900 I/Tizen::App(  902): (512) > Not registered pid(30062)
08-13 23:59:08.800+0900 I/Tizen::App(  902): (782) > Finished invoking application event listener for org.samteam.perfectsong, 30062.
08-13 23:59:08.810+0900 I/AUL_AMD (  438): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 30062
08-13 23:59:08.810+0900 I/Tizen::System(  940): (157) > change brightness system value.
08-13 23:59:08.810+0900 I/Tizen::App(  940): (782) > Finished invoking application event listener for org.samteam.perfectsong, 30062.
08-13 23:59:08.820+0900 W/PROCESSMGR(  378): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=588
08-13 23:59:08.840+0900 I/QUICKPANEL(  666): sound-profile.c: _view_update(106) > [_view_update : 106] sound : 1, vibration : 0
08-13 23:59:08.850+0900 W/CRASH_MANAGER(30225): worker.c: worker_job(1198) > 1130062706161143947794
