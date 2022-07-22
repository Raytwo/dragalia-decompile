using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Dpr.Title;

public static class AssetPreloader
{
	private static List<string> _preloadRequestList;

	public static bool IsLoading
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public static IEnumerator PreloadAssetBundle()
	{
		return null;
	}

	public static IEnumerator LoadAssetBundle(string path)
	{
		return null;
	}

	public static void UnloadPreloadAssetBundle()
	{
	}
}
