using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DPData;
using Dpr.BallDeco;
using Dpr.Battle.Logic.Net;
using Dpr.Trainer;
using Pml;
using Pml.PokePara;
using XLSXContent;
using poketool;

namespace Dpr.Battle.Logic;

public class MainModule
{
	private delegate bool pSubProc(ref int UnnamedParameter);

	private delegate bool pMainProc();

	private enum LocalSeq
	{
		kNone,
		kDetermingServer,
		kNotifyServerParam,
		kStartWaitServerParam,
		kWaitingServerParamNotified,
		kEnd
	}

	public enum BtlDetailRule
	{
		WildSingle,
		TrainerSingle,
		TrainerDouble1,
		TrainerDouble2,
		WildMulti,
		TrainerMulti,
		L1,
		L2,
		L3,
		L4,
		L5,
		L6,
		L7,
		L8,
		F1,
		F2,
		F3,
		F4,
		C,
		G1,
		G2,
		G3,
		G4,
		BTW,
		Joker1,
		Joker2,
		Safari
	}

	private BATTLE_SETUP_PARAM m_setupParam;

	private BattleViewBase m_viewCore;

	private Random m_randSys;

	private ulong m_randomSeed;

	private pSubProc m_subProc;

	private int m_subSeq;

	private int m_setupStep;

	private pMainProc m_mainLoop;

	private PokeParty[] m_srcParty;

	private PokeParty[] m_srcPartyForServer;

	private PokeParty m_tmpParty;

	private MyStatus m_playerStatus;

	private bool[] m_fClientQuit;

	private BtlRule m_rule;

	private uint m_regularMoney;

	private uint m_bonusMoney;

	private uint m_loseMoney;

	private MSGSPEED m_msgSpeed;

	private ushort m_LimitTimeGame;

	private ushort m_LimitTimeClient;

	private ushort m_LimitTimeCommand;

	private BtlResult m_serverResult;

	private ResultCause m_serverResultCause;

	private byte m_myClientID;

	private BtlPokePos m_myOrgPos;

	private BATTLERULE m_changeMode;

	private byte m_MultiAIDataSeq;

	private byte m_MultiAIClientNum;

	private byte[] m_MultiAIClientID;

	private bool m_fCommError;

	private bool m_fCommErrorMainQuit;

	private bool m_fWazaEffectEnable;

	private bool m_fGetMoneyFixed;

	private bool m_fLoseMoneyFixed;

	private bool m_padding;

	private bool m_isFinalizeStarted;

	private BTL_SERVER m_server;

	private BTL_SERVER m_cmdCheckServer;

	private BTL_CLIENT[] m_client;

	private BTL_CLIENT[] m_dummyClient;

	private TRAINER_DATA[] m_trainerParam;

	private ClientPublicInformation[] m_clientPublicInformation;

	private AdapterFactory m_adapterFactory;

	private rec.Reader m_recReader;

	private bool[] m_moneyDblUpCause;

	private Dictionary<uint, uint> m_zukanDataOnBattleStart;

	private PokeIDRec m_deadPokeIDRec;

	private BattleEnv m_battleEnvForClient;

	private BattleEnv m_battleEnvForServer;

	public Client m_iPtrNetClient;

	public bool isInitialized;

	public bool isFinalized;

	private static readonly BtlvPos[][] rule_double_vpos;

	private static readonly BtlvPos[][] rule_double_vpos_PA_A;

	private static readonly BtlvPos[][] rule_raid_vpos1;

	private static readonly BtlvPos[][] rule_raid_vpos2;

	private static readonly BtlvPos[][] rule_raid_vpos3;

	private static readonly BtlvPos[][] rule_raid_vpos4;

	private CapsuleData DummyCapsuleData;

	public BATTLE_SETUP_PARAM GetBattleSetupParam()
	{
		return null;
	}

	public bool GetEnableTimeStop()
	{
		return default(bool);
	}

	public bool GetEnableVoiceChat()
	{
		return default(bool);
	}

