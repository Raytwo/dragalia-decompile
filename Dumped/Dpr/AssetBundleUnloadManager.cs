using System.Collections.Generic;

namespace Dpr;

public static class AssetBundleUnloadManager
{
	private static HashSet<AssetBundleUnloader> _unloads;

	private static bool isInitialized;

	public static void Initialize()
	{
	}

	public static void Terminate()
	{
	}

	public static void RegisterUnload(AssetBundleUnloader unloader)
	{
	}

	public static void UnloadDirect(AssetBundleUnloader unloader)
	{
	}

	private static void OnLateUpdate(float deltaTime)
	{
	}
}
