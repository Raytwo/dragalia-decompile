using System.Runtime.InteropServices;
using DPData;
using Dpr.Message;
using Pml;
using Pml.Battle;
using Pml.PokePara;
using Pml.WazaData;

namespace Dpr.Battle.Logic;

public class BattleViewBase
{
	public enum BtlvMode : byte
	{
		BATTLE,
		CAPTURE,
		EFFECT_VIEWER
	}

	public enum SelectActMode
	{
		NORMAL,
		FORBID_BAG,
		CHEER
	}

	public enum ButtonMode
	{
		ACTIVE,
		PASSIVE,
		INVISIBLE
	}

	public class SelectActionParam
	{
		public BTL_POKEPARAM pActPoke;

		public byte pokeIndex;

		public bool fReturnable;

		public bool bGEnable;

		public bool isBallShortcutEnable;

		public bool isInfoEnable;

		public ButtonMode buttonMode_Fight;

		public ButtonMode buttonMode_Bag;

		public ButtonMode buttonMode_Pokemon;

		public ButtonMode buttonMode_Escape;

		public ButtonMode buttonMode_Cheer;
	}

	public enum BtlvResult : byte
	{
		NONE,
		DONE,
		CANCEL
	}

	public class ExpGetDescByPoke
	{
		public uint exp;

		public uint effort_hp;

		public uint effort_pow;

		public uint effort_def;

		public uint effort_sp_pow;

		public uint effort_sp_def;

		public uint effort_agi;

		public void Clear()
		{
		}
	}

	public class ExpGetDesc
	{
		public PokeParty iPtrParty;

		public ExpGetDescByPoke[] pokeDesc;

		public void Clear()
		{
		}
	}

	public class ExpGetResult
	{
		public bool isDeviceUpDown;

		public bool[] isLevelUpOccurred;

		public void Clear()
		{
		}
	}

	public enum RecPlayerInput : byte
	{
		NONE,
		REW,
		FF,
		STOP
	}

	public enum RecPlayStopFlag : byte
	{
		NONE,
		KEY,
		BREAK,
		SKIP
	}

	public class SummarizedGShockEffectParam
	{
		public ushort[] effectNo;

		public GShock.Effect gShockEffect;
	}

	public class Raid_SelectBall_Param
	{
		public bool isFlashAnimationEnable;

		public bool isCancelButtonPassive;
	}

	public class Raid_SelectBall_Result
	{
		public bool isThrow;

		public ItemNo itemno;
	}

	public class RaidCaptureParam
	{
		public ItemNo itemno;

		public bool isCaptured;

		public ushort yureCount;
	}

	public class UiDisplayPlayerNameInfo
	{
		public MyStatus pMyStatus;

		public string ipName;

		public string ipNameLabel;

		public Sex gender;

		public MessageEnumData.MsgLangId pokeLanguageID;

		public void Reset()
		{
		}
	}

	public class RaidRewardParam
	{
		public class ItemInfo
		{
			public ItemNo no;

			public uint amount;

			public void Set([In] ref ItemNo itemNo, [In] ref uint _amount)
			{
			}

			public void Reset()
			{
			}

			public bool IsAvailable()
			{
				return default(bool);
			}
		}

		public BTL_POKEPARAM pBPP;

		public uint rank;

		public bool bCaptured;

		public bool bRare;

		public ItemInfo[] itemInfo;

		public void SetItem([In] ref uint index, [In] ref ItemNo itemNo, [In] ref uint amount)
		{
		}

		public void ResetItem([In] ref uint index)
		{
		}

		public void Reset()
		{
		}
	}

	public enum SafariCmd
	{
		Esa,
		Doro,
		Yousumi
	}

	public const uint BTLV_GAUGE_HP_DOTTOMAX = 48u;

	public const uint BTLV_MSGWAIT_NONE = 0u;

	public const uint BTLV_MSGWAIT_AUTO_HIDE = 12u;

	public const uint BTLV_RAIDREWARD_RANK_MIN = 0u;

	public const uint BTLV_RAIDREWARD_RANK_MAX = 5u;

	private MainModule m_pMainModule;

	private BTL_CLIENT m_iPtrClient;

	private BattleEnv m_pBattleEnv;

	private BtlBagMode m_bagMode;

	private MSGSPEED m_msgSpeed;

	private BattleSimulator m_battleSimulator;

