using System.Runtime.InteropServices;
using Pml;
using Pml.PokePara;
using Pml.WazaData;

namespace Dpr.Battle.Logic;

public static class Common
{
	private const int FALSE = 0;

	private const int TRUE = 1;

	internal static ushort[] SortTargetsByAgility_rank;

	public static int GetEventVar([In] ref EventFactor.EventHandlerArgs args, EventVar.Label label)
	{
		return default(int);
	}

	public static WazaFailCause GetEventVar_FAIL_CAUSE([In] ref EventFactor.EventHandlerArgs args)
	{
		return default(WazaFailCause);
	}

	public static WazaDamageType GetEventVar_DAMAGE_TYPE([In] ref EventFactor.EventHandlerArgs args)
	{
		return default(WazaDamageType);
	}

	public static bool RewriteEventVar([In] ref EventFactor.EventHandlerArgs args, EventVar.Label label, int value)
	{
		return default(bool);
	}

	public static bool RewriteEventVar_FAIL_CAUSE([In] ref EventFactor.EventHandlerArgs args, WazaFailCause value)
	{
		return default(bool);
	}

	public static void MulEventVar([In] ref EventFactor.EventHandlerArgs args, EventVar.Label label, int value)
	{
	}

	public static bool GetEventVarIfExist([In] ref EventFactor.EventHandlerArgs args, EventVar.Label label, out int value)
	{
		return default(bool);
	}

	public static object GetEventVarAddress([In] ref EventFactor.EventHandlerArgs args, EventVar.Label label)
	{
		return null;
	}

	public static ushort GetSubID([In] ref EventFactor.EventHandlerArgs args)
	{
		return default(ushort);
	}

	public static int GetWorkValue([In] ref EventFactor.EventHandlerArgs args, byte workIdx)
	{
		return default(int);
	}

	public static void SetWorkValue([In] ref EventFactor.EventHandlerArgs args, byte workIdx, int value)
	{
	}

	public static void RemoveFactor([In] ref EventFactor.EventHandlerArgs args)
	{
	}