	public bool IsSkyBattle()
	{
		return default(bool);
	}

	public bool IsMustCaptureMode()
	{
		return default(bool);
	}

	public void SetFairyGymResult(byte result)
	{
	}

	public byte GetFairyGymResult()
	{
		return default(byte);
	}

	public BattleViewBase GetBattleViewSystem()
	{
		return null;
	}

	public MainModule(BATTLE_SETUP_PARAM setupParam)
	{
	}

	public void Dispose()
	{
	}

	public IEnumerator InitializeCoroutine()
	{
		return null;
	}

	private void createBattleEnv()
	{
	}

	private void initializeBattleAiSystem()
	{
	}

	private Dictionary<uint, uint> createZukanDataClone()
	{
		return null;
	}

	public bool MainLoop(ref int seq)
	{
		return default(bool);
	}

	private void storeBattleResult()
	{
	}

	private bool isBgmFadeOutDisable()
	{
		return default(bool);
	}

	private bool checkRecReadComplete()
	{
		return default(bool);
	}

	public IEnumerator FinalizeCoroutine()
	{
		return null;
	}

	public bool FinalizeApp(ref int seq)
	{
		return default(bool);
	}

	public IEnumerator LeavenOnErrorCoroutine()
	{
		return null;
	}

	public void StartForceRemoveView()
	{
	}

	public bool WaitForceRemoveView()
	{
		return default(bool);
	}

	private void setMainLoop(pMainProc proc)
	{
	}

	private bool callMainLoop()
	{
		return default(bool);
	}

	private void setSubProc(pSubProc subProc)
	{
	}

	private bool callSubProc()
	{
		return default(bool);
	}

	private void setSubProcForSetup(BATTLE_SETUP_PARAM setup_param)
	{
	}

	private void setSubProcForCleanUp(BATTLE_SETUP_PARAM setup_param)
	{
	}

	private void setupCommon_TrainerParam(BATTLE_SETUP_PARAM sp)
	{
	}

	private void setupCommon_SetRecplayerClientMode(BATTLE_SETUP_PARAM sp)
	{
	}

	private void setupCommon_CreateViewModule(BATTLE_SETUP_PARAM sp, BtlBagMode bagMode)
	{
	}

	private bool setupCommon_InitViewModule()
	{
		return default(bool);
	}

	private void setupCommon_ClientPublicInformation([In] ref BATTLE_SETUP_PARAM setupParam)
	{
	}

	private void setupCommon_ClientPublicInformation(ClientPublicInformation publicInfo, byte clientId, [In] ref MiseaiData miseaiData)
	{
	}

	private bool setup_alone_single(ref int seq)
	{
		return default(bool);
	}

	private bool setup_alone_double(ref int seq)
	{
		return default(bool);
	}

	private bool setup_alone_double_multi(ref int seq)
	{
		return default(bool);
	}

	private bool setup_alone_double_multi_00(ref int seq)
	{
		return default(bool);
	}

	private bool setup_alone_double_multi_01(ref int seq)
	{
		return default(bool);
	}

	private bool setup_alone_double_multi_02(ref int seq)
	{
		return default(bool);
	}

	private bool setup_alone_double_multi_03(ref int seq)
	{
		return default(bool);
	}

	private bool setup_alone_double_multi_04(ref int seq)
	{
		return default(bool);
	}

	private bool setup_alone_double_multi_05(ref int seq)
	{
		return default(bool);
	}

	private bool setup_alone_double_multi_06(ref int seq)
	{
		return default(bool);
	}

	private bool setup_alone_double_multi_07(ref int seq)
	{
		return default(bool);
	}

	private bool setup_alone_double_multi_08(ref int seq)
	{
		return default(bool);
	}

	private bool setup_alone_double_multi_09(ref int seq)
	{
		return default(bool);
	}

	private bool setup_alone_raid(ref int seq)
	{
		return default(bool);
	}

