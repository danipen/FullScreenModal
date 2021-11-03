```    ~/Pr/F/b/D/n/o/publish/FullScreenModal.app/Contents/MacOS  ./FullScreenModal                                                                          ✔  at 17:51:14 
2021-11-03 17:51:24.314 FullScreenModal[73243:5959277] NSWindowStyleMaskFullScreen cleared on a window outside of a full screen transition. Called from (
	0   AppKit                              0x00007fff22dfb826 __25-[NSWindow setStyleMask:]_block_invoke + 125
	1   AppKit                              0x00007fff22dfb74f NSPerformVisuallyAtomicChange + 132
	2   AppKit                              0x00007fff22dfb65c -[NSWindow setStyleMask:] + 170
	3   libAvaloniaNative.dylib             0x0000000107e6ae7a _ZN10WindowImpl9SetParentEP10IAvnWindow + 240
	4   ???                                 0x000000011584832c 0x0 + 4655973164
	5   ???                                 0x00000001158481ca 0x0 + 4655972810
	6   ???                                 0x0000000115847eb9 0x0 + 4655972025
	7   ???                                 0x0000000115847449 0x0 + 4655969353
	8   ???                                 0x000000011584638a 0x0 + 4655965066
	9   ???                                 0x000000011583f8b2 0x0 + 4655937714
	10  ???                                 0x000000011583f7dc 0x0 + 4655937500
	11  ???                                 0x00000001157997e0 0x0 + 4655257568
	12  ???                                 0x0000000115828cb0 0x0 + 4655844528
	13  ???                                 0x0000000115828582 0x0 + 4655842690
	14  ???                                 0x0000000115846126 0x0 + 4655964454
	15  ???                                 0x00000001158446ae 0x0 + 4655957678
	16  ???                                 0x00000001158443df 0x0 + 4655956959
	17  ???                                 0x00000001157999a2 0x0 + 4655258018
	18  ???                                 0x0000000115799766 0x0 + 4655257446
	19  ???                                 0x0000000115828cb0 0x0 + 4655844528
	20  ???                                 0x0000000115828582 0x0 + 4655842690
	21  ???                                 0x0000000115844111 0x0 + 4655956241
	22  ???                                 0x0000000115825e70 0x0 + 4655832688
	23  ???                                 0x0000000115825aa6 0x0 + 4655831718
	24  ???                                 0x0000000115825445 0x0 + 4655830085
	25  ???                                 0x0000000115824c19 0x0 + 4655827993
	26  ???                                 0x0000000115811fea 0x0 + 4655751146
	27  libAvaloniaNative.dylib             0x0000000107e65caa -[AvnView mouseEvent:withType:] + 678
	28  libAvaloniaNative.dylib             0x0000000107e65f94 -[AvnView mouseUp:] + 33
	29  AppKit                              0x00007fff22f336c5 -[NSWindow(NSEventRouting) _reallySendEvent:isDelayedEvent:] + 2719
	30  AppKit                              0x00007fff22f32a06 -[NSWindow(NSEventRouting) sendEvent:] + 347
	31  libAvaloniaNative.dylib             0x0000000107e67f3c -[AvnWindow sendEvent:] + 63
	32  AppKit                              0x00007fff22f30e14 -[NSApplication(NSEvent) sendEvent:] + 352
	33  libAvaloniaNative.dylib             0x0000000107e57c21 -[AvnApplication sendEvent:] + 84
	34  AppKit                              0x00007fff23209be1 -[NSApplication _handleEvent:] + 65
	35  AppKit                              0x00007fff22d99c8e -[NSApplication run] + 623
	36  libAvaloniaNative.dylib             0x0000000107e5b9d0 _ZN26PlatformThreadingInterface7RunLoopEP20IAvnLoopCancellation + 128
	37  ???                                 0x000000011580d06d 0x0 + 4655730797
	38  ???                                 0x000000011580c808 0x0 + 4655728648
	39  ???                                 0x000000011580c5e7 0x0 + 4655728103
	40  ???                                 0x0000000115796849 0x0 + 4655245385
	41  ???                                 0x0000000113be3ef9 0x0 + 4626202361
	42  ???                                 0x0000000113bc84ba 0x0 + 4626089146
	43  libcoreclr.dylib                    0x00000001050713d9 CallDescrWorkerInternal + 124
	44  libcoreclr.dylib                    0x0000000104ec62ef _ZN18MethodDescCallSite16CallTargetWorkerEPKmPmi + 1519
	45  libcoreclr.dylib                    0x0000000104da19ba _Z7RunMainP10MethodDescsPiPP8PtrArray + 746
	46  libcoreclr.dylib                    0x0000000104da1cf3 _ZN8Assembly17ExecuteMainMethodEPP8PtrArrayi + 387
	47  libcoreclr.dylib                    0x0000000104dde83d _ZN8CorHost215ExecuteAssemblyEjPKDsiPS1_Pj + 509
	48  libcoreclr.dylib                    0x0000000104d8b222 coreclr_execute_assembly + 242
	49  libhostpolicy.dylib                 0x0000000104cf0923 _Z19run_app_for_contextRK20hostpolicy_context_tiPPKc + 1443
	50  libhostpolicy.dylib                 0x0000000104cf1c2a corehost_main + 234
	51  libhostfxr.dylib                    0x0000000104c8c981 _ZN10fx_muxer_t24handle_exec_host_commandERKNSt3__112basic_stringIcNS0_11char_traitsIcEENS0_9allocatorIcEEEERK19host_startup_info_tS8_RKNS0_13unordered_mapI13known_optionsNS0_6vectorIS6_NS4_IS6_EEEE18known_options_hashNS0_8equal_toISD_EENS4_INS0_4pairIKSD_SG_EEEEEEiPPKci11host_mode_tPciPi + 1281
	52  libhostfxr.dylib                    0x0000000104c8bad3 _ZN10fx_muxer_t7executeENSt3__112basic_stringIcNS0_11char_traitsIcEENS0_9allocatorIcEEEEiPPKcRK19host_startup_info_tPciPi + 611
	53  libhostfxr.dylib                    0x0000000104c8947a hostfxr_main_startupinfo + 138
	54  FullScreenModal                     0x0000000104c3b793 _Z9exe_startiPPKc + 1795
	55  FullScreenModal                     0x0000000104c3b9df main + 143
	56  libdyld.dylib                       0x00007fff204c5f3d start + 1
	57  ???                                 0x0000000000000001 0x0 + 1
)
2021-11-03 17:51:24.324 FullScreenModal[73243:5959277] NSWindowStyleMaskFullScreen cleared on a window outside of a full screen transition. Called from (
	0   AppKit                              0x00007fff22dfb826 __25-[NSWindow setStyleMask:]_block_invoke + 125
	1   AppKit                              0x00007fff22dfb74f NSPerformVisuallyAtomicChange + 132
	2   AppKit                              0x00007fff22dfb65c -[NSWindow setStyleMask:] + 170
	3   libAvaloniaNative.dylib             0x0000000107e68ae3 _ZN14WindowBaseImpl4ShowEbb + 123
	4   libAvaloniaNative.dylib             0x0000000107e6ac82 _ZN10WindowImpl4ShowEbb + 96
	5   ???                                 0x00000001157dcdee 0x0 + 4655533550
	6   ???                                 0x00000001157dccf4 0x0 + 4655533300
	7   ???                                 0x0000000115847f69 0x0 + 4655972201
	8   ???                                 0x0000000115847449 0x0 + 4655969353
	9   ???                                 0x000000011584638a 0x0 + 4655965066
	10  ???                                 0x000000011583f8b2 0x0 + 4655937714
	11  ???                                 0x000000011583f7dc 0x0 + 4655937500
	12  ???                                 0x00000001157997e0 0x0 + 4655257568
	13  ???                                 0x0000000115828cb0 0x0 + 4655844528
	14  ???                                 0x0000000115828582 0x0 + 4655842690
	15  ???                                 0x0000000115846126 0x0 + 4655964454
	16  ???                                 0x00000001158446ae 0x0 + 4655957678
	17  ???                                 0x00000001158443df 0x0 + 4655956959
	18  ???                                 0x00000001157999a2 0x0 + 4655258018
	19  ???                                 0x0000000115799766 0x0 + 4655257446
	20  ???                                 0x0000000115828cb0 0x0 + 4655844528
	21  ???                                 0x0000000115828582 0x0 + 4655842690
	22  ???                                 0x0000000115844111 0x0 + 4655956241
	23  ???                                 0x0000000115825e70 0x0 + 4655832688
	24  ???                                 0x0000000115825aa6 0x0 + 4655831718
	25  ???                                 0x0000000115825445 0x0 + 4655830085
	26  ???                                 0x0000000115824c19 0x0 + 4655827993
	27  ???                                 0x0000000115811fea 0x0 + 4655751146
	28  libAvaloniaNative.dylib             0x0000000107e65caa -[AvnView mouseEvent:withType:] + 678
	29  libAvaloniaNative.dylib             0x0000000107e65f94 -[AvnView mouseUp:] + 33
	30  AppKit                              0x00007fff22f336c5 -[NSWindow(NSEventRouting) _reallySendEvent:isDelayedEvent:] + 2719
	31  AppKit                              0x00007fff22f32a06 -[NSWindow(NSEventRouting) sendEvent:] + 347
	32  libAvaloniaNative.dylib             0x0000000107e67f3c -[AvnWindow sendEvent:] + 63
	33  AppKit                              0x00007fff22f30e14 -[NSApplication(NSEvent) sendEvent:] + 352
	34  libAvaloniaNative.dylib             0x0000000107e57c21 -[AvnApplication sendEvent:] + 84
	35  AppKit                              0x00007fff23209be1 -[NSApplication _handleEvent:] + 65
	36  AppKit                              0x00007fff22d99c8e -[NSApplication run] + 623
	37  libAvaloniaNative.dylib             0x0000000107e5b9d0 _ZN26PlatformThreadingInterface7RunLoopEP20IAvnLoopCancellation + 128
	38  ???                                 0x000000011580d06d 0x0 + 4655730797
	39  ???                                 0x000000011580c808 0x0 + 4655728648
	40  ???                                 0x000000011580c5e7 0x0 + 4655728103
	41  ???                                 0x0000000115796849 0x0 + 4655245385
	42  ???                                 0x0000000113be3ef9 0x0 + 4626202361
	43  ???                                 0x0000000113bc84ba 0x0 + 4626089146
	44  libcoreclr.dylib                    0x00000001050713d9 CallDescrWorkerInternal + 124
	45  libcoreclr.dylib                    0x0000000104ec62ef _ZN18MethodDescCallSite16CallTargetWorkerEPKmPmi + 1519
	46  libcoreclr.dylib                    0x0000000104da19ba _Z7RunMainP10MethodDescsPiPP8PtrArray + 746
	47  libcoreclr.dylib                    0x0000000104da1cf3 _ZN8Assembly17ExecuteMainMethodEPP8PtrArrayi + 387
	48  libcoreclr.dylib                    0x0000000104dde83d _ZN8CorHost215ExecuteAssemblyEjPKDsiPS1_Pj + 509
	49  libcoreclr.dylib                    0x0000000104d8b222 coreclr_execute_assembly + 242
	50  libhostpolicy.dylib                 0x0000000104cf0923 _Z19run_app_for_contextRK20hostpolicy_context_tiPPKc + 1443
	51  libhostpolicy.dylib                 0x0000000104cf1c2a corehost_main + 234
	52  libhostfxr.dylib                    0x0000000104c8c981 _ZN10fx_muxer_t24handle_exec_host_commandERKNSt3__112basic_stringIcNS0_11char_traitsIcEENS0_9allocatorIcEEEERK19host_startup_info_tS8_RKNS0_13unordered_mapI13known_optionsNS0_6vectorIS6_NS4_IS6_EEEE18known_options_hashNS0_8equal_toISD_EENS4_INS0_4pairIKSD_SG_EEEEEEiPPKci11host_mode_tPciPi + 1281
	53  libhostfxr.dylib                    0x0000000104c8bad3 _ZN10fx_muxer_t7executeENSt3__112basic_stringIcNS0_11char_traitsIcEENS0_9allocatorIcEEEEiPPKcRK19host_startup_info_tPciPi + 611
	54  libhostfxr.dylib                    0x0000000104c8947a hostfxr_main_startupinfo + 138
	55  FullScreenModal                     0x0000000104c3b793 _Z9exe_startiPPKc + 1795
	56  FullScreenModal                     0x0000000104c3b9df main + 143
	57  libdyld.dylib                       0x00007fff204c5f3d start + 1
	58  ???                                 0x0000000000000001 0x0 + 1
)```