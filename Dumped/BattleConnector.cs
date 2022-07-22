using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Dpr.Battle.Logic;
using Dpr.Battle.View.Objects;
using Pml.PokePara;
using SmartPoint.AssetAssistant;
using UnityEngine;
using XLSXContent;

public sealed class BattleConnector : SceneConnector
{
	private static AssetRequestOperation bgRequestOperatioin;

	private static AssetRequestOperation skyRequestOperatioin;

	private static List<AssetRequestOperation> prefetchAssetBundleList;

	public static bool isKeepSetup;

	private static ArenaInfo.SheetArenaData _currentArenaData;

	private static ArenaInfo.SheetArenaData _prevArenaData;

	private static GameObject _cachedBackgroundObject;

	private static GameObject _cachedSkyObject;

	private static BattleFieldObject _battleFieldObject;

	public static int arenaIndex
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public static ArenaInfo.SheetArenaData currentArenaData
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public GameObject cachedBackgroundObject => null;

	public GameObject cachedSkyObject => null;

	public static BattleFieldObject BattleFieldObject => null;

	public override bool SwitchingOperation(SceneID target)
	{
		return default(bool);
	}

	public override IEnumerator PrepareOperation()
	{
		return null;
	}

	public static void PrepareOperationStatic()
	{
	}

	public override IEnumerator SetupOperation()
	{
		return null;
	}

	private static void DestroyBackgrounds()
	{
	}

	private static void PrefetchAssetBundles(BATTLE_SETUP_PARAM bsp)
	{
	}

	private static void prefetchPlayer(MyStatus myStatus)
	{
	}

	private static void prefetchTrainer(BSP_TRAINER_DATA trainerData)
	{
	}

	private static void prefetchPoke(PokemonParam pp, [Optional] string forcedAssetBundleName)
	{
	}

	public static void ReleasePrefetchAssetBundles()
	{
	}

	private static void prefetchAssetBundleRequest(string path)
	{
	}

	private static bool isKeepWaitingPrefetchAssetBundles()
	{
		return default(bool);
	}
}
