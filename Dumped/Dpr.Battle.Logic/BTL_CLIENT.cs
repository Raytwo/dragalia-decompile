using System.Runtime.InteropServices;
using Pml;
using Pml.Item;
using Pml.PokePara;
using Pml.WazaData;

namespace Dpr.Battle.Logic;

public sealed class BTL_CLIENT
{
	public enum PrintCallbackArg
	{
		PRINTCB_RUN,
		PRINTCB_JUST_DONE,
		PRINTCB_AFTER_DONE
	}

	public enum CantEscapeCode
	{
		CANTESC_START = 0,
		CANTESC_KAGEFUMI = 0,
		CANTESC_ARIJIGOKU = 1,
		CANTESC_JIRYOKU = 2,
		CANTESC_TOOSENBOU = 3,
		CANTESC_FAIRY_LOCK = 4,
		CANTESC_MAX = 5,
		CANTESC_NULL = 5
	}

	private delegate bool ClientMainProc();

	private delegate bool ClientSubProc(ref int seq);

	private delegate bool ServerCmdProc(ref int seq, int[] args);

	private enum RecCtrlCode
	{
		RECCTRL_NONE,
		RECCTRL_QUIT,
		RECCTRL_CHAPTER
	}

	private sealed class RECPLAYER_CONTROL
	{
		public byte seq;

		public byte ctrlCode;

		public bool fChapterSkip;

		public bool fFadeOutStart;

		public bool fFadeOutDone;

		public bool fTurnIncrement;

		public bool fLock;

		public bool fQuit;

		public ushort handlingTimer;

		public ushort turnCount;

		public ushort nextTurnCount;

		public ushort maxTurnCount;

		public ushort skipTurnCount;
	}

	private sealed class SEL_ITEM_WORK
	{
		public ushort itemNo;

		public bool bFromPokeSelect;
	}

	private enum WazaEffectCmdProcResult
	{
		WAZAEFF_CMD_RESULT_NO_PROC,
		WAZAEFF_CMD_RESULT_PROC_NO_SYNC,
		WAZAEFF_CMD_RESULT_PROC_SYNC
	}

	private sealed class VariableArgs
	{
		private int[] m_args;

		private byte m_cnt;

		public void Dispose()
		{
		}

		public void Clear()
		{
		}

		public void Setup(int[] cmd_args)
		{
		}

		public byte GetCount()
		{
			return default(byte);
		}

		public int GetArg(byte idx)
		{
			return default(int);
		}
	}

	private sealed class WAZAEFF_SYNCDAMAGE_CMD_WORK
	{
		public sealed class StoreElem
		{
			public ServerCmdProc cmdProc;

			public ServerCommand cmd;

			public int[] cmdArgs;

			public int seq;

			public bool bDone;

			public VariableArgs variableArgs;
		}

		public uint cmdCount;

		public StoreElem[] store;
	}

	private enum SelActRootSeq
	{
		SELACT_ROOTSEQ_START,
		SELACT_ROOTSEQ_FRIENDSHIP_MSG_WAIT,
		SELACT_ROOTSEQ_WAIT_MSG_CHECK,
		SELACT_ROOTSEQ_WAIT_MSG_WAIT,
		SELACT_ROOTSEQ_SEL_START,
		SELACT_ROOTSEQ_SEL_MAIN,
		SELACT_ROOTSEQ_WAIT_UI_RESTART,
		SELACT_ROOTSEQ_FREEFALL_WARN,
		SELACT_ROOTSEQ_FREEFALL_WARN_MSG,
		SELACT_ROOTSEQ_FREEFALL_WARN_WAIT
	}

	private sealed class FriendshipEffectProc
	{
		private MainModule m_mainModule;

		private POKECON m_pokeCon;

		private BattleViewBase m_viewCore;

		private byte m_myID;

		private byte m_numCoverPos;

		private byte m_searchIdx;

		private int m_step;

		public void Dispose()
		{
		}

		public void Start(MainModule mainModule, POKECON pokeCon, BattleViewBase viewCore, byte myID, byte numCoverPos)
		{
		}

		public bool Wait()
		{
			return default(bool);
		}

		private int checkEffectNo(BTL_POKEPARAM bpp)
		{
			return default(int);
		}

		public static bool S_IsEnable(BTL_POKEPARAM bpp)
		{
			return default(bool);
		}
	}

	private enum main_NormalSeq
	{
		SEQ_READ_ACMD,
		SEQ_EXEC_CMD,
		SEQ_RETURN_TO_SV,
		SEQ_RETURN_TO_SV_QUIT,
		SEQ_RECPLAY_CTRL,
		SEQ_RECPLAY_STOP,
		SEQ_BGM_FADEOUT,
		SEQ_WAIT_RECPLAY_FADEOUT,
		SEQ_COMM_ERROR,
		SEQ_WAIT_CLEANUP_FOR_COMM_ERROR,
		SEQ_QUIT
	}

	private enum main_ChapterSkipSeq
	{
		SEQ_RECPLAY_START,
		SEQ_RECPLAY_READ_ACMD,
		SEQ_RECPLAY_EXEC_CMD,
		SEQ_RECPLAY_RETURN_TO_SV,
		SEQ_RECPLAY_FADEIN,
		SEQ_RECPLAY_QUIT
	}

	private enum SeqRecPlayerCtrl_Main
	{
		SEQ_DEFAULT,
		SEQ_FADEOUT,
		SEQ_STAY
	}

	private struct check_status_up_item_check_tbl_elem
	{
		public Pml.Item.ItemData.PrmID itemParamID;

		public BTL_POKEPARAM.ValueID rankID;

		public check_status_up_item_check_tbl_elem(Pml.Item.ItemData.PrmID itemParamID, BTL_POKEPARAM.ValueID rankID)
		{
		}
	}

	private struct check_cure_sick_item_tbl_elem
	{
		public Pml.Item.ItemData.PrmID itemParamID;

		public WazaSick sickID;

		public check_cure_sick_item_tbl_elem(Pml.Item.ItemData.PrmID itemParamID, WazaSick sickID)
		{
		}
	}

	private enum SeqSubProc_UI_SelectAction
	{
		SEQ_START_0,
		SEQ_DEMOCAPTURE_WAIT,
		SEQ_START_1,
		SEQ_TRAINER_MESSAGE_SWITCH,
		SEQ_TRAINER_MESSAGE_START,
		SEQ_TRAINER_MESSAGE_WAIT,
		SEQ_CAMERA_INIT,
		SEQ_CAMERA_WAIT,
		SEQ_SELACT_START,
		SEQ_SELACT_WAIT
	}

