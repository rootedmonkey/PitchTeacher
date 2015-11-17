S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.0
Build-Number: Z130HDDU0BOB3
Build-Date: 2015.02.14 15:10:17

Crash Information
Process Name: paaaaaaaaa
PID: 14803
Date: 2015-08-13 21:07:07+0900
Executable File Path: /opt/usr/apps/org.samteam.perfectsong/bin/paaaaaaaaa
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0xb2500010, r3   = 0x00000000
r4   = 0xffffffff, r5   = 0x2a54c5e8
r6   = 0x2a5fcd20, r7   = 0xbeff0b94
r8   = 0x00000000, r9   = 0xb6f558a0
r10  = 0xb6f558fc, fp   = 0xb6f558fc
ip   = 0xb6c09fbc, sp   = 0xbeff08a8
lr   = 0x2a004b1d, pc   = 0xb6c09fc4
cpsr = 0x60000010

Memory Information
MemTotal:   730748 KB
MemFree:    169876 KB
Buffers:     41476 KB
Cached:     205048 KB
VmPeak:     347036 KB
VmSize:     346008 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       33416 KB
VmRSS:       33416 KB
VmData:     277636 KB
VmStk:         136 KB
VmExe:          36 KB
VmLib:       47124 KB
VmPTE:         146 KB
VmSwap:          0 KB

Threads Information
Threads: 31
PID = 14803 TID = 14803
14803 14845 14846 14848 14883 14884 14885 14888 14889 14894 14906 14918 14919 14920 14921 14922 14940 14941 14942 14943 14944 14958 14959 14960 14961 14963 14975 14976 14977 14978 14979 

Maps Information
2a000000 2a009000 r-xp /opt/usr/apps/org.samteam.perfectsong/bin/paaaaaaaaa
2a010000 2a011000 rwxp /opt/usr/apps/org.samteam.perfectsong/bin/paaaaaaaaa
2a011000 2aa89000 rwxp [heap]
a2c35000 a3434000 rwxp [stack:14979]
a3435000 a3c34000 rwxp [stack:14978]
a3c35000 a4434000 rwxp [stack:14977]
a4435000 a4c34000 rwxp [stack:14976]
a4c35000 a5434000 rwxp [stack:14975]
a5435000 a5c34000 rwxp [stack:14963]
a5c35000 a6434000 rwxp [stack:14961]
a6435000 a6c34000 rwxp [stack:14960]
a6c35000 a7434000 rwxp [stack:14959]
a7435000 a7c34000 rwxp [stack:14958]
a7c35000 a8434000 rwxp [stack:14944]
a8435000 a8c34000 rwxp [stack:14943]
a8c35000 a9434000 rwxp [stack:14942]
a9435000 a9c34000 rwxp [stack:14941]
a9c35000 aa434000 rwxp [stack:14940]
aa435000 aac34000 rwxp [stack:14922]
aac35000 ab434000 rwxp [stack:14921]
ab435000 abc34000 rwxp [stack:14920]
abc35000 ac434000 rwxp [stack:14919]
ac435000 acc34000 rwxp [stack:14918]
acc34000 ad035000 rwxs /dev/shm/pulse-shm-4129830343
ad036000 ad835000 rwxp [stack:14906]
ad836000 ae035000 rwxp [stack:14894]
ae036000 ae835000 rwxp [stack:14889]
ae836000 af035000 rwxp [stack:14888]
af035000 af1b5000 rwxs /drm
af1b5000 af335000 rwxs /drm
af335000 af4b5000 rwxs /drm
af6e8000 af702000 r-xp /usr/lib/gstreamer-0.10/libgstpulse.so
af70a000 af70b000 rwxp /usr/lib/gstreamer-0.10/libgstpulse.so
af70b000 af788000 r-xp /usr/lib/lib_SoundAlive_ver125e_wrapped.so
af790000 af7a5000 rwxp /usr/lib/lib_SoundAlive_ver125e_wrapped.so
af7a5000 af8c9000 r-xp /usr/share/fallback_fonts/TizenSansKoreanRegular.ttf
afcff000 b04ff000 rwxp [stack:14848]
b050c000 b0515000 r-xp /usr/lib/lib_SoundBooster_ver402_wrapped.so
b051d000 b051f000 rwxp /usr/lib/lib_SoundBooster_ver402_wrapped.so
b0534000 b054c000 r-xp /usr/lib/libgstcontroller-0.10.so.0.30.0
b0553000 b0554000 rwxp /usr/lib/libgstcontroller-0.10.so.0.30.0
b055b000 b0561000 r-xp /usr/lib/gstreamer-0.10/libgstsoundalive.so
b0568000 b0569000 rwxp /usr/lib/gstreamer-0.10/libgstsoundalive.so
b0569000 b056e000 r-xp /usr/lib/gstreamer-0.10/libgstvolume.so
b0575000 b0576000 rwxp /usr/lib/gstreamer-0.10/libgstvolume.so
b0614000 b061c000 r-xp /usr/lib/lib_SoundAlive_SRC192_ver204_wrapped.so
b061c000 b061f000 rwxp /usr/lib/lib_SoundAlive_SRC192_ver204_wrapped.so
b061f000 b0622000 r-xp /usr/lib/gstreamer-0.10/libgstsecresample.so
b062a000 b062b000 rwxp /usr/lib/gstreamer-0.10/libgstsecresample.so
b062b000 b0636000 r-xp /usr/lib/gstreamer-0.10/libgstaudioconvert.so
b063e000 b063f000 rwxp /usr/lib/gstreamer-0.10/libgstaudioconvert.so
b063f000 b0643000 r-xp /usr/lib/gstreamer-0.10/libgstaudiotp.so
b064a000 b064b000 rwxp /usr/lib/gstreamer-0.10/libgstaudiotp.so
b064b000 b065a000 r-xp /usr/lib/gstreamer-0.10/libgstsubparse.so
b0662000 b0663000 rwxp /usr/lib/gstreamer-0.10/libgstsubparse.so
b0663000 b0688000 r-xp /usr/lib/libgsttag-0.10.so.0.25.0
b0690000 b0691000 rwxp /usr/lib/libgsttag-0.10.so.0.25.0
b0691000 b06ba000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
b06c1000 b06c3000 rwxp /usr/lib/libgstaudio-0.10.so.0.25.0
b06c3000 b06cd000 r-xp /usr/lib/libgstriff-0.10.so.0.25.0
b06d5000 b06d6000 rwxp /usr/lib/libgstriff-0.10.so.0.25.0
b06e0000 b06e2000 r-xp /usr/lib/gconv/ISO8859-15.so
b06e9000 b06ea000 r-xp /usr/lib/gconv/ISO8859-15.so
b06ea000 b06eb000 rwxp /usr/lib/gconv/ISO8859-15.so
b06eb000 b06f5000 r-xp /usr/lib/gstreamer-0.10/libgstwavparse.so
b06fd000 b06fe000 rwxp /usr/lib/gstreamer-0.10/libgstwavparse.so
b06fe000 b0716000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
b071d000 b071f000 rwxp /usr/lib/libgstpbutils-0.10.so.0.25.0
b0721000 b072b000 r-xp /usr/lib/gstreamer-0.10/libgsttypefindfunctions.so
b0733000 b0734000 rwxp /usr/lib/gstreamer-0.10/libgsttypefindfunctions.so
b0734000 b0777000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
b077e000 b077f000 rwxp /usr/lib/libgstbase-0.10.so.0.30.0
b077f000 b08ff000 rwxs /drm
b0900000 b10ff000 rwxp [stack:14846]
b10ff000 b1500000 rwxs /dev/shm/pulse-shm-1257653480
b1501000 b1d00000 rwxp [stack:14845]
b260a000 b2620000 r-xp /usr/lib/gstreamer-0.10/libgstdecodebin2.so
b2628000 b2629000 rwxp /usr/lib/gstreamer-0.10/libgstdecodebin2.so
b2629000 b265e000 r-xp /usr/lib/gstreamer-0.10/libgstcoreelements.so
b2665000 b2667000 rwxp /usr/lib/gstreamer-0.10/libgstcoreelements.so
b2669000 b2686000 rwxs /SYSV00000000
b2686000 b2697000 rwxs /SYSV00000000
b2697000 b269e000 r-xs /usr/lib/gconv/gconv-modules.cache
b269f000 b2e9e000 rwxp [stack:14883]
b2e9e000 b2fc4000 r-xp /usr/share/fallback_fonts/SamsungKoreanCondensed-Regular.ttf
b2fc4000 b3010000 r-xp /usr/share/app_fonts/SamsungCondensed-1R.ttf
b3010000 b304a000 r-xp /usr/share/fonts/SamsungSans_Rg.ttf
b304a000 b3059000 r-xs /opt/var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-4
b3059000 b305f000 r-xs /opt/var/cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-4
b305f000 b3062000 r-xs /opt/var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-4
b3063000 b3862000 rwxp [stack:14884]
b3863000 b4062000 rwxp [stack:14885]
b4062000 b41e4000 r-xs /usr/share/elementary/themes/default.edj
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
b6fff000 b7000000 rwxp /lib/ld-2.13.so
befdf000 bf000000 rwxp [stack]
End of Maps Information

