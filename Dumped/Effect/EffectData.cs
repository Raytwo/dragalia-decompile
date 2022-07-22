using SmartPoint.AssetAssistant;
using UnityEngine;

namespace Effect;

public class EffectData : RefCounted
{
	private GameObject _prefab;

	private bool _isLooped;

	private string _assetBundleName;

	public GameObject prefab => null;

	public bool isLooped => default(bool);

	public string assetBundleName => null;

	public EffectData(string assetBundleName)
	{
	}

	public void Setup(GameObject prefab)
	{
	}

	public static bool ComputeIsLooped(GameObject prefab, out ParticleSystem baseParticleSystem)
	{
		return default(bool);
	}

	public override int Release()
	{
		return default(int);
	}
}
