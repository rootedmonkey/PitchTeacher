S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.0
Build-Number: Z130HDDU0BOB3
Build-Date: 2015.02.14 15:10:17

Crash Information
Process Name: paaaaaaaaa
PID: 15571
Date: 2015-08-13 23:13:55+0900
Executable File Path: /opt/usr/apps/org.samteam.perfectsong/bin/paaaaaaaaa
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x6c756e28

Register Information
r0   = 0x6c756e28, r1   = 0x6c756e28
r2   = 0x00000002, r3   = 0x00000073
r4   = 0x00000000, r5   = 0x6c756e28
r6   = 0x2a858538, r7   = 0x00000073
r8   = 0x00000004, r9   = 0xb48eb4d0
r10  = 0x2a0083ee, fp   = 0xbeff0814
ip   = 0x00000000, sp   = 0xbefefbd8
lr   = 0xb6beeb7c, pc   = 0xb6c23d64
cpsr = 0x60000010

Memory Information
MemTotal:   730748 KB
MemFree:    150412 KB
Buffers:     45284 KB
Cached:     210856 KB
VmPeak:     194844 KB
VmSize:     194840 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       40784 KB
VmRSS:       40784 KB
VmData:     126424 KB
VmStk:         136 KB
VmExe:          36 KB
VmLib:       47200 KB
VmPTE:         114 KB
VmSwap:          0 KB

Threads Information
Threads: 12
PID = 15571 TID = 15571
15571 15641 15642 15646 15717 16349 16350 16351 16354 16355 16356 16357 