	public static BTL_POKEPARAM GetPokeParam([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
		return null;
	}

	public static byte GetExistPokeID([In] ref EventFactor.EventHandlerArgs args, BtlPokePos pos)
	{
		return default(byte);
	}

	public static byte GetMyAddCounter([In] ref EventFactor.EventHandlerArgs args, BtlSide side)
	{
		return default(byte);
	}

	public static byte GetWeatherCausePokeID([In] ref EventFactor.EventHandlerArgs args)
	{
		return default(byte);
	}

	public static BtlRule GetRule([In] ref EventFactor.EventHandlerArgs args)
	{
		return default(BtlRule);
	}

	public static BtlSide PokeIDtoSide([In] ref EventFactor.EventHandlerArgs args, [In] ref byte pokeID)
	{
		return default(BtlSide);
	}

	public static BtlSide PokeIDtoSide([In] ref EventFactor.EventHandlerArgs args, [In] ref EventVar.Label label)
	{
		return default(BtlSide);
	}

	public static BtlSide PokeIDtoOpponentSide([In] ref EventFactor.EventHandlerArgs args, [In] ref byte pokeID)
	{
		return default(BtlSide);
	}

	public static BtlSide GetOpponentSide([In] ref EventFactor.EventHandlerArgs args, BtlSide side)
	{
		return default(BtlSide);
	}

	public static bool IsFriendPokeID([In] ref EventFactor.EventHandlerArgs args, byte pokeID1, byte pokeID2)
	{
		return default(bool);
	}

	public static bool IsFriendPokeID([In] ref EventFactor.SkipCheckHandlerArgs args, byte pokeID1, byte pokeID2)
	{
		return default(bool);
	}

	public static BtlGround GetGround([In] ref EventFactor.EventHandlerArgs args)
	{
		return default(BtlGround);
	}

	public static BTL_FIELD_SITUATION GetFieldSituation([In] ref EventFactor.EventHandlerArgs args)
	{
		return null;
	}

	public static void AttachSkipCheckHandler([In] ref EventFactor.EventHandlerArgs args, [In] ref EventFactor.SkipCheckHandler handler)
	{
	}

	public static void DetachSkipCheckHandler([In] ref EventFactor.EventHandlerArgs args)
	{
	}

	public static BtlPokePos GetPokeLastPos([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
		return default(BtlPokePos);
	}

	public static byte GetFrontPokeID([In] ref EventFactor.EventHandlerArgs args, [In] ref BtlPokePos pos)
	{
		return default(byte);
	}

	public static BtlPokePos PokeIDtoPokePos([In] ref EventFactor.EventHandlerArgs args, [In] ref byte pokeID)
	{
		return default(BtlPokePos);
	}

	public static byte GetTurnCount([In] ref EventFactor.EventHandlerArgs args)
	{
		return default(byte);
	}

	public static PosEffect.EffectParam GetEffectParam([In] ref EventFactor.EventHandlerArgs args, [In] ref BtlPokePos pos, [In] ref BtlPosEffect posEffect)
	{
		return default(PosEffect.EffectParam);
	}

	public static PokeAction SearchByPokeID([In] ref EventFactor.EventHandlerArgs args, byte pokeID, bool isSkipGStart, bool isSkipNull = false)
	{
		return null;
	}

	public static WazaRec GetWazaRec([In] ref EventFactor.EventHandlerArgs args)
	{
		return null;
	}

	public static BtlCompetitor GetCompetitor([In] ref EventFactor.EventHandlerArgs args)
	{
		return default(BtlCompetitor);
	}

	public static bool IsPlayerSide([In] ref EventFactor.EventHandlerArgs args, [In] ref BtlSide side)
	{
		return default(bool);
	}

	public static bool GetSetupStatusFlag([In] ref EventFactor.EventHandlerArgs args, [In] ref BTL_STATUS_FLAG flag)
	{
		return default(bool);
	}

	public static bool CheckWazaEffectEnable([In] ref EventFactor.EventHandlerArgs args)
	{
		return default(bool);
	}

	public static bool CheckFieldEffect([In] ref EventFactor.EventHandlerArgs args, [In] ref EffectType effType)
	{
		return default(bool);
	}

	public static bool IsExistBenchPoke([In] ref EventFactor.EventHandlerArgs args, [In] ref byte pokeID)
	{
		return default(bool);
	}

	public static void SetRecallEnable([In] ref EventFactor.EventHandlerArgs args)
	{
	}

	public static bool IsExistPokeChangeRequest([In] ref EventFactor.EventHandlerArgs args)
	{
		return default(bool);
	}

	public static bool IsExistPoke([In] ref EventFactor.EventHandlerArgs args, [In] ref byte pokeID)
	{
		return default(bool);
	}

	public static bool IsAllActDoneByPokeID([In] ref EventFactor.EventHandlerArgs args, [In] ref byte pokeID)
	{
		return default(bool);
	}

	public static void ConvertForIsolate([In] ref EventFactor.EventHandlerArgs args)
	{
	}

	public static bool TokuseiWindow_In([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
		return default(bool);
	}

	public static bool TokuseiWindow_Out([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
		return default(bool);
	}

	public static bool RecoverHP([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_RecoverHP.Description desc)
	{
		return default(bool);
	}

	public static bool DrainHp([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_DrainHP.Description desc)
	{
		return default(bool);
	}

	public static bool Damage([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_Damage.Description desc)
	{
		return default(bool);
	}

	public static bool ShiftHP([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_ShiftHP.Description desc)
	{
		return default(bool);
	}

	public static bool RecoverPP([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_RecoverPP.Description desc)
	{
		return default(bool);
	}

	public static bool DecrementPP([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_DecrementPP.Description desc)
	{
		return default(bool);
	}

	public static bool CureSick([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_CureSick.Description desc)
	{
		return default(bool);
	}

	public static bool CanAddSick([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_AddSickCheckFail.Description desc)
	{
		return default(bool);
	}

	public static bool AddSick([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_AddSick.Description desc)
	{
		return default(bool);
	}

	public static bool AddSick_Kodawari([In] ref EventFactor.EventHandlerArgs args, byte targetID, WazaNo actWazaNo, WazaNo orgWazaNo)
	{
		return default(bool);
	}

	public static bool RankEffect([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_RankEffect.Description desc)
	{
		return default(bool);
	}

	public static bool RankSet([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_RankSet.Description desc)
	{
		return default(bool);
	}

	public static bool RankReset([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_RankReset.Description desc)
	{
		return default(bool);
	}

	public static bool RankFlat_Recover([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_RankFlat_Recover.Description desc)
	{
		return default(bool);
	}

	public static bool RankFlat_Weaken([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_RankFlat_Weaken.Description desc)
	{
		return default(bool);
	}

	public static bool SetPower([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_SetPower.Description desc)
	{
		return default(bool);
	}

	public static bool Kill([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_Kill.Description desc)
	{
		return default(bool);
	}

	public static bool ChangeType([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_ChangePokeType.Description desc)
	{
		return default(bool);
	}

	public static bool ExtendType([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_ExtendPokeType.Description desc)
	{
		return default(bool);
	}

	public static void Message([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_Message.Description desc)
	{
	}

	public static bool SetTurnFlag([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_SetTurnFlag.Description desc)
	{
		return default(bool);
	}

	public static bool ResetTurnFlag([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_ResetTurnFlag.Description desc)
	{
		return default(bool);
	}

	public static bool SetContFlag([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_SetContFlag.Description desc)
	{
		return default(bool);
	}

	public static bool ResetContFlag([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_ResetContFlag.Description desc)
	{
		return default(bool);
	}

	public static void SetPermFlag([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_SetPermFlag.Description desc)
	{
	}

	public static bool AddSideEffect([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_SideEffect_Add.Description desc)
	{
		return default(bool);
	}

	public static bool RemoveSideEffect([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_SideEffect_Remove.Description desc)
	{
		return default(bool);
	}

	public static bool SleepSideEffect([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_SideEffect_Sleep.Description desc)
	{
		return default(bool);
	}

	public static bool SwapSideEffect([In] ref EventFactor.EventHandlerArgs args, BtlSide side1, BtlSide side2, Section_SideEffect_Swap.SidefEffectSwapCheck check)
	{
		return default(bool);
	}

	public static bool AddFieldEffect([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FieldEffect_Add.Description desc)
	{
		return default(bool);
	}

	public static bool RemoveFieldEffect([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_FieldEffect_Remove.Description desc)
	{
		return default(bool);
	}

	public static BtlWeather GetWeather([In] ref EventFactor.EventHandlerArgs args)
	{
		return default(BtlWeather);
	}

	public static BtlWeather GetLocalWeather([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
		return default(BtlWeather);
	}

	public static BtlWeather GetWeather_True([In] ref EventFactor.EventHandlerArgs args)
	{
		return default(BtlWeather);
	}

	public static BtlWeather GetDefaultWeather([In] ref EventFactor.EventHandlerArgs args)
	{
		return default(BtlWeather);
	}

	public static bool ChangeWeather([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_ChangeWeather.Description desc)
	{
		return default(bool);
	}

	public static bool AddPosEffect([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_PosEffect_Add.Description desc)
	{
		return default(bool);
	}

	public static void RemovePosEffect([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_RemovePosEffect.Description desc)
	{
	}

	public static void UpdatePosEffectParam([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_UpdatePosEffectParam.Description desc)
	{
	}

	public static bool ChangeTokusei([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_ChangeTokusei.Description desc)
	{
		return default(bool);
	}

	public static void SkillSwap([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_SkillSwap.Description desc)
	{
	}

	public static bool SetItem([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_SetItem.Description desc)
	{
		return default(bool);
	}

	public static bool SwapItem([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_SwapItem.Description desc)
	{
		return default(bool);
	}

	public static void CheckItemReaction([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_CheckItemReaction.Description desc)
	{
	}

	public static bool UseItem([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_UseItemEquip.Description desc)
	{
		return default(bool);
	}

	public static bool UseItem_Force([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_UseItem_Force.Description desc)
	{
		return default(bool);
	}

	public static void ConsumeItem([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_ConsumeItem.Description desc)
	{
	}

	public static ushort GetTamaHiroiBall([In] ref EventFactor.EventHandlerArgs args)
	{
		return default(ushort);
	}

	public static void UpdateWaza([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_UpdateWaza.Description desc)
	{
	}

	public static void SetPokeCounter([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_SetCounter.Description desc)
	{
	}

	public static bool DelayWazaDamage([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_DelayWazaDamage.Description desc)
	{
		return default(bool);
	}

	public static bool QuitBattle([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_QuitBattle.Description desc)
	{
		return default(bool);
	}

	public static bool MemberChange([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_MemberChange.Description desc)
	{
		return default(bool);
	}

	public static void BattonTouch([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_BattonTouch.Description desc)
	{
	}

	public static bool Shrink([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_Shrink.Description desc)
	{
		return default(bool);
	}

	public static void Relive([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_Relive.Description desc)
	{
	}

	public static void SetWeight([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_SetWeight.Description desc)
	{
	}

	public static bool PushOut([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_PushOut.Description desc)
	{
		return default(bool);
	}

	public static bool InterruptPokeAction([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_InterruptAction.Description desc)
	{
		return default(bool);
	}

	public static bool InterruptPokeAction_ByWaza([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_InterruptAction_ByWaza.Description desc)
	{
		return default(bool);
	}

	public static bool PostponePokeAction([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_PostponeAction.Description desc)
	{
		return default(bool);
	}

	public static bool SwapPoke([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_SwapPoke.Description desc)
	{
		return default(bool);
	}

	public static bool Hensin([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_Hensin.Description desc)
	{
		return default(bool);
	}

	public static bool BreakIllusion([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_BreakIllusion.Description desc)
	{
		return default(bool);
	}

	public static void VanishMessageWindow([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_VanishMessageWindow.Description desc)
	{
	}

	public static bool CancelTameHide([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_TameHideCancel.Description desc)
	{
		return default(bool);
	}

	public static void AddViewEffect([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_AddViewEffect.Description desc)
	{
	}

	public static bool FormChange([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_FormChange.Description desc)
	{
		return default(bool);
	}

	public static void SetWazaEffectIndex([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_SetWazaEffectIndex.Description desc)
	{
	}

	public static void SetWazaEffectEnable([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_SetWazaEffectEnable.Description desc)
	{
	}

	public static void FriendshipEffect([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_FriendshipEffect.Description desc)
	{
	}

	public static bool InsertWazaAction([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_InsertWazaAction.Description desc)
	{
		return default(bool);
	}

	public static bool FreeFallStart([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_FreeFallStart.Description desc)
	{
		return default(bool);
	}

	public static void FreeFallRelease([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FreeFall_Release.Description desc)
	{
	}

	public static void FreeFallAppearTarget([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_AppearFreeFallTarget.Description desc)
	{
	}

	public static bool DeadCheck([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_DeadCheck.Description desc)
	{
		return default(bool);
	}

	public static ushort CalcAgility([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_CalcAgility.Description desc)
	{
		return default(ushort);
	}

	public static byte CalcAgilityOrder([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_CalcAgilityOrder.Description desc)
	{
		return default(byte);
	}

	public static BtlPokePos DecideWazaTargetAuto([In] ref EventFactor.EventHandlerArgs args, byte pokeID, WazaNo wazano)
	{
		return default(BtlPokePos);
	}

	public static bool CheckFloating([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_CheckFloating.Description desc)
	{
		return default(bool);
	}

	public static uint GetWeight([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_GetWeight.Description desc)
	{
		return default(uint);
	}

	public static bool CanForceEscape([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_Escape_CheckForceSucceed.Description desc)
	{
		return default(bool);
	}

	public static void PlayWazaEffect([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_PlayWazaEffect.Description desc)
	{
	}

	public static bool CheckSpecialWazaAdditionalEffectOccur([In] ref EventFactor.EventHandlerArgs args, [In] ref Section_FromEvent_CheckSpecialWazaAdditionalEffectOccur.Description desc)
	{
		return default(bool);
	}

	public static bool CheckTargetPokeID([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
		return default(bool);
	}

	public static byte getTaragetPokeID(EventSystem eventSystem, byte index)
	{
		return default(byte);
	}

	public static bool CheckTargetSide([In] ref EventFactor.EventHandlerArgs args, BtlSide side)
	{
		return default(bool);
	}

	public static bool CheckPokeOrderLast([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
		return default(bool);
	}

	public static bool CheckActionDoneOnce([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
		return default(bool);
	}

	public static bool CheckUnbreakablePokeItem(ushort monsno, ushort itemID)
	{
		return default(bool);
	}

	public static bool CheckCantChangeItemPoke([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
		return default(bool);
	}

	public static bool CheckCantStealWildPoke([In] ref EventFactor.EventHandlerArgs args, byte attackPokeID)
	{
		return default(bool);
	}

	public static bool CheckCantStealPoke([In] ref EventFactor.EventHandlerArgs args, byte attackPokeID, byte targetPokeID)
	{
		return default(bool);
	}

	public static bool CheckTameHidePoke([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
		return default(bool);
	}

	public static void MagicCoat_CheckSideEffWaza([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void MagicCoat_Wait([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void MagicCoat_Reaction([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static void MulWazaBasePower([In] ref EventFactor.EventHandlerArgs args, uint ratio)
	{
	}

	public static void SkipEscapeCalculation([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static bool CheckEscapeExMessage([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
		return default(bool);
	}

	public static uint GetKillCount([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
		return default(uint);
	}

	public static bool Boujin_WeatherReaction([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
		return default(bool);
	}

	public static bool Boujin_WazaNoEffect([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
		return default(bool);
	}

	public static byte GetMezapaType([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
		return default(byte);
	}

	public static bool GuardWazaSick([In] ref EventFactor.EventHandlerArgs args, byte pokeID, WazaSick guardSick)
	{
		return default(bool);
	}

	public static void Dorobou_Start([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static bool Dorobou_CheckEnable([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
		return default(bool);
	}

	public static void SortTargetsByAgility([In] ref EventFactor.EventHandlerArgs args, byte[] targetPokeIDAry, uint targetCount, byte myPokeID, bool bDownFriendPriority)
	{
	}

	public static Sick CheckPokeSick([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
		return default(Sick);
	}

	public static bool CheckSimpleEffectOnlyAdvantage(WazaNo waza)
	{
		return default(bool);
	}

	public static void KonoyubiTomare_TemptTarget([In] ref EventFactor.EventHandlerArgs args, byte konoyubiPokeID, TemptTargetPriority temptPriority, TemptTargetCause temptCause)
	{
	}

	public static void HandCommon_TemptTarget([In] ref EventFactor.EventHandlerArgs args, byte temptPokeID, TemptTargetPriority temptPriority, TemptTargetCause temptCause)
	{
	}

	public static bool Katayaburi_SkipCheck([In] ref EventFactor.SkipCheckHandlerArgs args)
	{
		return default(bool);
	}

	public static bool CheckFreeFallUserPoke([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
		return default(bool);
	}

	public static bool CheckFreeFallPoke([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
		return default(bool);
	}

	public static bool CheckShowDown([In] ref EventFactor.EventHandlerArgs args)
	{
		return default(bool);
	}

	public static bool IsClientExist([In] ref EventFactor.EventHandlerArgs args, BTL_CLIENT_ID clientID)
	{
		return default(bool);
	}

	public static bool IsClientFriends([In] ref EventFactor.EventHandlerArgs args, BTL_CLIENT_ID clientID1, BTL_CLIENT_ID clientID2)
	{
		return default(bool);
	}

	public static BTL_PARTY GetPartyData([In] ref EventFactor.EventHandlerArgs args, BTL_CLIENT_ID clientID)
	{
		return null;
	}

	public static BTL_PARTY GetPartyData([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
		return null;
	}

	public static BTL_PARTY GetFriendPartyData([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
		return null;
	}

	public static BtlPokePos GetFriendPokePos([In] ref EventFactor.EventHandlerArgs args, BtlPokePos basePos, byte idx)
	{
		return default(BtlPokePos);
	}

	public static BtlPokePos GetOpponentPokePos([In] ref EventFactor.EventHandlerArgs args, BtlPokePos basePos, byte idx)
	{
		return default(BtlPokePos);
	}

	public static BtlPokePos GetFacedPokePos([In] ref EventFactor.EventHandlerArgs args, BtlPokePos basePos)
	{
		return default(BtlPokePos);
	}

	public static BtlPokePos GetExistFrontPokePos([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
		return default(BtlPokePos);
	}

	public static bool CheckEvolutionIncompleted([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
		return default(bool);
	}

	public static bool CheckItemUsable([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
		return default(bool);
	}

	public static ushort GetUsableItem([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
		return default(ushort);
	}

	public static byte GetAllOpponentFrontPokeID([In] ref EventFactor.EventHandlerArgs args, byte basePokeID, byte[] dst)
	{
		return default(byte);
	}

	public static byte ExpandExistPokeID([In] ref EventFactor.EventHandlerArgs args, [In] ref ExPokePos exPos, byte[] dst_pokeID)
	{
		return default(byte);
	}

	public static bool CheckChangeEnablePokeExist([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
		return default(bool);
	}

	public static byte GetFightEnableBenchPokeNum([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
		return default(byte);
	}

	public static byte GetMyBenchIndex([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
		return default(byte);
	}

	public static byte GetClientCoverPosCount([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
		return default(byte);
	}

	public static bool AddBonusMoney([In] ref EventFactor.EventHandlerArgs args, uint volume)
	{
		return default(bool);
	}

	public static void SetMoneyDoubleUp([In] ref EventFactor.EventHandlerArgs args, byte pokeID, MoneyDblUpCause cause)
	{
	}

	public static bool CheckMemberOutInterruptActionProceeding([In] ref EventFactor.EventHandlerArgs args)
	{
		return default(bool);
	}

	public static void AddMagicCoatAction([In] ref EventFactor.EventHandlerArgs args, byte pokeID, byte targetPokeID)
	{
	}

	public static void EnableWazaSubEffect([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
	}

	public static bool IsEscapeEnableBattle([In] ref EventFactor.EventHandlerArgs args)
	{
		return default(bool);
	}
}