	public BattleViewBase(BTLV_INIT_PARAM initParam)
	{
	}

	private void createSimulator()
	{
	}

	public MainModule GetMainModule()
	{
		return null;
	}

	public virtual BattleEnv GetBattleEnv()
	{
		return null;
	}

	public virtual POKECON GetBattleContainer()
	{
		return null;
	}

	public virtual BTL_POKEPARAM GetBattlePokeParam(BtlvPos pos)
	{
		return null;
	}

	public virtual bool GetBattlePokeParam_forUI(BTL_POKEPARAM pDest, BtlvPos vpos)
	{
		return default(bool);
	}

	public virtual PokemonParam GetViewSrcData(BtlvPos vpos)
	{
		return null;
	}

	public virtual BTL_PARTY GetBattleParty_Self()
	{
		return null;
	}

	public virtual BTL_PARTY GetBattleParty_Friend()
	{
		return null;
	}

	public virtual BTL_PARTY GetBattleParty_Enemy(int idx = 0)
	{
		return null;
	}

	public virtual BTL_PARTY GetBattleParty(byte clientID)
	{
		return null;
	}

	public virtual BTL_CLIENT GetClient()
	{
		return null;
	}

	public virtual FieldStatus GetFieldStatus()
	{
		return null;
	}

	public virtual SideEffectStatus GetSideEffectStatus(BtlSide side, BtlSideEffect effect)
	{
		return null;
	}

	public virtual PosEffectStatus GetPosEffectStatus(BtlPokePos pos, BtlPosEffect effect)
	{
		return null;
	}

	public virtual BtlCompetitor GetBattleCompetitor()
	{
		return default(BtlCompetitor);
	}

	public virtual BtlRule GetBattleRule()
	{
		return default(BtlRule);
	}

	public virtual BtlCommMode GetCommMode()
	{
		return default(BtlCommMode);
	}

	public virtual bool IsCommMode()
	{
		return default(bool);
	}

	public virtual bool IsCommChild()
	{
		return default(bool);
	}

	public virtual bool IsMultiMode()
	{
		return default(bool);
	}

	public virtual bool IsPokeExist(BtlvPos pos)
	{
		return default(bool);
	}

	public virtual bool IsFriendExist()
	{
		return default(bool);
	}

	public virtual bool IsClientTrainerExist(byte clientID)
	{
		return default(bool);
	}

	public virtual bool IsWatchMode()
	{
		return default(bool);
	}

	public virtual byte GetClientID()
	{
		return default(byte);
	}

	public virtual byte GetFriendCleintID()
	{
		return default(byte);
	}

	public virtual byte GetEnemyClientID(byte idx)
	{
		return default(byte);
	}

	public virtual byte GetEnemyClientNum(byte clientID)
	{
		return default(byte);
	}

	public virtual bool IsClientNpc(byte idx)
	{
		return default(bool);
	}

	public virtual BtlvPos GetClientIdToBtlvPos(byte clientId, byte pokeIdx = 0)
	{
		return default(BtlvPos);
	}

	public virtual byte GetBtlvPosToClientId(BtlvPos vpos)
	{
		return default(byte);
	}

	public virtual byte GetBtlvPosToPosIdx(BtlvPos vpos)
	{
		return default(byte);
	}

	public virtual byte GetBtlvPosToTrainerIdx(BtlvPos vpos)
	{
		return default(byte);
	}

	public virtual ushort GetTrainerID(byte clientID)
	{
		return default(ushort);
	}

	public virtual ushort GetTrainerType(byte clientID)
	{
		return default(ushort);
	}

	public virtual string GetTrainerModelID(byte clientID)
	{
		return null;
	}

	public virtual int GetTrainerColorID(byte clientID)
	{
		return default(int);
	}

	public virtual string GetTrainerWinEffect(byte clientID)
	{
		return null;
	}

	public virtual string GetTrainerName(byte clientID)
	{
		return null;
	}

	public virtual string GetTrainerNameLabel(byte clientID)
	{
		return null;
	}

	public virtual Sex GetTrainerSex(byte clientID)
	{
		return default(Sex);
	}

	public virtual bool IsClientRatingDisplay()
	{
		return default(bool);
	}

	public virtual ushort GetClientRating(byte clientID)
	{
		return default(ushort);
	}

	public virtual MSGSPEED GetMessageSpeed()
	{
		return default(MSGSPEED);
	}

