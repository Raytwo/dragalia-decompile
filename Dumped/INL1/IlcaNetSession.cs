using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using NexPlugin;
using UnityEngine;

namespace INL1;

public class IlcaNetSession : IlcaNetBase
{
	private enum GameState
	{
		GS_None,
		GS_AsyncWait,
		GS_NexLogOutWait,
		GS_NexPiaInitialize,
		GS_NetworkStartedUp,
		GS_NetworkStartedUpNEX,
		GS_LoggedIn,
		GS_LoggedInWaitWorker,
		GS_LoggedInReturnStep,
		GS_LoggedInReturnWaitWorker,
		GS_SessionStartedUp,
		GS_BrowseSession,
		GS_BrowseSessionAfter_LocalRandom,
		GS_BrowseSessionAfter_InternetRandomAikotobaBefore,
		GS_BrowseSessionAfter_InternetRandomAikotoba,
		GS_CreateOrJoinSessionBefore,
		GS_CreateOrJoinSession,
		GS_JoinProcess,
		GS_JoinProcessRandom,
		GS_JoinProcess_LocalRandom,
		GS_GameFrontBefore_LocalRandom,
		GS_GameFront,
		GS_Game,
		GS_GameLeave,
		GS_GameError,
		GS_HandleErrorWait,
		GS_HandleErrorWaitWorker,
		GS_ErrorHandling,
		GS_Logout,
		GS_LogoutWaitWorker,
		GS_PiaFrameworkFinalize,
		GS_PiaFrameworkFinalizeAfter,
		GS_Final,
		GS_Crash,
		GS_Max
	}

	private enum GameAsync
	{
		NoWork,
		SessionOpenWait,
		SessionCloseWait
	}

	public delegate void IlcaNetSessionFinalCallback();

	public delegate void IlcaNetSessionEventCallback(IlcaNetSessionEventCallbackType eve, int stationIndex);

	public delegate void UserSessionOpenCloseAsyncCompleteCallback(IlcaNetSessionOpenStatus nowOpenClose);

	private enum GSWaitWorkerEnum
	{
		To_GS_SessionStartedUp,
		To_GS_LoggedIn
	}

	private class getProListMod
	{
		public uint id;

		public PiaPluginSession.SessionProperty pro;
	}

	private static IlcaNetSessionSetting sampleset;

	private static IlcaNetSessionState netSessionState;

	private static GameState netGameState;

	private static GameState netNextGameState;

	private static PiaPlugin.AsyncProcessId netAsyncProcessId;

	private static GameAsync netGameState_Game_AsyncWait;

	private static IlcaNetSessionOpenStatus netSessionOpenCloseStatus;

	private static IlcaNetSessionOpenStatus netSessionOpenCloseStatusTarget;

	private static bool isCompletedSessionOpenCloseStatus;

	public const int maxNetGamer = 16;

	public static IlcaNetStation NetStation;

	public static IlcaNetGamer[] NetGamer;

	public static IlcaNetGamer[] NetGamer2;

	private static byte[] gamerNameConvBuff;

	private static PiaPlugin.Result lastErrorResult;

	private static bool isNetworkFinalRequest;

	private static bool isSessionLeaveRequest;

	private static IlcaNetSessionState sessionLeaveRequestState;

	private static bool isLogoutFinalizeAsyncMoving;

	private static bool isErrorHandleMoving;

	private static bool isCrash;

	private static byte[] gameFront_r_no;

	private static ushort[] gameFront_cnt;

	private static uint localRandomSessionList_counter;

	private static ushort localSessionRandomValue;

	private static bool checkSessionStateNowOnStageInConnected;

	private static ushort autoRetryRandomMatchmakeCounter;

	private static IlcaNetSessionFinalCallback finalRequestCallbackfunc;

	private static bool isSystemCallBackReady;

	private static IlcaNetSessionEventCallback sessionEventCallbackfunc;

	private static bool isSessionEventCallbackFuncReady;

