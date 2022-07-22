using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Dpr.Battle.Logic;
using Dpr.Battle.View.Objects;
using Dpr.SequenceEditor;
using Pml;
using Pml.Battle;
using Pml.PokePara;
using Pml.WazaData;
using UnityEngine;
using XLSXContent;

namespace Dpr.Battle.View.Systems;

public sealed class BattleViewSystem : BattleViewBase, ISequenceViewSystem
{
	public enum BattleViewSide
	{
		PLAYER_SIDE,
		ENEMY_SIDE
	}

	public enum InitializeSequenceStateType
	{
		Unregistered = -1,
		InitSystem,
		WaitLoadData,
		WaitLoadGraphic,
		SetupData,
		Finish
	}

	public enum SetupSequenceStateType
	{
		NONE,
		WILD_IN,
		WILD_RARE,
		TRAINER_IN,
		ENEMY_TRAINER,
		ENEMY_RARE,
		SELF_TRAINER,
		SELF_RARE,
		COMM_WAIT,
		RAID_WAIT,
		SEQ_WAIT,
		G_SIGNAL_IN,
		G_SIGNAL_WAIT,
		SIMPLE_IN,
		SIMPLE_WAIT,
		SAFARI_IN,
		SAFARI_RARE,
		FINISH
	}

	public enum SetupCommSequenceType
	{
		Unregistered = -1,
		SETUP,
		INTRO,
		THROW_1ST,
		RARE_1ST,
		THROW_2ND,
		RARE_2ND,
		FINISH
	}

	public enum SetupRaidSequenceType
	{
		Unregistered = -1,
		SETUP,
		INTRO,
		RAID_RARE,
		SELF_TRAINER,
		SELF_RARE,
		FINISH
	}

	public enum WazaSequenceType
	{
		SEQ_SETUP,
		SEQ_MIGAWARI_CHECK,
		SEQ_MIGAWARI_OUT,
		SEQ_MIGAWARI_OUT_UPDATE,
		SEQ_CAMERA_PLAY,
		SEQ_CAMERA_PLAY_START,
		SEQ_CAMERA_PLAY_WAIT,
		SEQ_WAZA_PLAY,
		SEQ_WAZA_PLAY_WAIT,
		SEQ_FORMCHANGE,
		SEQ_FORMCHANGE_WAIT,
		SEQ_FORMCHANGE_END,
		SEQ_MIGAWARI_IN,
		SEQ_MIGAWARI_IN_UPDATE,
		SEQ_END
	}

	public enum EndSequenceType
	{
		FADE,
		START,
		WAIT_OBJECT,
		WAIT_FIELD_OBJECT,
		MEMORY_WAIT,
		RENDERER,
		FINISH
	}

	public enum CommandTarget
	{
		TARGET_ATK,
		TARGET_DEF,
		MAX
	}

	public enum SequenceSeq
	{
		NONE,
		START_LOAD,
		WAIT_PRELOAD,
		WAIT_LOAD,
		WAIT_WAZA_MSG,
		UPDATE_SEQUENCE,
		FINISH,
		SOUND_WAIT,
		SEQ_LOAD_START
	}

	public const int BTLV_SEQ_SOUND_PLAY_FINISH_WAIT_MAX = 1800;

	public const int UNIQUE_MEMBER_CHANGE_ACT_ARIVE_POKE_CNT = 1;

	private bool m_isFinalize;

	private bool m_isFinalizeFadeSkip;

	private bool m_isFinishLoadObjects;

	private BattleSequenceSystem m_iPtrSequenceSystem;

	private BattleCharacterSystem m_iPtrCharacterSystem;

	private BattleCameraSystem m_iPtrCameraSystem;

	private BattleWeatherSystem m_iPtrWeatherSystem;

	private BattleGroundEffectSystem m_iPtrBattleGroundEffectSystem;

	private BattleStatusEffectObserverSystem m_iPtrStatusEffectObserverSystem;

	private BattleDataTable m_battleDataTable;

	private BattleDefaultPlacementData m_defaultPlacementData;

	private BattleScreenObject m_iPtrScreenObject;

	private Dictionary<BtlvPos, string> m_skrtModelDict;

	private BTLV_WAZA_EFF_PARAM m_wazaParam;

	private BtlvPos[] m_comTargetPoke;

	private BtlvPos[] m_comTargetDamage;

	private BtlvPos[] m_comTargetTrainer;

	private BtlEff m_comEffectId;

	private BallId[] m_effectBallId;

