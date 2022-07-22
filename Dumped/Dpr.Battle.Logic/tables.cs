using Pml;
using Pml.WazaData;

namespace Dpr.Battle.Logic;

public static class tables
{
	private static readonly ushort[] IsMatchEncoreFailTable;

	private static readonly ushort[] IsSakidoriFailWazaTable;

	private static readonly ushort[] IsDelayAttackWazaTbl;

	private static readonly ushort[] IsZWaza_GeneralTable;

	private static readonly ushort[] IsZWaza_SpecialTable;

	private static readonly ushort[] IsGWazaTable;

	private static readonly ushort[] IsGWaza_GeneralTable;

	private static readonly ushort[] IsPressureEffectiveWazaTable;

	private static readonly ushort[] IsGuardTypeSideEffectTable;

	private static readonly ushort[] IsCombiWazaTable;

	private static readonly ushort[] Pri_6;

	private static readonly ushort[] Pri_5;

	private static readonly ushort[] Pri_4;

	private static readonly ushort[] Pri_3;

	private static readonly ushort[] Pri_2;

	private static readonly ushort[] Pri_1;

	private static readonly ushort[][] GetAIItemPriorityTable;

	private static readonly ushort[] CheckItemCallNoEffectTable;

	private static readonly ushort[] IsNoTargetItemTable;

	private static readonly ushort[] IsRotoponItemTable;

	private static readonly ushort[] IsKodawariItemTable;

	private static readonly ushort[] CheckNakamaDukuriFailTokuseiTable;

	private static readonly ushort[] CheckSkillSwapFailTokuseiTable;

	private static readonly ushort[] IsNeverChangeTokuseiTable;

	private static readonly ushort[] IsMatchAruseusPlateTable;

	private static readonly ushort[] IsMatchGuripusu2ChipTable;

	private static readonly ushort[] IsMatchInsectaCasetteTable;

	private static readonly ushort[] IsMatchKatayaburiTargetTable;

	private static readonly ushort[] CheckOmmitAfterHensinTable;

	private static readonly ushort[] CheckOmmitOnGTable;

	private static readonly ushort[] IsTypeChangeForbidPokeTable;

	private static readonly ushort[] IsEffectDisableTypeTable;

	private static readonly ushort[] IsCourtChangeSwapSideEffectTable;

	private static readonly WazaSick[] MentalSickTbl;

	private static readonly WazaSick[] GetTurnCheckWazaSickByOrderTable;

	private static readonly ushort[] checkHaseiOmmitCommonTable;

	private static readonly ushort[] IsNegotoOmmitTable;

	private static readonly ushort[] IsNekoNoteOmmitTable;

	private static readonly ushort[] IsManekkoOmmitTable;

	private static readonly ushort[] IsMatchMonomaneFailTable;

	private static readonly ushort[] IsSaihaiOmmitTable;

	private static readonly ushort[] IsBoujinGuardWazaTable;

	private static readonly ushort[] IsAgoBoostWazaTable;

	private static readonly ushort[] IsBoudanWazaTable;

	private static readonly ushort[] IsDaiWallGuardDisableTable;

	private static readonly ushort[] IsOyakoaiOmitWazaTable;

	private static readonly ushort[] IsNotDisplayUiAffinityTable;

	private static readonly ushort[] IsTikarazukuEffeciveWazaTable;

	private static readonly ushort[] IsKiriBaraiEnable_AttackerSideTable;

	private static readonly ushort[] IsKiriBaraiEnable_DefenderSideTable;

	public static bool IsInclude(ServerCommand value, ServerCommand[] table)
	{
		return default(bool);
	}

	public static bool checkTableElems(ushort value, ushort[] table)
	{
		return default(bool);
	}

	public static bool IsMatchEncoreFail(WazaNo waza)
	{
		return default(bool);
	}

	public static bool IsSakidoriFailWaza(WazaNo waza)
	{
		return default(bool);
	}

	public static bool IsDelayAttackWaza(WazaNo waza)
	{
		return default(bool);
	}

	public static bool IsZWaza(WazaNo waza)
	{
		return default(bool);
	}

	public static bool IsZWaza_General(WazaNo waza)
	{
		return default(bool);
	}

	public static bool IsZWaza_Special(WazaNo waza)
	{
		return default(bool);
	}

	public static bool IsGWaza(WazaNo waza)
	{
		return default(bool);
	}

	public static bool IsGWaza_General(WazaNo waza)
	{
		return default(bool);
	}

	public static bool IsPressureEffectiveWaza(WazaNo waza)
	{
		return default(bool);
	}

