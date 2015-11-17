S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.0
Build-Number: Z130HDDU0BOB3
Build-Date: 2015.02.14 15:10:17

Crash Information
Process Name: paaaaaaaaa
PID: 20331
Date: 2015-08-13 23:28:13+0900
Executable File Path: /opt/usr/apps/org.samteam.perfectsong/bin/paaaaaaaaa
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x46

Register Information
r0   = 0x00000046, r1   = 0x00000025
r2   = 0xbeff071c, r3   = 0x00000046
r4   = 0xfbad8001, r5   = 0xbeff071c
r6   = 0xbeff01e8, r7   = 0xb6cd6000
r8   = 0x00000000, r9   = 0xb48eb4d0
r10  = 0x00000046, fp   = 0xbeff01dc
ip   = 0xb6f6da18, sp   = 0xbefefc68
lr   = 0xb6bedf5c, pc   = 0xb6c285d8
cpsr = 0x20000010

Memory Information
MemTotal:   730748 KB
MemFree:    156784 KB
Buffers:     46172 KB
Cached:     211772 KB
VmPeak:     187872 KB
VmSize:     187868 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       36136 KB
VmRSS:       36132 KB
VmData:     120996 KB
VmStk:         136 KB
VmExe:          36 KB
VmLib:       45656 KB
VmPTE:         110 KB
VmSwap:          0 KB

Threads Information
Threads: 12
PID = 20331 TID = 20331
20331 20384 20385 20387 20726 20727 20728 20731 20732 20741 20742 20756 

