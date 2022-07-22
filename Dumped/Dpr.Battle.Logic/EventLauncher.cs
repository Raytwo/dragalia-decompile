using System.Runtime.InteropServices;
using Pml;
using Pml.Battle;
using Pml.PokePara;
using Pml.WazaData;

namespace Dpr.Battle.Logic;

public sealed class EventLauncher
{
	public class SetupParam
	{
		public MainModule pMainModule;

		public EventSystem pEventSystem;

		public BattleEnv pBattleEnv;
	}

	public enum ReactionType
	{
		SV_REACTION_NONE,
		SV_REACTION_DAMAGE,
		SV_REACTION_HP
	}

	private readonly MainModule m_pMainModule;

	private EventSystem m_pEventSystem;

	private BattleEnv m_pBattleEnv;

	private const int FALSE = 0;

	private const int TRUE = 1;

	private static EventVar.Label LABEL_OFFSET(EventVar.Label label, uint i)
	{
		return default(EventVar.Label);
	}

	public EventLauncher([In] ref SetupParam setupParam)
	{
	}

	public WazaNo Event_ChangeGWaza(BTL_POKEPARAM attacker, WazaNo gWaza, WazaNo srcWaza)
	{
		return default(WazaNo);
	}

	public void Event_GetWazaParam(WazaNo waza, WazaNo orgWaza, WazaNo gSrcWaza, int wazaPri, BTL_POKEPARAM attacker, WazaParam param)
	{
	}

	public bool Event_CheckMigawariThrew(BTL_POKEPARAM attacker, BTL_POKEPARAM defender, WazaNo waza)
	{
		return default(bool);
	}

	public bool Event_CheckCritical(BTL_POKEPARAM attacker, BTL_POKEPARAM defender, WazaNo waza, ref bool pByFriendship)
	{
		return default(bool);
	}

	public bool Event_CalcDamage(BTL_POKEPARAM attacker, BTL_POKEPARAM defender, WazaParam wazaParam, TypeAffinity.AffinityID typeAff, int targetDmgRatio, bool isCritical, bool isRandDisable, bool isMigawariExist, BtlWeather defLocalWeather, out ushort dstDamage)
	{
		return default(bool);
	}

	public BtlWeather Event_GetWeather()
	{
		return default(BtlWeather);
	}

	public BtlWeather Event_CheckLocalWeather(byte pokeID, BtlWeather weather)
	{
		return default(BtlWeather);
	}

	public ushort Event_getWazaPower(BTL_POKEPARAM attacker, BTL_POKEPARAM defender, WazaParam wazaParam)
	{
		return default(ushort);
	}

	public ushort Event_getAttackPower(BTL_POKEPARAM attacker, BTL_POKEPARAM defender, WazaParam wazaParam, bool isCritical, out bool isYakedoDisable)
	{
		return default(ushort);
	}

	public BTL_POKEPARAM.ValueID Event_getAttackerPowerVID(BTL_POKEPARAM attacker, WazaParam wazaParam)
	{
		return default(BTL_POKEPARAM.ValueID);
	}

	public bool shouldAttackerPowerFlat(BTL_POKEPARAM attacker, BTL_POKEPARAM.ValueID vid, bool isCritical)
	{
		return default(bool);
	}

	public ushort Event_getDefenderGuard(BTL_POKEPARAM attacker, BTL_POKEPARAM defender, WazaParam wazaParam, bool isCritical)
	{
		return default(ushort);
	}

	public int Event_CalcTypeMatchRatio(BTL_POKEPARAM attacker, byte waza_type)
	{
		return default(int);
	}

	public TypeAffinity.AffinityID Event_CheckDamageAffinity([In] ref BTL_POKEPARAM attacker, [In] ref BTL_POKEPARAM defender, byte wazaType, bool onlyAttacker)
	{
		return default(TypeAffinity.AffinityID);
	}

	public TypeAffinity.AffinityID Event_CheckDamageAffinity([In] ref BTL_POKEPARAM attacker, [In] ref BTL_POKEPARAM defender, byte waza_type, byte defenderType, bool onlyAttacker)
	{
		return default(TypeAffinity.AffinityID);
	}