	public virtual bool IsClientCheerMode(byte clientID)
	{
		return default(bool);
	}

	public virtual byte GetFrontPosCount_Self()
	{
		return default(byte);
	}

	public virtual byte GetFrontPosCount_Friend()
	{
		return default(byte);
	}

	public virtual byte GetBenchPosIndex_Self()
	{
		return default(byte);
	}

	public virtual byte GetBenchPosIndex_Friend()
	{
		return default(byte);
	}

	public virtual bool IsSkyBattle()
	{
		return default(bool);
	}

	public virtual bool IsZukanRegistered(BTL_POKEPARAM bpp)
	{
		return default(bool);
	}

	public virtual bool IsEnableWazaEffect()
	{
		return default(bool);
	}

	public virtual bool IsItemEnable()
	{
		return default(bool);
	}

	public virtual bool GetSetupStatusFlag(BTL_STATUS_FLAG flag)
	{
		return default(bool);
	}

	public virtual bool GetEnableTimeStop()
	{
		return default(bool);
	}

	public virtual bool GetEnableVoiceChat()
	{
		return default(bool);
	}

	public virtual bool IsRecordPlayMode()
	{
		return default(bool);
	}

	public virtual BtlEscapeMode GetEscapeMode()
	{
		return default(BtlEscapeMode);
	}

	public virtual bool CanUseEscapeItem()
	{
		return default(bool);
	}

	public virtual MiseaiData GetMiseaiData(byte clientID)
	{
		return null;
	}

	public virtual uint GetTurnCount()
	{
		return default(uint);
	}

	public virtual bool IsWazaEffectEnable()
	{
		return default(bool);
	}

	public virtual bool IsPlayerInLeftSide()
	{
		return default(bool);
	}

	public virtual BtlvPos BtlPosToViewPos(BtlPokePos pos)
	{
		return default(BtlvPos);
	}

	public virtual BtlPokePos ViewPosToBtlPos(BtlvPos pos)
	{
		return default(BtlPokePos);
	}

	public virtual BtlSide ViewPosToBtlSide(BtlvPos viewPos)
	{
		return default(BtlSide);
	}

	public virtual BtlvPos PokeIDToViewPos(int pos)
	{
		return default(BtlvPos);
	}

	public virtual bool IsPlayerSide(BtlvPos pos)
	{
		return default(bool);
	}

	public virtual uint GetGameTime()
	{
		return default(uint);
	}

	public virtual uint GetCommandTime()
	{
		return default(uint);
	}

	public virtual uint GetClientTime(BTL_CLIENT_ID clientID)
	{
		return default(uint);
	}

	public virtual void GetUiDisplay_Turn_Weather(out uint numerator, out uint denominator)
	{
	}

	public virtual void GetUiDisplay_Turn_Ground(out uint numerator, out uint denominator)
	{
	}

	public virtual void GetUiDisplay_Turn_Hikarinokabe(out uint numerator, out uint denominator, BtlSide side)
	{
	}

	public virtual void GetUiDisplay_Turn_Reflector(out uint numerator, out uint denominator, BtlSide side)
	{
	}

	public virtual void GetUiDisplay_Turn_AuroraVeil(out uint numerator, out uint denominator, BtlSide side)
	{
	}

	public virtual void GetUiDisplay_Turn_SideEffect(out uint numerator, out uint denominator, BtlSide side, BtlSideEffect sideEffect)
	{
	}

	public virtual void GetUiDisplay_Turn(out uint numerator, out uint denominator, byte myClientID, byte causePokeID, uint totalTurn, uint upTurn, uint remainTurn, uint passedTurn)
	{
	}

	public virtual void GetUiDisplay_PokeType(out byte type1, out byte type2, [In] ref BTL_POKEPARAM poke)
	{
	}

	public void GetUiDisplay_WazaName(out WazaNo pDispWazaNo, out int pSpWazaNameIndex, MonsNo monsno, ushort formno, bool isG, bool isSpGEnable, WazaNo wazano)
	{
	}

	public void GetUiDisplay_WazaName(out WazaNo pDispWazaNo, out int pSpWazaNameIndex, BTL_POKEPARAM pAttacker, WazaNo wazano)
	{
	}

	public virtual byte GetUiDisplay_WazaType(WazaNo waza, [Optional] BTL_POKEPARAM pAttacker)
	{
		return default(byte);
	}

	public virtual ushort GetUiDisplay_WazaPower(WazaNo waza)
	{
		return default(ushort);
	}

