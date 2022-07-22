using System.Runtime.InteropServices;
using Pml;
using Pml.Battle;
using Pml.PokePara;
using Pml.WazaData;

namespace Dpr.Battle.Logic;

public sealed class ServerCommandPutter
{
	public class SetupParam
	{
		public MainModule pMainModule;

		public BattleEnv pBattleEnv;

		public ServerCommandQueue pQueue;

		public ServerCommandExecutor pServerCmdExecutor;
	}

	public class UseItemCommandParam
	{
		public ushort pokeID;

		public ushort itemno;

		public bool needTokuseiWindowDisplay;

		public ushort cmdQueuePos_TokuseiWindowIn;

		public ushort cmdQueuePos_ItemUseAction;

		public ushort cmdQueuePos_TokuseiWindowOut;
	}

	private readonly MainModule m_pMainModule;

	private BattleEnv m_pBattleEnv;

	private ServerCommandQueue m_pQueue;

	private ServerCommandExecutor m_pExecutor;

	private static void SCQUE_PUT_OP_HpMinus(ServerCommandQueue queue, byte pokeID, ushort value, DamageCause damageCause, byte damageCausePokeID)
	{
	}

	private static void SCQUE_PUT_OP_HpMinusForSyncWazaEffect(ServerCommandQueue queue, byte pokeID, ushort value, DamageCause damageCause, byte damageCausePokeID)
	{
	}

	private static void SCQUE_PUT_OP_HpPlus(ServerCommandQueue queue, byte pokeID, ushort value)
	{
	}

	private static void SCQUE_PUT_OP_HpZero(ServerCommandQueue queue, byte pokeID)
	{
	}

	private static void SCQUE_PUT_OP_PPMinus(ServerCommandQueue queue, byte pokeID, byte wazaIdx, byte value)
	{
	}

	private static void SCQUE_PUT_OP_PPMinus_Org(ServerCommandQueue queue, byte pokeID, byte wazaIdx, byte value)
	{
	}

	private static void SCQUE_PUT_OP_WazaUsed(ServerCommandQueue queue, byte pokeID, byte wazaIdx)
	{
	}

	private static void SCQUE_PUT_OP_IncWazaUsedCount(ServerCommandQueue queue, byte pokeID, byte wazaIdx)
	{
	}

	private static void SCQUE_PUT_OP_IncWazaKillCount(ServerCommandQueue queue, byte pokeID, byte wazaIdx)
	{
	}

	private static void SCQUE_PUT_OP_PPPlus(ServerCommandQueue queue, byte pokeID, byte wazaIdx, byte value)
	{
	}

	private static void SCQUE_PUT_OP_PPPlus_Org(ServerCommandQueue queue, byte pokeID, byte wazaIdx, byte value)
	{
	}

	private static void SCQUE_PUT_OP_RankUp(ServerCommandQueue queue, byte pokeID, byte statusType, byte volume)
	{
	}

	private static void SCQUE_PUT_OP_RankDown(ServerCommandQueue queue, byte pokeID, byte statusType, byte volume)
	{
	}

	private static void SCQUE_PUT_OP_RankSet8(ServerCommandQueue queue, byte pokeID, byte atk, byte def, byte sp_atk, byte sp_def, byte agi, byte hit, byte avoid, byte critical)
	{
	}

	private static void SCQUE_PUT_OP_RankRecover(ServerCommandQueue queue, byte pokeID)
	{
	}

	private static void SCQUE_PUT_OP_RankUpReset(ServerCommandQueue queue, byte pokeID)
	{
	}

	private static void SCQUE_PUT_OP_RankReset(ServerCommandQueue queue, byte pokeID)
	{
	}

	private static void SCQUE_PUT_OP_AddCritical(ServerCommandQueue queue, byte pokeID, int value)
	{
	}

	private static void SCQUE_PUT_OP_SetSick(ServerCommandQueue queue, byte pokeID, byte sick, [In] ref BTL_SICKCONT contParam)
	{
	}

	private static void SCQUE_PUT_OP_CurePokeSick(ServerCommandQueue queue, byte pokeID)
	{
	}

	private static void SCQUE_PUT_OP_CureWazaSick(ServerCommandQueue queue, byte pokeID, ushort sickID)
	{
	}

	private static void SCQUE_PUT_OP_MemberIn(ServerCommandQueue queue, byte clientID, byte posIdx, byte memberIdx, ushort turnCount)
	{
	}

	private static void SCQUE_PUT_OP_SetStatus(ServerCommandQueue queue, byte pokeID, byte vid, ushort value)
	{
	}

	private static void SCQUE_PUT_OP_SetWeight(ServerCommandQueue queue, byte pokeID, ushort weight)
	{
	}

	private static void SCQUE_PUT_OP_WazaSickTurnCheck(ServerCommandQueue queue, byte pokeID, WazaSick sick)
	{
	}

	private static void SCQUE_PUT_OP_ChangePokeType(ServerCommandQueue queue, byte pokeID, ushort nextType, BTL_POKEPARAM.ExTypeCause exTypeCause)
	{
	}

	private static void SCQUE_PUT_OP_ExPokeType(ServerCommandQueue queue, byte pokeID, byte exType, BTL_POKEPARAM.ExTypeCause exTypeCause)
	{
	}

	private static void SCQUE_PUT_OP_ConsumeItem(ServerCommandQueue queue, byte pokeID, ushort itemID)
	{
	}

	private static void SCQUE_PUT_OP_UpdateWazaProcResult(ServerCommandQueue queue, byte pokeID, BtlPokePos actTargetPos, byte actWazaType, bool fActEnable, WazaNo actWaza, WazaNo orgWaza)
	{
	}

	private static void SCQUE_PUT_OP_SetTurnFlag(ServerCommandQueue queue, byte pokeID, BTL_POKEPARAM.TurnFlag flag)
	{
	}

	private static void SCQUE_PUT_OP_ResetTurnFlag(ServerCommandQueue queue, byte pokeID, BTL_POKEPARAM.TurnFlag flag)
	{
	}

	private static void SCQUE_PUT_OP_SetContFlag(ServerCommandQueue queue, byte pokeID, ContFlag flag)
	{
	}

	private static void SCQUE_PUT_OP_ResetContFlag(ServerCommandQueue queue, byte pokeID, ContFlag flag)
	{
	}

	private static void SCQUE_PUT_OP_SetPermFlag(ServerCommandQueue queue, byte pokeID, BTL_POKEPARAM.PermFlag flag)
	{
	}

	private static void SCQUE_PUT_OP_IncPokeTurnCount(ServerCommandQueue queue, byte pokeID)
	{
	}