	public TypeAffinity.AffinityID Event_RewriteWazaAffinity(BTL_POKEPARAM attacker, BTL_POKEPARAM defender, byte wazaType, TypeAffinity.AffinityID affinity)
	{
		return default(TypeAffinity.AffinityID);
	}

	public bool Event_CheckFloating(BTL_POKEPARAM poke, bool isIncludeHikouType)
	{
		return default(bool);
	}

	public bool Event_AffineFloatingCancel(BTL_POKEPARAM attacker, BTL_POKEPARAM defender)
	{
		return default(bool);
	}

	public uint Event_CalcKickBack(BTL_POKEPARAM attacker, WazaNo waza, uint inDamage, out bool isMustEnable)
	{
		return default(uint);
	}

	public bool Event_CheckEnableSimpleDamage(BTL_POKEPARAM bpp, uint damage, DamageCause damageCause)
	{
		return default(bool);
	}

	public void Event_SimpleDamage_Before([In] ref BTL_POKEPARAM bpp, uint damage)
	{
	}

	public void Event_SimpleDamage_After([In] ref BTL_POKEPARAM bpp, uint damage)
	{
	}

	public bool Event_CheckIchigeki(ref bool pIsFailMsgDisplayed, BTL_POKEPARAM attacker, BTL_POKEPARAM defender, WazaParam wazaParam)
	{
		return default(bool);
	}

	public uint Event_getHitPer(EventID eventID, BTL_POKEPARAM attacker, BTL_POKEPARAM defender, WazaParam wazaParam)
	{
		return default(uint);
	}

	public bool Event_CheckIchigekiGuard(BTL_POKEPARAM attacker, BTL_POKEPARAM defender, WazaParam wazaParam)
	{
		return default(bool);
	}

	public void Event_IchigekiSucceed(BTL_POKEPARAM attacker, BTL_POKEPARAM target)
	{
	}

	public bool Event_SkipNigeruCalc(BTL_POKEPARAM bpp)
	{
		return default(bool);
	}

	public void Event_ChangePokeBefore(BTL_POKEPARAM bpp)
	{
	}

	public void Event_ChangeTokuseiAfter(byte pokeID)
	{
	}

	public void Event_WazaExeEnd_Common(byte pokeID, WazaNo waza, [In] ref ActionDesc actionDesc, EventID eventID)
	{
	}

	public void Event_GetWazaRankEffectValue(WazaNo waza, uint waza_effect_index, BTL_POKEPARAM attacker, BTL_POKEPARAM target, out WazaRankEffect effect, out int volume)
	{
	}

	public void Event_WazaRankEffectFixed(BTL_POKEPARAM target, WazaNo wazaID, WazaRankEffect effectID, int volume)
	{
	}

	public void Event_RankEffect_Failed(BTL_POKEPARAM target, uint wazaRankEffSerial)
	{
	}

	public bool Event_CheckRankEffectSuccess(BTL_POKEPARAM target, WazaRankEffect effect, byte wazaUsePokeID, int volume, RankEffectCause cause, uint wazaRankEffSerial)
	{
		return default(bool);
	}

	public int Event_RankValueChange(BTL_POKEPARAM target, WazaRankEffect rankType, byte wazaUsePokeID, ushort itemID, int volume)
	{
		return default(int);
	}

	public void Event_RankEffect_Fix(byte atkPokeID, BTL_POKEPARAM bpp, WazaRankEffect rankType, int volume)
	{
	}

	public bool Event_CheckRankEffectReflect(BTL_POKEPARAM target, byte wazaUsePokeID, WazaRankEffect effect, int volume, RankEffectCause cause)
	{
		return default(bool);
	}

	public void Event_RankEffectReflect(BTL_POKEPARAM target, byte wazaUsePokeID, WazaRankEffect effect, int volume)
	{
	}

	public void Event_UnDamageProcEnd(WazaParam wazaParam, BTL_POKEPARAM attacker)
	{
	}

