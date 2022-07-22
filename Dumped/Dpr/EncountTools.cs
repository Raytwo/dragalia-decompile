using System.Collections;
using System.Runtime.InteropServices;
using AttributeData;
using DPData;
using Dpr.BallDeco;
using Dpr.Battle.Logic;
using Dpr.Trainer;
using INL1;
using Pml;
using Pml.PokePara;

namespace Dpr;

public static class EncountTools
{
	public enum CommRule
	{
		Single,
		Double,
		Multi,
		Mix
	}

	private static bool m_isIgnorePokeReflectAfterBattle;

	public static PokeParty CreateSimpleParty(MonsNo monsNo0, int level0, MonsNo monsNo1 = MonsNo.NULL, int level1 = 1, [Optional] PokeParty party, ushort sex = 255, ushort seikaku = ushort.MaxValue, ushort sex1 = 255, ushort seikaku1 = ushort.MaxValue, ushort form0 = 0, ushort form1 = 0, byte talentVNum = 0)
	{
		return null;
	}

	public static ItemNo SetWildPokemonItem(PokemonParam pp, int itemRnd, int rnd1 = 50, int rnd2 = 5)
	{
		return default(ItemNo);
	}

	public static void SetupBattleWild(BATTLE_SETUP_PARAM battleSetupParam, PokeParty iPtrEnemyParty, ArenaID arenaID, MapAttributeEx mapAttrib, SYS_WEATHER weatherType, bool isSwim = false, bool isFishing = false, TrainerID partnerID = TrainerID.NONE, bool isCaptureDemo = false, int safariBallNum = -1, bool isSymbol = false, bool isMitu = false, [Optional] string overlapBgm, BattleSetupEffectId overlapSetupEffectId = BattleSetupEffectId.DEFAULT, bool isCantUseBall = false)
	{
	}

	private static bool IsUseSetupEffectVariation(PokeParty party)
	{
		return default(bool);
	}

	public static void SetupBattleTrainer(BATTLE_SETUP_PARAM battleSetupParam, ArenaID arenaID, MapAttributeEx mapAttrib, SYS_WEATHER weatherType, BtlRule rule, TrainerID enemyID0, TrainerID enemyID1 = TrainerID.NONE, TrainerID partnerID = TrainerID.NONE)
	{
	}

	public static void SetupBattleTowerTrainer(BATTLE_SETUP_PARAM battleSetupParam, PokeParty playerParty, BtlRule rule, ArenaID arenaID, SYS_WEATHER weatherType, TowerTrID enemy1, PokeParty enemy1Party, SealTemplateID[] enemy1SealTIDs, TowerTrID enemy2 = TowerTrID.NONE, [Optional] PokeParty enemy2Party, [Optional] SealTemplateID[] enemy2SealTIDs, [Optional] TowerLotResult lotResult)
	{
	}

	public static void SetupBattleTowerTrainer(BATTLE_SETUP_PARAM battleSetupParam, PokeParty playerParty, TowerLotResult lot, ArenaID arenaID, SYS_WEATHER weatherType, [Optional] TowerLotResult lotResult)
	{
	}

	public static void GetTrainerExParams(TrainerID enemyID0, TrainerID enemyID1, TrainerID partnerId, BtlRule rule, out ArenaID trainerArenaID, out BattleSetupEffectId trainerSetupEffectId, out EffectBattleID trainerEffectBattleId)
	{
	}

	public static void SetWeather(BTL_FIELD_SITUATION situation, SYS_WEATHER weatherType)
	{
	}

	public static void OnPostBattle(BATTLE_SETUP_PARAM bsp, PokeParty iPtrPlayerParty, out int outEvolveCheckTargetIndices, out IEnumerator outDispError)
	{
	}

	public static void OnPostRegisterZukan(PokemonParam capturePokemonParam, int throwBallCount)
	{
	}

	private static int GetPokemonParamIndex(PokeParty party, PokemonParam org)
	{
		return default(int);
	}

	private static void SetTrainerWinFlag(BATTLE_SETUP_PARAM bsp)
	{
	}

	private static void ReflectTokuseiMonohiroiMitsuatsume(PokeParty pMyParty)
	{
	}

	private static bool isEvolveCheckTarget(PokeParty playerParty, byte memberIdx, BtlResult result, bool isLevelUp)
	{
		return default(bool);
	}

	public static void GetAttEff(MapAttributeEx mapAttributeEx, ArenaID arenaID, BattleSetupEffectLot lot, out BattleSetupEffectId setupEffectId, out EffectBattleID effectBattleID, out string soundEventNama)
	{
	}

	public static BattleSetupEffectLot GetBattleSetupEffectLot(BtlRule rule, BtlCompetitor competitor = BtlCompetitor.BTL_COMPETITOR_WILD, BtlMultiMode multiMode = BtlMultiMode.BTL_MULTIMODE_NONE, TrainerID trainerID0 = TrainerID.MAX, TrainerID trainerID1 = TrainerID.MAX)
	{
		return default(BattleSetupEffectLot);
	}

	public static TrainerID GetDemoCaptureTrainer(bool isPlayerMale, DefaultPokeType defaultPokeType)
	{
		return default(TrainerID);
	}

	public static PokeParty CreateDemoCapturePokeParty(TrainerID trainerID)
	{
		return null;
	}

	private static ItemNo GetMonohiroiItem(uint level)
	{
		return default(ItemNo);
	}

	public static PokemonParam CreateFixPokeParam(MonsNo monsNo, ushort level, uint hp, ushort sex, ushort seikaku, Sick sick, ulong random, byte talentVNum)
	{
		return null;
	}

	private static bool IsLegendPoke(MonsNo monsNo)
	{
		return default(bool);
	}

	private static bool IsRecoverFromPartner(BATTLE_SETUP_PARAM bsp)
	{
		return default(bool);
	}

	public static void SetupBattleComm(BATTLE_SETUP_PARAM bsp, IlcaNetSessionNetworkType networkType, CommRule commRule, byte commPos, [In] ref Regulation.Data regulation, int stationIndex0, PokeParty party0, [In] ref MYSTATUS_COMM mystatus0, CapsuleData[] capsuleDatas0, int stationIndex1, PokeParty party1, [In] ref MYSTATUS_COMM mystatus1, CapsuleData[] capsuleDatas1, int stationIndex2 = -1, [Optional] PokeParty party2, [Optional][In] ref MYSTATUS_COMM mystatus2, [Optional] CapsuleData[] capsuleDatas2, int stationIndex3 = -1, [Optional] PokeParty party3, [Optional][In] ref MYSTATUS_COMM mystatus3, [Optional] CapsuleData[] capsuleDatas3, [Optional] string bgm, [Optional] string winBgm, uint GameLimitSec = 1200u, uint CommandLimitSec = 60u)
	{
	}

	private static void setupPlayerInfo(BATTLE_SETUP_PARAM bsp, int index, int stationIndex, PokeParty party, [In] ref MYSTATUS_COMM mystatus, CapsuleData[] capsuledata)
	{
	}

	public static IEnumerator DispErrorCoroutine(int commError, bool isDisplayedError)
	{
		return null;
	}
}
