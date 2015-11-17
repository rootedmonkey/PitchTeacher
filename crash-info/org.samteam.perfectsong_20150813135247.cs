S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.0
Build-Number: Z130HDDU0BOB3
Build-Date: 2015.02.14 15:10:17

Crash Information
Process Name: paaaaaaaaa
PID: 4899
Date: 2015-08-13 13:52:47+0900
Executable File Path: /opt/usr/apps/org.samteam.perfectsong/bin/paaaaaaaaa
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 4899, uid 5000)

Register Information
r0   = 0xa15fb000, r1   = 0xb099d8b8
r2   = 0xffffff90, r3   = 0x06f1076f
r4   = 0x055d0645, r5   = 0x037e0477
r6   = 0xfe43fe0e, r7   = 0xff1cfe98
r8   = 0xffd0ff7f, r9   = 0xb3482ea0
r10  = 0x00000890, fp   = 0xaeafed6c
ip   = 0x00000010, sp   = 0xaeafe97c
lr   = 0x00ec006e, pc   = 0xb6c96ee0
cpsr = 0x00000010

Memory Information
MemTotal:   730748 KB
MemFree:    227204 KB
Buffers:     33932 KB
Cached:     187100 KB
VmPeak:     368688 KB
VmSize:     368684 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       41628 KB
VmRSS:       41628 KB
VmData:     299632 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       28500 KB
VmPTE:         164 KB
VmSwap:          0 KB

Threads Information
Threads: 32
PID = 4899 TID = 5204
4899 4906 4907 4910 4934 5036 5037 5038 5040 5041 5042 5055 5056 5057 5058 5059 5096 5097 5098 5099 5100 5108 5109 5110 5111 5112 5155 5156 5157 5158 5159 5204 

Maps Information
a15fc000 a1dfb000 rwxp [stack:5159]
a1dfc000 a25fb000 rwxp [stack:5158]
a25fc000 a2dfb000 rwxp [stack:5157]
a2dfc000 a35fb000 rwxp [stack:5156]
a35fc000 a3dfb000 rwxp [stack:5155]
a3dfc000 a45fb000 rwxp [stack:5112]
a45fc000 a4dfb000 rwxp [stack:5111]
a4dfc000 a55fb000 rwxp [stack:5110]
a55fc000 a5dfb000 rwxp [stack:5109]
a5dfc000 a65fb000 rwxp [stack:5108]
a65fc000 a6dfb000 rwxp [stack:5100]
a6dfc000 a75fb000 rwxp [stack:5099]
a75fc000 a7dfb000 rwxp [stack:5098]
a7dfc000 a85fb000 rwxp [stack:5097]
a85fc000 a8dfb000 rwxp [stack:5096]
a8dfc000 a95fb000 rwxp [stack:5059]
a95fc000 a9dfb000 rwxp [stack:5058]
a9dfc000 aa5fb000 rwxp [stack:5057]
aa5fc000 aadfb000 rwxp [stack:5056]
aadfc000 ab5fb000 rwxp [stack:5055]
ab5fc000 abdfb000 rwxp [stack:5042]
abdfc000 ac5fb000 rwxp [stack:5037]
aca67000 ad266000 rwxp [stack:5041]
ad267000 ada66000 rwxp [stack:5038]
ada66000 adae3000 r-xp /usr/lib/lib_SoundAlive_ver125e_wrapped.so
adb01000 ae300000 rwxp [stack:5036]
ae301000 aeb00000 rwxp [stack:5204]
aec1e000 aec38000 r-xp /usr/lib/gstreamer-0.10/libgstpulse.so
aec41000 aec4a000 r-xp /usr/lib/lib_SoundBooster_ver402_wrapped.so
aec69000 aec81000 r-xp /usr/lib/libgstcontroller-0.10.so.0.30.0
aec90000 aec96000 r-xp /usr/lib/gstreamer-0.10/libgstsoundalive.so
aec9e000 aeca6000 r-xp /usr/lib/lib_SoundAlive_SRC192_ver204_wrapped.so
aecb1000 aecb6000 r-xp /usr/lib/gstreamer-0.10/libgstvolume.so
aecbe000 aecc1000 r-xp /usr/lib/gstreamer-0.10/libgstsecresample.so
aecca000 aecf3000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
aecfc000 aed21000 r-xp /usr/lib/libgsttag-0.10.so.0.25.0
aed2a000 aed34000 r-xp /usr/lib/libgstriff-0.10.so.0.25.0
aed3d000 aed63000 r-xp /usr/lib/gstreamer-0.10/libgstogg.so
aed6c000 aed84000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
aed8d000 aeda3000 r-xp /usr/lib/gstreamer-0.10/libgstdecodebin2.so
aedac000 aedef000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
aedf8000 aee03000 r-xp /usr/lib/gstreamer-0.10/libgstaudioconvert.so
af28d000 afa8c000 rwxp [stack:4910]
afa8d000 afa96000 r-xp /usr/lib/gstreamer-0.10/libgstvorbis.so
afa9e000 afad3000 r-xp /usr/lib/gstreamer-0.10/libgstcoreelements.so
afd01000 afd05000 r-xp /usr/lib/gstreamer-0.10/libgstaudiotp.so
afe8e000 b068d000 rwxp [stack:4907]
b0a8f000 b128e000 rwxp [stack:4906]
b2401000 b2c00000 rwxp [stack:4934]
b2c01000 b3400000 rwxp [stack:5040]
b3500000 b350a000 r-xp /usr/lib/gstreamer-0.10/libgsttypefindfunctions.so
b3a61000 b3a63000 r-xp /usr/lib/gconv/ISO8859-15.so
b3a6c000 b3a7b000 r-xp /usr/lib/gstreamer-0.10/libgstsubparse.so
b3a84000 b3a8e000 r-xp /usr/lib/gstreamer-0.10/libgstwavparse.so
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
b7283000 b72cc000 rw-p [heap]
b72cc000 b7b0a000 rw-p [heap]
be9ae000 be9cf000 rwxp [stack]
End of Maps Information