	public void Event_TurnEnd()
	{
	}

	public byte Event_GetWazaPriority(WazaNo waza, BTL_POKEPARAM bpp)
	{
		return default(byte);
	}

	public ushort Event_CalcAgility(BTL_POKEPARAM attacker, bool fTrickRoomEnable)
	{
		return default(ushort);
	}

	public void Event_ActProcStart(PokeAction action)
	{
	}

	public void Event_ActProcEnd(BTL_POKEPARAM bpp, PokeActionCategory actionCmd)
	{
	}

	public void Event_ActProcCanceled(PokeAction action)
	{
	}

	public bool Event_CheckInemuriFail(BTL_POKEPARAM bpp)
	{
		return default(bool);
	}

	public void Event_AfterMove(BTL_POKEPARAM bpp)
	{
	}

	public bool Event_CheckNigeruForbid(BTL_POKEPARAM bpp)
	{
		return default(bool);
	}

	public bool Event_NigeruExMessage(BTL_POKEPARAM bpp)
	{
		return default(bool);
	}

	public void Event_AfterMemberIn(BTL_POKEPARAM bpp, EventID eventID)
	{
	}

	public void Event_AfterMemberInForce(BTL_POKEPARAM bpp, EventID eventID)
	{
	}

	public void Event_AfterMemberInComp()
	{
	}

	public void Event_DasshutuPackLaunch()
	{
	}

	public void Event_MemberOutFixed(BTL_POKEPARAM outPoke)
	{
	}

	public void Event_ReplaceActWaza(BTL_POKEPARAM attacker, WazaNo originWaza, WazaNo nextWaza)
	{
	}

	public void Event_AfterWazaParamFixed(BTL_POKEPARAM attacker, WazaNo orgWazaID, WazaNo actWazaID)
	{
	}

	public void Event_CheckCombiWazaExe(BTL_POKEPARAM attacker, WazaParam wazaParam)
	{
	}

	public void Event_WazaCallDecide(BTL_POKEPARAM attacker, WazaParam wazaParamOrg, WazaParam wazaParamAct)
	{
	}

	public void Event_WazaExeDecide(BTL_POKEPARAM attacker, WazaParam wazaParam, EventID evType)
	{
	}

	public void Event_CheckDelayWazaSet([In] ref BTL_POKEPARAM attacker, ref BtlPokePos targetPos, out bool isTried, out bool isSuccessed)
	{
	}

	public void Event_DecideDelayWaza([In] ref BTL_POKEPARAM attacker)
	{
	}

	public void Event_StartWazaSeq(BTL_POKEPARAM attacker, WazaNo waza)
	{
	}

	public void Event_EndWazaSeq(BTL_POKEPARAM attacker, WazaNo waza, bool fWazaEnable, ActionDesc actionDesc)
	{
	}

	public void Event_WazaRob(BTL_POKEPARAM robPoke, BTL_POKEPARAM orgAtkPoke, WazaNo waza)
	{
	}

	public void Event_WazaReflect(BTL_POKEPARAM robPoke, BTL_POKEPARAM orgAtkPoke, WazaNo waza)
	{
	}

	public bool Event_CheckWazaRob(BTL_POKEPARAM attacker, WazaNo waza, PokeSet targetRec, ref byte robberPokeID, ref byte robTargetPokeID)
	{
		return default(bool);
	}

	public bool Event_IsRemoveAllFailCancel(BTL_POKEPARAM attacker, WazaParam wazaParam)
	{
		return default(bool);
	}

	public bool Event_WazaAffineCheckEnable(WazaParam wazaParam, BTL_POKEPARAM attacker)
	{
		return default(bool);
	}

	public void Event_checkNoEffectBySideEffectGuard_Begin(WazaParam wazaParam, BTL_POKEPARAM attacker, PokeSet targets)
	{
	}

	public void Event_checkNoEffectBySideEffectGuard_End(WazaParam wazaParam, BTL_POKEPARAM attacker, PokeSet targets)
	{
	}

	public void Event_MamoruSuccess(BTL_POKEPARAM attacker, BTL_POKEPARAM target, WazaParam wazaParam)
	{
	}

