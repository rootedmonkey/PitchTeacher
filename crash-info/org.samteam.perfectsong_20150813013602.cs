S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.0
Build-Number: Z130HDDU0BOB3
Build-Date: 2015.02.14 15:10:17

Crash Information
Process Name: paaaaaaaaa
PID: 11433
Date: 2015-08-13 01:36:02+0900
Executable File Path: /opt/usr/apps/org.samteam.perfectsong/bin/paaaaaaaaa
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 11433, uid 5000)

Register Information
r0   = 0xb3400010, r1   = 0x00000002
r2   = 0x00000000, r3   = 0xb3400058
r4   = 0xb3400010, r5   = 0x00000020
r6   = 0x00000004, r7   = 0xb3422c50
r8   = 0xbec18eb0, r9   = 0xb341dd40
r10  = 0x0000001c, fp   = 0x00000000
ip   = 0xb6390f68, sp   = 0xbec18e18
lr   = 0xb6cc3a80, pc   = 0xb6cc0eb4
cpsr = 0xa0000010

Memory Information
MemTotal:   730748 KB
MemFree:    195116 KB
Buffers:     40696 KB
Cached:     203640 KB
VmPeak:     189012 KB
VmSize:     187536 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       32232 KB
VmRSS:       32228 KB
VmData:     118700 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       28388 KB
VmPTE:         110 KB
VmSwap:          0 KB

Threads Information
Threads: 12
PID = 11433 TID = 11433
11433 11441 11442 11445 11914 11915 11916 11919 11920 11922 11923 11924 

Maps Information
ad201000 ada00000 rwxp [stack:11924]
adbb1000 adbcb000 r-xp /usr/lib/gstreamer-0.10/libgstpulse.so
adbd4000 adbdd000 r-xp /usr/lib/lib_SoundBooster_ver402_wrapped.so
adbe7000 adc64000 r-xp /usr/lib/lib_SoundAlive_ver125e_wrapped.so
adc96000 adcae000 r-xp /usr/lib/libgstcontroller-0.10.so.0.30.0
adcbd000 adcc3000 r-xp /usr/lib/gstreamer-0.10/libgstsoundalive.so
adccb000 adcd0000 r-xp /usr/lib/gstreamer-0.10/libgstvolume.so
adcd9000 ae4d8000 rwxp [stack:11923]
ae4d9000 aecd8000 rwxp [stack:11922]
af2d9000 afad8000 rwxp [stack:11445]
afadc000 afae4000 r-xp /usr/lib/lib_SoundAlive_SRC192_ver204_wrapped.so
afae7000 afaea000 r-xp /usr/lib/gstreamer-0.10/libgstsecresample.so
afaf3000 afafe000 r-xp /usr/lib/gstreamer-0.10/libgstaudioconvert.so
afb07000 afb0b000 r-xp /usr/lib/gstreamer-0.10/libgstaudiotp.so
afb13000 afb3c000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
afb45000 afb6a000 r-xp /usr/lib/libgsttag-0.10.so.0.25.0
afb73000 afb7d000 r-xp /usr/lib/libgstriff-0.10.so.0.25.0
afb86000 afbac000 r-xp /usr/lib/gstreamer-0.10/libgstogg.so
afbb5000 afbf8000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
afd04000 afd1c000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
afd25000 afd3b000 r-xp /usr/lib/gstreamer-0.10/libgstdecodebin2.so
afd66000 afd6f000 r-xp /usr/lib/gstreamer-0.10/libgstvorbis.so
afd77000 afdac000 r-xp /usr/lib/gstreamer-0.10/libgstcoreelements.so
afeda000 b06d9000 rwxp [stack:11442]
b0adb000 b12da000 rwxp [stack:11441]
b12db000 b1ada000 rwxp [stack:11914]
b1adb000 b22da000 rwxp [stack:11915]
b2401000 b2c00000 rwxp [stack:11919]
b2c01000 b3400000 rwxp [stack:11916]
b3505000 b350f000 r-xp /usr/lib/gstreamer-0.10/libgsttypefindfunctions.so
b35cc000 b3dcb000 rwxp [stack:11920]
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
b8cd6000 b954a000 rw-p [heap]
bec08000 bec29000 rwxp [stack]
b8cac000 b8cd6000 rw-p [heap]
b8cd6000 b954a000 rw-p [heap]
bec08000 bec29000 rwxp [stack]
End of Maps Information

