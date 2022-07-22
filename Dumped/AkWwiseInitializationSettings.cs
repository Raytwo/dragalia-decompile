using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AkWwiseInitializationSettings : AkCommonPlatformSettings
{
	public abstract class PlatformSettings : AkCommonPlatformSettings
	{
		[SerializeField]
		[HideInInspector]
		private List<string> IgnorePropertyNameList;

		[SerializeField]
		[HideInInspector]
		private List<string> GlobalPropertyNameList;

		private HashSet<string> _GlobalPropertyHashSet;

		public HashSet<string> GlobalPropertyHashSet
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void IgnorePropertyValue(string propertyPath)
		{
		}

		public bool IsPropertyIgnored(string propertyPath)
		{
			return default(bool);
		}

		public void SetUseGlobalPropertyValue(string propertyPath, bool use)
		{
		}

		public void SetGlobalPropertyValues(IEnumerable enumerable)
		{
		}

		private bool IsUsingGlobalPropertyValue(string propertyPath)
		{
			return default(bool);
		}
	}

	public class CommonPlatformSettings : PlatformSettings
	{
		[HideInInspector]
		public AkCommonUserSettings UserSettings;

		[HideInInspector]
		public AkCommonAdvancedSettings AdvancedSettings;

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

	[HideInInspector]
	public List<string> PlatformSettingsNameList;

	[HideInInspector]
	public List<PlatformSettings> PlatformSettingsList;

	[HideInInspector]
	public List<string> InvalidReferencePlatforms;

	[HideInInspector]
	public AkCommonUserSettings UserSettings;

	[HideInInspector]
	public AkCommonAdvancedSettings AdvancedSettings;

	[HideInInspector]
	public AkCommonCommSettings CommsSettings;

	private static readonly string[] AllGlobalValues;

	private static AkWwiseInitializationSettings m_Instance;

	private static AkBasePlatformSettings m_ActivePlatformSettings;

	public bool IsValid => default(bool);

	public int Count => default(int);

	public static AkWwiseInitializationSettings Instance => null;

	public static AkBasePlatformSettings ActivePlatformSettings => null;

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

	private static AkBasePlatformSettings GetPlatformSettings(string platformName)
	{
		return null;
	}

	private void OnEnable()
	{
	}

	public static bool InitializeSoundEngine()
	{
		return default(bool);
	}

	public static bool ResetSoundEngine(bool isPlaying)
	{
		return default(bool);
	}

	public static void TerminateSoundEngine()
	{
	}

	private static void SleepForMilliseconds(double milliseconds)
	{
	}
}