	private bool setup_comm_raid(ref int seq)
	{
		return default(bool);
	}

	private bool setupseq_comm_raid(ref int seq)
	{
		return default(bool);
	}

	private void setup_raid_srcParty()
	{
	}

	private void setup_raid_trainerParam()
	{
	}

	private void setup_raid_battleEnv(BattleEnv env, bool forServer)
	{
	}

	private void setup_raid_boss(BattleEnv env)
	{
	}

	private void setupCommon_SetupBattleEnv()
	{
	}

	private void setupCommon_SetupBattleEnv(BattleEnv env)
	{
	}

	private void setupCommon_SetupBattleEnv_TimeLimit(BattleEnv env)
	{
	}

	private void setupCommon_SetupBattleEnv_GRights(BattleEnv env)
	{
	}

	private void setupCommon_SetupBattleEnv_BattleTalk(BattleEnv env)
	{
	}

	public void setupCommon_CreateServerClient([In] ref BATTLE_SETUP_PARAM setupParam)
	{
	}

	private BtlBagMode checkBagMode(BATTLE_SETUP_PARAM sp)
	{
		return default(BtlBagMode);
	}

	private void setup_alone_common_ClientID(BATTLE_SETUP_PARAM sp)
	{
	}

	private void setupCommon_srcParty(BATTLE_SETUP_PARAM sp)
	{
	}

	private void setSrcPartyToBattleEnv(BattleEnv battleEnv, byte clientID, bool forServer)
	{
	}

	public byte ClientIDtoRelation(byte myClientID, byte targetClientID)
	{
		return default(byte);
	}

	private bool cleanup_common(ref int seq)
	{
		return default(bool);
	}

	private bool setup_comm_single(ref int seq)
	{
		return default(bool);
	}

	private bool setup_comm_double(ref int seq)
	{
		return default(bool);
	}

	private bool setupseq_comm_determine_server(ref int seq)
	{
		return default(bool);
	}

	private bool setupseq_comm_store_party_data(ref int seq)
	{
		return default(bool);
	}

	private bool setupseq_comm_store_player_data(ref int seq)
	{
		return default(bool);
	}

	private bool setupseq_comm_create_server_client(ref int seq)
	{
		return default(bool);
	}

	private bool setupseq_comm_start_server(ref int seq)
	{
		return default(bool);
	}

	private bool MainLoop_StandAlone()
	{
		return default(bool);
	}

	private bool MainLoop_Comm_Server()
	{
		return default(bool);
	}

	private void watchRemoteClientCommunication()
	{
	}

	private void watchMyClientCommunication()
	{
	}

	private bool canLaunchDammyClient()
	{
		return default(bool);
	}

	private void launchDammyClient(BTL_CLIENT_ID clientId)
	{
	}

	private bool MainLoop_Comm_NotServer()
	{
		return default(bool);
	}

	private void watchRemoteServerLoss()
	{
	}

	private void changeServerSelf()
	{
	}

	private bool MainLoop_Comm_Error()
	{
		return default(bool);
	}

	public void OnCommError()
	{
	}

	public void NotifyCommErrorToLocalClient()
	{
	}

	public bool CheckAllClientQuit()
	{
		return default(bool);
	}

	public BtlRule GetRule()
	{
		return default(BtlRule);
	}

	public bool IsWazaEffectEnable()
	{
		return default(bool);
	}

	public byte GetMaxFollowPokeLevel()
	{
		return default(byte);
	}

	public bool NeedReduleHighLevelCaptureRate()
	{
		return default(bool);
	}

	public byte GetCaptureLevelCap()
	{
		return default(byte);
	}

	public byte GetExpLevelCap()
	{
		return default(byte);
	}

	public bool IsIrekaeMode()
	{
		return default(bool);
	}

	public bool IsCompetitorScenarioMode()
	{
		return default(bool);
	}

	public bool IsScenarioMultiBattle()
	{
		return default(bool);
	}

