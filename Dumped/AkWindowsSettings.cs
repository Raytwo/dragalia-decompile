using System;
using UnityEngine;

public class AkWindowsSettings : AkWwiseInitializationSettings.PlatformSettings
{
	[Serializable]
	public class PlatformAdvancedSettings : AkCommonAdvancedSettings
	{
		public enum AudioAPI
		{
			None = 0,
			Wasapi = 1,
			XAudio2 = 2,
			DirectSound = 4,
			Default = -1
		}

		public AudioAPI m_AudioAPI;

		public bool m_GlobalFocus;

		public override void CopyTo(AkPlatformInitSettings settings)
		{
		}
	}

	[HideInInspector]
	public AkCommonUserSettings UserSettings;

	[HideInInspector]
	public PlatformAdvancedSettings AdvancedSettings;

	[HideInInspector]
	public AkCommonCommSettings CommsSettings;

	protected override AkCommonUserSettings GetUserSettings()
	{
		return null;
	}

	protected override AkCommonAdvancedSettings GetAdvancedSettings()
	{
		return null;
	}

	protected override AkCommonCommSettings GetCommsSettings()
	{
		return null;
	}
}