	public static bool IsGuardTypeSideEffect(BtlSideEffect eff)
	{
		return default(bool);
	}

	public static bool IsCombiWaza(WazaNo waza)
	{
		return default(bool);
	}

	public static uint GetAIItemPriority(ushort itemID)
	{
		return default(uint);
	}

	public static bool CheckItemCallNoEffect(ushort itemID)
	{
		return default(bool);
	}

	public static bool IsNoTargetItem(ushort itemID)
	{
		return default(bool);
	}

	public static bool IsRotoponItem(ushort itemID)
	{
		return default(bool);
	}

	public static bool IsKodawariItem(ushort itemID)
	{
		return default(bool);
	}

	public static bool CheckNarikiriFailTokusei(TokuseiNo tokuseiID)
	{
		return default(bool);
	}

	public static bool CheckReceiverFailTokusei(TokuseiNo tokuseiID)
	{
		return default(bool);
	}

	public static bool CheckNakamaDukuriFailTokusei(TokuseiNo tokuseiID)
	{
		return default(bool);
	}

	public static bool CheckTraceFailTokusei(TokuseiNo tokuseiID)
	{
		return default(bool);
	}

	public static bool CheckSkillSwapFailTokusei(TokuseiNo tokuseiID)
	{
		return default(bool);
	}

	public static bool IsNeverChangeTokusei(TokuseiNo tokuseiID)
	{
		return default(bool);
	}

	public static bool IsMatchAruseusPlate(ushort itemID)
	{
		return default(bool);
	}

	public static bool IsMatchGuripusu2Chip(ushort itemID)
	{
		return default(bool);
	}

	public static bool IsMatchInsectaCasette(ushort itemID)
	{
		return default(bool);
	}

	public static bool IsMatchKatayaburiTarget(TokuseiNo tokuseiID)
	{
		return default(bool);
	}

	public static bool CheckOmmitAfterHensin(TokuseiNo tokuseiID)
	{
		return default(bool);
	}

	public static bool CheckOmmitOnG(TokuseiNo tokuseiID)
	{
		return default(bool);
	}

	public static bool IsTypeChangeForbidPoke(ushort monsno)
	{
		return default(bool);
	}

	public static bool IsEffectDisableType(ushort effectNo)
	{
		return default(bool);
	}

	public static bool IsCourtChangeSwapSideEffect(BtlSideEffect effectNo)
	{
		return default(bool);
	}

	public static WazaSick GetMentalSickID(uint idx)
	{
		return default(WazaSick);
	}

	public static bool IsMentalSickID(WazaSick sickID)
	{
		return default(bool);
	}

	public static WazaSick GetTurnCheckWazaSickByOrder(uint idx)
	{
		return default(WazaSick);
	}

	public static bool checkHaseiOmmitCommon(WazaNo waza)
	{
		return default(bool);
	}

	public static bool IsNegotoOmmit(WazaNo waza)
	{
		return default(bool);
	}

	public static bool IsNekoNoteOmmit(WazaNo waza)
	{
		return default(bool);
	}

	public static bool IsManekkoOmmit(WazaNo waza)
	{
		return default(bool);
	}

	public static bool IsMatchMonomaneFail(WazaNo waza)
	{
		return default(bool);
	}

	public static bool IsSaihaiOmmit(WazaNo waza)
	{
		return default(bool);
	}

	public static ushort[] GetYubiFuruPermitTable()
	{
		return null;
	}

	public static bool IsYubiFuruPermit(WazaNo waza)
	{
		return default(bool);
	}

	public static bool IsBoujinGuardWaza(WazaNo waza)
	{
		return default(bool);
	}

	public static bool IsAgoBoostWaza(WazaNo waza)
	{
		return default(bool);
	}

	public static bool IsBoudanWaza(WazaNo waza)
	{
		return default(bool);
	}

	public static bool IsDaiWallGuardDisable(WazaNo waza)
	{
		return default(bool);
	}

	public static bool IsOyakoaiOmitWaza(WazaNo waza)
	{
		return default(bool);
	}

	public static bool IsNotDisplayUiAffinity(WazaNo waza)
	{
		return default(bool);
	}

	public static bool IsTikarazukuEffeciveWaza(WazaNo waza)
	{
		return default(bool);
	}

	public static bool IsKiriBaraiEnable_AttackerSide(BtlSideEffect effect)
	{
		return default(bool);
	}

	public static bool IsKiriBaraiEnable_DefenderSide(BtlSideEffect effect)
	{
		return default(bool);
	}
}