	private static IlcaNetSessionCallbackMode sessionEventCallbackFuncDelayMode;

	private static int sessionEventCallbackQueueCount;

	private const int sessionEventCallbackQueueSize = 128;

	private static PiaPluginSession.SessionEvent[] sessionEventCallbackEventQueue;

	private static PiaPluginSession.JoinSessionSetting sjSsetting;

	private static PiaPluginSession.UpdateSessionSetting suaSetting;

	private static UserSessionOpenCloseAsyncCompleteCallback openCloseCallback;

	private static bool DangerousEmergencyErrorRequest;

	private static PiaPlugin.Result DangerousEmergencyErrorRequestResult;

	private static ulong debugCount;

	private static PiaPlugin.AsyncProcessId updateDispatchWorkerAsyncProcessId;

	private static bool updateDispatchWorkerdispatchResultFlag;

	private static PiaPlugin.Result updateDispatchWorkerdispatchResult;

	private static bool updateDispatchWorkerAsyncResultFlag;

	private static PiaPlugin.Result updateDispatchWorkerAsyncResult;

	private static bool updateDispatchWorkerdispatchSuspendGoing;

	private static bool updateDispatchWorkerdispatchSuspendFinish;

	private static bool updateDispatchWorkerdispatchResultFlagSuspend;

	private static PiaPlugin.Result updateDispatchWorkerdispatchResultSuspend;

	public static List<PiaPluginSession.SessionEvent> sessionEventListSuspendDispatch;

	private static PiaPluginSession.SessionEvent leaveEvent;

	private static PiaPlugin.JoinRandomSessionSetting joinRandomSessionSetting;

	private static PiaPluginSession.CreateSessionSetting createSessionSetting;

	private static PiaPluginSession.CreateSessionSetting.Attribute[] createAttribute;

	private static List<PiaPluginSession.CreateSessionSetting.Attribute> createAttributeList;

	private static PiaPluginSession.SessionSearchCriteria[] sessionSearchCriteriaList;

	private static PiaPluginSession.SessionSearchCriteria.AttributeRange[] searchAttributeRange;

	private static List<PiaPluginSession.SessionSearchCriteria.AttributeRange> searchAttributeRangeList;

	private static List<PiaPluginSession.SessionProperty> getproListAikotoba;

	private static List<getProListMod> getproListIndex;

	private const int OverPasswordMagicNunberSize = 4;

	private const int OverPasswordIDposition = 4;

	private const int OverPasswordSizePosition = 5;

	private const int OverPasswordDataPosition = 6;

	private const int OverPasswordMinSize = 7;

	private static bool isErrorHandleNexInitialize;

	private static PiaPlugin.State errorHandleNextSessionState;

	static IlcaNetSession()
	{
	}

	private static void DebugDispSet()
	{
	}

	private static void DebugDispClear()
	{
	}

	public static bool Init(MonoBehaviour callobj)
	{
		return default(bool);
	}

	public static bool Init(MonoBehaviour callobj, IlcaNetSessionFinalCallback finalCallback)
	{
		return default(bool);
	}

	private static void SessionFinalCallbackSet(IlcaNetSessionFinalCallback finalRequestCallback)
	{
	}

	public static bool SessionEventCallbackFuncSet(IlcaNetSessionEventCallback func)
	{
		return default(bool);
	}

	public static bool SessionEventCallbackFuncSet(IlcaNetSessionEventCallback func, IlcaNetSessionCallbackMode callBackMode)
	{
		return default(bool);
	}

	public static bool NetworkInitAsync(IlcaNetSessionSetting setting)
	{
		return default(bool);
	}

	private static void NetworkInitAsyncNexWait()
	{
	}

	public static IlcaNetSessionState State()
	{
		return default(IlcaNetSessionState);
	}

	public static IlcaNetSessionState Update()
	{
		return default(IlcaNetSessionState);
	}

	public static void UpdateBottom()
	{
	}

	public static bool NetworkFinalRequestAsync()
	{
		return default(bool);
	}

