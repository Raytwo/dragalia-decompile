using System;
using UnityEngine;
using UnityEngine.U2D;

namespace Dpr.GMS;

public class GMSResourceLoader
{
	private bool bIsLoading;

	public bool IsLoading => default(bool);

	public void UnloadAssetBundle()
	{
	}

	public void AppendLoadAsset(string assetBundlePath, Action<UnityEngine.Object> onCompleteLoad)
	{
	}

	public void AppendLoadGameObject(string assetBundlePath, Action<GameObject> onCompleteLoad)
	{
	}

	public void AppendLoadScenePrefabs(string assetBundlePath, Transform parent, Action<string, GameObject> onCompleteLoad)
	{
	}

	public void AppendLoadEarth(string path, Transform content, float earthRadius, Action<GameObject> onComplete)
	{
	}

	public void AppendLoadTexture2D(string path, Action<Texture2D> onComplete)
	{
	}

	public void AppendLoadTextureSprite(string path, Action<Sprite> onComplete)
	{
	}

	public void LoadSpriteAtlas(string assetBundlePath, Action<SpriteAtlas> onCompleteLoad)
	{
	}

	public void RequestLoadAsset()
	{
	}
}