	private static void SCQUE_PUT_OP_ChangeTokusei(ServerCommandQueue queue, byte pokeID, TokuseiNo tokusei)
	{
	}

	private static void SCQUE_PUT_OP_SetItem(ServerCommandQueue queue, byte pokeID, ushort itemID)
	{
	}

	private static void SCQUE_PUT_OP_UpdateWaza(ServerCommandQueue queue, byte pokeID, byte wazaIdx, WazaNo wazaID, byte ppMax, bool fPermanent)
	{
	}

	private static void SCQUE_PUT_OP_OutClear(ServerCommandQueue queue, byte pokeID)
	{
	}

	private static void SCQUE_PUT_OP_DeadClear(ServerCommandQueue queue, byte pokeID)
	{
	}

	private static void SCQUE_PUT_OP_SetBattleFlag(ServerCommandQueue queue, BattleFlags.Flag flag)
	{
	}

	private static void SCQUE_PUT_OP_RemoveBattleFlag(ServerCommandQueue queue, BattleFlags.Flag flag)
	{
	}

	private static void SCQUE_PUT_OP_IncBattleCount(ServerCommandQueue queue, BattleCounter.UniqueCounter counterID)
	{
	}

	private static void SCQUE_PUT_OP_DecBattleCount(ServerCommandQueue queue, BattleCounter.UniqueCounter counterID)
	{
	}

	private static void SCQUE_PUT_OP_IncBattleCount(ServerCommandQueue queue, BattleCounter.ClientCounter counterID, BTL_CLIENT_ID clientID)
	{
	}

	private static void SCQUE_PUT_OP_IncBattleCount(ServerCommandQueue queue, BattleCounter.SideCounter counterID, BtlSide side)
	{
	}

	private static void SCQUE_OP_ChangeGround(ServerCommandQueue queue, BtlGround ground, [In] ref BTL_SICKCONT contParam)
	{
	}

	private static void SCQUE_PUT_OP_AddFieldEffect(ServerCommandQueue queue, EffectType effect, [In] ref BTL_SICKCONT cont)
	{
	}

	private static void SCQUE_PUT_OP_RemoveFieldEffect(ServerCommandQueue queue, EffectType effect)
	{
	}

	private static void SCQUE_PUT_OP_AddFieldEffectDepend(ServerCommandQueue queue, EffectType effect, byte pokeID)
	{
	}

	private static void SCQUE_PUT_OP_DeleteDependPokeFieldEffect(ServerCommandQueue queue, byte causedPokeID, EffectType fieldEffect)
	{
	}

	private static void SCQUE_PUT_OP_SetPokeCounter(ServerCommandQueue queue, byte pokeID, byte counterID, byte value)
	{
	}

	private static void SCQUE_PUT_OP_SetPokePermCounter(ServerCommandQueue queue, byte pokeID, BTL_POKEPARAM.PermCounter counterID, uint value)
	{
	}

	private static void SCQUE_PUT_OP_AddPokePermCounter(ServerCommandQueue queue, byte pokeID, BTL_POKEPARAM.PermCounter counterID, uint value)
	{
	}

	private static void SCQUE_PUT_OP_IncKillCount(ServerCommandQueue queue, byte pokeID)
	{
	}

	private static void SCQUE_PUT_OP_BatonTouch(ServerCommandQueue queue, byte userPokeID, byte targetPokeID)
	{
	}

	private static void SCQUE_PUT_OP_MigawariCreate(ServerCommandQueue queue, byte pokeID, ushort migawariHP)
	{
	}

	private static void SCQUE_PUT_OP_MigawariDelete(ServerCommandQueue queue, byte pokeID)
	{
	}

	private static void SCQUE_PUT_OP_SetIllusionForParty(ServerCommandQueue queue, BTL_CLIENT_ID clientID)
	{
	}

	private static void SCQUE_PUT_OP_FakeDisable(ServerCommandQueue queue, byte pokeID)
	{
	}

	private static void SCQUE_PUT_OP_ClearConsumedItem(ServerCommandQueue queue, byte pokeID)
	{
	}

	private static void SCQUE_PUT_OP_CureDependPokeSick(ServerCommandQueue queue, byte pokeID, byte causePokeID)
	{
	}

	private static void SCQUE_OP_AddWazaDmgRec(ServerCommandQueue queue, byte defPokeID, byte atkPokeID, BtlPokePos atkPokePos, byte wazaType, WazaDamageType damageType, ushort wazaID, ushort damage)
	{
	}

	private static void SCQUE_PUT_OP_TurnCheck(ServerCommandQueue queue, byte pokeID)
	{
	}

	private static void SCQUE_PUT_OP_IncFieldTurn(ServerCommandQueue queue, EffectType effect)
	{
	}

	private static void SCQUE_PUT_OP_Doryoku(ServerCommandQueue queue, byte pokeID, byte hp, byte pow, byte def, byte sp_pow, byte sp_def, byte agi)
	{
	}

	private static void SCQUE_PUT_OP_AddEffort_G(ServerCommandQueue queue, byte pokeID, byte value)
	{
	}

	private static void SCQUE_OP_StartPosEffect(ServerCommandQueue queue, BtlPosEffect effect, BtlPokePos pos, uint effectParam)
	{
	}

	public static void SCQUE_OP_RemovePosEffect(ServerCommandQueue queue, BtlPosEffect effect, BtlPokePos pos)
	{
	}

	public static void SCQUE_OP_UpdatePosEffectParam(ServerCommandQueue queue, BtlPosEffect effect, BtlPokePos pos, uint effectParam)
	{
	}

	private static void SCQUE_PUT_OP_PGLRecord(ServerCommandQueue queue, byte defPokeID, byte atkPokeID, ushort atkWazaNo)
	{
	}

	private static void SCQUE_PUT_OP_SideEffect_Add(ServerCommandQueue queue, BtlSide side, BtlSideEffect sideEffect, [In] ref BTL_SICKCONT contParam)
	{
	}

	private static void SCQUE_PUT_OP_SideEffect_Remove(ServerCommandQueue queue, BtlSide side, BtlSideEffect sideEffect)
	{
	}

	private static void SCQUE_PUT_OP_SideEffect_IncTurnCount(ServerCommandQueue queue, BtlSide side, BtlSideEffect sideEffect)
	{
	}

	private static void SCQUE_PUT_OP_SideEffect_Swap(ServerCommandQueue queue, BtlSide side1, BtlSide side2, BtlSideEffect sideEffect)
	{
	}

	private static void SCQUE_PUT_OP_PublishClientInformation_AppearedPokemon(ServerCommandQueue queue, byte appeardPokeId)
	{
	}

	private static void SCQUE_PUT_OP_PublishClientInformation_HavePokemonItem(ServerCommandQueue queue, byte pokeID, bool haveItem)
	{
	}

