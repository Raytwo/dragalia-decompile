using Pml;
using SmartPoint.AssetAssistant;
using UnityEngine;

public class FieldPokemonCenter
{
	private GameObject[] BallObjects;

	private AssetRequestOperation[] BallObjectLoads;

	public void Initialize()
	{
	}

	public void LoadTemotiBall()
	{
	}

	public bool IsLoadedTemotiBall()
	{
		return default(bool);
	}

	public void ReleaseAll()
	{
	}

	public GameObject GetBallObject(BallId ballId)
	{
		return null;
	}

	private void OnLoadedBallObject(int index, Object content)
	{
	}

	private BallId CheckBallId(BallId ballId)
	{
		return default(BallId);
	}
}
