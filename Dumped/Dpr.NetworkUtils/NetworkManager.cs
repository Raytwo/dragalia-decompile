using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Dpr.Message;
using Dpr.SubContents;
using INL1;
using Pml.PokePara;
using SmartPoint.AssetAssistant;
using XLSXContent;

namespace Dpr.NetworkUtils;

public class NetworkManager : SingletonMonoBehaviour<NetworkManager>
{
	public delegate void ReceivePacketCallback(PacketReader pr);

	public delegate void ReceivePacketExCallback(PacketReader pr, TransportType transportType, int receiveStationIndex);

	public delegate void SessionEventCallback(SessionEventData result);

	public delegate void FinishSessionCallback();

	public static ReceivePacketCallback onReceivePacket;

	public static ReceivePacketExCallback onReceivePacketEx;

	public static SessionEventCallback onSessionEvent;

	public static FinishSessionCallback onFinishedSession;

	private Dictionary<int, string> sessionErrorLogTable;

	private Dictionary<int, NetworkData.SheetErrorDialogInfo> networkErrorDialogTable;

	private SessionConnector sessionConnector;

	private NetworkParam networkParam;

	private PacketReader packetReader;

	private PacketWriter packetWriter;

	private PacketWriterRe packetWriterRe;

	private IlcaNetServerValidate.CheckRequest checkRequest;

	private IlcaNetServerValidate.CheckResponse checkResponse;

	private RequestValidateResult validateResult;

	private ValidateCheckResult singleValidateCheckResult;

	private ValidateCheckPluralResult pluralValidateCheckResult;

	private GMSTradeResult gmsTradeResult;

	private ErrorAppletResult appletResult;

	private ShowMessageWindow showMsgWindow;

	private int systemErrorDialogOpenCount;

	private ErrorCodeID systemErrorDialogCode;

	private static bool IsNetworkAvailable => default(bool);

	public static NetworkParam NetworkParam => null;

	public static bool IsInternetMode => default(bool);

	public static bool IsConnect => default(bool);

	public static bool IsDisconnected => default(bool);

	public static IlcaNetSessionState SessionState => default(IlcaNetSessionState);

	public static bool IsCrash => default(bool);

	public static bool IsHost => default(bool);

	public int MyStationIndex => default(int);

	public static PacketWriter PacketWriter => null;

	public static PacketWriterRe PacketWriterRe => null;

	public static int NowGamerNum => default(int);

	public static bool IsMaxJoinPlayer => default(bool);

	public static int GetMaxStation => default(int);

	public static void Reset()
	{
	}

	private void Start()
	{
	}

	private IEnumerator IE_Start()
	{
		return null;
	}

	private void InitCallbackParam()
	{
	}

	private void InitNotification()
	{
	}

	private void InitData()
	{
	}

	private void OnDestroy()
	{
	}

	public static void StartSessionRandomJoin(IlcaNetSessionNetworkType networkType, IlcaNetSessionGamingStartMode gamingStartMode, ushort gameMode, ushort playerNumMax, [Optional] Action<StartSessionResult> onCompleteStartSession)
	{
	}

	public static void StartSessionRandomJoin(IlcaNetSessionNetworkType networkType, IlcaNetSessionGamingStartMode gamingStartMode, ushort gameMode, ushort playerNumMax, bool bAutoSessionOpen, bool bAutoSessionClose, [Optional] Action<StartSessionResult> onCompleteStartSession)
	{
	}

	public static void StartSessionRandomJoin(IlcaNetSessionNetworkType networkType, IlcaNetSessionGamingStartMode gamingStartMode, ushort gameMode, ushort playerNumMax, string password, [Optional] Action<StartSessionResult> onCompleteStartSession, IlcaNetSessionCallbackLastEventLeave sessionCallbackLastEventLeave = IlcaNetSessionCallbackLastEventLeave.LastCall)
	{
	}

	public static void StartSessionRandomJoin(IlcaNetSessionNetworkType networkType, IlcaNetSessionGamingStartMode gamingStartMode, ushort gameMode, ushort playerNumMax, string password, bool bAutoSessionOpen, bool bAutoSessionClose, [Optional] Action<StartSessionResult> onCompleteStartSession)
	{
	}

	public static void StartSessionRandomJoin(IlcaNetSessionNetworkType networkType, IlcaNetSessionGamingStartMode gamingStartMode, ushort gameMode, ushort playerNumMax, string password, bool bAutoSessionOpen, bool bAutoSessionClose, [Optional] uint[] attributeValueArray, [Optional] uint[] attributeMinValueArray, [Optional] uint[] attributeMaxValueArray, [Optional] Action<StartSessionResult> onCompleteStartSession)
	{
	}

	public static void StartGMSTrade([Optional] Action<bool> onCompleteInternetGo)
	{
	}

	private void DoStartSession([Optional] Action<StartSessionResult> onCompleteStartSession)
	{
	}

	public static void JoinSessionRandom([Optional] Action<StartSessionResult> onSessionEventCallback)
	{
	}

	private static bool IsAlreadyConnectInternet()
	{
		return default(bool);
	}

	public static void CallInternetGo(bool ngsLogin, bool isShowMessage, Action<bool, SessionErrorType> onFinishedInternetGo, bool freePass = false, bool isNetworkMode = false)
	{
	}

