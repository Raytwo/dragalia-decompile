using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.U2D;
using XLSXContent;

namespace Dpr.Contest;

public class SceneResourceLoader
{
	private bool bLoading;

	public bool Loading => default(bool);

	public void Initialize()
	{
	}

	public void OnFinalize()
	{
	}

	public void UnloadAssetBundle()
	{
	}

	public void LoadScenePrefabs(string assetBundlePath, Transform parent, Action<string, GameObject> onCompleteLoad)
	{
	}

	public void LoadSpriteAtlas(string assetBundlePath, Action<SpriteAtlas> onCompleteLoad)
	{
	}

	public void LoadContestMasterDatas(string assetBundlePath, Action<UnityEngine.Object> onCompleteLoad)
	{
	}

	public void LoadNotesPatternData(string assetBundlePath, Action<NotesInfo> onCompleteLoad)
	{
	}

	public void LoadSprite(string path, Action<Sprite> onCompleteLoad, [Optional] string[] variants)
	{
	}

	public void LoadMigawariModel(Action onCompleteLoad)
	{
	}

	public void RequestLoadAsset()
	{
	}
}