	private static void SCQUE_PUT_ACT_WazaEffect(ServerCommandQueue queue, BtlPokePos atPokePos, BtlPokePos defPokePos, WazaNo waza, byte wazaType, byte arg, byte pluralHitIndex, bool bSyncDamageEffect, bool isGShockOccur)
	{
	}

	private static void SCQUE_PUT_ACT_TameWazaHide(ServerCommandQueue queue, byte pokeID, bool hideFlag)
	{
	}

	private static void SCQUE_PUT_ACT_WazaDamage(ServerCommandQueue queue, byte defPokeID, TypeAffinity.AboutAffinityID affAbout, WazaNo wazaID)
	{
	}

	private static void SCQUE_PUT_ACT_WazaDamagePlural(ServerCommandQueue queue, byte pokeCnt, byte affAbout, ushort wazaID)
	{
	}

	private static void SCQUE_PUT_ACT_MigawariDamage(ServerCommandQueue queue, byte defPokeID, TypeAffinity.AffinityID affine, WazaNo waza)
	{
	}

	private static void SCQUE_PUT_ACT_WazaIchigeki(ServerCommandQueue queue, byte pokeID)
	{
	}

	private static void SCQUE_PUT_ACT_SickIcon(ServerCommandQueue queue, byte pokeID, Sick sick)
	{
	}

	private static void SCQUE_PUT_ACT_ConfDamage(ServerCommandQueue queue, byte pokeID)
	{
	}

	private static void SCQUE_PUT_ACT_RankUp(ServerCommandQueue queue, byte pokeID, byte statusType, byte volume, RankEffectViewType viewType)
	{
	}

	private static void SCQUE_PUT_ACT_RankDown(ServerCommandQueue queue, byte pokeID, byte statusType, byte volume, RankEffectViewType viewType)
	{
	}

	private static void SCQUE_PUT_ACT_Dead(ServerCommandQueue queue, byte pokeID, bool isKillCountEffect)
	{
	}

	private static void SCQUE_PUT_ACT_RelivePoke(ServerCommandQueue queue, byte pokeID)
	{
	}

	private static void SCQUE_PUT_ACT_MemberOutMsg(ServerCommandQueue queue, byte clientID, byte pokeID)
	{
	}

	private static void SCQUE_PUT_ACT_MemberOut(ServerCommandQueue queue, BtlPokePos pos, ushort effectNo)
	{
	}

	private static void SCQUE_PUT_ACT_MemberIn(ServerCommandQueue queue, byte clientID, byte posIdx, byte memberIdx, bool fPutMsg)
	{
	}

	private static void SCQUE_PUT_ACTOP_WeatherStart(ServerCommandQueue queue, byte weather, byte turn, byte turnUpCount, byte causePokeID, ChangeWeatherCause cause)
	{
	}

	private static void SCQUE_PUT_ACT_WeatherEnd(ServerCommandQueue queue, byte weather)
	{
	}

	private static void SCQUE_PUT_OP_WeatherEnd(ServerCommandQueue queue)
	{
	}

	private static void SCQUE_PUT_ACT_SimpleHP(ServerCommandQueue queue, byte pokeID)
	{
	}

	private static void SCQUE_PUT_ACT_USE_ITEM(ServerCommandQueue queue, byte pokeID, byte bNuts)
	{
	}

	private static void SCQUE_PUT_ACT_KINOMI_PRE_WAZA(ServerCommandQueue queue, byte pokeCnt, byte pokeID_1, byte pokeID_2, byte pokeID_3, byte pokeID_4, byte pokeID_5)
	{
	}

	private static void SCQUE_PUT_ACT_Kill(ServerCommandQueue queue, byte pokeID, byte effectType)
	{
	}

	private static void SCQUE_PUT_OP_MemberMove(ServerCommandQueue queue, byte clientID, BtlPokePos pos1, BtlPokePos pos2)
	{
	}

	private static void SCQUE_PUT_ACT_MemberMove(ServerCommandQueue queue, byte clientID, BtlPokePos pos1, BtlPokePos pos2)
	{
	}

	private static void SCQUE_PUT_ACT_AddExp_InitParam(ServerCommandQueue queue)
	{
	}

	private static void SCQUE_PUT_ACT_AddExp_AddParam(ServerCommandQueue queue, byte pokeID, uint exp, uint effort_hp, uint effort_pow, uint effort_def, uint effort_sp_pow, uint effort_sp_def, uint effort_agi)
	{
	}

	private static void SCQUE_PUT_ACT_AddExp(ServerCommandQueue queue)
	{
	}

	private static void SCQUE_PUT_OP_AddExp(ServerCommandQueue queue, byte pokeID, uint exp)
	{
	}

	private static void SCQUE_PUT_ACT_BallThrow(ServerCommandQueue queue, BtlPokePos userPos, BtlPokePos targetPos, byte yureCnt, bool fSuccess, bool fZukanRegister, bool fCritical, ushort ballItemID)
	{
	}

	private static void SCQUE_PUT_ACT_BallThrow_Captured(ServerCommandQueue queue, BtlPokePos pos, bool bZukanRegister)
	{
	}

	private static void SCQUE_PUT_ACT_BallThrowForbidden(ServerCommandQueue queue, BtlPokePos targetPos, ushort ballItemID, BallThrowForbiddenCause cause)
	{
	}

	private static void SCQUE_PUT_ACTOP_ChangeTokusei(ServerCommandQueue queue, byte pokeID, ushort tokuseiID)
	{
	}

	private static void SCQUE_PUT_ACTOP_SkillSwap(ServerCommandQueue queue, byte pokeID_1, byte pokeID_2, TokuseiNo tokID_1, TokuseiNo tokID_2)
	{
	}

	private static void SCQUE_PUT_ACT_FakeDisable(ServerCommandQueue queue, byte pokeID)
	{
	}

	private static void SCQUE_PUT_ACT_EffectSimple(ServerCommandQueue queue, ushort effectNo)
	{
	}

	private static void SCQUE_PUT_ACT_EffectByPos(ServerCommandQueue queue, BtlPokePos pos, ushort effectNo)
	{
	}

	private static void SCQUE_PUT_ACT_EffectByVector(ServerCommandQueue queue, BtlPokePos pos_from, BtlPokePos pos_to, ushort effectNo)
	{
	}

	private static void SCQUE_PUT_ACT_EffectBySide(ServerCommandQueue queue, BtlPokePos pos_from, BtlPokePos pos_to, ushort effectNo)
	{
	}

	private static void SCQUE_PUT_ACT_ChangeGround(ServerCommandQueue queue, BtlGround ground)
	{
	}