	private static bool NetworkFinalAsync()
	{
		return default(bool);
	}

	public static bool SettingSet(IlcaNetSessionSetting setting)
	{
		return default(bool);
	}

	private static void CleanUpCore()
	{
	}

	private static void NetworkTransportInit()
	{
	}

	private static void GameFrontRnoInit()
	{
	}

	private static void StationIndexCasheInit()
	{
	}

	private static void SystemCallBackInit()
	{
	}

	private static void SystemCallBackFinal()
	{
	}

	private static void SessionEventUserCallbackInit()
	{
	}

	private static void SessionEventUserCallbackInitAll()
	{
	}

	private static void SessonOpenCloseInit()
	{
	}

	public static bool IsHost()
	{
		return default(bool);
	}

	public static int ThisStationIndex()
	{
		return default(int);
	}

	public static int HostStationIndex()
	{
		return default(int);
	}

	public static int NumStation()
	{
		return default(int);
	}

	public static int NumGamer()
	{
		return default(int);
	}

	public static int PlayerNumMaxCurrentlySetting()
	{
		return default(int);
	}

	public static bool IsSessionOnStageInConnected()
	{
		return default(bool);
	}

	private static bool SessionOnStageCheck(ref PiaPluginSession.SessionStatus session)
	{
		return default(bool);
	}