	public virtual ushort GetUiDisplay_WazaHitPer(WazaNo waza)
	{
		return default(ushort);
	}

	public virtual WazaDamageType GetUiDisplay_WazaDamageType(WazaNo waza)
	{
		return default(WazaDamageType);
	}

	public virtual bool GetUiDisplay_IsPokemonAppearedOnBattleField([In] ref byte clientID, [In] ref byte memberIndex)
	{
		return default(bool);
	}

	public virtual ClientPublicInformation GetUiDisplay_GetClientPublicInfomation([In] ref byte clientID)
	{
		return null;
	}

	public virtual bool GetUiDisplay_IsCheerMode([In] ref byte clientID)
	{
		return default(bool);
	}

	public virtual BtlMultiMode GetUIDisplay_GetMultiMode()
	{
		return default(BtlMultiMode);
	}

	public virtual void GetUiDisplay_GetPlayerName(UiDisplayPlayerNameInfo pInfo, [In] ref byte clientID)
	{
	}

	public virtual bool IsWazaAffinityDisplayEnable(byte defPokeID)
	{
		return default(bool);
	}

	public virtual TypeAffinity.AboutAffinityID CalcWazaAffinityAbout(byte atkPokeID, byte defPokeID, WazaNo waza, out bool isDisplayEnable)
	{
		return default(TypeAffinity.AboutAffinityID);
	}

	public virtual RaidActionIconID GetRaidActionIconID(BTL_CLIENT_ID clientID)
	{
		return default(RaidActionIconID);
	}

	public virtual bool IsGWallGaugeDisplay()
	{
		return default(bool);
	}

	public virtual byte GetGWallGaugeMax()
	{
		return default(byte);
	}

	public virtual byte GetGWallGaugeNow()
	{
		return default(byte);
	}

	private GWall GetGWall()
	{
		return null;
	}

	public virtual bool CheckTrainerActionRequest(BTL_CLIENT_ID clientID)
	{
		return default(bool);
	}

	public virtual void SetTrainerActionRequest()
	{
	}

	public virtual void ClearTrainerActionRequest()
	{
	}

	public virtual bool IsTutorial()
	{
		return default(bool);
	}

	public virtual int GetSafariBallNum()
	{
		return default(int);
	}

	public virtual bool Initialize()
	{
		return default(bool);
	}

	public virtual bool FinalizeApp()
	{
		return default(bool);
	}

	public virtual bool FinalizeAppForce()
	{
		return default(bool);
	}

	public virtual void CMD_StartSetup()
	{
	}

	public virtual bool CMD_WaitSetup()
	{
		return default(bool);
	}

	public virtual void CMD_StartCleanUp()
	{
	}

	public virtual bool CMD_WaitCleanUp()
	{
		return default(bool);
	}

	public virtual bool CMD_InitStartWaitCameraEffect()
	{
		return default(bool);
	}

	public virtual bool CMD_WaitStartWaitCameraEffect()
	{
		return default(bool);
	}

	public virtual void CMD_InitFinishWaitCameraEffect()
	{
	}

	public virtual bool CMD_WaitFinishWaitCameraEffect()
	{
		return default(bool);
	}

	public virtual void CMD_UI_OnFirstSelectActionStart()
	{
	}

	public virtual void CMD_UI_SelectAction_Start([In] ref SelectActionParam param, BTL_ACTION_PARAM_OBJ dest)
	{
	}

	public virtual BtlAction CMD_UI_SelectAction_Wait()
	{
		return default(BtlAction);
	}

	public virtual void CMD_UI_SelectAction_ForceQuit()
	{
	}

	public virtual void CMD_UI_SelectAction_AllFinished()
	{
	}

	public virtual bool CMD_UI_SelectAction_AllFinished_Wait()
	{
		return default(bool);
	}

	public virtual void CMD_UI_SelectWaza_Start(BTL_POKEPARAM bpp, byte pokeIndex, BTL_ACTION_PARAM_OBJ dest)
	{
	}

	public virtual void CMD_UI_SelectWaza_Restart(byte pokeIndex)
	{
	}

	public virtual bool CMD_UI_SelectWaza_Wait()
	{
		return default(bool);
	}

	public virtual bool CMD_UI_SelectWaza_End()
	{
		return default(bool);
	}

	public virtual void CMD_UI_SelectWaza_ForceQuit()
	{
	}

