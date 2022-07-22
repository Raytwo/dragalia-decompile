using System.Runtime.InteropServices;
using Dpr.Trainer;
using Pml;

namespace Dpr.Battle.Logic;

public static class Setup
{
	private static readonly byte[] maxFollowPokeLevelTbl;

	public static void BATTLE_SETUP_FIELD_SITUATION_Init(BTL_FIELD_SITUATION sit)
	{
	}

	public static void BATTLE_PARAM_SetBtlStatusFlag(BATTLE_SETUP_PARAM bp, BTL_STATUS_FLAG status_f)
	{
	}

	public static void BATTLE_PARAM_ResetBtlStatusFlag(BATTLE_SETUP_PARAM bp, BTL_STATUS_FLAG status_f)
	{
	}

	public static bool BATTLE_PARAM_CheckBtlStatusFlag(BATTLE_SETUP_PARAM bp, BTL_STATUS_FLAG status_f)
	{
		return default(bool);
	}

	private static void BATTLE_SETUP_Init(BATTLE_SETUP_PARAM bp)
	{
	}

	public static void BATTLE_SETUP_Clear(BATTLE_SETUP_PARAM bp)
	{
	}

	public static void BATTLE_SETUP_Wild(BATTLE_SETUP_PARAM bp, PokeParty playerParty, PokeParty partyEnemy, TrainerID partnerTrainerID, BTL_FIELD_SITUATION sit, BtlRule rule)
	{
	}

	public static void BATTLE_SETUP_Wild(BATTLE_SETUP_PARAM bp, PokeParty playerParty, PokeParty partyEnemy, BTL_FIELD_SITUATION sit, BtlRule rule)
	{
	}

	public static void BATTLE_SETUP_DemoCapture(BATTLE_SETUP_PARAM bp, PokeParty playerParty, PokeParty partyEnemy, TrainerID trainerID, BTL_FIELD_SITUATION sit)
	{
	}

	private static void setBoxFull(BATTLE_SETUP_PARAM pSetupParam)
	{
	}

	private static bool checkBoxFull()
	{
		return default(bool);
	}

	public static void BTL_SETUP_Trainer(BATTLE_SETUP_PARAM bp, PokeParty playerParty, TrainerID trID, BTL_FIELD_SITUATION sit, BtlRule rule)
	{
	}

	public static void BTL_SETUP_Trainer_Tag(BATTLE_SETUP_PARAM bp, [In] ref PokeParty playerParty, TrainerID trID_1, TrainerID trID_2, BTL_FIELD_SITUATION sit, BtlRule rule)
	{
	}

	public static void BTL_SETUP_Trainer_Multi(BATTLE_SETUP_PARAM bp, [In] ref PokeParty playerParty, TrainerID trID_friend, TrainerID trID_1, TrainerID trID_2, BTL_FIELD_SITUATION sit, BtlRule rule)
	{
	}

	public static void BATTLE_SETUP_Comm(BATTLE_SETUP_PARAM bp, [In] ref PokeParty playerParty, BTL_FIELD_SITUATION sit, BtlCommMode commMode, byte commPos)
	{
	}

	public static void BATTLE_SETUP_ToMultiMode(BATTLE_SETUP_PARAM bp)
	{
	}

	public static void BATTLE_SETUP_ToAIMultiMode(BATTLE_SETUP_PARAM bp, TrainerID trid_enemy1, TrainerID trid_enemy2, BtlCompetitor competitor)
	{
	}

	private static void setupParty(BATTLE_SETUP_PARAM pSetupParam, BTL_CLIENT_ID clientID, PokeParty pParty)
	{
	}

	public static void BATTLE_PARAM_SetTimeLimit(BATTLE_SETUP_PARAM bsp, uint GameLimitSec, uint ClientLimitSec, uint CommandLimitSec)
	{
	}

	public static void BATTLE_PARAM_SetSkyBattle(BATTLE_SETUP_PARAM bsp)
	{
	}

	public static void BATTLE_PARAM_SetSakasaBattle(BATTLE_SETUP_PARAM bsp)
	{
	}

	public static void BATTLE_PARAM_SetMustCaptureMode(BATTLE_SETUP_PARAM bsp)
	{
	}

	private static void BATTLE_PARAM_SetNoGainMode(BATTLE_SETUP_PARAM bsp)
	{
	}

	private static void BATTLE_PARAM_SetMoneyRate(BATTLE_SETUP_PARAM bsp, float rate)
	{
	}

	private static void BATTLE_PARAM_SetPokeParty(BATTLE_SETUP_PARAM bsp, PokeParty party, BTL_CLIENT_ID id)
	{
	}

	public static void BATTLE_PARAM_SetRegulation(BATTLE_SETUP_PARAM bsp, [In] ref Regulation.Data regulation)
	{
	}

	private static void BATTLE_PARAM_SetRatingValue(BATTLE_SETUP_PARAM bsp, ushort rate1, ushort rate2)
	{
	}

	public static void BATTLE_PARAM_AllocRecBuffer(BATTLE_SETUP_PARAM bsp)
	{
	}

	private static uint getBattleInstTrainerAIBit(BtlRule rule)
	{
		return default(uint);
	}

	public static void BTL_SETUP_BattleInst(BATTLE_SETUP_PARAM pSetupParam, PokeParty pPlayerParty, TowerTrID instTrainerEnemy1, PokeParty instEnemy1Party, SealTemplateID[] instEnemy1SealTIDs, TowerTrID instTrainerEnemy2, PokeParty instEnemy2Party, SealTemplateID[] instEnemy2SealTIDs, BTL_FIELD_SITUATION pFieldSituation, BtlRule rule)
	{
	}

	private static void BTL_SETUP_VoiceChatOn(BATTLE_SETUP_PARAM bp)
	{
	}

	private static void BATTLE_PARAM_AddWildPokemonAi(BATTLE_SETUP_PARAM pSetupParam, BtlAiScriptNo scriptNo)
	{
	}

	private static void common_base(BATTLE_SETUP_PARAM dst, BTL_FIELD_SITUATION sit)
	{
	}

	private static byte GetMaxFollowPokeLevel()
	{
		return default(byte);
	}

	private static byte GetCaptureLevelCap()
	{
		return default(byte);
	}

	private static byte GetExpLevelCap()
	{
		return default(byte);
	}

	private static void BATTLE_SETUP_PARAM_InitPartyParam(BATTLE_SETUP_PARAM setupParam)
	{
	}

	private static void player_param(BATTLE_SETUP_PARAM dst, PokeParty party)
	{
	}

	private static void clearEgg(PokeParty party)
	{
	}

	private static void player_balldeco(BATTLE_SETUP_PARAM dst, PokeParty party)
	{
	}

	public static void normalTrainer(BATTLE_SETUP_PARAM dst, BTL_CLIENT_ID clientID, TrainerID tr_id)
	{
	}

	public static void instTrainer(BATTLE_SETUP_PARAM dst, BTL_CLIENT_ID clientID, TowerTrID trainerID, PokeParty trainerParty, SealTemplateID[] sealTIDs, BtlRule rule)
	{
	}

	public static void settingByTrainerData(BATTLE_SETUP_PARAM bp, [In] ref BSP_TRAINER_DATA trData)
	{
	}
}