	public bool IsScenarioRaidBattle()
	{
		return default(bool);
	}

	public bool IsPokeItemConsumeBattle()
	{
		return default(bool);
	}

	public bool CanAddBonusMoney()
	{
		return default(bool);
	}

	public bool IsEscapeEnableBattle()
	{
		return default(bool);
	}

	public bool IsExpSeqEnable()
	{
		return default(bool);
	}

	public bool IsMoneySeqEnable()
	{
		return default(bool);
	}

	public BtlPokePos GetValidPosMax()
	{
		return default(BtlPokePos);
	}

	public uint GetFrontPosNum(byte clientID)
	{
		return default(uint);
	}

	public uint GetSidePosNum(BtlSide side)
	{
		return default(uint);
	}

	public uint GetOpponentFrontPosNum(byte clientID)
	{
		return default(uint);
	}

	public bool IsPokePosExist(BtlPokePos pos)
	{
		return default(bool);
	}

	public bool IsFrontPos(BtlPokePos pos)
	{
		return default(bool);
	}

	public BtlCompetitor GetCompetitor(bool isDemoCaptureConvert = true)
	{
		return default(BtlCompetitor);
	}

	public BtlCommMode GetCommMode()
	{
		return default(BtlCommMode);
	}

	public string GetWinBGMStr()
	{
		return null;
	}

	public BtlEscapeMode GetEscapeMode()
	{
		return default(BtlEscapeMode);
	}

	public bool CanUseEscapeItem()
	{
		return default(bool);
	}

	public BTL_FIELD_SITUATION GetFieldSituation()
	{
		return null;
	}

	public BtlWeather GetDefaultWeather()
	{
		return default(BtlWeather);
	}

	public byte GetDefaultGround()
	{
		return default(byte);
	}

	public BattleEffectComponentData GetBattleEffectData()
	{
		return null;
	}

	public byte GetForceQuitTurnCount()
	{
		return default(byte);
	}

	public MyStatus GetPlayerStatus()
	{
		return null;
	}

	public bool IsZukanRegistered(MonsNo monsno)
	{
		return default(bool);
	}

	public bool IsZukanRegistered(BTL_POKEPARAM bpp)
	{
		return default(bool);
	}

	public uint GetZukanCapturedCount()
	{
		return default(uint);
	}

	public bool IsZukanPokeSeeOnBattleStart(MonsNo monsno)
	{
		return default(bool);
	}

	public void RegisterZukanSeeFlag(BTL_POKEPARAM bpp)
	{
	}

	private bool canRegisterZukanSeeFlag(BTL_POKEPARAM pTarget)
	{
		return default(bool);
	}

	public void RegisterZukanSpGGetFlag(BTL_POKEPARAM bpp)
	{
	}

	public void IncrementZukanBattleCount(BTL_POKEPARAM bpp, bool isCaptured)
	{
	}

	public uint GetClientCoverPosNum(byte clientID)
	{
		return default(uint);
	}

	public BTL_CLIENT_ID GetPosCoverClientId(BtlPokePos pos)
	{
		return default(BTL_CLIENT_ID);
	}

	public bool IsExistClient(byte clientID)
	{
		return default(bool);
	}

	public BtlMultiMode GetMultiMode()
	{
		return default(BtlMultiMode);
	}

	public bool IsMultiMode()
	{
		return default(bool);
	}

	public bool IsPlayerRatingDisplay()
	{
		return default(bool);
	}

	public bool IsWatchMember()
	{
		return default(bool);
	}

	public BtlSide GetClientSide(byte clientID)
	{
		return default(BtlSide);
	}

	public bool IsPlayerSide(BtlSide side)
	{
		return default(bool);
	}

	public bool IsSideExist(BtlSide side)
	{
		return default(bool);
	}

	public void ExpandSide(BtlSide[] expandSide, ref byte expandSideNum, BtlSide side)
	{
	}

	public BtlPokePos GetSidePos(BtlSide side, byte index)
	{
		return default(BtlPokePos);
	}

