using Dpr.Battle.Logic;
using Dpr.Trainer;
using Pml;
using Pml.PokePara;
using UnityEngine;
using XLSXContent;

namespace Dpr.Field;

public class FieldEncount
{
	public struct ENC_FLD_SPA
	{
		public TrainerID TrainerID;

		public bool SprayCheck;

		public bool EncCancelSpInvalid;

		public int SpMyLv;

		public bool Egg;

		public TokuseiNo Spa;

		public int[] FormProb;

		public int AnnoonTblType;
	}

	public struct SWAY_ENC_INFO
	{
		public int Table;

		public bool Decide;

		public bool Enc;
	}

	public const int GENE_ENC_1 = 0;

	public const int GENE_ENC_2 = 1;

	public const int TIME_ENC_1 = 2;

	public const int TIME_ENC_2 = 3;

	public const int SWAY_ENC_1 = 4;

	public const int SWAY_ENC_2 = 5;

	public const int SP_ENC_1 = 6;

	public const int SP_ENC_2 = 7;

	public const int AGB_ENC_1 = 8;

	public const int AGB_ENC_2 = 9;

	public const int SWAY_ENC_3 = 10;

	public const int SWAY_ENC_4 = 11;

	public const int ENC_MONS_NUM_NORMAL = 12;

	public const int ENC_MONS_NUM_GENERATE = 2;

	public const int ENC_MONS_NUM_NOON = 2;

	public const int ENC_MONS_NUM_NIGHT = 2;

	public const int ENC_MONS_NUM_SWAY_GRASS = 4;

	public const int ENC_FORM_PROB_NUM = 5;

	public const int ENC_MONS_NUM_AGB = 2;

	public const int ENC_MONS_NUM_SEA = 5;

	public const int ENC_MONS_NUM_ROCK = 5;

	public const int ENC_MONS_NUM_FISH = 5;

	public const int GROUND_ENCOUNT = 0;

	public const int WATER_ENCOUNT = 1;

	public const int FISHING_ENCOUNT = 2;

	private const int ENC_MONS_NUM_MAX = 12;

	private const int ROD_TYPE_NONE = 255;

	private const int WEATHER_NONE = 255;

	private const int CALC_SHIFT = 8;

	private const int DEBUG_MONITOR_TIME = 20;

	public static EncountResult FieldEncount_Check(FieldObjectEntity entity, bool inGridmove)
	{
		return null;
	}

	private static void EncountAttributeCheck(int attribute, FieldEncountTable.Sheettable data, out int enc_location, out uint prob)
	{
	}

	private static void GetEncountProbFishing(FishingRod inRodType, FieldEncountTable.Sheettable data, out uint prob)
	{
	}

	public static EncountResult SetFishingEncount(FishingRod inRodType, Vector2Int position)
	{
		return null;
	}

	public static EncountResult SetSweetEncount()
	{
		return null;
	}

	private static void ApplyDayTime(ref MonsLv[] enc_data, FieldEncountTable.Sheettable data)
	{
	}

	private static void ApplyAgbSlot(ref MonsLv[] enc_data, FieldEncountTable.Sheettable data)
	{
	}

	private static int GetMaxLvMonsTblNo(MonsLv[] inEncCommonData, ENC_FLD_SPA inFldSpa, int inTblNo)
	{
		return default(int);
	}

	private static void SetSpaStruct(PokemonParam inPokeParam, FieldEncountTable.Sheettable inData, ref ENC_FLD_SPA outSpa)
	{
	}

	private static uint ChangeEncProb(bool inIsFishing, uint inProb, ENC_FLD_SPA inFldSpa, SYS_WEATHER inWeatherCode, PokemonParam inPokeParam)
	{
		return default(uint);
	}

	private static bool CheckEcntCancelByLv(ENC_FLD_SPA inFldSpa, PokemonParam inMyPokeParam, int inEneLv)
	{
		return default(bool);
	}

	private static bool CheckSpray(int inEneLv, ref ENC_FLD_SPA inSpa)
	{
		return default(bool);
	}

	private static uint ChangeEncProbByEquipItem(PokemonParam inMyPokeParam, uint ioPer)
	{
		return default(uint);
	}