Maps Information
2a000000 2a009000 r-xp /opt/usr/apps/org.samteam.perfectsong/bin/paaaaaaaaa
2a010000 2a012000 rwxp /opt/usr/apps/org.samteam.perfectsong/bin/paaaaaaaaa
2a012000 2a75b000 rwxp [heap]
ac004000 ac184000 rwxs /drm
ac184000 ac304000 rwxs /drm
ac47c000 ac5fc000 rwxs /drm
ac5fc000 ac77c000 rwxs /drm
ad3b1000 ad7b2000 rwxs /dev/shm/pulse-shm-1372458658
ad7b3000 adfb2000 rwxp [stack:20756]
adfb2000 adfcc000 r-xp /usr/lib/gstreamer-0.10/libgstpulse.so
adfd4000 adfd5000 rwxp /usr/lib/gstreamer-0.10/libgstpulse.so
adfd5000 adfde000 r-xp /usr/lib/lib_SoundBooster_ver402_wrapped.so
adfe6000 adfe8000 rwxp /usr/lib/lib_SoundBooster_ver402_wrapped.so
adfe8000 ae065000 r-xp /usr/lib/lib_SoundAlive_ver125e_wrapped.so
ae06d000 ae082000 rwxp /usr/lib/lib_SoundAlive_ver125e_wrapped.so
ae097000 ae0af000 r-xp /usr/lib/libgstcontroller-0.10.so.0.30.0
ae0b6000 ae0b7000 rwxp /usr/lib/libgstcontroller-0.10.so.0.30.0
ae0be000 ae0c4000 r-xp /usr/lib/gstreamer-0.10/libgstsoundalive.so
ae0cb000 ae0cc000 rwxp /usr/lib/gstreamer-0.10/libgstsoundalive.so
ae0cc000 ae0d4000 r-xp /usr/lib/lib_SoundAlive_SRC192_ver204_wrapped.so
ae0d4000 ae0d7000 rwxp /usr/lib/lib_SoundAlive_SRC192_ver204_wrapped.so
ae0df000 ae0e4000 r-xp /usr/lib/gstreamer-0.10/libgstvolume.so
ae0eb000 ae0ec000 rwxp /usr/lib/gstreamer-0.10/libgstvolume.so
ae0ec000 ae0f7000 r-xp /usr/lib/gstreamer-0.10/libgstaudioconvert.so
ae0ff000 ae100000 rwxp /usr/lib/gstreamer-0.10/libgstaudioconvert.so
ae101000 ae900000 rwxp [stack:20742]
ae901000 af100000 rwxp [stack:20741]
af408000 af431000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
af438000 af43a000 rwxp /usr/lib/libgstaudio-0.10.so.0.25.0
af43a000 af45f000 r-xp /usr/lib/libgsttag-0.10.so.0.25.0
af467000 af468000 rwxp /usr/lib/libgsttag-0.10.so.0.25.0
af468000 af58c000 r-xp /usr/share/fallback_fonts/TizenSansKoreanRegular.ttf
af58d000 afd8c000 rwxp [stack:20387]
afd91000 afd94000 r-xp /usr/lib/gstreamer-0.10/libgstsecresample.so
afd9c000 afd9d000 rwxp /usr/lib/gstreamer-0.10/libgstsecresample.so
afd9d000 afda1000 r-xp /usr/lib/gstreamer-0.10/libgstaudiotp.so
afda8000 afda9000 rwxp /usr/lib/gstreamer-0.10/libgstaudiotp.so
afda9000 afdb3000 r-xp /usr/lib/libgstriff-0.10.so.0.25.0
afdbb000 afdbc000 rwxp /usr/lib/libgstriff-0.10.so.0.25.0
afdc0000 afdc9000 r-xp /usr/lib/gstreamer-0.10/libgstvorbis.so
afdd0000 afdd1000 rwxp /usr/lib/gstreamer-0.10/libgstvorbis.so
afdd1000 afdf7000 r-xp /usr/lib/gstreamer-0.10/libgstogg.so
afdfe000 afe00000 rwxp /usr/lib/gstreamer-0.10/libgstogg.so
aff0a000 aff22000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
aff29000 aff2b000 rwxp /usr/lib/libgstpbutils-0.10.so.0.25.0
aff2b000 aff41000 r-xp /usr/lib/gstreamer-0.10/libgstdecodebin2.so
aff49000 aff4a000 rwxp /usr/lib/gstreamer-0.10/libgstdecodebin2.so
aff4a000 aff8d000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
aff94000 aff95000 rwxp /usr/lib/libgstbase-0.10.so.0.30.0
aff97000 affa1000 r-xp /usr/lib/gstreamer-0.10/libgsttypefindfunctions.so
affa9000 affaa000 rwxp /usr/lib/gstreamer-0.10/libgsttypefindfunctions.so
affaa000 affdf000 r-xp /usr/lib/gstreamer-0.10/libgstcoreelements.so
affe6000 affe8000 rwxp /usr/lib/gstreamer-0.10/libgstcoreelements.so
affe8000 b0005000 rwxs /SYSV00000000
b017c000 b018d000 rwxs /SYSV00000000
b018e000 b098d000 rwxp [stack:20385]
b098d000 b0d8e000 rwxs /dev/shm/pulse-shm-713940932
b0d8f000 b158e000 rwxp [stack:20384]
b158f000 b1d8e000 rwxp [stack:20726]
b1d8f000 b258e000 rwxp [stack:20727]
b258e000 b26b4000 r-xp /usr/share/fallback_fonts/SamsungKoreanCondensed-Regular.ttf
b26b4000 b2700000 r-xp /usr/share/app_fonts/SamsungCondensed-1R.ttf
b2701000 b2f00000 rwxp [stack:20731]
b2f01000 b3700000 rwxp [stack:20728]
b3809000 b3810000 r-xs /usr/lib/gconv/gconv-modules.cache
b3810000 b384a000 r-xp /usr/share/fonts/SamsungSans_Rg.ttf
b384a000 b3859000 r-xs /opt/var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-4
b3859000 b385f000 r-xs /opt/var/cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-4
b385f000 b3862000 r-xs /opt/var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-4
b3863000 b4062000 rwxp [stack:20732]
b41e4000 b41e5000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b41ec000 b41ed000 rwxp /usr/lib/libmmfkeysound.so.0.0.0
b41ed000 b41f4000 r-xp /usr/lib/libfeedback.so.0.1.4
b41fc000 b41fd000 rwxp /usr/lib/libfeedback.so.0.1.4
b4208000 b420a000 rwxs /SYSV2019101d
b420a000 b420b000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
b4212000 b4213000 rwxp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
b4213000 b4215000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
b421c000 b421d000 rwxp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
b421d000 b421e000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
b4225000 b4226000 rwxp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
b4226000 b423d000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b4244000 b4249000 rwxp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b4249000 b4399000 r-xs /usr/share/elementary/themes/tizen-2.3-mobile-WVGA.edj
b4399000 b439d000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b43a5000 b43a6000 rwxp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b43a6000 b43b0000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b43b8000 b43b9000 rwxp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b43b9000 b44ea000 r-xp /usr/lib/locale/locale-archive
b44ea000 b46ea000 r-xp /usr/lib/locale/locale-archive
b46ea000 b46f4000 r-xp /lib/libnss_files-2.13.so
b46fb000 b46fc000 r-xp /lib/libnss_files-2.13.so
b46fc000 b46fd000 rwxp /lib/libnss_files-2.13.so
b46fd000 b47cb000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b47d3000 b47e2000 rwxp /usr/lib/libscim-1.0.so.8.2.3
b47e2000 b4806000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b480d000 b480f000 rwxp /usr/lib/ecore/immodules/libisf-imf-module.so
b480f000 b48d9000 r-xp /usr/lib/libCOREGL.so.4.0
b48e0000 b48e2000 rwxp /usr/lib/libCOREGL.so.4.0
b48f1000 b48f4000 r-xp /lib/libgpg-error.so.0.5.0
b48fb000 b48fc000 rwxp /lib/libgpg-error.so.0.5.0
b48fc000 b4954000 r-xp /usr/lib/libgcrypt.so.11.5.3
b495b000 b495e000 rwxp /usr/lib/libgcrypt.so.11.5.3
b495e000 b498a000 r-xp /usr/lib/libsystemd.so.0.0.1
b4991000 b4992000 r-xp /usr/lib/libsystemd.so.0.0.1
b4992000 b4993000 rwxp /usr/lib/libsystemd.so.0.0.1
b4994000 b49a6000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b49ad000 b49ae000 rwxp /usr/lib/libsecurity-server-commons.so.1.0.0
b49ae000 b49b2000 r-xp /usr/lib/libogg.so.0.7.1
b49b9000 b49ba000 rwxp /usr/lib/libogg.so.0.7.1
b49ba000 b49dc000 r-xp /usr/lib/libvorbis.so.0.4.3
b49e3000 b49e4000 rwxp /usr/lib/libvorbis.so.0.4.3
b49e4000 b4ac8000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4ad0000 b4adc000 rwxp /usr/lib/libvorbisenc.so.2.0.6
b4adc000 b4b0d000 r-xp /usr/lib/libFLAC.so.8.2.0
b4b15000 b4b16000 rwxp /usr/lib/libFLAC.so.8.2.0
b4b17000 b4b27000 r-xp /lib/libresolv-2.13.so
b4b27000 b4b28000 r-xp /lib/libresolv-2.13.so
b4b28000 b4b29000 rwxp /lib/libresolv-2.13.so
b4b2b000 b4b2d000 r-xp /usr/lib/libXau.so.6.0.0
b4b34000 b4b35000 rwxp /usr/lib/libXau.so.6.0.0
b4b35000 b4b3f000 r-xp /usr/lib/libspdy.so.0.0.0
b4b47000 b4b48000 rwxp /usr/lib/libspdy.so.0.0.0
b4b48000 b4b76000 r-xp /usr/lib/libidn.so.11.5.44
b4b7d000 b4b7e000 rwxp /usr/lib/libidn.so.11.5.44
b4b7f000 b4b89000 r-xp /usr/lib/libcares.so.2.1.0
b4b90000 b4b91000 rwxp /usr/lib/libcares.so.2.1.0
b4b91000 b4bb2000 r-xp /usr/lib/libexif.so.12.3.3
b4bb9000 b4bc5000 rwxp /usr/lib/libexif.so.12.3.3
b4bc5000 b4bca000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b4bd1000 b4bd2000 rwxp /usr/lib/libmmutil_jpeg.so.0.0.0
b4bd2000 b4bd7000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4bdf000 b4be0000 rwxp /usr/lib/libxcb-render.so.0.0.0
b4be1000 b4be2000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4bea000 b4beb000 rwxp /usr/lib/libxcb-shm.so.0.0.0
b4beb000 b4c03000 r-xp /usr/lib/libpng12.so.0.50.0
b4c0a000 b4c0b000 rwxp /usr/lib/libpng12.so.0.50.0
b4c0b000 b4c0e000 r-xp /usr/lib/libEGL.so.1.4
b4c15000 b4c16000 rwxp /usr/lib/libEGL.so.1.4
b4c16000 b4c24000 r-xp /usr/lib/libGLESv2.so.2.0
b4c2c000 b4c2d000 rwxp /usr/lib/libGLESv2.so.2.0
b4c2d000 b4c31000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b4c39000 b4c3a000 rwxp /usr/lib/libcapi-system-info.so.0.2.0
b4c3b000 b4c3d000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b4c44000 b4c45000 rwxp /usr/lib/journal/libjournal.so.0.1.0
b4c45000 b4c4e000 r-xp /usr/lib/libmdm-common.so.1.0.45
b4c55000 b4c56000 rwxp /usr/lib/libmdm-common.so.1.0.45
b4c56000 b55df000 r-xp /usr/lib/libicudata.so.51.1
b55e6000 b55e7000 rwxp /usr/lib/libicudata.so.51.1
b55e8000 b5634000 r-xp /usr/lib/libssl.so.1.0.0
b563c000 b5641000 rwxp /usr/lib/libssl.so.1.0.0
b5641000 b5657000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b565e000 b565f000 rwxp /usr/lib/libsecurity-server-client.so.1.0.1
b565f000 b56a4000 r-xp /usr/lib/libsndfile.so.1.0.25
b56ac000 b56ae000 rwxp /usr/lib/libsndfile.so.1.0.25
b56b2000 b56fa000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b56fa000 b56fb000 rwxp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b56fb000 b5701000 r-xp /usr/lib/libjson.so.0.1.0
b5708000 b5709000 rwxp /usr/lib/libjson.so.0.1.0
b570a000 b576b000 r-xp /usr/lib/libasound.so.2.0.0
b5772000 b5775000 rwxp /usr/lib/libasound.so.2.0.0
b5775000 b5779000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
b5780000 b5781000 rwxp /usr/lib/libascenario-0.2.so.0.0.0
b5781000 b5784000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b578c000 b578d000 rwxp /usr/lib/libpulse-simple.so.0.0.4
b578d000 b5861000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b5869000 b586c000 rwxp /usr/lib/libgio-2.0.so.0.3200.3
b586d000 b5880000 r-xp /usr/lib/libxcb.so.1.1.0
b5887000 b5888000 rwxp /usr/lib/libxcb.so.1.1.0
b5889000 b588e000 r-xp /usr/lib/libcapi-base-common.so.0.1.6
b5896000 b5897000 rwxp /usr/lib/libcapi-base-common.so.0.1.6
b5897000 b597c000 r-xp /usr/lib/libicuuc.so.51.1
b5983000 b598c000 rwxp /usr/lib/libicuuc.so.51.1
b5991000 b59c5000 r-xp /usr/lib/libicule.so.51.1
b59cc000 b59ce000 rwxp /usr/lib/libicule.so.51.1
b59ce000 b5a0b000 r-xp /usr/lib/libcurl.so.4.3.0
b5a12000 b5a14000 rwxp /usr/lib/libcurl.so.4.3.0
b5a14000 b5a1d000 r-xp /usr/lib/libethumb.so.1.7.99
b5a25000 b5a26000 rwxp /usr/lib/libethumb.so.1.7.99
b5a27000 b5a29000 r-xp /usr/lib/libctxdata.so.0.0.0
b5a30000 b5a31000 rwxp /usr/lib/libctxdata.so.0.0.0
b5a31000 b5a3e000 r-xp /usr/lib/libremix.so.0.0.0
b5a45000 b5a46000 rwxp /usr/lib/libremix.so.0.0.0
b5a46000 b5a47000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5a4e000 b5a4f000 rwxp /usr/lib/libecore_imf_evas.so.1.7.99
b5a4f000 b5a66000 r-xp /usr/lib/liblua-5.1.so
b5a6e000 b5a6f000 rwxp /usr/lib/liblua-5.1.so
b5a6f000 b5a76000 r-xp /usr/lib/libembryo.so.1.7.99
b5a7d000 b5a7e000 rwxp /usr/lib/libembryo.so.1.7.99
b5a7f000 b5aa2000 r-xp /usr/lib/libjpeg.so.8.0.2
b5aa9000 b5aaa000 rwxp /usr/lib/libjpeg.so.8.0.2
b5aba000 b5b4e000 r-xp /usr/lib/libstdc++.so.6.0.16
b5b56000 b5b59000 r-xp /usr/lib/libstdc++.so.6.0.16
b5b59000 b5b5b000 rwxp /usr/lib/libstdc++.so.6.0.16
b5b61000 b5b69000 r-xp /usr/lib/libui-extension.so.0.1.0
b5b69000 b5b6a000 rwxp /usr/lib/libui-extension.so.0.1.0
b5b6a000 b5b6d000 r-xp /usr/lib/libnative-buffer.so.0.1.0
b5b74000 b5b75000 rwxp /usr/lib/libnative-buffer.so.0.1.0
b5b75000 b5b78000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.22
b5b7f000 b5b80000 rwxp /usr/lib/libcapi-media-image-util.so.0.3.22
b5b81000 b5c37000 r-xp /usr/lib/libcairo.so.2.11200.14
b5c3f000 b5c42000 rwxp /usr/lib/libcairo.so.2.11200.14
b5c42000 b5c54000 r-xp /usr/lib/libtts.so
b5c5b000 b5c5c000 rwxp /usr/lib/libtts.so
b5c5c000 b5e03000 r-xp /usr/lib/libcrypto.so.1.0.0
b5e0b000 b5e20000 rwxp /usr/lib/libcrypto.so.1.0.0
b5e24000 b5e3a000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5e41000 b5e42000 rwxp /usr/lib/libpkgmgr_parser.so.0.1.0
b5e42000 b5e58000 r-xp /lib/libz.so.1.2.5
b5e5f000 b5e60000 rwxp /lib/libz.so.1.2.5
b5e61000 b5e77000 r-xp /lib/libexpat.so.1.5.2
b5e7e000 b5e80000 rwxp /lib/libexpat.so.1.5.2
b5e80000 b5e83000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b5e8a000 b5e8b000 rwxp /usr/lib/libecore_input_evas.so.1.7.99
b5e8b000 b5e8f000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b5e96000 b5e97000 rwxp /usr/lib/libecore_ipc.so.1.7.99
b5e97000 b5e9c000 r-xp /usr/lib/libecore_fb.so.1.7.99
b5ea3000 b5ea5000 rwxp /usr/lib/libecore_fb.so.1.7.99
b5ea5000 b5eaf000 r-xp /usr/lib/libXext.so.6.4.0
b5eb6000 b5eb7000 rwxp /usr/lib/libXext.so.6.4.0
b5eb8000 b5ebb000 r-xp /usr/lib/libXtst.so.6.1.0
b5ec2000 b5ec3000 rwxp /usr/lib/libXtst.so.6.1.0
b5ec3000 b5ec9000 r-xp /usr/lib/libXrender.so.1.3.0
b5ed0000 b5ed1000 rwxp /usr/lib/libXrender.so.1.3.0
b5ed1000 b5ed6000 r-xp /usr/lib/libXrandr.so.2.2.0
b5edd000 b5ede000 rwxp /usr/lib/libXrandr.so.2.2.0
b5ede000 b5edf000 r-xp /usr/lib/libXinerama.so.1.0.0
b5ee7000 b5ee8000 rwxp /usr/lib/libXinerama.so.1.0.0
b5ee8000 b5ef0000 r-xp /usr/lib/libXi.so.6.1.0
b5ef0000 b5ef1000 rwxp /usr/lib/libXi.so.6.1.0
b5ef1000 b5ef4000 r-xp /usr/lib/libXfixes.so.3.1.0
b5efb000 b5efc000 rwxp /usr/lib/libXfixes.so.3.1.0
b5efd000 b5eff000 r-xp /usr/lib/libXgesture.so.7.0.0
b5f06000 b5f07000 rwxp /usr/lib/libXgesture.so.7.0.0
b5f07000 b5f09000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5f10000 b5f11000 rwxp /usr/lib/libXcomposite.so.1.0.0
b5f11000 b5f12000 r-xp /usr/lib/libXdamage.so.1.1.0
b5f1a000 b5f1b000 rwxp /usr/lib/libXdamage.so.1.1.0
b5f1b000 b5f21000 r-xp /usr/lib/libXcursor.so.1.0.2
b5f29000 b5f2a000 rwxp /usr/lib/libXcursor.so.1.0.2
b5f2a000 b5f2f000 r-xp /usr/lib/libffi.so.5.0.10
b5f36000 b5f37000 rwxp /usr/lib/libffi.so.5.0.10
b5f38000 b5f39000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b5f40000 b5f41000 rwxp /usr/lib/libgthread-2.0.so.0.3200.3
b5f41000 b5f43000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b5f4a000 b5f4b000 rwxp /usr/lib/libgmodule-2.0.so.0.3200.3
b5f4b000 b608a000 r-xp /usr/lib/libicui18n.so.51.1
b6092000 b609a000 rwxp /usr/lib/libicui18n.so.51.1
b609a000 b60a0000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b60a8000 b60a9000 rwxp /usr/lib/libmmfcommon.so.0.0.0
b60a9000 b60b6000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
b60be000 b60bf000 rwxp /usr/lib/libgstinterfaces-0.10.so.0.25.0
b60c0000 b60c8000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b60cf000 b60d0000 rwxp /usr/lib/libmmutil_imgp.so.0.0.0
b60d0000 b60d2000 r-xp /usr/lib/libdri2.so.0.0.0
b60d9000 b60da000 rwxp /usr/lib/libdri2.so.0.0.0
b60da000 b60e1000 r-xp /usr/lib/libdrm.so.2.4.0
b60e9000 b60ea000 rwxp /usr/lib/libdrm.so.2.4.0
b60ea000 b60fd000 r-xp /usr/lib/libmdm.so.1.0.88
b6104000 b6105000 rwxp /usr/lib/libmdm.so.1.0.88
b6105000 b610d000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b6114000 b6115000 rwxp /usr/lib/lib_DNSe_NRSS_ver225.so
b611d000 b611f000 r-xp /usr/lib/libiniparser.so.0
b6127000 b6128000 rwxp /usr/lib/libiniparser.so.0
b6129000 b613f000 r-xp /usr/lib/lib_SamsungRec_TizenV04009.so
b6147000 b614c000 rwxp /usr/lib/lib_SamsungRec_TizenV04009.so
b616d000 b6170000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b6177000 b6178000 rwxp /usr/lib/libsyspopup_caller.so.0.1.0
b6178000 b61af000 r-xp /usr/lib/libpulse.so.0.16.2
b61b7000 b61b8000 rwxp /usr/lib/libpulse.so.0.16.2
b61b8000 b61ce000 r-xp /usr/lib/libavsysaudio.so.0.0.1
b61d5000 b61d6000 rwxp /usr/lib/libavsysaudio.so.0.0.1
b61d7000 b61de000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b61e5000 b61e6000 rwxp /usr/lib/libmmfsoundcommon.so.0.0.0
b61e6000 b61f0000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
b61f8000 b61f9000 rwxp /usr/lib/libaudio-session-mgr.so.0.0.0
b61fc000 b6201000 r-xp /usr/lib/libmmfsession.so.0.0.0
b6208000 b6209000 rwxp /usr/lib/libmmfsession.so.0.0.0
b6209000 b626e000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6275000 b6278000 rwxp /usr/lib/libsqlite3.so.0.8.6
b6278000 b627b000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6282000 b6283000 rwxp /usr/lib/libSLP-db-util.so.0.1.0
b6284000 b6289000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6291000 b6292000 rwxp /usr/lib/libxdgmime.so.1.1.0
b6292000 b62a9000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b62b1000 b62b2000 rwxp /usr/lib/libdbus-glib-1.so.2.2.2
b62b2000 b6393000 r-xp /usr/lib/libX11.so.6.3.0
b639a000 b639e000 rwxp /usr/lib/libX11.so.6.3.0
b639e000 b63a1000 r-xp /usr/lib/libsmack.so.1.0.0
b63a8000 b63a9000 rwxp /usr/lib/libsmack.so.1.0.0
b63a9000 b63ac000 r-xp /usr/lib/libbundle.so.0.1.22
b63b3000 b63b4000 rwxp /usr/lib/libbundle.so.0.1.22
b63b5000 b63bb000 r-xp /usr/lib/libappsvc.so.0.1.0
b63c2000 b63c3000 rwxp /usr/lib/libappsvc.so.0.1.0
b63c3000 b6419000 r-xp /usr/lib/libpixman-1.so.0.28.2
b6421000 b6426000 rwxp /usr/lib/libpixman-1.so.0.28.2
b6426000 b6479000 r-xp /usr/lib/libfreetype.so.6.8.1
b6480000 b6484000 rwxp /usr/lib/libfreetype.so.6.8.1
b6484000 b64ca000 r-xp /usr/lib/libharfbuzz.so.0.907.0
b64d2000 b64d3000 rwxp /usr/lib/libharfbuzz.so.0.907.0
b64d3000 b64e6000 r-xp /usr/lib/libfribidi.so.0.3.1
b64ed000 b64ee000 rwxp /usr/lib/libfribidi.so.0.3.1
b64ef000 b6508000 r-xp /usr/lib/libecore_con.so.1.7.99
b6510000 b6511000 rwxp /usr/lib/libecore_con.so.1.7.99
b6512000 b6518000 r-xp /usr/lib/libecore_imf.so.1.7.99
b651f000 b6520000 rwxp /usr/lib/libecore_imf.so.1.7.99
b6520000 b6528000 r-xp /usr/lib/libethumb_client.so.1.7.99
b652f000 b6530000 rwxp /usr/lib/libethumb_client.so.1.7.99
b6530000 b655a000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6562000 b6563000 rwxp /usr/lib/libdbus-1.so.3.7.2
b6563000 b656c000 r-xp /usr/lib/libedbus.so.1.7.99
b6573000 b6574000 rwxp /usr/lib/libedbus.so.1.7.99
b6574000 b65d1000 r-xp /usr/lib/libedje.so.1.7.99
b65d8000 b65da000 rwxp /usr/lib/libedje.so.1.7.99
b65db000 b65ec000 r-xp /usr/lib/libecore_input.so.1.7.99
b65f3000 b65f4000 rwxp /usr/lib/libecore_input.so.1.7.99
b65f4000 b65f9000 r-xp /usr/lib/libecore_file.so.1.7.99
b6600000 b6601000 rwxp /usr/lib/libecore_file.so.1.7.99
b6601000 b661a000 r-xp /usr/lib/libeet.so.1.7.99
b6622000 b6623000 rwxp /usr/lib/libeet.so.1.7.99
b662b000 b6694000 r-xp /lib/libm-2.13.so
b669b000 b669c000 r-xp /lib/libm-2.13.so
b669c000 b669d000 rwxp /lib/libm-2.13.so
b669d000 b66a3000 r-xp /lib/librt-2.13.so
b66aa000 b66ab000 r-xp /lib/librt-2.13.so
b66ab000 b66ac000 rwxp /lib/librt-2.13.so
b66ad000 b66c3000 r-xp /usr/lib/libefl-assist.so.0.1.0
b66ca000 b66cb000 rwxp /usr/lib/libefl-assist.so.0.1.0
b66cb000 b66ea000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b66f1000 b66f2000 rwxp /usr/lib/libpkgmgr-info.so.0.0.17
b66f2000 b67bd000 r-xp /usr/lib/libxml2.so.2.7.8
b67c5000 b67ca000 rwxp /usr/lib/libxml2.so.2.7.8
b67cb000 b67f3000 r-xp /usr/lib/libfontconfig.so.1.8.0
b67f3000 b67f4000 rwxp /usr/lib/libfontconfig.so.1.8.0
b67f4000 b67fb000 r-xp /usr/lib/libvconf.so.0.2.45
b6803000 b6804000 rwxp /usr/lib/libvconf.so.0.2.45
b6805000 b6826000 r-xp /usr/lib/libecore_evas.so.1.7.99
b682d000 b682f000 rwxp /usr/lib/libecore_evas.so.1.7.99
b682f000 b685e000 r-xp /usr/lib/libecore_x.so.1.7.99
b6866000 b6868000 rwxp /usr/lib/libecore_x.so.1.7.99
b6868000 b6938000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6938000 b6939000 rwxp /usr/lib/libglib-2.0.so.0.3200.3
b6939000 b696d000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b6974000 b6976000 rwxp /usr/lib/libgobject-2.0.so.0.3200.3
b6976000 b6a11000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
b6a19000 b6a1c000 rwxp /usr/lib/libgstreamer-0.10.so.0.30.0
b6a1e000 b6a21000 r-xp /usr/lib/libmm_ta.so.0.0.0
b6a28000 b6a29000 rwxp /usr/lib/libmm_ta.so.0.0.0
b6a29000 b6a75000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b6a7c000 b6a7d000 rwxp /usr/lib/libmmfplayer.so.0.0.0
b6a7d000 b6a84000 r-xp /usr/lib/libtbm.so.1.0.0
b6a8b000 b6a8c000 rwxp /usr/lib/libtbm.so.1.0.0
b6a8c000 b6a91000 r-xp /usr/lib/libcapi-media-tool.so.0.1.3
b6a98000 b6a99000 rwxp /usr/lib/libcapi-media-tool.so.0.1.3
b6a99000 b6aad000 r-xp /usr/lib/libmmfsound.so.0.1.0
b6ab5000 b6ab6000 rwxp /usr/lib/libmmfsound.so.0.1.0
b6ab6000 b6aca000 r-xp /lib/libpthread-2.13.so
b6ad1000 b6ad2000 r-xp /lib/libpthread-2.13.so
b6ad2000 b6ad3000 rwxp /lib/libpthread-2.13.so
b6ad5000 b6b15000 r-xp /usr/lib/libeina.so.1.7.99
b6b1c000 b6b1d000 rwxp /usr/lib/libeina.so.1.7.99
b6b1e000 b6b2c000 r-xp /usr/lib/libail.so.0.1.0
b6b33000 b6b34000 rwxp /usr/lib/libail.so.0.1.0
b6b34000 b6b3f000 r-xp /usr/lib/libaul.so.0.1.0
b6b47000 b6b48000 rwxp /usr/lib/libaul.so.0.1.0
b6b49000 b6b4d000 r-xp /usr/lib/libappcore-common.so.1.1
b6b54000 b6b55000 rwxp /usr/lib/libappcore-common.so.1.1
b6b55000 b6b58000 r-xp /usr/lib/libappcore-efl.so.1.1
b6b60000 b6b61000 rwxp /usr/lib/libappcore-efl.so.1.1
b6b61000 b6b66000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b6b6d000 b6b6e000 rwxp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b6b6e000 b6b70000 r-xp /lib/libdl-2.13.so
b6b77000 b6b78000 r-xp /lib/libdl-2.13.so
b6b78000 b6b79000 rwxp /lib/libdl-2.13.so
b6b79000 b6b84000 r-xp /lib/libunwind.so.8.0.1
b6b8b000 b6b8c000 rwxp /lib/libunwind.so.8.0.1
b6bb1000 b6ccc000 r-xp /lib/libc-2.13.so
b6cd4000 b6cd6000 r-xp /lib/libc-2.13.so
b6cd6000 b6cd7000 rwxp /lib/libc-2.13.so
b6cda000 b6ce2000 r-xp /lib/libgcc_s-4.6.4.so.1
b6ce9000 b6cea000 rwxp /lib/libgcc_s-4.6.4.so.1
b6cea000 b6cec000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.3
b6cf4000 b6cf5000 rwxp /usr/lib/libcapi-appfw-app-common.so.0.3.1.3
b6cf5000 b6cf7000 r-xp /usr/lib/libefl-extension.so.0.1.0
b6cfe000 b6cff000 rwxp /usr/lib/libefl-extension.so.0.1.0
b6cff000 b6dc6000 r-xp /usr/lib/libevas.so.1.7.99
b6dce000 b6dd8000 rwxp /usr/lib/libevas.so.1.7.99
b6deb000 b6f22000 r-xp /usr/lib/libelementary.so.1.7.99
b6f29000 b6f31000 rwxp /usr/lib/libelementary.so.1.7.99
b6f38000 b6f4e000 r-xp /usr/lib/libecore.so.1.7.99
b6f55000 b6f56000 rwxp /usr/lib/libecore.so.1.7.99
b6f64000 b6f66000 r-xp /usr/lib/libdlog.so.0.0.0
b6f6d000 b6f6e000 rwxp /usr/lib/libdlog.so.0.0.0
b6f6e000 b6f75000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.4
b6f7d000 b6f7e000 rwxp /usr/lib/libcapi-system-system-settings.so.0.0.4
b6f7e000 b6f96000 r-xp /usr/lib/libcapi-media-player.so.0.1.75
b6f9d000 b6f9e000 rwxp /usr/lib/libcapi-media-player.so.0.1.75
b6f9e000 b6fa4000 r-xp /usr/lib/libcapi-media-audio-io.so.0.2.31
b6fab000 b6fac000 rwxp /usr/lib/libcapi-media-audio-io.so.0.2.31
b6fac000 b6fb0000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.3
b6fb7000 b6fb8000 rwxp /usr/lib/libcapi-appfw-application.so.0.3.1.3
b6fb8000 b6fba000 r-xp /usr/share/locale/ko_KR/LC_MESSAGES/elementary.mo
b6fba000 b6fc4000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
b6fcc000 b6fcd000 rwxp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
b6fcd000 b6fd1000 r-xp /usr/lib/libsys-assert.so
b6fd9000 b6fda000 rwxp /usr/lib/libsys-assert.so
b6fda000 b6ff7000 r-xp /lib/ld-2.13.so
b6ffe000 b6fff000 r-xp /lib/ld-2.13.so
b6fff000 b7000000 rwxp /lib/ld-2.13.so
befdf000 bf000000 rwxp [stack]
b6fcc000 b6fcd000 rwxp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
b6fcd000 b6fd1000 r-xp /usr/lib/libsys-assert.so
b6fd9000 b6fda000 rwxp /usr/lib/libsys-assert.so
b6fda000 b6ff7000 r-xp /lib/ld-2.13.so
b6ffe000 b6fff000 r-xp /lib/ld-2.13.so
b6fff000 b7000000 rwxp /lib/ld-2.13.so
befdf000 bf000000 rwxp [stack]
End of Maps Information