	private static void SCQUE_PUT_ACT_ExPlural2ndHit(ServerCommandQueue queue, BtlPokePos pos, ushort effectNo)
	{
	}

	private static void SCQUE_PUT_ACT_ChangeForm(ServerCommandQueue queue, byte pokeID)
	{
	}

	private static void SCQUE_PUT_OP_ChangeForm(ServerCommandQueue queue, byte pokeID, byte formNo, bool dontResetFormByOut)
	{
	}

	private static void SCQUE_PUT_OP_Hensin(ServerCommandQueue queue, byte userID, byte targetID)
	{
	}

	private static void SCQUE_PUT_OP_AddWazaHandler(ServerCommandQueue queue, byte pokeID, WazaNo waza, uint subPri)
	{
	}

	private static void SCQUE_PUT_OP_RemoveWazaHandler(ServerCommandQueue queue, byte pokeID, WazaNo waza)
	{
	}

	private static void SCQUE_PUT_OP_RemoveForceWazaHandler(ServerCommandQueue queue, byte pokeID, WazaNo waza)
	{
	}

	private static void SCQUE_PUT_OP_RemoveForceAllWazaHandler(ServerCommandQueue queue, byte pokeID)
	{
	}

	private static void SCQUE_PUT_OP_AddTokuseiHandler(ServerCommandQueue queue, byte pokeID)
	{
	}

	private static void SCQUE_PUT_OP_RemoveTokuseiHandler(ServerCommandQueue queue, byte pokeID)
	{
	}

	private static void SCQUE_PUT_OP_SwapTokuseiHandler(ServerCommandQueue queue, byte pokeID1, byte pokeID2)
	{
	}

	private static void SCQUE_PUT_OP_AddItemHandler(ServerCommandQueue queue, byte pokeID)
	{
	}

	private static void SCQUE_PUT_OP_RemoveItemHandler(ServerCommandQueue queue, byte pokeID)
	{
	}

	private static void SCQUE_PUT_OP_AddPosEffectHandler(ServerCommandQueue queue, BtlPosEffect effect, BtlPokePos pos, byte pokeID, int[] param, byte param_cnt)
	{
	}

	private static void SCQUE_PUT_OP_RemovePosHandler(ServerCommandQueue queue, BtlPosEffect effect, BtlPokePos pos)
	{
	}

	private static void SCQUE_PUT_OP_AddSideHandler(ServerCommandQueue queue, BtlSide side, BtlSideEffect sideEffect, [In] ref BTL_SICKCONT contParam)
	{
	}

	private static void SCQUE_PUT_OP_RemoveSideHandler(ServerCommandQueue queue, BtlSide side, BtlSideEffect sideEffect)
	{
	}

	private static void SCQUE_PUT_OP_SleepSideHandler(ServerCommandQueue queue, BtlSide side, BtlSideEffect sideEffect)
	{
	}

	private static void SCQUE_PUT_OP_WakeSideHandler(ServerCommandQueue queue, BtlSide side, BtlSideEffect sideEffect)
	{
	}

	private static void SCQUE_PUT_OP_AddFieldHandler(ServerCommandQueue queue, EffectType effect, byte sub_param)
	{
	}

	private static void SCQUE_PUT_OP_RemoveFieldHandler(ServerCommandQueue queue, EffectType effect)
	{
	}

	private static void SCQUE_PUT_OP_AddDefaultPowerUpHandler(ServerCommandQueue queue, byte pokeID)
	{
	}

	private static void SCQUE_PUT_OP_RemoveDefaultPowerUpHandler(ServerCommandQueue queue, byte pokeID)
	{
	}

	private static void SCQUE_PUT_OP_AddRaidBossHandler(ServerCommandQueue queue, byte pokeID, RaidBossHandlerType handlerType)
	{
	}

	private static void SCQUE_PUT_OP_RemoveRaidBossHandler(ServerCommandQueue queue, byte pokeID, RaidBossHandlerType handlerType)
	{
	}

	private static void SCQUE_PUT_ACT_MigawariCreate(ServerCommandQueue queue, BtlPokePos pos)
	{
	}

	private static void SCQUE_PUT_ACT_MigawariDelete(ServerCommandQueue queue, BtlPokePos pos)
	{
	}

	private static void SCQUE_PUT_ACT_Hensin(ServerCommandQueue queue, byte atkPokeID, byte tgtPokeID)
	{
	}

	public static void SCQUE_PUT_ACT_PlayWinBGM(ServerCommandQueue queue, uint bgmNo)
	{
	}

	private static void SCQUE_PUT_ACT_MsgWinHide(ServerCommandQueue queue, byte dmy)
	{
	}

	private static void SCQUE_PUT_ACT_FriendshipEffect(ServerCommandQueue queue, byte pokeID, FriendshipEffect effect)
	{
	}

	private static void SCQUE_PUT_ACT_FriendshipEffectWithMsg(ServerCommandQueue queue, byte pokeID, FriendshipEffect effect, BtlStrType msgType, ushort strID, ushort arg1, ushort arg2)
	{
	}

	private static void SCQUE_PUT_OP_INC_WEATHER_PASSED_TURN(ServerCommandQueue queue)
	{
	}

	private static void SCQUE_PUT_OP_SET_SPACT_PRIORITY(ServerCommandQueue queue, byte pokeID, byte priority)
	{
	}

	private static void SCQUE_PUT_OP_SetActionRecord(ServerCommandQueue queue, byte pokeID, ActionRecorder.ActionID actionID)
	{
	}

	private static void SCQUE_PUT_OP_AddEscapeInfo(ServerCommandQueue queue, BTL_CLIENT_ID clientID)
	{
	}

	private static void SCQUE_PUT_ACT_TurnStart(ServerCommandQueue queue)
	{
	}

	private static void SCQUE_PUT_OP_GWallBreak(ServerCommandQueue queue, byte pokeID)
	{
	}

	private static void SCQUE_PUT_OP_GWallGaugeAdd(ServerCommandQueue queue, byte pokeID, byte value)
	{
	}

	private static void SCQUE_PUT_OP_GWallGaugeSub(ServerCommandQueue queue, byte pokeID, byte value)
	{
	}

	private static void SCQUE_PUT_OP_GWallGaugeInit(ServerCommandQueue queue, byte pokeID)
	{
	}

	private static void SCQUE_PUT_OP_DecGWallRepairTurnCount(ServerCommandQueue queue, byte pokeID)
	{
	}

	private static void SCQUE_PUT_OP_RepairGWall(ServerCommandQueue queue, byte pokeID)
	{
	}

	private static void SCQUE_PUT_OP_G_Start(ServerCommandQueue queue, byte pokeID)
	{
	}