	private BtlvBallInfo[] m_effectBallInfo;

	private int m_comIsVisibleTame;

	private bool m_comIsMigawari;

	private bool m_comMigawariReserve;

	private BtlvPos m_comMigawariReserveTarget;

	private int m_comRepeatNum;

	private bool m_comIsSuccsess;

	private bool m_comIsCritical;

	private int m_subSequence;

	private SequenceSeq m_sequenceSeq;

	private bool m_seqKeepResource;

	private string m_playingSeqFileNameHash;

	private Func<bool> m_pComWaitFunc;

	private bool m_isStartMsgDisplay;

	private int m_wazaMsgFrame;

	private BtlvPos m_beforePlayEffPos;

	private BtlEff m_beforePlayEffNo;

	private bool m_isFieldIndoor;

	private bool m_isFieldStadium;

	private bool m_isFieldRoseTower;

	private bool m_isFieldStadiumWide;

	private bool m_isFieldWaitcamExcept;

	private bool m_reqCheckPinch;

	private bool m_canChangePinch;

	private bool m_isSoundPlayingFinishCheckInvalid;

	private int m_soundPlayingFinishWaitCount;

	private BtlvSound m_pokePinchSound;

	private bool m_preUpdateAudioListenerByMainCamera;

	private DeadActParam m_deadActParam;

	private MemberChangeActParam m_memberChangeActParam;

	private MemberOutActParam m_memberOutActParam;

	private StartGActParam m_startGActParam;

	private EndGActParam m_endGActParam;

	private TrainerTalkParam m_trainerTalkParam;

	private BTLV_ATTR_EFF_PARAM m_attrEffParam;

	private string m_attrSoundEvent;

	private TaskManager m_iPtrTaskManager;

	private TaskManager m_iPtrTaskManagerLate;

	private Stack<Tuple<int, uint, uint>> m_uPtrSoundPlayingIDHash;

	private int m_shadowResolutionBackup;

	private bool IsSuspendSequenceSystem => default(bool);

	private bool IsSoundPlayingFinishCheckInvalid => default(bool);