	public byte GetSideNum()
	{
		return default(byte);
	}

	public byte GetClientNum()
	{
		return default(byte);
	}

	public byte GetClientNum(BtlSide side)
	{
		return default(byte);
	}

	public byte GetEnemyClientNum(byte clientID)
	{
		return default(byte);
	}

	public BtlPokePos GetOpponentPokePos(BtlPokePos basePos, byte idx)
	{
		return default(BtlPokePos);
	}

	public BtlPokePos GetFriendPokePos(BtlPokePos basePos, byte idx)
	{
		return default(BtlPokePos);
	}

	public bool IsFriendPokePos(BtlPokePos pos1, BtlPokePos pos2)
	{
		return default(bool);
	}

	public bool IsOpponentClientID(byte clientID1, byte clientID2)
	{
		return default(bool);
	}

	private byte btlPos_to_clientID(BtlPokePos btlPos)
	{
		return default(byte);
	}

	private void btlPos_to_cliendID_and_posIdx(BtlPokePos btlPos, out byte clientID, out byte posIdx)
	{
	}

	public BtlPokePos PokeIDtoPokePos(POKECON pokeCon, byte pokeID)
	{
		return default(BtlPokePos);
	}

	public BtlvPos PokeIDtoViewPos(POKECON pokeCon, byte pokeID)
	{
		return default(BtlvPos);
	}

	public byte BtlPosToClientID(BtlPokePos pos)
	{
		return default(byte);
	}

	public byte BtlPosToPosIdx(BtlPokePos pos)
	{
		return default(byte);
	}

	public void BtlPosToClientID_and_PosIdx(BtlPokePos pos, out byte clientID, out byte posIdx)
	{
	}

	public BtlvPos ClientIDtoTrainerViewPos(byte clientID)
	{
		return default(BtlvPos);
	}

	public BtlvPos BtlPosToViewPos(BtlPokePos pos)
	{
		return default(BtlvPos);
	}

	public BtlPokePos ViewPosToBtlPos(byte vpos)
	{
		return default(BtlPokePos);
	}

	public byte GetPlayerClientID()
	{
		return default(byte);
	}

	public byte GetPlayerFriendCleintID()
	{
		return default(byte);
	}

	public byte GetFriendCleintID(byte clientID)
	{
		return default(byte);
	}

	public byte GetEnemyClientID(byte idx)
	{
		return default(byte);
	}

	public uint GetOpponentClientID(byte clientID, byte idx)
	{
		return default(uint);
	}

	public bool DecrementPlayerItem(byte clientID, ushort itemID)
	{
		return default(bool);
	}

	public bool AddItem(byte clientID, ushort itemID)
	{
		return default(bool);
	}

	public bool IsRecordEnable()
	{
		return default(bool);
	}

	public void NotifyCapturedInfo([In] ref CaptureInfo info)
	{
	}

	public void NotifyTurnedLevelUpPokePos(byte pokeID)
	{
	}

	public bool CheckTurnedLevelUp(byte pokeID)
	{
		return default(bool);
	}

	public void NotifyRaidCaptureStart()
	{
	}

	public void NotifyRaidExitLose()
	{
	}

	public void NotifyBattleResult(BtlResult result, ResultCause resultCause, bool isForceSetEnable = false)
	{
	}

	public BtlResult GetBattleResult()
	{
		return default(BtlResult);
	}

	public ResultCause GetBattleResultCause()
	{
		return default(ResultCause);
	}

	public void NotifyCmdCheckError()
	{
	}

	public uint FixRegularMoney()
	{
		return default(uint);
	}

	public void AddBonusMoney(uint volume)
	{
	}

	public uint GetBonusMoney()
	{
		return default(uint);
	}

	public void SetMoneyDblUp(MoneyDblUpCause cause)
	{
	}

	private uint calcMoneyDblUpRatio()
	{
		return default(uint);
	}

	public uint FixLoseMoney()
	{
		return default(uint);
	}