	private static void SCQUE_PUT_OP_G_End(ServerCommandQueue queue, byte pokeID)
	{
	}

	private static void SCQUE_PUT_OP_G_IncTurn(ServerCommandQueue queue, byte pokeID)
	{
	}

	private static void SCQUE_PUT_OP_GGauge_Inc(ServerCommandQueue queue, BTL_CLIENT_ID clientID)
	{
	}

	private static void SCQUE_PUT_OP_GGauge_Empty(ServerCommandQueue queue, BTL_CLIENT_ID clientID)
	{
	}

	private static void SCQUE_PUT_ACT_G_Start(ServerCommandQueue queue, byte pokeID)
	{
	}

	private static void SCQUE_PUT_ACT_G_End(ServerCommandQueue queue, byte pokeID)
	{
	}

	private static void SCQUE_PUT_OP_RaidBoss_DecReinforceTurn(ServerCommandQueue queue, byte pokeID)
	{
	}

	private static void SCQUE_PUT_OP_RaidBoss_SetReinforceTurn(ServerCommandQueue queue, byte pokeID, byte turn)
	{
	}

	private static void SCQUE_PUT_OP_RaidBoss_SetAngry(ServerCommandQueue queue, byte pokeID)
	{
	}

	private static void SCQUE_PUT_OP_RaidBoss_GWazaUseSchedule_DecTurn(ServerCommandQueue queue, byte pokeID)
	{
	}

	private static void SCQUE_PUT_OP_RaidBoss_GWazaUseSchedule_SetUsed(ServerCommandQueue queue, byte pokeID)
	{
	}

	private static void SCQUE_PUT_OP_RaidBoss_GWazaUseSchedule_Reset(ServerCommandQueue queue, byte pokeID, byte turn)
	{
	}

	private static void SCQUE_PUT_OP_TransferGRights(ServerCommandQueue queue, BtlSide side)
	{
	}

	private static void SCQUE_PUT_OP_IncGRightsPassedTurnCount(ServerCommandQueue queue, BtlSide side)
	{
	}

	private static void SCQUE_PUT_OP_InvalidateGRights(ServerCommandQueue queue, BTL_CLIENT_ID clientID)
	{
	}

	private static void SCQUE_PUT_ACT_GetGRights(ServerCommandQueue queue, BTL_CLIENT_ID clientID, bool canAnotherClientDisplayMessage)
	{
	}

	private static void SCQUE_PUT_RaidBattleStatus_IncAllDeadCount(ServerCommandQueue queue)
	{
	}

	private static void SCQUE_PUT_RaidBattleStatus_IncTurnCountAfterAllDead(ServerCommandQueue queue, BTL_CLIENT_ID clientID)
	{
	}

	private static void SCQUE_PUT_RaidBattleStatus_ResetTurnCountAfterAllDead(ServerCommandQueue queue, BTL_CLIENT_ID clientID)
	{
	}

	private static void SCQUE_PUT_ACT_RaidResult(ServerCommandQueue queue)
	{
	}

	private static void SCQUE_PUT_TOKWIN_IN(ServerCommandQueue queue, byte pokeID)
	{
	}

	private static void SCQUE_PUT_TOKWIN_OUT(ServerCommandQueue queue, byte pokeID)
	{
	}

	private static void SCQUE_PUT_MSG_WAZA(ServerCommandQueue queue, byte pokeID, ushort waza, BtlPokePos targetPos, bool needMsgDisplay)
	{
	}

	private static void SCQUE_PUT_MSG_WAZA_ToReservedPos(ServerCommandQueue queue, byte pokeID, ushort waza, BtlPokePos targetPos, bool needMsgDisplay, ushort reservedPos)
	{
	}

	private static void SCQUE_PUT_MSG_STD(ServerCommandQueue queue, int[] args)
	{
	}

	private static void SCQUE_PUT_MSG_SET(ServerCommandQueue queue, int[] args)
	{
	}

	private static void SCQUE_PUT_MSG_STD_SE(ServerCommandQueue queue, int[] args)
	{
	}

	private static void SCQUE_PUT_MSG_SET_SE(ServerCommandQueue queue, int[] args)
	{
	}

	public static void SCQUE_PUT_MSG_STD_TO_RESERVED_POS(ServerCommandQueue queue, ushort pos, int[] args)
	{
	}

	public static void SCQUE_PUT_MSG_SET_TO_RESERVED_POS(ServerCommandQueue queue, ushort pos, int[] args)
	{
	}

	private static void SCQUE_PUT_ACT_Safari(ServerCommandQueue queue, byte pokeID, byte param0, byte param1)
	{
	}

	public ServerCommandPutter([In] ref SetupParam param)
	{
	}

	public bool Message([In] ref StrParam strParam)
	{
		return default(bool);
	}

	public void Message_Std(ushort strID)
	{
	}

	public void Message_Std(ushort strID, int arg)
	{
	}

	public void Message_Std(ushort strID, int arg1, int arg2)
	{
	}

	public void Message_Std(ushort strID, int arg1, int arg2, int arg3)
	{
	}

	public void Message_Std(ushort strID, int arg1, int arg2, int arg3, int arg4)
	{
	}

	public void Message_StdEx(ushort strID, uint argsCount, int[] args)
	{
	}

	public void Message_StdSE(ushort strID, uint SENo, uint argsCount, int[] args)
	{
	}

	public void Message_Set(BTL_POKEPARAM poke, ushort strID)
	{
	}

	public void Message_Set(ushort strID, int arg1)
	{
	}

	public void Message_Set(ushort strID, int arg1, int arg2)
	{
	}

	public void Message_SetEx(ushort strID, uint argsCount, int[] args)
	{
	}

	public void Message_SetSE(ushort strID, uint SENo, uint argsCount, int[] args)
	{
	}

	public void Message_Waza(byte attackerID, WazaNo waza, BtlPokePos targetPos, bool needMsgDisplay)
	{
	}

	public void Message_Waza_ToReservedPos(byte attackerID, WazaNo waza, BtlPokePos targetPos, bool needMsgDisplay, ushort reservedPos)
	{
	}

	public void Message_DamageAffinity(TypeAffinity.AffinityID affinity)
	{
	}

	public void Message_WazaAffinity(BTL_POKEPARAM attacker, uint targetCount, TypeAffinity.AffinityID[] affinityArray, BTL_POKEPARAM[] targets, bool isPluralHitWaza)
	{
	}

	public void Message_WazaFailed()
	{
	}

	public void Message_WazaAvoid(BTL_POKEPARAM defender, WazaNo waza)
	{
	}

	public void Message_WazaAvoidByFriendship(BTL_POKEPARAM defender, WazaNo waza)
	{
	}

	public void Message_NoEffect(BTL_POKEPARAM defender)
	{
	}

