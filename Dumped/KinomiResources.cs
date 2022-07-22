using SmartPoint.AssetAssistant;
using UnityEngine;

public class KinomiResources
{
	public enum CommonObjectType
	{
		WetSoil,
		MoriSoil,
		Seeding,
		Max
	}

	private static readonly string[] CommonAssetNames;

	private GameObject[] CommonObjects;

	private AssetRequestOperation[] CommonObjectLoads;

	private GameObject[] GrowedObjects;

	private AssetRequestOperation[] GrowedObjectLoads;

	private int LoadRequestCount;

	private int LoadedCount;

	public void LoadAll()
	{
	}

	public void ReleaseAll()
	{
	}

	private void OnLoadedCommonObject(int index, Object content)
	{
	}

	private void OnLoadedGrowedObject(int index, Object content)
	{
	}

	public bool IsValid()
	{
		return default(bool);
	}

	public GameObject GetCommonObject(CommonObjectType type)
	{
		return null;
	}

	public GameObject GetGrowedObject(int tagNo)
	{
		return null;
	}
}