	public virtual void CMD_UI_SelectTarget_Start(byte poke_index, BTL_POKEPARAM bpp, BTL_ACTION_PARAM_OBJ dest)
	{
	}

	public virtual BtlvResult CMD_UI_SelectTarget_Wait()
	{
		return default(BtlvResult);
	}

	public virtual void CMD_UI_SelectTarget_ForceQuit()
	{
	}

	public virtual void CMD_UI_RestartIfNotStandBy()
	{
	}

	public virtual void CMD_UI_Restart()
	{
	}

	public virtual bool CMD_UI_WaitRestart()
	{
		return default(bool);
	}

	public virtual void CMD_StartMemberChangeAct(BtlPokePos pos, byte clientID, byte memberIdx)
	{
	}

	public virtual bool CMD_WaitMemberChangeAct()
	{
		return default(bool);
	}

	public virtual void CMD_StartMsgInBuffer(bool isKeyWait = false)
	{
	}

	public virtual void CMD_StartPokeList(PokeSelParam param, BTL_POKEPARAM outMemberParam, uint outMemberIndex, bool fCantEsc, PokeSelResult result)
	{
	}

	public virtual bool CMD_WaitPokeList()
	{
		return default(bool);
	}

	public virtual void CMD_ForceQuitPokeList()
	{
	}

	public virtual bool CMD_WaitForceQuitPokeList()
	{
		return default(bool);
	}

	public virtual void CMD_StartPokeSelect(PokeSelParam param, uint outMemberIndex, bool bCancelable, PokeSelResult result)
	{
	}

	public virtual bool CMD_WaitPokeSelect()
	{
		return default(bool);
	}

	public virtual void CMD_ForceQuitPokeSelect()
	{
	}

	public virtual bool CMD_WaitForceQuitPokeSelect()
	{
		return default(bool);
	}

	public virtual void CMD_StartMsg(BTLV_STRPARAM param)
	{
	}

	public virtual void CMD_StartMsgWaza(byte pokeID, WazaNo waza, BtlPokePos attackerPos, BtlPokePos defenderPos, WazaTarget wazaRange, bool needMessageDisplay)
	{
	}

	public virtual void CMD_StartMsgStd(ushort strID, int[] args)
	{
	}

	public virtual void CMD_StartMsgSet(ushort strID, int[] args)
	{
	}

	public virtual bool CMD_StartMsgTrainer(byte clientID, uint param, bool isKeyWait = false)
	{
		return default(bool);
	}

	public virtual bool CMD_WaitMsg()
	{
		return default(bool);
	}

	public virtual bool CMD_WaitMsg_WithoutHide()
	{
		return default(bool);
	}

	public virtual void CMD_HideMsg()
	{
	}

	public virtual void CMD_ACT_WazaEffect_Start(BtlPokePos atPokePos, BtlPokePos defPokePos, WazaNo waza, byte wazaType, WazaTarget wazaRange, BtlvWazaEffect_TurnType turnType, byte continueCount, bool syncDamageEffect, bool isGShockOccur)
	{
	}

	public virtual bool CMD_ACT_WazaEffect_Wait()
	{
		return default(bool);
	}

	public virtual void CMD_ACT_WazaEffect_NotView(WazaNo wazano)
	{
	}

	public virtual void CMD_ACT_DamageEffectSingle_Start(WazaNo wazaID, BtlPokePos defPokePos, TypeAffinity.AboutAffinityID affAbout)
	{
	}

	public virtual bool CMD_ACT_DamageEffectSingle_Wait()
	{
		return default(bool);
	}

	public virtual void CMD_ACT_DamageEffectPlural_Start(uint pokeCnt, TypeAffinity.AboutAffinityID affAbout, byte[] pokeID, TypeAffinity.AffinityID[] pokeAffinity, WazaNo waza)
	{
	}

	public virtual bool CMD_ACT_DamageEffectPlural_Wait()
	{
		return default(bool);
	}

	public virtual void CMD_ACT_MigawariDamageEffect_Start(WazaNo wazaID, BtlPokePos migawariPos, TypeAffinity.AboutAffinityID affAbout)
	{
	}

	public virtual bool CMD_ACT_MigawariDamageEffect_Wait()
	{
		return default(bool);
	}

	public virtual void CMD_StartDeadAct(BtlPokePos pokePos, bool isKillCountEffectExist)
	{
	}

