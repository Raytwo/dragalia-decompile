using System;

[Serializable]
public class AkCommonAdvancedSettings
{
	[Serializable]
	public class SpatialAudioSettings
	{
		public float m_DiffractionShadowAttenuationFactor;

		public float m_DiffractionShadowDegrees;
	}

	public uint m_IOMemorySize;

	public float m_TargetAutoStreamBufferLengthMs;

	public bool m_UseStreamCache;

	public uint m_MaximumPinnedBytesInCache;

	public bool m_EnableGameSyncPreparation;

	public uint m_ContinuousPlaybackLookAhead;

	public uint m_MonitorQueuePoolSize;

	public uint m_MaximumHardwareTimeoutMs;

	public bool m_DebugOutOfRangeCheckEnabled;

	public float m_DebugOutOfRangeLimit;

	public SpatialAudioSettings m_SpatialAudioSettings;

	public bool m_RenderDuringFocusLoss;

	public string m_SoundBankPersistentDataPath;

	public bool m_UseAsyncOpen;

	public virtual void CopyTo(AkDeviceSettings settings)
	{
	}

	public virtual void CopyTo(AkInitSettings settings)
	{
	}

	public virtual void CopyTo(AkPlatformInitSettings settings)
	{
	}

	public virtual void CopyTo(AkSpatialAudioInitSettings settings)
	{
	}

	public virtual void CopyTo(AkUnityPlatformSpecificSettings settings)
	{
	}

	public virtual void Validate()
	{
	}
}