Callstack Information (PID:20331)
Call Stack Count: 5
 0: strchrnul + 0x14 (0xb6c285d8) [/lib/libc.so.6] + 0x775d8
 1: _IO_vfprintf + 0x98 (0xb6bedf5c) [/lib/libc.so.6] + 0x3cf5c
 2: __vsnprintf_chk + 0xa0 (0xb6c88c68) [/lib/libc.so.6] + 0xd7c68
 3: dlog_print + 0x42 (0xb6f65063) [/usr/lib/libdlog.so.0] + 0x1063
 4: statsInput + 0x72 (0x2a0049d3) [/opt/usr/apps/org.samteam.perfectsong/bin/paaaaaaaaa] + 0x49d3
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
 note : 52 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:26:55.280+0900 E/record  (20331): !! interval
08-13 23:26:55.330+0900 F/record  (20331): ===next node===
08-13 23:26:55.330+0900 I/record  (20331): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:26:55.330+0900 E/record  (20331): !! interval
08-13 23:26:55.380+0900 I/record  (20331): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:26:55.380+0900 E/record  (20331): !! interval
08-13 23:26:55.430+0900 I/record  (20331): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:26:55.430+0900 E/record  (20331): !! interval
08-13 23:26:55.480+0900 I/record  (20331): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:26:55.490+0900 E/record  (20331): !! interval
08-13 23:26:55.530+0900 I/record  (20331): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:26:55.540+0900 E/record  (20331): !! interval
08-13 23:26:55.580+0900 I/record  (20331): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:26:55.590+0900 E/record  (20331): !! interval
08-13 23:26:55.630+0900 F/record  (20331): ===next node===
08-13 23:26:55.630+0900 I/record  (20331): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:26:55.640+0900 E/record  (20331): !! interval
08-13 23:26:55.690+0900 I/record  (20331): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:26:55.690+0900 E/record  (20331): !! interval
08-13 23:26:55.750+0900 I/record  (20331): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:26:55.760+0900 E/record  (20331): !! interval
08-13 23:26:55.810+0900 I/record  (20331): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:26:55.810+0900 E/record  (20331): !! interval
08-13 23:26:55.860+0900 I/record  (20331): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:26:55.860+0900 E/record  (20331): !! interval
08-13 23:26:55.910+0900 I/record  (20331): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:26:55.910+0900 E/record  (20331): !! interval
08-13 23:26:55.960+0900 I/record  (20331): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:26:55.960+0900 E/record  (20331): !! interval
08-13 23:26:56.090+0900 I/record  (20331): note : 48 detect :97 isHit : -1 [0: 1071644672/-1393055228]
08-13 23:26:56.150+0900 I/record  (20331): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:26:56.160+0900 E/record  (20331): !! interval
08-13 23:26:56.210+0900 F/record  (20331): ===next node===
08-13 23:26:56.210+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:56.260+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:56.330+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:56.390+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:56.450+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:56.500+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:56.550+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:56.610+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:56.670+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:56.720+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:56.770+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:56.830+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:56.880+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:56.940+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:56.990+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:57.050+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:57.100+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:57.160+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:57.210+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:57.270+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:57.320+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:57.380+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:57.440+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:57.500+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:57.550+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:57.610+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:57.660+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:57.720+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:57.770+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:57.830+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:57.880+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:57.940+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:57.990+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:58.040+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:58.090+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:58.150+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:58.200+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:58.250+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:58.300+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:58.350+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:58.410+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:58.470+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:58.520+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:58.570+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:58.630+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:58.690+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:58.750+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:58.810+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:58.860+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:58.910+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:58.960+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:59.010+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:59.070+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:59.120+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:59.170+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:59.220+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:59.280+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:59.330+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:59.380+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:59.430+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:59.480+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:59.540+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:59.590+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:59.650+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:59.710+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:59.760+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:59.810+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:59.860+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:59.920+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:26:59.980+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:27:00.040+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:27:00.090+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:27:00.140+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:27:00.200+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:27:00.260+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:27:00.320+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:27:00.370+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:27:00.520+0900 I/record  (20331): note : 55 detect :89 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:27:00.570+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:27:00.730+0900 I/record  (20331): note : 55 detect :103 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:27:00.780+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:27:00.840+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:27:00.890+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:27:00.940+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:27:01.080+0900 I/record  (20331): note : 55 detect :74 isHit : -1 [0: 1071644672/-1393055228]
08-13 23:27:01.140+0900 I/record  (20331): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:01.140+0900 E/record  (20331): !! interval
08-13 23:27:01.190+0900 I/record  (20331): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:01.190+0900 E/record  (20331): !! interval
08-13 23:27:01.240+0900 I/record  (20331): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:01.240+0900 E/record  (20331): !! interval
08-13 23:27:01.290+0900 F/record  (20331): ===next node===
08-13 23:27:01.290+0900 I/record  (20331): note : 52 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:27:01.350+0900 I/record  (20331): note : 52 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:27:01.400+0900 I/record  (20331): note : 52 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:27:01.450+0900 I/record  (20331): note : 52 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:27:01.500+0900 I/record  (20331): note : 52 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:27:01.560+0900 I/record  (20331): note : 52 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:27:01.610+0900 I/record  (20331): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:01.610+0900 E/record  (20331): !! interval
08-13 23:27:01.660+0900 I/record  (20331): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:01.660+0900 E/record  (20331): !! interval
08-13 23:27:01.720+0900 I/record  (20331): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:01.720+0900 E/record  (20331): !! interval
08-13 23:27:01.770+0900 I/record  (20331): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:01.770+0900 E/record  (20331): !! interval
08-13 23:27:01.820+0900 I/record  (20331): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:01.820+0900 E/record  (20331): !! interval
08-13 23:27:01.870+0900 I/record  (20331): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:01.870+0900 E/record  (20331): !! interval
08-13 23:27:01.930+0900 F/record  (20331): ===next node===
08-13 23:27:01.930+0900 I/record  (20331): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:01.930+0900 E/record  (20331): !! interval
08-13 23:27:01.990+0900 I/record  (20331): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:01.990+0900 E/record  (20331): !! interval
08-13 23:27:02.040+0900 I/record  (20331): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:02.040+0900 E/record  (20331): !! interval
08-13 23:27:02.090+0900 I/record  (20331): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:02.090+0900 E/record  (20331): !! interval
08-13 23:27:02.150+0900 I/record  (20331): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:02.150+0900 E/record  (20331): !! interval
08-13 23:27:02.200+0900 F/record  (20331): ===next node===
08-13 23:27:02.200+0900 I/record  (20331): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:02.200+0900 E/record  (20331): !! interval
08-13 23:27:02.250+0900 I/record  (20331): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:02.250+0900 E/record  (20331): !! interval
08-13 23:27:02.300+0900 I/record  (20331): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:02.300+0900 E/record  (20331): !! interval
08-13 23:27:02.350+0900 I/record  (20331): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:02.350+0900 E/record  (20331): !! interval
08-13 23:27:02.400+0900 I/record  (20331): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:02.400+0900 E/record  (20331): !! interval
08-13 23:27:02.460+0900 I/record  (20331): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:02.460+0900 E/record  (20331): !! interval
08-13 23:27:02.520+0900 F/record  (20331): ===next node===
08-13 23:27:02.520+0900 I/record  (20331): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:02.520+0900 E/record  (20331): !! interval
08-13 23:27:02.570+0900 I/record  (20331): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:02.570+0900 E/record  (20331): !! interval
08-13 23:27:02.620+0900 I/record  (20331): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:02.620+0900 E/record  (20331): !! interval
08-13 23:27:02.680+0900 I/record  (20331): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:02.680+0900 E/record  (20331): !! interval
08-13 23:27:02.730+0900 I/record  (20331): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:02.730+0900 E/record  (20331): !! interval
08-13 23:27:02.780+0900 I/record  (20331): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:02.790+0900 E/record  (20331): !! interval
08-13 23:27:02.830+0900 F/record  (20331): ===next node===
08-13 23:27:02.830+0900 I/record  (20331): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:02.840+0900 E/record  (20331): !! interval
08-13 23:27:02.890+0900 I/record  (20331): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:02.890+0900 E/record  (20331): !! interval
08-13 23:27:02.950+0900 I/record  (20331): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:02.950+0900 E/record  (20331): !! interval
08-13 23:27:03.000+0900 I/record  (20331): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:03.000+0900 E/record  (20331): !! interval
08-13 23:27:03.050+0900 I/record  (20331): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:03.050+0900 E/record  (20331): !! interval
08-13 23:27:03.100+0900 F/record  (20331): ===next node===
08-13 23:27:03.100+0900 I/record  (20331): note : 50 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:27:03.220+0900 I/record  (20331): note : 50 detect :97 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:27:03.280+0900 I/record  (20331): note : 50 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:27:03.340+0900 I/record  (20331): note : 50 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:27:03.390+0900 I/record  (20331): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:03.390+0900 E/record  (20331): !! interval
08-13 23:27:03.450+0900 I/record  (20331): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:03.450+0900 E/record  (20331): !! interval
08-13 23:27:03.500+0900 I/record  (20331): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:03.500+0900 E/record  (20331): !! interval
08-13 23:27:03.560+0900 I/record  (20331): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:03.560+0900 E/record  (20331): !! interval
08-13 23:27:03.620+0900 I/record  (20331): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:03.620+0900 E/record  (20331): !! interval
08-13 23:27:03.670+0900 I/record  (20331): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:03.670+0900 E/record  (20331): !! interval
08-13 23:27:03.730+0900 F/record  (20331): ===next node===
08-13 23:27:03.730+0900 I/record  (20331): note : 52 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:27:03.780+0900 I/record  (20331): note : 52 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:27:03.840+0900 I/record  (20331): note : 52 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:27:03.900+0900 I/record  (20331): note : 52 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:27:03.950+0900 I/record  (20331): note : 52 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:27:04.010+0900 I/record  (20331): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:04.010+0900 E/record  (20331): !! interval
08-13 23:27:04.060+0900 I/record  (20331): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:04.060+0900 E/record  (20331): !! interval
08-13 23:27:04.110+0900 I/record  (20331): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:04.110+0900 E/record  (20331): !! interval
08-13 23:27:04.160+0900 I/record  (20331): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:04.160+0900 E/record  (20331): !! interval
08-13 23:27:04.210+0900 I/record  (20331): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:04.210+0900 E/record  (20331): !! interval
08-13 23:27:04.260+0900 I/record  (20331): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:04.260+0900 E/record  (20331): !! interval
08-13 23:27:04.320+0900 F/record  (20331): ===next node===
08-13 23:27:04.320+0900 I/record  (20331): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:04.320+0900 E/record  (20331): !! interval
08-13 23:27:04.380+0900 I/record  (20331): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:04.380+0900 E/record  (20331): !! interval
08-13 23:27:04.430+0900 I/record  (20331): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:04.430+0900 E/record  (20331): !! interval
08-13 23:27:04.480+0900 I/record  (20331): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:04.480+0900 E/record  (20331): !! interval
08-13 23:27:04.530+0900 I/record  (20331): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:04.530+0900 E/record  (20331): !! interval
08-13 23:27:04.590+0900 F/record  (20331): ===next node===
08-13 23:27:04.590+0900 I/record  (20331): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:04.590+0900 E/record  (20331): !! interval
08-13 23:27:04.640+0900 I/record  (20331): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:04.640+0900 E/record  (20331): !! interval
08-13 23:27:04.690+0900 I/record  (20331): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:04.690+0900 E/record  (20331): !! interval
08-13 23:27:04.740+0900 I/record  (20331): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:04.750+0900 E/record  (20331): !! interval
08-13 23:27:04.800+0900 I/record  (20331): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:04.800+0900 E/record  (20331): !! interval
08-13 23:27:04.850+0900 I/record  (20331): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:04.860+0900 E/record  (20331): !! interval
08-13 23:27:04.910+0900 F/record  (20331): ===next node===
08-13 23:27:04.910+0900 I/record  (20331): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:04.910+0900 E/record  (20331): !! interval
08-13 23:27:04.960+0900 I/record  (20331): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:04.960+0900 E/record  (20331): !! interval
08-13 23:27:05.010+0900 I/record  (20331): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:05.010+0900 E/record  (20331): !! interval
08-13 23:27:05.070+0900 I/record  (20331): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:05.070+0900 E/record  (20331): !! interval
08-13 23:27:05.120+0900 I/record  (20331): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:05.120+0900 E/record  (20331): !! interval
08-13 23:27:05.170+0900 I/record  (20331): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:05.170+0900 E/record  (20331): !! interval
08-13 23:27:05.220+0900 F/record  (20331): ===next node===
08-13 23:27:05.220+0900 I/record  (20331): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:05.230+0900 E/record  (20331): !! interval
08-13 23:27:05.280+0900 I/record  (20331): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:05.280+0900 E/record  (20331): !! interval
08-13 23:27:05.330+0900 I/record  (20331): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:05.330+0900 E/record  (20331): !! interval
08-13 23:27:05.390+0900 I/record  (20331): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:05.390+0900 E/record  (20331): !! interval
08-13 23:27:05.440+0900 I/record  (20331): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:05.440+0900 E/record  (20331): !! interval
08-13 23:27:05.490+0900 F/record  (20331): ===next node===
08-13 23:27:05.490+0900 I/record  (20331): note : 60 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:27:05.540+0900 I/record  (20331): note : 60 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:27:05.600+0900 I/record  (20331): note : 60 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:27:05.650+0900 I/record  (20331): note : 60 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:27:05.710+0900 I/record  (20331): note : 60 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:27:05.760+0900 I/record  (20331): note : 60 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:27:05.810+0900 I/record  (20331): note : 60 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:05.810+0900 E/record  (20331): !! interval
08-13 23:27:05.860+0900 I/record  (20331): note : 60 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:05.860+0900 E/record  (20331): !! interval
08-13 23:27:05.910+0900 I/record  (20331): note : 60 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:05.910+0900 E/record  (20331): !! interval
08-13 23:27:05.960+0900 I/record  (20331): note : 60 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:05.960+0900 E/record  (20331): !! interval
08-13 23:27:06.010+0900 I/record  (20331): note : 60 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:06.010+0900 E/record  (20331): !! interval
08-13 23:27:06.070+0900 I/record  (20331): note : 60 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:06.070+0900 E/record  (20331): !! interval
08-13 23:27:06.120+0900 I/record  (20331): note : 60 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:06.120+0900 E/record  (20331): !! interval
08-13 23:27:06.180+0900 I/record  (20331): note : 60 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:06.180+0900 E/record  (20331): !! interval
08-13 23:27:06.230+0900 I/record  (20331): note : 60 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:06.230+0900 E/record  (20331): !! interval
08-13 23:27:06.280+0900 F/record  (20331): ===next node===
08-13 23:27:06.280+0900 I/record  (20331): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:06.280+0900 E/record  (20331): !! interval
08-13 23:27:06.330+0900 I/record  (20331): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:06.340+0900 E/record  (20331): !! interval
08-13 23:27:06.390+0900 F/record  (20331): ===next node===
08-13 23:27:06.390+0900 I/record  (20331): note : 60 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:06.390+0900 E/record  (20331): !! interval
08-13 23:27:06.450+0900 I/record  (20331): note : 60 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:06.450+0900 E/record  (20331): !! interval
08-13 23:27:06.510+0900 I/record  (20331): note : 60 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:06.510+0900 E/record  (20331): !! interval
08-13 23:27:06.560+0900 I/record  (20331): note : 60 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:06.570+0900 E/record  (20331): !! interval
08-13 23:27:06.620+0900 I/record  (20331): note : 60 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:06.620+0900 E/record  (20331): !! interval
08-13 23:27:06.670+0900 I/record  (20331): note : 60 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:06.670+0900 E/record  (20331): !! interval
08-13 23:27:06.730+0900 I/record  (20331): note : 60 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:06.730+0900 E/record  (20331): !! interval
08-13 23:27:06.790+0900 I/record  (20331): note : 60 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:06.790+0900 E/record  (20331): !! interval
08-13 23:27:06.850+0900 F/record  (20331): ===next node===
08-13 23:27:06.850+0900 I/record  (20331): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:06.850+0900 E/record  (20331): !! interval
08-13 23:27:06.910+0900 I/record  (20331): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:06.910+0900 E/record  (20331): !! interval
08-13 23:27:06.970+0900 I/record  (20331): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:06.970+0900 E/record  (20331): !! interval
08-13 23:27:07.020+0900 F/record  (20331): ===next node===
08-13 23:27:07.020+0900 I/record  (20331): note : 60 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:07.020+0900 E/record  (20331): !! interval
08-13 23:27:07.070+0900 I/record  (20331): note : 60 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:07.070+0900 E/record  (20331): !! interval
08-13 23:27:07.120+0900 I/record  (20331): note : 60 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:07.120+0900 E/record  (20331): !! interval
08-13 23:27:07.170+0900 I/record  (20331): note : 60 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:07.170+0900 E/record  (20331): !! interval
08-13 23:27:07.220+0900 I/record  (20331): note : 60 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:07.220+0900 E/record  (20331): !! interval
08-13 23:27:07.280+0900 I/record  (20331): note : 60 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:07.280+0900 E/record  (20331): !! interval
08-13 23:27:07.330+0900 F/record  (20331): ===next node===
08-13 23:27:07.330+0900 I/record  (20331): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:07.330+0900 E/record  (20331): !! interval
08-13 23:27:07.390+0900 I/record  (20331): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:07.390+0900 E/record  (20331): !! interval
08-13 23:27:07.440+0900 I/record  (20331): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:07.440+0900 E/record  (20331): !! interval
08-13 23:27:07.500+0900 I/record  (20331): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:07.500+0900 E/record  (20331): !! interval
08-13 23:27:07.550+0900 I/record  (20331): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:07.550+0900 E/record  (20331): !! interval
08-13 23:27:07.610+0900 F/record  (20331): ===next node===
08-13 23:27:07.610+0900 I/record  (20331): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:07.610+0900 E/record  (20331): !! interval
08-13 23:27:07.660+0900 I/record  (20331): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:07.660+0900 E/record  (20331): !! interval
08-13 23:27:07.720+0900 I/record  (20331): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:07.720+0900 E/record  (20331): !! interval
08-13 23:27:07.770+0900 I/record  (20331): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:07.770+0900 E/record  (20331): !! interval
08-13 23:27:07.820+0900 I/record  (20331): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:07.820+0900 E/record  (20331): !! interval
08-13 23:27:07.880+0900 I/record  (20331): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:07.880+0900 E/record  (20331): !! interval
08-13 23:27:07.940+0900 F/record  (20331): ===next node===
08-13 23:27:07.940+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:27:08.000+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:27:08.060+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:27:08.120+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:27:08.170+0900 I/record  (20331): note : 55 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:27:08.230+0900 I/record  (20331): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:08.230+0900 E/record  (20331): !! interval
08-13 23:27:08.280+0900 I/record  (20331): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:08.280+0900 E/record  (20331): !! interval
08-13 23:27:08.340+0900 I/record  (20331): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:08.340+0900 E/record  (20331): !! interval
08-13 23:27:08.390+0900 I/record  (20331): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:08.400+0900 E/record  (20331): !! interval
08-13 23:27:08.450+0900 I/record  (20331): note : 55 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:08.450+0900 E/record  (20331): !! interval
08-13 23:27:08.500+0900 F/record  (20331): ===next node===
08-13 23:27:08.500+0900 I/record  (20331): note : 50 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:27:08.550+0900 I/record  (20331): note : 50 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:27:08.610+0900 I/record  (20331): note : 50 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:27:08.660+0900 I/record  (20331): note : 50 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:27:08.710+0900 I/record  (20331): note : 50 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:27:08.760+0900 I/record  (20331): note : 50 detect :21 isHit : 3 [0: 1071644672/-1393055228]
08-13 23:27:08.820+0900 I/record  (20331): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:08.820+0900 E/record  (20331): !! interval
08-13 23:27:08.880+0900 I/record  (20331): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:08.880+0900 E/record  (20331): !! interval
08-13 23:27:08.930+0900 I/record  (20331): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:08.930+0900 E/record  (20331): !! interval
08-13 23:27:08.980+0900 I/record  (20331): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:08.980+0900 E/record  (20331): !! interval
08-13 23:27:09.030+0900 I/record  (20331): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:09.030+0900 E/record  (20331): !! interval
08-13 23:27:09.080+0900 I/record  (20331): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:09.080+0900 E/record  (20331): !! interval
08-13 23:27:09.140+0900 F/record  (20331): ===next node===
08-13 23:27:09.140+0900 I/record  (20331): note : 53 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:09.140+0900 E/record  (20331): !! interval
08-13 23:27:09.200+0900 I/record  (20331): note : 53 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:09.200+0900 E/record  (20331): !! interval
08-13 23:27:09.260+0900 I/record  (20331): note : 53 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:09.260+0900 E/record  (20331): !! interval
08-13 23:27:09.320+0900 I/record  (20331): note : 53 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:09.320+0900 E/record  (20331): !! interval
08-13 23:27:09.380+0900 I/record  (20331): note : 53 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:09.380+0900 E/record  (20331): !! interval
08-13 23:27:09.430+0900 F/record  (20331): ===next node===
08-13 23:27:09.430+0900 I/record  (20331): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:09.430+0900 E/record  (20331): !! interval
08-13 23:27:09.480+0900 I/record  (20331): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:09.480+0900 E/record  (20331): !! interval
08-13 23:27:09.610+0900 I/record  (20331): note : 52 detect :86 isHit : -1 [0: 1071644672/-1393055228]
08-13 23:27:09.660+0900 I/record  (20331): note : 52 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:09.670+0900 E/record  (20331): !! interval
08-13 23:27:09.720+0900 F/record  (20331): ===next node===
08-13 23:27:09.720+0900 I/record  (20331): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:09.720+0900 E/record  (20331): !! interval
08-13 23:27:09.770+0900 I/record  (20331): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:09.770+0900 E/record  (20331): !! interval
08-13 23:27:09.820+0900 I/record  (20331): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:09.840+0900 E/record  (20331): !! interval
08-13 23:27:09.880+0900 I/record  (20331): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:09.890+0900 E/record  (20331): !! interval
08-13 23:27:09.930+0900 I/record  (20331): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:09.930+0900 E/record  (20331): !! interval
08-13 23:27:09.980+0900 I/record  (20331): note : 50 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:09.990+0900 E/record  (20331): !! interval
08-13 23:27:10.040+0900 F/record  (20331): ===next node===
08-13 23:27:10.040+0900 I/record  (20331): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:10.040+0900 E/record  (20331): !! interval
08-13 23:27:10.090+0900 I/record  (20331): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:10.100+0900 E/record  (20331): !! interval
08-13 23:27:10.140+0900 I/record  (20331): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:10.160+0900 E/record  (20331): !! interval
08-13 23:27:10.200+0900 I/record  (20331): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:10.200+0900 E/record  (20331): !! interval
08-13 23:27:10.250+0900 I/record  (20331): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:10.260+0900 E/record  (20331): !! interval
08-13 23:27:10.300+0900 I/record  (20331): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:10.300+0900 E/record  (20331): !! interval
08-13 23:27:10.360+0900 I/record  (20331): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:10.370+0900 E/record  (20331): !! interval
08-13 23:27:10.420+0900 I/record  (20331): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:10.420+0900 E/record  (20331): !! interval
08-13 23:27:10.470+0900 I/record  (20331): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:10.470+0900 E/record  (20331): !! interval
08-13 23:27:10.520+0900 I/record  (20331): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:10.520+0900 E/record  (20331): !! interval
08-13 23:27:10.570+0900 I/record  (20331): note : 48 detect :21 isHit : -2 [0: 1071644672/-1393055228]
08-13 23:27:10.590+0900 E/record  (20331): !! interval
08-13 23:27:11.280+0900 I/CAPI_APPFW_APPLICATION(  700): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:11.280+0900 I/CAPI_APPFW_APPLICATION(20447): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:11.280+0900 I/CAPI_APPFW_APPLICATION(20331): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:11.280+0900 I/CAPI_APPFW_APPLICATION(17310): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:11.280+0900 W/CAM_APP (17310): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-13 23:27:11.580+0900 I/CAPI_APPFW_APPLICATION(20447): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:11.580+0900 I/CAPI_APPFW_APPLICATION(20331): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:11.580+0900 I/CAPI_APPFW_APPLICATION(17310): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:11.580+0900 I/CAPI_APPFW_APPLICATION(  700): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:11.590+0900 W/CAM_APP (17310): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-13 23:27:11.760+0900 I/CAPI_APPFW_APPLICATION(20331): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:11.760+0900 I/CAPI_APPFW_APPLICATION(20447): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:11.760+0900 I/CAPI_APPFW_APPLICATION(17310): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:11.760+0900 I/CAPI_APPFW_APPLICATION(  700): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:11.760+0900 W/CAM_APP (17310): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-13 23:27:11.820+0900 I/CAPI_APPFW_APPLICATION(20447): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:11.820+0900 I/CAPI_APPFW_APPLICATION(20331): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:11.820+0900 I/CAPI_APPFW_APPLICATION(17310): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:11.820+0900 I/CAPI_APPFW_APPLICATION(  700): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:11.830+0900 W/CAM_APP (17310): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-13 23:27:11.880+0900 I/CAPI_APPFW_APPLICATION(20447): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:11.880+0900 I/CAPI_APPFW_APPLICATION(20331): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:11.880+0900 I/CAPI_APPFW_APPLICATION(17310): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:11.880+0900 I/CAPI_APPFW_APPLICATION(  700): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:11.880+0900 W/CAM_APP (17310): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-13 23:27:11.940+0900 I/CAPI_APPFW_APPLICATION(20331): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:11.940+0900 I/CAPI_APPFW_APPLICATION(20447): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:11.940+0900 I/CAPI_APPFW_APPLICATION(17310): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:11.940+0900 I/CAPI_APPFW_APPLICATION(  700): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:11.950+0900 W/CAM_APP (17310): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-13 23:27:12.000+0900 I/CAPI_APPFW_APPLICATION(20447): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:12.000+0900 I/CAPI_APPFW_APPLICATION(20331): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:12.000+0900 I/CAPI_APPFW_APPLICATION(17310): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:12.000+0900 I/CAPI_APPFW_APPLICATION(  700): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:12.000+0900 W/CAM_APP (17310): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-13 23:27:20.180+0900 I/CAPI_APPFW_APPLICATION(20447): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:20.180+0900 I/CAPI_APPFW_APPLICATION(17310): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:20.180+0900 I/CAPI_APPFW_APPLICATION(  700): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:20.180+0900 W/CAM_APP (17310): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-13 23:27:20.240+0900 I/CAPI_APPFW_APPLICATION(20447): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:20.240+0900 I/CAPI_APPFW_APPLICATION(17310): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:20.240+0900 I/CAPI_APPFW_APPLICATION(  700): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:20.240+0900 W/CAM_APP (17310): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-13 23:27:20.780+0900 I/CAPI_APPFW_APPLICATION(20447): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:20.780+0900 I/CAPI_APPFW_APPLICATION(17310): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:20.780+0900 I/CAPI_APPFW_APPLICATION(  700): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:20.780+0900 W/CAM_APP (17310): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-13 23:27:20.840+0900 I/CAPI_APPFW_APPLICATION(20447): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:20.840+0900 I/CAPI_APPFW_APPLICATION(17310): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:20.840+0900 I/CAPI_APPFW_APPLICATION(  700): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:20.840+0900 W/CAM_APP (17310): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-13 23:27:21.020+0900 I/CAPI_APPFW_APPLICATION(20447): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:21.020+0900 I/CAPI_APPFW_APPLICATION(17310): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:21.020+0900 I/CAPI_APPFW_APPLICATION(  700): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:21.020+0900 W/CAM_APP (17310): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-13 23:27:21.080+0900 I/CAPI_APPFW_APPLICATION(20447): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:21.080+0900 I/CAPI_APPFW_APPLICATION(17310): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:21.080+0900 I/CAPI_APPFW_APPLICATION(  700): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:21.080+0900 W/CAM_APP (17310): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-13 23:27:21.210+0900 I/CAPI_APPFW_APPLICATION(20447): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:21.210+0900 I/CAPI_APPFW_APPLICATION(17310): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:21.210+0900 I/CAPI_APPFW_APPLICATION(  700): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:21.210+0900 W/CAM_APP (17310): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-13 23:27:21.450+0900 I/CAPI_APPFW_APPLICATION(20447): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:21.450+0900 I/CAPI_APPFW_APPLICATION(17310): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:21.450+0900 I/CAPI_APPFW_APPLICATION(  700): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:21.450+0900 W/CAM_APP (17310): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-13 23:27:21.510+0900 I/CAPI_APPFW_APPLICATION(20447): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:21.510+0900 I/CAPI_APPFW_APPLICATION(17310): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:21.510+0900 I/CAPI_APPFW_APPLICATION(  700): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:21.510+0900 W/CAM_APP (17310): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-13 23:27:26.390+0900 I/CAPI_APPFW_APPLICATION(20447): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:26.390+0900 I/CAPI_APPFW_APPLICATION(17310): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:26.390+0900 I/CAPI_APPFW_APPLICATION(  700): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:26.390+0900 W/CAM_APP (17310): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-13 23:27:26.450+0900 I/CAPI_APPFW_APPLICATION(20447): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:26.450+0900 I/CAPI_APPFW_APPLICATION(17310): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:26.450+0900 I/CAPI_APPFW_APPLICATION(  700): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 23:27:26.450+0900 W/CAM_APP (17310): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-13 23:27:58.110+0900 I/June    (20331): ission denied
08-13 23:28:13.700+0900 W/CRASH_MANAGER(21135): worker.c: worker_job(1198) > 1120331706161143947609
