using System;
using System.Runtime.InteropServices;
using UnityEngine;

internal class AkSoundEnginePINVOKE
{
	static AkSoundEnginePINVOKE()
	{
	}

	public static extern uint CSharp_AK_SOUNDBANK_VERSION_get();

	public static extern void CSharp_AkAudioSettings_uNumSamplesPerFrame_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkAudioSettings_uNumSamplesPerFrame_get(IntPtr jarg1);

	public static extern void CSharp_AkAudioSettings_uNumSamplesPerSecond_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkAudioSettings_uNumSamplesPerSecond_get(IntPtr jarg1);

	public static extern IntPtr CSharp_new_AkAudioSettings();

	public static extern void CSharp_delete_AkAudioSettings(IntPtr jarg1);

	public static extern void CSharp_AkDeviceDescription_idDevice_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkDeviceDescription_idDevice_get(IntPtr jarg1);

	public static extern void CSharp_AkDeviceDescription_deviceName_set(IntPtr jarg1, string jarg2);

	public static extern IntPtr CSharp_AkDeviceDescription_deviceName_get(IntPtr jarg1);

	public static extern void CSharp_AkDeviceDescription_deviceStateMask_set(IntPtr jarg1, int jarg2);

	public static extern int CSharp_AkDeviceDescription_deviceStateMask_get(IntPtr jarg1);

	public static extern void CSharp_AkDeviceDescription_isDefaultDevice_set(IntPtr jarg1, bool jarg2);

	public static extern bool CSharp_AkDeviceDescription_isDefaultDevice_get(IntPtr jarg1);

	public static extern void CSharp_AkDeviceDescription_Clear(IntPtr jarg1);

	public static extern int CSharp_AkDeviceDescription_GetSizeOf();

	public static extern void CSharp_AkDeviceDescription_Clone(IntPtr jarg1, IntPtr jarg2);

	public static extern IntPtr CSharp_new_AkDeviceDescription();

	public static extern void CSharp_delete_AkDeviceDescription(IntPtr jarg1);

	public static extern Vector3 CSharp_AkTransform_Position(IntPtr jarg1);

	public static extern Vector3 CSharp_AkTransform_OrientationFront(IntPtr jarg1);

	public static extern Vector3 CSharp_AkTransform_OrientationTop(IntPtr jarg1);

	public static extern void CSharp_AkTransform_Set__SWIG_0(IntPtr jarg1, Vector3 jarg2, Vector3 jarg3, Vector3 jarg4);

	public static extern void CSharp_AkTransform_Set__SWIG_1(IntPtr jarg1, float jarg2, float jarg3, float jarg4, float jarg5, float jarg6, float jarg7, float jarg8, float jarg9, float jarg10);

	public static extern void CSharp_AkTransform_SetPosition__SWIG_0(IntPtr jarg1, Vector3 jarg2);

	public static extern void CSharp_AkTransform_SetPosition__SWIG_1(IntPtr jarg1, float jarg2, float jarg3, float jarg4);

	public static extern void CSharp_AkTransform_SetOrientation__SWIG_0(IntPtr jarg1, Vector3 jarg2, Vector3 jarg3);

	public static extern void CSharp_AkTransform_SetOrientation__SWIG_1(IntPtr jarg1, float jarg2, float jarg3, float jarg4, float jarg5, float jarg6, float jarg7);

	public static extern IntPtr CSharp_new_AkTransform();

	public static extern void CSharp_delete_AkTransform(IntPtr jarg1);

	public static extern void CSharp_AkObstructionOcclusionValues_occlusion_set(IntPtr jarg1, float jarg2);

	public static extern float CSharp_AkObstructionOcclusionValues_occlusion_get(IntPtr jarg1);

	public static extern void CSharp_AkObstructionOcclusionValues_obstruction_set(IntPtr jarg1, float jarg2);

	public static extern float CSharp_AkObstructionOcclusionValues_obstruction_get(IntPtr jarg1);

	public static extern void CSharp_AkObstructionOcclusionValues_Clear(IntPtr jarg1);

	public static extern int CSharp_AkObstructionOcclusionValues_GetSizeOf();

	public static extern void CSharp_AkObstructionOcclusionValues_Clone(IntPtr jarg1, IntPtr jarg2);

	public static extern IntPtr CSharp_new_AkObstructionOcclusionValues();

	public static extern void CSharp_delete_AkObstructionOcclusionValues(IntPtr jarg1);

	public static extern void CSharp_AkChannelEmitter_position_set(IntPtr jarg1, IntPtr jarg2);

	public static extern IntPtr CSharp_AkChannelEmitter_position_get(IntPtr jarg1);

	public static extern void CSharp_AkChannelEmitter_uInputChannels_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkChannelEmitter_uInputChannels_get(IntPtr jarg1);

	public static extern void CSharp_delete_AkChannelEmitter(IntPtr jarg1);

	public static extern void CSharp_AkAuxSendValue_listenerID_set(IntPtr jarg1, ulong jarg2);

	public static extern ulong CSharp_AkAuxSendValue_listenerID_get(IntPtr jarg1);

	public static extern void CSharp_AkAuxSendValue_auxBusID_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkAuxSendValue_auxBusID_get(IntPtr jarg1);

	public static extern void CSharp_AkAuxSendValue_fControlValue_set(IntPtr jarg1, float jarg2);

	public static extern float CSharp_AkAuxSendValue_fControlValue_get(IntPtr jarg1);

	public static extern void CSharp_AkAuxSendValue_Set(IntPtr jarg1, ulong jarg2, uint jarg3, float jarg4);

	public static extern bool CSharp_AkAuxSendValue_IsSame(IntPtr jarg1, ulong jarg2, uint jarg3);

	public static extern int CSharp_AkAuxSendValue_GetSizeOf();

	public static extern void CSharp_delete_AkAuxSendValue(IntPtr jarg1);

	public static extern IntPtr CSharp_new_AkRamp__SWIG_0();

	public static extern IntPtr CSharp_new_AkRamp__SWIG_1(float jarg1, float jarg2);

	public static extern void CSharp_AkRamp_fPrev_set(IntPtr jarg1, float jarg2);

	public static extern float CSharp_AkRamp_fPrev_get(IntPtr jarg1);

	public static extern void CSharp_AkRamp_fNext_set(IntPtr jarg1, float jarg2);

	public static extern float CSharp_AkRamp_fNext_get(IntPtr jarg1);

	public static extern void CSharp_delete_AkRamp(IntPtr jarg1);

	public static extern ushort CSharp_AK_INT_get();

	public static extern ushort CSharp_AK_FLOAT_get();

	public static extern byte CSharp_AK_INTERLEAVED_get();

	public static extern byte CSharp_AK_NONINTERLEAVED_get();

	public static extern uint CSharp_AK_LE_NATIVE_BITSPERSAMPLE_get();

	public static extern uint CSharp_AK_LE_NATIVE_SAMPLETYPE_get();

	public static extern uint CSharp_AK_LE_NATIVE_INTERLEAVE_get();

	public static extern void CSharp_AkAudioFormat_uSampleRate_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkAudioFormat_uSampleRate_get(IntPtr jarg1);

	public static extern void CSharp_AkAudioFormat_channelConfig_set(IntPtr jarg1, IntPtr jarg2);

	public static extern IntPtr CSharp_AkAudioFormat_channelConfig_get(IntPtr jarg1);

	public static extern void CSharp_AkAudioFormat_uBitsPerSample_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkAudioFormat_uBitsPerSample_get(IntPtr jarg1);

	public static extern void CSharp_AkAudioFormat_uBlockAlign_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkAudioFormat_uBlockAlign_get(IntPtr jarg1);

	public static extern void CSharp_AkAudioFormat_uTypeID_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkAudioFormat_uTypeID_get(IntPtr jarg1);

	public static extern void CSharp_AkAudioFormat_uInterleaveID_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkAudioFormat_uInterleaveID_get(IntPtr jarg1);

	public static extern uint CSharp_AkAudioFormat_GetNumChannels(IntPtr jarg1);

	public static extern uint CSharp_AkAudioFormat_GetBitsPerSample(IntPtr jarg1);

	public static extern uint CSharp_AkAudioFormat_GetBlockAlign(IntPtr jarg1);

	public static extern uint CSharp_AkAudioFormat_GetTypeID(IntPtr jarg1);

	public static extern uint CSharp_AkAudioFormat_GetInterleaveID(IntPtr jarg1);

	public static extern void CSharp_AkAudioFormat_SetAll(IntPtr jarg1, uint jarg2, IntPtr jarg3, uint jarg4, uint jarg5, uint jarg6, uint jarg7);

	public static extern bool CSharp_AkAudioFormat_IsChannelConfigSupported(IntPtr jarg1);

	public static extern IntPtr CSharp_new_AkAudioFormat();

	public static extern void CSharp_delete_AkAudioFormat(IntPtr jarg1);

	public static extern void CSharp_AkIterator_pItem_set(IntPtr jarg1, IntPtr jarg2);

	public static extern IntPtr CSharp_AkIterator_pItem_get(IntPtr jarg1);

	public static extern IntPtr CSharp_AkIterator_NextIter(IntPtr jarg1);

	public static extern IntPtr CSharp_AkIterator_PrevIter(IntPtr jarg1);

	public static extern IntPtr CSharp_AkIterator_GetItem(IntPtr jarg1);

	public static extern bool CSharp_AkIterator_IsEqualTo(IntPtr jarg1, IntPtr jarg2);

	public static extern bool CSharp_AkIterator_IsDifferentFrom(IntPtr jarg1, IntPtr jarg2);

	public static extern IntPtr CSharp_new_AkIterator();

	public static extern void CSharp_delete_AkIterator(IntPtr jarg1);

	public static extern IntPtr CSharp_new_AkPlaylistItem__SWIG_0();

	public static extern IntPtr CSharp_new_AkPlaylistItem__SWIG_1(IntPtr jarg1);

	public static extern void CSharp_delete_AkPlaylistItem(IntPtr jarg1);

	public static extern IntPtr CSharp_AkPlaylistItem_Assign(IntPtr jarg1, IntPtr jarg2);

	public static extern bool CSharp_AkPlaylistItem_IsEqualTo(IntPtr jarg1, IntPtr jarg2);

	public static extern int CSharp_AkPlaylistItem_SetExternalSources(IntPtr jarg1, uint jarg2, IntPtr jarg3);

	public static extern void CSharp_AkPlaylistItem_audioNodeID_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkPlaylistItem_audioNodeID_get(IntPtr jarg1);

	public static extern void CSharp_AkPlaylistItem_msDelay_set(IntPtr jarg1, int jarg2);

	public static extern int CSharp_AkPlaylistItem_msDelay_get(IntPtr jarg1);

	public static extern void CSharp_AkPlaylistItem_pCustomInfo_set(IntPtr jarg1, IntPtr jarg2);

	public static extern IntPtr CSharp_AkPlaylistItem_pCustomInfo_get(IntPtr jarg1);

	public static extern IntPtr CSharp_new_AkPlaylistArray();

	public static extern void CSharp_delete_AkPlaylistArray(IntPtr jarg1);

	public static extern IntPtr CSharp_AkPlaylistArray_Begin(IntPtr jarg1);

	public static extern IntPtr CSharp_AkPlaylistArray_End(IntPtr jarg1);

	public static extern IntPtr CSharp_AkPlaylistArray_FindEx(IntPtr jarg1, IntPtr jarg2);

	public static extern IntPtr CSharp_AkPlaylistArray_Erase__SWIG_0(IntPtr jarg1, IntPtr jarg2);

	public static extern void CSharp_AkPlaylistArray_Erase__SWIG_1(IntPtr jarg1, uint jarg2);

	public static extern IntPtr CSharp_AkPlaylistArray_EraseSwap(IntPtr jarg1, IntPtr jarg2);

	public static extern bool CSharp_AkPlaylistArray_IsGrowingAllowed(IntPtr jarg1);