Callstack Information (PID:4899)
Call Stack Count: 7
 0: memcpy + 0xb0 (0xb6c96ee0) [/lib/libc.so.6] + 0x74ee0
 1: pa_simple_read + 0x10c (0xb464ef69) [/usr/lib/libpulse-simple.so.0] + 0x1f69
 2: avsys_audio_pasimple_read + 0x30 (0xb49ce505) [/usr/lib/libavsysaudio.so.0] + 0x10505
 3: avsys_audio_read + 0x3a (0xb49c801f) [/usr/lib/libavsysaudio.so.0] + 0xa01f
 4: mm_sound_pcm_capture_read + 0x36 (0xb4b59d6f) [/usr/lib/libmmfsound.so.0] + 0xbd6f
 5: audio_in_read + 0x18 (0xb4b9db49) [/usr/lib/libcapi-media-audio-io.so.0] + 0x2b49
 6: pitch_detect_routine + 0xc6 (0xb4bc067f) [/opt/usr/apps/org.samteam.perfectsong/bin/paaaaaaaaa] + 0x267f
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
  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:13.020+0900 I/record  ( 4899): [D#2] [레#] [77.80 Hz]
08-13 13:52:13.140+0900 I/record  ( 4899): [D2] [레] [73.40 Hz]
08-13 13:52:13.220+0900 I/record  ( 4899): [D2] [레] [73.40 Hz]
08-13 13:52:13.300+0900 I/record  ( 4899): [D2] [레] [73.40 Hz]
08-13 13:52:13.420+0900 I/record  ( 4899): [D2] [레] [73.40 Hz]
08-13 13:52:13.500+0900 I/record  ( 4899): [D2] [레] [73.40 Hz]
08-13 13:52:13.580+0900 I/record  ( 4899): [D#2] [레#] [77.80 Hz]
08-13 13:52:13.650+0900 I/record  ( 4899): [D2] [레] [73.40 Hz]
08-13 13:52:13.780+0900 I/record  ( 4899): [D#2] [레#] [77.80 Hz]
08-13 13:52:13.870+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:13.950+0900 I/record  ( 4899): [C5] [도] [523.30 Hz]
08-13 13:52:13.990+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:14.060+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:14.150+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:14.270+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:14.350+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:14.430+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:14.550+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:14.630+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:14.710+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:14.830+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:14.910+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:14.990+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:15.110+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:15.190+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:15.270+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:15.430+0900 I/record  ( 4899): [G2] [솔] [98.00 Hz]
08-13 13:52:15.550+0900 I/record  ( 4899): [D2] [레] [73.40 Hz]
08-13 13:52:15.650+0900 I/record  ( 4899): [D2] [레] [73.40 Hz]
08-13 13:52:15.740+0900 I/record  ( 4899): [C#2] [도#] [69.30 Hz]
08-13 13:52:15.820+0900 I/record  ( 4899): [C#2] [도#] [69.30 Hz]
08-13 13:52:15.900+0900 I/record  ( 4899): [C#2] [도#] [69.30 Hz]
08-13 13:52:16.020+0900 I/record  ( 4899): [G7] [솔] [3136.00 Hz]
08-13 13:52:16.100+0900 I/record  ( 4899): [C#2] [도#] [69.30 Hz]
08-13 13:52:16.180+0900 I/record  ( 4899): [C#2] [도#] [69.30 Hz]
08-13 13:52:16.260+0900 I/record  ( 4899): [D2] [레] [73.40 Hz]
08-13 13:52:16.380+0900 I/record  ( 4899): [D2] [레] [73.40 Hz]
08-13 13:52:16.460+0900 I/record  ( 4899): [C#2] [도#] [69.30 Hz]
08-13 13:52:16.550+0900 I/record  ( 4899): [C#2] [도#] [69.30 Hz]
08-13 13:52:16.670+0900 I/record  ( 4899): [D2] [레] [73.40 Hz]
08-13 13:52:16.750+0900 I/record  ( 4899): [D2] [레] [73.40 Hz]
08-13 13:52:16.820+0900 I/record  ( 4899): [C#2] [도#] [69.30 Hz]
08-13 13:52:16.860+0900 I/Tizen::Net::Wifi(  970): (1072) > _WifiService is not registered.
08-13 13:52:16.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 13:52:16.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 13:52:16.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 13:52:16.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 306 5 28 25"
08-13 13:52:16.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 213 334 5 28 25"
08-13 13:52:16.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 362 5 28 25"
08-13 13:52:16.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 390 5 28 25"
08-13 13:52:16.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 418 5 28 25"
08-13 13:52:16.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 13:52:16.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 13:52:16.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 13:52:16.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 598 5 28 25"
08-13 13:52:16.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 626 5 28 25"
08-13 13:52:16.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 213 654 5 28 25"
08-13 13:52:16.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 682 5 28 25"
08-13 13:52:16.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 710 5 28 25"
08-13 13:52:16.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 738 5 28 25"
08-13 13:52:16.950+0900 I/record  ( 4899): [D2] [레] [73.40 Hz]
08-13 13:52:17.030+0900 I/record  ( 4899): [D2] [레] [73.40 Hz]
08-13 13:52:17.120+0900 I/record  ( 4899): [D2] [레] [73.40 Hz]
08-13 13:52:17.200+0900 I/record  ( 4899): [D2] [레] [73.40 Hz]
08-13 13:52:17.320+0900 I/record  ( 4899): [D2] [레] [73.40 Hz]
08-13 13:52:17.400+0900 I/record  ( 4899): [D2] [레] [73.40 Hz]
08-13 13:52:17.480+0900 I/record  ( 4899): [D2] [레] [73.40 Hz]
08-13 13:52:17.600+0900 I/record  ( 4899): [D2] [레] [73.40 Hz]
08-13 13:52:17.680+0900 I/record  ( 4899): [D2] [레] [73.40 Hz]
08-13 13:52:17.760+0900 I/record  ( 4899): [D2] [레] [73.40 Hz]
08-13 13:52:17.850+0900 I/Tizen::Net::Wifi(  970): (1072) > _WifiService is not registered.
08-13 13:52:17.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 13:52:17.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 13:52:17.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 13:52:17.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 306 5 28 25"
08-13 13:52:17.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 213 334 5 28 25"
08-13 13:52:17.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 362 5 28 25"
08-13 13:52:17.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 390 5 28 25"
08-13 13:52:17.850+0900 I/record  ( 4899): [D2] [레] [73.40 Hz]
08-13 13:52:17.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 418 5 28 25"
08-13 13:52:17.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 13:52:17.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 13:52:17.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 13:52:17.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 598 5 28 25"
08-13 13:52:17.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 626 5 28 25"
08-13 13:52:17.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 213 654 5 28 25"
08-13 13:52:17.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 682 5 28 25"
08-13 13:52:17.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 710 5 28 25"
08-13 13:52:17.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 738 5 28 25"
08-13 13:52:17.970+0900 I/record  ( 4899): [D2] [레] [73.40 Hz]
08-13 13:52:18.050+0900 I/record  ( 4899): [D2] [레] [73.40 Hz]
08-13 13:52:18.130+0900 I/record  ( 4899): [D2] [레] [73.40 Hz]
08-13 13:52:18.240+0900 I/record  ( 4899): [D2] [레] [73.40 Hz]
08-13 13:52:18.320+0900 I/record  ( 4899): [D2] [레] [73.40 Hz]
08-13 13:52:18.320+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:18.450+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:18.530+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:18.610+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:18.730+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:18.810+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:18.890+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:18.970+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:19.090+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:19.170+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:19.260+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:19.370+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:19.450+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:19.530+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:19.650+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:19.730+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:19.820+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:19.930+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:20.000+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:20.120+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:20.210+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:20.290+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:20.370+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:20.490+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:20.570+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:20.650+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:20.770+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:20.850+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:20.940+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:21.050+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:21.130+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:21.210+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:21.410+0900 I/record  ( 4899): [F6] [파] [1396.90 Hz]
08-13 13:52:21.420+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:21.500+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:21.620+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:21.690+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:21.780+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:21.940+0900 I/record  ( 4899): [B2] [시] [123.50 Hz]
08-13 13:52:22.060+0900 I/record  ( 4899): [A#2] [라#] [116.50 Hz]
08-13 13:52:22.150+0900 I/record  ( 4899): [A#2] [라#] [116.50 Hz]
08-13 13:52:22.220+0900 I/record  ( 4899): [A#2] [라#] [116.50 Hz]
08-13 13:52:22.330+0900 I/record  ( 4899): [A#2] [라#] [116.50 Hz]
08-13 13:52:22.420+0900 I/record  ( 4899): [A2] [라] [110.00 Hz]
08-13 13:52:22.500+0900 I/record  ( 4899): [A2] [라] [110.00 Hz]
08-13 13:52:22.620+0900 I/record  ( 4899): [A#2] [라#] [116.50 Hz]
08-13 13:52:22.700+0900 I/record  ( 4899): [A#2] [라#] [116.50 Hz]
08-13 13:52:22.780+0900 I/record  ( 4899): [A#2] [라#] [116.50 Hz]
08-13 13:52:22.850+0900 I/Tizen::Net::Wifi(  970): (1072) > _WifiService is not registered.
08-13 13:52:22.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 13:52:22.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 13:52:22.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 13:52:22.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 306 5 28 25"
08-13 13:52:22.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 213 334 5 28 25"
08-13 13:52:22.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 362 5 28 25"
08-13 13:52:22.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 390 5 28 25"
08-13 13:52:22.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 418 5 28 25"
08-13 13:52:22.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 13:52:22.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 13:52:22.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 13:52:22.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 598 5 28 25"
08-13 13:52:22.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 626 5 28 25"
08-13 13:52:22.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 213 654 5 28 25"
08-13 13:52:22.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 682 5 28 25"
08-13 13:52:22.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 710 5 28 25"
08-13 13:52:22.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 738 5 28 25"
08-13 13:52:22.900+0900 I/record  ( 4899): [A#2] [라#] [116.50 Hz]
08-13 13:52:22.980+0900 I/record  ( 4899): [B2] [시] [123.50 Hz]
08-13 13:52:23.060+0900 I/record  ( 4899): [B2] [시] [123.50 Hz]
08-13 13:52:23.170+0900 I/record  ( 4899): [A#2] [라#] [116.50 Hz]
08-13 13:52:23.240+0900 I/record  ( 4899): [A#2] [라#] [116.50 Hz]
08-13 13:52:23.330+0900 I/record  ( 4899): [A#2] [라#] [116.50 Hz]
08-13 13:52:23.450+0900 I/record  ( 4899): [A2] [라] [110.00 Hz]
08-13 13:52:23.520+0900 I/record  ( 4899): [A2] [라] [110.00 Hz]
08-13 13:52:23.600+0900 I/record  ( 4899): [A2] [라] [110.00 Hz]
08-13 13:52:23.730+0900 I/record  ( 4899): [A2] [라] [110.00 Hz]
08-13 13:52:23.810+0900 I/record  ( 4899): [A2] [라] [110.00 Hz]
08-13 13:52:23.890+0900 I/record  ( 4899): [A2] [라] [110.00 Hz]
08-13 13:52:24.000+0900 I/record  ( 4899): [A2] [라] [110.00 Hz]
08-13 13:52:24.080+0900 I/record  ( 4899): [A2] [라] [110.00 Hz]
08-13 13:52:24.160+0900 I/record  ( 4899): [A2] [라] [110.00 Hz]
08-13 13:52:24.290+0900 I/record  ( 4899): [A2] [라] [110.00 Hz]
08-13 13:52:24.370+0900 I/record  ( 4899): [A2] [라] [110.00 Hz]
08-13 13:52:24.450+0900 I/record  ( 4899): [A6] [라] [1760.00 Hz]
08-13 13:52:24.450+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:24.570+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:24.730+0900 I/record  ( 4899): [F#6] [파#] [1480.00 Hz]
08-13 13:52:24.810+0900 I/record  ( 4899): [F6] [파] [1396.90 Hz]
08-13 13:52:24.860+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:24.940+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:25.020+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:25.190+0900 I/record  ( 4899): [G#6] [솔#] [1661.20 Hz]
08-13 13:52:25.300+0900 I/record  ( 4899): [G#6] [솔#] [1661.20 Hz]
08-13 13:52:25.390+0900 I/record  ( 4899): [F#2] [파#] [92.50 Hz]
08-13 13:52:25.470+0900 I/record  ( 4899): [F#2] [파#] [92.50 Hz]
08-13 13:52:25.580+0900 I/record  ( 4899): [F#2] [파#] [92.50 Hz]
08-13 13:52:25.660+0900 I/record  ( 4899): [F#2] [파#] [92.50 Hz]
08-13 13:52:25.740+0900 I/record  ( 4899): [F#2] [파#] [92.50 Hz]
08-13 13:52:25.860+0900 I/record  ( 4899): [F#2] [파#] [92.50 Hz]
08-13 13:52:25.940+0900 I/record  ( 4899): [F#2] [파#] [92.50 Hz]
08-13 13:52:26.020+0900 I/record  ( 4899): [F#2] [파#] [92.50 Hz]
08-13 13:52:26.130+0900 I/record  ( 4899): [F#2] [파#] [92.50 Hz]
08-13 13:52:26.210+0900 I/record  ( 4899): [F#2] [파#] [92.50 Hz]
08-13 13:52:26.330+0900 I/record  ( 4899): [F#2] [파#] [92.50 Hz]
08-13 13:52:26.410+0900 I/record  ( 4899): [F#2] [파#] [92.50 Hz]
08-13 13:52:26.490+0900 I/record  ( 4899): [F#2] [파#] [92.50 Hz]
08-13 13:52:26.570+0900 I/record  ( 4899): [F#2] [파#] [92.50 Hz]
08-13 13:52:26.690+0900 I/record  ( 4899): [F#2] [파#] [92.50 Hz]
08-13 13:52:26.770+0900 I/record  ( 4899): [G6] [솔] [1568.00 Hz]
08-13 13:52:26.850+0900 I/Tizen::Net::Wifi(  970): (1072) > _WifiService is not registered.
08-13 13:52:26.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 13:52:26.850+0900 I/record  ( 4899): [E2] [미] [82.40 Hz]
08-13 13:52:26.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 13:52:26.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 13:52:26.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 306 5 28 25"
08-13 13:52:26.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 213 334 5 28 25"
08-13 13:52:26.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 362 5 28 25"
08-13 13:52:26.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 390 5 28 25"
08-13 13:52:26.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 418 5 28 25"
08-13 13:52:26.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 13:52:26.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 13:52:26.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 13:52:26.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 598 5 28 25"
08-13 13:52:26.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 626 5 28 25"
08-13 13:52:26.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 213 654 5 28 25"
08-13 13:52:26.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 682 5 28 25"
08-13 13:52:26.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 710 5 28 25"
08-13 13:52:26.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 738 5 28 25"
08-13 13:52:26.970+0900 I/record  ( 4899): [F#6] [파#] [1480.00 Hz]
08-13 13:52:27.040+0900 I/record  ( 4899): [E2] [미] [82.40 Hz]
08-13 13:52:27.130+0900 I/record  ( 4899): [E2] [미] [82.40 Hz]
08-13 13:52:27.250+0900 I/record  ( 4899): [E2] [미] [82.40 Hz]
08-13 13:52:27.340+0900 I/record  ( 4899): [E2] [미] [82.40 Hz]
08-13 13:52:27.410+0900 I/record  ( 4899): [E2] [미] [82.40 Hz]
08-13 13:52:27.530+0900 I/record  ( 4899): [E2] [미] [82.40 Hz]
08-13 13:52:27.540+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:27.620+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:27.810+0900 I/record  ( 4899): [C5] [도] [523.30 Hz]
08-13 13:52:27.900+0900 I/record  ( 4899): [F6] [파] [1396.90 Hz]
08-13 13:52:27.900+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:28.020+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:28.100+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:28.180+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:28.260+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:28.380+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:28.470+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:28.540+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:28.660+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:28.740+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:28.820+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:28.940+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:29.010+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:29.210+0900 I/record  ( 4899): [D#3] [레#] [155.60 Hz]
08-13 13:52:29.300+0900 I/record  ( 4899): [F6] [파] [1396.90 Hz]
08-13 13:52:29.390+0900 I/record  ( 4899): [D#2] [레#] [77.80 Hz]
08-13 13:52:29.480+0900 I/record  ( 4899): [D#2] [레#] [77.80 Hz]
08-13 13:52:29.560+0900 I/record  ( 4899): [D#2] [레#] [77.80 Hz]
08-13 13:52:29.650+0900 I/record  ( 4899): [A#6] [라#] [1864.70 Hz]
08-13 13:52:29.770+0900 I/record  ( 4899): [D#2] [레#] [77.80 Hz]
08-13 13:52:29.840+0900 I/record  ( 4899): [D#2] [레#] [77.80 Hz]
08-13 13:52:29.930+0900 I/record  ( 4899): [D#2] [레#] [77.80 Hz]
08-13 13:52:30.000+0900 I/record  ( 4899): [D#2] [레#] [77.80 Hz]
08-13 13:52:30.130+0900 I/record  ( 4899): [F#6] [파#] [1480.00 Hz]
08-13 13:52:30.210+0900 I/record  ( 4899): [F#6] [파#] [1480.00 Hz]
08-13 13:52:30.290+0900 I/record  ( 4899): [D#2] [레#] [77.80 Hz]
08-13 13:52:30.410+0900 I/record  ( 4899): [D#2] [레#] [77.80 Hz]
08-13 13:52:30.490+0900 I/record  ( 4899): [D#2] [레#] [77.80 Hz]
08-13 13:52:30.570+0900 I/record  ( 4899): [D#2] [레#] [77.80 Hz]
08-13 13:52:30.690+0900 I/record  ( 4899): [D#2] [레#] [77.80 Hz]
08-13 13:52:30.770+0900 I/record  ( 4899): [D#2] [레#] [77.80 Hz]
08-13 13:52:30.850+0900 I/Tizen::Net::Wifi(  970): (1072) > _WifiService is not registered.
08-13 13:52:30.850+0900 I/record  ( 4899): [D2] [레] [73.40 Hz]
08-13 13:52:30.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 13:52:30.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 13:52:30.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 13:52:30.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 306 5 28 25"
08-13 13:52:30.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 213 334 5 28 25"
08-13 13:52:30.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 362 5 28 25"
08-13 13:52:30.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 390 5 28 25"
08-13 13:52:30.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 418 5 28 25"
08-13 13:52:30.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 13:52:30.850+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 13:52:30.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 13:52:30.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 598 5 28 25"
08-13 13:52:30.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 626 5 28 25"
08-13 13:52:30.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 213 654 5 28 25"
08-13 13:52:30.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 682 5 28 25"
08-13 13:52:30.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 710 5 28 25"
08-13 13:52:30.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 738 5 28 25"
08-13 13:52:30.970+0900 I/record  ( 4899): [D#2] [레#] [77.80 Hz]
08-13 13:52:31.040+0900 I/record  ( 4899): [D#2] [레#] [77.80 Hz]
08-13 13:52:31.140+0900 I/record  ( 4899): [D2] [레] [73.40 Hz]
08-13 13:52:31.220+0900 I/record  ( 4899): [D#2] [레#] [77.80 Hz]
08-13 13:52:31.340+0900 I/record  ( 4899): [D2] [레] [73.40 Hz]
08-13 13:52:31.420+0900 I/record  ( 4899): [D2] [레] [73.40 Hz]
08-13 13:52:31.490+0900 I/record  ( 4899): [D2] [레] [73.40 Hz]
08-13 13:52:31.620+0900 I/record  ( 4899): [D2] [레] [73.40 Hz]
08-13 13:52:31.700+0900 I/record  ( 4899): [G#6] [솔#] [1661.20 Hz]
08-13 13:52:31.780+0900 I/record  ( 4899): [D2] [레] [73.40 Hz]
08-13 13:52:31.860+0900 I/Tizen::Net::Wifi(  970): (1072) > _WifiService is not registered.
08-13 13:52:31.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 13:52:31.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 13:52:31.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 13:52:31.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 306 5 28 25"
08-13 13:52:31.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 213 334 5 28 25"
08-13 13:52:31.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 362 5 28 25"
08-13 13:52:31.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 390 5 28 25"
08-13 13:52:31.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 418 5 28 25"
08-13 13:52:31.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 13:52:31.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 13:52:31.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 13:52:31.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 598 5 28 25"
08-13 13:52:31.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 626 5 28 25"
08-13 13:52:31.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 213 654 5 28 25"
08-13 13:52:31.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 682 5 28 25"
08-13 13:52:31.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 710 5 28 25"
08-13 13:52:31.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 738 5 28 25"
08-13 13:52:31.900+0900 I/record  ( 4899): [D2] [레] [73.40 Hz]
08-13 13:52:31.990+0900 I/record  ( 4899): [D2] [레] [73.40 Hz]
08-13 13:52:32.070+0900 I/record  ( 4899): [G#6] [솔#] [1661.20 Hz]
08-13 13:52:32.170+0900 I/record  ( 4899): [G#6] [솔#] [1661.20 Hz]
08-13 13:52:32.250+0900 I/record  ( 4899): [F#6] [파#] [1480.00 Hz]
08-13 13:52:32.330+0900 I/record  ( 4899): [G6] [솔] [1568.00 Hz]
08-13 13:52:32.450+0900 I/record  ( 4899): [C#2] [도#] [69.30 Hz]
08-13 13:52:32.530+0900 I/record  ( 4899): [C#2] [도#] [69.30 Hz]
08-13 13:52:32.620+0900 I/record  ( 4899): [C#2] [도#] [69.30 Hz]
08-13 13:52:32.730+0900 I/record  ( 4899): [C#2] [도#] [69.30 Hz]
08-13 13:52:32.810+0900 I/record  ( 4899): [C#2] [도#] [69.30 Hz]
08-13 13:52:32.860+0900 I/Tizen::Net::Wifi(  970): (1072) > _WifiService is not registered.
08-13 13:52:32.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 13:52:32.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 13:52:32.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 13:52:32.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 306 5 28 25"
08-13 13:52:32.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 213 334 5 28 25"
08-13 13:52:32.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 362 5 28 25"
08-13 13:52:32.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 390 5 28 25"
08-13 13:52:32.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 418 5 28 25"
08-13 13:52:32.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 13:52:32.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 13:52:32.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 13:52:32.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 598 5 28 25"
08-13 13:52:32.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 626 5 28 25"
08-13 13:52:32.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 213 654 5 28 25"
08-13 13:52:32.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 682 5 28 25"
08-13 13:52:32.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 710 5 28 25"
08-13 13:52:32.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 738 5 28 25"
08-13 13:52:32.890+0900 I/record  ( 4899): [C#2] [도#] [69.30 Hz]
08-13 13:52:33.010+0900 I/record  ( 4899): [C#2] [도#] [69.30 Hz]
08-13 13:52:33.090+0900 I/record  ( 4899): [C#2] [도#] [69.30 Hz]
08-13 13:52:33.170+0900 I/record  ( 4899): [C#2] [도#] [69.30 Hz]
08-13 13:52:33.290+0900 I/record  ( 4899): [C#2] [도#] [69.30 Hz]
08-13 13:52:33.380+0900 I/record  ( 4899): [C#2] [도#] [69.30 Hz]
08-13 13:52:33.460+0900 I/record  ( 4899): [C#2] [도#] [69.30 Hz]
08-13 13:52:33.570+0900 I/record  ( 4899): [F6] [파] [1396.90 Hz]
08-13 13:52:33.660+0900 I/record  ( 4899): [C#2] [도#] [69.30 Hz]
08-13 13:52:33.660+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:33.780+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:33.850+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:34.020+0900 I/record  ( 4899): [D#3] [레#] [155.60 Hz]
08-13 13:52:34.100+0900 I/record  ( 4899): [D#4] [레#] [311.10 Hz]
08-13 13:52:34.140+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:34.220+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:34.380+0900 I/record  ( 4899): [F#5] [파#] [740.00 Hz]
08-13 13:52:34.420+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:34.500+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:34.580+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:34.700+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:34.860+0900 I/Tizen::Net::Wifi(  970): (1072) > _WifiService is not registered.
08-13 13:52:34.870+0900 I/record  ( 4899): [G#3] [솔#] [207.70 Hz]
08-13 13:52:34.900+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 13:52:34.900+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 13:52:34.900+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 13:52:34.900+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 306 5 28 25"
08-13 13:52:34.900+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 213 334 5 28 25"
08-13 13:52:34.900+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 362 5 28 25"
08-13 13:52:34.910+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 390 5 28 25"
08-13 13:52:34.910+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 418 5 28 25"
08-13 13:52:34.910+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 13:52:34.910+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 13:52:34.920+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 13:52:34.920+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 598 5 28 25"
08-13 13:52:34.920+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 626 5 28 25"
08-13 13:52:34.920+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 213 654 5 28 25"
08-13 13:52:34.920+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 682 5 28 25"
08-13 13:52:34.920+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 710 5 28 25"
08-13 13:52:34.920+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 738 5 28 25"
08-13 13:52:34.970+0900 I/record  ( 4899): [G3] [솔] [196.00 Hz]
08-13 13:52:35.050+0900 I/record  ( 4899): [E4] [미] [329.60 Hz]
08-13 13:52:35.120+0900 I/record  ( 4899): [D#1] [레#] [38.80 Hz]
08-13 13:52:35.200+0900 I/record  ( 4899): [D4] [레] [293.70 Hz]
08-13 13:52:35.330+0900 I/record  ( 4899): [G#4] [솔#] [415.30 Hz]
08-13 13:52:35.410+0900 I/record  ( 4899): [G#4] [솔#] [415.30 Hz]
08-13 13:52:35.490+0900 I/record  ( 4899): [C3] [도] [130.80 Hz]
08-13 13:52:35.610+0900 I/record  ( 4899): [G#2] [솔#] [103.80 Hz]
08-13 13:52:35.690+0900 I/record  ( 4899): [D3] [레 ] [146.80 Hz]
08-13 13:52:35.770+0900 I/record  ( 4899): [A2] [라] [110.00 Hz]
08-13 13:52:35.860+0900 I/Tizen::Net::Wifi(  970): (1072) > _WifiService is not registered.
08-13 13:52:35.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 13:52:35.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 13:52:35.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 13:52:35.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 306 5 28 25"
08-13 13:52:35.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 213 334 5 28 25"
08-13 13:52:35.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 362 5 28 25"
08-13 13:52:35.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 390 5 28 25"
08-13 13:52:35.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 418 5 28 25"
08-13 13:52:35.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 13:52:35.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 13:52:35.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 13:52:35.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 598 5 28 25"
08-13 13:52:35.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 626 5 28 25"
08-13 13:52:35.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 213 654 5 28 25"
08-13 13:52:35.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 682 5 28 25"
08-13 13:52:35.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 710 5 28 25"
08-13 13:52:35.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 738 5 28 25"
08-13 13:52:35.890+0900 I/record  ( 4899): [C2] [도] [65.40 Hz]
08-13 13:52:35.980+0900 I/record  ( 4899): [F#2] [파#] [92.50 Hz]
08-13 13:52:36.060+0900 I/record  ( 4899): [A#2] [라#] [116.50 Hz]
08-13 13:52:36.060+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:36.190+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:36.260+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:36.340+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:36.460+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:36.540+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:36.630+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:36.830+0900 I/record  ( 4899): [F6] [파] [1396.90 Hz]
08-13 13:52:36.830+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:36.900+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:37.110+0900 I/record  ( 4899): [F6] [파] [1396.90 Hz]
08-13 13:52:37.110+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:37.190+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:37.310+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:37.470+0900 I/record  ( 4899): [G#6] [솔#] [1661.20 Hz]
08-13 13:52:37.560+0900 I/record  ( 4899): [E6] [미] [1318.50 Hz]
08-13 13:52:37.640+0900 I/record  ( 4899): [C#2] [도#] [69.30 Hz]
08-13 13:52:37.750+0900 I/record  ( 4899): [C#2] [도#] [69.30 Hz]
08-13 13:52:37.830+0900 I/record  ( 4899): [C#2] [도#] [69.30 Hz]
08-13 13:52:37.910+0900 I/record  ( 4899): [C#2] [도#] [69.30 Hz]
08-13 13:52:38.030+0900 I/record  ( 4899): [C#2] [도#] [69.30 Hz]
08-13 13:52:38.110+0900 I/record  ( 4899): [A#6] [라#] [1864.70 Hz]
08-13 13:52:38.210+0900 I/record  ( 4899): [A#6] [라#] [1864.70 Hz]
08-13 13:52:38.290+0900 I/record  ( 4899): [C#2] [도#] [69.30 Hz]
08-13 13:52:38.370+0900 I/record  ( 4899): [C2] [도] [65.40 Hz]
08-13 13:52:38.490+0900 I/record  ( 4899): [A6] [라] [1760.00 Hz]
08-13 13:52:38.570+0900 I/record  ( 4899): [C#2] [도#] [69.30 Hz]
08-13 13:52:38.650+0900 I/record  ( 4899): [C#2] [도#] [69.30 Hz]
08-13 13:52:38.770+0900 I/record  ( 4899): [C#2] [도#] [69.30 Hz]
08-13 13:52:38.850+0900 I/record  ( 4899): [C2] [도] [65.40 Hz]
08-13 13:52:38.940+0900 I/record  ( 4899): [C#2] [도#] [69.30 Hz]
08-13 13:52:39.050+0900 I/record  ( 4899): [C#2] [도#] [69.30 Hz]
08-13 13:52:39.140+0900 I/record  ( 4899): [C#2] [도#] [69.30 Hz]
08-13 13:52:39.220+0900 I/record  ( 4899): [C#2] [도#] [69.30 Hz]
08-13 13:52:39.300+0900 I/record  ( 4899): [C#2] [도#] [69.30 Hz]
08-13 13:52:39.420+0900 I/record  ( 4899): [C#2] [도#] [69.30 Hz]
08-13 13:52:39.500+0900 I/record  ( 4899): [C#2] [도#] [69.30 Hz]
08-13 13:52:39.580+0900 I/record  ( 4899): [C#2] [도#] [69.30 Hz]
08-13 13:52:39.700+0900 I/record  ( 4899): [C#2] [도#] [69.30 Hz]
08-13 13:52:39.790+0900 I/record  ( 4899): [F6] [파] [1396.90 Hz]
08-13 13:52:39.860+0900 I/record  ( 4899): [A6] [라] [1760.00 Hz]
08-13 13:52:39.980+0900 I/record  ( 4899): [F6] [파] [1396.90 Hz]
08-13 13:52:39.990+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:40.070+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:40.160+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:40.270+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:40.350+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:40.430+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:40.550+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:40.640+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:40.720+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:40.800+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:40.920+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:40.990+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:41.080+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:41.200+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:41.360+0900 I/record  ( 4899): [G#2] [솔#] [103.80 Hz]
08-13 13:52:41.450+0900 I/record  ( 4899): [F6] [파] [1396.90 Hz]
08-13 13:52:41.560+0900 I/record  ( 4899): [G#6] [솔#] [1661.20 Hz]
08-13 13:52:41.650+0900 I/record  ( 4899): [C#2] [도#] [69.30 Hz]
08-13 13:52:41.730+0900 I/record  ( 4899): [C#2] [도#] [69.30 Hz]
08-13 13:52:41.830+0900 I/record  ( 4899): [A6] [라] [1760.00 Hz]
08-13 13:52:41.920+0900 I/record  ( 4899): [C#2] [도#] [69.30 Hz]
08-13 13:52:42.000+0900 I/record  ( 4899): [C#2] [도#] [69.30 Hz]
08-13 13:52:42.120+0900 I/record  ( 4899): [C#2] [도#] [69.30 Hz]
08-13 13:52:42.200+0900 I/record  ( 4899): [G6] [솔] [1568.00 Hz]
08-13 13:52:42.280+0900 I/record  ( 4899): [C#2] [도#] [69.30 Hz]
08-13 13:52:42.350+0900 I/record  ( 4899): [D2] [레] [73.40 Hz]
08-13 13:52:42.480+0900 I/record  ( 4899): [C#2] [도#] [69.30 Hz]
08-13 13:52:42.560+0900 I/record  ( 4899): [C#2] [도#] [69.30 Hz]
08-13 13:52:42.670+0900 I/record  ( 4899): [C#2] [도#] [69.30 Hz]
08-13 13:52:42.750+0900 I/record  ( 4899): [C#2] [도#] [69.30 Hz]
08-13 13:52:42.830+0900 I/record  ( 4899): [C#2] [도#] [69.30 Hz]
08-13 13:52:42.950+0900 I/record  ( 4899): [C#2] [도#] [69.30 Hz]
08-13 13:52:43.030+0900 I/record  ( 4899): [D2] [레] [73.40 Hz]
08-13 13:52:43.110+0900 I/record  ( 4899): [D2] [레] [73.40 Hz]
08-13 13:52:43.230+0900 I/record  ( 4899): [D2] [레] [73.40 Hz]
08-13 13:52:43.310+0900 I/record  ( 4899): [G#6] [솔#] [1661.20 Hz]
08-13 13:52:43.390+0900 I/record  ( 4899): [D2] [레] [73.40 Hz]
08-13 13:52:43.510+0900 I/record  ( 4899): [D2] [레] [73.40 Hz]
08-13 13:52:43.590+0900 I/record  ( 4899): [D2] [레] [73.40 Hz]
08-13 13:52:43.680+0900 I/record  ( 4899): [D2] [레] [73.40 Hz]
08-13 13:52:43.760+0900 I/record  ( 4899): [D2] [레] [73.40 Hz]
08-13 13:52:43.870+0900 I/record  ( 4899): [D2] [레] [73.40 Hz]
08-13 13:52:43.960+0900 I/record  ( 4899): [D2] [레] [73.40 Hz]
08-13 13:52:44.040+0900 I/record  ( 4899): [D#6] [레#] [1244.50 Hz]
08-13 13:52:44.090+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:44.160+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:44.240+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:44.330+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:44.450+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:44.530+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:44.610+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:44.810+0900 I/record  ( 4899): [F#6] [파#] [1480.00 Hz]
08-13 13:52:44.820+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:44.890+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:45.010+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:45.090+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:45.180+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:45.370+0900 I/record  ( 4899): [G3] [솔] [196.00 Hz]
08-13 13:52:45.460+0900 I/record  ( 4899): [E3] [미] [164.80 Hz]
08-13 13:52:45.470+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:45.560+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:45.630+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:45.760+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:45.840+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:45.860+0900 I/Tizen::Net::Wifi(  970): (1072) > _WifiService is not registered.
08-13 13:52:45.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
08-13 13:52:45.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
08-13 13:52:45.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
08-13 13:52:45.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 306 5 28 25"
08-13 13:52:45.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 213 334 5 28 25"
08-13 13:52:45.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 362 5 28 25"
08-13 13:52:45.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 390 5 28 25"
08-13 13:52:45.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 418 5 28 25"
08-13 13:52:45.860+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
08-13 13:52:45.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
08-13 13:52:45.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
08-13 13:52:45.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 201 598 5 28 25"
08-13 13:52:45.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 204 626 5 28 25"
08-13 13:52:45.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 213 654 5 28 25"
08-13 13:52:45.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 682 5 28 25"
08-13 13:52:45.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 214 710 5 28 25"
08-13 13:52:45.870+0900 I/indicator(  494): indicator_box_util.c: _update_display(585) > "Noti Icon : 216 738 5 28 25"
08-13 13:52:45.910+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:46.040+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:46.120+0900 I/record  ( 4899): [A0] [라] [27.50 Hz]
08-13 13:52:46.280+0900 I/record  ( 4899): [G#6] [솔#] [1661.20 Hz]
08-13 13:52:46.370+0900 I/record  ( 4899): [A#2] [라#] [116.50 Hz]
08-13 13:52:46.480+0900 I/record  ( 4899): [B2] [시] [123.50 Hz]
08-13 13:52:46.560+0900 I/record  ( 4899): [B2] [시] [123.50 Hz]
08-13 13:52:46.640+0900 I/record  ( 4899): [B2] [시] [123.50 Hz]
08-13 13:52:46.760+0900 I/record  ( 4899): [B2] [시] [123.50 Hz]
08-13 13:52:46.840+0900 I/record  ( 4899): [A#2] [라#] [116.50 Hz]
08-13 13:52:46.920+0900 I/record  ( 4899): [B2] [시] [123.50 Hz]
08-13 13:52:47.040+0900 I/record  ( 4899): [B2] [시] [123.50 Hz]
08-13 13:52:47.120+0900 I/record  ( 4899): [B2] [시] [123.50 Hz]
08-13 13:52:47.200+0900 I/record  ( 4899): [B2] [시] [123.50 Hz]
08-13 13:52:47.320+0900 I/record  ( 4899): [B2] [시] [123.50 Hz]
08-13 13:52:47.400+0900 I/record  ( 4899): [B2] [시] [123.50 Hz]
08-13 13:52:47.480+0900 I/record  ( 4899): [B2] [시] [123.50 Hz]
08-13 13:52:47.600+0900 I/record  ( 4899): [B2] [시] [123.50 Hz]
08-13 13:52:47.680+0900 I/record  ( 4899): [B2] [시] [123.50 Hz]
08-13 13:52:47.760+0900 I/record  ( 4899): [B2] [시] [123.50 Hz]
08-13 13:52:47.840+0900 I/record  ( 4899): [B2] [시] [123.50 Hz]
08-13 13:52:47.960+0900 I/record  ( 4899): [A2] [라] [110.00 Hz]
08-13 13:52:48.120+0900 I/AUL_PAD (  492): sigchild.h: __launchpad_sig_child(142) > dead_pid = 4899 pgid = 4899
08-13 13:52:48.120+0900 I/AUL_PAD (  492): sigchild.h: __sigchild_action(123) > dead_pid(4899)
08-13 13:52:48.120+0900 I/AUL_PAD (  492): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
08-13 13:52:48.120+0900 I/AUL_PAD (  492): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
08-13 13:52:48.150+0900 I/Tizen::System(  940): (246) > Terminated app [org.samteam.perfectsong]
08-13 13:52:48.150+0900 I/Tizen::Io(  940): (729) > Entry not found
08-13 13:52:48.150+0900 I/Tizen::App(  902): (243) > App[org.samteam.perfectsong] pid[4899] terminate event is forwarded
08-13 13:52:48.150+0900 I/Tizen::System(  902): (256) > osp.accessorymanager.service provider is found.
08-13 13:52:48.150+0900 I/Tizen::System(  902): (196) > Accessory Owner is removed [org.samteam.perfectsong, 4899, ]
08-13 13:52:48.150+0900 I/Tizen::System(  902): (256) > osp.system.service provider is found.
08-13 13:52:48.150+0900 I/Tizen::App(  902): (506) > TerminatedApp(org.samteam.perfectsong)
08-13 13:52:48.150+0900 I/Tizen::App(  902): (512) > Not registered pid(4899)
08-13 13:52:48.150+0900 I/Tizen::App(  902): (782) > Finished invoking application event listener for org.samteam.perfectsong, 4899.
08-13 13:52:48.160+0900 I/AUL_AMD (  438): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 4899
08-13 13:52:48.160+0900 W/AUL_AMD (  438): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
08-13 13:52:48.160+0900 W/AUL_AMD (  438): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
08-13 13:52:48.180+0900 I/Tizen::System(  940): (157) > change brightness system value.
08-13 13:52:48.180+0900 I/Tizen::App(  940): (782) > Finished invoking application event listener for org.samteam.perfectsong, 4899.
08-13 13:52:48.200+0900 W/PROCESSMGR(  378): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=588
08-13 13:52:48.220+0900 I/QUICKPANEL(  666): sound-profile.c: _view_update(106) > [_view_update : 106] sound : 1, vibration : 0
08-13 13:52:48.230+0900 I/QUICKPANEL(  666): quickpanel-ui.c: _ui_handler_input_region_set(172) > [_ui_handler_input_region_set : 172] win_input_0:0
08-13 13:52:48.230+0900 I/QUICKPANEL(  666): win_input_1:758
08-13 13:52:48.230+0900 I/QUICKPANEL(  666): win_input_2:480
08-13 13:52:48.230+0900 I/QUICKPANEL(  666): win_input_3:42
08-13 13:52:48.230+0900 I/QUICKPANEL(  666): 
08-13 13:52:48.240+0900 I/CAPI_APPFW_APPLICATION(  588): app_main.c: app_appcore_resume(223) > app_appcore_resume
08-13 13:52:48.240+0900 E/cluster-home(  588): homescreen-main.cpp: app_resume(422) >  app resume
08-13 13:52:48.250+0900 W/CRASH_MANAGER( 5480): worker.c: worker_job(1198) > 1104899706161143944156