	private enum SeqSubProc_REC_SelectAction
	{
		SEQ_FIRST,
		SEQ_NONE,
		SEQ_START_WAIT,
		SEQ_CAMERA_RUNNING,
		SEQ_END_WAIT
	}

	private enum Seqselact_Fight
	{
		SEQ_START,
		SEQ_SELECT_WAZA_START,
		SEQ_SELECT_WAZA_WAIT,
		SEQ_SELECT_WAZA_END,
		SEQ_CHECK_WAZA_TARGET,
		SEQ_SELECT_TARGET_START,
		SEQ_SELECT_TARGET_WAIT,
		SEQ_WAIT_UNSEL_WAZA_MSG,
		SEQ_WAIT_UNSEL_TARGET_MSG,
		SEQ_DONE
	}

	private enum Seqselact_Item
	{
		SEQ_START,
		SEQ_SELECT_START,
		SEQ_SELECT_WAIT,
		SEQ_FORCE_QUIT,
		SEQ_CANT_USE_START,
		SEQ_CANT_USE_WAIT
	}

	private enum Seqselact_Escape
	{
		SEQ_INIT,
		SEQ_CANT_MSG_START,
		SEQ_CANT_MSG_WAIT,
		SEQ_CONFIRM_MSG_START,
		SEQ_CONFIRM_MSG_WAIT,
		SEQ_CONFIRM_YESNO,
		SEQ_RETURN_ESCAPE
	}

	private enum SEQ_SubProc_AI_SelectAction
	{
		SEQ_INIT,
		SEQ_POKE_START,
		SEQ_AI_START,
		SEQ_AI_WAIT,
		SEQ_NEXT_POKE,
		SEQ_SAFARI,
		SEQ_END
	}

	private enum SeqselectPokemonUI_Core
	{
		SEQ_INIT,
		SEQ_SELECT_ROOT,
		SEQ_TIMELIMIT_OVER,
		SEQ_SELECT_END,
		SEQ_PROC_QUIT_ROOT,
		SEQ_COMM_WAIT,
		SEQ_PROC_QUIT_END
	}

	private enum SeqSubProc_UI_ConfirmIrekae
	{
		SEQ_INIT,
		SEQ_START_CONFIRM,
		SEQ_WAIT_CONFIRM,
		SEQ_WAIT_POKESELECT,
		SEQ_DONT_CHANGE,
		SEQ_RETURN
	}

	private enum SeqSubProc_ExitCommTrainer
	{
		SEQ_START,
		SEQ_SHOWDOWN_MESSAGE_START,
		SEQ_SHOWDOWN_MESSAGE_WAIT_WIN,
		SEQ_SHOWDOWN_MESSAGE_WAIT_LOSE,
		SEQ_LOSE_BGM_FADEOUT_WAIT
	}

	private enum SeqSubProc_UI_ExitForNPC
	{
		SEQ_INIT,
		SEQ_WIN_START,
		SEQ_WIN_WAIT_TR1_IN,
		SEQ_WIN_WAIT_TR1_MSG,
		SEQ_WIN_WAIT_TR1_OUT,
		SEQ_WIN_WAIT_TR2_IN,
		SEQ_WIN_WAIT_TR2_MSG,
		SEQ_WIN_GET_MONEY_MSG,
		SEQ_WIN_GET_MONEY,
		SEQ_WIN_BONUS_MONEY,
		SEQ_LOSE_START,
		SEQ_LOSE_WAIT_MSG1,
		SEQ_END
	}

	private enum SeqSubProc_ExitForSubwayTrainer
	{
		SEQ_START,
		SEQ_INIT,
		SEQ_WAIT_TRAINER_IN,
		SEQ_WAIT_MSG,
		SEQ_WAIT_TRAINER_OUT,
		SEQ_WAIT_TRAINER2_IN,
		SEQ_WAIT_MSG2
	}

	private enum SeqSubProc_UI_FadeOut
	{
		SEQ_START,
		SEQ_FADEOUT_START,
		SEQ_FAIDEOUT_WAIT,
		SEQ_END
	}

	private enum SeqSubProc_UI_RaidBossCapture_SelectBall
	{
		SEQ_START,
		SEQ_SELECTBALL_START,
		SEQ_SELECTBALL_WAIT,
		SEQ_END
	}

	private enum SeqSubProc_UI_RaidBossCapture_Result
	{
		SEQ_START,
		SEQ_BALLTHROW_START,
		SEQ_BALLTHROW_WAIT,
		SEQ_CAPTURED,
		SEQ_ESCAPE,
		SEQ_ESCAPE_ACT_START,
		SEQ_ESCAPE_ACT_WAIT,
		SEQ_JOKER_BALLTHROW_START,
		SEQ_JOKER_BALLTHROW_WAIT,
		SEQ_END
	}

	private enum SeqSubProc_UI_LoseRaid
	{
		SEQ_START,
		SEQ_EFFECT_START,
		SEQ_EFFECT_WAIT,
		SEQ_END
	}

	private enum SeqscProc_ACT_MemberIn
	{
		SEQ_TRAINER_MSG_SWITCH,
		SEQ_TRAINER_MSG_START,
		SEQ_TRAINER_MSG_WAIT,
		SEQ_MEMBERIN_MSG_START,
		SEQ_MEMBERIN_MSG_WAIT,
		SEQ_MEMBERIN_ACT
	}

	private struct getWeatherStartMessageTableElem
	{
		public BtlWeather weather;

		public int strID_others;

		public int strID_onBattleStart;

		public getWeatherStartMessageTableElem(BtlWeather weather, int strID_others, int strID_onBattleStart)
		{
		}
	}

	private enum SeqscProc_ACT_BallThrow
	{
		SEQ_START_BALL_THROW,
		SEQ_WAIT_BALL_THROW,
		SEQ_DONE
	}

	private enum SeqscProc_ACT_BallThrowForbidden
	{
		SEQ_START,
		SEQ_BALLTHROW_START,
		SEQ_BALLTHROW_WAIT,
		SEQ_MSG_START,
		SEQ_MSG_WAIT,
		SEQ_END
	}

	private enum Seq_ACT_Safari
	{
		Start,
		Throw0,
		Throw1,
		Throw2,
		Throw3,
		Yousumi0,
		Yousumi1,
		Yousumi2,
		End
	}

	public const int AITRAINER_MSG_MAX = 4;

	private MainModule m_mainModule;

	private BattleEnv m_pBattleEnv;

	private BTL_POKEPARAM m_procPoke;

	private byte m_actCountSum;

	private int m_procActionIndex;

	private BTL_ACTION_PARAM_OBJ m_procActionUIRet;

	private int m_currentActionIndex;

	private rec.Data m_recData;