	public virtual bool CMD_WaitDeadAct()
	{
		return default(bool);
	}

	public virtual void CMD_StartReliveAct(BtlPokePos pos)
	{
	}

	public virtual bool CMD_WaitReliveAct()
	{
		return default(bool);
	}

	public virtual void CMD_ACT_MemberOut_Start(BtlvPos vpos, BtlEff effectNo)
	{
	}

	public virtual bool CMD_ACT_MemberOut_Wait()
	{
		return default(bool);
	}

	public virtual void CMD_ACT_TameWazaHide(BtlvPos vpos, BTLV_VANISH_FLAG vanishFlag)
	{
	}

	public virtual void CMD_ACT_SimpleHPEffect_Start(BtlPokePos pokePos)
	{
	}

	public virtual bool CMD_ACT_SimpleHPEffect_Wait()
	{
		return default(bool);
	}

	public virtual void CMD_AddEffect(BtlEff effectNo)
	{
	}

	public virtual bool CMD_WaitEffect()
	{
		return default(bool);
	}

	public virtual void CMD_AddEffectByPos(BtlvPos vpos, BtlEff effectNo)
	{
	}

	public virtual bool CMD_WaitEffectByPos()
	{
		return default(bool);
	}

	public virtual void CMD_AddEffectByDir(BtlvPos vpos_from, BtlvPos vpos_to, BtlEff effectNo)
	{
	}

	public virtual bool CMD_WaitEffectByDir()
	{
		return default(bool);
	}

	public virtual void CMD_AddEffectBySide(BtlvPos vpos_from, BtlvPos vpos_to, BtlEff effectNo)
	{
	}

	public virtual bool CMD_WaitEffectBySide()
	{
		return default(bool);
	}

	public virtual void CMD_TokWin_DispStart(BtlPokePos pos, bool fFlash)
	{
	}

	public virtual bool CMD_TokWin_DispWait(BtlPokePos pos)
	{
		return default(bool);
	}

	public virtual void CMD_QuitTokWin(BtlPokePos pos)
	{
	}

	public virtual bool CMD_QuitTokWinWait(BtlPokePos pos)
	{
		return default(bool);
	}

	public virtual void CMD_TokWin_Renew_Start(BtlPokePos pos)
	{
	}

	public virtual bool CMD_TokWin_Renew_Wait(BtlPokePos pos)
	{
		return default(bool);
	}

	public virtual void CMD_StartRankDownEffect(BtlvPos vpos, byte rankDownVolume, RankEffectViewType viewType)
	{
	}

	public virtual void CMD_StartRankUpEffect(BtlvPos vpos, byte rankUpVolume, RankEffectViewType UnnamedParameter)
	{
	}

	public virtual bool CMD_WaitRankEffect(BtlvPos vpos)
	{
		return default(bool);
	}

	public virtual void CMD_StartCommWait()
	{
	}

	public virtual bool CMD_WaitCommWait()
	{
		return default(bool);
	}

	public virtual void CMD_ResetCommWaitInfo()
	{
	}

	public virtual void CMD_ItemAct_Start(BtlPokePos pos)
	{
	}

	public virtual bool CMD_ItemAct_Wait(BtlPokePos pos)
	{
		return default(bool);
	}

	public virtual void CMD_KinomiAct_Start(BtlPokePos pos)
	{
	}

	public virtual bool CMD_KinomiAct_Wait(BtlPokePos pos)
	{
		return default(bool);
	}

	public virtual void CMD_FakeDisable_Start(BtlPokePos pos, bool fSkipMode)
	{
	}

	public virtual bool CMD_FakeDisable_Wait()
	{
		return default(bool);
	}

	public virtual void CMD_ChangeForm_Start(BtlvPos vpos)
	{
	}

	public virtual bool CMD_ChangeForm_Wait()
	{
		return default(bool);
	}

	public virtual void CMD_Hensin_Start(BtlvPos atkVpos, BtlvPos tgtVpos)
	{
	}

	public virtual bool CMD_Hensin_Wait()
	{
		return default(bool);
	}

	public virtual void CMD_ACT_MoveMember_Start(byte clientID, BtlvPos vpos1, BtlvPos vpos2, byte posIdx1, byte posIdx2)
	{
	}

	public virtual bool CMD_ACT_MoveMember_Wait()
	{
		return default(bool);
	}