Maps Information
2a000000 2a009000 r-xp /opt/usr/apps/org.samteam.perfectsong/bin/paaaaaaaaa
2a010000 2a012000 rwxp /opt/usr/apps/org.samteam.perfectsong/bin/paaaaaaaaa
2a012000 2aca1000 rwxp [heap]
ac2c0000 ac440000 rwxs /drm
ac730000 ac8b0000 rwxs /drm
ac8b0000 aca30000 rwxs /drm
ad665000 ada66000 rwxs /dev/shm/pulse-shm-524033094
ada67000 ae266000 rwxp [stack:16351]
ae266000 ae2e3000 r-xp /usr/lib/lib_SoundAlive_ver125e_wrapped.so
ae2eb000 ae300000 rwxp /usr/lib/lib_SoundAlive_ver125e_wrapped.so
ae301000 aeb00000 rwxp [stack:16350]
aeb01000 af300000 rwxp [stack:16349]
af301000 afb00000 rwxp [stack:16357]
afc45000 afc5f000 r-xp /usr/lib/gstreamer-0.10/libgstpulse.so
afc67000 afc68000 rwxp /usr/lib/gstreamer-0.10/libgstpulse.so
afc68000 afd8c000 r-xp /usr/share/fallback_fonts/TizenSansKoreanRegular.ttf
afd8d000 b058c000 rwxp [stack:15646]
b0599000 b05a2000 r-xp /usr/lib/lib_SoundBooster_ver402_wrapped.so
b05aa000 b05ac000 rwxp /usr/lib/lib_SoundBooster_ver402_wrapped.so
b05c1000 b05d9000 r-xp /usr/lib/libgstcontroller-0.10.so.0.30.0
b05e0000 b05e1000 rwxp /usr/lib/libgstcontroller-0.10.so.0.30.0
b05e8000 b05ee000 r-xp /usr/lib/gstreamer-0.10/libgstsoundalive.so
b05f5000 b05f6000 rwxp /usr/lib/gstreamer-0.10/libgstsoundalive.so
b05f6000 b05fe000 r-xp /usr/lib/lib_SoundAlive_SRC192_ver204_wrapped.so
b05fe000 b0601000 rwxp /usr/lib/lib_SoundAlive_SRC192_ver204_wrapped.so
b0609000 b060e000 r-xp /usr/lib/gstreamer-0.10/libgstvolume.so
b0615000 b0616000 rwxp /usr/lib/gstreamer-0.10/libgstvolume.so
b0616000 b0619000 r-xp /usr/lib/gstreamer-0.10/libgstsecresample.so
b0621000 b0622000 rwxp /usr/lib/gstreamer-0.10/libgstsecresample.so
b0622000 b062d000 r-xp /usr/lib/gstreamer-0.10/libgstaudioconvert.so
b0635000 b0636000 rwxp /usr/lib/gstreamer-0.10/libgstaudioconvert.so
b0636000 b065f000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
b0666000 b0668000 rwxp /usr/lib/libgstaudio-0.10.so.0.25.0
b0668000 b07e8000 rwxs /drm
b07e8000 b0805000 rwxs /SYSV00000000
b080d000 b0811000 r-xp /usr/lib/gstreamer-0.10/libgstaudiotp.so
b0818000 b0819000 rwxp /usr/lib/gstreamer-0.10/libgstaudiotp.so
b0819000 b083e000 r-xp /usr/lib/libgsttag-0.10.so.0.25.0
b0846000 b0847000 rwxp /usr/lib/libgsttag-0.10.so.0.25.0
b0847000 b0851000 r-xp /usr/lib/libgstriff-0.10.so.0.25.0
b0859000 b085a000 rwxp /usr/lib/libgstriff-0.10.so.0.25.0
b085e000 b0867000 r-xp /usr/lib/gstreamer-0.10/libgstvorbis.so
b086e000 b086f000 rwxp /usr/lib/gstreamer-0.10/libgstvorbis.so
b086f000 b0895000 r-xp /usr/lib/gstreamer-0.10/libgstogg.so
b089c000 b089e000 rwxp /usr/lib/gstreamer-0.10/libgstogg.so
b089e000 b08b6000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
b08bd000 b08bf000 rwxp /usr/lib/libgstpbutils-0.10.so.0.25.0
b08bf000 b08d5000 r-xp /usr/lib/gstreamer-0.10/libgstdecodebin2.so
b08dd000 b08de000 rwxp /usr/lib/gstreamer-0.10/libgstdecodebin2.so
b08de000 b0921000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
b0928000 b0929000 rwxp /usr/lib/libgstbase-0.10.so.0.30.0
b092b000 b0935000 r-xp /usr/lib/gstreamer-0.10/libgsttypefindfunctions.so
b093d000 b093e000 rwxp /usr/lib/gstreamer-0.10/libgsttypefindfunctions.so
b093e000 b0973000 r-xp /usr/lib/gstreamer-0.10/libgstcoreelements.so
b097a000 b097c000 rwxp /usr/lib/gstreamer-0.10/libgstcoreelements.so
b097c000 b098d000 rwxs /SYSV00000000
b098e000 b118d000 rwxp [stack:15642]
b118d000 b158e000 rwxs /dev/shm/pulse-shm-2272926892
b158f000 b1d8e000 rwxp [stack:15641]
b1d8f000 b258e000 rwxp [stack:16355]
b258e000 b26b4000 r-xp /usr/share/fallback_fonts/SamsungKoreanCondensed-Regular.ttf
b26b4000 b2700000 r-xp /usr/share/app_fonts/SamsungCondensed-1R.ttf
b2701000 b2f00000 rwxp [stack:16354]
b2f01000 b3700000 rwxp [stack:16356]
b3807000 b380e000 r-xs /usr/lib/gconv/gconv-modules.cache
b380e000 b3810000 rwxs /SYSV2019101d
b3810000 b384a000 r-xp /usr/share/fonts/SamsungSans_Rg.ttf
b384a000 b3859000 r-xs /opt/var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-4
b3859000 b385f000 r-xs /opt/var/cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-4
b385f000 b3862000 r-xs /opt/var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-4
b3863000 b4062000 rwxp [stack:15717]
b4062000 b41e4000 r-xs /usr/share/elementary/themes/default.edj
b41e4000 b41e5000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b41ec000 b41ed000 rwxp /usr/lib/libmmfkeysound.so.0.0.0
b41ed000 b41f4000 r-xp /usr/lib/libfeedback.so.0.1.4
b41fc000 b41fd000 rwxp /usr/lib/libfeedback.so.0.1.4
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
b6fd9000 b6fda000 rwxp /usr/lib/libsys-assert.so
b6fda000 b6ff7000 r-xp /lib/ld-2.13.so
b6ffe000 b6fff000 r-xp /lib/ld-2.13.so
b6fff000 b7000000 rwxp /lib/ld-2.13.so
befdf000 bf000000 rwxp [stack]
End of Maps Information