	private rec.Reader m_btlRecReader;

	private RECPLAYER_CONTROL m_recPlayer;

	private ClientMainProc m_mainProc;

	private FieldStatus m_fldSim;

	private ulong m_randContext;

	private Adapter m_adapter;

	private SendDataContainer m_sendDataContainer;

	private SendDataContainer m_receiveDataContainer;

	private Random m_random;

	private Random m_AIRand;

	private TrainerMessageManager m_trainerMessageManager;

	private ClientSeq_TrainerMessage m_seq_TrainerMessage;

	private ClientSeq_WinWild m_seq_WinWild;

	private ClientSeq_Capture m_seq_Capture;

	private BattleSimulator m_battleSimulator;

	private BattleDriver m_battleDriver;

	private ServerCommandQueue m_serverCmdQueue;

	private GameTimer m_gameTimer;

	private ServerSendData.CLIENT_LIMIT_TIME m_syncClientTime;

	private ServerSendData.RAIDBOSS_CAPTURE_RESULT m_raidBossCaptureResult;

	private uint m_turnCount;

	private ushort m_EnemyPokeHPBase;

	private SEL_ITEM_WORK[] m_selItemWork;

	private byte m_myID;

	private byte m_myType;

	private byte m_myState;

	private bool m_commWaitInfoOn;

	private byte m_bagMode;

	private unsafe byte* m_change_escape_code;

	private bool m_fForceQuitSelAct;

	private byte m_cmdCheckTimingCode;

	private byte[] m_actionCountWork;

	private byte m_wazaInfoPokeIdx;

	private byte m_wazaInfoWazaIdx;

	private bool m_fAITrainerBGMChanged;

	private bool m_fCommError;

	private bool m_fSelActForceFinish;

	private bool m_fCmdCheckEnable;

	private bool m_fRecPlayEndTimeOver;

	private bool m_fRecPlayEndBufOver;

	private bool m_bRecPlayFadeStarted;

	private bool m_isWaitingAdapterCommand;

	private bool m_isGSelectedThisTurn;

	private bool m_isFirstActionSelectDone;

	private byte m_myChangePokeCnt;

	private byte m_myPuttablePokeCnt;

	private BtlPokePos[] m_myChangePokePos;

	private ushort m_returnDataSerialNumber;

	private ServerSequence m_returnDataServerSeq;

	private ServerRequest m_returnDataServerRequest;

	private unsafe void* m_returnDataPtr;

	private uint m_returnDataSize;

	private unsafe uint* m_dummyReturnData;

	private unsafe ClientSendData.ACTION_SELECT* m_returnData_ActionSelect;

	private unsafe ClientSendData.CLIENT_LIMIT_TIME* m_returnData_ClientLimitTime;

	private unsafe ClientSendData.RAID_BALL_SELECT* m_returnData_RaidBallSelect;

	private ushort m_cmdLimitTime;

	private ushort m_gameLimitTime;

	private ushort m_clientLimitTime;

	private readonly BTL_PARTY m_myParty;

	private byte m_procPokeIdx;

	private byte m_procPokeActIdx;

	private sbyte m_prevPokeIdx;

	private byte m_firstPokeIdx;

	private bool m_fStdMsgChanged;

	private bool m_b1stReadyMsgDisped;

	private BTL_SERVER m_cmdCheckServer;

	private BattleViewBase _m_viewCore;

	private BattleViewBase.ExpGetDesc m_viewExpGetDesc;

	private BattleViewBase.ExpGetResult m_viewExpGetResult;

	private BTL_ACTION_PARAM[] m_actionParam;

	private int[] m_cmdArgs;

	private VariableArgs m_stdVariableArgs;

	private VariableArgs m_tmpVariableArgs;

	private BattleAi m_ai;

	private ushort[] m_AIItem;

	private sbyte[] m_AIChangeIndex;

	private bool[] m_AITrainerMsgCheckedFlag;

	private ClientSubProc m_subProc;

	private int m_subSeq;

	private ClientSubProc m_selActProc;

	private int m_selActSeq;

	private BTLV_STRPARAM m_strParam;

	private BTLV_STRPARAM m_strParamSub;

	private PokeSelParam m_pokeSelParam;

	private PokeSelResult m_pokeSelResult;

	private ServerCmdProc m_scProc;

	private ServerCommand m_serverCmd;

	private int m_scSeq;

	private BtlPokePos[] m_deadPokePos;

	private bool m_isLiveRecSeedSetup;

	private uint m_liveRecWaitCameraSeq;

	private uint m_liveRecSizeSave;

	private WAZAEFF_SYNCDAMAGE_CMD_WORK m_wazaEffDmgSyncWork;

	private bool m_bWazaEffectDone;

	private bool m_bSyncEffectDone;

	private FriendshipEffectProc m_frEffectProc;

	private uint m_JK3Joker_PrevTurnAttackToLegends;

	private uint m_JK3Legend_PrevTurnUseKyozyuuzan;

	private const int CHAPTER_CTRL_FRAMES = 45;

	private static readonly check_status_up_item_check_tbl_elem[] check_status_up_item_check_tbl;

	private static readonly check_cure_sick_item_tbl_elem[] check_cure_sick_item_check_tbl;

	private static sbyte SubProc_UI_SelectAction_trainerMessage_clientID;

	private static TrainerMessageID SubProc_UI_SelectAction_trainerMessage_messageID;

	private int scProc_MSG_StdSE_subSeq;

	private int scProc_MSG_SetSE_subSeq;

	private static readonly getWeatherStartMessageTableElem[] getWeatherStartMessageParamTable;

	private uint scProc_ACT_KinomiPrevWaza_procIdx;

	private int scProc_ACT_FriendshipEffectMsg_effSeq;

	private int scProc_ACT_FriendshipEffectMsg_msgSeq;

	private uint scProc_ACTOP_SwapTokusei_timer;

	private BTL_ACTION_PARAM m_procAction => default(BTL_ACTION_PARAM);

	private byte m_currentActionCount
	{
		get
		{
			return default(byte);
		}
		set
		{
		}
	}

	private BattleViewBase m_viewCore
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void m_viewCore_CMD_EFFECT_DrawEnableTimer(GameTimer.TimerType type, bool enable)
	{
	}

	public BTL_CLIENT(MainModule mainModule, BattleEnv pBattleEnv, Adapter adapter, SendDataContainer sendDataContainer, SendDataContainer receiveDataContainer, byte commMode, ushort clientID, byte clientType, BtlBagMode bagMode, bool fRecPlayMode, ulong randSeed)
	{
	}

	private void createSimulator()
	{
	}

	private void createBattleDriver()
	{
	}