	public virtual void CMD_ITEMSELECT_Start(byte bagMode, byte energy, byte reserved_energy, bool fFirstPokemon, bool fBallTargetHide, bool canUseReliveItem)
	{
	}

	public virtual bool CMD_ITEMSELECT_Wait()
	{
		return default(bool);
	}

	public virtual void CMD_ITEMSELECT_ForceQuit()
	{
	}

	public virtual ItemNo CMD_ITEMSELECT_GetItemID()
	{
		return default(ItemNo);
	}

	public virtual byte CMD_ITEMSELECT_GetTargetIdx()
	{
		return default(byte);
	}

	public virtual byte CMD_ITEMSELECT_GetWazaIdx()
	{
		return default(byte);
	}

	public virtual void CMD_ITEMSELECT_ReflectUsedItem()
	{
	}

	public virtual void CMD_YESNO_Start(bool b_cancel, YesNoMode yesno_mode)
	{
	}

	public virtual bool CMD_YESNO_Wait(out BtlYesNo result)
	{
		return default(bool);
	}

	public virtual void CMD_YESNO_ForceQuit()
	{
	}

	public virtual void CMD_YESNO_Delete()
	{
	}

	public virtual void CMD_ExpGet_Start(ExpGetDesc desc, ExpGetResult pResult)
	{
	}

	public virtual bool CMD_ExpGet_Wait(ExpGetResult pResult)
	{
		return default(bool);
	}

	public virtual void CMD_RecPlayFadeOut_Start()
	{
	}

	public virtual bool CMD_RecPlayFadeOut_Wait()
	{
		return default(bool);
	}

	public virtual void CMD_RecPlayFadeIn_Start()
	{
	}

	public virtual bool CMD_RecPlayFadeIn_Wait()
	{
		return default(bool);
	}

	public virtual void CMD_RecDispTurnGauge_Start()
	{
	}

	public virtual bool CMD_RecDispTurnGauge_Wait()
	{
		return default(bool);
	}

	public virtual void CMD_Naderu_Start(BtlvPos vpos)
	{
	}

	public virtual bool CMD_Naderu_Wait(BtlvPos vpos)
	{
		return default(bool);
	}

	public virtual void CMD_VsNusiWinEffect_Start()
	{
	}

	public virtual bool CMD_VsNusiWinEffect_Wait()
	{
		return default(bool);
	}

	public virtual void CMD_GRightsGet_Start(byte clientID)
	{
	}

	public virtual bool CMD_GRightsGet_Wait()
	{
		return default(bool);
	}

	public virtual void CMD_MsgWinHide_Start()
	{
	}

	public virtual bool CMD_MsgWinHide_Wait()
	{
		return default(bool);
	}

	public virtual void CMD_ForceQuitInput_Notify()
	{
	}

	public virtual bool CMD_ForceQuitInput_Wait()
	{
		return default(bool);
	}

	public virtual void CMD_RecPlayer_Init(ushort max_chapter)
	{
	}

	public virtual RecPlayerInput CMD_CheckRecPlayerInput()
	{
		return default(RecPlayerInput);
	}

	public virtual void CMD_UpdateRecPlayerInput(ushort currentChapter, ushort ctrlChapter)
	{
	}

	public virtual void CMD_RecPlayer_StartSkip()
	{
	}

	public virtual void CMD_RecPlayer_StartSkipDisplay(ushort nextChapter)
	{
	}

	public virtual void CMD_RecPlayer_StartQuit(ushort chapter, RecPlayStopFlag stop_flag)
	{
	}

	public virtual void CMD_TrainerIn_Win(BtlvPos position)
	{
	}

	public virtual void CMD_TrainerIn_Lose(BtlvPos position)
	{
	}

	public virtual void CMD_TrainerIn_Event(BtlvPos position)
	{
	}

	public virtual bool CMD_WaitTrainerIn()
	{
		return default(bool);
	}

	public virtual void CMD_EFFECT_SetGaugeStatus(Sick sick, BtlvPos pos)
	{
	}

	public virtual void CMD_EFFECT_BallThrow(BtlvPos userPos, BtlvPos position, ItemNo item_no, byte yure_cnt, bool f_success, bool f_critical)
	{
	}

	public virtual void CMD_EFFECT_BallThrowTrainer(BtlvPos vpos, ItemNo item_no)
	{
	}

	public virtual bool CMD_EFFECT_WaitBallThrow()
	{
		return default(bool);
	}