	public void ReflectNatsukiDead(BTL_POKEPARAM bpp, bool fLargeDiffLevel)
	{
	}

	private void natsukiPut(BTL_POKEPARAM bpp, DaisukiType calcID)
	{
	}

	public void ReflectPokeWazaOboe(byte pokeID)
	{
	}

	public byte GetClientFrontPosCount(byte clientID)
	{
		return default(byte);
	}

	public byte GetClientBenchPosIndex(byte clientID)
	{
		return default(byte);
	}

	public bool IsPlayersPokeID(byte pokeID)
	{
		return default(bool);
	}

	public bool IsFriendPokeID(byte pokeID1, byte pokeID2)
	{
		return default(bool);
	}

	public BtlSide PokeIDtoSide(byte pokeID)
	{
		return default(BtlSide);
	}

	public BtlSide PokeIDtoOpponentSide(byte pokeID)
	{
		return default(BtlSide);
	}

	public BtlSide GetOpponentSide(BtlSide side)
	{
		return default(BtlSide);
	}

	public void SetIllusionForParty(BTL_PARTY party, byte clientID)
	{
	}

	public bool GetSetupStatusFlag(BTL_STATUS_FLAG flag)
	{
		return default(bool);
	}

	public void RECORDDATA_Inc(RECORD_ID recID)
	{
	}

	public void RECORDDATA_Add(RECORD_ID recID, uint value)
	{
	}

	public bool IsShooterEnable()
	{
		return default(bool);
	}

	public bool IsItemEnable()
	{
		return default(bool);
	}

	public bool IsFriendshipActive(BTL_POKEPARAM bpp)
	{
		return default(bool);
	}

	public byte GetPokeFriendship(BTL_POKEPARAM bpp)
	{
		return default(byte);
	}

	public bool CanEvolveAfterBattle([In] ref BTL_POKEPARAM poke)
	{
		return default(bool);
	}

	public void GetEvolveSituation(EvolveSituation dest, byte pokeId)
	{
	}

	public void NotifyPokemonLevelup(BTL_POKEPARAM bpp)
	{
	}

	public void CalcNatsukiItemUse(BTL_POKEPARAM bpp, ushort itemNo)
	{
	}

	public void NotifyPokemonGetToGameSystem(BTL_POKEPARAM bpp)
	{
	}

	public bool IsResultStrictMode()
	{
		return default(bool);
	}

	private BtlResult checkWinner(byte myClientId)
	{
		return default(BtlResult);
	}

	public uint GetCommandLimitTime()
	{
		return default(uint);
	}

	public uint GetClientLimitTime()
	{
		return default(uint);
	}

	public bool IsClientLimitTimeExist()
	{
		return default(bool);
	}

	public uint GetGameLimitTime()
	{
		return default(uint);
	}

	public bool IsGameLimitTimeExist()
	{
		return default(bool);
	}

	public bool CheckGameLimitTimeOver()
	{
		return default(bool);
	}

	public bool CheckClientLimitTimeOver()
	{
		return default(bool);
	}

	public bool IsLongEncount()
	{
		return default(bool);
	}

	public bool CheckRecPlayError()
	{
		return default(bool);
	}

	private void Bspstore_RecordData()
	{
	}

	public void StartFadeoutForRecPlay()
	{
	}

	public void ResetForRecPlay(uint nextTurnNum)
	{
	}

	public void NotifyChapterSkipEnd()
	{
	}

	public BTL_CLIENT GetClient(byte clientID)
	{
		return null;
	}

	public BTL_CLIENT GetClientByPokeID(byte pokeID)
	{
		return null;
	}

	private void Kentei_ClearField(BATTLE_SETUP_PARAM sp)
	{
	}

	private void Bspstore_KenteiData()
	{
	}

	private void trainerParam_Init()
	{
	}

	private void trainerParam_Clear()
	{
	}

	private void trainerParam_ClearCore(TRAINER_DATA data)
	{
	}