	private InitializeSequenceStateType InitializeSequenceState
	{
		[CompilerGenerated]
		get
		{
			return default(InitializeSequenceStateType);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	private SetupSequenceStateType SetupSequenceState
	{
		[CompilerGenerated]
		get
		{
			return default(SetupSequenceStateType);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	private SetupCommSequenceType SetupCommSequence
	{
		[CompilerGenerated]
		get
		{
			return default(SetupCommSequenceType);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	private SetupRaidSequenceType SetupRaidSequence
	{
		[CompilerGenerated]
		get
		{
			return default(SetupRaidSequenceType);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	private WazaSequenceType WazaSequence
	{
		[CompilerGenerated]
		get
		{
			return default(WazaSequenceType);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	private EndSequenceType EndSequence
	{
		[CompilerGenerated]
		get
		{
			return default(EndSequenceType);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public bool IsStencilEnable
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

	private bool IsAllTaskFinished => default(bool);

	public float blurry
	{
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public Dictionary<BtlvPos, string> PositionForModelIDDict
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool IsApplicationPause
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

	private bool IsFieldStadium => default(bool);

	private bool IsFieldRoseTower => default(bool);

	private bool IsFieldStadiumWide => default(bool);

	private bool IsFieldWaitcamExceptreturn => default(bool);

	public override void CMD_UI_OnFirstSelectActionStart()
	{
	}

	public override void CMD_UI_SelectAction_Start([In] ref SelectActionParam param, BTL_ACTION_PARAM_OBJ dest)
	{
	}

	public override BtlAction CMD_UI_SelectAction_Wait()
	{
		return default(BtlAction);
	}

	public override void CMD_UI_SelectAction_ForceQuit()
	{
	}

	public override void CMD_UI_SelectAction_AllFinished()
	{
	}

	public override void CMD_UI_SelectWaza_Start(BTL_POKEPARAM bpp, byte pokeIndex, BTL_ACTION_PARAM_OBJ dest)
	{
	}

	public override void CMD_UI_SelectWaza_Restart(byte pokeIndex)
	{
	}

	public override bool CMD_UI_SelectWaza_Wait()
	{
		return default(bool);
	}

	public override bool CMD_UI_SelectWaza_End()
	{
		return default(bool);
	}

	public override void CMD_UI_SelectWaza_ForceQuit()
	{
	}

	public override void CMD_UI_SelectTarget_Start(byte poke_index, BTL_POKEPARAM bpp, BTL_ACTION_PARAM_OBJ dest)
	{
	}

	public override BtlvResult CMD_UI_SelectTarget_Wait()
	{
		return default(BtlvResult);
	}

	public override void CMD_UI_SelectTarget_ForceQuit()
	{
	}

	public override void CMD_ITEMSELECT_Start(byte bagMode, byte energy, byte reserved_energy, bool fFirstPokemon, bool fBallTargetHide, bool canUseReliveItem)
	{
	}

	public override bool CMD_ITEMSELECT_Wait()
	{
		return default(bool);
	}

	public override void CMD_ITEMSELECT_ForceQuit()
	{
	}

	public override ItemNo CMD_ITEMSELECT_GetItemID()
	{
		return default(ItemNo);
	}

	public override byte CMD_ITEMSELECT_GetTargetIdx()
	{
		return default(byte);
	}

	public override byte CMD_ITEMSELECT_GetWazaIdx()
	{
		return default(byte);
	}

	public override void CMD_ITEMSELECT_ReflectUsedItem()
	{
	}

	public override void CMD_StartPokeList(PokeSelParam param, BTL_POKEPARAM outMemberParam, uint outMemberIndex, bool fCantEsc, PokeSelResult result)
	{
	}

	public override bool CMD_WaitPokeList()
	{
		return default(bool);
	}

	public override void CMD_ForceQuitPokeList()
	{
	}

	public override bool CMD_WaitForceQuitPokeList()
	{
		return default(bool);
	}

	public override void CMD_StartPokeSelect(PokeSelParam param, uint outMemberIndex, bool bCancelable, PokeSelResult result)
	{
	}

	public override bool CMD_WaitPokeSelect()
	{
		return default(bool);
	}

	public override void CMD_ForceQuitPokeSelect()
	{
	}

	public override bool CMD_WaitForceQuitPokeSelect()
	{
		return default(bool);
	}

	public override void CMD_EFFECT_BallThrow(BtlvPos userPos, BtlvPos position, ItemNo item_no, byte yure_cnt, bool f_success, bool f_critical)
	{
	}

	public override void CMD_EFFECT_BallThrowTrainer(BtlvPos vpos, ItemNo item_no)
	{
	}

	public override bool CMD_EFFECT_WaitBallThrow()
	{
		return default(bool);
	}

	public override bool CMD_EFFECT_WaitBallThrowTrainer()
	{
		return default(bool);
	}

	public bool CheckCanPlayCommand(CommandParam param)
	{
		return default(bool);
	}

	public bool CheckCanPlayCommandWaitCamera(CommandParam param)
	{
		return default(bool);
	}

	public override bool FinalizeApp()
	{
		return default(bool);
	}

	public override bool FinalizeAppForce()
	{
		return default(bool);
	}

	private bool finalizeCommon()
	{
		return default(bool);
	}

	public override bool Initialize()
	{
		return default(bool);
	}

	private void StartLoadObject()
	{
	}

	private void StartSetup()
	{
	}

	private void SetupLight()
	{
	}

	private void SetupWeather()
	{
	}

	private void StartGround()
	{
	}

	public void SetBattleReflection(Camera reflectionCamera, int reflectionResolutionStage)
	{
	}

	private int GetBattleReflectionLayer(bool isEnable)
	{
		return default(int);
	}

	public bool SetupGraphic()
	{
		return default(bool);
	}

	private void InitializeSystem()
	{
	}

	public override void CMD_StartMsg(BTLV_STRPARAM param)
	{
	}

	public override void CMD_StartMsgWaza(byte pokeID, WazaNo waza, BtlPokePos attackerPos, BtlPokePos defenderPos, WazaTarget wazaRange, bool needMessageDisplay)
	{
	}

	public override void CMD_StartMsgStd(ushort strID, int[] args)
	{
	}

	public override void CMD_StartMsgSet(ushort strID, int[] args)
	{
	}

	public override bool CMD_StartMsgTrainer(byte clientID, uint param, bool isKeyWait = false)
	{
		return default(bool);
	}

	public override bool CMD_WaitMsg()
	{
		return default(bool);
	}

	public override bool CMD_WaitMsg_WithoutHide()
	{
		return default(bool);
	}

	public override void CMD_HideMsg()
	{
	}

	public override void CMD_DemoCapture_Start()
	{
	}

	public override bool CMD_DemoCapture_Wait()
	{
		return default(bool);
	}

	public override void CMD_ACT_MemberOut_Start(BtlvPos vPos, BtlEff effectNo)
	{
	}

	public override bool CMD_ACT_MemberOut_Wait()
	{
		return default(bool);
	}

	public override void CMD_ACT_TameWazaHide(BtlvPos vpos, BTLV_VANISH_FLAG vanishFlag)
	{
	}

	public override void CMD_StartMemberChangeAct(BtlPokePos pos, byte clientID, byte memberIdx)
	{
	}

	public override bool CMD_WaitMemberChangeAct()
	{
		return default(bool);
	}

	public override void CMD_FakeDisable_Start(BtlPokePos pos, bool fSkipMode)
	{
	}

	public override bool CMD_FakeDisable_Wait()
	{
		return default(bool);
	}

	public override void CMD_ChangeForm_Start(BtlvPos vpos)
	{
	}

	public override bool CMD_ChangeForm_Wait()
	{
		return default(bool);
	}

	public override void CMD_Hensin_Start(BtlvPos atkVpos, BtlvPos tgtVpos)
	{
	}

	public override bool CMD_Hensin_Wait()
	{
		return default(bool);
	}

	private void CMD_ACT_PokeChangeEffect_StartCore(BtlvPos vpos, BtlEff effId, bool isNoLoad)
	{
	}

	private bool CMD_ACT_PokeChangeEffect_WaitCore(bool isGChange)
	{
		return default(bool);
	}

	private bool CMD_ACT_PokeChangeEffect_WaitCore_Skip()
	{
		return default(bool);
	}

	public override void CMD_ExpGet_Start(ExpGetDesc desc, ExpGetResult pResult)
	{
	}

	public override bool CMD_ExpGet_Wait(ExpGetResult pResult)
	{
		return default(bool);
	}

	public override void CMD_StartRankDownEffect(BtlvPos vpos, byte rankDownVolume, RankEffectViewType viewType)
	{
	}

	public override void CMD_StartRankUpEffect(BtlvPos vPos, byte rankUpVolume, RankEffectViewType UnnamedParameter)
	{
	}

	public override bool CMD_WaitRankEffect(BtlvPos vPos)
	{
		return default(bool);
	}

	public override void CMD_ACT_Safari_Start(BtlPokePos pokePos, SafariCmd safariCmd, int param)
	{
	}

	public override bool CMD_ACT_Safari_Wait()
	{
		return default(bool);
	}

	public void SEQ_CMD_ResetDefaultCamera(int frame, SEQ_DEF_MOVETYPE moveType, SequenceCameraSystem system)
	{
	}

	public bool SeqComFunc_IsFlipEffect(BtlvPos target, BtlvPos subTarget)
	{
		return default(bool);
	}

	public BattleViewCharacter SeqComFunc_GetTargetChara(SEQ_DEF_TRAINER trg, int idx = 0)
	{
		return null;
	}

	public BattleViewCharacter SeqComFunc_GetTargetChara(SEQ_DEF_TRAINER_ADD trg, int idx = 0)
	{
		return null;
	}

	public BtlvPos SeqComFunc_GetTargetPoke(SEQ_DEF_POS target, int index = 0)
	{
		return default(BtlvPos);
	}

	public BtlvPos SeqComFunc_GetTargetPokeSub(SEQ_DEF_POS target)
	{
		return default(BtlvPos);
	}

	public BtlvPos SeqComFunc_GetTargetPoke_Org(int idx)
	{
		return default(BtlvPos);
	}

	public void SeqComFunc_GetPokeRelativePos(ref RELARIVE_POKE_OPTION opt, ref Vector3 pRetPos, ref Vector3 pRetRot, ref Vector3 pRetScale, bool isCameraAdjust)
	{
	}

	public void SeqComFunc_GetSpecialPos(SEQ_DEF_SPPOS trgType, ref Vector3 retPos, ref Vector3 retRot)
	{
	}

	public void SeqComFunc_GetPokeFiledPos(ref Vector3 retPos, ref Vector3 retRot, BtlvPos plater, bool isAttack)
	{
	}

	public int SeqComFunc_GetTargetPokeNum(bool isCheck = true)
	{
		return default(int);
	}

	public BtlvPos SeqComFunc_GetTargetCharaVPos(SEQ_DEF_TRAINER target, int index = 0)
	{
		return default(BtlvPos);
	}

	public void SeqComFunc_CalcPokeDir(Vector3 nowPos, BtlvPos trgPoke, SEQ_DEF_NODE trgNode, ref Vector3 retRot, bool isVertical)
	{
	}

	public void SeqComFunc_CalcPosDir(Vector3 nowPos, Vector3 trgPos, ref Vector3 retRot, bool isVertical)
	{
	}

	public void SeqComFunc_MoveRelativePoke(ITranslationObject iPtrObj, int frame, RELARIVE_POKE_OPTION opt, bool isTrainer = false)
	{
	}

	public void SeqComFunc_MoveSpecialPos(ITranslationObject iPtrObj, int frame, SEQ_DEF_SPPOS trgType, Vector3 ofs, bool isRotate, bool isFlip)
	{
	}

	public void SetTerrainChipVisibility(bool disp)
	{
	}

	public void StartWeather(BtlWeather weather)
	{
	}

	public void SetSuspendSequenceFunc(SEQ_DEF_WAIT type)
	{
	}

	private bool SeqComWaitFunc_Message()
	{
		return default(bool);
	}

	private bool SeqComWaitFunc_LoadPoke()
	{
		return default(bool);
	}

	private bool SeqComWaitFunc_SelectMessage()
	{
		return default(bool);
	}

	private bool SeqComWaitFunc_UIBag()
	{
		return default(bool);
	}

	private bool SeqComWaitFunc_UITrainerName()
	{
		return default(bool);
	}

	private bool SeqComWaitFunc_UIFog()
	{
		return default(bool);
	}

	private bool SeqComWaitFunc_UISeq()
	{
		return default(bool);
	}

	private BallId SeqComFunc_GetEffectBallId(int idx)
	{
		return default(BallId);
	}

	public BtlvBallInfo SeqComFunc_GetEffectBallInfo(int idx)
	{
		return default(BtlvBallInfo);
	}

	public override void CMD_StartSetup()
	{
	}

	private IEnumerator WaitSetupSequence()
	{
		return null;
	}

	private void StartSetView()
	{
	}

	private void RegisterCamera()
	{
	}

	public override bool CMD_WaitSetup()
	{
		return default(bool);
	}

	private void PlaySequenceStartDemo(bool isKeepResource = true)
	{
	}

	private void StartRareSequence(BtlvPos[] posArr, int arrNum, bool isKeepResource = true)
	{
	}

	private void CMD_WaitSetup_ThrowSelf()
	{
	}

	private void CMD_WaitSetup_ThrowEnemy(bool isComm = false)
	{
	}

	private bool CMD_WaitSetup_Comm()
	{
		return default(bool);
	}

	public override bool CMD_InitStartWaitCameraEffect()
	{
		return default(bool);
	}

	public override bool CMD_WaitStartWaitCameraEffect()
	{
		return default(bool);
	}

	public override void CMD_InitFinishWaitCameraEffect()
	{
	}

	public override bool CMD_WaitFinishWaitCameraEffect()
	{
		return default(bool);
	}

	public BattleViewSystem(BTLV_INIT_PARAM initParam)
	{
	}

	private void InitializeMember()
	{
	}

	public override void CMD_ACT_WazaEffect_Start(BtlPokePos atPokePos, BtlPokePos defPokePos, WazaNo waza, byte wazaType, WazaTarget wazaRange, BtlvWazaEffect_TurnType turnType, byte continueCount, bool syncDamageEffect, bool isGShockOccur)
	{
	}

	public override bool CMD_ACT_WazaEffect_Wait()
	{
		return default(bool);
	}

	private void StartWazaEffect()
	{
	}

	private bool WaitWazaEffect()
	{
		return default(bool);
	}

	private void UpdateCheerSoundOnWazaStart_Damage(BtlvPos pos)
	{
	}

	private void UpdateCheerSoundOnWazaStart_Damage(BtlPokePos pos)
	{
	}

	private void UpdateCheerSoundOnWazaStart_NotDamage()
	{
	}

	private void UpdateCheerSoundOnWazaEnd()
	{
	}

	private void StartEgCamWazaStart()
	{
	}

	private bool WaitSequence()
	{
		return default(bool);
	}

	private void StartWazaEffectCore()
	{
	}

	private void PlaySequenceEffect(BtlEff no, bool isKeepResource = false)
	{
	}

	public override void CMD_ACT_DamageEffectSingle_Start(WazaNo wazaID, BtlPokePos defPokePos, TypeAffinity.AboutAffinityID affAbout)
	{
	}

	public override bool CMD_ACT_DamageEffectSingle_Wait()
	{
		return default(bool);
	}

	public override void CMD_ACT_DamageEffectPlural_Start(uint pokeCnt, TypeAffinity.AboutAffinityID affAbout, byte[] pokeID, TypeAffinity.AffinityID[] pokeAffinity, WazaNo waza)
	{
	}

	public override bool CMD_ACT_DamageEffectPlural_Wait()
	{
		return default(bool);
	}

	public override void CMD_ACT_MigawariDamageEffect_Start(WazaNo wazaID, BtlPokePos migawariPos, TypeAffinity.AboutAffinityID affAbout)
	{
	}

	public override bool CMD_ACT_MigawariDamageEffect_Wait()
	{
		return default(bool);
	}

	private bool CMD_ACT_DamageEffect_WaitCore()
	{
		return default(bool);
	}

	public override void CMD_StartDeadAct(BtlPokePos pokePos, bool isKillCountEffectExist)
	{
	}

	public override bool CMD_WaitDeadAct()
	{
		return default(bool);
	}

	public override void CMD_ACT_SimpleHPEffect_Start(BtlPokePos pokePos)
	{
	}

	public override bool CMD_ACT_SimpleHPEffect_Wait()
	{
		return default(bool);
	}

	public override void CMD_AddEffect(BtlEff effectNo)
	{
	}

	public override bool CMD_WaitEffect()
	{
		return default(bool);
	}

	public override void CMD_AddEffectByPos(BtlvPos vpos, BtlEff effectNo)
	{
	}

	public override bool CMD_WaitEffectByPos()
	{
		return default(bool);
	}

	public override void CMD_AddEffectByDir(BtlvPos vpos_from, BtlvPos vpos_to, BtlEff effectNo)
	{
	}

	public override bool CMD_WaitEffectByDir()
	{
		return default(bool);
	}

	public override void CMD_AddEffectBySide(BtlvPos vpos_from, BtlvPos vpos_to, BtlEff effectNo)
	{
	}

	public override bool CMD_WaitEffectBySide()
	{
		return default(bool);
	}

	public override void CMD_ChangeWheather(BtlWeather weather)
	{
	}

	public override bool CMD_ChangeWheather_Wait()
	{
		return default(bool);
	}

	public override void CMD_ChangeGround(BtlGround type)
	{
	}

	public override bool CMD_ChangeGround_Wait()
	{
		return default(bool);
	}

	public override void CMD_TokWin_DispStart(BtlPokePos pos, bool fFlash)
	{
	}

	public void CMD_TokWin_DispStartEx(BtlPokePos pos, TokuseiNo overrideTokusei = TokuseiNo.NULL)
	{
	}

	public override bool CMD_TokWin_DispWait(BtlPokePos pos)
	{
		return default(bool);
	}

	public override void CMD_QuitTokWin(BtlPokePos pos)
	{
	}

	public override bool CMD_QuitTokWinWait(BtlPokePos pos)
	{
		return default(bool);
	}

	public override void CMD_TokWin_Renew_Start(BtlPokePos pos)
	{
	}

	public override bool CMD_TokWin_Renew_Wait(BtlPokePos pos)
	{
		return default(bool);
	}

	public override void CMD_StartCommWait()
	{
	}

	public override bool CMD_WaitCommWait()
	{
		return default(bool);
	}

	public override void CMD_ResetCommWaitInfo()
	{
	}

	public override void CMD_ItemAct_Start(BtlPokePos pos)
	{
	}

	public override bool CMD_ItemAct_Wait(BtlPokePos pos)
	{
		return default(bool);
	}

	public override void CMD_KinomiAct_Start(BtlPokePos pos)
	{
	}

	public override bool CMD_KinomiAct_Wait(BtlPokePos pos)
	{
		return default(bool);
	}

	public override void CMD_TrainerIn_Win(BtlvPos position)
	{
	}

	public override void CMD_TrainerIn_Lose(BtlvPos position)
	{
	}

	public override bool CMD_WaitTrainerIn()
	{
		return default(bool);
	}

	public override void CMD_PlayWinBGM()
	{
	}

	public override void CMD_PlaySE(SoundType SENo)
	{
	}

	public override bool CMD_IsSEFinished(SoundType SENo)
	{
		return default(bool);
	}

	public override void CMD_ACT_MoveMember_Start(byte clientID, BtlvPos vpos1, BtlvPos vpos2, byte posIdx1, byte posIdx2)
	{
	}

	public override bool CMD_ACT_MoveMember_Wait()
	{
		return default(bool);
	}

	public override void CMD_YESNO_Start(bool b_cancel, YesNoMode yesno_mode)
	{
	}

	public override bool CMD_YESNO_Wait(out BtlYesNo result)
	{
		return default(bool);
	}

	public override void CMD_YESNO_ForceQuit()
	{
	}

	public override void CMD_EFFECT_SetGaugeStatus(Sick sick, BtlvPos pos)
	{
	}

	public override void CMD_EFFECT_DrawEnableTimer(GameTimer.TimerType type, bool enable)
	{
	}

	public override void CMD_FinalizeFadeSkip()
	{
	}

	private void PlaySequenceCore(string path, bool keepResource = false)
	{
	}

	private void PlaySequenceWaza(BTLV_WAZA_EFF_PARAM param)
	{
	}

	private string GetWazaSequencePath(ref BTLV_WAZA_EFF_PARAM param, ref bool? isNormalSeq)
	{
		return null;
	}

	private bool IsWazaMsgCommandSeq()
	{
		return default(bool);
	}

	private void StartWazaMsgCommand()
	{
	}

	private bool WaitWazaMsgCommand()
	{
		return default(bool);
	}

	public void OnUpdate(float deltaTime)
	{
	}

	public void OnLateUpdate(float deltaTime)
	{
	}

	private void UpdateSequence()
	{
	}

	private void UpdateSuspendSequenceSystem()
	{
	}

	private void CheckPokePinch()
	{
	}

	private void StartLoadSequence()
	{
	}

	public void ResetAll()
	{
	}

	private void ResetEnvironmentParams()
	{
	}

	private void ResetQualitySettings()
	{
	}

	private void ResetHitBack()
	{
	}

	private bool CheckCanPlayEffect(BtlvPos vPos, BtlEff effectNo)
	{
		return default(bool);
	}

	private void ResetCheckCanPlayEffect()
	{
	}

	private BallId GetCaptureBall(BtlvPos vPos, out bool isStrangeBall)
	{
		return default(BallId);
	}

	private BtlvBallInfo GetBallInfo(BtlvPos vPos)
	{
		return default(BtlvBallInfo);
	}

	public override BtlRule GetBattleRule()
	{
		return default(BtlRule);
	}

	public PartyDesc GetPartySetupParam(byte clientId)
	{
		return null;
	}

	public BTLV_WAZA_EFF_PARAM GetWazaParam()
	{
		return default(BTLV_WAZA_EFF_PARAM);
	}

	public BTLV_WAZA_EFF_PARAM SetWazaParam(BTLV_WAZA_EFF_PARAM param)
	{
		return default(BTLV_WAZA_EFF_PARAM);
	}

	public BTLV_ATTR_EFF_PARAM GetAttrEffParam()
	{
		return default(BTLV_ATTR_EFF_PARAM);
	}

	public string GetSoundEventName()
	{
		return null;
	}

	public TrainerTalkParam GetTrainerTalkParam()
	{
		return default(TrainerTalkParam);
	}

	public BtlvMode GetBtlvMode()
	{
		return default(BtlvMode);
	}

	private void ResetDefaultCamera(int frame = 0, EaseFunc moveType = EaseFunc.LINEAR)
	{
	}

	private void ResetDefaultCamera(int frame, EaseFunc moveType, BattleCameraSystem system)
	{
	}

	private void ResetDefaultCameraParam(int frame, EaseFunc moveType, SequenceCameraSystem system, Vector3 pos, Vector3 target, float fov, float depthNear, float depthFar)
	{
	}

	private void GetDefaultCamera(ref Vector3 pos, ref Vector3 target, ref float fov, ref float depthNear, ref float depthFar)
	{
	}

	private void GetDefaultCamera_Target(ref Vector3 pos, ref Vector3 target, ref float fov, ref float depthNear, ref float depthFar)
	{
	}

	private void GetDefaultCameraParam(Size playerSize, Size enemySize, bool isExistGPoke, ref Vector3 pos, ref Vector3 target, ref float fov, ref float near, ref float far)
	{
	}

	public float GetTimeZoneSensorScale()
	{
		return default(float);
	}

	private BattleEffectComponentData GetBattleEffectComponentData()
	{
		return null;
	}

	private bool WaitLoadSequence()
	{
		return default(bool);
	}

	private bool WaitSequenceResource()
	{
		return default(bool);
	}

	private bool IsExistGPoke()
	{
		return default(bool);
	}

	private bool IsExistGPokeSide(bool playerSide)
	{
		return default(bool);
	}

	public string GetBattleModelPath(string idx)
	{
		return null;
	}

	public string GetBttleWazaModelPath(string idx)
	{
		return null;
	}

	public string GetBallModelPath(int idx)
	{
		return null;
	}

	public void ResetPokemon(BtlvPos vPos, int frame, SEQ_DEF_MOVETYPE moveType, SEQ_DEF_DEFAULT_PLACEMENT placement = SEQ_DEF_DEFAULT_PLACEMENT.SEQ_DEF_DEFAULT_PLACEMENT_DEFAULT)
	{
	}

	private void SwapPokeModel(BtlvPos vPos1, BtlvPos vPos2)
	{
	}

	public void GetDefaultPokePos(BtlvPos vPos, ref Vector3 pos, ref int deg, SEQ_DEF_DEFAULT_PLACEMENT placement = SEQ_DEF_DEFAULT_PLACEMENT.SEQ_DEF_DEFAULT_PLACEMENT_DEFAULT)
	{
	}

	public BOPokemon GetPokeModel(BtlvPos vPos)
	{
		return null;
	}

	public Size GetPokeSize(BattleViewSide side, bool isGPoke = false)
	{
		return default(Size);
	}

	private void SetVisiblePokeObject(bool value)
	{
	}

	public void ResetTrainer(BtlvPos vPos, bool isOrigin, SEQ_DEF_DEFAULT_PLACEMENT placement = SEQ_DEF_DEFAULT_PLACEMENT.SEQ_DEF_DEFAULT_PLACEMENT_DEFAULT)
	{
	}

	private void GetDefaultTrainerPos(BtlvPos vPos, ref Vector3 pPos, ref int pDeg, bool isOrigin, SEQ_DEF_DEFAULT_PLACEMENT placement)
	{
	}

	public BattleViewCharacter GetTrainerModel(BtlvPos vPos)
	{
		return null;
	}

	private void SetVisibleTrainerObject(bool value)
	{
	}

	private void SetVisibleBattleObject(bool value)
	{
	}

	private void SetEnableMotionWaitB(bool isEnable)
	{
	}

	public BattleScreenObject GetScreenObject()
	{
		return null;
	}

	public void SetReqCheckPinch(bool value)
	{
	}

	public bool IsReqCheckPinch()
	{
		return default(bool);
	}

	public void SetCanChangePinch(bool value)
	{
	}

	public bool IsCanChangePinch()
	{
		return default(bool);
	}

	public void SetIsSoundPlayingFinishCheckInvalid(bool value)
	{
	}

	private void SaveFog()
	{
	}

	private bool UIFog_Wait()
	{
		return default(bool);
	}

	private void SetComTargetReset()
	{
	}

	private bool CheckEgCamWazaStart()
	{
		return default(bool);
	}

	private void SetupWazaTarget(BtlvPos atkPos, BtlvPos defPos, WazaTarget wazaRange)
	{
	}

	private void SetupWazaTarget_AllFunc(BtlvPos atkPos, ref BtlvPos[] retArray, bool enemyOnly)
	{
	}

	private bool IsDefGPoke()
	{
		return default(bool);
	}

	private BtlvWazaEffect_TurnType GetUniqWazaSeqTurnType(BtlvPos vPos, WazaNo no, BtlvWazaEffect_TurnType turnType)
	{
		return default(BtlvWazaEffect_TurnType);
	}

	public void CheckWazaDataPath_Particle(ref string path, int idx, bool isBallEffect, bool isCapture, bool isAttributeEffect, bool isStreamLineEffect)
	{
	}

	public Stack<Tuple<int, uint, uint>> GetSoundPlayingIDHashTable()
	{
		return null;
	}

	public BattleSequenceSystem GetSequenceSystem()
	{
		return null;
	}

	public BattleCharacterSystem GetCharacterSystem()
	{
		return null;
	}

	public SequenceCameraSystem GetCameraSystem()
	{
		return null;
	}

	public BattleWeatherSystem GetBattleWeatherSystem()
	{
		return null;
	}

	public BattleGroundEffectSystem GetBattleGroundEffectSystem()
	{
		return null;
	}

	public BattleViewUISystem GetHUD()
	{
		return null;
	}

	public TaskManager GetTaskManager()
	{
		return null;
	}

	public TaskManager GetTaskManagerLate()
	{
		return null;
	}

	private bool IsGosanke(BTL_POKEPARAM pokeParam)
	{
		return default(bool);
	}

	private bool IsGosanke(PokemonParam pokeParam)
	{
		return default(bool);
	}

	private string GetGosankeThrowSeq(uint friendShip)
	{
		return null;
	}
}