	public virtual bool CMD_EFFECT_WaitBallThrowTrainer()
	{
		return default(bool);
	}

	public virtual void CMD_EFFECT_DrawEnableTimer(GameTimer.TimerType type, bool enable)
	{
	}

	public virtual void CMD_ChangeWheather(BtlWeather weather)
	{
	}

	public virtual bool CMD_ChangeWheather_Wait()
	{
		return default(bool);
	}

	public virtual void CMD_ChangeGround(BtlGround type)
	{
	}

	public virtual bool CMD_ChangeGround_Wait()
	{
		return default(bool);
	}

	public virtual void CMD_FadeOutBGM(uint frames)
	{
	}

	public virtual void CMD_FadeInBGM(uint frames)
	{
	}

	public virtual bool CMD_CheckFadeOnBGM()
	{
		return default(bool);
	}

	public virtual void CMD_StopBGM()
	{
	}

	public virtual void CMD_PlayWinBGM()
	{
	}

	public virtual void CMD_PlaySE(SoundType SENo)
	{
	}

	public virtual bool CMD_IsSEFinished(SoundType SENo)
	{
		return default(bool);
	}

	public virtual void CMD_StopAllSE()
	{
	}

	public virtual void CMD_StartGMode(BtlPokePos pos)
	{
	}

	public virtual bool CMD_StartGMode_Wait()
	{
		return default(bool);
	}

	public virtual void CMD_EndGMode(BtlPokePos pos)
	{
	}

	public virtual bool CMD_EndGMode_Wait()
	{
		return default(bool);
	}

	public virtual void CMD_SummarizedGShockEffect([In] ref SummarizedGShockEffectParam param)
	{
	}

	public virtual bool CMD_SummarizedGShockEffect_Wait()
	{
		return default(bool);
	}

	public virtual void CMD_Raid_StartCoopCapture(BtlPokePos bossPos, uint seqNo)
	{
	}

	public virtual bool CMD_Raid_StartCoopCapture_Wait()
	{
		return default(bool);
	}

	public virtual void CMD_Raid_SelectBall([In] ref Raid_SelectBall_Param param)
	{
	}

	public virtual bool CMD_Raid_SelectBall_Wait(Raid_SelectBall_Result pResult)
	{
		return default(bool);
	}

	public virtual void CMD_Raid_SelectBall_ForceQuit()
	{
	}

	public virtual void CMD_Raid_Capture([In] ref RaidCaptureParam param)
	{
	}

	public virtual bool CMD_Raid_Capture_Wait()
	{
		return default(bool);
	}

	public virtual void CMD_Raid_Capture_vsJoker([In] ref RaidCaptureParam param)
	{
	}

	public virtual bool CMD_Raid_Capture_vsJoker_Wait()
	{
		return default(bool);
	}

	public virtual void CMD_Raid_Win()
	{
	}

	public virtual bool CMD_Raid_Win_Wait()
	{
		return default(bool);
	}

	public virtual void CMD_Raid_Result()
	{
	}

	public virtual bool CMD_Raid_Result_Wait()
	{
		return default(bool);
	}

	public virtual void CMD_Raid_Lose()
	{
	}

	public virtual bool CMD_Raid_Lose_Wait()
	{
		return default(bool);
	}

	public virtual void CMD_FinalizeFadeSkip()
	{
	}

	public virtual void CMD_Tips_G()
	{
	}

	public virtual bool CMD_Tips_G_Wait()
	{
		return default(bool);
	}

	public virtual void CMD_DemoCapture_Start()
	{
	}

	public virtual bool CMD_DemoCapture_Wait()
	{
		return default(bool);
	}

	public virtual BtlBagMode GetBagMode()
	{
		return default(BtlBagMode);
	}

	public virtual void RaidReward_Start([In] ref RaidRewardParam rewardParam)
	{
	}

	public virtual bool RaidReward_Wait()
	{
		return default(bool);
	}

	public virtual void SetUIControlEnableForLiveCup([In] ref bool bEnable)
	{
	}

	public virtual void CMD_ACT_Safari_Start(BtlPokePos pokePos, SafariCmd safariCmd, int param)
	{
	}

	public virtual bool CMD_ACT_Safari_Wait()
	{
		return default(bool);
	}

	protected static void DBG_PrintFuncName()
	{
	}

	protected static void DBG_LogFuncNames()
	{
	}
}