	public void trainerParam_StorePlayer(TRAINER_DATA dst, MyStatus playerData)
	{
	}

	public void trainerParam_StoreCore(TRAINER_DATA dst)
	{
	}

	private void trainerParam_StoreNPCTrainer(TRAINER_DATA dst, BSP_TRAINER_DATA trData)
	{
	}

	private void trainerParam_SetupForRecPlay(byte clientID)
	{
	}

	private bool trainerParam_IsExist(TRAINER_DATA trData)
	{
		return default(bool);
	}

	public bool IsClientTrainerExist(byte clientID)
	{
		return default(bool);
	}

	public bool IsClientNPC(byte clientID)
	{
		return default(bool);
	}

	public ushort GetClientUseItem(byte clientID, byte itemIdx)
	{
		return default(ushort);
	}

	public uint GetClientAIBit(byte clientID)
	{
		return default(uint);
	}

	public TRAINER_DATA GetClientTrainerData(byte clientID)
	{
		return null;
	}

	public TrainerID GetClientTrainerID(byte clientID)
	{
		return default(TrainerID);
	}

	public void GetClientTrainerMsg(byte clientID, TrainerMessageID messageID, out string outMessageLabel, out string outSequenceName)
	{
	}

	public string GetCliehtTrainerSequence(byte clientID, TrainerSequenceID sequenceID)
	{
		return null;
	}

	public string GetClientTrainerMsg(byte clientID, TrainerMessageID messageID)
	{
		return null;
	}

	public string GetClientTrainerName(byte clientID)
	{
		return null;
	}

	public string GetClientTrainerNameLabel(byte clientID)
	{
		return null;
	}

	public string GetClientTrainerTypeLabel(byte clientID)
	{
		return null;
	}

	public Sex GetClientTrainerSex(byte clientID)
	{
		return default(Sex);
	}

	public TrainerType GetClientTrainerType(byte clientID)
	{
		return default(TrainerType);
	}

	public TrainerTypeGroup GetClientTrainerGroup(byte clientID)
	{
		return default(TrainerTypeGroup);
	}

	public byte GetClientTrainerGold(byte clientID)
	{
		return default(byte);
	}

	public string GetClientTrainerModelID(byte clientID)
	{
		return null;
	}

	public int GetClientTrainerColorID(byte clientID)
	{
		return default(int);
	}

	public string GetClientTrainerWinEffect(byte clientID)
	{
		return null;
	}

	public HandDominance GetClientTrainerHandDominance(byte clientID)
	{
		return default(HandDominance);
	}

	public HandDominance GetClientTrainerHoldBallHandDominance(byte clientID)
	{
		return default(HandDominance);
	}

	public float GetClientTrainerThrowTime(byte clientID)
	{
		return default(float);
	}

	public float GetClientTrainerCaptureThrowTime(byte clientID)
	{
		return default(float);
	}

	public float GetClientTrainerLoseLoopTime(byte clientID)
	{
		return default(float);
	}

	public string GetClientTrainerEffect(byte clientID)
	{
		return null;
	}

	private TrainerTable.SheetTrainerData GetClientTrainerDataXLSX(byte clientID)
	{
		return null;
	}

	private TrainerTable.SheetTrainerType GetClientTrainerTypeDataXLSX(byte clientID)
	{
		return null;
	}

	public MyStatus GetClientPlayerData(byte clientID)
	{
		return null;
	}

	public ushort GetClientRating(byte clientID)
	{
		return default(ushort);
	}

	public ClientPublicInformation GetClientPublicInformation(byte clientID)
	{
		return null;
	}

	public bool IsRecordPlayMode()
	{
		return default(bool);
	}

	public bool CheckImServerMachine()
	{
		return default(bool);
	}

	public bool HasPlayerGakusyuSouti()
	{
		return default(bool);
	}

	public BtlPokePos GetClientPokePos(byte clientID, byte posIdx)
	{
		return default(BtlPokePos);
	}