	public void Dispose()
	{
	}

	private POKECON getPokeCon()
	{
		return null;
	}

	private ServerCommandExecutor getServerCmdExecutor()
	{
		return null;
	}

	private void changeMainProc(ClientMainProc proc)
	{
	}

	private byte getMyCoverPosNum()
	{
		return default(byte);
	}

	public bool IsWaitingAdapterCommand()
	{
		return default(bool);
	}

	private bool main_Normal()
	{
		return default(bool);
	}

	private bool main_ChapterSkip()
	{
		return default(bool);
	}

	public unsafe void registerReceivedData(ushort serialNumber, ServerSequence serverSeq, ServerRequest serverReq, [In] ref void* data, uint dataSize)
	{
	}

	private bool returnToServer()
	{
		return default(bool);
	}

	private void RecPlayer_Init(RECPLAYER_CONTROL ctrl)
	{
	}

	private void RecPlayer_Setup(RECPLAYER_CONTROL ctrl, uint turnCnt)
	{
	}

	private bool RecPlayer_CheckBlackOut(RECPLAYER_CONTROL ctrl)
	{
		return default(bool);
	}

	private void RecPlayer_TurnIncReq(RECPLAYER_CONTROL ctrl)
	{
	}

	private RecCtrlCode RecPlayer_GetCtrlCode(RECPLAYER_CONTROL ctrl)
	{
		return default(RecCtrlCode);
	}

	private void RecPlayer_ChapterSkipOn(RECPLAYER_CONTROL ctrl, uint nextTurnNum)
	{
	}

	private void RecPlayer_ChapterSkipOff(RECPLAYER_CONTROL ctrl)
	{
	}

	private bool RecPlayer_CheckChapterSkipEnd(RECPLAYER_CONTROL ctrl)
	{
		return default(bool);
	}

	private uint RecPlayer_GetNextTurn(RECPLAYER_CONTROL ctrl)
	{
		return default(uint);
	}

	private bool RecPlayerCtrl_Lock(RECPLAYER_CONTROL ctrl)
	{
		return default(bool);
	}

	private void RecPlayerCtrl_Unlock(RECPLAYER_CONTROL ctrl)
	{
	}

	private void RecPlayer_Quit(RECPLAYER_CONTROL ctrl)
	{
	}

	private bool RecPlayer_IsActive(RECPLAYER_CONTROL ctrl)
	{
		return default(bool);
	}

	private void RecPlayerCtrl_Main(RECPLAYER_CONTROL ctrl)
	{
	}

	private void AIItem_Setup()
	{
	}

	private ushort AIItem_CheckUse(BTL_POKEPARAM bpp, BTL_PARTY party)
	{
		return default(ushort);
	}

	private bool check_status_up_item(ushort itemID, BTL_POKEPARAM bpp)
	{
		return default(bool);
	}

	private bool check_cure_sick_item(ushort itemID, BTL_POKEPARAM bpp)
	{
		return default(bool);
	}

	public void SetRecordPlayerMode(rec.Reader recReader)
	{
	}

	public void NotifyCommError()
	{
	}

	public unsafe void* GetRecordData(ref uint size)
	{
		//IL_0002: Expected I, but got O
		return (void*)unchecked((nint)null);
	}

	public void AttachViewCore(BattleViewBase viewCore)
	{
	}

	public void AttachCmdCheckServer(BTL_SERVER server)
	{
	}

	public void DetachCmdCheckServer()
	{
	}

	public Adapter GetAdapter()
	{
		return null;
	}

	public GameTimer GetGameTimer()
	{
		return null;
	}

	public uint GetSyncClientTime(BTL_CLIENT_ID clientID)
	{
		return default(uint);
	}

	public void SetSyncClientTime([In] ref ServerSendData.CLIENT_LIMIT_TIME time)
	{
	}

	public bool Main()
	{
		return default(bool);
	}

	public void NotifyFadeoutStartForRecPlay()
	{
	}

	public void SetChapterSkip(uint nextTurnNum)
	{
	}

	public void StopChapterSkip()
	{
	}

	public bool IsRecPlayerMode()
	{
		return default(bool);
	}

	public uint GetRecPlayerMaxChapter()
	{
		return default(uint);
	}

	public bool IsChapterSkipMode()
	{
		return default(bool);
	}

	private void setDummyReturnData()
	{
	}

	private bool setSubProc(ServerRequest serverReq, out bool fRecCtrlLock)
	{
		return default(bool);
	}

	private bool callSubProc()
	{
		return default(bool);
	}

	public bool IsGameTimeOver()
	{
		return default(bool);
	}

	public bool IsRecPlayBufOver()
	{
		return default(bool);
	}

	private bool SubProc_UI_Setup(ref int seq)
	{
		return default(bool);
	}

	private bool SubProc_AI_Setup(ref int seq)
	{
		return default(bool);
	}

	private bool SubProc_REC_Setup(ref int seq)
	{
		return default(bool);
	}

	private void enemyPokeHPBase_Update()
	{
	}

	private uint enemyPokeHPBase_CheckRatio()
	{
		return default(uint);
	}

	private BTL_POKEPARAM enemyPokeHPBase_GetTargetPoke()
	{
		return null;
	}

	private void startGameTimeCountDown()
	{
	}

	private void cmdLimit_Start()
	{
	}

	private bool cmdLimit_CheckOver()
	{
		return default(bool);
	}

	private bool checkSelactForceQuit(ClientSubProc nextProc)
	{
		return default(bool);
	}

	private void cmdLimit_End()
	{
	}

	private bool cmdComm_checkError()
	{
		return default(bool);
	}

	private bool setupSelectStartStr(BTL_POKEPARAM procPoke, BTLV_STRPARAM strParam)
	{
		return default(bool);
	}

	private bool checkFriendshipSpecialMessage(BTL_POKEPARAM procPoke, BTLV_STRPARAM strParam)
	{
		return default(bool);
	}

	private void selActSubProc_Set(ClientSubProc proc)
	{
	}

	private bool selActSubProc_Call()
	{
		return default(bool);
	}

	private bool SubProc_UI_SelectAction(ref int seq)
	{
		return default(bool);
	}

	private void onFirstActionSelectStart()
	{
	}

	private bool needDisplayTipsForG()
	{
		return default(bool);
	}

	private bool isRandomWaitCameraEnable()
	{
		return default(bool);
	}

	private bool DecideTrainerMessage_OnSelectAction(ref sbyte clientID, ref TrainerMessageID messageID)
	{
		return default(bool);
	}

	private sbyte DecideTrainerMessage_OnSelectAction_FirstDamage()
	{
		return default(sbyte);
	}