	public void Event_CheckNotEffect(WazaParam wazaParam, BTL_POKEPARAM attacker, BTL_POKEPARAM defender, DmgAffRec affinityRecorder, EventID eventID, out bool isNoEffect, out bool isNoReaction, out bool isNoEffectMessageDisplayed, out bool isTokuseiWindowDisplay, StrParam customMessage)
	{
	}

	public bool Event_SkipAvoidCheck(BTL_POKEPARAM attacker, BTL_POKEPARAM defender, WazaParam wazaParam)
	{
		return default(bool);
	}

	public bool Event_CheckHit(BTL_POKEPARAM attacker, BTL_POKEPARAM defender, WazaParam wazaParam, out bool bFriendshipActive)
	{
		return default(bool);
	}

	public void Event_WazaAvoid(BTL_POKEPARAM attacker, bool fDelayAttack)
	{
	}

	public bool Event_Check_FreeFallStart_Guard(BTL_POKEPARAM attacker, BTL_POKEPARAM target, WazaParam wazaParam, StrParam strParam)
	{
		return default(bool);
	}

	public void Event_TameReleaseFailed(BTL_POKEPARAM attacker, PokeSet targetRec, WazaParam wazaParam)
	{
	}

	public bool Event_ExeFailThrew(BTL_POKEPARAM bpp, WazaNo waza, WazaFailCause cause)
	{
		return default(bool);
	}

	public WazaFailCause Event_CheckWazaExecute(BTL_POKEPARAM attacker, WazaNo waza, EventID eventID, WazaParam wazaParam, PokeSet targets)
	{
		return default(WazaFailCause);
	}

	public bool Event_IsWazaMeltMustFail(BTL_POKEPARAM attacker, WazaNo waza)
	{
		return default(bool);
	}

	public uint Event_DecrementPPVolume(BTL_POKEPARAM attacker, byte wazaIdx, WazaNo waza, PokeSet rec)
	{
		return default(uint);
	}

	public bool Event_CheckAttackerDeadPreTarget(BTL_POKEPARAM attacker, WazaParam wazaParam)
	{
		return default(bool);
	}

	public void Event_WazaDamageDetermine(BTL_POKEPARAM attacker, BTL_POKEPARAM defender, WazaParam wazaParam)
	{
	}

	public KoraeruCause Event_CheckKoraeru(BTL_POKEPARAM attacker, BTL_POKEPARAM defender, bool isWazaDamage, ref ushort damage)
	{
		return default(KoraeruCause);
	}

	public void Event_KoraeruExe(BTL_POKEPARAM poke, KoraeruCause cause)
	{
	}

	public void Event_WazaDamageSideAfter(BTL_POKEPARAM attacker, WazaParam wazaParam, uint damage)
	{
	}

	public void Event_CheckItemReaction(BTL_POKEPARAM bpp, byte reactionType)
	{
	}

	public void Event_DamageProcStart(BTL_POKEPARAM attacker, WazaParam wazaParam, PokeSet targets)
	{
	}

	public void Event_DamageProcEndSub(BTL_POKEPARAM attacker, PokeSet targets, ActionDesc actionDesc, WazaParam wazaParam, bool fDelayAttack, bool fRealHitOnly, EventID eventID)
	{
	}

	public void Event_DamageProcEnd(BTL_POKEPARAM attacker, PokeSet targets, WazaParam wazaParam, bool fDelayAttack)
	{
	}

	public void Event_SimpleDamage_Failed([In] ref BTL_POKEPARAM bpp, DamageCause damageCause, byte damageCausePokeID)
	{
	}

	public bool Event_CheckItemEquipFail(BTL_POKEPARAM bpp, ushort itemID)
	{
		return default(bool);
	}

	public void Event_AfterItemEquip(BTL_POKEPARAM bpp, ushort itemID, bool bCheckKinomi)
	{
	}

	public void Event_KillHandler(BTL_POKEPARAM target, byte atkPokeID)
	{
	}

