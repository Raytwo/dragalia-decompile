using System.Runtime.CompilerServices;

public class AkBasePathGetter
{
	public static readonly string DefaultBasePath;

	private static bool LogWarnings_Internal;

	private const string DecodedBankFolder = "DecodedBanks";

	public static bool LogWarnings
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public static string SoundBankBasePath
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public static string PersistentDataPath
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public static string DecodedBankFullPath
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	private static void GetCustomPlatformName(ref string platformName)
	{
	}

	public static string GetPlatformName()
	{
		return null;
	}

	public static string GetPlatformBasePath()
	{
		return null;
	}

	public static void EvaluateGamePaths()
	{
	}
}