	private bool IsTrainerMessageEnable_OnSelectAction_FirstDamage(byte clientID)
	{
		return default(bool);
	}

	private sbyte DecideTrainerMessage_OnSelectAction_LastPokeHpHalf()
	{
		return default(sbyte);
	}

	private bool IsTrainerMessageEnable_OnSelectAction_LastPokeHpHalf(byte clientID)
	{
		return default(bool);
	}

	private bool SubProc_REC_SelectAction(ref int seq)
	{
		return default(bool);
	}

	private void setNullActionRecplay()
	{
	}

	private bool selact_Start(ref int seq)
	{
		return default(bool);
	}

	private void selact_startMsg(BTLV_STRPARAM strParam)
	{
	}

	private void selact_ClearWorks()
	{
	}

	private bool selact_ForceQuit(ref int seq)
	{
		return default(bool);
	}

	private void setActionForce(ref BTL_ACTION_PARAM pActionParam, BTL_POKEPARAM poke)
	{
	}

	private bool selact_Root(ref int seq)
	{
		return default(bool);
	}

	private void setupSelectActionUIParam(BattleViewBase.SelectActionParam pViewParam, BTL_POKEPARAM pActPoke, byte actPokeIdx)
	{
	}

	private byte calcAddActionCountSum(byte pokeIdx)
	{
		return default(byte);
	}

	private void setupCurrentPokeActionPtr()
	{
	}

	private bool selact_root_start(ref int seq)
	{
		return default(bool);
	}

	private void incrementAddActionCount()
	{
	}

	private void decrementAddActionCount()
	{
	}

	private bool selact_root_friendship_msg_wait(ref int seq)
	{
		return default(bool);
	}

	private bool selact_root_wait_msg_check(ref int seq)
	{
		return default(bool);
	}

	private bool selact_root_sel_main(ref int seq)
	{
		return default(bool);
	}

	private bool canStartG(BTL_POKEPARAM pPoke)
	{
		return default(bool);
	}

	private bool selact_Fight(ref int seq)
	{
		return default(bool);
	}

	private bool needGButtonDisplay(BTL_POKEPARAM pActPoke)
	{
		return default(bool);
	}

	private bool selact_SelectChangePokemon(ref int seq)
	{
		return default(bool);
	}

	private bool selact_Item(ref int seq)
	{
		return default(bool);
	}

	private bool canSelectItem(BTLV_STRPARAM pCantMessage)
	{
		return default(bool);
	}

	private bool canUseItem(BTLV_STRPARAM pCantMessage, ushort itemno, byte procPokeIdx)
	{
		return default(bool);
	}

	private bool canUseBall(BTLV_STRPARAM pCantMessage, ushort itemno, byte procPokeIdx)
	{
		return default(bool);
	}

	private void registerLastSelectedBall(uint itemno)
	{
	}

	private BTL_POKEPARAM getBallTarget()
	{
		return null;
	}

	private bool checkBallTargetHide()
	{
		return default(bool);
	}

	private bool selact_Escape(ref int seq)
	{
		return default(bool);
	}

	private bool canSelectEscape(BTLV_STRPARAM pCantMessage)
	{
		return default(bool);
	}

	private bool needEscapeConfirm(BTLV_STRPARAM pConfirmMessage)
	{
		return default(bool);
	}

	private bool selact_CheckFinish(ref int seq)
	{
		return default(bool);
	}

	private void setupSelActReturnData()
	{
	}

	private void storeActionSelectSendData(BTL_ACTION_PARAM[] actionParamArray, uint actionNum)
	{
	}

	private unsafe void storeActionSelectSendData(BTL_ACTION_PARAM* actionParamArray, uint actionNum)
	{
	}

	private void sendSelectedRaidActionIconID()
	{
	}

	private void clearSelectedRaidActionIconID()
	{
	}

	private bool selact_Finish(ref int seq)
	{
		return default(bool);
	}

	private void selItemWork_Init()
	{
	}

	private void selItemWork_Reserve(byte pokeIdx, ushort itemID, bool bFromPokeSelect)
	{
	}

	private bool selItemWork_IsFromPokeSelect(byte pokeIdx)
	{
		return default(bool);
	}

	private void selItemWork_Restore(byte pokeIdx)
	{
	}

	private void selItemWork_Quit()
	{
	}

	private bool checkActionForceSet(BTL_POKEPARAM bpp, ref BTL_ACTION_PARAM action)
	{
		return default(bool);
	}

	public bool IsCheerMode()
	{
		return default(bool);
	}

	private bool checkWazaForceSet(BTL_POKEPARAM bpp, ref BTL_ACTION_PARAM action)
	{
		return default(bool);
	}

	private void setWaruagakiAction(ref BTL_ACTION_PARAM dst, BTL_POKEPARAM bpp)
	{
	}

	private bool is_unselectable_waza(BTL_POKEPARAM bpp, WazaNo waza, BTLV_STRPARAM strParam)
	{
		return default(bool);
	}

	private bool is_unselectable_target(BTL_POKEPARAM bpp, WazaNo waza, BtlPokePos targetPos, BTLV_STRPARAM strParam)
	{
		return default(bool);
	}

	private byte storeSelectableWazaFlag(BTL_POKEPARAM bpp, bool checkGWaza, bool[] dst)
	{
		return default(byte);
	}

	public CantEscapeCode isForbidPokeChange(BTL_POKEPARAM procPoke, out byte pokeID, out ushort tokuseiID)
	{
		return default(CantEscapeCode);
	}

	public CantEscapeCode isForbidEscape(ref byte pokeID, ref ushort tokuseiID)
	{
		return default(CantEscapeCode);
	}

	private CantEscapeCode checkForbidChangeEscapeCommon(BTL_POKEPARAM procPoke, ref byte pokeID, ref ushort tokuseiID)
	{
		return default(CantEscapeCode);
	}

	private bool checkForbitEscapeEffective_Kagefumi(BTL_POKEPARAM procPoke)
	{
		return default(bool);
	}

	private bool checkForbitEscapeEffective_Arijigoku(BTL_POKEPARAM procPoke)
	{
		return default(bool);
	}

	private bool checkForbitEscapeEffective_Jiryoku(BTL_POKEPARAM procPoke)
	{
		return default(bool);
	}

	private void changeAI_InitWork()
	{
	}

	public bool changeAI_CheckReserve(byte pokeIndexWithinParty)
	{
		return default(bool);
	}

	private void changeAI_SetReserve(byte outPokeIdx, byte inPokeIdx)
	{
	}

	public bool IsPuttablePokemonExist()
	{
		return default(bool);
	}