	public WazaSick Event_CheckWazaAddSick(WazaNo waza, BTL_POKEPARAM attacker, BTL_POKEPARAM defender, out BTL_SICKCONT pSickCont)
	{
		return default(WazaSick);
	}

	public uint Event_CheckSpecialWazaAdditionalPer(byte atkPokeID, byte defPokeID, uint defaultPer)
	{
		return default(uint);
	}

	public void Event_CheckRecoverMsgCustom(StrParam pCustomMsg, BTL_POKEPARAM pAttacker, BTL_POKEPARAM pTarget, WazaNo wazano)
	{
	}

	public void Event_GetWazaSickAddStr(WazaSick sick, BTL_POKEPARAM attacker, BTL_POKEPARAM defender, StrParam str)
	{
	}

	public void Event_WazaSickCont(BTL_POKEPARAM attacker, BTL_POKEPARAM target, WazaSick sick, BTL_SICKCONTOBJ sickCont)
	{
	}

	public bool Event_CheckAddSickFailStdSkip(BTL_POKEPARAM target, BTL_POKEPARAM attacker, WazaSick sick, SickCause cause)
	{
		return default(bool);
	}

	public bool Event_WazaSick_CheckFail(BTL_POKEPARAM attacker, BTL_POKEPARAM target, WazaSick sick, SickCause cause, ref bool bCallFailedEvent)
	{
		return default(bool);
	}

	public void Event_AddSick_Failed(BTL_POKEPARAM target, BTL_POKEPARAM attacker, WazaSick sick, SickCause cause, uint wazaSerial)
	{
	}

	public void Event_PokeSickFixed(BTL_POKEPARAM target, BTL_POKEPARAM attacker, Sick sick, BTL_SICKCONT inSickCont)
	{
	}

	public void Event_WazaSickFixed(BTL_POKEPARAM target, BTL_POKEPARAM attacker, WazaSick sick)
	{
	}

	public bool Event_CheckKodawariFactorExist(BTL_POKEPARAM poke)
	{
		return default(bool);
	}

	public void Event_TokuseiDisabled(BTL_POKEPARAM target)
	{
	}

	public bool Event_CheckAddRankEffectOccur(WazaParam wazaParam, BTL_POKEPARAM attacker, BTL_POKEPARAM target)
	{
		return default(bool);
	}

	public ushort Event_CheckPushOutEffectNo(BTL_POKEPARAM attacker, WazaNo waza)
	{
		return default(ushort);
	}

	public void Event_CheckPushOutFail(out bool isFailed, out bool isFailMessageDisplayed, BTL_POKEPARAM attacker, BTL_POKEPARAM target)
	{
	}

	public byte Event_WazaWeatherTurnUp(BtlWeather weather, BTL_POKEPARAM attacker)
	{
		return default(byte);
	}

	public bool Event_CheckChangeWeather(BtlWeather weather, ref byte turn)
	{
		return default(bool);
	}

	public void Event_ChangeGroundBefore(byte pokeID, byte ground, ref BTL_SICKCONT contParam)
	{
	}

	public void Event_ChangeGroundAfter(byte pokeID, byte ground)
	{
	}

	public bool Event_FieldEffectCall(BTL_POKEPARAM attacker, WazaNo waza)
	{
		return default(bool);
	}

	public void Event_ChangeFieldAfter(byte pokeID, EffectType field)
	{
	}

	public void Event_WazaDamageReaction(BTL_POKEPARAM attacker, BTL_POKEPARAM defender, WazaParam wazaParam, TypeAffinity.AffinityID aff, uint damage, bool fCritical, bool fMigawari)
	{
	}

	public bool Event_UnCategoryWaza(WazaParam wazaParam, BTL_POKEPARAM attacker, PokeSet targets, out bool fFailMsgEnable)
	{
		return default(bool);
	}

	public void Event_TurnCheck(byte pokeID, EventID event_type)
	{
	}

	public uint Event_SickDamage(BTL_POKEPARAM bpp, WazaSick sickID, uint damage)
	{
		return default(uint);
	}