	private static bool WildEncSingle(PokemonParam poke_param, ref EncountResult param, FieldEncountTable.Sheettable data, MonsLv[] enc_data, ENC_FLD_SPA inFldSpa, SWAY_ENC_INFO inSwayEncInfo)
	{
		return default(bool);
	}

	private static bool WildEncDouble(PokemonParam poke_param, ref EncountResult param, MonsLv[] enc_data, ENC_FLD_SPA inFldSpa)
	{
		return default(bool);
	}

	private static bool WildWaterEncSingle(PokemonParam poke_param, ref EncountResult param, MonsLv[] enc_data, ENC_FLD_SPA inFldSpa)
	{
		return default(bool);
	}

	private static bool FishingEncSingle(PokemonParam poke_param, ref EncountResult battle_param, MonsLv[] inData, ENC_FLD_SPA inFldSpa, FishingRod inRodType)
	{
		return default(bool);
	}

	private static bool MapEncountCheck(uint per, int attr, bool inGridmove)
	{
		return default(bool);
	}

	private static bool EncountWalkCheck(float walkcnt, uint per)
	{
		return default(bool);
	}

	private static bool EncountCheckMain(uint per)
	{
		return default(bool);
	}

	private static int RandomPokeSet()
	{
		return default(int);
	}

	private static int RandomPokeSetNoGround()
	{
		return default(int);
	}

	private static int RandomPokeSetFishing(FishingRod inFishingRod)
	{
		return default(int);
	}

	private static bool SetEncountData(PokemonParam param, FishingRod inRodType, ENC_FLD_SPA inFldSpa, MonsLv[] inData, int location, BTL_CLIENT_ID inTarget, ref EncountResult outBattleParam)
	{
		return default(bool);
	}

	private static bool SetEncountDataDecideMons(MonsNo inMonsNo, uint inLv, BTL_CLIENT_ID inTarget, bool inRare, ENC_FLD_SPA inFldSpa, PokemonParam param, ref EncountResult outBattleParam)
	{
		return default(bool);
	}

	private static bool SetSwayEncountData(PokemonParam param, ENC_FLD_SPA inFldSpa, MonsLv[] inData, BTL_CLIENT_ID inTarget, ref EncountResult outBattleParam, MonsNo inMonsNo, uint inLv)
	{
		return default(bool);
	}

	private static bool CheckFixTypeEcnt(ENC_FLD_SPA inFldSpa, MonsLv[] inData, int inListNum, PokeType type, TokuseiNo tokusei, ref int outNo)
	{
		return default(bool);
	}

	private static bool FixPokeSet(MonsLv[] inData, int inListNum, PokeType type, ref int outNo)
	{
		return default(bool);
	}

	private static int SetEncountPokeLv(MonsLv inData, ENC_FLD_SPA inFldSpa)
	{
		return default(int);
	}

	private static void EncountParamSetRare(MonsNo poke, int lv, BTL_CLIENT_ID inTarget, ENC_FLD_SPA inFldSpa, PokemonParam inPokeParam, ref EncountResult outBattleParam)
	{
	}

	private static void EncountParamSet(MonsNo poke, int lv, BTL_CLIENT_ID inTarget, ENC_FLD_SPA inFldSpa, PokemonParam inPokeParam, ref EncountResult outBattleParam)
	{
	}

	private static void LastTokuseiCheck(ref EncountResult result, ref ENC_FLD_SPA spa)
	{
	}

	private static void LastProc(ref EncountResult result, ref ENC_FLD_SPA spa)
	{
	}

	private static void SetSfariMonster(bool inSafariFlg, bool inBookGet, ref MonsLv[] enc_data)
	{
	}

	public static MonsNo GetSafariScopeMonster(ZoneID zoneId)
	{
		return default(MonsNo);
	}

	private static void SafariEnc_SetSafariEnc(int inRandomSeed, bool inBookGet, ZoneID inZoneID, ref MonsLv[] outenc_data)
	{
	}

	private static int CheckMovePokeEnc()
	{
		return default(int);
	}

	public static bool IsTairyouHassei()
	{
		return default(bool);
	}

	public static int SafariRandomSeed()
	{
		return default(int);
	}
}
