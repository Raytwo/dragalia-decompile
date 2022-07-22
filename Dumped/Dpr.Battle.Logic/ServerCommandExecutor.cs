using System.Runtime.InteropServices;
using Pml;
using Pml.WazaData;

namespace Dpr.Battle.Logic;

public sealed class ServerCommandExecutor
{
	public struct SetupParam
	{
		public MainModule pMainModule;

		public BattleEnv pBattleEnv;

		public EventSystem pEventSystem;
	}

	private readonly MainModule m_pMainModule;

	private BattleEnv m_pBattleEnv;

	private EventSystem m_pEventSystem;

	public ServerCommandExecutor(ref SetupParam param)
	{
	}

	private BTL_POKEPARAM getPokeParam(byte pokeID)
	{
		return null;
	}

	public void SetTurnFlag(byte pokeID, BTL_POKEPARAM.TurnFlag flag)
	{
	}

	public void ResetTurnFlag(byte pokeID, BTL_POKEPARAM.TurnFlag flag)
	{
	}

	public void SetContFlag(byte pokeID, ContFlag flag)
	{
	}

	public void ResetContFlag(byte pokeID, ContFlag flag)
	{
	}

	public void SetPermFlag(byte pokeID, BTL_POKEPARAM.PermFlag flag)
	{
	}

	public void SetBppCounter(byte pokeID, BTL_POKEPARAM.Counter counterID, byte value)
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

	public void HPMinus(byte pokeID, uint value, DamageCause damageCause, byte damageCausePokeID)
	{
	}

	public void HpZero(byte pokeID)
	{
	}

	public void DecrementPP(byte pokeID, byte wazaIdx, byte volume)
	{
	}

	public void SetWazaUsedFlag(byte pokeID, byte wazaIdx)
	{
	}

	public void IncWazaUsedCount(byte pokeID, byte wazaIdx)
	{
	}

	public void IncWazaKillCount(byte pokeID, byte wazaIdx)
	{
	}

	public void SetItem(byte pokeID, ushort itemID)
	{
	}

	public void ConsumeItem(byte pokeID, ushort itemID)
	{
	}

	public void ClearConsumedItem(byte pokeID)
	{
	}

	public void CurePokeSick(byte pokeID)
	{
	}

	public void CureWazaSick(byte pokeID, WazaSick sick)
	{
	}

	public void CureDependPokeSick(byte pokeID, byte causePokeID)
	{
	}

	public void SetActionRecord(byte pokeID, ActionRecorder.ActionID actionID)
	{
	}

	public void AddWazaDamageRecord(byte defPokeID, byte atkPokeID, BtlPokePos atkPokePos, byte wazaType, WazaDamageType damageType, ushort wazaID, ushort damage)
	{
	}

	public void MemberIn(byte clientID, byte posIdx, byte nextPokeIdx, uint turnCount)
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

	public bool RemoveFieldEffect_DependPoke(byte causedPokeID, EffectType fieldEffect)
	{
		return default(bool);
	}

	public bool SwapSideEffect(BtlSide side1, BtlSide side2, BtlSideEffect effect)
	{
		return default(bool);
	}

	public void AddExp(byte pokeID, uint exp)
	{
	}

	public void AddEffort(byte pokeID, byte hp, byte pow, byte def, byte sp_pow, byte sp_def, byte agi)
	{
	}

	public void AddEffort_G(byte pokeID, byte value)
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

	public void ChangeForm(byte pokeID, byte formNo, bool dontResetFormByOut)
	{
	}

	public void Hensin(byte userID, byte targetID)
	{
	}

	public void SetBaseStatus(byte pokeID, BTL_POKEPARAM.ValueID valueID, ushort value)
	{
	}

	public void SetWeight(byte pokeID, ushort weight)
	{
	}

	public void SwapPokePos(byte clientID, BtlPokePos pos1, BtlPokePos pos2)
	{
	}

	public void UpdateWazaNo(byte pokeID, byte wazaIdx, WazaNo wazaNo, byte ppMax, bool fPermanent)
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

	public void SetSpActPriority(byte pokeID, byte priority)
	{
	}

	public void StartWeather(BtlWeather weather, byte turn, byte turnUpCount, byte causePokeID)
	{
	}

	public void EndWeather()
	{
	}

	public BtlWeather TurnCheckWeather()
	{
		return default(BtlWeather);
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

	public void UpdateIllusion(BTL_CLIENT_ID clientID)
	{
	}

	public void FakeDisable(byte pokeID)
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

	public void StartGMode(byte pokeID)
	{
	}

	public void EndGMode(byte pokeID)
	{
	}

	public void IncGModeTurnCount(byte pokeID)
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

	public void PlayedTalkEvent(byte talkID)
	{
	}

	public void AddEscapeInfo(BTL_CLIENT_ID clientID)
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
}