Callstack Information (PID:14803)
Call Stack Count: 2
 0: fclose + 0x8 (0xb6c09fc4) [/lib/libc.so.6] + 0x58fc4
 1: labels_update_cb + 0x198 (0x2a004b1d) [/opt/usr/apps/org.samteam.perfectsong/bin/paaaaaaaaa] + 0x4b1d
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
w-mgr.c: mp_external_view_mgr_post_event(227) > [33m[TID:11252]   event = 121[0m
08-13 21:05:55.860+0900 I/Tizen::Net::Wifi(  970): (1072) > _WifiService is not registered.
08-13 21:05:55.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 21:05:55.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 21:05:55.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 21:05:55.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 306 5 28 25"
08-13 21:05:55.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 334 5 28 25"
08-13 21:05:55.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 362 5 28 25"
08-13 21:05:55.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 390 5 28 25"
08-13 21:05:55.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 418 5 28 25"
08-13 21:05:55.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 21:05:55.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 21:05:55.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 21:05:55.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 626 5 28 25"
08-13 21:05:55.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 654 5 28 25"
08-13 21:05:55.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 682 5 28 25"
08-13 21:05:55.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 710 5 28 25"
08-13 21:05:55.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 738 5 28 25"
08-13 21:06:02.860+0900 I/Tizen::Net::Wifi(  970): (1072) > _WifiService is not registered.
08-13 21:06:02.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 21:06:02.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 21:06:02.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 21:06:02.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 306 5 28 25"
08-13 21:06:02.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 334 5 28 25"
08-13 21:06:02.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 362 5 28 25"
08-13 21:06:02.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 390 5 28 25"
08-13 21:06:02.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 418 5 28 25"
08-13 21:06:02.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 21:06:02.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 21:06:02.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 21:06:02.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 626 5 28 25"
08-13 21:06:02.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 654 5 28 25"
08-13 21:06:02.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 682 5 28 25"
08-13 21:06:02.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 710 5 28 25"
08-13 21:06:02.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 738 5 28 25"
08-13 21:06:03.860+0900 I/Tizen::Net::Wifi(  970): (1072) > _WifiService is not registered.
08-13 21:06:03.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 21:06:03.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 21:06:03.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 21:06:03.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 306 5 28 25"
08-13 21:06:03.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 334 5 28 25"
08-13 21:06:03.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 362 5 28 25"
08-13 21:06:03.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 390 5 28 25"
08-13 21:06:03.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 418 5 28 25"
08-13 21:06:03.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 21:06:03.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 21:06:03.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 21:06:03.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 626 5 28 25"
08-13 21:06:03.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 654 5 28 25"
08-13 21:06:03.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 682 5 28 25"
08-13 21:06:03.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 710 5 28 25"
08-13 21:06:03.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 738 5 28 25"
08-13 21:06:05.860+0900 I/Tizen::Net::Wifi(  970): (1072) > _WifiService is not registered.
08-13 21:06:05.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 21:06:05.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 21:06:05.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 21:06:05.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 306 5 28 25"
08-13 21:06:05.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 334 5 28 25"
08-13 21:06:05.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 362 5 28 25"
08-13 21:06:05.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 390 5 28 25"
08-13 21:06:05.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 418 5 28 25"
08-13 21:06:05.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 21:06:05.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 21:06:05.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 21:06:05.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 626 5 28 25"
08-13 21:06:05.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 654 5 28 25"
08-13 21:06:05.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 682 5 28 25"
08-13 21:06:05.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 710 5 28 25"
08-13 21:06:05.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 738 5 28 25"
08-13 21:06:09.620+0900 E/PKGMGR  (14722): pkgmgr-internal.c: _get_type_from_zip(634) > can not access to [org.samteam.perfectsong]
08-13 21:06:09.620+0900 E/PKGMGR_SERVER(14722): pkgmgr-server.c: __get_type_from_msg(283) > [0;31m[__get_type_from_msg(): 283](pkgtype == NULL) pkgtype is null for org.samteam.perfectsong 
08-13 21:06:09.620+0900 E/PKGMGR_SERVER(14722): [0;m
08-13 21:06:09.790+0900 I/Tizen::App(  902): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.samteam.perfectsong, key: start, val: update
08-13 21:06:09.790+0900 I/Tizen::App(  902): (1584) > Package = [org.samteam.perfectsong], Key = [start], Value = [update], install = [96]
08-13 21:06:09.800+0900 W/AUL_AMD (  438): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(580) > __amd_pkgmgrinfo_start_handler
08-13 21:06:09.800+0900 I/Tizen::App(  902): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.samteam.perfectsong, key: install_percent, val: 30
08-13 21:06:09.800+0900 I/Tizen::App(  902): (119) > InstallationInProgress [30]
08-13 21:06:09.800+0900 I/Tizen::App(  902): (1584) > Package = [org.samteam.perfectsong], Key = [install_percent], Value = [30], install = [1]
08-13 21:06:09.860+0900 I/Tizen::Net::Wifi(  970): (1072) > _WifiService is not registered.
08-13 21:06:09.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 21:06:09.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 21:06:09.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 21:06:09.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 306 5 28 25"
08-13 21:06:09.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 334 5 28 25"
08-13 21:06:09.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 362 5 28 25"
08-13 21:06:09.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 390 5 28 25"
08-13 21:06:09.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 418 5 28 25"
08-13 21:06:09.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 21:06:09.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 21:06:09.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 21:06:09.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 626 5 28 25"
08-13 21:06:09.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 654 5 28 25"
08-13 21:06:09.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 682 5 28 25"
08-13 21:06:09.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 710 5 28 25"
08-13 21:06:09.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 738 5 28 25"
08-13 21:06:09.890+0900 I/CAPI_APPFW_APPLICATION( 1124): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 21:06:09.890+0900 I/CAPI_APPFW_APPLICATION(11252): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 21:06:09.890+0900 W/MUSIC_PLAYER(11252): mp-main.c: mp_device_orientation(2354) > [36m[TID:11252]   [MUSIC_PLAYER_EVENT][0m
08-13 21:06:09.890+0900 I/CAPI_APPFW_APPLICATION(  700): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 21:06:09.890+0900 W/CAM_APP ( 1124): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-13 21:06:09.960+0900 I/CAPI_APPFW_APPLICATION( 1122): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 21:06:11.060+0900 E/PKGMGR_CERT(14723): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
08-13 21:06:11.070+0900 E/PKGMGR_CERT(14723): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 105
08-13 21:06:11.070+0900 I/Tizen::App(  902): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.samteam.perfectsong, key: install_percent, val: 60
08-13 21:06:11.070+0900 I/Tizen::App(  902): (119) > InstallationInProgress [60]
08-13 21:06:11.070+0900 I/Tizen::App(  902): (1584) > Package = [org.samteam.perfectsong], Key = [install_percent], Value = [60], install = [1]
08-13 21:06:11.070+0900 E/PKGMGR_CERT(14723): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 105
08-13 21:06:11.070+0900 E/PKGMGR_CERT(14723): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 25 16
08-13 21:06:11.070+0900 E/PKGMGR_CERT(14723): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 22 18
08-13 21:06:11.070+0900 E/PKGMGR_CERT(14723): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 23 18
08-13 21:06:11.070+0900 E/PKGMGR_CERT(14723): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 26 16
08-13 21:06:11.090+0900 E/PKGMGR_CERT(14723): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(571) > Transaction Commit and End
08-13 21:06:11.090+0900 E/rpm-installer(14723): coretpk-installer.c: _coretpk_installer_make_directory(1784) > mkdir failed. appdir=[/usr/apps/org.samteam.perfectsong/shared], errno=[2][No such file or directory]
08-13 21:06:11.090+0900 E/rpm-installer(14723): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1406) > skip! empty dirpath=[/usr/apps/org.samteam.perfectsong/shared]
08-13 21:06:11.090+0900 E/rpm-installer(14723): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1406) > skip! empty dirpath=[/opt/usr/apps/org.samteam.perfectsong/shared/data]
08-13 21:06:11.090+0900 E/rpm-installer(14723): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1406) > skip! empty dirpath=[/usr/apps/org.samteam.perfectsong/shared/res]
08-13 21:06:11.090+0900 E/rpm-installer(14723): coretpk-installer.c: _coretpk_installer_apply_file_policy(1391) > skip! empty filepath=[/usr/apps/org.samteam.perfectsong/tizen-manifest.xml]
08-13 21:06:11.090+0900 E/rpm-installer(14723): coretpk-installer.c: _coretpk_installer_apply_file_policy(1391) > skip! empty filepath=[/usr/apps/org.samteam.perfectsong/author-signature.xml]
08-13 21:06:11.090+0900 E/rpm-installer(14723): coretpk-installer.c: _coretpk_installer_apply_file_policy(1391) > skip! empty filepath=[/usr/apps/org.samteam.perfectsong/signature1.xml]
08-13 21:06:11.090+0900 E/rpm-installer(14723): coretpk-installer.c: _coretpk_installer_apply_file_policy(1391) > skip! empty filepath=[/usr/share/packages/org.samteam.perfectsong.xml]
08-13 21:06:11.610+0900 E/rpm-installer(14723): coretpk-installer.c: _coretpk_installer_get_smack_label_access(964) > Error in getting smack ACCESS label failed. result[-1] (path:[/opt/usr/apps/org.samteam.perfectsong/shared/data]))
08-13 21:06:12.550+0900 E/PKGMGR_INFO(14723): pkgmgrinfo_feature.c: pkgmgrinfo_updateinfo_remove(528) > (strstr(vconf_str, pkgid_is) == NULL) pkgid is already removed
08-13 21:06:12.550+0900 E/PKGMGR_INSTALLER(14723): pkgmgr_installer.c: __send_event(114) > fail to remove update-service
08-13 21:06:12.550+0900 I/Tizen::App(  902): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.samteam.perfectsong, key: install_percent, val: 100
08-13 21:06:12.550+0900 I/Tizen::App(  902): (119) > InstallationInProgress [100]
08-13 21:06:12.550+0900 I/Tizen::App(  902): (1584) > Package = [org.samteam.perfectsong], Key = [install_percent], Value = [100], install = [96]
08-13 21:06:12.550+0900 I/Tizen::App(  902): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.samteam.perfectsong, key: end, val: ok
08-13 21:06:12.550+0900 I/Tizen::App(  902): (78) > Installation is Completed. [Package = org.samteam.perfectsong]
08-13 21:06:12.550+0900 I/Tizen::App(  902): (663) > Enter. package(org.samteam.perfectsong), installationResult(0)
08-13 21:06:12.560+0900 E/cluster-home(  588): mainmenu-package-manager.cpp: OnClientListenCb(535) >  #Step 1
08-13 21:06:12.560+0900 E/cluster-home(  588): mainmenu-package-manager.cpp: OnClientListenCb(539) >  #Step 2
08-13 21:06:12.560+0900 E/cluster-home(  588): mainmenu-package-manager.cpp: _GetAppIds(344) >  BEGIN
08-13 21:06:12.560+0900 I/Tizen::App(  902): (1360) > package(org.samteam.perfectsong), version(1.0.0), type(rpm), displayName(paaaaaaaaa), uninstallable(1), downloaded(1), updated(1), preloaded(0)movable(1), externalStorage(0), mainApp(org.samteam.perfectsong), storeClient(), appRootPath(/opt/usr/apps/org.samteam.perfectsong)
08-13 21:06:12.600+0900 I/Tizen::App(  902): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.samteam.perfectsong]
08-13 21:06:12.600+0900 E/cluster-home(  588): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(246) >  ##### [org.samteam.perfectsong]
08-13 21:06:12.600+0900 E/cluster-home(  588): mainmenu-package-manager.cpp: _GetAppIds(365) >  ##### [org.samteam.perfectsong]
08-13 21:06:12.600+0900 E/cluster-home(  588): mainmenu-package-manager.cpp: _GetAppIds(369) >  END
08-13 21:06:12.600+0900 E/cluster-home(  588): mainmenu-package-manager.cpp: _DoPkgJob(448) >  #Step 3 size[1]
08-13 21:06:12.600+0900 E/cluster-home(  588): mainmenu-package-manager.cpp: _DoPkgJob(452) >  appId[org.samteam.perfectsong]
08-13 21:06:12.620+0900 I/Tizen::App(  902): (416) > appName = [paaaaaaaaa]
08-13 21:06:12.630+0900 I/Tizen::App(  902): (509) > exe = [/opt/usr/apps/org.samteam.perfectsong/bin/paaaaaaaaa], displayName = [paaaaaaaaa], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
08-13 21:06:12.630+0900 E/cluster-home(  588): mainmenu-package-manager.cpp: _GetAppInfo(941) >  AppId[org.samteam.perfectsong] Name[paaaaaaaaa] Icon[/opt/usr/apps/org.samteam.perfectsong/shared/res/mainIcon.png] enable[1] system[0]
08-13 21:06:12.630+0900 E/PKGMGR_INFO(  902): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(717) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
08-13 21:06:12.630+0900 I/Tizen::App(  902): (675) > Application count(1) in this package
08-13 21:06:12.630+0900 E/cluster-home(  588): mainmenu-package-manager.cpp: GetAppInfo(595) >  Find a App Info AppId[org.samteam.perfectsong] Name[paaaaaaaaa] Icon[/opt/usr/apps/org.samteam.perfectsong/shared/res/mainIcon.png] enable[1] system[0]
08-13 21:06:12.630+0900 I/Tizen::App(  902): (855) > Enter.
08-13 21:06:12.640+0900 I/Tizen::App(  902): (695) > Exit.
08-13 21:06:12.640+0900 I/Tizen::App(  902): (1584) > Package = [org.samteam.perfectsong], Key = [end], Value = [ok], install = [1]
08-13 21:06:12.640+0900 I/Tizen::App(  902): (416) > appName = [paaaaaaaaa]
08-13 21:06:12.640+0900 I/Tizen::App(  902): (509) > exe = [/opt/usr/apps/org.samteam.perfectsong/bin/paaaaaaaaa], displayName = [paaaaaaaaa], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
08-13 21:06:12.640+0900 I/Tizen::App(  902): (2343) > info file is not existed. [/opt/usr/apps/org.samtea/info/org.samteam.perfectsong.info]
08-13 21:06:12.640+0900 I/Tizen::App(  902): (131) > Enter
08-13 21:06:12.650+0900 I/Tizen::App(  902): (137) > org.samteam.perfectsong does not have launch condition
08-13 21:06:12.650+0900 I/Tizen::App(  902): (898) > Exit.
08-13 21:06:14.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 21:06:14.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 21:06:14.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 21:06:14.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 306 5 28 25"
08-13 21:06:14.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 334 5 28 25"
08-13 21:06:14.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 362 5 28 25"
08-13 21:06:14.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 390 5 28 25"
08-13 21:06:14.880+0900 I/Tizen::Net::Wifi(  970): (1072) > _WifiService is not registered.
08-13 21:06:14.880+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 418 5 28 25"
08-13 21:06:14.880+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 21:06:14.880+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 21:06:14.890+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 21:06:14.890+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 626 5 28 25"
08-13 21:06:14.890+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 654 5 28 25"
08-13 21:06:14.890+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 682 5 28 25"
08-13 21:06:14.890+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 710 5 28 25"
08-13 21:06:14.890+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 738 5 28 25"
08-13 21:06:15.030+0900 W/AUL_AMD (  438): amd_request.c: __request_handler(601) > __request_handler: 0
08-13 21:06:15.040+0900 I/AUL     (  438): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/launch_app, ret : 0
08-13 21:06:15.050+0900 I/AUL     (  438): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /bin/bash, ret : 0
08-13 21:06:15.050+0900 E/AUL_AMD (  438): amd_appinfo.c: appinfo_get_value(791) > appinfo get value: Invalid argument, 24
08-13 21:06:15.170+0900 E/DBG_PAD ( 9321): launchpad.c: __launchpad_main_loop(1204) > faild to get app pid
08-13 21:06:15.180+0900 E/RESOURCED(  766): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 427
08-13 21:06:15.190+0900 I/AUL     (  902): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /home/developer/sdk_tools/gdbserver/gdbserver, ret : 0
08-13 21:06:15.190+0900 I/AUL     (  940): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /home/developer/sdk_tools/gdbserver/gdbserver, ret : 0
08-13 21:06:15.200+0900 I/AUL     (  902): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /home/developer/sdk_tools/gdbserver/gdbserver, ret : 0
08-13 21:06:15.200+0900 E/Tizen::App(  902): (703) > Cannot acquire app for 14800.
08-13 21:06:15.200+0900 I/AUL     (  940): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /home/developer/sdk_tools/gdbserver/gdbserver, ret : 0
08-13 21:06:15.200+0900 E/Tizen::App(  940): (703) > Cannot acquire app for 14800.
08-13 21:06:16.170+0900 W/AUL_AMD (  438): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
08-13 21:06:16.170+0900 W/AUL_AMD (  438): amd_launch.c: __grab_timeout_handler(1309) > back key ungrab error
08-13 21:06:21.880+0900 I/CAPI_APPFW_APPLICATION(14803): app_main.c: ui_app_main(699) > app_efl_main
08-13 21:06:21.940+0900 I/UXT     (14803): uxt_object_manager.cpp: on_initialized(287) > Initialized.
08-13 21:06:22.530+0900 I/CAPI_APPFW_APPLICATION(14803): app_main.c: _ui_app_appcore_create(560) > app_appcore_create
08-13 21:06:24.330+0900 E/EFL     (14803): elementary<14803> elm_layout.c:833 _elm_layout_smart_content_set() could not swallow 0x2a316410 into part ''
08-13 21:06:24.830+0900 E/EFL     (14803): evas_main<14803> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
08-13 21:06:24.850+0900 E/EFL     (14803): evas_main<14803> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
08-13 21:06:25.050+0900 I/TIZEN_N_AUDIO_IO(14803): audio_io_private.c: audio_in_create_private(267) > mm_sound_pcm_capture_open_ex() success
08-13 21:06:25.050+0900 I/TIZEN_N_AUDIO_IO(14803): audio_io_private.c: audio_in_create_private(285) > mm_sound_pcm_set_message_callback() success
08-13 21:06:25.060+0900 I/TIZEN_N_AUDIO_IO(14803): audio_io.c: audio_in_prepare(88) > [audio_in_prepare] mm_sound_pcm_capture_start() success
08-13 21:06:25.060+0900 I/CAPI_APPFW_APPLICATION(14803): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
08-13 21:06:25.060+0900 E/PKGMGR_INFO(14803): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_appinfo(1347) > (appid == NULL) appid is NULL
08-13 21:06:25.060+0900 I/APP_CORE(14803): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
08-13 21:06:25.060+0900 I/APP_CORE(14803): appcore-efl.c: __do_app(511) > [APP 14803] Initial Launching, call the resume_cb
08-13 21:06:25.060+0900 I/CAPI_APPFW_APPLICATION(14803): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
08-13 21:06:25.170+0900 W/PROCESSMGR(  378): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=14803
08-13 21:06:25.200+0900 W/APP_CORE(14803): appcore-efl.c: __show_cb(822) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1200002
08-13 21:06:25.210+0900 I/QUICKPANEL(  666): sound-profile.c: _view_update(106) > [_view_update : 106] sound : 1, vibration : 0
08-13 21:06:25.220+0900 I/QUICKPANEL(  666): quickpanel-ui.c: _ui_handler_input_region_set(172) > [_ui_handler_input_region_set : 172] win_input_0:0
08-13 21:06:25.220+0900 I/QUICKPANEL(  666): win_input_1:0
08-13 21:06:25.220+0900 I/QUICKPANEL(  666): win_input_2:42
08-13 21:06:25.220+0900 I/QUICKPANEL(  666): win_input_3:800
08-13 21:06:25.220+0900 I/QUICKPANEL(  666): 
08-13 21:06:25.240+0900 I/MALI    (  588): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0xb0636300] swap changed from sync to async
08-13 21:06:25.360+0900 I/Tizen::System(  940): (259) > Active app [org.samtea], current [com.samsun] 
08-13 21:06:25.360+0900 I/Tizen::Io(  940): (729) > Entry not found
08-13 21:06:25.370+0900 I/Tizen::System(  940): (157) > change brightness system value.
08-13 21:06:25.400+0900 I/CAPI_APPFW_APPLICATION(  588): app_main.c: app_appcore_pause(202) > app_appcore_pause
08-13 21:06:25.400+0900 E/cluster-home(  588): homescreen-main.cpp: app_pause(355) >  app pause
08-13 21:06:25.410+0900 W/AUL_AMD (  438): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
08-13 21:06:25.410+0900 W/AUL_AMD (  438): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
08-13 21:06:27.610+0900 E/record  (14803): buffer size : 4410000
08-13 21:06:27.630+0900 E/record  (14803): pitch_detect_routine start
08-13 21:06:27.630+0900 I/record  (14803): [A0] [라] [27.50 Hz]
08-13 21:06:27.790+0900 I/record  (14803): [A2] [라] [110.00 Hz]
08-13 21:06:27.790+0900 I/record  (14803): [A0] [라] [27.50 Hz]
08-13 21:06:27.790+0900 I/record  (14803): [A0] [라] [27.50 Hz]
08-13 21:06:27.870+0900 I/record  (14803): [C1] [도] [32.70 Hz]
08-13 21:06:27.950+0900 I/record  (14803): [A0] [라] [27.50 Hz]
08-13 21:06:28.020+0900 I/record  (14803): [G#3] [솔#] [207.70 Hz]
08-13 21:06:28.090+0900 I/record  (14803): [A4] [라] [440.00 Hz]
08-13 21:06:28.090+0900 I/record  (14803): [A0] [라] [27.50 Hz]
08-13 21:06:28.090+0900 I/record  (14803): [A0] [라] [27.50 Hz]
08-13 21:06:28.090+0900 I/record  (14803): [A0] [라] [27.50 Hz]
08-13 21:06:28.090+0900 I/record  (14803): [A0] [라] [27.50 Hz]
08-13 21:06:28.090+0900 I/record  (14803): [A0] [라] [27.50 Hz]
08-13 21:06:28.090+0900 I/record  (14803): [A0] [라] [27.50 Hz]
08-13 21:06:28.100+0900 I/record  (14803): [A0] [라] [27.50 Hz]
08-13 21:06:28.100+0900 I/record  (14803): [A0] [라] [27.50 Hz]
08-13 21:06:28.220+0900 I/record  (14803): [A0] [라] [27.50 Hz]
08-13 21:06:28.420+0900 I/record  (14803): [A0] [라] [27.50 Hz]
08-13 21:06:28.580+0900 I/record  (14803): [A0] [라] [27.50 Hz]
08-13 21:06:28.870+0900 I/record  (14803): [A0] [라] [27.50 Hz]
08-13 21:06:29.060+0900 I/record  (14803): [C#4] [도#] [277.20 Hz]
08-13 21:06:29.140+0900 I/record  (14803): [A0] [라] [27.50 Hz]
08-13 21:06:29.420+0900 I/record  (14803): [B2] [시] [123.50 Hz]
08-13 21:06:29.580+0900 I/record  (14803): [A#2] [라#] [116.50 Hz]
08-13 21:06:29.780+0900 I/record  (14803): [A#2] [라#] [116.50 Hz]
08-13 21:06:30.000+0900 I/record  (14803): [A#2] [라#] [116.50 Hz]
08-13 21:06:30.140+0900 I/record  (14803): [A2] [라] [110.00 Hz]
08-13 21:06:30.340+0900 I/record  (14803): [A#2] [라#] [116.50 Hz]
08-13 21:06:30.550+0900 I/record  (14803): [A2] [라] [110.00 Hz]
08-13 21:06:30.700+0900 I/record  (14803): [A#2] [라#] [116.50 Hz]
08-13 21:06:30.830+0900 I/record  (14803): [A0] [라] [27.50 Hz]
08-13 21:06:31.100+0900 I/record  (14803): [C3] [도] [130.80 Hz]
08-13 21:06:31.270+0900 I/record  (14803): [C3] [도] [130.80 Hz]
08-13 21:06:31.460+0900 I/record  (14803): [C3] [도] [130.80 Hz]
08-13 21:06:31.620+0900 I/record  (14803): [B2] [시] [123.50 Hz]
08-13 21:06:31.820+0900 I/record  (14803): [C3] [도] [130.80 Hz]
08-13 21:06:32.030+0900 I/record  (14803): [B2] [시] [123.50 Hz]
08-13 21:06:32.180+0900 I/record  (14803): [C3] [도] [130.80 Hz]
08-13 21:06:32.390+0900 I/record  (14803): [C3] [도] [130.80 Hz]
08-13 21:06:32.580+0900 I/record  (14803): [C3] [도] [130.80 Hz]
08-13 21:06:32.740+0900 I/record  (14803): [C3] [도] [130.80 Hz]
08-13 21:06:32.940+0900 I/record  (14803): [C3] [도] [130.80 Hz]
08-13 21:06:33.150+0900 I/record  (14803): [C3] [도] [130.80 Hz]
08-13 21:06:33.310+0900 I/record  (14803): [C3] [도] [130.80 Hz]
08-13 21:06:33.310+0900 F/record  (14803): pass! [C3] [도]
08-13 21:06:33.380+0900 I/TIZEN_N_PLAYER(14803): player.c: player_create(1091) > [player_create] new handle : 0x2a633908
08-13 21:06:33.410+0900 F/rrss    (14803): /opt/usr/apps/org.samteam.perfectsong/res/PASS1.wav
08-13 21:06:33.410+0900 I/TIZEN_N_PLAYER(14803): player.c: player_prepare(1272) > [player_prepare] Start
08-13 21:06:33.880+0900 W/TIZEN_N_PLAYER(14803): player.c: __msg_callback(660) > [__msg_callback] Got message type : 0x3
08-13 21:06:33.880+0900 I/TIZEN_N_PLAYER(14803): player.c: __msg_callback(686) > STATE CHANGED INTERNALLY - from : 0,  to : 1 (CAPI State : 1)
08-13 21:06:33.880+0900 W/TIZEN_N_PLAYER(14803): player.c: __msg_callback(859) > [__msg_callback] End
08-13 21:06:34.410+0900 I/record  (14803): [C3] [도] [130.80 Hz]
08-13 21:06:36.220+0900 I/record  (14803): [C3] [도] [130.80 Hz]
08-13 21:06:36.600+0900 I/record  (14803): [C3] [도] [130.80 Hz]
08-13 21:06:36.940+0900 I/record  (14803): [C3] [도] [130.80 Hz]
08-13 21:06:37.000+0900 W/TIZEN_N_PLAYER(14803): player.c: __msg_callback(660) > [__msg_callback] Got message type : 0x3
08-13 21:06:37.000+0900 I/TIZEN_N_PLAYER(14803): player.c: __msg_callback(686) > STATE CHANGED INTERNALLY - from : 1,  to : 3 (CAPI State : 1)
08-13 21:06:37.000+0900 W/TIZEN_N_PLAYER(14803): player.c: __msg_callback(859) > [__msg_callback] End
08-13 21:06:37.000+0900 I/TIZEN_N_PLAYER(14803): player.c: player_prepare(1343) > [player_prepare] End
08-13 21:06:37.000+0900 I/TIZEN_N_PLAYER(14803): player.c: player_start(1582) > [player_start] Start
08-13 21:06:37.010+0900 W/TIZEN_N_PLAYER(14803): player.c: __msg_callback(660) > [__msg_callback] Got message type : 0x3
08-13 21:06:37.010+0900 I/TIZEN_N_PLAYER(14803): player.c: __msg_callback(686) > STATE CHANGED INTERNALLY - from : 3,  to : 2 (CAPI State : 2)
08-13 21:06:37.010+0900 W/TIZEN_N_PLAYER(14803): player.c: __msg_callback(859) > [__msg_callback] End
08-13 21:06:37.010+0900 W/TIZEN_N_PLAYER(14803): player.c: __msg_callback(660) > [__msg_callback] Got message type : 0x104
08-13 21:06:37.010+0900 I/TIZEN_N_PLAYER(14803): player.c: __msg_callback(708) > [__msg_callback] Ready to streaming information (BOS) [current state : 2]
08-13 21:06:37.010+0900 W/TIZEN_N_PLAYER(14803): player.c: __msg_callback(859) > [__msg_callback] End
08-13 21:06:37.010+0900 I/TIZEN_N_PLAYER(14803): player.c: player_start(1632) > [player_start] End
08-13 21:06:37.010+0900 F/record  (14803): <font_size=53><color=#000000>레 (D3)</color></font_size>
08-13 21:06:37.060+0900 I/record  (14803): [C3] [도] [130.80 Hz]
08-13 21:06:37.130+0900 I/record  (14803): [G7] [솔] [3136.00 Hz]
08-13 21:06:37.200+0900 I/record  (14803): [C3] [도] [130.80 Hz]
08-13 21:06:37.270+0900 I/record  (14803): [C3] [도] [130.80 Hz]
08-13 21:06:37.330+0900 I/record  (14803): [C3] [도] [130.80 Hz]
08-13 21:06:37.400+0900 I/record  (14803): [C3] [도] [130.80 Hz]
08-13 21:06:37.470+0900 I/record  (14803): [C3] [도] [130.80 Hz]
08-13 21:06:37.530+0900 I/record  (14803): [C3] [도] [130.80 Hz]
08-13 21:06:37.600+0900 I/record  (14803): [C3] [도] [130.80 Hz]
08-13 21:06:37.660+0900 I/record  (14803): [C3] [도] [130.80 Hz]
08-13 21:06:37.730+0900 I/record  (14803): [C3] [도] [130.80 Hz]
08-13 21:06:37.790+0900 I/record  (14803): [C#3] [도#] [138.60 Hz]
08-13 21:06:37.860+0900 I/record  (14803): [C#3] [도#] [138.60 Hz]
08-13 21:06:37.920+0900 I/record  (14803): [C#3] [도#] [138.60 Hz]
08-13 21:06:37.990+0900 I/record  (14803): [C#3] [도#] [138.60 Hz]
08-13 21:06:38.060+0900 I/record  (14803): [C#3] [도#] [138.60 Hz]
08-13 21:06:38.060+0900 W/TIZEN_N_PLAYER(14803): player.c: __msg_callback(660) > [__msg_callback] Got message type : 0x105
08-13 21:06:38.060+0900 W/TIZEN_N_PLAYER(14803): player.c: __msg_callback(859) > [__msg_callback] End
08-13 21:06:38.120+0900 I/record  (14803): [C3] [도] [130.80 Hz]
08-13 21:06:38.190+0900 I/record  (14803): [C3] [도] [130.80 Hz]
08-13 21:06:38.250+0900 I/record  (14803): [C3] [도] [130.80 Hz]
08-13 21:06:38.250+0900 I/record  (14803): [A0] [라] [27.50 Hz]
08-13 21:06:38.250+0900 I/record  (14803): [A0] [라] [27.50 Hz]
08-13 21:06:38.250+0900 I/record  (14803): [A0] [라] [27.50 Hz]
08-13 21:06:38.260+0900 I/record  (14803): [A0] [라] [27.50 Hz]
08-13 21:06:38.490+0900 I/record  (14803): [D3] [레 ] [146.80 Hz]
08-13 21:06:38.700+0900 I/record  (14803): [D3] [레 ] [146.80 Hz]
08-13 21:06:38.900+0900 I/record  (14803): [D3] [레 ] [146.80 Hz]
08-13 21:06:39.060+0900 I/record  (14803): [D3] [레 ] [146.80 Hz]
08-13 21:06:39.260+0900 I/record  (14803): [D3] [레 ] [146.80 Hz]
08-13 21:06:39.460+0900 I/record  (14803): [D3] [레 ] [146.80 Hz]
08-13 21:06:39.620+0900 I/record  (14803): [D3] [레 ] [146.80 Hz]
08-13 21:06:39.620+0900 F/record  (14803): pass! [D3] [레 ]
08-13 21:06:39.640+0900 I/TIZEN_N_PLAYER(14803): player.c: player_create(1091) > [player_create] new handle : 0x2a531310
08-13 21:06:39.640+0900 F/rrss    (14803): /opt/usr/apps/org.samteam.perfectsong/res/PASS1.wav
08-13 21:06:39.640+0900 I/TIZEN_N_PLAYER(14803): player.c: player_prepare(1272) > [player_prepare] Start
08-13 21:06:39.640+0900 W/TIZEN_N_PLAYER(14803): player.c: __msg_callback(660) > [__msg_callback] Got message type : 0x3
08-13 21:06:39.640+0900 I/TIZEN_N_PLAYER(14803): player.c: __msg_callback(686) > STATE CHANGED INTERNALLY - from : 0,  to : 1 (CAPI State : 1)
08-13 21:06:39.640+0900 W/TIZEN_N_PLAYER(14803): player.c: __msg_callback(859) > [__msg_callback] End
08-13 21:06:39.710+0900 W/TIZEN_N_PLAYER(14803): player.c: __msg_callback(660) > [__msg_callback] Got message type : 0x3
08-13 21:06:39.710+0900 I/TIZEN_N_PLAYER(14803): player.c: __msg_callback(686) > STATE CHANGED INTERNALLY - from : 1,  to : 3 (CAPI State : 1)
08-13 21:06:39.710+0900 W/TIZEN_N_PLAYER(14803): player.c: __msg_callback(859) > [__msg_callback] End
08-13 21:06:39.710+0900 I/TIZEN_N_PLAYER(14803): player.c: player_prepare(1343) > [player_prepare] End
08-13 21:06:39.710+0900 I/TIZEN_N_PLAYER(14803): player.c: player_start(1582) > [player_start] Start
08-13 21:06:39.710+0900 W/TIZEN_N_PLAYER(14803): player.c: __msg_callback(660) > [__msg_callback] Got message type : 0x3
08-13 21:06:39.710+0900 I/TIZEN_N_PLAYER(14803): player.c: __msg_callback(686) > STATE CHANGED INTERNALLY - from : 3,  to : 2 (CAPI State : 2)
08-13 21:06:39.710+0900 W/TIZEN_N_PLAYER(14803): player.c: __msg_callback(859) > [__msg_callback] End
08-13 21:06:39.710+0900 W/TIZEN_N_PLAYER(14803): player.c: __msg_callback(660) > [__msg_callback] Got message type : 0x104
08-13 21:06:39.710+0900 I/TIZEN_N_PLAYER(14803): player.c: __msg_callback(708) > [__msg_callback] Ready to streaming information (BOS) [current state : 2]
08-13 21:06:39.710+0900 W/TIZEN_N_PLAYER(14803): player.c: __msg_callback(859) > [__msg_callback] End
08-13 21:06:39.710+0900 I/TIZEN_N_PLAYER(14803): player.c: player_start(1632) > [player_start] End
08-13 21:06:39.710+0900 F/record  (14803): <font_size=53><color=#000000>미(E3)</color></font_size>
08-13 21:06:39.830+0900 I/record  (14803): [D3] [레 ] [146.80 Hz]
08-13 21:06:40.010+0900 I/record  (14803): [D3] [레 ] [146.80 Hz]
08-13 21:06:40.170+0900 I/record  (14803): [D3] [레 ] [146.80 Hz]
08-13 21:06:40.290+0900 I/record  (14803): [A0] [라] [27.50 Hz]
08-13 21:06:40.490+0900 I/record  (14803): [A0] [라] [27.50 Hz]
08-13 21:06:40.650+0900 I/record  (14803): [A0] [라] [27.50 Hz]
08-13 21:06:40.760+0900 W/TIZEN_N_PLAYER(14803): player.c: __msg_callback(660) > [__msg_callback] Got message type : 0x105
08-13 21:06:40.760+0900 W/TIZEN_N_PLAYER(14803): player.c: __msg_callback(859) > [__msg_callback] End
08-13 21:06:40.850+0900 I/record  (14803): [A0] [라] [27.50 Hz]
08-13 21:06:41.130+0900 I/record  (14803): [F3] [파] [174.60 Hz]
08-13 21:06:41.290+0900 I/record  (14803): [F3] [파] [174.60 Hz]
08-13 21:06:41.470+0900 I/record  (14803): [F3] [파] [174.60 Hz]
08-13 21:06:41.670+0900 I/record  (14803): [G7] [솔] [3136.00 Hz]
08-13 21:06:41.870+0900 I/record  (14803): [E3] [미] [164.80 Hz]
08-13 21:06:42.030+0900 I/record  (14803): [D#3] [레#] [155.60 Hz]
08-13 21:06:42.230+0900 I/record  (14803): [D#2] [레#] [77.80 Hz]
08-13 21:06:42.430+0900 I/record  (14803): [E3] [미] [164.80 Hz]
08-13 21:06:42.590+0900 I/record  (14803): [E3] [미] [164.80 Hz]
08-13 21:06:42.790+0900 I/record  (14803): [D#3] [레#] [155.60 Hz]
08-13 21:06:42.970+0900 I/record  (14803): [E3] [미] [164.80 Hz]
08-13 21:06:43.180+0900 I/record  (14803): [E3] [미] [164.80 Hz]
08-13 21:06:43.340+0900 I/record  (14803): [E3] [미] [164.80 Hz]
08-13 21:06:43.550+0900 I/record  (14803): [E3] [미] [164.80 Hz]
08-13 21:06:43.710+0900 I/record  (14803): [E3] [미] [164.80 Hz]
08-13 21:06:43.920+0900 I/record  (14803): [E3] [미] [164.80 Hz]
08-13 21:06:44.070+0900 I/record  (14803): [E3] [미] [164.80 Hz]
08-13 21:06:44.080+0900 F/record  (14803): pass! [E3] [미]
08-13 21:06:44.090+0900 I/TIZEN_N_PLAYER(14803): player.c: player_create(1091) > [player_create] new handle : 0x2a631578
08-13 21:06:44.090+0900 F/rrss    (14803): /opt/usr/apps/org.samteam.perfectsong/res/PASS1.wav
08-13 21:06:44.090+0900 I/TIZEN_N_PLAYER(14803): player.c: player_prepare(1272) > [player_prepare] Start
08-13 21:06:44.100+0900 W/TIZEN_N_PLAYER(14803): player.c: __msg_callback(660) > [__msg_callback] Got message type : 0x3
08-13 21:06:44.100+0900 I/TIZEN_N_PLAYER(14803): player.c: __msg_callback(686) > STATE CHANGED INTERNALLY - from : 0,  to : 1 (CAPI State : 1)
08-13 21:06:44.100+0900 W/TIZEN_N_PLAYER(14803): player.c: __msg_callback(859) > [__msg_callback] End
08-13 21:06:44.170+0900 W/TIZEN_N_PLAYER(14803): player.c: __msg_callback(660) > [__msg_callback] Got message type : 0x3
08-13 21:06:44.170+0900 I/TIZEN_N_PLAYER(14803): player.c: __msg_callback(686) > STATE CHANGED INTERNALLY - from : 1,  to : 3 (CAPI State : 1)
08-13 21:06:44.170+0900 W/TIZEN_N_PLAYER(14803): player.c: __msg_callback(859) > [__msg_callback] End
08-13 21:06:44.170+0900 I/TIZEN_N_PLAYER(14803): player.c: player_prepare(1343) > [player_prepare] End
08-13 21:06:44.170+0900 I/TIZEN_N_PLAYER(14803): player.c: player_start(1582) > [player_start] Start
08-13 21:06:44.170+0900 W/TIZEN_N_PLAYER(14803): player.c: __msg_callback(660) > [__msg_callback] Got message type : 0x3
08-13 21:06:44.170+0900 I/TIZEN_N_PLAYER(14803): player.c: __msg_callback(686) > STATE CHANGED INTERNALLY - from : 3,  to : 2 (CAPI State : 2)
08-13 21:06:44.170+0900 W/TIZEN_N_PLAYER(14803): player.c: __msg_callback(859) > [__msg_callback] End
08-13 21:06:44.170+0900 W/TIZEN_N_PLAYER(14803): player.c: __msg_callback(660) > [__msg_callback] Got message type : 0x104
08-13 21:06:44.170+0900 I/TIZEN_N_PLAYER(14803): player.c: __msg_callback(708) > [__msg_callback] Ready to streaming information (BOS) [current state : 2]
08-13 21:06:44.170+0900 W/TIZEN_N_PLAYER(14803): player.c: __msg_callback(859) > [__msg_callback] End
08-13 21:06:44.170+0900 I/TIZEN_N_PLAYER(14803): player.c: player_start(1632) > [player_start] End
08-13 21:06:44.170+0900 F/record  (14803): <font_size=53><color=#000000>파(F3)</color></font_size>
08-13 21:06:44.270+0900 I/record  (14803): [E3] [미] [164.80 Hz]
08-13 21:06:44.470+0900 I/record  (14803): [D#3] [레#] [155.60 Hz]
08-13 21:06:44.640+0900 I/record  (14803): [D#3] [레#] [155.60 Hz]
08-13 21:06:44.840+0900 I/record  (14803): [E3] [미] [164.80 Hz]
08-13 21:06:44.920+0900 I/record  (14803): [A0] [라] [27.50 Hz]
08-13 21:06:45.120+0900 I/record  (14803): [A0] [라] [27.50 Hz]
08-13 21:06:45.220+0900 W/TIZEN_N_PLAYER(14803): player.c: __msg_callback(660) > [__msg_callback] Got message type : 0x105
08-13 21:06:45.220+0900 W/TIZEN_N_PLAYER(14803): player.c: __msg_callback(859) > [__msg_callback] End
08-13 21:06:45.400+0900 I/record  (14803): [F3] [파] [174.60 Hz]
08-13 21:06:45.560+0900 I/record  (14803): [F3] [파] [174.60 Hz]
08-13 21:06:45.760+0900 I/record  (14803): [E3] [미] [164.80 Hz]
08-13 21:06:45.960+0900 I/record  (14803): [E3] [미] [164.80 Hz]
08-13 21:06:46.120+0900 I/record  (14803): [F3] [파] [174.60 Hz]
08-13 21:06:46.340+0900 I/record  (14803): [F3] [파] [174.60 Hz]
08-13 21:06:46.490+0900 I/record  (14803): [F3] [파] [174.60 Hz]
08-13 21:06:46.690+0900 I/record  (14803): [F3] [파] [174.60 Hz]
08-13 21:06:46.900+0900 I/record  (14803): [F3] [파] [174.60 Hz]
08-13 21:06:47.050+0900 I/record  (14803): [F3] [파] [174.60 Hz]
08-13 21:06:47.250+0900 I/record  (14803): [F3] [파] [174.60 Hz]
08-13 21:06:47.260+0900 F/record  (14803): pass! [F3] [파]
08-13 21:06:47.280+0900 I/TIZEN_N_PLAYER(14803): player.c: player_create(1091) > [player_create] new handle : 0xaf50ae90
08-13 21:06:47.280+0900 F/rrss    (14803): /opt/usr/apps/org.samteam.perfectsong/res/PASS1.wav
08-13 21:06:47.280+0900 I/TIZEN_N_PLAYER(14803): player.c: player_prepare(1272) > [player_prepare] Start
08-13 21:06:47.280+0900 W/TIZEN_N_PLAYER(14803): player.c: __msg_callback(660) > [__msg_callback] Got message type : 0x3
08-13 21:06:47.280+0900 I/TIZEN_N_PLAYER(14803): player.c: __msg_callback(686) > STATE CHANGED INTERNALLY - from : 0,  to : 1 (CAPI State : 1)
08-13 21:06:47.280+0900 W/TIZEN_N_PLAYER(14803): player.c: __msg_callback(859) > [__msg_callback] End
08-13 21:06:47.350+0900 W/TIZEN_N_PLAYER(14803): player.c: __msg_callback(660) > [__msg_callback] Got message type : 0x3
08-13 21:06:47.350+0900 I/TIZEN_N_PLAYER(14803): player.c: __msg_callback(686) > STATE CHANGED INTERNALLY - from : 1,  to : 3 (CAPI State : 1)
08-13 21:06:47.350+0900 W/TIZEN_N_PLAYER(14803): player.c: __msg_callback(859) > [__msg_callback] End
08-13 21:06:47.350+0900 I/TIZEN_N_PLAYER(14803): player.c: player_prepare(1343) > [player_prepare] End
08-13 21:06:47.350+0900 I/TIZEN_N_PLAYER(14803): player.c: player_start(1582) > [player_start] Start
08-13 21:06:47.350+0900 W/TIZEN_N_PLAYER(14803): player.c: __msg_callback(660) > [__msg_callback] Got message type : 0x3
08-13 21:06:47.350+0900 I/TIZEN_N_PLAYER(14803): player.c: __msg_callback(686) > STATE CHANGED INTERNALLY - from : 3,  to : 2 (CAPI State : 2)
08-13 21:06:47.350+0900 W/TIZEN_N_PLAYER(14803): player.c: __msg_callback(859) > [__msg_callback] End
08-13 21:06:47.350+0900 W/TIZEN_N_PLAYER(14803): player.c: __msg_callback(660) > [__msg_callback] Got message type : 0x104
08-13 21:06:47.350+0900 I/TIZEN_N_PLAYER(14803): player.c: __msg_callback(708) > [__msg_callback] Ready to streaming information (BOS) [current state : 2]
08-13 21:06:47.350+0900 W/TIZEN_N_PLAYER(14803): player.c: __msg_callback(859) > [__msg_callback] End
08-13 21:06:47.350+0900 I/TIZEN_N_PLAYER(14803): player.c: player_start(1632) > [player_start] End
08-13 21:06:47.350+0900 F/record  (14803): <font_size=53><color=#000000>솔(G3)</color></font_size>
08-13 21:06:47.460+0900 I/record  (14803): [F3] [파] [174.60 Hz]
08-13 21:06:47.630+0900 I/record  (14803): [F3] [파] [174.60 Hz]
08-13 21:06:47.790+0900 I/record  (14803): [F3] [파] [174.60 Hz]
08-13 21:06:47.920+0900 I/record  (14803): [A0] [라] [27.50 Hz]
08-13 21:06:48.070+0900 I/record  (14803): [A0] [라] [27.50 Hz]
08-13 21:06:48.280+0900 I/record  (14803): [A0] [라] [27.50 Hz]
08-13 21:06:48.400+0900 W/TIZEN_N_PLAYER(14803): player.c: __msg_callback(660) > [__msg_callback] Got message type : 0x105
08-13 21:06:48.400+0900 W/TIZEN_N_PLAYER(14803): player.c: __msg_callback(859) > [__msg_callback] End
08-13 21:06:48.480+0900 I/record  (14803): [A0] [라] [27.50 Hz]
08-13 21:06:48.720+0900 I/record  (14803): [G3] [솔] [196.00 Hz]
08-13 21:06:48.920+0900 I/record  (14803): [G3] [솔] [196.00 Hz]
08-13 21:06:49.120+0900 I/record  (14803): [G3] [솔] [196.00 Hz]
08-13 21:06:49.280+0900 I/record  (14803): [G3] [솔] [196.00 Hz]
08-13 21:06:49.480+0900 I/record  (14803): [G3] [솔] [196.00 Hz]
08-13 21:06:49.680+0900 I/record  (14803): [G3] [솔] [196.00 Hz]
08-13 21:06:49.840+0900 I/record  (14803): [G3] [솔] [196.00 Hz]
08-13 21:06:49.850+0900 F/record  (14803): pass! [G3] [솔]
08-13 21:06:49.860+0900 I/TIZEN_N_PLAYER(14803): player.c: player_create(1091) > [player_create] new handle : 0xb252c630
08-13 21:06:49.860+0900 F/rrss    (14803): /opt/usr/apps/org.samteam.perfectsong/res/PASS1.wav
08-13 21:06:49.860+0900 I/TIZEN_N_PLAYER(14803): player.c: player_prepare(1272) > [player_prepare] Start
08-13 21:06:49.860+0900 W/TIZEN_N_PLAYER(14803): player.c: __msg_callback(660) > [__msg_callback] Got message type : 0x3
08-13 21:06:49.860+0900 I/TIZEN_N_PLAYER(14803): player.c: __msg_callback(686) > STATE CHANGED INTERNALLY - from : 0,  to : 1 (CAPI State : 1)
08-13 21:06:49.860+0900 W/TIZEN_N_PLAYER(14803): player.c: __msg_callback(859) > [__msg_callback] End
08-13 21:06:49.940+0900 W/TIZEN_N_PLAYER(14803): player.c: __msg_callback(660) > [__msg_callback] Got message type : 0x3
08-13 21:06:49.940+0900 I/TIZEN_N_PLAYER(14803): player.c: __msg_callback(686) > STATE CHANGED INTERNALLY - from : 1,  to : 3 (CAPI State : 1)
08-13 21:06:49.940+0900 W/TIZEN_N_PLAYER(14803): player.c: __msg_callback(859) > [__msg_callback] End
08-13 21:06:49.940+0900 I/TIZEN_N_PLAYER(14803): player.c: player_prepare(1343) > [player_prepare] End
08-13 21:06:49.940+0900 I/TIZEN_N_PLAYER(14803): player.c: player_start(1582) > [player_start] Start
08-13 21:06:49.940+0900 W/TIZEN_N_PLAYER(14803): player.c: __msg_callback(660) > [__msg_callback] Got message type : 0x3
08-13 21:06:49.940+0900 I/TIZEN_N_PLAYER(14803): player.c: __msg_callback(686) > STATE CHANGED INTERNALLY - from : 3,  to : 2 (CAPI State : 2)
08-13 21:06:49.940+0900 W/TIZEN_N_PLAYER(14803): player.c: __msg_callback(859) > [__msg_callback] End
08-13 21:06:49.940+0900 W/TIZEN_N_PLAYER(14803): player.c: __msg_callback(660) > [__msg_callback] Got message type : 0x104
08-13 21:06:49.940+0900 I/TIZEN_N_PLAYER(14803): player.c: __msg_callback(708) > [__msg_callback] Ready to streaming information (BOS) [current state : 2]
08-13 21:06:49.940+0900 W/TIZEN_N_PLAYER(14803): player.c: __msg_callback(859) > [__msg_callback] End
08-13 21:06:49.940+0900 I/TIZEN_N_PLAYER(14803): player.c: player_start(1632) > [player_start] End
08-13 21:06:49.940+0900 F/record  (14803): <font_size=53><color=#000000>솔(G3)</color></font_size>
08-13 21:06:49.950+0900 F/record  (14803): <font_size=50 align=center><color=#FF0000>Clear!!!</br> 클리어 시간 : 22초</color></font_size>
08-13 21:06:53.070+0900 I/CAPI_APPFW_APPLICATION( 1124): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 21:06:53.070+0900 I/CAPI_APPFW_APPLICATION(  700): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 21:06:53.070+0900 W/CAM_APP ( 1124): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
08-13 21:06:53.070+0900 I/CAPI_APPFW_APPLICATION(11252): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 21:06:53.080+0900 W/MUSIC_PLAYER(11252): mp-main.c: mp_device_orientation(2354) > [36m[TID:11252]   [MUSIC_PLAYER_EVENT][0m
08-13 21:06:53.140+0900 I/CAPI_APPFW_APPLICATION( 1122): app_main.c: _ui_app_appcore_rotation_event(490) > _ui_app_appcore_rotation_event
08-13 21:06:55.630+0900 F/record  (14803): clear!
08-13 21:07:01.090+0900 E/RESOURCED(  766): proc-monitor.c: edbus_signal_trigger(473) > [edbus_signal_trigger,473] Receive watchdog signal to pid: 14803(paaaaaaaaa)
08-13 21:07:08.120+0900 W/CRASH_MANAGER(15054): worker.c: worker_job(1198) > 1114803706161143946762