Callstack Information (PID:15571)
Call Stack Count: 4
 0: strlen + 0x4 (0xb6c23d64) [/lib/libc.so.6] + 0x72d64
 1: _IO_vfprintf + 0xcb8 (0xb6beeb7c) [/lib/libc.so.6] + 0x3db7c
 2: _IO_fprintf + 0x1c (0xb6bf715c) [/lib/libc.so.6] + 0x4615c
 3: statsInput + 0x1c2 (0x2a004b23) [/opt/usr/apps/org.samteam.perfectsong/bin/paaaaaaaaa] + 0x4b23
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
I/record  (15571): note : 52 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:11:57.350+0900 E/record  (15571): !! interval
08-13 23:11:57.390+0900 I/record  (15571): note : 52 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:11:57.390+0900 E/record  (15571): !! interval
08-13 23:11:57.440+0900 I/record  (15571): note : 52 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:11:57.440+0900 E/record  (15571): !! interval
08-13 23:11:57.500+0900 F/record  (15571): ===next node===
08-13 23:11:57.500+0900 I/record  (15571): note : 50 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:11:57.500+0900 E/record  (15571): !! interval
08-13 23:11:57.540+0900 I/record  (15571): note : 50 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:11:57.540+0900 E/record  (15571): !! interval
08-13 23:11:57.600+0900 I/record  (15571): note : 50 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:11:57.600+0900 E/record  (15571): !! interval
08-13 23:11:57.650+0900 I/record  (15571): note : 50 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:11:57.650+0900 E/record  (15571): !! interval
08-13 23:11:57.700+0900 I/record  (15571): note : 50 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:11:57.700+0900 E/record  (15571): !! interval
08-13 23:11:57.750+0900 F/record  (15571): ===next node===
08-13 23:11:57.750+0900 I/record  (15571): note : 48 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:11:57.750+0900 E/record  (15571): !! interval
08-13 23:11:57.800+0900 I/record  (15571): note : 48 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:11:57.800+0900 E/record  (15571): !! interval
08-13 23:11:57.850+0900 I/record  (15571): note : 48 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:11:57.850+0900 E/record  (15571): !! interval
08-13 23:11:57.900+0900 I/record  (15571): note : 48 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:11:57.900+0900 E/record  (15571): !! interval
08-13 23:11:57.950+0900 I/record  (15571): note : 48 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:11:57.950+0900 E/record  (15571): !! interval
08-13 23:11:58.000+0900 I/record  (15571): note : 48 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:11:58.000+0900 E/record  (15571): !! interval
08-13 23:11:58.050+0900 F/record  (15571): ===next node===
08-13 23:11:58.050+0900 I/record  (15571): note : 52 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:11:58.050+0900 E/record  (15571): !! interval
08-13 23:11:58.100+0900 I/record  (15571): note : 52 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:11:58.100+0900 E/record  (15571): !! interval
08-13 23:11:58.150+0900 I/record  (15571): note : 52 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:11:58.150+0900 E/record  (15571): !! interval
08-13 23:11:58.210+0900 I/record  (15571): note : 52 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:11:58.210+0900 E/record  (15571): !! interval
08-13 23:11:58.260+0900 I/record  (15571): note : 52 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:11:58.260+0900 E/record  (15571): !! interval
08-13 23:11:58.310+0900 I/record  (15571): note : 52 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:11:58.310+0900 E/record  (15571): !! interval
08-13 23:11:58.360+0900 F/record  (15571): ===next node===
08-13 23:11:58.360+0900 I/record  (15571): note : 55 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:11:58.360+0900 E/record  (15571): !! interval
08-13 23:11:58.420+0900 I/record  (15571): note : 55 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:11:58.420+0900 E/record  (15571): !! interval
08-13 23:11:58.470+0900 I/record  (15571): note : 55 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:11:58.470+0900 E/record  (15571): !! interval
08-13 23:11:58.510+0900 I/record  (15571): note : 55 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:11:58.510+0900 E/record  (15571): !! interval
08-13 23:11:58.560+0900 I/record  (15571): note : 55 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:11:58.560+0900 E/record  (15571): !! interval
08-13 23:11:58.620+0900 I/record  (15571): note : 55 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:11:58.620+0900 E/record  (15571): !! interval
08-13 23:11:58.670+0900 F/record  (15571): ===next node===
08-13 23:11:58.670+0900 I/record  (15571): note : 60 detect :21 isHit : 3 [0: 1071644672/0]
08-13 23:11:58.720+0900 I/record  (15571): note : 60 detect :21 isHit : 3 [0: 1071644672/0]
08-13 23:11:58.760+0900 I/record  (15571): note : 60 detect :21 isHit : 3 [0: 1071644672/0]
08-13 23:11:58.820+0900 I/record  (15571): note : 60 detect :21 isHit : 3 [0: 1071644672/0]
08-13 23:11:58.870+0900 I/record  (15571): note : 60 detect :21 isHit : 3 [0: 1071644672/0]
08-13 23:11:58.920+0900 I/record  (15571): note : 60 detect :21 isHit : 3 [0: 1071644672/0]
08-13 23:11:58.970+0900 I/record  (15571): note : 60 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:11:58.970+0900 E/record  (15571): !! interval
08-13 23:11:59.020+0900 I/record  (15571): note : 60 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:11:59.020+0900 E/record  (15571): !! interval
08-13 23:11:59.080+0900 I/record  (15571): note : 60 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:11:59.080+0900 E/record  (15571): !! interval
08-13 23:11:59.130+0900 I/record  (15571): note : 60 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:11:59.130+0900 E/record  (15571): !! interval
08-13 23:11:59.180+0900 I/record  (15571): note : 60 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:11:59.180+0900 E/record  (15571): !! interval
08-13 23:11:59.220+0900 I/record  (15571): note : 60 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:11:59.220+0900 E/record  (15571): !! interval
08-13 23:11:59.270+0900 I/record  (15571): note : 60 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:11:59.270+0900 E/record  (15571): !! interval
08-13 23:11:59.330+0900 I/record  (15571): note : 60 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:11:59.330+0900 E/record  (15571): !! interval
08-13 23:11:59.380+0900 I/record  (15571): note : 60 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:11:59.380+0900 E/record  (15571): !! interval
08-13 23:11:59.420+0900 F/record  (15571): ===next node===
08-13 23:11:59.420+0900 I/record  (15571): note : 55 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:11:59.430+0900 E/record  (15571): !! interval
08-13 23:11:59.480+0900 I/record  (15571): note : 55 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:11:59.480+0900 E/record  (15571): !! interval
08-13 23:11:59.530+0900 I/record  (15571): note : 55 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:11:59.530+0900 E/record  (15571): !! interval
08-13 23:11:59.580+0900 F/record  (15571): ===next node===
08-13 23:11:59.580+0900 I/record  (15571): note : 60 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:11:59.580+0900 E/record  (15571): !! interval
08-13 23:11:59.630+0900 I/record  (15571): note : 60 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:11:59.630+0900 E/record  (15571): !! interval
08-13 23:11:59.680+0900 I/record  (15571): note : 60 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:11:59.680+0900 E/record  (15571): !! interval
08-13 23:11:59.740+0900 I/record  (15571): note : 60 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:11:59.740+0900 E/record  (15571): !! interval
08-13 23:11:59.780+0900 I/record  (15571): note : 60 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:11:59.780+0900 E/record  (15571): !! interval
08-13 23:11:59.830+0900 I/record  (15571): note : 60 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:11:59.830+0900 E/record  (15571): !! interval
08-13 23:11:59.880+0900 I/record  (15571): note : 60 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:11:59.880+0900 E/record  (15571): !! interval
08-13 23:11:59.930+0900 I/record  (15571): note : 60 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:11:59.930+0900 E/record  (15571): !! interval
08-13 23:11:59.990+0900 I/record  (15571): note : 60 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:11:59.990+0900 E/record  (15571): !! interval
08-13 23:12:00.030+0900 F/record  (15571): ===next node===
08-13 23:12:00.030+0900 I/record  (15571): note : 55 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:00.030+0900 E/record  (15571): !! interval
08-13 23:12:00.090+0900 I/record  (15571): note : 55 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:00.090+0900 E/record  (15571): !! interval
08-13 23:12:00.130+0900 I/record  (15571): note : 55 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:00.130+0900 E/record  (15571): !! interval
08-13 23:12:00.190+0900 F/record  (15571): ===next node===
08-13 23:12:00.190+0900 I/record  (15571): note : 60 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:00.190+0900 E/record  (15571): !! interval
08-13 23:12:00.240+0900 I/record  (15571): note : 60 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:00.240+0900 E/record  (15571): !! interval
08-13 23:12:00.290+0900 I/record  (15571): note : 60 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:00.290+0900 E/record  (15571): !! interval
08-13 23:12:00.340+0900 I/record  (15571): note : 60 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:00.340+0900 E/record  (15571): !! interval
08-13 23:12:00.390+0900 I/record  (15571): note : 60 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:00.390+0900 E/record  (15571): !! interval
08-13 23:12:00.440+0900 I/record  (15571): note : 60 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:00.440+0900 E/record  (15571): !! interval
08-13 23:12:00.490+0900 F/record  (15571): ===next node===
08-13 23:12:00.490+0900 I/record  (15571): note : 55 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:00.490+0900 E/record  (15571): !! interval
08-13 23:12:00.540+0900 I/record  (15571): note : 55 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:00.540+0900 E/record  (15571): !! interval
08-13 23:12:00.590+0900 I/record  (15571): note : 55 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:00.590+0900 E/record  (15571): !! interval
08-13 23:12:00.640+0900 I/record  (15571): note : 55 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:00.640+0900 E/record  (15571): !! interval
08-13 23:12:00.690+0900 I/record  (15571): note : 55 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:00.690+0900 E/record  (15571): !! interval
08-13 23:12:00.740+0900 I/record  (15571): note : 55 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:00.740+0900 E/record  (15571): !! interval
08-13 23:12:00.790+0900 F/record  (15571): ===next node===
08-13 23:12:00.790+0900 I/record  (15571): note : 52 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:00.790+0900 E/record  (15571): !! interval
08-13 23:12:00.850+0900 I/record  (15571): note : 52 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:00.850+0900 E/record  (15571): !! interval
08-13 23:12:00.900+0900 I/record  (15571): note : 52 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:00.900+0900 E/record  (15571): !! interval
08-13 23:12:00.950+0900 I/record  (15571): note : 52 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:00.950+0900 E/record  (15571): !! interval
08-13 23:12:01.000+0900 I/record  (15571): note : 52 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:01.000+0900 E/record  (15571): !! interval
08-13 23:12:01.050+0900 F/record  (15571): ===next node===
08-13 23:12:01.050+0900 I/record  (15571): note : 55 detect :21 isHit : 3 [0: 1071644672/0]
08-13 23:12:01.110+0900 I/record  (15571): note : 55 detect :21 isHit : 3 [0: 1071644672/0]
08-13 23:12:01.150+0900 I/record  (15571): note : 55 detect :21 isHit : 3 [0: 1071644672/0]
08-13 23:12:01.200+0900 I/record  (15571): note : 55 detect :21 isHit : 3 [0: 1071644672/0]
08-13 23:12:01.260+0900 I/record  (15571): note : 55 detect :21 isHit : 3 [0: 1071644672/0]
08-13 23:12:01.300+0900 I/record  (15571): note : 55 detect :21 isHit : 3 [0: 1071644672/0]
08-13 23:12:01.360+0900 I/record  (15571): note : 55 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:01.360+0900 E/record  (15571): !! interval
08-13 23:12:01.400+0900 I/record  (15571): note : 55 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:01.400+0900 E/record  (15571): !! interval
08-13 23:12:01.450+0900 I/record  (15571): note : 55 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:01.450+0900 E/record  (15571): !! interval
08-13 23:12:01.500+0900 I/record  (15571): note : 55 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:01.510+0900 E/record  (15571): !! interval
08-13 23:12:01.560+0900 I/record  (15571): note : 55 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:01.560+0900 E/record  (15571): !! interval
08-13 23:12:01.610+0900 I/record  (15571): note : 55 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:01.610+0900 E/record  (15571): !! interval
08-13 23:12:01.660+0900 F/record  (15571): ===next node===
08-13 23:12:01.660+0900 I/record  (15571): note : 50 detect :21 isHit : 3 [0: 1071644672/0]
08-13 23:12:01.720+0900 I/record  (15571): note : 50 detect :21 isHit : 3 [0: 1071644672/0]
08-13 23:12:01.760+0900 I/record  (15571): note : 50 detect :21 isHit : 3 [0: 1071644672/0]
08-13 23:12:01.810+0900 I/record  (15571): note : 50 detect :21 isHit : 3 [0: 1071644672/0]
08-13 23:12:01.860+0900 I/record  (15571): note : 50 detect :21 isHit : 3 [0: 1071644672/0]
08-13 23:12:01.910+0900 I/record  (15571): note : 50 detect :21 isHit : 3 [0: 1071644672/0]
08-13 23:12:01.960+0900 I/record  (15571): note : 50 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:01.960+0900 E/record  (15571): !! interval
08-13 23:12:02.010+0900 I/record  (15571): note : 50 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:02.020+0900 E/record  (15571): !! interval
08-13 23:12:02.060+0900 I/record  (15571): note : 50 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:02.060+0900 E/record  (15571): !! interval
08-13 23:12:02.110+0900 I/record  (15571): note : 50 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:02.110+0900 E/record  (15571): !! interval
08-13 23:12:02.170+0900 I/record  (15571): note : 50 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:02.170+0900 E/record  (15571): !! interval
08-13 23:12:02.220+0900 I/record  (15571): note : 50 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:02.220+0900 E/record  (15571): !! interval
08-13 23:12:02.270+0900 F/record  (15571): ===next node===
08-13 23:12:02.270+0900 I/record  (15571): note : 53 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:02.270+0900 E/record  (15571): !! interval
08-13 23:12:02.330+0900 I/record  (15571): note : 53 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:02.330+0900 E/record  (15571): !! interval
08-13 23:12:02.380+0900 I/record  (15571): note : 53 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:02.380+0900 E/record  (15571): !! interval
08-13 23:12:02.420+0900 I/record  (15571): note : 53 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:02.420+0900 E/record  (15571): !! interval
08-13 23:12:02.480+0900 I/record  (15571): note : 53 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:02.480+0900 E/record  (15571): !! interval
08-13 23:12:02.520+0900 I/record  (15571): note : 53 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:02.520+0900 E/record  (15571): !! interval
08-13 23:12:02.570+0900 F/record  (15571): ===next node===
08-13 23:12:02.570+0900 I/record  (15571): note : 52 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:02.570+0900 E/record  (15571): !! interval
08-13 23:12:02.620+0900 I/record  (15571): note : 52 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:02.620+0900 E/record  (15571): !! interval
08-13 23:12:02.670+0900 I/record  (15571): note : 52 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:02.670+0900 E/record  (15571): !! interval
08-13 23:12:02.720+0900 I/record  (15571): note : 52 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:02.720+0900 E/record  (15571): !! interval
08-13 23:12:02.770+0900 I/record  (15571): note : 52 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:02.770+0900 E/record  (15571): !! interval
08-13 23:12:02.820+0900 I/record  (15571): note : 52 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:02.820+0900 E/record  (15571): !! interval
08-13 23:12:02.880+0900 F/record  (15571): ===next node===
08-13 23:12:02.880+0900 I/record  (15571): note : 50 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:02.880+0900 E/record  (15571): !! interval
08-13 23:12:02.930+0900 I/record  (15571): note : 50 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:02.930+0900 E/record  (15571): !! interval
08-13 23:12:02.980+0900 I/record  (15571): note : 50 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:02.980+0900 E/record  (15571): !! interval
08-13 23:12:03.030+0900 I/record  (15571): note : 50 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:03.030+0900 E/record  (15571): !! interval
08-13 23:12:03.080+0900 I/record  (15571): note : 50 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:03.080+0900 E/record  (15571): !! interval
08-13 23:12:03.130+0900 I/record  (15571): note : 50 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:03.130+0900 E/record  (15571): !! interval
08-13 23:12:03.180+0900 F/record  (15571): ===next node===
08-13 23:12:03.180+0900 I/record  (15571): note : 48 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:03.180+0900 E/record  (15571): !! interval
08-13 23:12:03.230+0900 I/record  (15571): note : 48 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:03.230+0900 E/record  (15571): !! interval
08-13 23:12:03.280+0900 I/record  (15571): note : 48 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:03.280+0900 E/record  (15571): !! interval
08-13 23:12:03.330+0900 I/record  (15571): note : 48 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:03.330+0900 E/record  (15571): !! interval
08-13 23:12:03.380+0900 I/record  (15571): note : 48 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:03.380+0900 E/record  (15571): !! interval
08-13 23:12:03.440+0900 I/record  (15571): note : 48 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:03.440+0900 E/record  (15571): !! interval
08-13 23:12:03.490+0900 I/record  (15571): note : 48 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:03.490+0900 E/record  (15571): !! interval
08-13 23:12:03.540+0900 I/record  (15571): note : 48 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:03.540+0900 E/record  (15571): !! interval
08-13 23:12:03.590+0900 I/record  (15571): note : 48 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:03.590+0900 E/record  (15571): !! interval
08-13 23:12:03.650+0900 I/record  (15571): note : 48 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:03.650+0900 E/record  (15571): !! interval
08-13 23:12:03.700+0900 I/record  (15571): note : 48 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:03.700+0900 E/record  (15571): !! interval
08-13 23:12:03.750+0900 I/record  (15571): note : 48 detect :21 isHit : -2 [0: 1071644672/0]
08-13 23:12:03.750+0900 E/record  (15571): !! interval
08-13 23:12:11.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 23:12:11.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 23:12:11.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 23:12:11.860+0900 I/Tizen::Net::Wifi(  970): (1072) > _WifiService is not registered.
08-13 23:12:11.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 306 5 28 25"
08-13 23:12:11.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 334 5 28 25"
08-13 23:12:11.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 237 362 5 28 25"
08-13 23:12:11.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 390 5 28 25"
08-13 23:12:11.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 418 5 28 25"
08-13 23:12:11.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 23:12:11.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 23:12:11.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 23:12:11.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 626 5 28 25"
08-13 23:12:11.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 654 5 28 25"
08-13 23:12:11.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 682 5 28 25"
08-13 23:12:11.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 237 710 5 28 25"
08-13 23:12:11.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 738 5 28 25"
08-13 23:12:21.090+0900 E/RESOURCED(  766): proc-monitor.c: edbus_signal_trigger(473) > [edbus_signal_trigger,473] Receive watchdog signal to pid: 15571(paaaaaaaaa)
08-13 23:12:22.860+0900 I/Tizen::Net::Wifi(  970): (1072) > _WifiService is not registered.
08-13 23:12:22.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 23:12:22.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 23:12:22.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 23:12:22.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 306 5 28 25"
08-13 23:12:22.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 334 5 28 25"
08-13 23:12:22.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 237 362 5 28 25"
08-13 23:12:22.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 390 5 28 25"
08-13 23:12:22.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 418 5 28 25"
08-13 23:12:22.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 23:12:22.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 23:12:22.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 23:12:22.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 626 5 28 25"
08-13 23:12:22.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 654 5 28 25"
08-13 23:12:22.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 682 5 28 25"
08-13 23:12:22.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 237 710 5 28 25"
08-13 23:12:22.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 738 5 28 25"
08-13 23:12:23.850+0900 I/Tizen::Net::Wifi(  970): (1072) > _WifiService is not registered.
08-13 23:12:23.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 23:12:23.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 23:12:23.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 23:12:23.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 306 5 28 25"
08-13 23:12:23.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 334 5 28 25"
08-13 23:12:23.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 237 362 5 28 25"
08-13 23:12:23.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 390 5 28 25"
08-13 23:12:23.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 418 5 28 25"
08-13 23:12:23.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 23:12:23.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 23:12:23.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 23:12:23.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 626 5 28 25"
08-13 23:12:23.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 654 5 28 25"
08-13 23:12:23.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 682 5 28 25"
08-13 23:12:23.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 237 710 5 28 25"
08-13 23:12:23.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 738 5 28 25"
08-13 23:12:54.860+0900 I/Tizen::Net::Wifi(  970): (1072) > _WifiService is not registered.
08-13 23:12:54.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 23:12:54.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 23:12:54.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 23:12:54.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 306 5 28 25"
08-13 23:12:54.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 334 5 28 25"
08-13 23:12:54.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 237 362 5 28 25"
08-13 23:12:54.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 390 5 28 25"
08-13 23:12:54.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 418 5 28 25"
08-13 23:12:54.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 23:12:54.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 23:12:54.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 23:12:54.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 626 5 28 25"
08-13 23:12:54.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 654 5 28 25"
08-13 23:12:54.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 682 5 28 25"
08-13 23:12:54.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 237 710 5 28 25"
08-13 23:12:54.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 738 5 28 25"
08-13 23:12:59.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 23:12:59.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 23:12:59.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 23:12:59.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 306 5 28 25"
08-13 23:12:59.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 334 5 28 25"
08-13 23:12:59.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 237 362 5 28 25"
08-13 23:12:59.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 390 5 28 25"
08-13 23:12:59.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 418 5 28 25"
08-13 23:12:59.860+0900 I/Tizen::Net::Wifi(  970): (1072) > _WifiService is not registered.
08-13 23:12:59.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 23:12:59.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 23:12:59.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 23:12:59.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 626 5 28 25"
08-13 23:12:59.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 654 5 28 25"
08-13 23:12:59.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 682 5 28 25"
08-13 23:12:59.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 237 710 5 28 25"
08-13 23:12:59.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 738 5 28 25"
08-13 23:13:01.850+0900 I/Tizen::Net::Wifi(  970): (1072) > _WifiService is not registered.
08-13 23:13:01.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 23:13:01.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 23:13:01.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 23:13:01.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 306 5 28 25"
08-13 23:13:01.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 334 5 28 25"
08-13 23:13:01.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 237 362 5 28 25"
08-13 23:13:01.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 390 5 28 25"
08-13 23:13:01.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 418 5 28 25"
08-13 23:13:01.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 23:13:01.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 23:13:01.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 23:13:01.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 626 5 28 25"
08-13 23:13:01.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 654 5 28 25"
08-13 23:13:01.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 682 5 28 25"
08-13 23:13:01.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 237 710 5 28 25"
08-13 23:13:01.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 738 5 28 25"
08-13 23:13:02.860+0900 I/Tizen::Net::Wifi(  970): (1072) > _WifiService is not registered.
08-13 23:13:02.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 23:13:02.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 23:13:02.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 23:13:02.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 306 5 28 25"
08-13 23:13:02.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 334 5 28 25"
08-13 23:13:02.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 237 362 5 28 25"
08-13 23:13:02.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 390 5 28 25"
08-13 23:13:02.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 418 5 28 25"
08-13 23:13:02.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 23:13:02.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 23:13:02.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 23:13:02.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 626 5 28 25"
08-13 23:13:02.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 654 5 28 25"
08-13 23:13:02.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 682 5 28 25"
08-13 23:13:02.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 237 710 5 28 25"
08-13 23:13:02.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 738 5 28 25"
08-13 23:13:03.850+0900 I/Tizen::Net::Wifi(  970): (1072) > _WifiService is not registered.
08-13 23:13:03.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 23:13:03.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 23:13:03.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 23:13:03.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 306 5 28 25"
08-13 23:13:03.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 334 5 28 25"
08-13 23:13:03.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 237 362 5 28 25"
08-13 23:13:03.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 390 5 28 25"
08-13 23:13:03.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 418 5 28 25"
08-13 23:13:03.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 23:13:03.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 23:13:03.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 23:13:03.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 626 5 28 25"
08-13 23:13:03.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 654 5 28 25"
08-13 23:13:03.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 682 5 28 25"
08-13 23:13:03.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 237 710 5 28 25"
08-13 23:13:03.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 738 5 28 25"
08-13 23:13:13.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 23:13:13.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 23:13:13.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 23:13:13.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 306 5 28 25"
08-13 23:13:13.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 334 5 28 25"
08-13 23:13:13.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 237 362 5 28 25"
08-13 23:13:13.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 390 5 28 25"
08-13 23:13:13.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 418 5 28 25"
08-13 23:13:13.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 23:13:13.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 23:13:13.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 23:13:13.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 626 5 28 25"
08-13 23:13:13.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 654 5 28 25"
08-13 23:13:13.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 682 5 28 25"
08-13 23:13:13.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 237 710 5 28 25"
08-13 23:13:13.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 738 5 28 25"
08-13 23:13:13.860+0900 I/Tizen::Net::Wifi(  970): (1072) > _WifiService is not registered.
08-13 23:13:30.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 23:13:30.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 23:13:30.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 23:13:30.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 306 5 28 25"
08-13 23:13:30.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 334 5 28 25"
08-13 23:13:30.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 237 362 5 28 25"
08-13 23:13:30.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 390 5 28 25"
08-13 23:13:30.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 418 5 28 25"
08-13 23:13:30.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 23:13:30.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 23:13:30.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 23:13:30.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 626 5 28 25"
08-13 23:13:30.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 654 5 28 25"
08-13 23:13:30.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 682 5 28 25"
08-13 23:13:30.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 237 710 5 28 25"
08-13 23:13:30.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 738 5 28 25"
08-13 23:13:30.860+0900 I/Tizen::Net::Wifi(  970): (1072) > _WifiService is not registered.
08-13 23:13:31.860+0900 I/Tizen::Net::Wifi(  970): (1072) > _WifiService is not registered.
08-13 23:13:31.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 23:13:31.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 23:13:31.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 23:13:31.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 306 5 28 25"
08-13 23:13:31.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 334 5 28 25"
08-13 23:13:31.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 237 362 5 28 25"
08-13 23:13:31.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 390 5 28 25"
08-13 23:13:31.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 418 5 28 25"
08-13 23:13:31.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 23:13:31.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 23:13:31.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 23:13:31.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 626 5 28 25"
08-13 23:13:31.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 654 5 28 25"
08-13 23:13:31.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 682 5 28 25"
08-13 23:13:31.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 237 710 5 28 25"
08-13 23:13:31.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 738 5 28 25"
08-13 23:13:37.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 23:13:37.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 23:13:37.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 23:13:37.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 306 5 28 25"
08-13 23:13:37.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 334 5 28 25"
08-13 23:13:37.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 237 362 5 28 25"
08-13 23:13:37.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 390 5 28 25"
08-13 23:13:37.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 418 5 28 25"
08-13 23:13:37.870+0900 I/Tizen::Net::Wifi(  970): (1072) > _WifiService is not registered.
08-13 23:13:37.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 23:13:37.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 23:13:37.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 23:13:37.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 626 5 28 25"
08-13 23:13:37.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 654 5 28 25"
08-13 23:13:37.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 682 5 28 25"
08-13 23:13:37.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 237 710 5 28 25"
08-13 23:13:37.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 738 5 28 25"
08-13 23:13:38.860+0900 I/Tizen::Net::Wifi(  970): (1072) > _WifiService is not registered.
08-13 23:13:38.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 23:13:38.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 23:13:38.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 23:13:38.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 306 5 28 25"
08-13 23:13:38.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 334 5 28 25"
08-13 23:13:38.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 237 362 5 28 25"
08-13 23:13:38.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 390 5 28 25"
08-13 23:13:38.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 418 5 28 25"
08-13 23:13:38.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 23:13:38.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 23:13:38.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 23:13:38.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 626 5 28 25"
08-13 23:13:38.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 654 5 28 25"
08-13 23:13:38.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 682 5 28 25"
08-13 23:13:38.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 237 710 5 28 25"
08-13 23:13:38.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 738 5 28 25"
08-13 23:13:46.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 23:13:46.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 23:13:46.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 23:13:46.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 306 5 28 25"
08-13 23:13:46.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 334 5 28 25"
08-13 23:13:46.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 237 362 5 28 25"
08-13 23:13:46.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 390 5 28 25"
08-13 23:13:46.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 418 5 28 25"
08-13 23:13:46.850+0900 I/Tizen::Net::Wifi(  970): (1072) > _WifiService is not registered.
08-13 23:13:46.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 23:13:46.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 23:13:46.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 23:13:46.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 626 5 28 25"
08-13 23:13:46.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 654 5 28 25"
08-13 23:13:46.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 682 5 28 25"
08-13 23:13:46.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 237 710 5 28 25"
08-13 23:13:46.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 738 5 28 25"
08-13 23:13:47.840+0900 I/Tizen::Net::Wifi(  970): (1072) > _WifiService is not registered.
08-13 23:13:47.840+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 23:13:47.840+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 23:13:47.840+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 23:13:47.840+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 306 5 28 25"
08-13 23:13:47.840+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 334 5 28 25"
08-13 23:13:47.840+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 237 362 5 28 25"
08-13 23:13:47.840+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 390 5 28 25"
08-13 23:13:47.840+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 418 5 28 25"
08-13 23:13:47.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 23:13:47.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 23:13:47.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 23:13:47.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 626 5 28 25"
08-13 23:13:47.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 654 5 28 25"
08-13 23:13:47.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 682 5 28 25"
08-13 23:13:47.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 237 710 5 28 25"
08-13 23:13:47.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 738 5 28 25"
08-13 23:13:56.160+0900 W/CRASH_MANAGER(16937): worker.c: worker_job(1198) > 1115571706161143947523
