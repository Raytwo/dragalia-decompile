using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Dpr.FureaiHiroba;
using Dpr.Item;
using SmartPoint.AssetAssistant;
using UnityEngine;
using XLSXContent;

namespace Dpr.SubContents;

public class PoffinCookingSceneManager : SingletonMonoBehaviour<PoffinCookingSceneManager>
{
	private UnityEngine.Object PofinManagerPrefab;

	private const string Path_MasterData = "fureai/masterdata";

	private const string Path_UIPrefabs = "ui/prefab/pofinplayingui";

	private const string Path_CookPrefabs_Pot = "objects/ob1014_00";

	private const string Path_CookPrefabs_Poffin = "objects/ob1014_01";

	private const string Path_PoffinManagerPrefab = "poffin/prefabs";

	public UnityEngine.Object uiPofinPlaying;

	public UnityEngine.Object Cook_Pot;

	public UnityEngine.Object Cook_Pofin;

	private List<GameObject> PofinNonActives;

	private Vector3 playerPos;

	public List<PoffinResult.SheetSheet1> PofinData
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

	public List<PoffinNakayoshiScoreHosei.SheetSheet1> PofinNakayoshiScoreHoseiData
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

	private IEnumerator Start()
	{
		return null;
	}

	private void OnDestroy()
	{
	}

	public IEnumerator LoadMD()
	{
		return null;
	}

	public IEnumerator LoadPofinPrefab()
	{
		return null;
	}

	public IEnumerator CreatePofinManager(List<ItemInfo> kinomiList, Action OnComplete, [Optional] List<FureaiPokeModel> pokes)
	{
		return null;
	}

	public void SetActiveForPofin(bool isActive)
	{
	}

	private void SetActiveFureaiHiroba()
	{
	}

	private void SetActivePoffinHouse()
	{
	}
}
