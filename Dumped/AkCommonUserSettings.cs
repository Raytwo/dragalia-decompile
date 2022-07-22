using System;

[Serializable]
public class AkCommonUserSettings
{
	[Serializable]
	public class SpatialAudioSettings
	{
		public enum DiffractionFlags
		{
			UseBuiltInParam = 1,
			UseObstruction = 2,
			CalcEmitterVirtualPosition = 8
		}

		public uint m_MaxSoundPropagationDepth;

		public DiffractionFlags m_DiffractionFlags;

		public float m_MovementThreshold;

		public uint m_NumberOfPrimaryRays;

		public uint m_MaxReflectionOrder;

		public float m_MaxPathLength;

		public bool m_EnableDiffractionOnReflections;

		public bool m_EnableDirectPathDiffraction;

		public bool m_EnableTransmission;
	}

	public string m_BasePath;

	public string m_StartupLanguage;

	public int m_CallbackManagerBufferSize;

	public bool m_EngineLogging;

	public uint m_MaximumNumberOfPositioningPaths;

	public uint m_CommandQueueSize;

	public uint m_SamplesPerFrame;

	public AkCommonOutputSettings m_MainOutputSettings;

	public float m_StreamingLookAheadRatio;

	public uint m_SampleRate;

	public ushort m_NumberOfRefillsInVoice;

	public SpatialAudioSettings m_SpatialAudioSettings;

	protected static string GetPluginPath()
	{
		return null;
	}

	public virtual void CopyTo(AkInitSettings settings)
	{
	}

	public void CopyTo(AkMusicSettings settings)
	{
	}

	public void CopyTo(AkStreamMgrSettings settings)
	{
	}

	public virtual void CopyTo(AkDeviceSettings settings)
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