	public void Message_NoEffect_Ichigeki(BTL_POKEPARAM defender)
	{
	}

	public void Message_WazaExecuteFailed(BTL_POKEPARAM attacker, WazaNo waza, WazaFailCause cause)
	{
	}

	public void Message_MemberOut(BTL_POKEPARAM bpp)
	{
	}

	public void Message_AffGoodFriendship(BTL_POKEPARAM poke)
	{
	}

	public void Message_AddSickFailed(BTL_POKEPARAM target, AddSickFailCode failCode, WazaSick sick, SickCause cause)
	{
	}

	public void Message_SideEffectOff(BtlSide side, BtlSideEffect sideEffect)
	{
	}

	public bool ChangeGround(byte ground, [In] ref BTL_SICKCONT contParam)
	{
		return default(bool);
	}

	public void AddFieldEffect(EffectType effect, [In] ref BTL_SICKCONT cont)
	{
	}

	public bool RemoveFieldEffect(EffectType effect)
	{
		return default(bool);
	}

	public bool IncFieldTurnCount(EffectType effect)
	{
		return default(bool);
	}

	public void AddFieldEffect_DependPoke(EffectType effect, byte pokeID)
	{
	}

	public bool RemoveFieldEffect_DependPoke(BTL_POKEPARAM causedPoke, EffectType fieldEffect)
	{
		return default(bool);
	}

	public bool SideEffect_Add(BtlSide side, BtlSideEffect sideEffect, [In] ref BTL_SICKCONT contParam)
	{
		return default(bool);
	}

	public bool SideEffect_Remove(BtlSide side, BtlSideEffect sideEffect)
	{
		return default(bool);
	}

	public void SideEffect_IncTurnCount(BtlSide side, BtlSideEffect sideEffect)
	{
	}

	public bool SideEffect_Swap(BtlSide side1, BtlSide side2, BtlSideEffect sideEffect)
	{
		return default(bool);
	}

	public bool PosEffect_Add(BtlPokePos effectPos, BtlPosEffect posEffect, [In] ref PosEffect.EffectParam effectParam)
	{
		return default(bool);
	}

	public void EffectByPos(BTL_POKEPARAM poke, ushort effectNo)
	{
	}

	public void EffectByPos(BtlPokePos pos, ushort effectNo)
	{
	}

	public void EffectByClient(BTL_CLIENT_ID clientID, ushort effectNo)
	{
	}

	public void EffectBySide(BtlPokePos pos_from, BtlPokePos pos_to, ushort effectNo)
	{
	}

	public void ConfusionAct(BTL_POKEPARAM poke)
	{
	}

	public void MeromeroAct(BTL_POKEPARAM poke)
	{
	}

	public void UseItemAct(BTL_POKEPARAM poke)
	{
	}

	public void CantAction(BTL_POKEPARAM poke)
	{
	}

	public void MemberIn(byte clientID, byte posIdx, byte nextPokeIdx, uint turnCount)
	{
	}

	public void SetTurnFlag(BTL_POKEPARAM poke, BTL_POKEPARAM.TurnFlag flag)
	{
	}

	public void ResetTurnFlag(BTL_POKEPARAM poke, BTL_POKEPARAM.TurnFlag flag)
	{
	}

	public void SetContFlag(BTL_POKEPARAM poke, ContFlag flag)
	{
	}

	public void ResetContFlag(BTL_POKEPARAM poke, ContFlag flag)
	{
	}

	public void SetPermFlag(BTL_POKEPARAM poke, BTL_POKEPARAM.PermFlag flag)
	{
	}

	public void SetBppCounter(BTL_POKEPARAM poke, BTL_POKEPARAM.Counter counterID, byte value)
	{
	}

	public void IncBppCounter(BTL_POKEPARAM poke, BTL_POKEPARAM.Counter counterID)
	{
	}

	public void SetPokePermCounter(byte pokeID, BTL_POKEPARAM.PermCounter counterID, uint value)
	{
	}

	public void AddPokePermCounter(byte pokeID, BTL_POKEPARAM.PermCounter counterID, uint value)
	{
	}

	public void IncPokePermCounter(byte pokeID, BTL_POKEPARAM.PermCounter counterID)
	{
	}

	public void IncTotalTurnCount(byte pokeID)
	{
	}

	public void IncKillCount(byte pokeID)
	{
	}

	public void SetItem(BTL_POKEPARAM poke, ushort itemID)
	{
	}

	public void ConsumeItem(BTL_POKEPARAM poke, ushort itemID)
	{
	}

	public void ClearConsumedItem(byte pokeID)
	{
	}

	public void SimpleHp(BTL_POKEPARAM poke, int value, DamageCause damageCause, byte damageCausePokeID, bool isEffectEnable)
	{
	}

	public void DecreaseHP(BTL_POKEPARAM poke, uint value, bool byWazaDamage, DamageCause damageCause, byte damageCausePokeID)
	{
	}

	public void ConfDamage(BTL_POKEPARAM poke, uint damage)
	{
	}

	public void HpZero(BTL_POKEPARAM poke)
	{
	}

	public void KillPokemon(BTL_POKEPARAM poke, byte attackerID, DamageCause deadCause, byte effectType)
	{
	}

	public void DecrementPP(BTL_POKEPARAM poke, byte wazaIdx, byte volume)
	{
	}

	public void RecoverPP(BTL_POKEPARAM poke, byte wazaIdx, byte volume, bool isOriginalWaza)
	{
	}

	public void AddSick(BTL_POKEPARAM target, WazaSick sick, [In] ref BTL_SICKCONT sickCont)
	{
	}

	public void CureSick(BTL_POKEPARAM poke, WazaSick sick, out BTL_SICKCONT pOldCont)
	{
	}

	public void CureDependPokeSick(BTL_POKEPARAM poke, BTL_POKEPARAM causedPoke)
	{
	}

	public void RankEffect(BTL_POKEPARAM target, WazaRankEffect effect, int volume, ushort itemID, bool putStdMsg, RankEffectViewType viewType)
	{
	}

	public void SetSpActPriority(BTL_POKEPARAM poke, byte priority)
	{
	}

	public void Act_ChangeForm(byte pokeID)
	{
	}

	public void ChangeForm(byte pokeID, byte formNo, bool dontResetFormByOut)
	{
	}

	public void AddWazaDamageRecord(BTL_POKEPARAM defender, BTL_POKEPARAM attacker, BtlPokePos atkPokePos, byte wazaType, WazaDamageType damageType, ushort wazaID, ushort damage)
	{
	}

	public void CopyBatonTouchParams(byte userPokeID, byte targetPokeID)
	{
	}

