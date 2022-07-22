using System.Runtime.CompilerServices;
using AttributeData;
using SmartPoint.AssetAssistant;
using UnityEngine;
using XLSXContent;

namespace Dpr.Battle.Logic;

public sealed class BattleDataTableManager
{
	private static BattleDataTableManager s_Instance;

	private static readonly string[] AB_NAMES;

	public static BattleDataTableManager Instance => null;

	public BattleDataTable BattleDataTable
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

	public BattleDefaultPlacementData BattleDefaultPlacementData
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

	public BattleWaitCameraData BattleWaitCameraData
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

	public BattleSetupEffectLots BattleSetupEffectLots
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

	public bool IsInitialized
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	private bool IsABAppended
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	private bool IsLoaded => default(bool);

	public bool AppendAssetBundleRequests()
	{
		return default(bool);
	}

	public bool OnDispatchRequests(RequestEventType eventType, string name, Object asset)
	{
		return default(bool);
	}

	public void OnAfterLoadAll()
	{
	}

	private static void OnAfterLoadAll_Update(float deltaTime)
	{
	}

	public static BattleSetupEffectLots.SheetArenaEffTable GetArenaEff(ArenaID arenaID)
	{
		return null;
	}

	public static BattleSetupEffectLots.SheetAttEffTable GetAttEff(MapAttributeEx mapAttributeEx, ArenaID arenaID)
	{
		return null;
	}

	public static BattleSetupEffectLots.SheetRuleEffTable GetRuleEff(BattleSetupEffectLot lot)
	{
		return null;
	}
}