	private BTL_POKEPARAM changeAI_SupposeEnemy(BtlPokePos basePos)
	{
		return null;
	}

	private bool SubProc_AI_SelectAction(ref int seq)
	{
		return default(bool);
	}

	private byte getAIPokeActNum(BTL_POKEPARAM pPoke)
	{
		return default(byte);
	}

	private BTL_ACTION_PARAM buildActionParamFromAiResult(ref BTL_ACTION_PARAM actionParam, byte actPokeIndex, BTL_POKEPARAM actPoke, BTL_PARTY actPokeParty, [In] ref BattleAi.Result aiResult)
	{
		return default(BTL_ACTION_PARAM);
	}

	private void buildActionParamFromAiResult_Fight(ref BTL_ACTION_PARAM actionParam, BTL_POKEPARAM actPoke, [In] ref BattleAi.Result aiResult)
	{
	}

	private void buildActionParam_Safari(ref BTL_ACTION_PARAM actionParam, byte actPokeIndex, BTL_POKEPARAM actPoke)
	{
	}

	private bool canStartGForNPC(BTL_POKEPARAM pActPoke)
	{
		return default(bool);
	}

	private void decideRaidBossGWazaAction(ref BTL_ACTION_PARAM destAction)
	{
	}

	private BtlPokePos decideRaidBossGWazaTarget()
	{
		return default(BtlPokePos);
	}

	private void correctRaidBossGWazaTarget_JK3(RaidBoss.SelectTargetParam pSelectParam)
	{
	}

	private WazaNo decideRaidBossWaza(BTL_POKEPARAM boss, BTL_POKEPARAM target)
	{
		return default(WazaNo);
	}

	private bool isRaidBossGWazaUseTurn(BTL_POKEPARAM boss)
	{
		return default(bool);
	}

	private bool canRaidBossUseGWazaIfNotG(BTL_POKEPARAM boss)
	{
		return default(bool);
	}

	public byte countPuttablePokemons(byte[] list)
	{
		return default(byte);
	}

	private byte countPuttablePokemons_sub(byte[] list, byte numFrontPos)
	{
		return default(byte);
	}

	private unsafe void sortPuttablePokemonList(byte* list, byte numPoke, BTL_POKEPARAM target, BtlPokePos posForCheckEffect)
	{
	}

	private bool changeAI_IsSpecialMons(BTL_POKEPARAM bpp)
	{
		return default(bool);
	}

	private bool isExistHPRecoverEffect(BtlPokePos pos)
	{
		return default(bool);
	}

	private void setupPokeSelParam(byte numSelect, PokeSelParam param, PokeSelResult result)
	{
	}

	private void storePokeSelResult(PokeSelResult res)
	{
	}

	private void storePokeSelResult_ForceQuit()
	{
	}

	private byte storeMyChangePokePos(BtlPokePos[] myCoverPos)
	{
		return default(byte);
	}

	private bool SubProc_UI_SelectChangeOrEscape(ref int seq)
	{
		return default(bool);
	}

	private bool SubProc_UI_SelectPokemonForCover(ref int seq)
	{
		return default(bool);
	}

	private bool SubProc_UI_SelectPokemonForChange(ref int seq)
	{
		return default(bool);
	}

	private bool SubProc_AI_SelectPokemon(ref int seq)
	{
		return default(bool);
	}

	private void sortChangePos(BtlPokePos[] posAry, uint posCnt)
	{
	}

	private bool SubProc_REC_SelectPokemon(ref int seq)
	{
		return default(bool);
	}

	private bool selectPokemonUI_Core(ref int seq, bool bForceChangeMode)
	{
		return default(bool);
	}

	private bool SubProc_UI_ConfirmIrekae(ref int seq)
	{
		return default(bool);
	}

	private bool SubProc_UI_RecordData(ref int seq)
	{
		return default(bool);
	}

	private bool SubProc_REC_ExitCommTrainer(ref int seq)
	{
		return default(bool);
	}

	private bool SubProc_UI_ExitCommTrainer(ref int seq)
	{
		return default(bool);
	}

	private bool SubProc_ExitCommTrainer(ref int seq, bool isRecPlayMode)
	{
		return default(bool);
	}

	private BtlResult expandServerResult(out ResultCause resultCause)
	{
		return default(BtlResult);
	}

	private bool getVsCommTrainerExitMessage(BTLV_STRPARAM strParam, BtlResult battleResult, bool isMultiMode)
	{
		return default(bool);
	}

	private bool isEnemyClientDouble()
	{
		return default(bool);
	}

	private void trainerGraphicIn(int client_idx)
	{
	}

	private void msgWinningTrainerStart()
	{
	}

	private bool SubProc_REC_ExitForNPC(ref int seq)
	{
		return default(bool);
	}

	private bool SubProc_UI_ExitForNPC(ref int seq)
	{
		return default(bool);
	}

	private bool SubProc_REC_ExitForSubwayTrainer(ref int seq)
	{
		return default(bool);
	}

	private bool SubProc_UI_ExitForSubwayTrainer(ref int seq)
	{
		return default(bool);
	}

	private bool SubProc_ExitForSubwayTrainer(ref int seq, bool isRecPlayMode)
	{
		return default(bool);
	}

	private void setupSubwayTrainerMsg(BtlResult result, byte client_idx)
	{
	}

	public void GetBonusMoneyGettingStr(BTLV_STRPARAM strParam, uint bonus)
	{
	}

	private void setBonusMoneyGettingStr(BTLV_STRPARAM strParam, uint bonus)
	{
	}

	private bool SubProc_UI_WinWild(ref int seq)
	{
		return default(bool);
	}

	private bool SubProc_UI_LoseWild(ref int seq)
	{
		return default(bool);
	}

	private bool SubProc_UI_ForceQuitWild(ref int seq)
	{
		return default(bool);
	}

	private bool SubProc_UI_CaptureWild(ref int seq)
	{
		return default(bool);
	}

	private bool SubProc_UI_NotifyTimeUp(ref int seq)
	{
		return default(bool);
	}

	private void getTimeUpMessage(out uint strID, out BtlStrType strType)
	{
	}

	private void getTimeUpMessage_ClientLimitTime(out uint strID, out BtlStrType strType)
	{
	}

	private bool SubProc_UI_FadeOut(ref int seq)
	{
		return default(bool);
	}

	private bool SubProc_REC_FadeOut(ref int seq)
	{
		return default(bool);
	}

	public bool isEvolveEnablePokeExsist()
	{
		return default(bool);
	}

	private bool SubProc_UI_SendLastDataAgain(ref int seq)
	{
		return default(bool);
	}

	private bool SubProc_UI_SendClientLimitTime(ref int seq)
	{
		return default(bool);
	}