	public bool ChangePokeType(byte pokeID, PokeTypePair nextType, BTL_POKEPARAM.ExTypeCause exTypeCause)
	{
		return default(bool);
	}

	public void ExPokeType(byte pokeID, byte exType, BTL_POKEPARAM.ExTypeCause exTypeCause)
	{
	}

	public void ChangeTokusei(byte pokeID, TokuseiNo tokusei)
	{
	}

	public void SetBaseStatus(byte pokeID, BTL_POKEPARAM.ValueID valueID, ushort value)
	{
	}

	public void SetWeight(byte pokeID, ushort weight)
	{
	}

	public void ClearForOut(byte pokeID)
	{
	}

	public void ClearForDead(byte pokeID)
	{
	}

	public void CreateMigawari(byte pokeID, ushort migawariHP)
	{
	}

	public void DeleteMigawari(byte pokeID)
	{
	}

	public void Relive(byte pokeID, ushort recoverHP)
	{
	}

	public void TurnEnd(byte pokeID)
	{
	}

	public void TurnCheck_WazaSick(byte pokeID, WazaSick sick, out bool isSickValid, out BTL_SICKCONT pOldContDest, out bool fCured)
	{
	}

	public void UpdateWazaProcResult(byte pokeID, BtlPokePos actTargetPos, byte actWazaType, bool isWazaEffective, WazaNo actWaza, WazaNo orgWaza)
	{
	}

	public void TokWin_In(byte pokeID)
	{
	}

	public void TokWin_In(BTL_POKEPARAM poke)
	{
	}

	public void TokWin_Out(byte pokeID)
	{
	}

	public void TokWin_Out(BTL_POKEPARAM poke)
	{
	}

	public void PublishClientInformation_AppeardPokemon([In] ref BTL_POKEPARAM appeardPoke)
	{
	}

	public void PublishClientInformation_HavePokemonItem(BTL_POKEPARAM poke, bool haveItem)
	{
	}

	public void WazaEffect([In] ref WazaParam wazaParam, WazaEffectParams wazaEffect, [In] ref WazaEffectReservedPos reservedQueuePos)
	{
	}

	public void WazaSubEffect(WazaEffectParams wazaEffect, ushort reservedQuePos)
	{
	}

	public void HaseiWazaEffect(BTL_POKEPARAM poke, WazaNo waza, BtlPokePos targetPos)
	{
	}

	public void WazaDamagePlural(BTL_POKEPARAM attacker, WazaParam wazaParam, uint targetCount, BTL_POKEPARAM[] targets, TypeAffinity.AffinityID[] affinityArray, ushort[] damage)
	{
	}

	public void InsertWazaInfo(byte pokeID, bool isTokuseiWindowDisplay, [In] ref StrParam message)
	{
	}

	public void SetBattleFlag(BattleFlags.Flag flag)
	{
	}

	public void RemoveBattleFlag(BattleFlags.Flag flag)
	{
	}

	public void IncBattleCount(BattleCounter.UniqueCounter counterID)
	{
	}

	public void DecBattleCount(BattleCounter.UniqueCounter counterID)
	{
	}

	public void IncBattleCount(BattleCounter.ClientCounter counterID, BTL_CLIENT_ID clientID)
	{
	}

	public void IncBattleCount(BattleCounter.SideCounter counterID, BtlSide side)
	{
	}

	public void SetActionRecord(byte pokeID, ActionRecorder.ActionID actionID)
	{
	}

	public void NotifyPGLRecord(BTL_POKEPARAM defPoke, PGLRecord.RecParam pPGLParam)
	{
	}

	public void AddEffort(byte pokeID, byte hp, byte pow, byte def, byte sp_pow, byte sp_def, byte agi)
	{
	}

	public void AddEffort_G(byte pokeID, byte value)
	{
	}

	public void SwapPokePos(byte clientID, BtlPokePos pos1, BtlPokePos pos2)
	{
	}

	public void Act_SwapPokePos(byte clientID, BtlPokePos pos1, BtlPokePos pos2)
	{
	}

	public void UpdateWazaNo(byte pokeID, byte wazaIdx, WazaNo wazaNo, byte ppMax, bool fPermanent)
	{
	}

	public void IncWazaUsedCount(byte pokeID, byte wazaIdx)
	{
	}

	public void IncWazaKillCount(byte pokeID, byte wazaIdx)
	{
	}

	public void SetWazaUsedFlag(byte pokeID, byte wazaIdx)
	{
	}

	public bool RecoverRank(byte pokeID)
	{
		return default(bool);
	}

	public bool RankUpReset(byte pokeID)
	{
		return default(bool);
	}

	public void RankReset(byte pokeID)
	{
	}

	public void RankSet8(byte pokeID, byte atk, byte def, byte sp_atk, byte sp_def, byte agi, byte hit, byte avoid, byte critical)
	{
	}

	public bool AddCriticalRank(byte pokeID, byte volume)
	{
		return default(bool);
	}

	public void StartWeather(BtlWeather weather, byte turn, byte turnUpCount, byte causePokeID, ChangeWeatherCause cause)
	{
	}

	public void EndWeather()
	{
	}

	public void Act_EndWeather(BtlWeather weather)
	{
	}

	public BtlWeather TurnCheckWeather()
	{
		return default(BtlWeather);
	}

	public void UpdateIllusion()
	{
	}

	public void UpdateIllusion(BTL_CLIENT_ID clientID)
	{
	}

	public void FakeDisable(byte pokeID)
	{
	}

	public void Act_FakeDisable(byte pokeID)
	{
	}

	public void Act_FriendshipEffect(byte pokeID, FriendshipEffect effect)
	{
	}

	public void Act_FriendshipEffectWithMsg(byte pokeID, FriendshipEffect effect, BtlStrType msgType, ushort strID, ushort arg1, ushort arg2)
	{
	}

	public void RaidBoss_DecReinforceTurn(byte pokeID)
	{
	}

	public void RaidBoss_SetReinforceTurn(byte pokeID, byte turn)
	{
	}

	public void RaidBoss_IncAngryLevel(byte pokeID)
	{
	}

	public void RaidBoss_GWazaUseSchedule_DecTurn(byte pokeID)
	{
	}

	public void RaidBoss_GWazaUseSchedule_SetUsed(byte pokeID)
	{
	}

	public void RaidBoss_GWazaUseSchedule_Reset(byte pokeID, byte turn)
	{
	}

	public void Act_RaidBoss_GWallAppear(byte pokeID)
	{
	}

	public void BreakGWall(byte pokeID)
	{
	}

	public void AddGWallGauge(byte pokeID, byte value)
	{
	}

	public void SubGWallGauge(byte pokeID, byte value)
	{
	}

	public void InitGWallGauge(byte pokeID)
	{
	}