	private void OpenConfirmConnectMsg(Action onSelectYes, Action onSelectNo)
	{
	}

	private void DoInternetGo(bool ngsLogin, bool bIsSaveOnSuccess, bool isAlreadyConnect, bool isShowMessage, Action<bool, SessionErrorType> onFinishedInternetGo, bool freePass = false)
	{
	}

	private IEnumerator IE_SaveFirstConnect(Action onComplete)
	{
		return null;
	}

	public static void RestartRequestAsync([Optional] uint[] attributeValueArray, [Optional] uint[] attributeMinValueArray, [Optional] uint[] attributeMaxValueArray)
	{
	}

	public uint GetSessionNum()
	{
		return default(uint);
	}

	public IlcaNetSessionProperty GetSessionProperty(uint index)
	{
		return null;
	}

	public IlcaNetSessionProperty[] GetAllSessionProperties()
	{
		return null;
	}

	public void RefreshSessionList(Action<bool> onCompleteSearch)
	{
	}

	public bool IsJoinOtherPlayer()
	{
		return default(bool);
	}

	public int GetHostStationIndex()
	{
		return default(int);
	}

	public bool IsGamerActive(int stationIndex)
	{
		return default(bool);
	}

	public static IlcaNetGamer GetGamerData(int stationIndex)
	{
		return null;
	}

	public string GetGamerName(int stationIndex, bool surroundFontTag = true)
	{
		return null;
	}

	public string GetGamerName(int stationIndex, int cassetVersion, bool surroundFontTag = true)
	{
		return null;
	}

	public MessageEnumData.MsgLangId GetGamerLangID(int stationIndex)
	{
		return default(MessageEnumData.MsgLangId);
	}

	public static int SendReliablePacket(PacketWriterRe packetWriterRe, int sendStationIndex, TransportType transportType = TransportType.Station)
	{
		return default(int);
	}

	public static int SendUnReliablePacket(PacketWriter packetWriter, int sendStationIndex, TransportType transportType = TransportType.Station)
	{
		return default(int);
	}

	public static int SendReliablePacketToAll(PacketWriterRe packetWriterRe, TransportType transportType = TransportType.Station)
	{
		return default(int);
	}

	public static int SendUnReliablePacketToAll(PacketWriter packetWriter, TransportType transportType = TransportType.Station)
	{
		return default(int);
	}

	public bool CloseSession()
	{
		return default(bool);
	}

	public bool OpenSession()
	{
		return default(bool);
	}

	public static bool LeaveSession()
	{
		return default(bool);
	}

	public static bool FinishSession()
	{
		return default(bool);
	}

	public void RequestValidateTrade(CoreParam coreParam, Action<ValidateCheckResult> onFinished)
	{
	}

	public void RequestValidateBattle(CoreParam[] coreParamArray, Action<ValidateCheckPluralResult> onFinished)
	{
	}

	public void RequestValidateGMS(CoreParam coreParam, Action<ValidateCheckResult> onFinished)
	{
	}

	private bool CheckValidateTargetData(CoreParam[] coreParamArray)
	{
		return default(bool);
	}

	private void SettingCheckRequestData(CoreParam[] coreParamArray)
	{
	}

	private void RequestValidateCheck(IlcaNetServerValidate.CheckRequest cReq, Action<RequestValidateResult> onCompleteCheck)
	{
	}

	private void CheckUpdateValidatePublicKey()
	{
	}

	private ValidateResultID CheckIllegalResultData()
	{
		return default(ValidateResultID);
	}

	public void DoGMSTrade(int dataPointNo, Action<GMSTradeResult> onComplete)
	{
	}

	public static bool SuspendOn()
	{
		return default(bool);
	}

	public static bool SuspendOff()
	{
		return default(bool);
	}

	public void OnUpdate(float deltaTime)
	{
	}

	public void CheckReceivePacket()
	{
	}

	private void CheckReceivePacketImpl(TransportType transportType, int receiveStationIndex, ReceivePacketCallback _onReceivePacket, ReceivePacketExCallback _onReceivePacketEx)
	{
	}

	private void OnLateUpdate(float deltaTime)
	{
	}

	private void OnSessionEvent(SessionEventData sessionEvent)
	{
	}

	private void OnFinishedSession()
	{
	}

	private void OnSessionError(SessionErrorType errorType)
	{
	}

	public void SetupMasterData(NetworkData networkData)
	{
	}

	public static void ShowApplicationErrorDialog(ErrorCodeID errorCodeId, [Optional] Action<ErrorAppletResult> onCloseWindow)
	{
	}

	public static bool IsShowApplicationErrorDialog()
	{
		return default(bool);
	}

	public static ErrorCodeID GetShowApplicationErrorCodeID()
	{
		return default(ErrorCodeID);
	}

	private void OpenErrorDialog(uint errorCode, Action<ErrorAppletResult> onCloseWindow)
	{
	}

	private string GetErrorMessage(string msbtName, string labelName)
	{
		return null;
	}

	private void EmitSessionErrorLog(SessionErrorType errorType)
	{
	}

	private void OnResume(int value)
	{
	}
}