	private bool SubProc_UI_SyncClientLimitTime(ref int seq)
	{
		return default(bool);
	}

	private bool SubProc_UI_RaidBossCapture_Start(ref int seq)
	{
		return default(bool);
	}

	private uint getRaidBossCaptureStartSeqNo()
	{
		return default(uint);
	}

	private bool SubProc_UI_RaidBossCapture_SelectBall(ref int seq)
	{
		return default(bool);
	}

	private bool SubProc_UI_RaidBossCapture_Result(ref int seq)
	{
		return default(bool);
	}

	private bool SubProc_UI_LoseRaid(ref int seq)
	{
		return default(bool);
	}

	private bool SubProc_REC_ServerCmd(ref int seq)
	{
		return default(bool);
	}

	private ServerCmdProc dispatchServerCmdProc(ServerCommand cmd)
	{
		return null;
	}

	private bool SubProc_UI_ServerCmd(ref int seq)
	{
		return default(bool);
	}

	private bool SubProc_AI_ServerCmd(ref int seq)
	{
		return default(bool);
	}

	private void storeWazaEffectSyncDamageParams(WAZAEFF_SYNCDAMAGE_CMD_WORK work, ServerCommand[] pTargetCmdList)
	{
	}

	private bool putWazaEffSyncDamage(WAZAEFF_SYNCDAMAGE_CMD_WORK work)
	{
		return default(bool);
	}

	private bool scProc_ACT_MemberOutMsg(ref int seq, int[] args)
	{
		return default(bool);
	}

	private ushort checkMemberOutStrID(byte clientID, byte pokeID, out bool fClientArg)
	{
		return default(ushort);
	}