	public int Event_CheckWeatherReaction(BTL_POKEPARAM bpp, BtlWeather weather, uint damage)
	{
		return default(int);
	}

	public void Event_PokeDeadActionAfter(byte deadPokeID)
	{
	}

	public void Event_PokeDeadAfter(byte deadPokeID)
	{
	}

	public void Event_BeforeDead(BTL_POKEPARAM bpp)
	{
	}

	public void Event_AfterCritical(WazaParam wazaParam, BTL_POKEPARAM attacker, BTL_POKEPARAM defender)
	{
	}

	public bool Event_GetReqWazaParam(BTL_POKEPARAM attacker, WazaNo orgWazaId, BtlPokePos orgTargetPos, REQWAZA_WORK reqWaza)
	{
		return default(bool);
	}

	public byte Event_CheckSpecialActPriority(BTL_POKEPARAM attacker)
	{
		return default(byte);
	}

	public void Event_BeforeFight(BTL_POKEPARAM bpp, WazaNo waza)
	{
	}

	public void Event_FixConfDamage(BTL_POKEPARAM poke, ref ushort damage)
	{
	}

	public void Event_ConfDamageReaction(BTL_POKEPARAM attacker, BTL_POKEPARAM defender)
	{
	}

	public bool Event_CheckWazaMsgCustom(BTL_POKEPARAM attacker, WazaNo orgWazaID, WazaNo actWazaID, StrParam str)
	{
		return default(bool);
	}

	public void Event_CheckWazaExeFail(BTL_POKEPARAM bpp, WazaNo waza, WazaFailCause cause)
	{
	}

	public WazaForceEnableMode Event_WazaExecuteStart(ActionDesc actionDesc, BTL_POKEPARAM attacker, WazaParam wazaParam, PokeSet rec, WazaEffectParams pWazaEffectParams)
	{
		return default(WazaForceEnableMode);
	}

	public bool Event_CheckMamoruBreak(BTL_POKEPARAM attacker, BTL_POKEPARAM defender, WazaNo waza)
	{
		return default(bool);
	}

	public bool Event_CheckTameFail(BTL_POKEPARAM attacker, PokeSet targetRec)
	{
		return default(bool);
	}

	public bool Event_CheckTameTurnSkip(BTL_POKEPARAM attacker, WazaNo waza)
	{
		return default(bool);
	}

	public bool Event_TameStart(BTL_POKEPARAM attacker, PokeSet targetRec, WazaParam wazaParam, ref byte hideTargetPokeID, ref bool fFailMsgDisped)
	{
		return default(bool);
	}

	public void Event_TameStartFixed(BTL_POKEPARAM attacker)
	{
	}

	public void Event_TameSkip(BTL_POKEPARAM attacker, WazaNo waza)
	{
	}

	public bool Event_TameRelease(BTL_POKEPARAM attacker, PokeSet rec, WazaNo waza)
	{
		return default(bool);
	}

	public bool Event_CheckPokeHideAvoid(BTL_POKEPARAM attacker, BTL_POKEPARAM defender, WazaNo waza, ref bool bEnableAvoidMsg)
	{
		return default(bool);
	}

	public bool Event_IsCalcHitCancel(BTL_POKEPARAM attacker, BTL_POKEPARAM defender, WazaNo waza)
	{
		return default(bool);
	}

	public bool Event_CheckDmgToRecover(BTL_POKEPARAM attacker, BTL_POKEPARAM defender, WazaParam wazaParam)
	{
		return default(bool);
	}

	public void Event_DmgToRecover(BTL_POKEPARAM attacker, BTL_POKEPARAM defender)
	{
	}

	public bool Event_CheckKinomiEffectUp(BTL_POKEPARAM poke, out bool pNeedTokuseiWindowDisplayOnItemUseAct)
	{
		return default(bool);
	}

	public bool Event_CheckKinomiEffectUp(BTL_POKEPARAM poke)
	{
		return default(bool);
	}

	public bool Event_ItemEquip(BTL_POKEPARAM poke, out bool pNeedTokuseiWindowDisplayOnItemUseAct, out bool pNeedToConsumeItemMessageDisplay)
	{
		return default(bool);
	}