	public static extern int CSharp_AkPlaylistArray_Reserve(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkPlaylistArray_Reserved(IntPtr jarg1);

	public static extern void CSharp_AkPlaylistArray_Term(IntPtr jarg1);

	public static extern uint CSharp_AkPlaylistArray_Length(IntPtr jarg1);

	public static extern IntPtr CSharp_AkPlaylistArray_Data(IntPtr jarg1);

	public static extern bool CSharp_AkPlaylistArray_IsEmpty(IntPtr jarg1);

	public static extern IntPtr CSharp_AkPlaylistArray_Exists(IntPtr jarg1, IntPtr jarg2);

	public static extern IntPtr CSharp_AkPlaylistArray_AddLast__SWIG_0(IntPtr jarg1);

	public static extern IntPtr CSharp_AkPlaylistArray_AddLast__SWIG_1(IntPtr jarg1, IntPtr jarg2);

	public static extern IntPtr CSharp_AkPlaylistArray_Last(IntPtr jarg1);

	public static extern void CSharp_AkPlaylistArray_RemoveLast(IntPtr jarg1);

	public static extern int CSharp_AkPlaylistArray_Remove(IntPtr jarg1, IntPtr jarg2);

	public static extern int CSharp_AkPlaylistArray_RemoveSwap(IntPtr jarg1, IntPtr jarg2);

	public static extern void CSharp_AkPlaylistArray_RemoveAll(IntPtr jarg1);

	public static extern IntPtr CSharp_AkPlaylistArray_ItemAtIndex(IntPtr jarg1, uint jarg2);

	public static extern IntPtr CSharp_AkPlaylistArray_Insert(IntPtr jarg1, uint jarg2);

	public static extern bool CSharp_AkPlaylistArray_GrowArray__SWIG_0(IntPtr jarg1);

	public static extern bool CSharp_AkPlaylistArray_GrowArray__SWIG_1(IntPtr jarg1, uint jarg2);

	public static extern bool CSharp_AkPlaylistArray_Resize(IntPtr jarg1, uint jarg2);

	public static extern void CSharp_AkPlaylistArray_Transfer(IntPtr jarg1, IntPtr jarg2);

	public static extern int CSharp_AkPlaylistArray_Copy(IntPtr jarg1, IntPtr jarg2);

	public static extern int CSharp_AkPlaylist_Enqueue__SWIG_0(IntPtr jarg1, uint jarg2, int jarg3, IntPtr jarg4, uint jarg5, IntPtr jarg6);

	public static extern int CSharp_AkPlaylist_Enqueue__SWIG_1(IntPtr jarg1, uint jarg2, int jarg3, IntPtr jarg4, uint jarg5);

	public static extern int CSharp_AkPlaylist_Enqueue__SWIG_2(IntPtr jarg1, uint jarg2, int jarg3, IntPtr jarg4);

	public static extern int CSharp_AkPlaylist_Enqueue__SWIG_3(IntPtr jarg1, uint jarg2, int jarg3);

	public static extern int CSharp_AkPlaylist_Enqueue__SWIG_4(IntPtr jarg1, uint jarg2);

	public static extern IntPtr CSharp_new_AkPlaylist();

	public static extern void CSharp_delete_AkPlaylist(IntPtr jarg1);

	public static extern uint CSharp_DynamicSequenceOpen__SWIG_0(ulong jarg1, uint jarg2, IntPtr jarg3, IntPtr jarg4, int jarg5);

	public static extern uint CSharp_DynamicSequenceOpen__SWIG_1(ulong jarg1, uint jarg2, IntPtr jarg3, IntPtr jarg4);

	public static extern uint CSharp_DynamicSequenceOpen__SWIG_2(ulong jarg1);

	public static extern int CSharp_DynamicSequenceClose(uint jarg1);

	public static extern int CSharp_DynamicSequencePlay__SWIG_0(uint jarg1, int jarg2, int jarg3);

	public static extern int CSharp_DynamicSequencePlay__SWIG_1(uint jarg1, int jarg2);

	public static extern int CSharp_DynamicSequencePlay__SWIG_2(uint jarg1);

	public static extern int CSharp_DynamicSequencePause__SWIG_0(uint jarg1, int jarg2, int jarg3);

	public static extern int CSharp_DynamicSequencePause__SWIG_1(uint jarg1, int jarg2);

	public static extern int CSharp_DynamicSequencePause__SWIG_2(uint jarg1);

	public static extern int CSharp_DynamicSequenceResume__SWIG_0(uint jarg1, int jarg2, int jarg3);

	public static extern int CSharp_DynamicSequenceResume__SWIG_1(uint jarg1, int jarg2);

	public static extern int CSharp_DynamicSequenceResume__SWIG_2(uint jarg1);

	public static extern int CSharp_DynamicSequenceStop__SWIG_0(uint jarg1, int jarg2, int jarg3);

	public static extern int CSharp_DynamicSequenceStop__SWIG_1(uint jarg1, int jarg2);

	public static extern int CSharp_DynamicSequenceStop__SWIG_2(uint jarg1);

	public static extern int CSharp_DynamicSequenceBreak(uint jarg1);

	public static extern int CSharp_Seek__SWIG_0(uint jarg1, int jarg2, bool jarg3);

	public static extern int CSharp_Seek__SWIG_1(uint jarg1, float jarg2, bool jarg3);

	public static extern int CSharp_DynamicSequenceGetPauseTimes(uint jarg1, out uint jarg2, out uint jarg3);

	public static extern IntPtr CSharp_DynamicSequenceLockPlaylist(uint jarg1);

	public static extern int CSharp_DynamicSequenceUnlockPlaylist(uint jarg1);

	public static extern IntPtr CSharp_new_AkOutputSettings__SWIG_0();

	public static extern IntPtr CSharp_new_AkOutputSettings__SWIG_1(string jarg1, uint jarg2, IntPtr jarg3, int jarg4);

	public static extern IntPtr CSharp_new_AkOutputSettings__SWIG_2(string jarg1, uint jarg2, IntPtr jarg3);

	public static extern IntPtr CSharp_new_AkOutputSettings__SWIG_3(string jarg1, uint jarg2);

	public static extern IntPtr CSharp_new_AkOutputSettings__SWIG_4(string jarg1);

	public static extern void CSharp_AkOutputSettings_audioDeviceShareset_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkOutputSettings_audioDeviceShareset_get(IntPtr jarg1);

	public static extern void CSharp_AkOutputSettings_idDevice_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkOutputSettings_idDevice_get(IntPtr jarg1);

	public static extern void CSharp_AkOutputSettings_ePanningRule_set(IntPtr jarg1, int jarg2);

	public static extern int CSharp_AkOutputSettings_ePanningRule_get(IntPtr jarg1);

	public static extern void CSharp_AkOutputSettings_channelConfig_set(IntPtr jarg1, IntPtr jarg2);

	public static extern IntPtr CSharp_AkOutputSettings_channelConfig_get(IntPtr jarg1);

	public static extern void CSharp_delete_AkOutputSettings(IntPtr jarg1);

	public static extern void CSharp_AkTaskContext_uIdxThread_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkTaskContext_uIdxThread_get(IntPtr jarg1);

	public static extern IntPtr CSharp_new_AkTaskContext();

	public static extern void CSharp_delete_AkTaskContext(IntPtr jarg1);

	public static extern void CSharp_AkInitSettings_uMaxNumPaths_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkInitSettings_uMaxNumPaths_get(IntPtr jarg1);

	public static extern void CSharp_AkInitSettings_uCommandQueueSize_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkInitSettings_uCommandQueueSize_get(IntPtr jarg1);

	public static extern void CSharp_AkInitSettings_bEnableGameSyncPreparation_set(IntPtr jarg1, bool jarg2);

	public static extern bool CSharp_AkInitSettings_bEnableGameSyncPreparation_get(IntPtr jarg1);

	public static extern void CSharp_AkInitSettings_uContinuousPlaybackLookAhead_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkInitSettings_uContinuousPlaybackLookAhead_get(IntPtr jarg1);

	public static extern void CSharp_AkInitSettings_uNumSamplesPerFrame_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkInitSettings_uNumSamplesPerFrame_get(IntPtr jarg1);

	public static extern void CSharp_AkInitSettings_uMonitorQueuePoolSize_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkInitSettings_uMonitorQueuePoolSize_get(IntPtr jarg1);

	public static extern void CSharp_AkInitSettings_settingsMainOutput_set(IntPtr jarg1, IntPtr jarg2);

	public static extern IntPtr CSharp_AkInitSettings_settingsMainOutput_get(IntPtr jarg1);

	public static extern void CSharp_AkInitSettings_uMaxHardwareTimeoutMs_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkInitSettings_uMaxHardwareTimeoutMs_get(IntPtr jarg1);

	public static extern void CSharp_AkInitSettings_bUseSoundBankMgrThread_set(IntPtr jarg1, bool jarg2);

	public static extern bool CSharp_AkInitSettings_bUseSoundBankMgrThread_get(IntPtr jarg1);

	public static extern void CSharp_AkInitSettings_bUseLEngineThread_set(IntPtr jarg1, bool jarg2);

	public static extern bool CSharp_AkInitSettings_bUseLEngineThread_get(IntPtr jarg1);

	public static extern void CSharp_AkInitSettings_szPluginDLLPath_set(IntPtr jarg1, string jarg2);

	public static extern IntPtr CSharp_AkInitSettings_szPluginDLLPath_get(IntPtr jarg1);

	public static extern void CSharp_AkInitSettings_eFloorPlane_set(IntPtr jarg1, int jarg2);

	public static extern int CSharp_AkInitSettings_eFloorPlane_get(IntPtr jarg1);

	public static extern void CSharp_AkInitSettings_uBankReadBufferSize_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkInitSettings_uBankReadBufferSize_get(IntPtr jarg1);

	public static extern void CSharp_AkInitSettings_fDebugOutOfRangeLimit_set(IntPtr jarg1, float jarg2);

	public static extern float CSharp_AkInitSettings_fDebugOutOfRangeLimit_get(IntPtr jarg1);

	public static extern void CSharp_AkInitSettings_bDebugOutOfRangeCheckEnabled_set(IntPtr jarg1, bool jarg2);

	public static extern bool CSharp_AkInitSettings_bDebugOutOfRangeCheckEnabled_get(IntPtr jarg1);

	public static extern void CSharp_delete_AkInitSettings(IntPtr jarg1);

	public static extern void CSharp_AkSourceSettings_sourceID_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkSourceSettings_sourceID_get(IntPtr jarg1);

	public static extern void CSharp_AkSourceSettings_pMediaMemory_set(IntPtr jarg1, IntPtr jarg2);

	public static extern IntPtr CSharp_AkSourceSettings_pMediaMemory_get(IntPtr jarg1);

	public static extern void CSharp_AkSourceSettings_uMediaSize_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkSourceSettings_uMediaSize_get(IntPtr jarg1);

	public static extern void CSharp_AkSourceSettings_Clear(IntPtr jarg1);

	public static extern int CSharp_AkSourceSettings_GetSizeOf();

	public static extern void CSharp_AkSourceSettings_Clone(IntPtr jarg1, IntPtr jarg2);

	public static extern IntPtr CSharp_new_AkSourceSettings();

	public static extern void CSharp_delete_AkSourceSettings(IntPtr jarg1);

	public static extern bool CSharp_IsInitialized();

	public static extern int CSharp_GetAudioSettings(IntPtr jarg1);

	public static extern IntPtr CSharp_GetSpeakerConfiguration__SWIG_0(ulong jarg1);

	public static extern IntPtr CSharp_GetSpeakerConfiguration__SWIG_1();

	public static extern int CSharp_GetPanningRule__SWIG_0(out int jarg1, ulong jarg2);

	public static extern int CSharp_GetPanningRule__SWIG_1(out int jarg1);

	public static extern int CSharp_SetPanningRule__SWIG_0(int jarg1, ulong jarg2);

	public static extern int CSharp_SetPanningRule__SWIG_1(int jarg1);

	public static extern int CSharp_GetSpeakerAngles__SWIG_0([In][Out] float[] jarg1, ref uint jarg2, out float jarg3, ulong jarg4);

	public static extern int CSharp_GetSpeakerAngles__SWIG_1([In][Out] float[] jarg1, ref uint jarg2, out float jarg3);

	public static extern int CSharp_SetSpeakerAngles__SWIG_0([In] float[] jarg1, uint jarg2, float jarg3, ulong jarg4);

	public static extern int CSharp_SetSpeakerAngles__SWIG_1([In] float[] jarg1, uint jarg2, float jarg3);

	public static extern int CSharp_SetVolumeThreshold(float jarg1);

	public static extern int CSharp_SetMaxNumVoicesLimit(ushort jarg1);

	public static extern int CSharp_RenderAudio__SWIG_0(bool jarg1);

	public static extern int CSharp_RenderAudio__SWIG_1();

	public static extern int CSharp_RegisterPluginDLL__SWIG_0(string jarg1, string jarg2);

	public static extern int CSharp_RegisterPluginDLL__SWIG_1(string jarg1);

	public static extern uint CSharp_GetIDFromString(string jarg1);

	public static extern uint CSharp_PostEvent__SWIG_0(uint jarg1, ulong jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5, uint jarg6, IntPtr jarg7, uint jarg8);

	public static extern uint CSharp_PostEvent__SWIG_1(uint jarg1, ulong jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5, uint jarg6, IntPtr jarg7);

	public static extern uint CSharp_PostEvent__SWIG_2(uint jarg1, ulong jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5);

	public static extern uint CSharp_PostEvent__SWIG_3(uint jarg1, ulong jarg2);

	public static extern uint CSharp_PostEvent__SWIG_4(string jarg1, ulong jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5, uint jarg6, IntPtr jarg7, uint jarg8);

	public static extern uint CSharp_PostEvent__SWIG_5(string jarg1, ulong jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5, uint jarg6, IntPtr jarg7);

	public static extern uint CSharp_PostEvent__SWIG_6(string jarg1, ulong jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5);

	public static extern uint CSharp_PostEvent__SWIG_7(string jarg1, ulong jarg2);

	public static extern int CSharp_ExecuteActionOnEvent__SWIG_0(uint jarg1, int jarg2, ulong jarg3, int jarg4, int jarg5, uint jarg6);

	public static extern int CSharp_ExecuteActionOnEvent__SWIG_1(uint jarg1, int jarg2, ulong jarg3, int jarg4, int jarg5);

	public static extern int CSharp_ExecuteActionOnEvent__SWIG_2(uint jarg1, int jarg2, ulong jarg3, int jarg4);

	public static extern int CSharp_ExecuteActionOnEvent__SWIG_3(uint jarg1, int jarg2, ulong jarg3);

	public static extern int CSharp_ExecuteActionOnEvent__SWIG_4(uint jarg1, int jarg2);

	public static extern int CSharp_ExecuteActionOnEvent__SWIG_5(string jarg1, int jarg2, ulong jarg3, int jarg4, int jarg5, uint jarg6);

	public static extern int CSharp_ExecuteActionOnEvent__SWIG_6(string jarg1, int jarg2, ulong jarg3, int jarg4, int jarg5);

	public static extern int CSharp_ExecuteActionOnEvent__SWIG_7(string jarg1, int jarg2, ulong jarg3, int jarg4);

	public static extern int CSharp_ExecuteActionOnEvent__SWIG_8(string jarg1, int jarg2, ulong jarg3);

	public static extern int CSharp_ExecuteActionOnEvent__SWIG_9(string jarg1, int jarg2);

	public static extern int CSharp_PostMIDIOnEvent(uint jarg1, ulong jarg2, IntPtr jarg3, ushort jarg4);

	public static extern int CSharp_StopMIDIOnEvent__SWIG_0(uint jarg1, ulong jarg2);

	public static extern int CSharp_StopMIDIOnEvent__SWIG_1(uint jarg1);

	public static extern int CSharp_StopMIDIOnEvent__SWIG_2();

	public static extern int CSharp_PinEventInStreamCache__SWIG_0(uint jarg1, sbyte jarg2, sbyte jarg3);

	public static extern int CSharp_PinEventInStreamCache__SWIG_1(string jarg1, sbyte jarg2, sbyte jarg3);

	public static extern int CSharp_UnpinEventInStreamCache__SWIG_0(uint jarg1);

	public static extern int CSharp_UnpinEventInStreamCache__SWIG_1(string jarg1);

	public static extern int CSharp_GetBufferStatusForPinnedEvent__SWIG_0(uint jarg1, out float jarg2, out int jarg3);

	public static extern int CSharp_GetBufferStatusForPinnedEvent__SWIG_1(string jarg1, out float jarg2, out int jarg3);

	public static extern int CSharp_SeekOnEvent__SWIG_0(uint jarg1, ulong jarg2, int jarg3, bool jarg4, uint jarg5);

	public static extern int CSharp_SeekOnEvent__SWIG_1(uint jarg1, ulong jarg2, int jarg3, bool jarg4);

	public static extern int CSharp_SeekOnEvent__SWIG_2(uint jarg1, ulong jarg2, int jarg3);

	public static extern int CSharp_SeekOnEvent__SWIG_3(string jarg1, ulong jarg2, int jarg3, bool jarg4, uint jarg5);

	public static extern int CSharp_SeekOnEvent__SWIG_4(string jarg1, ulong jarg2, int jarg3, bool jarg4);

	public static extern int CSharp_SeekOnEvent__SWIG_5(string jarg1, ulong jarg2, int jarg3);

	public static extern int CSharp_SeekOnEvent__SWIG_6(uint jarg1, ulong jarg2, float jarg3, bool jarg4, uint jarg5);

	public static extern int CSharp_SeekOnEvent__SWIG_7(uint jarg1, ulong jarg2, float jarg3, bool jarg4);

	public static extern int CSharp_SeekOnEvent__SWIG_8(uint jarg1, ulong jarg2, float jarg3);

	public static extern int CSharp_SeekOnEvent__SWIG_9(string jarg1, ulong jarg2, float jarg3, bool jarg4, uint jarg5);

	public static extern int CSharp_SeekOnEvent__SWIG_10(string jarg1, ulong jarg2, float jarg3, bool jarg4);

	public static extern int CSharp_SeekOnEvent__SWIG_11(string jarg1, ulong jarg2, float jarg3);

	public static extern void CSharp_CancelEventCallbackCookie(IntPtr jarg1);

	public static extern void CSharp_CancelEventCallbackGameObject(ulong jarg1);

	public static extern void CSharp_CancelEventCallback(uint jarg1);

	public static extern int CSharp_GetSourcePlayPosition__SWIG_0(uint jarg1, out int jarg2, bool jarg3);

	public static extern int CSharp_GetSourcePlayPosition__SWIG_1(uint jarg1, out int jarg2);

	public static extern int CSharp_GetSourceStreamBuffering(uint jarg1, out int jarg2, out int jarg3);

	public static extern void CSharp_StopAll__SWIG_0(ulong jarg1);

	public static extern void CSharp_StopAll__SWIG_1();

	public static extern void CSharp_StopPlayingID__SWIG_0(uint jarg1, int jarg2, int jarg3);

	public static extern void CSharp_StopPlayingID__SWIG_1(uint jarg1, int jarg2);

	public static extern void CSharp_StopPlayingID__SWIG_2(uint jarg1);

	public static extern void CSharp_ExecuteActionOnPlayingID__SWIG_0(int jarg1, uint jarg2, int jarg3, int jarg4);

	public static extern void CSharp_ExecuteActionOnPlayingID__SWIG_1(int jarg1, uint jarg2, int jarg3);

	public static extern void CSharp_ExecuteActionOnPlayingID__SWIG_2(int jarg1, uint jarg2);

	public static extern void CSharp_SetRandomSeed(uint jarg1);

	public static extern void CSharp_MuteBackgroundMusic(bool jarg1);

	public static extern bool CSharp_GetBackgroundMusicMute();

	public static extern int CSharp_SendPluginCustomGameData(uint jarg1, ulong jarg2, int jarg3, uint jarg4, uint jarg5, IntPtr jarg6, uint jarg7);

	public static extern int CSharp_UnregisterAllGameObj();

	public static extern int CSharp_SetMultiplePositions__SWIG_0(ulong jarg1, IntPtr jarg2, ushort jarg3, int jarg4);

	public static extern int CSharp_SetMultiplePositions__SWIG_1(ulong jarg1, IntPtr jarg2, ushort jarg3);

	public static extern int CSharp_SetMultiplePositions__SWIG_2(ulong jarg1, IntPtr jarg2, ushort jarg3, int jarg4);

	public static extern int CSharp_SetMultiplePositions__SWIG_3(ulong jarg1, IntPtr jarg2, ushort jarg3);

	public static extern int CSharp_SetScalingFactor(ulong jarg1, float jarg2);

	public static extern int CSharp_ClearBanks();

	public static extern int CSharp_SetBankLoadIOSettings(float jarg1, sbyte jarg2);

	public static extern int CSharp_LoadBank__SWIG_0(string jarg1, out uint jarg2);

	public static extern int CSharp_LoadBank__SWIG_1(uint jarg1);

	public static extern int CSharp_LoadBankMemoryView__SWIG_0(IntPtr jarg1, uint jarg2, out uint jarg3);

	public static extern int CSharp_LoadBankMemoryCopy__SWIG_0(IntPtr jarg1, uint jarg2, out uint jarg3);

	public static extern int CSharp_LoadBank__SWIG_2(string jarg1, IntPtr jarg2, IntPtr jarg3, out uint jarg4);

	public static extern int CSharp_LoadBank__SWIG_3(uint jarg1, IntPtr jarg2, IntPtr jarg3);

	public static extern int CSharp_LoadBankMemoryView__SWIG_1(IntPtr jarg1, uint jarg2, IntPtr jarg3, IntPtr jarg4, out uint jarg5);

	public static extern int CSharp_LoadBankMemoryCopy__SWIG_1(IntPtr jarg1, uint jarg2, IntPtr jarg3, IntPtr jarg4, out uint jarg5);

	public static extern int CSharp_UnloadBank__SWIG_0(string jarg1, IntPtr jarg2);

	public static extern int CSharp_UnloadBank__SWIG_1(uint jarg1, IntPtr jarg2);

	public static extern int CSharp_UnloadBank__SWIG_2(string jarg1, IntPtr jarg2, IntPtr jarg3, IntPtr jarg4);

	public static extern int CSharp_UnloadBank__SWIG_3(uint jarg1, IntPtr jarg2, IntPtr jarg3, IntPtr jarg4);

	public static extern void CSharp_CancelBankCallbackCookie(IntPtr jarg1);

	public static extern int CSharp_PrepareBank__SWIG_0(int jarg1, string jarg2, int jarg3);

	public static extern int CSharp_PrepareBank__SWIG_1(int jarg1, string jarg2);

	public static extern int CSharp_PrepareBank__SWIG_2(int jarg1, uint jarg2, int jarg3);

	public static extern int CSharp_PrepareBank__SWIG_3(int jarg1, uint jarg2);

	public static extern int CSharp_PrepareBank__SWIG_4(int jarg1, string jarg2, IntPtr jarg3, IntPtr jarg4, int jarg5);

	public static extern int CSharp_PrepareBank__SWIG_5(int jarg1, string jarg2, IntPtr jarg3, IntPtr jarg4);

	public static extern int CSharp_PrepareBank__SWIG_6(int jarg1, uint jarg2, IntPtr jarg3, IntPtr jarg4, int jarg5);

	public static extern int CSharp_PrepareBank__SWIG_7(int jarg1, uint jarg2, IntPtr jarg3, IntPtr jarg4);

	public static extern int CSharp_ClearPreparedEvents();

	public static extern int CSharp_PrepareEvent__SWIG_0(int jarg1, IntPtr jarg2, uint jarg3);

	public static extern int CSharp_PrepareEvent__SWIG_1(int jarg1, [In] uint[] jarg2, uint jarg3);

	public static extern int CSharp_PrepareEvent__SWIG_2(int jarg1, IntPtr jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5);

	public static extern int CSharp_PrepareEvent__SWIG_3(int jarg1, [In] uint[] jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5);

	public static extern int CSharp_SetMedia(IntPtr jarg1, uint jarg2);

	public static extern int CSharp_UnsetMedia(IntPtr jarg1, uint jarg2);

	public static extern int CSharp_PrepareGameSyncs__SWIG_0(int jarg1, int jarg2, string jarg3, IntPtr jarg4, uint jarg5);

	public static extern int CSharp_PrepareGameSyncs__SWIG_1(int jarg1, int jarg2, uint jarg3, [In] uint[] jarg4, uint jarg5);

	public static extern int CSharp_PrepareGameSyncs__SWIG_2(int jarg1, int jarg2, string jarg3, IntPtr jarg4, uint jarg5, IntPtr jarg6, IntPtr jarg7);

	public static extern int CSharp_PrepareGameSyncs__SWIG_3(int jarg1, int jarg2, uint jarg3, [In] uint[] jarg4, uint jarg5, IntPtr jarg6, IntPtr jarg7);

	public static extern int CSharp_AddListener(ulong jarg1, ulong jarg2);

	public static extern int CSharp_RemoveListener(ulong jarg1, ulong jarg2);

	public static extern int CSharp_AddDefaultListener(ulong jarg1);

	public static extern int CSharp_RemoveDefaultListener(ulong jarg1);

	public static extern int CSharp_ResetListenersToDefault(ulong jarg1);

	public static extern int CSharp_SetListenerSpatialization__SWIG_0(ulong jarg1, bool jarg2, IntPtr jarg3, [In] float[] jarg4);

	public static extern int CSharp_SetListenerSpatialization__SWIG_1(ulong jarg1, bool jarg2, IntPtr jarg3);

	public static extern int CSharp_SetRTPCValue__SWIG_0(uint jarg1, float jarg2, ulong jarg3, int jarg4, int jarg5, bool jarg6);

	public static extern int CSharp_SetRTPCValue__SWIG_1(uint jarg1, float jarg2, ulong jarg3, int jarg4, int jarg5);

	public static extern int CSharp_SetRTPCValue__SWIG_2(uint jarg1, float jarg2, ulong jarg3, int jarg4);

	public static extern int CSharp_SetRTPCValue__SWIG_3(uint jarg1, float jarg2, ulong jarg3);

	public static extern int CSharp_SetRTPCValue__SWIG_4(uint jarg1, float jarg2);

	public static extern int CSharp_SetRTPCValue__SWIG_5(string jarg1, float jarg2, ulong jarg3, int jarg4, int jarg5, bool jarg6);

	public static extern int CSharp_SetRTPCValue__SWIG_6(string jarg1, float jarg2, ulong jarg3, int jarg4, int jarg5);

	public static extern int CSharp_SetRTPCValue__SWIG_7(string jarg1, float jarg2, ulong jarg3, int jarg4);

	public static extern int CSharp_SetRTPCValue__SWIG_8(string jarg1, float jarg2, ulong jarg3);

	public static extern int CSharp_SetRTPCValue__SWIG_9(string jarg1, float jarg2);

	public static extern int CSharp_SetRTPCValueByPlayingID__SWIG_0(uint jarg1, float jarg2, uint jarg3, int jarg4, int jarg5, bool jarg6);

	public static extern int CSharp_SetRTPCValueByPlayingID__SWIG_1(uint jarg1, float jarg2, uint jarg3, int jarg4, int jarg5);

	public static extern int CSharp_SetRTPCValueByPlayingID__SWIG_2(uint jarg1, float jarg2, uint jarg3, int jarg4);

	public static extern int CSharp_SetRTPCValueByPlayingID__SWIG_3(uint jarg1, float jarg2, uint jarg3);

	public static extern int CSharp_SetRTPCValueByPlayingID__SWIG_4(string jarg1, float jarg2, uint jarg3, int jarg4, int jarg5, bool jarg6);

	public static extern int CSharp_SetRTPCValueByPlayingID__SWIG_5(string jarg1, float jarg2, uint jarg3, int jarg4, int jarg5);

	public static extern int CSharp_SetRTPCValueByPlayingID__SWIG_6(string jarg1, float jarg2, uint jarg3, int jarg4);

	public static extern int CSharp_SetRTPCValueByPlayingID__SWIG_7(string jarg1, float jarg2, uint jarg3);

	public static extern int CSharp_ResetRTPCValue__SWIG_0(uint jarg1, ulong jarg2, int jarg3, int jarg4, bool jarg5);

	public static extern int CSharp_ResetRTPCValue__SWIG_1(uint jarg1, ulong jarg2, int jarg3, int jarg4);

	public static extern int CSharp_ResetRTPCValue__SWIG_2(uint jarg1, ulong jarg2, int jarg3);

	public static extern int CSharp_ResetRTPCValue__SWIG_3(uint jarg1, ulong jarg2);

	public static extern int CSharp_ResetRTPCValue__SWIG_4(uint jarg1);

	public static extern int CSharp_ResetRTPCValue__SWIG_5(string jarg1, ulong jarg2, int jarg3, int jarg4, bool jarg5);

	public static extern int CSharp_ResetRTPCValue__SWIG_6(string jarg1, ulong jarg2, int jarg3, int jarg4);

	public static extern int CSharp_ResetRTPCValue__SWIG_7(string jarg1, ulong jarg2, int jarg3);

	public static extern int CSharp_ResetRTPCValue__SWIG_8(string jarg1, ulong jarg2);

	public static extern int CSharp_ResetRTPCValue__SWIG_9(string jarg1);

	public static extern int CSharp_SetSwitch__SWIG_0(uint jarg1, uint jarg2, ulong jarg3);

	public static extern int CSharp_SetSwitch__SWIG_1(string jarg1, string jarg2, ulong jarg3);

	public static extern int CSharp_PostTrigger__SWIG_0(uint jarg1, ulong jarg2);

	public static extern int CSharp_PostTrigger__SWIG_1(string jarg1, ulong jarg2);

	public static extern int CSharp_SetState__SWIG_0(uint jarg1, uint jarg2);

	public static extern int CSharp_SetState__SWIG_1(string jarg1, string jarg2);

	public static extern int CSharp_SetGameObjectAuxSendValues(ulong jarg1, IntPtr jarg2, uint jarg3);

	public static extern int CSharp_SetGameObjectOutputBusVolume(ulong jarg1, ulong jarg2, float jarg3);

	public static extern int CSharp_SetActorMixerEffect(uint jarg1, uint jarg2, uint jarg3);

	public static extern int CSharp_SetBusEffect__SWIG_0(uint jarg1, uint jarg2, uint jarg3);

	public static extern int CSharp_SetBusEffect__SWIG_1(string jarg1, uint jarg2, uint jarg3);

	public static extern int CSharp_SetMixer__SWIG_0(uint jarg1, uint jarg2);

	public static extern int CSharp_SetMixer__SWIG_1(string jarg1, uint jarg2);

	public static extern int CSharp_SetBusConfig__SWIG_0(uint jarg1, IntPtr jarg2);

	public static extern int CSharp_SetBusConfig__SWIG_1(string jarg1, IntPtr jarg2);

	public static extern int CSharp_SetObjectObstructionAndOcclusion(ulong jarg1, ulong jarg2, float jarg3, float jarg4);

	public static extern int CSharp_SetMultipleObstructionAndOcclusion(ulong jarg1, ulong jarg2, IntPtr jarg3, uint jarg4);

	public static extern int CSharp_StartOutputCapture(string jarg1);

	public static extern int CSharp_StopOutputCapture();

	public static extern int CSharp_AddOutputCaptureMarker(string jarg1);

	public static extern int CSharp_StartProfilerCapture(string jarg1);

	public static extern int CSharp_StopProfilerCapture();

	public static extern int CSharp_RemoveOutput(ulong jarg1);

	public static extern int CSharp_ReplaceOutput__SWIG_0(IntPtr jarg1, ulong jarg2, out ulong jarg3);

	public static extern int CSharp_ReplaceOutput__SWIG_1(IntPtr jarg1, ulong jarg2);

	public static extern ulong CSharp_GetOutputID__SWIG_0(uint jarg1, uint jarg2);

	public static extern ulong CSharp_GetOutputID__SWIG_1(string jarg1, uint jarg2);

	public static extern int CSharp_SetBusDevice__SWIG_0(uint jarg1, uint jarg2);

	public static extern int CSharp_SetBusDevice__SWIG_1(string jarg1, string jarg2);

	public static extern int CSharp_GetDeviceList__SWIG_0(uint jarg1, uint jarg2, out uint jarg3, IntPtr jarg4);

	public static extern int CSharp_GetDeviceList__SWIG_1(uint jarg1, out uint jarg2, IntPtr jarg3);

	public static extern int CSharp_SetOutputVolume(ulong jarg1, float jarg2);

	public static extern int CSharp_GetDeviceSpatialAudioSupport(uint jarg1);

	public static extern int CSharp_Suspend__SWIG_0(bool jarg1);

	public static extern int CSharp_Suspend__SWIG_1();

	public static extern int CSharp_WakeupFromSuspend();

	public static extern uint CSharp_GetBufferTick();

	public static extern void CSharp_AkSegmentInfo_iCurrentPosition_set(IntPtr jarg1, int jarg2);

	public static extern int CSharp_AkSegmentInfo_iCurrentPosition_get(IntPtr jarg1);

	public static extern void CSharp_AkSegmentInfo_iPreEntryDuration_set(IntPtr jarg1, int jarg2);

	public static extern int CSharp_AkSegmentInfo_iPreEntryDuration_get(IntPtr jarg1);

	public static extern void CSharp_AkSegmentInfo_iActiveDuration_set(IntPtr jarg1, int jarg2);

	public static extern int CSharp_AkSegmentInfo_iActiveDuration_get(IntPtr jarg1);

	public static extern void CSharp_AkSegmentInfo_iPostExitDuration_set(IntPtr jarg1, int jarg2);

	public static extern int CSharp_AkSegmentInfo_iPostExitDuration_get(IntPtr jarg1);

	public static extern void CSharp_AkSegmentInfo_iRemainingLookAheadTime_set(IntPtr jarg1, int jarg2);

	public static extern int CSharp_AkSegmentInfo_iRemainingLookAheadTime_get(IntPtr jarg1);

	public static extern void CSharp_AkSegmentInfo_fBeatDuration_set(IntPtr jarg1, float jarg2);

	public static extern float CSharp_AkSegmentInfo_fBeatDuration_get(IntPtr jarg1);

	public static extern void CSharp_AkSegmentInfo_fBarDuration_set(IntPtr jarg1, float jarg2);

	public static extern float CSharp_AkSegmentInfo_fBarDuration_get(IntPtr jarg1);

	public static extern void CSharp_AkSegmentInfo_fGridDuration_set(IntPtr jarg1, float jarg2);

	public static extern float CSharp_AkSegmentInfo_fGridDuration_get(IntPtr jarg1);

	public static extern void CSharp_AkSegmentInfo_fGridOffset_set(IntPtr jarg1, float jarg2);

	public static extern float CSharp_AkSegmentInfo_fGridOffset_get(IntPtr jarg1);

	public static extern IntPtr CSharp_new_AkSegmentInfo();

	public static extern void CSharp_delete_AkSegmentInfo(IntPtr jarg1);

	public static extern void CSharp_AkResourceMonitorDataSummary_totalCPU_set(IntPtr jarg1, float jarg2);

	public static extern float CSharp_AkResourceMonitorDataSummary_totalCPU_get(IntPtr jarg1);

	public static extern void CSharp_AkResourceMonitorDataSummary_pluginCPU_set(IntPtr jarg1, float jarg2);

	public static extern float CSharp_AkResourceMonitorDataSummary_pluginCPU_get(IntPtr jarg1);

	public static extern void CSharp_AkResourceMonitorDataSummary_physicalVoices_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkResourceMonitorDataSummary_physicalVoices_get(IntPtr jarg1);

	public static extern void CSharp_AkResourceMonitorDataSummary_virtualVoices_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkResourceMonitorDataSummary_virtualVoices_get(IntPtr jarg1);

	public static extern void CSharp_AkResourceMonitorDataSummary_totalVoices_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkResourceMonitorDataSummary_totalVoices_get(IntPtr jarg1);

	public static extern void CSharp_AkResourceMonitorDataSummary_nbActiveEvents_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkResourceMonitorDataSummary_nbActiveEvents_get(IntPtr jarg1);

	public static extern IntPtr CSharp_new_AkResourceMonitorDataSummary();

	public static extern void CSharp_delete_AkResourceMonitorDataSummary(IntPtr jarg1);

	public static extern byte CSharp_AK_INVALID_MIDI_CHANNEL_get();

	public static extern byte CSharp_AK_INVALID_MIDI_NOTE_get();

	public static extern void CSharp_AkMIDIEvent_byChan_set(IntPtr jarg1, byte jarg2);

	public static extern byte CSharp_AkMIDIEvent_byChan_get(IntPtr jarg1);

	public static extern void CSharp_AkMIDIEvent_tGen_byParam1_set(IntPtr jarg1, byte jarg2);

	public static extern byte CSharp_AkMIDIEvent_tGen_byParam1_get(IntPtr jarg1);

	public static extern void CSharp_AkMIDIEvent_tGen_byParam2_set(IntPtr jarg1, byte jarg2);

	public static extern byte CSharp_AkMIDIEvent_tGen_byParam2_get(IntPtr jarg1);

	public static extern IntPtr CSharp_new_AkMIDIEvent_tGen();

	public static extern void CSharp_delete_AkMIDIEvent_tGen(IntPtr jarg1);

	public static extern void CSharp_AkMIDIEvent_tNoteOnOff_byNote_set(IntPtr jarg1, byte jarg2);

	public static extern byte CSharp_AkMIDIEvent_tNoteOnOff_byNote_get(IntPtr jarg1);

	public static extern void CSharp_AkMIDIEvent_tNoteOnOff_byVelocity_set(IntPtr jarg1, byte jarg2);

	public static extern byte CSharp_AkMIDIEvent_tNoteOnOff_byVelocity_get(IntPtr jarg1);

	public static extern IntPtr CSharp_new_AkMIDIEvent_tNoteOnOff();

	public static extern void CSharp_delete_AkMIDIEvent_tNoteOnOff(IntPtr jarg1);

	public static extern void CSharp_AkMIDIEvent_tCc_byCc_set(IntPtr jarg1, byte jarg2);

	public static extern byte CSharp_AkMIDIEvent_tCc_byCc_get(IntPtr jarg1);

	public static extern void CSharp_AkMIDIEvent_tCc_byValue_set(IntPtr jarg1, byte jarg2);

	public static extern byte CSharp_AkMIDIEvent_tCc_byValue_get(IntPtr jarg1);

	public static extern IntPtr CSharp_new_AkMIDIEvent_tCc();

	public static extern void CSharp_delete_AkMIDIEvent_tCc(IntPtr jarg1);

	public static extern void CSharp_AkMIDIEvent_tPitchBend_byValueLsb_set(IntPtr jarg1, byte jarg2);

	public static extern byte CSharp_AkMIDIEvent_tPitchBend_byValueLsb_get(IntPtr jarg1);

	public static extern void CSharp_AkMIDIEvent_tPitchBend_byValueMsb_set(IntPtr jarg1, byte jarg2);

	public static extern byte CSharp_AkMIDIEvent_tPitchBend_byValueMsb_get(IntPtr jarg1);

	public static extern IntPtr CSharp_new_AkMIDIEvent_tPitchBend();

	public static extern void CSharp_delete_AkMIDIEvent_tPitchBend(IntPtr jarg1);

	public static extern void CSharp_AkMIDIEvent_tNoteAftertouch_byNote_set(IntPtr jarg1, byte jarg2);

	public static extern byte CSharp_AkMIDIEvent_tNoteAftertouch_byNote_get(IntPtr jarg1);

	public static extern void CSharp_AkMIDIEvent_tNoteAftertouch_byValue_set(IntPtr jarg1, byte jarg2);

	public static extern byte CSharp_AkMIDIEvent_tNoteAftertouch_byValue_get(IntPtr jarg1);

	public static extern IntPtr CSharp_new_AkMIDIEvent_tNoteAftertouch();

	public static extern void CSharp_delete_AkMIDIEvent_tNoteAftertouch(IntPtr jarg1);

	public static extern void CSharp_AkMIDIEvent_tChanAftertouch_byValue_set(IntPtr jarg1, byte jarg2);

	public static extern byte CSharp_AkMIDIEvent_tChanAftertouch_byValue_get(IntPtr jarg1);

	public static extern IntPtr CSharp_new_AkMIDIEvent_tChanAftertouch();

	public static extern void CSharp_delete_AkMIDIEvent_tChanAftertouch(IntPtr jarg1);

	public static extern void CSharp_AkMIDIEvent_tProgramChange_byProgramNum_set(IntPtr jarg1, byte jarg2);

	public static extern byte CSharp_AkMIDIEvent_tProgramChange_byProgramNum_get(IntPtr jarg1);

	public static extern IntPtr CSharp_new_AkMIDIEvent_tProgramChange();

	public static extern void CSharp_delete_AkMIDIEvent_tProgramChange(IntPtr jarg1);

	public static extern void CSharp_AkMIDIEvent_Gen_set(IntPtr jarg1, IntPtr jarg2);

	public static extern IntPtr CSharp_AkMIDIEvent_Gen_get(IntPtr jarg1);

	public static extern void CSharp_AkMIDIEvent_Cc_set(IntPtr jarg1, IntPtr jarg2);

	public static extern IntPtr CSharp_AkMIDIEvent_Cc_get(IntPtr jarg1);

	public static extern void CSharp_AkMIDIEvent_NoteOnOff_set(IntPtr jarg1, IntPtr jarg2);

	public static extern IntPtr CSharp_AkMIDIEvent_NoteOnOff_get(IntPtr jarg1);

	public static extern void CSharp_AkMIDIEvent_PitchBend_set(IntPtr jarg1, IntPtr jarg2);

	public static extern IntPtr CSharp_AkMIDIEvent_PitchBend_get(IntPtr jarg1);

	public static extern void CSharp_AkMIDIEvent_NoteAftertouch_set(IntPtr jarg1, IntPtr jarg2);

	public static extern IntPtr CSharp_AkMIDIEvent_NoteAftertouch_get(IntPtr jarg1);

	public static extern void CSharp_AkMIDIEvent_ChanAftertouch_set(IntPtr jarg1, IntPtr jarg2);

	public static extern IntPtr CSharp_AkMIDIEvent_ChanAftertouch_get(IntPtr jarg1);

	public static extern void CSharp_AkMIDIEvent_ProgramChange_set(IntPtr jarg1, IntPtr jarg2);

	public static extern IntPtr CSharp_AkMIDIEvent_ProgramChange_get(IntPtr jarg1);

	public static extern void CSharp_AkMIDIEvent_byType_set(IntPtr jarg1, int jarg2);

	public static extern int CSharp_AkMIDIEvent_byType_get(IntPtr jarg1);

	public static extern void CSharp_AkMIDIEvent_byOnOffNote_set(IntPtr jarg1, byte jarg2);

	public static extern byte CSharp_AkMIDIEvent_byOnOffNote_get(IntPtr jarg1);

	public static extern void CSharp_AkMIDIEvent_byVelocity_set(IntPtr jarg1, byte jarg2);

	public static extern byte CSharp_AkMIDIEvent_byVelocity_get(IntPtr jarg1);

	public static extern void CSharp_AkMIDIEvent_byCc_set(IntPtr jarg1, int jarg2);

	public static extern int CSharp_AkMIDIEvent_byCc_get(IntPtr jarg1);

	public static extern void CSharp_AkMIDIEvent_byCcValue_set(IntPtr jarg1, byte jarg2);

	public static extern byte CSharp_AkMIDIEvent_byCcValue_get(IntPtr jarg1);

	public static extern void CSharp_AkMIDIEvent_byValueLsb_set(IntPtr jarg1, byte jarg2);

	public static extern byte CSharp_AkMIDIEvent_byValueLsb_get(IntPtr jarg1);

	public static extern void CSharp_AkMIDIEvent_byValueMsb_set(IntPtr jarg1, byte jarg2);

	public static extern byte CSharp_AkMIDIEvent_byValueMsb_get(IntPtr jarg1);

	public static extern void CSharp_AkMIDIEvent_byAftertouchNote_set(IntPtr jarg1, byte jarg2);

	public static extern byte CSharp_AkMIDIEvent_byAftertouchNote_get(IntPtr jarg1);

	public static extern void CSharp_AkMIDIEvent_byNoteAftertouchValue_set(IntPtr jarg1, byte jarg2);

	public static extern byte CSharp_AkMIDIEvent_byNoteAftertouchValue_get(IntPtr jarg1);

	public static extern void CSharp_AkMIDIEvent_byChanAftertouchValue_set(IntPtr jarg1, byte jarg2);

	public static extern byte CSharp_AkMIDIEvent_byChanAftertouchValue_get(IntPtr jarg1);

	public static extern void CSharp_AkMIDIEvent_byProgramNum_set(IntPtr jarg1, byte jarg2);

	public static extern byte CSharp_AkMIDIEvent_byProgramNum_get(IntPtr jarg1);

	public static extern IntPtr CSharp_new_AkMIDIEvent();

	public static extern void CSharp_delete_AkMIDIEvent(IntPtr jarg1);

	public static extern void CSharp_AkMIDIPost_uOffset_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkMIDIPost_uOffset_get(IntPtr jarg1);

	public static extern int CSharp_AkMIDIPost_PostOnEvent(IntPtr jarg1, uint jarg2, ulong jarg3, uint jarg4);

	public static extern void CSharp_AkMIDIPost_Clone(IntPtr jarg1, IntPtr jarg2);

	public static extern int CSharp_AkMIDIPost_GetSizeOf();

	public static extern IntPtr CSharp_new_AkMIDIPost();

	public static extern void CSharp_delete_AkMIDIPost(IntPtr jarg1);

	public static extern void CSharp_AkMusicSettings_fStreamingLookAheadRatio_set(IntPtr jarg1, float jarg2);

	public static extern float CSharp_AkMusicSettings_fStreamingLookAheadRatio_get(IntPtr jarg1);

	public static extern void CSharp_delete_AkMusicSettings(IntPtr jarg1);

	public static extern int CSharp_GetPlayingSegmentInfo__SWIG_0(uint jarg1, IntPtr jarg2, bool jarg3);

	public static extern int CSharp_GetPlayingSegmentInfo__SWIG_1(uint jarg1, IntPtr jarg2);

	public static extern IntPtr CSharp_AkSerializedCallbackHeader_pPackage_get(IntPtr jarg1);

	public static extern IntPtr CSharp_AkSerializedCallbackHeader_pNext_get(IntPtr jarg1);

	public static extern int CSharp_AkSerializedCallbackHeader_eType_get(IntPtr jarg1);

	public static extern IntPtr CSharp_AkSerializedCallbackHeader_GetData(IntPtr jarg1);

	public static extern IntPtr CSharp_new_AkSerializedCallbackHeader();

	public static extern void CSharp_delete_AkSerializedCallbackHeader(IntPtr jarg1);

	public static extern IntPtr CSharp_AkCallbackInfo_pCookie_get(IntPtr jarg1);

	public static extern ulong CSharp_AkCallbackInfo_gameObjID_get(IntPtr jarg1);

	public static extern IntPtr CSharp_new_AkCallbackInfo();

	public static extern void CSharp_delete_AkCallbackInfo(IntPtr jarg1);

	public static extern uint CSharp_AkEventCallbackInfo_playingID_get(IntPtr jarg1);

	public static extern uint CSharp_AkEventCallbackInfo_eventID_get(IntPtr jarg1);

	public static extern IntPtr CSharp_new_AkEventCallbackInfo();

	public static extern void CSharp_delete_AkEventCallbackInfo(IntPtr jarg1);

	public static extern byte CSharp_AkMIDIEventCallbackInfo_byChan_get(IntPtr jarg1);

	public static extern byte CSharp_AkMIDIEventCallbackInfo_byParam1_get(IntPtr jarg1);

	public static extern byte CSharp_AkMIDIEventCallbackInfo_byParam2_get(IntPtr jarg1);

	public static extern int CSharp_AkMIDIEventCallbackInfo_byType_get(IntPtr jarg1);

	public static extern byte CSharp_AkMIDIEventCallbackInfo_byOnOffNote_get(IntPtr jarg1);

	public static extern byte CSharp_AkMIDIEventCallbackInfo_byVelocity_get(IntPtr jarg1);

	public static extern int CSharp_AkMIDIEventCallbackInfo_byCc_get(IntPtr jarg1);

	public static extern byte CSharp_AkMIDIEventCallbackInfo_byCcValue_get(IntPtr jarg1);

	public static extern byte CSharp_AkMIDIEventCallbackInfo_byValueLsb_get(IntPtr jarg1);

	public static extern byte CSharp_AkMIDIEventCallbackInfo_byValueMsb_get(IntPtr jarg1);

	public static extern byte CSharp_AkMIDIEventCallbackInfo_byAftertouchNote_get(IntPtr jarg1);

	public static extern byte CSharp_AkMIDIEventCallbackInfo_byNoteAftertouchValue_get(IntPtr jarg1);

	public static extern byte CSharp_AkMIDIEventCallbackInfo_byChanAftertouchValue_get(IntPtr jarg1);

	public static extern byte CSharp_AkMIDIEventCallbackInfo_byProgramNum_get(IntPtr jarg1);

	public static extern IntPtr CSharp_new_AkMIDIEventCallbackInfo();

	public static extern void CSharp_delete_AkMIDIEventCallbackInfo(IntPtr jarg1);

	public static extern uint CSharp_AkMarkerCallbackInfo_uIdentifier_get(IntPtr jarg1);

	public static extern uint CSharp_AkMarkerCallbackInfo_uPosition_get(IntPtr jarg1);

	public static extern IntPtr CSharp_AkMarkerCallbackInfo_strLabel_get(IntPtr jarg1);

	public static extern IntPtr CSharp_new_AkMarkerCallbackInfo();

	public static extern void CSharp_delete_AkMarkerCallbackInfo(IntPtr jarg1);

	public static extern float CSharp_AkDurationCallbackInfo_fDuration_get(IntPtr jarg1);

	public static extern float CSharp_AkDurationCallbackInfo_fEstimatedDuration_get(IntPtr jarg1);

	public static extern uint CSharp_AkDurationCallbackInfo_audioNodeID_get(IntPtr jarg1);

	public static extern uint CSharp_AkDurationCallbackInfo_mediaID_get(IntPtr jarg1);

	public static extern bool CSharp_AkDurationCallbackInfo_bStreaming_get(IntPtr jarg1);

	public static extern IntPtr CSharp_new_AkDurationCallbackInfo();

	public static extern void CSharp_delete_AkDurationCallbackInfo(IntPtr jarg1);

	public static extern uint CSharp_AkDynamicSequenceItemCallbackInfo_playingID_get(IntPtr jarg1);

	public static extern uint CSharp_AkDynamicSequenceItemCallbackInfo_audioNodeID_get(IntPtr jarg1);

	public static extern IntPtr CSharp_AkDynamicSequenceItemCallbackInfo_pCustomInfo_get(IntPtr jarg1);

	public static extern IntPtr CSharp_new_AkDynamicSequenceItemCallbackInfo();

	public static extern void CSharp_delete_AkDynamicSequenceItemCallbackInfo(IntPtr jarg1);

	public static extern uint CSharp_AkMusicSyncCallbackInfo_playingID_get(IntPtr jarg1);

	public static extern int CSharp_AkMusicSyncCallbackInfo_segmentInfo_iCurrentPosition_get(IntPtr jarg1);

	public static extern int CSharp_AkMusicSyncCallbackInfo_segmentInfo_iPreEntryDuration_get(IntPtr jarg1);

	public static extern int CSharp_AkMusicSyncCallbackInfo_segmentInfo_iActiveDuration_get(IntPtr jarg1);

	public static extern int CSharp_AkMusicSyncCallbackInfo_segmentInfo_iPostExitDuration_get(IntPtr jarg1);

	public static extern int CSharp_AkMusicSyncCallbackInfo_segmentInfo_iRemainingLookAheadTime_get(IntPtr jarg1);

	public static extern float CSharp_AkMusicSyncCallbackInfo_segmentInfo_fBeatDuration_get(IntPtr jarg1);

	public static extern float CSharp_AkMusicSyncCallbackInfo_segmentInfo_fBarDuration_get(IntPtr jarg1);

	public static extern float CSharp_AkMusicSyncCallbackInfo_segmentInfo_fGridDuration_get(IntPtr jarg1);

	public static extern float CSharp_AkMusicSyncCallbackInfo_segmentInfo_fGridOffset_get(IntPtr jarg1);

	public static extern int CSharp_AkMusicSyncCallbackInfo_musicSyncType_get(IntPtr jarg1);

	public static extern IntPtr CSharp_AkMusicSyncCallbackInfo_userCueName_get(IntPtr jarg1);

	public static extern IntPtr CSharp_new_AkMusicSyncCallbackInfo();

	public static extern void CSharp_delete_AkMusicSyncCallbackInfo(IntPtr jarg1);

	public static extern uint CSharp_AkMusicPlaylistCallbackInfo_playlistID_get(IntPtr jarg1);

	public static extern uint CSharp_AkMusicPlaylistCallbackInfo_uNumPlaylistItems_get(IntPtr jarg1);

	public static extern uint CSharp_AkMusicPlaylistCallbackInfo_uPlaylistSelection_get(IntPtr jarg1);

	public static extern uint CSharp_AkMusicPlaylistCallbackInfo_uPlaylistItemDone_get(IntPtr jarg1);

	public static extern IntPtr CSharp_new_AkMusicPlaylistCallbackInfo();

	public static extern void CSharp_delete_AkMusicPlaylistCallbackInfo(IntPtr jarg1);

	public static extern uint CSharp_AkBankCallbackInfo_bankID_get(IntPtr jarg1);

	public static extern IntPtr CSharp_AkBankCallbackInfo_inMemoryBankPtr_get(IntPtr jarg1);

	public static extern int CSharp_AkBankCallbackInfo_loadResult_get(IntPtr jarg1);

	public static extern IntPtr CSharp_new_AkBankCallbackInfo();

	public static extern void CSharp_delete_AkBankCallbackInfo(IntPtr jarg1);

	public static extern int CSharp_AkMonitoringCallbackInfo_errorCode_get(IntPtr jarg1);

	public static extern int CSharp_AkMonitoringCallbackInfo_errorLevel_get(IntPtr jarg1);

	public static extern uint CSharp_AkMonitoringCallbackInfo_playingID_get(IntPtr jarg1);

	public static extern ulong CSharp_AkMonitoringCallbackInfo_gameObjID_get(IntPtr jarg1);

	public static extern IntPtr CSharp_AkMonitoringCallbackInfo_message_get(IntPtr jarg1);

	public static extern IntPtr CSharp_new_AkMonitoringCallbackInfo();

	public static extern void CSharp_delete_AkMonitoringCallbackInfo(IntPtr jarg1);

	public static extern bool CSharp_AkAudioInterruptionCallbackInfo_bEnterInterruption_get(IntPtr jarg1);

	public static extern IntPtr CSharp_new_AkAudioInterruptionCallbackInfo();

	public static extern void CSharp_delete_AkAudioInterruptionCallbackInfo(IntPtr jarg1);

	public static extern bool CSharp_AkAudioSourceChangeCallbackInfo_bOtherAudioPlaying_get(IntPtr jarg1);

	public static extern IntPtr CSharp_new_AkAudioSourceChangeCallbackInfo();

	public static extern void CSharp_delete_AkAudioSourceChangeCallbackInfo(IntPtr jarg1);

	public static extern void CSharp_LocalOutput(int jarg1, string jarg2, int jarg3, uint jarg4, ulong jarg5);

	public static extern int CSharp_AkCallbackSerializer_Init(IntPtr jarg1, uint jarg2);

	public static extern void CSharp_AkCallbackSerializer_Term();

	public static extern IntPtr CSharp_AkCallbackSerializer_Lock();

	public static extern void CSharp_AkCallbackSerializer_Unlock();

	public static extern void CSharp_AkCallbackSerializer_SetLocalOutput(uint jarg1);

	public static extern int CSharp_AkCallbackSerializer_AudioSourceChangeCallbackFunc(bool jarg1, IntPtr jarg2);

	public static extern IntPtr CSharp_new_AkCallbackSerializer();

	public static extern void CSharp_delete_AkCallbackSerializer(IntPtr jarg1);

	public static extern int CSharp_PostCode__SWIG_0(int jarg1, int jarg2, uint jarg3, ulong jarg4, uint jarg5, bool jarg6);

	public static extern int CSharp_PostCode__SWIG_1(int jarg1, int jarg2, uint jarg3, ulong jarg4, uint jarg5);

	public static extern int CSharp_PostCode__SWIG_2(int jarg1, int jarg2, uint jarg3, ulong jarg4);

	public static extern int CSharp_PostCode__SWIG_3(int jarg1, int jarg2, uint jarg3);

	public static extern int CSharp_PostCode__SWIG_4(int jarg1, int jarg2);

	public static extern int CSharp_PostString__SWIG_0(string jarg1, int jarg2, uint jarg3, ulong jarg4, uint jarg5, bool jarg6);

	public static extern int CSharp_PostString__SWIG_1(string jarg1, int jarg2, uint jarg3, ulong jarg4, uint jarg5);

	public static extern int CSharp_PostString__SWIG_2(string jarg1, int jarg2, uint jarg3, ulong jarg4);

	public static extern int CSharp_PostString__SWIG_3(string jarg1, int jarg2, uint jarg3);

	public static extern int CSharp_PostString__SWIG_4(string jarg1, int jarg2);

	public static extern int CSharp_GetTimeStamp();

	public static extern uint CSharp_GetNumNonZeroBits(uint jarg1);

	public static extern void CSharp_AkGetDefaultHighPriorityThreadProperties(IntPtr jarg1);

	public static extern uint CSharp_ResolveDialogueEvent__SWIG_0(uint jarg1, [In] uint[] jarg2, uint jarg3, uint jarg4);

	public static extern uint CSharp_ResolveDialogueEvent__SWIG_1(uint jarg1, [In] uint[] jarg2, uint jarg3);

	public static extern int CSharp_GetDialogueEventCustomPropertyValue__SWIG_0(uint jarg1, uint jarg2, out int jarg3);

	public static extern int CSharp_GetDialogueEventCustomPropertyValue__SWIG_1(uint jarg1, uint jarg2, out float jarg3);

	public static extern void CSharp_AkPositioningInfo_fCenterPct_set(IntPtr jarg1, float jarg2);

	public static extern float CSharp_AkPositioningInfo_fCenterPct_get(IntPtr jarg1);

	public static extern void CSharp_AkPositioningInfo_pannerType_set(IntPtr jarg1, int jarg2);

	public static extern int CSharp_AkPositioningInfo_pannerType_get(IntPtr jarg1);

	public static extern void CSharp_AkPositioningInfo_e3dPositioningType_set(IntPtr jarg1, int jarg2);

	public static extern int CSharp_AkPositioningInfo_e3dPositioningType_get(IntPtr jarg1);

	public static extern void CSharp_AkPositioningInfo_bHoldEmitterPosAndOrient_set(IntPtr jarg1, bool jarg2);

	public static extern bool CSharp_AkPositioningInfo_bHoldEmitterPosAndOrient_get(IntPtr jarg1);

	public static extern void CSharp_AkPositioningInfo_e3DSpatializationMode_set(IntPtr jarg1, int jarg2);

	public static extern int CSharp_AkPositioningInfo_e3DSpatializationMode_get(IntPtr jarg1);

	public static extern void CSharp_AkPositioningInfo_bEnableAttenuation_set(IntPtr jarg1, bool jarg2);

	public static extern bool CSharp_AkPositioningInfo_bEnableAttenuation_get(IntPtr jarg1);

	public static extern void CSharp_AkPositioningInfo_bUseConeAttenuation_set(IntPtr jarg1, bool jarg2);

	public static extern bool CSharp_AkPositioningInfo_bUseConeAttenuation_get(IntPtr jarg1);

	public static extern void CSharp_AkPositioningInfo_fInnerAngle_set(IntPtr jarg1, float jarg2);

	public static extern float CSharp_AkPositioningInfo_fInnerAngle_get(IntPtr jarg1);

	public static extern void CSharp_AkPositioningInfo_fOuterAngle_set(IntPtr jarg1, float jarg2);

	public static extern float CSharp_AkPositioningInfo_fOuterAngle_get(IntPtr jarg1);

	public static extern void CSharp_AkPositioningInfo_fConeMaxAttenuation_set(IntPtr jarg1, float jarg2);

	public static extern float CSharp_AkPositioningInfo_fConeMaxAttenuation_get(IntPtr jarg1);

	public static extern void CSharp_AkPositioningInfo_LPFCone_set(IntPtr jarg1, float jarg2);

	public static extern float CSharp_AkPositioningInfo_LPFCone_get(IntPtr jarg1);

	public static extern void CSharp_AkPositioningInfo_HPFCone_set(IntPtr jarg1, float jarg2);

	public static extern float CSharp_AkPositioningInfo_HPFCone_get(IntPtr jarg1);

	public static extern void CSharp_AkPositioningInfo_fMaxDistance_set(IntPtr jarg1, float jarg2);

	public static extern float CSharp_AkPositioningInfo_fMaxDistance_get(IntPtr jarg1);

	public static extern void CSharp_AkPositioningInfo_fVolDryAtMaxDist_set(IntPtr jarg1, float jarg2);

	public static extern float CSharp_AkPositioningInfo_fVolDryAtMaxDist_get(IntPtr jarg1);

	public static extern void CSharp_AkPositioningInfo_fVolAuxGameDefAtMaxDist_set(IntPtr jarg1, float jarg2);

	public static extern float CSharp_AkPositioningInfo_fVolAuxGameDefAtMaxDist_get(IntPtr jarg1);

	public static extern void CSharp_AkPositioningInfo_fVolAuxUserDefAtMaxDist_set(IntPtr jarg1, float jarg2);

	public static extern float CSharp_AkPositioningInfo_fVolAuxUserDefAtMaxDist_get(IntPtr jarg1);

	public static extern void CSharp_AkPositioningInfo_LPFValueAtMaxDist_set(IntPtr jarg1, float jarg2);

	public static extern float CSharp_AkPositioningInfo_LPFValueAtMaxDist_get(IntPtr jarg1);

	public static extern void CSharp_AkPositioningInfo_HPFValueAtMaxDist_set(IntPtr jarg1, float jarg2);

	public static extern float CSharp_AkPositioningInfo_HPFValueAtMaxDist_get(IntPtr jarg1);

	public static extern IntPtr CSharp_new_AkPositioningInfo();

	public static extern void CSharp_delete_AkPositioningInfo(IntPtr jarg1);

	public static extern void CSharp_AkObjectInfo_objID_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkObjectInfo_objID_get(IntPtr jarg1);

	public static extern void CSharp_AkObjectInfo_parentID_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkObjectInfo_parentID_get(IntPtr jarg1);

	public static extern void CSharp_AkObjectInfo_iDepth_set(IntPtr jarg1, int jarg2);

	public static extern int CSharp_AkObjectInfo_iDepth_get(IntPtr jarg1);

	public static extern void CSharp_AkObjectInfo_Clear(IntPtr jarg1);

	public static extern int CSharp_AkObjectInfo_GetSizeOf();

	public static extern void CSharp_AkObjectInfo_Clone(IntPtr jarg1, IntPtr jarg2);

	public static extern IntPtr CSharp_new_AkObjectInfo();

	public static extern void CSharp_delete_AkObjectInfo(IntPtr jarg1);

	public static extern int CSharp_GetPosition(ulong jarg1, IntPtr jarg2);

	public static extern int CSharp_GetListenerPosition(ulong jarg1, IntPtr jarg2);

	public static extern int CSharp_GetRTPCValue__SWIG_0(uint jarg1, ulong jarg2, uint jarg3, out float jarg4, ref int jarg5);

	public static extern int CSharp_GetRTPCValue__SWIG_1(string jarg1, ulong jarg2, uint jarg3, out float jarg4, ref int jarg5);

	public static extern int CSharp_GetSwitch__SWIG_0(uint jarg1, ulong jarg2, out uint jarg3);

	public static extern int CSharp_GetSwitch__SWIG_1(string jarg1, ulong jarg2, out uint jarg3);

	public static extern int CSharp_GetState__SWIG_0(uint jarg1, out uint jarg2);

	public static extern int CSharp_GetState__SWIG_1(string jarg1, out uint jarg2);

	public static extern int CSharp_GetGameObjectAuxSendValues(ulong jarg1, IntPtr jarg2, ref uint jarg3);

	public static extern int CSharp_GetGameObjectDryLevelValue(ulong jarg1, ulong jarg2, out float jarg3);

	public static extern int CSharp_GetObjectObstructionAndOcclusion(ulong jarg1, ulong jarg2, out float jarg3, out float jarg4);

	public static extern int CSharp_QueryAudioObjectIDs__SWIG_0(uint jarg1, ref uint jarg2, IntPtr jarg3);

	public static extern int CSharp_QueryAudioObjectIDs__SWIG_1(string jarg1, ref uint jarg2, IntPtr jarg3);

	public static extern int CSharp_GetPositioningInfo(uint jarg1, IntPtr jarg2);

	public static extern bool CSharp_GetIsGameObjectActive(ulong jarg1);

	public static extern float CSharp_GetMaxRadius(ulong jarg1);

	public static extern uint CSharp_GetEventIDFromPlayingID(uint jarg1);

	public static extern ulong CSharp_GetGameObjectFromPlayingID(uint jarg1);

	public static extern int CSharp_GetPlayingIDsFromGameObject(ulong jarg1, ref uint jarg2, [Out] uint[] jarg3);

	public static extern int CSharp_GetCustomPropertyValue__SWIG_0(uint jarg1, uint jarg2, out int jarg3);

	public static extern int CSharp_GetCustomPropertyValue__SWIG_1(uint jarg1, uint jarg2, out float jarg3);

	public static extern void CSharp_AK_SPEAKER_SETUP_FIX_LEFT_TO_CENTER(ref uint jarg1);

	public static extern void CSharp_AK_SPEAKER_SETUP_FIX_REAR_TO_SIDE(ref uint jarg1);

	public static extern void CSharp_AK_SPEAKER_SETUP_CONVERT_TO_SUPPORTED(ref uint jarg1);

	public static extern byte CSharp_ChannelMaskToNumChannels(uint jarg1);

	public static extern uint CSharp_ChannelMaskFromNumChannels(uint jarg1);

	public static extern byte CSharp_ChannelBitToIndex(uint jarg1, uint jarg2);

	public static extern bool CSharp_HasSurroundChannels(uint jarg1);

	public static extern bool CSharp_HasStrictlyOnePairOfSurroundChannels(uint jarg1);

	public static extern bool CSharp_HasSideAndRearChannels(uint jarg1);

	public static extern bool CSharp_HasHeightChannels(uint jarg1);

	public static extern uint CSharp_BackToSideChannels(uint jarg1);

	public static extern uint CSharp_StdChannelIndexToDisplayIndex(int jarg1, uint jarg2, uint jarg3);

	public static extern void CSharp_AkChannelConfig_uNumChannels_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkChannelConfig_uNumChannels_get(IntPtr jarg1);

	public static extern void CSharp_AkChannelConfig_eConfigType_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkChannelConfig_eConfigType_get(IntPtr jarg1);

	public static extern void CSharp_AkChannelConfig_uChannelMask_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkChannelConfig_uChannelMask_get(IntPtr jarg1);

	public static extern IntPtr CSharp_new_AkChannelConfig__SWIG_0();

	public static extern IntPtr CSharp_new_AkChannelConfig__SWIG_1(uint jarg1, uint jarg2);

	public static extern void CSharp_AkChannelConfig_Clear(IntPtr jarg1);

	public static extern void CSharp_AkChannelConfig_SetStandard(IntPtr jarg1, uint jarg2);

	public static extern void CSharp_AkChannelConfig_SetStandardOrAnonymous(IntPtr jarg1, uint jarg2, uint jarg3);

	public static extern void CSharp_AkChannelConfig_SetAnonymous(IntPtr jarg1, uint jarg2);

	public static extern void CSharp_AkChannelConfig_SetAmbisonic(IntPtr jarg1, uint jarg2);

	public static extern bool CSharp_AkChannelConfig_IsValid(IntPtr jarg1);

	public static extern uint CSharp_AkChannelConfig_Serialize(IntPtr jarg1);

	public static extern void CSharp_AkChannelConfig_Deserialize(IntPtr jarg1, uint jarg2);

	public static extern IntPtr CSharp_AkChannelConfig_RemoveLFE(IntPtr jarg1);

	public static extern IntPtr CSharp_AkChannelConfig_RemoveCenter(IntPtr jarg1);

	public static extern bool CSharp_AkChannelConfig_IsChannelConfigSupported(IntPtr jarg1);

	public static extern void CSharp_delete_AkChannelConfig(IntPtr jarg1);

	public static extern IntPtr CSharp_new_AkImageSourceParams__SWIG_0();

	public static extern IntPtr CSharp_new_AkImageSourceParams__SWIG_1(Vector3 jarg1, float jarg2, float jarg3);

	public static extern void CSharp_AkImageSourceParams_sourcePosition_set(IntPtr jarg1, Vector3 jarg2);

	public static extern Vector3 CSharp_AkImageSourceParams_sourcePosition_get(IntPtr jarg1);

	public static extern void CSharp_AkImageSourceParams_fDistanceScalingFactor_set(IntPtr jarg1, float jarg2);

	public static extern float CSharp_AkImageSourceParams_fDistanceScalingFactor_get(IntPtr jarg1);

	public static extern void CSharp_AkImageSourceParams_fLevel_set(IntPtr jarg1, float jarg2);

	public static extern float CSharp_AkImageSourceParams_fLevel_get(IntPtr jarg1);

	public static extern void CSharp_AkImageSourceParams_fDiffraction_set(IntPtr jarg1, float jarg2);

	public static extern float CSharp_AkImageSourceParams_fDiffraction_get(IntPtr jarg1);

	public static extern void CSharp_AkImageSourceParams_uDiffractionEmitterSide_set(IntPtr jarg1, byte jarg2);

	public static extern byte CSharp_AkImageSourceParams_uDiffractionEmitterSide_get(IntPtr jarg1);

	public static extern void CSharp_AkImageSourceParams_uDiffractionListenerSide_set(IntPtr jarg1, byte jarg2);

	public static extern byte CSharp_AkImageSourceParams_uDiffractionListenerSide_get(IntPtr jarg1);

	public static extern void CSharp_delete_AkImageSourceParams(IntPtr jarg1);

	public static extern float CSharp_kDefaultMaxPathLength_get();

	public static extern uint CSharp_kDefaultDiffractionMaxEdges_get();

	public static extern uint CSharp_kDefaultDiffractionMaxPaths_get();

	public static extern float CSharp_kMaxDiffraction_get();

	public static extern uint CSharp_kDiffractionMaxEdges_get();

	public static extern uint CSharp_kDiffractionMaxPaths_get();

	public static extern uint CSharp_kPortalToPortalDiffractionMaxPaths_get();

	public static extern IntPtr CSharp_new_AkSpatialAudioInitSettings();

	public static extern void CSharp_AkSpatialAudioInitSettings_uMaxSoundPropagationDepth_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkSpatialAudioInitSettings_uMaxSoundPropagationDepth_get(IntPtr jarg1);

	public static extern void CSharp_AkSpatialAudioInitSettings_uDiffractionFlags_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkSpatialAudioInitSettings_uDiffractionFlags_get(IntPtr jarg1);

	public static extern void CSharp_AkSpatialAudioInitSettings_fDiffractionShadowAttenFactor_set(IntPtr jarg1, float jarg2);

	public static extern float CSharp_AkSpatialAudioInitSettings_fDiffractionShadowAttenFactor_get(IntPtr jarg1);

	public static extern void CSharp_AkSpatialAudioInitSettings_fDiffractionShadowDegrees_set(IntPtr jarg1, float jarg2);

	public static extern float CSharp_AkSpatialAudioInitSettings_fDiffractionShadowDegrees_get(IntPtr jarg1);

	public static extern void CSharp_AkSpatialAudioInitSettings_fMovementThreshold_set(IntPtr jarg1, float jarg2);

	public static extern float CSharp_AkSpatialAudioInitSettings_fMovementThreshold_get(IntPtr jarg1);

	public static extern void CSharp_AkSpatialAudioInitSettings_uNumberOfPrimaryRays_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkSpatialAudioInitSettings_uNumberOfPrimaryRays_get(IntPtr jarg1);

	public static extern void CSharp_AkSpatialAudioInitSettings_uMaxReflectionOrder_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkSpatialAudioInitSettings_uMaxReflectionOrder_get(IntPtr jarg1);

	public static extern void CSharp_AkSpatialAudioInitSettings_fMaxPathLength_set(IntPtr jarg1, float jarg2);

	public static extern float CSharp_AkSpatialAudioInitSettings_fMaxPathLength_get(IntPtr jarg1);

	public static extern void CSharp_AkSpatialAudioInitSettings_bEnableDiffractionOnReflection_set(IntPtr jarg1, bool jarg2);

	public static extern bool CSharp_AkSpatialAudioInitSettings_bEnableDiffractionOnReflection_get(IntPtr jarg1);

	public static extern void CSharp_AkSpatialAudioInitSettings_bEnableDirectPathDiffraction_set(IntPtr jarg1, bool jarg2);

	public static extern bool CSharp_AkSpatialAudioInitSettings_bEnableDirectPathDiffraction_get(IntPtr jarg1);

	public static extern void CSharp_AkSpatialAudioInitSettings_bEnableTransmission_set(IntPtr jarg1, bool jarg2);

	public static extern bool CSharp_AkSpatialAudioInitSettings_bEnableTransmission_get(IntPtr jarg1);

	public static extern void CSharp_delete_AkSpatialAudioInitSettings(IntPtr jarg1);

	public static extern IntPtr CSharp_new_AkImageSourceSettings__SWIG_0();

	public static extern IntPtr CSharp_new_AkImageSourceSettings__SWIG_1(Vector3 jarg1, float jarg2, float jarg3);

	public static extern void CSharp_delete_AkImageSourceSettings(IntPtr jarg1);

	public static extern void CSharp_AkImageSourceSettings_SetOneTexture(IntPtr jarg1, uint jarg2);

	public static extern void CSharp_AkImageSourceSettings_SetName(IntPtr jarg1, string jarg2);

	public static extern void CSharp_AkImageSourceSettings_params__set(IntPtr jarg1, IntPtr jarg2);

	public static extern IntPtr CSharp_AkImageSourceSettings_params__get(IntPtr jarg1);

	public static extern IntPtr CSharp_new_AkTriangle__SWIG_0();

	public static extern IntPtr CSharp_new_AkTriangle__SWIG_1(ushort jarg1, ushort jarg2, ushort jarg3, ushort jarg4);

	public static extern void CSharp_AkTriangle_point0_set(IntPtr jarg1, ushort jarg2);

	public static extern ushort CSharp_AkTriangle_point0_get(IntPtr jarg1);

	public static extern void CSharp_AkTriangle_point1_set(IntPtr jarg1, ushort jarg2);

	public static extern ushort CSharp_AkTriangle_point1_get(IntPtr jarg1);

	public static extern void CSharp_AkTriangle_point2_set(IntPtr jarg1, ushort jarg2);

	public static extern ushort CSharp_AkTriangle_point2_get(IntPtr jarg1);

	public static extern void CSharp_AkTriangle_surface_set(IntPtr jarg1, ushort jarg2);

	public static extern ushort CSharp_AkTriangle_surface_get(IntPtr jarg1);

	public static extern void CSharp_AkTriangle_Clear(IntPtr jarg1);

	public static extern int CSharp_AkTriangle_GetSizeOf();

	public static extern void CSharp_AkTriangle_Clone(IntPtr jarg1, IntPtr jarg2);

	public static extern void CSharp_delete_AkTriangle(IntPtr jarg1);

	public static extern IntPtr CSharp_new_AkAcousticSurface();

	public static extern void CSharp_AkAcousticSurface_textureID_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkAcousticSurface_textureID_get(IntPtr jarg1);

	public static extern void CSharp_AkAcousticSurface_occlusion_set(IntPtr jarg1, float jarg2);

	public static extern float CSharp_AkAcousticSurface_occlusion_get(IntPtr jarg1);

	public static extern void CSharp_AkAcousticSurface_strName_set(IntPtr jarg1, string jarg2);

	public static extern IntPtr CSharp_AkAcousticSurface_strName_get(IntPtr jarg1);

	public static extern void CSharp_AkAcousticSurface_Clear(IntPtr jarg1);

	public static extern void CSharp_AkAcousticSurface_DeleteName(IntPtr jarg1);

	public static extern int CSharp_AkAcousticSurface_GetSizeOf();

	public static extern void CSharp_AkAcousticSurface_Clone(IntPtr jarg1, IntPtr jarg2);

	public static extern void CSharp_delete_AkAcousticSurface(IntPtr jarg1);

	public static extern void CSharp_AkReflectionPathInfo_imageSource_set(IntPtr jarg1, Vector3 jarg2);

	public static extern Vector3 CSharp_AkReflectionPathInfo_imageSource_get(IntPtr jarg1);

	public static extern void CSharp_AkReflectionPathInfo_numPathPoints_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkReflectionPathInfo_numPathPoints_get(IntPtr jarg1);

	public static extern void CSharp_AkReflectionPathInfo_numReflections_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkReflectionPathInfo_numReflections_get(IntPtr jarg1);

	public static extern void CSharp_AkReflectionPathInfo_level_set(IntPtr jarg1, float jarg2);

	public static extern float CSharp_AkReflectionPathInfo_level_get(IntPtr jarg1);

	public static extern void CSharp_AkReflectionPathInfo_isOccluded_set(IntPtr jarg1, bool jarg2);

	public static extern bool CSharp_AkReflectionPathInfo_isOccluded_get(IntPtr jarg1);

	public static extern int CSharp_AkReflectionPathInfo_GetSizeOf();

	public static extern Vector3 CSharp_AkReflectionPathInfo_GetPathPoint(IntPtr jarg1, uint jarg2);

	public static extern IntPtr CSharp_AkReflectionPathInfo_GetAcousticSurface(IntPtr jarg1, uint jarg2);

	public static extern float CSharp_AkReflectionPathInfo_GetDiffraction(IntPtr jarg1, uint jarg2);

	public static extern void CSharp_AkReflectionPathInfo_Clone(IntPtr jarg1, IntPtr jarg2);

	public static extern IntPtr CSharp_new_AkReflectionPathInfo();

	public static extern void CSharp_delete_AkReflectionPathInfo(IntPtr jarg1);

	public static extern void CSharp_AkDiffractionPathInfo_virtualPos_set(IntPtr jarg1, IntPtr jarg2);

	public static extern IntPtr CSharp_AkDiffractionPathInfo_virtualPos_get(IntPtr jarg1);

	public static extern void CSharp_AkDiffractionPathInfo_nodeCount_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkDiffractionPathInfo_nodeCount_get(IntPtr jarg1);

	public static extern void CSharp_AkDiffractionPathInfo_diffraction_set(IntPtr jarg1, float jarg2);

	public static extern float CSharp_AkDiffractionPathInfo_diffraction_get(IntPtr jarg1);

	public static extern void CSharp_AkDiffractionPathInfo_totLength_set(IntPtr jarg1, float jarg2);

	public static extern float CSharp_AkDiffractionPathInfo_totLength_get(IntPtr jarg1);

	public static extern void CSharp_AkDiffractionPathInfo_obstructionValue_set(IntPtr jarg1, float jarg2);

	public static extern float CSharp_AkDiffractionPathInfo_obstructionValue_get(IntPtr jarg1);

	public static extern int CSharp_AkDiffractionPathInfo_GetSizeOf();

	public static extern Vector3 CSharp_AkDiffractionPathInfo_GetNodes(IntPtr jarg1, uint jarg2);

	public static extern float CSharp_AkDiffractionPathInfo_GetAngles(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkDiffractionPathInfo_GetPortals(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkDiffractionPathInfo_GetRooms(IntPtr jarg1, uint jarg2);

	public static extern void CSharp_AkDiffractionPathInfo_Clone(IntPtr jarg1, IntPtr jarg2);

	public static extern IntPtr CSharp_new_AkDiffractionPathInfo();

	public static extern void CSharp_delete_AkDiffractionPathInfo(IntPtr jarg1);

	public static extern IntPtr CSharp_new_AkRoomParams();

	public static extern void CSharp_AkRoomParams_Up_set(IntPtr jarg1, Vector3 jarg2);

	public static extern Vector3 CSharp_AkRoomParams_Up_get(IntPtr jarg1);

	public static extern void CSharp_AkRoomParams_Front_set(IntPtr jarg1, Vector3 jarg2);

	public static extern Vector3 CSharp_AkRoomParams_Front_get(IntPtr jarg1);

	public static extern void CSharp_AkRoomParams_ReverbAuxBus_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkRoomParams_ReverbAuxBus_get(IntPtr jarg1);

	public static extern void CSharp_AkRoomParams_ReverbLevel_set(IntPtr jarg1, float jarg2);

	public static extern float CSharp_AkRoomParams_ReverbLevel_get(IntPtr jarg1);

	public static extern void CSharp_AkRoomParams_WallOcclusion_set(IntPtr jarg1, float jarg2);

	public static extern float CSharp_AkRoomParams_WallOcclusion_get(IntPtr jarg1);

	public static extern void CSharp_AkRoomParams_RoomGameObj_AuxSendLevelToSelf_set(IntPtr jarg1, float jarg2);

	public static extern float CSharp_AkRoomParams_RoomGameObj_AuxSendLevelToSelf_get(IntPtr jarg1);

	public static extern void CSharp_AkRoomParams_RoomGameObj_KeepRegistered_set(IntPtr jarg1, bool jarg2);

	public static extern bool CSharp_AkRoomParams_RoomGameObj_KeepRegistered_get(IntPtr jarg1);

	public static extern void CSharp_delete_AkRoomParams(IntPtr jarg1);

	public static extern int CSharp_SetImageSource(uint jarg1, IntPtr jarg2, uint jarg3, ulong jarg4, ulong jarg5);

	public static extern int CSharp_RemoveImageSource(uint jarg1, uint jarg2, ulong jarg3);

	public static extern int CSharp_ClearImageSources__SWIG_0(uint jarg1, ulong jarg2);

	public static extern int CSharp_ClearImageSources__SWIG_1(uint jarg1);

	public static extern int CSharp_ClearImageSources__SWIG_2();

	public static extern int CSharp_RemoveGeometry(ulong jarg1);

	public static extern int CSharp_QueryReflectionPaths(ulong jarg1, ref Vector3 jarg2, ref Vector3 jarg3, IntPtr jarg4, out uint jarg5);

	public static extern int CSharp_RemoveRoom(ulong jarg1);

	public static extern int CSharp_RemovePortal(ulong jarg1);

	public static extern int CSharp_SetGameObjectInRoom(ulong jarg1, ulong jarg2);

	public static extern int CSharp_SetReflectionsOrder(uint jarg1, bool jarg2);

	public static extern int CSharp_SetNumberOfPrimaryRays(uint jarg1);

	public static extern int CSharp_SetEarlyReflectionsAuxSend(ulong jarg1, uint jarg2);

	public static extern int CSharp_SetEarlyReflectionsVolume(ulong jarg1, float jarg2);

	public static extern int CSharp_SetPortalObstructionAndOcclusion(ulong jarg1, float jarg2, float jarg3);

	public static extern int CSharp_QueryWetDiffraction(ulong jarg1, out float jarg2);

	public static extern int CSharp_QueryDiffractionPaths(ulong jarg1, ref Vector3 jarg2, ref Vector3 jarg3, IntPtr jarg4, out uint jarg5);

	public static extern void CSharp_AkPlatformInitSettings_threadLEngine_set(IntPtr jarg1, IntPtr jarg2);

	public static extern IntPtr CSharp_AkPlatformInitSettings_threadLEngine_get(IntPtr jarg1);

	public static extern void CSharp_AkPlatformInitSettings_threadOutputMgr_set(IntPtr jarg1, IntPtr jarg2);

	public static extern IntPtr CSharp_AkPlatformInitSettings_threadOutputMgr_get(IntPtr jarg1);

	public static extern void CSharp_AkPlatformInitSettings_threadBankManager_set(IntPtr jarg1, IntPtr jarg2);

	public static extern IntPtr CSharp_AkPlatformInitSettings_threadBankManager_get(IntPtr jarg1);

	public static extern void CSharp_AkPlatformInitSettings_threadMonitor_set(IntPtr jarg1, IntPtr jarg2);

	public static extern IntPtr CSharp_AkPlatformInitSettings_threadMonitor_get(IntPtr jarg1);

	public static extern void CSharp_AkPlatformInitSettings_threadOpusDecoder_set(IntPtr jarg1, IntPtr jarg2);

	public static extern IntPtr CSharp_AkPlatformInitSettings_threadOpusDecoder_get(IntPtr jarg1);

	public static extern void CSharp_AkPlatformInitSettings_uSampleRate_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkPlatformInitSettings_uSampleRate_get(IntPtr jarg1);

	public static extern void CSharp_AkPlatformInitSettings_uNumRefillsInVoice_set(IntPtr jarg1, ushort jarg2);

	public static extern ushort CSharp_AkPlatformInitSettings_uNumRefillsInVoice_get(IntPtr jarg1);

	public static extern void CSharp_AkPlatformInitSettings_bAutoPanningRule_set(IntPtr jarg1, bool jarg2);

	public static extern bool CSharp_AkPlatformInitSettings_bAutoPanningRule_get(IntPtr jarg1);

	public static extern void CSharp_delete_AkPlatformInitSettings(IntPtr jarg1);

	public static extern void CSharp_delete_AkStreamMgrSettings(IntPtr jarg1);

	public static extern void CSharp_AkDeviceSettings_pIOMemory_set(IntPtr jarg1, IntPtr jarg2);

	public static extern IntPtr CSharp_AkDeviceSettings_pIOMemory_get(IntPtr jarg1);

	public static extern void CSharp_AkDeviceSettings_uIOMemorySize_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkDeviceSettings_uIOMemorySize_get(IntPtr jarg1);

	public static extern void CSharp_AkDeviceSettings_uIOMemoryAlignment_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkDeviceSettings_uIOMemoryAlignment_get(IntPtr jarg1);

	public static extern void CSharp_AkDeviceSettings_ePoolAttributes_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkDeviceSettings_ePoolAttributes_get(IntPtr jarg1);

	public static extern void CSharp_AkDeviceSettings_uGranularity_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkDeviceSettings_uGranularity_get(IntPtr jarg1);

	public static extern void CSharp_AkDeviceSettings_uSchedulerTypeFlags_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkDeviceSettings_uSchedulerTypeFlags_get(IntPtr jarg1);

	public static extern void CSharp_AkDeviceSettings_threadProperties_set(IntPtr jarg1, IntPtr jarg2);

	public static extern IntPtr CSharp_AkDeviceSettings_threadProperties_get(IntPtr jarg1);

	public static extern void CSharp_AkDeviceSettings_fTargetAutoStmBufferLength_set(IntPtr jarg1, float jarg2);

	public static extern float CSharp_AkDeviceSettings_fTargetAutoStmBufferLength_get(IntPtr jarg1);

	public static extern void CSharp_AkDeviceSettings_uMaxConcurrentIO_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkDeviceSettings_uMaxConcurrentIO_get(IntPtr jarg1);

	public static extern void CSharp_AkDeviceSettings_bUseStreamCache_set(IntPtr jarg1, bool jarg2);

	public static extern bool CSharp_AkDeviceSettings_bUseStreamCache_get(IntPtr jarg1);

	public static extern void CSharp_AkDeviceSettings_uMaxCachePinnedBytes_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkDeviceSettings_uMaxCachePinnedBytes_get(IntPtr jarg1);

	public static extern void CSharp_delete_AkDeviceSettings(IntPtr jarg1);

	public static extern void CSharp_AkThreadProperties_nPriority_set(IntPtr jarg1, int jarg2);

	public static extern int CSharp_AkThreadProperties_nPriority_get(IntPtr jarg1);

	public static extern void CSharp_AkThreadProperties_uStackSize_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkThreadProperties_uStackSize_get(IntPtr jarg1);

	public static extern void CSharp_AkThreadProperties_iIdealCore_set(IntPtr jarg1, int jarg2);

	public static extern int CSharp_AkThreadProperties_iIdealCore_get(IntPtr jarg1);

	public static extern void CSharp_AkThreadProperties_affinityMask_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkThreadProperties_affinityMask_get(IntPtr jarg1);

	public static extern IntPtr CSharp_new_AkThreadProperties();

	public static extern void CSharp_delete_AkThreadProperties(IntPtr jarg1);

	public static extern void CSharp_SetErrorLogger__SWIG_0(AkLogger.ErrorLoggerInteropDelegate jarg1);

	public static extern void CSharp_SetErrorLogger__SWIG_1();

	public static extern void CSharp_SetAudioInputCallbacks(AkAudioInputManager.AudioSamplesInteropDelegate jarg1, AkAudioInputManager.AudioFormatInteropDelegate jarg2);

	public static extern void CSharp_delete_AkUnityPlatformSpecificSettings(IntPtr jarg1);

	public static extern IntPtr CSharp_new_AkCommunicationSettings();

	public static extern void CSharp_AkCommunicationSettings_commsThreadProperties_set(IntPtr jarg1, IntPtr jarg2);

	public static extern IntPtr CSharp_AkCommunicationSettings_commsThreadProperties_get(IntPtr jarg1);

	public static extern void CSharp_AkCommunicationSettings_uPoolSize_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkCommunicationSettings_uPoolSize_get(IntPtr jarg1);

	public static extern void CSharp_AkCommunicationSettings_uDiscoveryBroadcastPort_set(IntPtr jarg1, ushort jarg2);

	public static extern ushort CSharp_AkCommunicationSettings_uDiscoveryBroadcastPort_get(IntPtr jarg1);

	public static extern void CSharp_AkCommunicationSettings_uCommandPort_set(IntPtr jarg1, ushort jarg2);

	public static extern ushort CSharp_AkCommunicationSettings_uCommandPort_get(IntPtr jarg1);

	public static extern void CSharp_AkCommunicationSettings_uNotificationPort_set(IntPtr jarg1, ushort jarg2);

	public static extern ushort CSharp_AkCommunicationSettings_uNotificationPort_get(IntPtr jarg1);

	public static extern void CSharp_AkCommunicationSettings_bInitSystemLib_set(IntPtr jarg1, bool jarg2);

	public static extern bool CSharp_AkCommunicationSettings_bInitSystemLib_get(IntPtr jarg1);

	public static extern void CSharp_AkCommunicationSettings_szAppNetworkName_set(IntPtr jarg1, string jarg2);

	public static extern IntPtr CSharp_AkCommunicationSettings_szAppNetworkName_get(IntPtr jarg1);

	public static extern void CSharp_delete_AkCommunicationSettings(IntPtr jarg1);

	public static extern IntPtr CSharp_new_AkInitializationSettings();

	public static extern void CSharp_delete_AkInitializationSettings(IntPtr jarg1);

	public static extern void CSharp_AkInitializationSettings_streamMgrSettings_set(IntPtr jarg1, IntPtr jarg2);

	public static extern IntPtr CSharp_AkInitializationSettings_streamMgrSettings_get(IntPtr jarg1);

	public static extern void CSharp_AkInitializationSettings_deviceSettings_set(IntPtr jarg1, IntPtr jarg2);

	public static extern IntPtr CSharp_AkInitializationSettings_deviceSettings_get(IntPtr jarg1);

	public static extern void CSharp_AkInitializationSettings_initSettings_set(IntPtr jarg1, IntPtr jarg2);

	public static extern IntPtr CSharp_AkInitializationSettings_initSettings_get(IntPtr jarg1);

	public static extern void CSharp_AkInitializationSettings_platformSettings_set(IntPtr jarg1, IntPtr jarg2);

	public static extern IntPtr CSharp_AkInitializationSettings_platformSettings_get(IntPtr jarg1);

	public static extern void CSharp_AkInitializationSettings_musicSettings_set(IntPtr jarg1, IntPtr jarg2);

	public static extern IntPtr CSharp_AkInitializationSettings_musicSettings_get(IntPtr jarg1);

	public static extern void CSharp_AkInitializationSettings_unityPlatformSpecificSettings_set(IntPtr jarg1, IntPtr jarg2);

	public static extern IntPtr CSharp_AkInitializationSettings_unityPlatformSpecificSettings_get(IntPtr jarg1);

	public static extern void CSharp_AkInitializationSettings_useAsyncOpen_set(IntPtr jarg1, bool jarg2);

	public static extern bool CSharp_AkInitializationSettings_useAsyncOpen_get(IntPtr jarg1);

	public static extern IntPtr CSharp_new_AkExternalSourceInfo__SWIG_0();

	public static extern void CSharp_delete_AkExternalSourceInfo(IntPtr jarg1);

	public static extern IntPtr CSharp_new_AkExternalSourceInfo__SWIG_1(IntPtr jarg1, uint jarg2, uint jarg3, uint jarg4);

	public static extern IntPtr CSharp_new_AkExternalSourceInfo__SWIG_2(string jarg1, uint jarg2, uint jarg3);

	public static extern IntPtr CSharp_new_AkExternalSourceInfo__SWIG_3(uint jarg1, uint jarg2, uint jarg3);

	public static extern void CSharp_AkExternalSourceInfo_Clear(IntPtr jarg1);

	public static extern void CSharp_AkExternalSourceInfo_Clone(IntPtr jarg1, IntPtr jarg2);

	public static extern int CSharp_AkExternalSourceInfo_GetSizeOf();

	public static extern void CSharp_AkExternalSourceInfo_iExternalSrcCookie_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkExternalSourceInfo_iExternalSrcCookie_get(IntPtr jarg1);

	public static extern void CSharp_AkExternalSourceInfo_idCodec_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkExternalSourceInfo_idCodec_get(IntPtr jarg1);

	public static extern void CSharp_AkExternalSourceInfo_szFile_set(IntPtr jarg1, string jarg2);

	public static extern IntPtr CSharp_AkExternalSourceInfo_szFile_get(IntPtr jarg1);

	public static extern void CSharp_AkExternalSourceInfo_pInMemory_set(IntPtr jarg1, IntPtr jarg2);

	public static extern IntPtr CSharp_AkExternalSourceInfo_pInMemory_get(IntPtr jarg1);

	public static extern void CSharp_AkExternalSourceInfo_uiMemorySize_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkExternalSourceInfo_uiMemorySize_get(IntPtr jarg1);

	public static extern void CSharp_AkExternalSourceInfo_idFile_set(IntPtr jarg1, uint jarg2);

	public static extern uint CSharp_AkExternalSourceInfo_idFile_get(IntPtr jarg1);

	public static extern int CSharp_Init(IntPtr jarg1);

	public static extern int CSharp_InitSpatialAudio(IntPtr jarg1);

	public static extern int CSharp_InitCommunication(IntPtr jarg1);

	public static extern void CSharp_Term();

	public static extern int CSharp_RegisterGameObjInternal(ulong jarg1);

	public static extern int CSharp_UnregisterGameObjInternal(ulong jarg1);

	public static extern int CSharp_RegisterGameObjInternal_WithName(ulong jarg1, string jarg2);

	public static extern int CSharp_SetBasePath(string jarg1);

	public static extern int CSharp_SetCurrentLanguage(string jarg1);

	public static extern int CSharp_LoadFilePackage(string jarg1, out uint jarg2);

	public static extern int CSharp_AddBasePath(string jarg1);

	public static extern int CSharp_SetGameName(string jarg1);

	public static extern int CSharp_SetDecodedBankPath(string jarg1);

	public static extern int CSharp_LoadAndDecodeBank(string jarg1, bool jarg2, out uint jarg3);

	public static extern int CSharp_LoadAndDecodeBankFromMemory(IntPtr jarg1, uint jarg2, bool jarg3, string jarg4, bool jarg5, out uint jarg6);

	public static extern uint CSharp_PostEventOnRoom__SWIG_0(string jarg1, ulong jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5, uint jarg6, IntPtr jarg7, uint jarg8);

	public static extern uint CSharp_PostEventOnRoom__SWIG_1(string jarg1, ulong jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5, uint jarg6, IntPtr jarg7);

	public static extern uint CSharp_PostEventOnRoom__SWIG_2(string jarg1, ulong jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5);

	public static extern uint CSharp_PostEventOnRoom__SWIG_3(string jarg1, ulong jarg2);

	public static extern IntPtr CSharp_GetCurrentLanguage();

	public static extern int CSharp_UnloadFilePackage(uint jarg1);

	public static extern int CSharp_UnloadAllFilePackages();

	public static extern int CSharp_SetObjectPosition(ulong jarg1, Vector3 jarg2, Vector3 jarg3, Vector3 jarg4);

	public static extern int CSharp_GetSourceMultiplePlayPositions__SWIG_0(uint jarg1, [Out] uint[] jarg2, [Out] uint[] jarg3, [Out] int[] jarg4, ref uint jarg5, bool jarg6);

	public static extern int CSharp_GetSourceMultiplePlayPositions__SWIG_1(uint jarg1, [Out] uint[] jarg2, [Out] uint[] jarg3, [Out] int[] jarg4, ref uint jarg5);

	public static extern int CSharp_SetListeners(ulong jarg1, ulong[] jarg2, uint jarg3);

	public static extern int CSharp_SetDefaultListeners(ulong[] jarg1, uint jarg2);

	public static extern int CSharp_AddOutput__SWIG_0(IntPtr jarg1, out ulong jarg2, ulong[] jarg3, uint jarg4);

	public static extern int CSharp_AddOutput__SWIG_1(IntPtr jarg1, out ulong jarg2, ulong[] jarg3);

	public static extern int CSharp_AddOutput__SWIG_2(IntPtr jarg1, out ulong jarg2);

	public static extern int CSharp_AddOutput__SWIG_3(IntPtr jarg1);

	public static extern void CSharp_GetDefaultStreamSettings(IntPtr jarg1);

	public static extern void CSharp_GetDefaultDeviceSettings(IntPtr jarg1);

	public static extern void CSharp_GetDefaultMusicSettings(IntPtr jarg1);

	public static extern void CSharp_GetDefaultInitSettings(IntPtr jarg1);

	public static extern void CSharp_GetDefaultPlatformInitSettings(IntPtr jarg1);

	public static extern uint CSharp_GetMajorMinorVersion();

	public static extern uint CSharp_GetSubminorBuildVersion();

	public static extern void CSharp_StartResourceMonitoring();

	public static extern void CSharp_StopResourceMonitoring();

	public static extern void CSharp_GetResourceMonitorDataSummary(IntPtr jarg1);

	public static extern int CSharp_SetRoomPortal(ulong jarg1, IntPtr jarg2, Vector3 jarg3, bool jarg4, ulong jarg5, ulong jarg6);

	public static extern int CSharp_SetRoom(ulong jarg1, IntPtr jarg2, string jarg3);

	public static extern int CSharp_RegisterSpatialAudioListener(ulong jarg1);

	public static extern int CSharp_UnregisterSpatialAudioListener(ulong jarg1);

	public static extern int CSharp_SetGeometry(ulong jarg1, IntPtr jarg2, uint jarg3, Vector3[] jarg4, uint jarg5, IntPtr jarg6, uint jarg7, ulong jarg8, bool jarg9, bool jarg10);

	public static extern uint CSharp_PostEventOnRoom__SWIG_4(uint jarg1, ulong jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5, uint jarg6, IntPtr jarg7, uint jarg8);

	public static extern uint CSharp_PostEventOnRoom__SWIG_5(uint jarg1, ulong jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5, uint jarg6, IntPtr jarg7);

	public static extern uint CSharp_PostEventOnRoom__SWIG_6(uint jarg1, ulong jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5);

	public static extern uint CSharp_PostEventOnRoom__SWIG_7(uint jarg1, ulong jarg2);

	public static extern IntPtr CSharp_AkPlaylist_SWIGUpcast(IntPtr jarg1);

	public static extern IntPtr CSharp_AkMIDIPost_SWIGUpcast(IntPtr jarg1);

	public static extern IntPtr CSharp_AkEventCallbackInfo_SWIGUpcast(IntPtr jarg1);

	public static extern IntPtr CSharp_AkMIDIEventCallbackInfo_SWIGUpcast(IntPtr jarg1);

	public static extern IntPtr CSharp_AkMarkerCallbackInfo_SWIGUpcast(IntPtr jarg1);

	public static extern IntPtr CSharp_AkDurationCallbackInfo_SWIGUpcast(IntPtr jarg1);

	public static extern IntPtr CSharp_AkDynamicSequenceItemCallbackInfo_SWIGUpcast(IntPtr jarg1);

	public static extern IntPtr CSharp_AkMusicSyncCallbackInfo_SWIGUpcast(IntPtr jarg1);

	public static extern IntPtr CSharp_AkMusicPlaylistCallbackInfo_SWIGUpcast(IntPtr jarg1);
}