	public static void MatchingBlockRelease()
	{
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static uint GetSendUnreliableDataSizeMax()
	{
		return default(uint);
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static uint SessionID()
	{
		return default(uint);
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static int CallbackQueueNum()
	{
		return default(int);
	}

	public static uint ErrorResultGet()
	{
		return default(uint);
	}

	public static PiaPlugin.Result ErrorResultGetForFamily()
	{
		return default(PiaPlugin.Result);
	}

	public static uint SessionListSizeGet()
	{
		return default(uint);
	}

	public static bool SessionListPropertyGet(uint index, ref IlcaNetSessionProperty pro)
	{
		return default(bool);
	}

	public static bool SessionSearchRetryAsync()
	{
		return default(bool);
	}

	public static bool SessionJoinAsync(uint index)
	{
		return default(bool);
	}

	public static bool SessionJoinAsync(uint index, string password)
	{
		return default(bool);
	}

	private static bool SessionJoinAsyncCore(uint index, string password, uint sessionId, GameState nextState)
	{
		return default(bool);
	}

	public static bool SessionCreateAsync()
	{
		return default(bool);
	}

	public static bool SessionCreateAsync(string password)
	{
		return default(bool);
	}

	private static bool SessionCreateAsyncCore(string password, GameState nextState = GameState.GS_JoinProcess)
	{
		return default(bool);
	}

	public static bool SessionRandomAsync()
	{
		return default(bool);
	}

	public static bool SessionUpdateApplicationDataBufferAsync(byte[] appData, int appDataSize)
	{
		return default(bool);
	}

	public static bool SessionCloseHostAsync([Optional] UserSessionOpenCloseAsyncCompleteCallback callback)
	{
		return default(bool);
	}

	public static bool SessionOpenHostAsync([Optional] UserSessionOpenCloseAsyncCompleteCallback callback)
	{
		return default(bool);
	}

	private static bool SessionOpenCloseHostAsyncCore(IlcaNetSessionOpenStatus nowstate, IlcaNetSessionOpenStatus targetstate)
	{
		return default(bool);
	}

	private static bool SessionOpenCloseHostAsyncCompleted()
	{
		return default(bool);
	}

	private static bool IsSessionOpenCloseHost(IlcaNetSessionOpenStatus state)
	{
		return default(bool);
	}

	private static bool IsSessionToOpenCloseHost(IlcaNetSessionOpenStatus state)
	{
		return default(bool);
	}

	private static bool IsSessionClose()
	{
		return default(bool);
	}

	private static bool IsSessionOpen()
	{
		return default(bool);
	}

	public static bool SessionLeaveRequestAsync()
	{
		return default(bool);
	}

	public static bool SessionRestartRequestAsync()
	{
		return default(bool);
	}

	private static bool SessionLeaveRequestAsync(IlcaNetSessionState state)
	{
		return default(bool);
	}

	private static bool SessionLeaveDefaultCheck(IlcaNetSessionState state)
	{
		return default(bool);
	}

	private static bool SessionLeaveAsyncCore(IlcaNetSessionState state)
	{
		return default(bool);
	}

	private static bool NetGamerNameGet(PiaPluginSession.SessionEvent ev, ref string gamerName, ref byte nameStringLanguage)
	{
		return default(bool);
	}

	private static bool CleanupRecoveryToLoggedIn()
	{
		return default(bool);
	}

	private static bool CleanupRecoveryToLoggedIn2phase()
	{
		return default(bool);
	}

	private static void DangerousEmergencyCall()
	{
	}

	public static void DangerousEmergencyError(int level)
	{
	}

	private static void DangerousEmergencyErrorCore()
	{
	}

	private static void AnalysisResultPrintCore()
	{
	}

	private static bool SessionFinalizeProcessMovingCheck()
	{
		return default(bool);
	}

	private static bool EmergencyCheckFromFamilyClass()
	{
		return default(bool);
	}

	private static bool NetworkFinalRequestCheck()
	{
		return default(bool);
	}

	private static bool SessionLeaveRequestCheck()
	{
		return default(bool);
	}

	private static void SessionStatusCheckForFamilyClass()
	{
	}

	private static IlcaNetSessionState UpdateCore()
	{
		return default(IlcaNetSessionState);
	}

	private static void UpdateDispatchWorkerTh()
	{
	}

	private static bool UpdateDispatchWorkerSet(PiaPlugin.AsyncProcessId apid, bool PriorityMode2 = false)
	{
		return default(bool);
	}

	private static void UpdateDispatchWorkerThSuspend()
	{
	}

	private static bool UpdateDispatchWorkerSetSuspend()
	{
		return default(bool);
	}

	public static bool SuspendON()
	{
		return default(bool);
	}

	public static bool SuspendOFFRequest()
	{
		return default(bool);
	}

	public static bool SuspendOFF()
	{
		return default(bool);
	}

	private static bool SuspendFinishCheck(bool first)
	{
		return default(bool);
	}

	private static void UpdateDispatchCore(bool first)
	{
	}

	private static void DispatchAftre(bool first, List<PiaPluginSession.SessionEvent> sessionEventList)
	{
	}

	private static void SessionToTransportSet(bool first, List<PiaPluginSession.SessionEvent> sessionEventList)
	{
	}

	private static void NetStationBootCheck()
	{
	}

	private static void UpdateSwitchCore()
	{
	}

	private static bool IsAllNetworkAsyncCompleted()
	{
		return default(bool);
	}

	private static void SessionStateSet(IlcaNetSessionState sessionEnum)
	{
	}

	private static IlcaNetSessionState SessionStateNow()
	{
		return default(IlcaNetSessionState);
	}

	private static void GameStateChangeSet(GameState setState)
	{
	}

	private static void GameStateChangeSet(GameState setState, PiaPlugin.AsyncProcessId waitAsycId, GameState setNextState)
	{
	}

	private static GameState GameStateNow()
	{
		return default(GameState);
	}

	private static void CallBackExtension(List<PiaPluginSession.SessionEvent> sessionEventList, bool first)
	{
	}

	private static bool CallbackEventQueueCheck()
	{
		return default(bool);
	}

	private static void CallbackEventQueueCore([In] ref List<PiaPluginSession.SessionEvent> sessionEventList)
	{
	}

	private static void CallBackExtensionCore(PiaPluginSession.SessionEvent ev, int i, [Optional] string str)
	{
	}

	private static void CallBackExtensionCoreEventJoin(ref IlcaNetGamer gamer, PiaPluginSession.SessionEvent ev)
	{
	}

	private static void CallBackNetGamerLastEventLeave()
	{
	}

	private static void GameState_AsyncWaitCore()
	{
	}

	private static void GameState_NexPiaInitialize()
	{
	}

	private static void GameState_NetworkStartedUp()
	{
	}

	private static void GameState_NetworkStartedUp_NexCallBack(AsyncResult asyncResult)
	{
	}

	private static void GameState_NetworkStartedUp_after()
	{
	}

	private static void GameState_LoggedIn()
	{
	}

	private static void GameState_LoggedInAfter()
	{
	}

	private static void GameState_WaitWorker(GSWaitWorkerEnum mode)
	{
	}

	private static void GameState_LoggedInReturnStep()
	{
	}

	private static void GameState_SessionStartedUp()
	{
	}

	private static void CreateSessionSet(string password)
	{
	}

	private static void SearchSessionSet()
	{
	}

	private static void GameState_BrowseSession()
	{
	}

	private static void GameState_CreateOrJoinSessionBefore()
	{
	}

	private static void GameState_BrowseSessionAfter_InternetRandomAikotoba()
	{
	}

	private static int getproListCompIDIndex(getProListMod a, getProListMod b)
	{
		return default(int);
	}

	private static int getproListCompPlayerNumIndex(getProListMod a, getProListMod b)
	{
		return default(int);
	}

	private static void GameState_BrowseSessionAfter_LocalRandom2()
	{
	}

	private static bool OverPasswordMagicNumberIDCheck(ref byte[] c, int i)
	{
		return default(bool);
	}

	private static uint OverPasswordSizeGet(ref byte[] c, int i)
	{
		return default(uint);
	}

	private static bool OverPasswordCompare(ref byte[] c1, int i, ref byte[] c2, int j, uint size)
	{
		return default(bool);
	}

	private static void ToGameFrontBeforeLocalRandom()
	{
	}

	private static void ToGameFront()
	{
	}

	private static void ToGameInit()
	{
	}

	private static void autoRetryRandomMatchmakeCounterReset()
	{
	}

	private static bool AutoRetryCheck(PiaPlugin.Result result)
	{
		return default(bool);
	}

	private static void GameState_JoinProcessAll()
	{
	}

	private static bool InternetRandomMatchCheck()
	{
		return default(bool);
	}

	private static bool InternetRandomAikotobaMatchCheck()
	{
		return default(bool);
	}

	private static bool LocalRandomMatchCheck()
	{
		return default(bool);
	}

	private static bool LanRandomMatchCheck()
	{
		return default(bool);
	}

	private static void GameState_GameFrontBefore_LocalRandom()
	{
	}

	private static void GameState_GameFront()
	{
	}

	private static void GameState_Game()
	{
	}

	private static bool CheckSessionOpenCloseStatus()
	{
		return default(bool);
	}

	private static void GameState_LogoutCore()
	{
	}

	private static void GameState_LogoutWaitWorker()
	{
	}

	private static void GameState_PiaFrameworkFinalize()
	{
	}

	private static void GameState_PiaFrameworkFinalizeWorkerTh()
	{
	}

	private static void GameState_PiaFrameworkFinalizeCoreAfter()
	{
	}

	private static void GameState_ErrorHandling(bool direct = false)
	{
	}

	private static void GameState_ErrorHandlingCoreToCrash()
	{
	}

	private static void GameState_ErrorHandlingCoreToError()
	{
	}

	private static void GameState_ErrorHandlingCoreViewer(PiaPlugin.Result res)
	{
	}

	private static void HandleError(PiaPlugin.Result errorResult)
	{
	}

	private static void HandleErrorCore()
	{
	}

	private static void GameState_HandleErrorWaitWorker()
	{
	}

	private static void GameState_HandleErrorWait()
	{
	}

	private static PiaPlugin.State MyConvertHandlingTypeToStat(PiaPlugin.HandlingType handle)
	{
		return default(PiaPlugin.State);
	}
}