	public bool Event_ItemEquipTmp(BTL_POKEPARAM target, byte atkPokeID, out bool pNeedTokuseiWindowDisplayOnItemUseAct)
	{
		return default(bool);
	}

	public bool Event_WazaNoEffectByFlying(BTL_POKEPARAM poke)
	{
		return default(bool);
	}

	public bool Event_DecrementPP_Reaction(BTL_POKEPARAM attacker, byte wazaIdx)
	{
		return default(bool);
	}

	public void Event_HitCheckParam(BTL_POKEPARAM attacker, WazaNo waza, HITCHECK_PARAM param, bool fDelayAttack)
	{
	}

	public uint Event_GetWazaShrinkPer(WazaNo waza, BTL_POKEPARAM attacker)
	{
		return default(uint);
	}

	public bool Event_CheckShrink(BTL_POKEPARAM target, uint percentage)
	{
		return default(bool);
	}

	public void Event_FailShrink(BTL_POKEPARAM target)
	{
	}

	public ushort Event_RecalcDrainVolume(BTL_POKEPARAM attacker, BTL_POKEPARAM target, ushort volume)
	{
		return default(ushort);
	}

	public void Event_AfterChangeWeather(BtlWeather weather)
	{
	}

	public uint Event_CalcWazaRecoverHP(BTL_POKEPARAM attacker, BTL_POKEPARAM target, WazaNo waza)
	{
		return default(uint);
	}

	public bool Event_CheckItemSet(BTL_POKEPARAM bpp, ushort itemID)
	{
		return default(bool);
	}

	public void Event_ItemSetFailed(BTL_POKEPARAM bpp)
	{
	}

	public void Event_ItemSetDecide(BTL_POKEPARAM bpp, ushort nextItemID)
	{
	}

	public void Event_ItemSetFixed(BTL_POKEPARAM bpp)
	{
	}

	public void Event_ChangeTokuseiBefore(byte pokeID, TokuseiNo prev_tokuseiID, ushort next_tokuseiID)
	{
	}

	public void Event_CheckSideEffectParam(byte userPokeID, BtlSideEffect effect, BtlSide side, BTL_SICKCONTOBJ cont)
	{
	}

	public void Event_NotifyAirLock()
	{
	}

	public bool Event_CheckTokuseiChangeEnable(byte targetPokeID, TokuseiNo nextTokusei, TokuseiChangeCause cause)
	{
		return default(bool);
	}

	public void Event_TokuseiChangeFailed(byte targetPokeID, TokuseiNo nextTokusei, TokuseiChangeCause cause)
	{
	}

	public byte Event_GetWazaTargetIntr(BTL_POKEPARAM attacker, WazaParam wazaParam)
	{
		return default(byte);
	}

	public bool Event_CheckWazaTargetTemptEnable(BTL_POKEPARAM attacker, [In] ref bool enable)
	{
		return default(bool);
	}

	public byte Event_GetWazaTargetTempt(BTL_POKEPARAM attacker, WazaParam wazaParam, byte defaultTargetPokeID, out TemptTargetCause outTemptCause)
	{
		return default(byte);
	}

	public void Event_WazaTargetTemptEnd(BTL_POKEPARAM attacker, ushort temptPokeId, WazaParam wazaParam, TemptTargetCause temptCause)
	{
	}

	public int svEvent_GetWeightRatio(BTL_POKEPARAM bpp)
	{
		return default(int);
	}

	public bool Event_CheckAimTargetEnable(BTL_POKEPARAM attacker, WazaParam wazaParam)
	{
		return default(bool);
	}

	public bool Event_CheckWazaTargetIncrease(BTL_POKEPARAM attacker, BTL_POKEPARAM defender, BTL_POKEPARAM target)
	{
		return default(bool);
	}

	public bool Event_CheckHitCountMessageDisplay(BTL_POKEPARAM attacker)
	{
		return default(bool);
	}

	private bool perOccur(byte per, out byte rnd)
	{
		return default(bool);
	}
}