	private bool scProc_ACT_MemberOut(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_ACT_MemberIn(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool IsTrainerMessageEnable_OnLastPokeIn(byte clientID)
	{
		return default(bool);
	}

	private void StartTrainerMessage(byte clientID, TrainerMessageID messageID)
	{
	}

	private bool UpdateTrainerMessage()
	{
		return default(bool);
	}

	private ushort checkMemberPutStrID(BTL_POKEPARAM putPoke)
	{
		return default(ushort);
	}

	private ushort getMemberPutStrID(BTL_POKEPARAM putPoke, BTL_POKEPARAM opponentPoke)
	{
		return default(ushort);
	}

	private bool scProc_MSG_Std(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_MSG_StdSE(ref int seq, int[] args)
	{
		return default(bool);
	}

	private unsafe bool scproc_msgStdCore(ref int seq, ushort strID, int* args, int argsLen)
	{
		return default(bool);
	}

	private bool scProc_MSG_Set(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_MSG_SetSE(ref int seq, int[] args)
	{
		return default(bool);
	}

	private unsafe bool scproc_msgSetCore(ref int seq, ushort strID, int* args, int argsLen)
	{
		return default(bool);
	}

	private bool scProc_MSG_Waza(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool needWazaMessageDisplay(WazaNo wazano, WazaTarget wazaRange, BtlPokePos attackerPos, BtlPokePos targetPos)
	{
		return default(bool);
	}

	private bool scProc_ACT_WazaEffect(ref int seq, int[] args)
	{
		return default(bool);
	}

	private WazaEffectCmdProcResult scproc_wazaEffProc_Start(int[] args)
	{
		return default(WazaEffectCmdProcResult);
	}

	private bool wazaEff_IsOmitFriendAttackEffect(WazaNo waza, WazaTarget wazaRange, BtlPokePos atkPokePos, BtlPokePos defPokePos)
	{
		return default(bool);
	}

	private WazaTarget checkWazaRange(WazaNo waza, BtlPokePos atPokePos)
	{
		return default(WazaTarget);
	}

	private bool scProc_ACT_TameWazaHide(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_ACT_WazaDmg(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_ACT_WazaDmg_Plural(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_ACT_WazaIchigeki(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_ACT_SickIcon(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_ACT_ConfDamage(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_ACT_Dead(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_ACT_Relive(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_ACT_RankDown(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_ACT_RankUp(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_IncWeatherPassedTurn(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_SetSpActPriority(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_SetActionRecord(ref int UnnamedParameter, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_AddEscapeInfo(ref int UnnamedParameter, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_GWallBreak(ref int UnnamedParameter, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_GWallGaugeAdd(ref int UnnamedParameter, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_GWallGaugeSub(ref int UnnamedParameter, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_GWallGaugeInit(ref int UnnamedParameter, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_GWallDecRepairTurn(ref int UnnamedParameter, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_GWallRepair(ref int UnnamedParameter, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_G_Start(ref int UnnamedParameter, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_G_End(ref int UnnamedParameter, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_G_IncTurn(ref int UnnamedParameter, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_GGauge_Inc(ref int UnnamedParameter, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_GGauge_Empty(ref int UnnamedParameter, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_RaidBoss_DecReinforceTurn(ref int UnnamedParameter, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_RaidBoss_SetReinforceTurn(ref int UnnamedParameter, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_RaidBoss_SetAngry(ref int UnnamedParameter, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_RaidBoss_GWazaUseSchedule_DecTurn(ref int UnnamedParameter, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_RaidBoss_GWazaUseSchedule_SetUsed(ref int UnnamedParameter, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_RaidBoss_GWazaUseSchedule_Reset(ref int UnnamedParameter, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_GRights_Transfer(ref int UnnamedParameter, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_GRights_Invalidate(ref int UnnamedParameter, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_GRights_IncTurn(ref int UnnamedParameter, int[] args)
	{
		return default(bool);
	}

	private bool scProc_ACT_GRights_Get(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_ACT_GRights_Get_MySelf(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_ACT_GRights_Get_Others(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_RaidBattleStatus_IncAllDeadCount(ref int UnnamedParameter, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_RaidBattleStatus_IncTurnCountAfterAllDead(ref int UnnamedParameter, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_RaidBattleStatus_ResetTurnCountAfterAllDead(ref int UnnamedParameter, int[] args)
	{
		return default(bool);
	}

	private bool scProc_ACT_RaidResult(ref int seq, int[] args)
	{
		return default(bool);
	}

	private void setupRaidRewardParam(BattleViewBase.RaidRewardParam pRewardParam)
	{
	}

	private bool scProc_ACT_SummarizedGShockEffect(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_ACTOP_BattleTalk(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_ACT_TurnStart(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_ACT_G_Start(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_ACT_G_End(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_ACTOP_WeatherStart(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool needWeatherStartEffect(ChangeWeatherCause cause)
	{
		return default(bool);
	}

	private int getWeatherStartMessage(BtlWeather weather, ChangeWeatherCause cause)
	{
		return default(int);
	}

	private bool scProc_ACT_WeatherEnd(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_WeatherEnd(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_ACT_SimpleHP(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_ACT_UseItem(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_ACT_KinomiPrevWaza(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_ACT_Kill(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_Move(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_ACT_Move(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_ACT_MigawariCreate(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_ACT_MigawariDelete(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_ACT_Hensin(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_Hensin(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_ACT_MigawariDamage(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_ACT_PlayWinBGM(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_ACT_MsgWinHide(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_ACT_FriendshipEffect(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_ACT_FriendshipEffectMsg(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_ACT_Exp_InitParam(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_ACT_Exp_AddParam(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_ACT_Exp(ref int seq, int[] args)
	{
		return default(bool);
	}

	private void updatePokeParamByLevelUp([In] ref BattleViewBase.ExpGetResult result)
	{
	}

	private bool copyWaza(PokemonParam pDest, PokemonParam pSrc)
	{
		return default(bool);
	}

	private bool scProc_OP_AddExp(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_ExArg(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_ExAssignClient_Start(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_AddWazaHandler(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_RemoveWazaHandler(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_RemoveForceWazaHandler(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_RemoveForceAllWazaHandler(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_AddTokuseiHandler(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_RemoveTokuseiHandler(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_SwapTokuseiHandler(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_AddItemHandler(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_RemoveItemHandler(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_AddPosHandler(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_RemovePosHandler(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_AddSideHandler(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_RemoveSideHandler(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_SleepSideHandler(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_WakeSideHandler(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_AddFieldHandler(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_RemoveFieldHandler(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_AddDefaultPowerUpHandler(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_RemoveDefaultPowerUpHandler(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_AddRaidBossHandler(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_RemoveRaidBossHandler(ref int seq, int[] args)
	{
		return default(bool);
	}

	public bool PrintCallback(PrintCallbackArg arg)
	{
		return default(bool);
	}

	private bool scProc_ACT_BallThrow(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_ACT_BallThrowCaptured(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_ACT_BallThrowForbidden(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_ACTOP_ChangeTokusei(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_ACTOP_SwapTokusei(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_ACT_FakeDisable(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_ACT_EffectSimple(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_ACT_EffectByPos(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_ACT_PluralEx2ndHit(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_ACT_EffectByVector(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_ACT_EffectBySide(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_ACT_EffectField(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_ChangeForm(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_ACT_ChangeForm(ref int seq, int[] args)
	{
		return default(bool);
	}

	private void updateClientPublicInformation_FormNo([In] ref BTL_POKEPARAM poke)
	{
	}

	private bool scProc_TOKWIN_In(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_TOKWIN_Out(ref int seq, int[] args)
	{
		return default(bool);
	}

	private void notifyTokuseiToAI(byte pokeID)
	{
	}

	private bool scProc_OP_HpMinus(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_HpPlus(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_PPMinus(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_PPMinus_Org(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_WazaUsed(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_IncWazaUsedCount(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_IncWazaKillCount(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_HpZero(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_PPPlus(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_PPPlus_Org(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_RankUp(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_RankDown(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_RankSet8(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_RankRecover(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_RankReset(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_RankUpReset(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_AddCritical(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_SickSet(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_CurePokeSick(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_CureWazaSick(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_MemberIn(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_ChangePokeType(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_ExPokeType(ref int UnnamedParameter, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_WSTurnCheck(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_ConsumeItem(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_UpdateUseWaza(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_SetContFlag(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_ResetContFlag(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_SetTurnFlag(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_ResetTurnFlag(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_SetPermFlag(ref int UnnamedParameter, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_SetBattleFlag(ref int UnnamedParameter, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_RemoveBattleFlag(ref int UnnamedParameter, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_IncBattleCount_Unique(ref int UnnamedParameter, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_IncBattleCount_Client(ref int UnnamedParameter, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_IncBattleCount_Side(ref int UnnamedParameter, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_IncPokeTurnCount(ref int UnnamedParameter, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_ChangeTokusei(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_SetItem(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_UpdateWazaNumber(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_OutClear(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_DeadClear(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_AddFldEff(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_AddFldEffDepend(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_ChangeGround(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_DelFldEffDepend(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_RemoveFldEff(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_SetPokeCounter(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_SetPokePermCounter(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_AddPokePermCounter(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_IncKillCount(ref int UnnamedParameter, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_BatonTouch(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_MigawariCreate(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_MigawariDelete(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_SetFakeSrc(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_FakeDisable(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_ClearConsumedItem(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_CureSickDependPoke(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_AddWazaDamage(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_TurnCheck(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_IncFieldTurn(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_SetDoryoku(ref int UnnamedParameter, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_AddEffort_G(ref int UnnamedParameter, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_StartPosEff(ref int UnnamedParameter, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_RemovePosEff(ref int UnnamedParameter, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_UpdatePosEffectParam(ref int UnnamedParameter, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_PGLRecord(ref int UnnamedParameter, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_SideEffect_Add(ref int UnnamedParameter, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_SideEffect_Remove(ref int UnnamedParameter, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_SideEffect_IncTurnCount(ref int UnnamedParameter, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_SideEffect_Swap(ref int UnnamedParameter, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_PublishClientInformation_AppaearPokemon(ref int UnnamedParameter, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_PublishClientInformation_HavePokemonItem(ref int UnnamedParameter, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_SetStatus(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_OP_SetWeight(ref int seq, int[] args)
	{
		return default(bool);
	}

	private VariableArgs PushTmpVariableArgsWork(VariableArgs newArgs)
	{
		return null;
	}

	private void PopTmpVariableArgsWork(VariableArgs oldArgs)
	{
	}

	private byte GetVariableArgsCount()
	{
		return default(byte);
	}

	private int GetVariableArgs(byte idx)
	{
		return default(int);
	}

	public byte GetClientID()
	{
		return default(byte);
	}

	public BTL_PARTY GetParty()
	{
		return null;
	}

	public BtlWeather GetWeather()
	{
		return default(BtlWeather);
	}

	public uint GetTurnCount()
	{
		return default(uint);
	}

	public BtlPokePos GetProcPokePos()
	{
		return default(BtlPokePos);
	}

	public bool IsUnselectableWaza(BTL_POKEPARAM bpp, WazaNo waza)
	{
		return default(bool);
	}

	private bool scProc_OP_DecBattleCount_Unique(ref int seq, int[] args)
	{
		return default(bool);
	}

	private bool scProc_ACT_Safari(ref int seq, int[] args)
	{
		return default(bool);
	}

	public bool CanChangePoke(BTL_POKEPARAM bpp)
	{
		return default(bool);
	}
}