	public void DecGWallRepairTurnCount(byte pokeID)
	{
	}

	public void RepairGWall(byte pokeID)
	{
	}

	public void RaidBattleStatus_IncAllDeadCount()
	{
	}

	public void RaidBattleStatus_IncTurnCountAfterAllDead(BTL_CLIENT_ID clientID)
	{
	}

	public void RaidBattleStatus_ResetTurnCountAfterAllDead(BTL_CLIENT_ID clientID)
	{
	}

	public void Act_RaidResult()
	{
	}

	public void StartGMode(byte pokeID)
	{
	}

	public void EndGMode(byte pokeID)
	{
	}

	public void IncGModeTurnCount(byte pokeID)
	{
	}

	public void Act_StartGMode(byte pokeID)
	{
	}

	public void Act_EndGMode(byte pokeID)
	{
	}

	public void IncGGauge(BTL_CLIENT_ID clientID)
	{
	}

	public void EmptyGGauge(BTL_CLIENT_ID clientID)
	{
	}

	public bool TransferGRights(BtlSide side)
	{
		return default(bool);
	}

	public void IncGRightsTurnCount(BtlSide side)
	{
	}

	public void InvalidateGRights(BTL_CLIENT_ID clientID)
	{
	}

	public void Act_GrightsGet(BTL_CLIENT_ID clientID, bool canAnotherClientDisplayMessage)
	{
	}

	public void Act_TurnStart()
	{
	}

	public void Act_Dead(byte pokeID, bool isKillCountEffect)
	{
	}

	public void Act_TameWazaHide(byte pokeID, bool hideFlag)
	{
	}

	public void Act_CreateMigawari(BtlPokePos pos)
	{
	}

	public void Act_HideMessageWindow()
	{
	}

	public void Act_ChangeGround(byte ground)
	{
	}

	public void Act_IchigekiWaza(byte targetID)
	{
	}

	public void Act_WazaDamage(byte targetID, TypeAffinity.AboutAffinityID affAbout, WazaNo wazaID)
	{
	}

	public void Act_WazaEffect(BtlPokePos atPokePos, BtlPokePos defPokePos, WazaNo waza, byte wazaType, byte arg, byte pluralHitIndex, bool bSyncDamageEffect, bool isGShockOccur)
	{
	}

	public void Act_EffectSimple(ushort effectNo)
	{
	}

	public void Act_EffectByVector(BtlPokePos pos_from, BtlPokePos pos_to, ushort effectNo)
	{
	}

	public void Act_Hensin(byte userID, byte targetID)
	{
	}

	public void Op_Hensin(byte userID, byte targetID)
	{
	}

	public void Act_MemberIn(byte clientID, byte posIdx, byte memberIdx, bool fPutMsg)
	{
	}

	public void Act_MemberOut(BtlPokePos pos, ushort effectNo)
	{
	}

	public void Act_MigawariDamage(byte defPokeID, TypeAffinity.AffinityID affine, WazaNo waza)
	{
	}

	public void Act_MigawariDelete(BtlPokePos pos)
	{
	}

	public void Act_BallThrow(BtlPokePos userPos, BtlPokePos targetPos, byte yureCnt, bool fSuccess, bool fZukanRegister, bool fCritical, ushort ballItemID)
	{
	}

	public void Act_BallThrow_Forbidden(BtlPokePos targetPos, ushort ballItemID, BallThrowForbiddenCause cause)
	{
	}

	public void Act_BallThrow_AfterCaptured([In] ref POKE_CAPTURED_CONTEXT context)
	{
	}

	public void Act_PlayWinBGM(uint BGMNo)
	{
	}

	public void ActOp_SkillSwap(byte pokeID_1, byte pokeID_2, TokuseiNo tokID_1, TokuseiNo tokID_2)
	{
	}

	public void ActOp_ChangeTokusei(byte pokeID, TokuseiNo tokuseiNo)
	{
	}

	public void Act_AddExp_InitParam()
	{
	}

	public void Act_AddExp_AddParam(byte pokeID, uint exp, uint effort_hp, uint effort_pow, uint effort_def, uint effort_sp_pow, uint effort_sp_def, uint effort_agi)
	{
	}

	public void Act_AddExp()
	{
	}

	public void Op_AddExp(byte pokeID, uint exp)
	{
	}

	public void AddEscapeInfo(BTL_CLIENT_ID clientID)
	{
	}

	public void ReserveUseItemCommands(UseItemCommandParam pParam)
	{
	}

	public void PutUseItemCommands([In] ref UseItemCommandParam param)
	{
	}

	public bool AddWazaHandler(byte pokeID, WazaNo waza, uint subPri)
	{
		return default(bool);
	}

	public void RemoveWazaHandler(byte pokeID, WazaNo waza)
	{
	}

	public void RemoveForceWazaHandler(byte pokeID, WazaNo waza)
	{
	}

	public void RemoveForceAllWazaHandler(byte pokeID)
	{
	}

	public void AddTokuseiHandler(byte pokeID)
	{
	}

	public void RemoveTokuseiHandler(byte pokeID)
	{
	}

	public void SwapTokuseiHandler(byte pokeID1, byte pokeID2)
	{
	}

	public void AddItemHandler(byte pokeID)
	{
	}

	public void RemoveItemHandler(byte pokeID)
	{
	}

	public void AddPosHandler(BtlPosEffect effect, BtlPokePos pos, byte pokeID, int[] param, byte param_cnt)
	{
	}

	public void RemovePosHandler(BtlPosEffect effect, BtlPokePos pos)
	{
	}

	public void AddSideHandler(BtlSide side, BtlSideEffect sideEffect, [In] ref BTL_SICKCONT contParam)
	{
	}

	public void RemoveSideHandler(BtlSide side, BtlSideEffect sideEffect)
	{
	}

	public bool SleepSideHandler(BtlSide side, BtlSideEffect sideEffect)
	{
		return default(bool);
	}

	public bool WakeSideHandler(BtlSide side, BtlSideEffect sideEffect)
	{
		return default(bool);
	}

	public bool AddFieldHandler(EffectType effect, byte sub_param)
	{
		return default(bool);
	}

	public void RemoveFieldHandler(EffectType effect)
	{
	}

	public void AddDefaultPowerUpHandler(byte pokeID)
	{
	}

	public void RemoveDefaultPowerUpHandler(byte pokeID)
	{
	}

	public void AddRaidBossHandler(byte pokeID, RaidBossHandlerType handlerType)
	{
	}

	public void RemoveRaidBossHandler(byte pokeID, RaidBossHandlerType handlerType)
	{
	}

	public void SafariAct(byte pokeID, byte param0, byte param1)
	{
	}
}
