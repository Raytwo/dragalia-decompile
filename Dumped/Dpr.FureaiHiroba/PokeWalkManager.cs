using System.Collections.Generic;
using Dpr.Field.Walking;
using UnityEngine;

namespace Dpr.FureaiHiroba;

public class PokeWalkManager : MonoBehaviour
{
	public enum WalkMode
	{
		Line,
		Formation
	}

	[SerializeField]
	private FureaiDebugViewManager debugManager;

	private FureaiDataManager fureaiDataManager;

	private FormationData formationData;

	private List<FureaiPokeModel> pokeList;

	[SerializeField]
	private bool DrawDebugObjects;

	[SerializeField]
	private float basePokeSpeed;

	[SerializeField]
	private float baseOffsetScale;

	[SerializeField]
	private List<FureaiPokeModel> PokeWalkers;

	[SerializeField]
	private bool isLineFormation;

	[SerializeField]
	private Transform Player;

	[SerializeField]
	private int kyori;

	[SerializeField]
	private List<Vector3> Offsets;

	public void Init(FureaiDataManager mng, List<FureaiPokeModel> pokeList)
	{
	}

	public void MyUpdate(float deltaTime)
	{
	}

	public void OnWarp(WalkingCharacterModel model)
	{
	}

	public void AddPoke(FureaiPokeModel model)
	{
	}

	public void SubPoke(FureaiPokeModel model)
	{
	}

	public List<FureaiPokeModel> AllSubPoke(FureaiPokeModel model)
	{
		return null;
	}

	public FureaiPokeModel GetDelPoke()
	{
		return null;
	}

	public List<FureaiPokeModel> GetPokeWalkers()
	{
		return null;
	}

	private void OnValidate()
	{
	}
}
