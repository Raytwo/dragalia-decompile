using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Effect;
using Pml;
using SmartPoint.AssetAssistant;
using UnityEngine;
using XLSXContent;

namespace Dpr.UnderGround.LightStone;

public class LightStoneManager : SingletonMonoBehaviour<LightStoneManager>
{
	private enum UgZoneID
	{
		NONE,
		UGA,
		UGB,
		UGC,
		UGD,
		UGE,
		UGF
	}

	[SerializeField]
	private LightStoneTable bonusTable;

	[SerializeField]
	private LightStonePosTable posTable;

	[SerializeField]
	private GameObject lightStonePrefab;

	[SerializeField]
	private float pokemonDigRange;

	[SerializeField]
	private float lightStoneGetRange;

	[SerializeField]
	private Vector3 getEffectOffset;

	[SerializeField]
	private float smallEffectScale;

	[SerializeField]
	private float largeEffectScale;

	[SerializeField]
	private float getEffectScale;

	private Dictionary<ZoneID, LightStonePosTable.SheetData> tableData;

	private Dictionary<UgZoneID, LightStoneTable.SheetData> bonusTableData;

	private List<LightStone> allDigletList;

	private List<LightStone> allDugtrioList;

	private List<LightStone> activeLightStoneList;

	private List<LightStone> deleteList;

	private EffectData lightStoneSmallEfData;

	private EffectData lightStoneLargeEfData;

	private EffectData smokeEfData;

	private EffectData lightStoneGetEfData;

	private bool isBonus;

	private static Dictionary<UgZoneID, List<ZoneID>> UgZoneList;

	public bool IsBonusTime => default(bool);

	public int LightStoneCount => default(int);

	public int LightStoneMaxNum => default(int);

	public int LightStoneCountMine
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public EffectData LightStoneSmallEfData => null;

	public EffectData LightStoneLargeEfData => null;

	public EffectData SmokeEfData => null;

	public float SmallEffectScale => default(float);

	public float LargeEffectScale => default(float);

	public float PokemonDigRange => default(float);

	public float LightStoneGetRange => default(float);

	public static int BonusTimeMax => default(int);

	public static IEnumerator GetBonusTimeMax(Action<int> onLoad)
	{
		return null;
	}

	public static void StartBonusTime()
	{
	}

	private IEnumerator Start()
	{
		return null;
	}

	private void OnDestroy()
	{
	}

	public void AddLightStone(int num)
	{
	}

	public int GetBonusTimeMinuteMax()
	{
		return default(int);
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private void UpdateLightStone(float deltaTime)
	{
	}

	private void Setup()
	{
	}

	private void RestartEffect()
	{
	}

	private LightStone ActiveLightStone(Vector2Int gridPos, MonsNo monsNo)
	{
		return null;
	}

	public void StartBonus()
	{
	}

	private void SaveReport()
	{
	}

	private void ResetLightStone()
	{
	}

	private void Clear()
	{
	}

	private LightStone SpawnLightStone(MonsNo monsNo)
	{
		return null;
	}

	private List<Vector2Int> LotteryPosiiton(ZoneID zoneID)
	{
		return null;
	}

	private MonsNo LotteryMonsNo(ZoneID zoneID)
	{
		return default(MonsNo);
	}

	private UgZoneID GetUgZoneID(ZoneID zoneID)
	{
		return default(UgZoneID);
	}
}