	private void srcParty_Create()
	{
	}

	private void srcParty_Delete()
	{
	}

	private void srcParty_Set(byte clientID, [In] ref PokeParty party)
	{
	}

	private static void srcParty_FormChangeForX(PokeParty party)
	{
	}

	private static void srcParty_FromChange_OnBattleStart(PokemonParam pokeParam)
	{
	}

	private void setupUnknownPokeNickName(PokeParty party)
	{
	}

	public PokeParty GetSrcParty(byte clientID, bool fForServer)
	{
		return null;
	}

	public PartyDesc GetPartySetupParam(byte clientID)
	{
		return null;
	}

	public RaidBattleParam GetRaidBattleParam()
	{
		return null;
	}

	public static byte GetClientBasePokeID(byte clientID)
	{
		return default(byte);
	}

	public static byte PokeIDtoClientID(byte pokeID)
	{
		return default(byte);
	}

	public static byte PokeIDtoShortID(byte pokeID)
	{
		return default(byte);
	}

	public static byte ShortIDtoPokeID(byte clientID, byte shortID)
	{
		return default(byte);
	}

	public BtlPokePos GetFacedPokePos(BtlPokePos pos)
	{
		return default(BtlPokePos);
	}

	public bool IsFriendClientID(byte clientID_1, byte clientID_2)
	{
		return default(bool);
	}

	public BtlSide PosToSide(BtlPokePos pos)
	{
		return default(BtlSide);
	}

	public BATTLE_CONVENTION_INFO GetBattleConventionInfo(byte id)
	{
		return null;
	}

	public void NotifyPGLRecord(BTL_POKEPARAM bpp, PGLRecord.RecParam recParam)
	{
	}

	public void SetTvNaviData_FrontPoke(BTL_POKEPARAM bpp1, BTL_POKEPARAM bpp2)
	{
	}

	public void SetTvNaviData_UseWaza(BTL_POKEPARAM bpp, ushort wazaNo)
	{
	}

	public void NotifyPokemonDead(byte pokeID)
	{
	}

	public bool RankUpByClient(byte pokeID, BTL_POKEPARAM.ValueID rank, byte volume)
	{
		return default(bool);
	}

	public bool RankDownByClient(byte pokeID, BTL_POKEPARAM.ValueID rank, byte volume)
	{
		return default(bool);
	}

	public void SetUpRandSystem()
	{
	}

	public bool IsRaidBossRare()
	{
		return default(bool);
	}

	public bool IsGEnableByNPC(byte pokeID)
	{
		return default(bool);
	}

	public void WatchCmdAddReader()
	{
	}

	public bool NeedEndGOnBattleEnd()
	{
		return default(bool);
	}

	public void WatchDataRecvAfterFunc()
	{
	}

	public void UpdateNetClient()
	{
	}

	public void NotifyPokeMemory_AllDead(byte causedPokeID)
	{
	}

	public bool IsLiveCup()
	{
		return default(bool);
	}

	public void SyncClientLimitTimeForLiveCupWatcher([In] ref ServerSendData.CLIENT_LIMIT_TIME time)
	{
	}

	public void SendClientTimerForLiveCupWatcher(uint[] timeBuf, [In] ref uint num)
	{
	}

	public void PauseTimerForLiveCup()
	{
	}

	public void RestartTimerForLiveCup(uint gameTimeS)
	{
	}

	public uint GetRemainingGameTimeForLiveCup()
	{
		return default(uint);
	}

	public BtlDetailRule GetDetailRule()
	{
		return default(BtlDetailRule);
	}

	public byte GetBallDecoSeals(byte pokeID, ref AffixSealData[] sealData)
	{
		return default(byte);
	}

	private CapsuleData GetBallDeco(byte clientID, PokemonParam pp)
	{
		return default(CapsuleData);
	}

	public bool IsTurearukiPokemon(PokemonParam pp)
	{
		return default(bool);
	}
}