Callstack Information (PID:11433)
Call Stack Count: 13
 0: (0xb6cc0eb4) [/lib/libc.so.6] + 0x6beb4
 1: __libc_malloc + 0x80 (0xb6cc3a80) [/lib/libc.so.6] + 0x6ea80
 2: evas_common_tilebuf_get_render_rects + 0x1b8 (0xb634f441) [/usr/lib/libevas.so.1] + 0x8e441
 3: (0xb4be17c9) [/usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so] + 0x27c9
 4: (0xb6318c89) [/usr/lib/libevas.so.1] + 0x57c89
 5: (0xb63be1b5) [/usr/lib/libecore_evas.so.1] + 0x111b5
 6: (0xb63bb965) [/usr/lib/libecore_evas.so.1] + 0xe965
 7: (0xb6bcccfd) [/usr/lib/libecore.so.1] + 0x9cfd
 8: (0xb6bce127) [/usr/lib/libecore.so.1] + 0xb127
 9: ecore_main_loop_begin + 0x30 (0xb6bce691) [/usr/lib/libecore.so.1] + 0xb691
10: appcore_efl_main + 0x17e (0xb6f84387) [/usr/lib/libappcore-efl.so.1] + 0x2387
11: ui_app_main + 0xb0 (0xb6568499) [/usr/lib/libcapi-appfw-application.so.0] + 0x2499
12: main + 0x11e (0xb4bf73cb) [/opt/usr/apps/org.samteam.perfectsong/bin/paaaaaaaaa] + 0x53cb
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
0900 I/record  (11433): note : 48 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:43.360+0900 I/record  (11433): note : 48 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:43.420+0900 I/record  (11433): note : 48 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:43.470+0900 I/record  (11433): note : 48 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:43.510+0900 I/record  (11433): note : 48 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:43.570+0900 I/record  (11433): note : 48 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:43.610+0900 I/record  (11433): note : 48 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:43.660+0900 I/record  (11433): note : 48 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:43.720+0900 I/record  (11433): note : 48 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:43.770+0900 I/record  (11433): note : 48 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:43.820+0900 I/record  (11433): note : 48 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:43.870+0900 F/record  (11433): ===next node===
08-13 01:35:43.870+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:43.920+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:43.970+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:44.020+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:44.070+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:44.200+0900 I/record  (11433): note : 55 detect :49 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:44.250+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:44.260+0900 I/Tizen::Net::Wifi(  961): (1072) > _WifiService is not registered.
08-13 01:35:44.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 01:35:44.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 01:35:44.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 01:35:44.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
08-13 01:35:44.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 303 5 28 25"
08-13 01:35:44.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 331 5 28 25"
08-13 01:35:44.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 359 5 28 25"
08-13 01:35:44.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 387 5 28 25"
08-13 01:35:44.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 01:35:44.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 01:35:44.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 01:35:44.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
08-13 01:35:44.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 198 567 5 28 25"
08-13 01:35:44.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 200 595 5 28 25"
08-13 01:35:44.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 623 5 28 25"
08-13 01:35:44.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 651 5 28 25"
08-13 01:35:44.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 679 5 28 25"
08-13 01:35:44.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 707 5 28 25"
08-13 01:35:44.300+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:44.360+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:44.490+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:44.540+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:44.590+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:44.730+0900 I/record  (11433): note : 55 detect :49 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:44.780+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:44.830+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:44.970+0900 I/record  (11433): note : 55 detect :47 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:45.110+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:45.240+0900 I/record  (11433): note : 55 detect :94 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:45.260+0900 I/Tizen::Net::Wifi(  961): (1072) > _WifiService is not registered.
08-13 01:35:45.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 01:35:45.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 01:35:45.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 01:35:45.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
08-13 01:35:45.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 303 5 28 25"
08-13 01:35:45.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 331 5 28 25"
08-13 01:35:45.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 359 5 28 25"
08-13 01:35:45.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 387 5 28 25"
08-13 01:35:45.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 01:35:45.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 01:35:45.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 01:35:45.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
08-13 01:35:45.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 198 567 5 28 25"
08-13 01:35:45.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 200 595 5 28 25"
08-13 01:35:45.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 623 5 28 25"
08-13 01:35:45.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 651 5 28 25"
08-13 01:35:45.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 679 5 28 25"
08-13 01:35:45.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 707 5 28 25"
08-13 01:35:45.400+0900 I/record  (11433): note : 55 detect :47 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:45.530+0900 I/record  (11433): note : 55 detect :47 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:45.670+0900 I/record  (11433): note : 55 detect :44 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:45.720+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:45.770+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:45.820+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:45.870+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:45.920+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:45.970+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:46.030+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:46.080+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:46.130+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:46.180+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:46.230+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:46.260+0900 I/Tizen::Net::Wifi(  961): (1072) > _WifiService is not registered.
08-13 01:35:46.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 01:35:46.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 01:35:46.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 01:35:46.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
08-13 01:35:46.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 303 5 28 25"
08-13 01:35:46.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 331 5 28 25"
08-13 01:35:46.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 359 5 28 25"
08-13 01:35:46.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 387 5 28 25"
08-13 01:35:46.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 01:35:46.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 01:35:46.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 01:35:46.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
08-13 01:35:46.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 198 567 5 28 25"
08-13 01:35:46.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 200 595 5 28 25"
08-13 01:35:46.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 623 5 28 25"
08-13 01:35:46.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 651 5 28 25"
08-13 01:35:46.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 679 5 28 25"
08-13 01:35:46.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 707 5 28 25"
08-13 01:35:46.280+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:46.330+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:46.390+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:46.520+0900 I/record  (11433): note : 55 detect :47 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:46.570+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:46.620+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:46.670+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:46.720+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:46.770+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:46.820+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:46.870+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:46.920+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:46.980+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:47.030+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:47.080+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:47.130+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:47.180+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:47.230+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:47.260+0900 I/Tizen::Net::Wifi(  961): (1072) > _WifiService is not registered.
08-13 01:35:47.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 01:35:47.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 01:35:47.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 01:35:47.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
08-13 01:35:47.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 303 5 28 25"
08-13 01:35:47.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 331 5 28 25"
08-13 01:35:47.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 359 5 28 25"
08-13 01:35:47.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 387 5 28 25"
08-13 01:35:47.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 01:35:47.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 01:35:47.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 01:35:47.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
08-13 01:35:47.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 198 567 5 28 25"
08-13 01:35:47.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 200 595 5 28 25"
08-13 01:35:47.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 623 5 28 25"
08-13 01:35:47.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 651 5 28 25"
08-13 01:35:47.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 679 5 28 25"
08-13 01:35:47.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 707 5 28 25"
08-13 01:35:47.280+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:47.330+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:47.380+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:47.430+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:47.480+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:47.530+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:47.580+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:47.640+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:47.690+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:47.740+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:47.790+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:47.840+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:47.970+0900 I/record  (11433): note : 55 detect :75 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:48.020+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:48.070+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:48.120+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:48.180+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:48.230+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:48.260+0900 I/Tizen::Net::Wifi(  961): (1072) > _WifiService is not registered.
08-13 01:35:48.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 01:35:48.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 01:35:48.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 01:35:48.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
08-13 01:35:48.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 303 5 28 25"
08-13 01:35:48.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 331 5 28 25"
08-13 01:35:48.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 359 5 28 25"
08-13 01:35:48.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 387 5 28 25"
08-13 01:35:48.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 01:35:48.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 01:35:48.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 01:35:48.280+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
08-13 01:35:48.280+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 198 567 5 28 25"
08-13 01:35:48.280+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 200 595 5 28 25"
08-13 01:35:48.280+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 623 5 28 25"
08-13 01:35:48.280+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 651 5 28 25"
08-13 01:35:48.280+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 679 5 28 25"
08-13 01:35:48.280+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 707 5 28 25"
08-13 01:35:48.280+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:48.430+0900 I/record  (11433): note : 55 detect :58 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:48.480+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:48.530+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:48.580+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:48.630+0900 I/record  (11433): note : 55 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:48.760+0900 I/record  (11433): note : 55 detect :103 isHit : -1 [0: 1071644672/-1399026844]
08-13 01:35:48.820+0900 I/record  (11433): note : 55 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:48.860+0900 I/record  (11433): note : 55 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:48.920+0900 I/record  (11433): note : 55 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:48.970+0900 F/record  (11433): ===next node===
08-13 01:35:48.970+0900 I/record  (11433): note : 52 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:49.020+0900 I/record  (11433): note : 52 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:49.070+0900 I/record  (11433): note : 52 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:49.120+0900 I/record  (11433): note : 52 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:49.170+0900 I/record  (11433): note : 52 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:49.220+0900 I/record  (11433): note : 52 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:49.270+0900 I/record  (11433): note : 52 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:49.320+0900 I/record  (11433): note : 52 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:49.370+0900 I/record  (11433): note : 52 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:49.420+0900 I/record  (11433): note : 52 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:49.470+0900 I/record  (11433): note : 52 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:49.520+0900 F/record  (11433): ===next node===
08-13 01:35:49.520+0900 I/record  (11433): note : 52 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:49.660+0900 I/record  (11433): note : 52 detect :72 isHit : -1 [0: 1071644672/-1399026844]
08-13 01:35:49.710+0900 I/record  (11433): note : 52 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:49.760+0900 I/record  (11433): note : 52 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:49.810+0900 I/record  (11433): note : 52 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:49.860+0900 F/record  (11433): ===next node===
08-13 01:35:49.860+0900 I/record  (11433): note : 55 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:49.910+0900 I/record  (11433): note : 55 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:49.960+0900 I/record  (11433): note : 55 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:50.010+0900 I/record  (11433): note : 55 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:50.060+0900 I/record  (11433): note : 55 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:50.110+0900 I/record  (11433): note : 55 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:50.260+0900 F/record  (11433): ===next node===
08-13 01:35:50.260+0900 I/record  (11433): note : 52 detect :66 isHit : -1 [0: 1071644672/-1399026844]
08-13 01:35:50.260+0900 I/Tizen::Net::Wifi(  961): (1072) > _WifiService is not registered.
08-13 01:35:50.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 01:35:50.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 01:35:50.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 01:35:50.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
08-13 01:35:50.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 303 5 28 25"
08-13 01:35:50.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 331 5 28 25"
08-13 01:35:50.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 359 5 28 25"
08-13 01:35:50.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 387 5 28 25"
08-13 01:35:50.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 01:35:50.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 01:35:50.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 01:35:50.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
08-13 01:35:50.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 198 567 5 28 25"
08-13 01:35:50.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 200 595 5 28 25"
08-13 01:35:50.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 623 5 28 25"
08-13 01:35:50.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 651 5 28 25"
08-13 01:35:50.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 679 5 28 25"
08-13 01:35:50.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 707 5 28 25"
08-13 01:35:50.310+0900 I/record  (11433): note : 52 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:50.360+0900 I/record  (11433): note : 52 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:50.410+0900 I/record  (11433): note : 52 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:50.460+0900 F/record  (11433): ===next node===
08-13 01:35:50.460+0900 I/record  (11433): note : 48 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:50.510+0900 I/record  (11433): note : 48 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:50.560+0900 I/record  (11433): note : 48 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:50.610+0900 I/record  (11433): note : 48 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:50.660+0900 I/record  (11433): note : 48 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:50.710+0900 I/record  (11433): note : 48 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:50.760+0900 F/record  (11433): ===next node===
08-13 01:35:50.760+0900 I/record  (11433): note : 50 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:50.810+0900 I/record  (11433): note : 50 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:50.950+0900 I/record  (11433): note : 50 detect :77 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:51.080+0900 I/record  (11433): note : 50 detect :45 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:51.130+0900 I/record  (11433): note : 50 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:51.270+0900 I/record  (11433): note : 50 detect :49 isHit : 0 [0: 1071644672/-1399026844]
08-13 01:35:51.280+0900 I/Tizen::Net::Wifi(  961): (1072) > _WifiService is not registered.
08-13 01:35:51.280+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 01:35:51.280+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 01:35:51.280+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 01:35:51.280+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
08-13 01:35:51.280+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 303 5 28 25"
08-13 01:35:51.280+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 331 5 28 25"
08-13 01:35:51.280+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 359 5 28 25"
08-13 01:35:51.280+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 387 5 28 25"
08-13 01:35:51.280+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 01:35:51.280+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 01:35:51.280+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 01:35:51.280+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
08-13 01:35:51.280+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 198 567 5 28 25"
08-13 01:35:51.280+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 200 595 5 28 25"
08-13 01:35:51.280+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 623 5 28 25"
08-13 01:35:51.280+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 651 5 28 25"
08-13 01:35:51.280+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 679 5 28 25"
08-13 01:35:51.280+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 707 5 28 25"
08-13 01:35:51.410+0900 F/record  (11433): ===next node===
08-13 01:35:51.410+0900 I/record  (11433): note : 52 detect :46 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:51.460+0900 I/record  (11433): note : 52 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:51.510+0900 I/record  (11433): note : 52 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:51.640+0900 I/record  (11433): note : 52 detect :54 isHit : 0 [0: 1071644672/-1399026844]
08-13 01:35:51.770+0900 I/record  (11433): note : 52 detect :49 isHit : 0 [0: 1071644672/-1399026844]
08-13 01:35:51.830+0900 I/record  (11433): note : 52 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:51.880+0900 I/record  (11433): note : 52 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:51.930+0900 F/record  (11433): ===next node===
08-13 01:35:51.930+0900 I/record  (11433): note : 50 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:51.980+0900 I/record  (11433): note : 50 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:52.030+0900 I/record  (11433): note : 50 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:52.080+0900 I/record  (11433): note : 50 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:52.130+0900 I/record  (11433): note : 50 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:52.190+0900 I/record  (11433): note : 50 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:52.230+0900 F/record  (11433): ===next node===
08-13 01:35:52.230+0900 I/record  (11433): note : 48 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:52.280+0900 I/record  (11433): note : 48 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:52.330+0900 I/record  (11433): note : 48 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:52.470+0900 I/record  (11433): note : 48 detect :60 isHit : 0 [0: 1071644672/-1399026844]
08-13 01:35:52.600+0900 F/record  (11433): ===next node===
08-13 01:35:52.600+0900 I/record  (11433): note : 52 detect :47 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:52.730+0900 I/record  (11433): note : 52 detect :49 isHit : 0 [0: 1071644672/-1399026844]
08-13 01:35:52.860+0900 F/record  (11433): ===next node===
08-13 01:35:52.860+0900 I/record  (11433): note : 55 detect :47 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:52.910+0900 I/record  (11433): note : 55 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:52.960+0900 I/record  (11433): note : 55 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:53.020+0900 I/record  (11433): note : 55 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:53.070+0900 I/record  (11433): note : 55 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:53.120+0900 I/record  (11433): note : 55 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:53.170+0900 F/record  (11433): ===next node===
08-13 01:35:53.170+0900 I/record  (11433): note : 60 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:53.220+0900 I/record  (11433): note : 60 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:53.270+0900 I/record  (11433): note : 60 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:53.330+0900 I/record  (11433): note : 60 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:53.370+0900 I/record  (11433): note : 60 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:53.430+0900 I/record  (11433): note : 60 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:53.470+0900 I/record  (11433): note : 60 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:53.520+0900 I/record  (11433): note : 60 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:53.580+0900 I/record  (11433): note : 60 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:53.620+0900 I/record  (11433): note : 60 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:53.670+0900 I/record  (11433): note : 60 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:53.730+0900 I/record  (11433): note : 60 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:53.780+0900 I/record  (11433): note : 60 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:53.830+0900 I/record  (11433): note : 60 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:53.880+0900 F/record  (11433): ===next node===
08-13 01:35:53.880+0900 I/record  (11433): note : 55 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:53.930+0900 I/record  (11433): note : 55 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:53.980+0900 I/record  (11433): note : 55 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:54.030+0900 F/record  (11433): ===next node===
08-13 01:35:54.030+0900 I/record  (11433): note : 60 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:54.080+0900 I/record  (11433): note : 60 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:54.130+0900 I/record  (11433): note : 60 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:54.270+0900 I/record  (11433): note : 60 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:54.410+0900 I/record  (11433): note : 60 detect :52 isHit : 0 [0: 1071644672/-1399026844]
08-13 01:35:54.550+0900 F/record  (11433): ===next node===
08-13 01:35:54.550+0900 I/record  (11433): note : 55 detect :103 isHit : -1 [0: 1071644672/-1399026844]
08-13 01:35:54.600+0900 I/record  (11433): note : 55 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:54.740+0900 F/record  (11433): ===next node===
08-13 01:35:54.740+0900 I/record  (11433): note : 60 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:54.790+0900 I/record  (11433): note : 60 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:54.840+0900 I/record  (11433): note : 60 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:54.980+0900 F/record  (11433): ===next node===
08-13 01:35:54.980+0900 I/record  (11433): note : 55 detect :43 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:55.110+0900 I/record  (11433): note : 55 detect :43 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:55.250+0900 F/record  (11433): ===next node===
08-13 01:35:55.260+0900 I/record  (11433): note : 52 detect :43 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:55.270+0900 I/Tizen::Net::Wifi(  961): (1072) > _WifiService is not registered.
08-13 01:35:55.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 01:35:55.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 01:35:55.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 01:35:55.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
08-13 01:35:55.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 303 5 28 25"
08-13 01:35:55.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 331 5 28 25"
08-13 01:35:55.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 359 5 28 25"
08-13 01:35:55.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 387 5 28 25"
08-13 01:35:55.280+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 01:35:55.280+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 01:35:55.280+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 01:35:55.280+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
08-13 01:35:55.280+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 198 567 5 28 25"
08-13 01:35:55.280+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 200 595 5 28 25"
08-13 01:35:55.280+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 623 5 28 25"
08-13 01:35:55.280+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 651 5 28 25"
08-13 01:35:55.280+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 679 5 28 25"
08-13 01:35:55.280+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 707 5 28 25"
08-13 01:35:55.310+0900 I/record  (11433): note : 52 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:55.450+0900 I/record  (11433): note : 52 detect :81 isHit : -1 [0: 1071644672/-1399026844]
08-13 01:35:55.580+0900 F/record  (11433): ===next node===
08-13 01:35:55.580+0900 I/record  (11433): note : 55 detect :58 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:55.720+0900 I/record  (11433): note : 55 detect :21 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:55.850+0900 I/record  (11433): note : 55 detect :103 isHit : -1 [0: 1071644672/-1399026844]
08-13 01:35:55.990+0900 I/record  (11433): note : 55 detect :71 isHit : -1 [0: 1071644672/-1399026844]
08-13 01:35:56.120+0900 F/record  (11433): ===next node===
08-13 01:35:56.120+0900 I/record  (11433): note : 50 detect :91 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:56.250+0900 I/record  (11433): note : 50 detect :55 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:56.390+0900 I/record  (11433): note : 50 detect :54 isHit : 3 [0: 1071644672/-1399026844]
08-13 01:35:56.520+0900 I/record  (11433): note : 50 detect :57 isHit : 0 [0: 1071644672/-1399026844]
08-13 01:35:56.570+0900 I/record  (11433): note : 50 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:56.700+0900 I/record  (11433): note : 50 detect :56 isHit : 0 [0: 1071644672/-1399026844]
08-13 01:35:56.840+0900 F/record  (11433): ===next node===
08-13 01:35:56.840+0900 I/record  (11433): note : 53 detect :57 isHit : 0 [0: 1071644672/-1399026844]
08-13 01:35:56.970+0900 I/record  (11433): note : 53 detect :67 isHit : -1 [0: 1071644672/-1399026844]
08-13 01:35:57.100+0900 F/record  (11433): ===next node===
08-13 01:35:57.100+0900 I/record  (11433): note : 52 detect :97 isHit : -1 [0: 1071644672/-1399026844]
08-13 01:35:57.230+0900 I/record  (11433): note : 52 detect :57 isHit : 0 [0: 1071644672/-1399026844]
08-13 01:35:57.370+0900 F/record  (11433): ===next node===
08-13 01:35:57.370+0900 I/record  (11433): note : 50 detect :54 isHit : 0 [0: 1071644672/-1399026844]
08-13 01:35:57.500+0900 I/record  (11433): note : 50 detect :103 isHit : -1 [0: 1071644672/-1399026844]
08-13 01:35:57.630+0900 F/record  (11433): ===next node===
08-13 01:35:57.630+0900 I/record  (11433): note : 48 detect :55 isHit : 0 [0: 1071644672/-1399026844]
08-13 01:35:57.680+0900 I/record  (11433): note : 48 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:57.820+0900 I/record  (11433): note : 48 detect :52 isHit : 0 [0: 1071644672/-1399026844]
08-13 01:35:57.880+0900 I/record  (11433): note : 48 detect :21 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:58.010+0900 I/record  (11433): note : 48 detect :47 isHit : -2 [0: 1071644672/-1399026844]
08-13 01:35:58.140+0900 I/record  (11433): note : 48 detect :55 isHit : 0 [0: 1071644672/-1399026844]
08-13 01:35:59.240+0900 I/Tizen::Net::Wifi(  961): (1072) > _WifiService is not registered.
08-13 01:35:59.250+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 01:35:59.250+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 01:35:59.250+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 01:35:59.250+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
08-13 01:35:59.250+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 303 5 28 25"
08-13 01:35:59.250+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 331 5 28 25"
08-13 01:35:59.250+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 359 5 28 25"
08-13 01:35:59.250+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 387 5 28 25"
08-13 01:35:59.250+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 01:35:59.250+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 01:35:59.250+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 01:35:59.250+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
08-13 01:35:59.250+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 198 567 5 28 25"
08-13 01:35:59.250+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 200 595 5 28 25"
08-13 01:35:59.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 623 5 28 25"
08-13 01:35:59.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 651 5 28 25"
08-13 01:35:59.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 679 5 28 25"
08-13 01:35:59.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 707 5 28 25"
08-13 01:36:01.260+0900 I/Tizen::Net::Wifi(  961): (1072) > _WifiService is not registered.
08-13 01:36:01.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 01:36:01.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 01:36:01.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 01:36:01.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
08-13 01:36:01.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 303 5 28 25"
08-13 01:36:01.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 331 5 28 25"
08-13 01:36:01.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 359 5 28 25"
08-13 01:36:01.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 387 5 28 25"
08-13 01:36:01.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 01:36:01.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 01:36:01.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 01:36:01.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
08-13 01:36:01.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 198 567 5 28 25"
08-13 01:36:01.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 200 595 5 28 25"
08-13 01:36:01.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 623 5 28 25"
08-13 01:36:01.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 651 5 28 25"
08-13 01:36:01.260+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 679 5 28 25"
08-13 01:36:01.270+0900 I/indicator(  499): indicator_box_util.c: _update_display(585) > "Noti Icon : 205 707 5 28 25"
08-13 01:36:01.280+0900 E/record  (11433): perfect_song_end
08-13 01:36:02.460+0900 F/record  (11433): tunning button Callback
08-13 01:36:02.660+0900 E/asdf    (11433): -1286887728
08-13 01:36:02.660+0900 E/asdf    (11433): -1286887728
08-13 01:36:02.660+0900 I/TIZEN_N_PLAYER(11433): player.c: player_stop(1639) > [player_stop] Start
08-13 01:36:02.700+0900 W/TIZEN_N_PLAYER(11433): player.c: __msg_callback(660) > [__msg_callback] Got message type : 0x3
08-13 01:36:02.700+0900 I/TIZEN_N_PLAYER(11433): player.c: __msg_callback(686) > STATE CHANGED INTERNALLY - from : 2,  to : 1 (CAPI State : 3)
08-13 01:36:02.700+0900 W/TIZEN_N_PLAYER(11433): player.c: __msg_callback(859) > [__msg_callback] End
08-13 01:36:02.700+0900 I/TIZEN_N_PLAYER(11433): player.c: player_stop(1665) > [player_stop] End
08-13 01:36:02.700+0900 E/asdf    (11433): escape
08-13 01:36:03.050+0900 W/AUL_AMD (  444): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
08-13 01:36:03.050+0900 W/AUL_AMD (  444): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
08-13 01:36:03.050+0900 I/AUL_PAD (  498): sigchild.h: __launchpad_sig_child(142) > dead_pid = 11433 pgid = 11433
08-13 01:36:03.050+0900 I/AUL_PAD (  498): sigchild.h: __sigchild_action(123) > dead_pid(11433)
08-13 01:36:03.050+0900 I/AUL_PAD (  498): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
08-13 01:36:03.050+0900 I/AUL_PAD (  498): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
08-13 01:36:03.060+0900 I/Tizen::System(  937): (246) > Terminated app [org.samteam.perfectsong]
08-13 01:36:03.070+0900 I/Tizen::Io(  937): (729) > Entry not found
08-13 01:36:03.070+0900 I/Tizen::App(  887): (243) > App[org.samteam.perfectsong] pid[11433] terminate event is forwarded
08-13 01:36:03.070+0900 I/Tizen::System(  887): (256) > osp.accessorymanager.service provider is found.
08-13 01:36:03.070+0900 I/Tizen::System(  887): (196) > Accessory Owner is removed [org.samteam.perfectsong, 11433, ]
08-13 01:36:03.070+0900 I/Tizen::System(  887): (256) > osp.system.service provider is found.
08-13 01:36:03.070+0900 I/Tizen::App(  887): (506) > TerminatedApp(org.samteam.perfectsong)
08-13 01:36:03.070+0900 I/Tizen::App(  887): (512) > Not registered pid(11433)
08-13 01:36:03.070+0900 I/Tizen::App(  887): (782) > Finished invoking application event listener for org.samteam.perfectsong, 11433.
08-13 01:36:03.070+0900 I/AUL_AMD (  444): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 11433
08-13 01:36:03.080+0900 I/Tizen::System(  937): (157) > change brightness system value.
08-13 01:36:03.080+0900 I/Tizen::App(  937): (782) > Finished invoking application event listener for org.samteam.perfectsong, 11433.
08-13 01:36:03.120+0900 W/PROCESSMGR(  407): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=589
08-13 01:36:03.160+0900 I/QUICKPANEL(  661): sound-profile.c: _view_update(106) > [_view_update : 106] sound : 0, vibration : 1
08-13 01:36:03.170+0900 I/CAPI_APPFW_APPLICATION(  589): app_main.c: app_appcore_resume(223) > app_appcore_resume
08-13 01:36:03.170+0900 E/cluster-home(  589): homescreen-main.cpp: app_resume(422) >  app resume
08-13 01:36:03.210+0900 I/QUICKPANEL(  661): quickpanel-ui.c: _ui_handler_input_region_set(172) > [_ui_handler_input_region_set : 172] win_input_0:0
08-13 01:36:03.210+0900 I/QUICKPANEL(  661): win_input_1:758
08-13 01:36:03.210+0900 I/QUICKPANEL(  661): win_input_2:480
08-13 01:36:03.210+0900 I/QUICKPANEL(  661): win_input_3:42
08-13 01:36:03.210+0900 I/QUICKPANEL(  661): 
08-13 01:36:03.220+0900 W/CRASH_MANAGER(11997): worker.c: worker_job(1198) > 1111433706161143939736
