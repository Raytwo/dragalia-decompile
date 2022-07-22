using System.Collections;
using System.Runtime.InteropServices;
using Dpr.Battle.Logic.Net.Data;
using Dpr.NetworkUtils;
using INL1;

namespace Dpr.Battle.Logic.Net;

public class Client
{
	private struct SendToClientReq
	{
		public const int HEADER_SIZE = 17;

		public const int WRITABLE_SIZE = 1007;

		public ulong sendBuf;

		public int sendSize;

		public int donenum;

		public int GetDivNum()
		{
			return default(int);
		}

		public bool GetOfs(out int outOfs, out int outBytes, int index)
		{
			return default(bool);
		}

		public static int GetDivNum(int size)
		{
			return default(int);
		}

		public static bool GetOfs(out int outOfs, out int outBytes, int size, int index)
		{
			return default(bool);
		}

		public void Set(ulong pSendBuf, int sendSize)
		{
		}

		public void Clear()
		{
		}
	}

	private class BattleCommandWork
	{
		public const int BUFFER_SIZE = 10012;

		public byte clientId;

		public ulong cmdSeqNo;

		public bool isChecked;

		public unsafe byte* body;

		public void Set(byte clientId, ulong cmdSeqNo)
		{
		}

		public void Initialize()
		{
		}

		public bool IsValid()
		{
			return default(bool);
		}
	}

	private struct SendSeverVersionReq
	{
		public ushort receivedFlag;

		public byte interval;

		public void SetReceivedFlag(ushort flag)
		{
		}

		public bool SetReceivedFlagRange(byte src, byte flag)
		{
			return default(bool);
		}

		public int countNum(int src)
		{
			return default(int);
		}
	}

	public enum ErrorKind
	{
		Invalid,
		Leave_Mine,
		Leave_Other,
		GamingError,
		Crash,
		ResumeGame,
		Timeout,
		CmdIllegal,
		Inconsistent,
		SendError,
		LeaveBattle
	}

	private const int WORK_MAX = 4;

	private static uint s_battleCmdSeqNo;

	private static int[] s_setupStationIndices;

	private BATTLE_SETUP_PARAM m_pSetupParam;

	private ServerVersions m_serverVesions;

	private byte m_myClientID;

	private int m_myStationIndex;

	private ServerParam m_serverParam;

	private int m_serverParamSignal;

	private SendToClientReq[] sendToClientReq;

	private BattleCommandWork m_uPtrServerCommand;

	private BattleCommandWork[] m_uPtrClientCommand;

	private int m_ErrorKindBit;

	private SignalNetData netData_Signal;

	private ServerVersionNetData netData_ServerVersion;

	private ServerParamNetData netData_ServerParam;

	private BattleCommandSCNetData netData_BattleCommandSC;

	private BattleCommandCSNetData netData_BattleCommandCS;

	private bool isStartDetermineServer;

	private float determineServerTimeout;

	private SendSeverVersionReq[] sendServerVersionReq;

	private bool isTerminated;

	private bool isFinishedSession;

	private const int SEND_SERVER_VERSION_INTERVAL = 15;

	private const TransportType UseTransportType = TransportType.Gamer2;

	private static Client Instance => null;

	public int ErrorKindBits => default(int);

	public Client(BATTLE_SETUP_PARAM bsp)
	{
	}

	public void Initialize()
	{
	}

	public void Terminate()
	{
	}

	public bool IsTerminated()
	{
		return default(bool);
	}

	public bool HasErrorOccured(ErrorKind kind = ErrorKind.Invalid)
	{
		return default(bool);
	}

	public bool IsReady()
	{
		return default(bool);
	}

	public bool StartDetermineServer()
	{
		return default(bool);
	}

	public bool IsDeterminedServer()
	{
		return default(bool);
	}

	public byte GetServerVersion()
	{
		return default(byte);
	}

	public bool CheckImServer()
	{
		return default(bool);
	}

	public void Update()
	{
	}

	public bool ToBeReconnectableMode()
	{
		return default(bool);
	}

	public void TurnToRaidAIEnableMode()
	{
	}

	public void TurnToRaidOnlyMeMode()
	{
	}

	public static bool IsShouldDissconetError(int errorKindBits)
	{
		return default(bool);
	}

	public static ErrorCodeID GetErrorDialogCode(int errorKindBits)
	{
		return default(ErrorCodeID);
	}

	private static bool IsErrorKindBit(int errorKindBits, ErrorKind kind)
	{
		return default(bool);
	}

	public void NotifyNetworkError(ErrorKind kind, int arg = 0)
	{
	}

	public bool IsClientCommunicationExist(BTL_CLIENT_ID clientId)
	{
		return default(bool);
	}

	public bool StartNotifyServerParam([In] ref ServerParam serverParam)
	{
		return default(bool);
	}

	public bool StartWaitForNotifyServerParam()
	{
		return default(bool);
	}

	public bool IsNotifiedServerParam()
	{
		return default(bool);
	}

	public ServerParam GetServerParam()
	{
		return default(ServerParam);
	}

	public IEnumerator StartLeaveOnError()
	{
		return null;
	}

	public static void RegisterSetupStationIndices(int index0 = -1, int index1 = -1, int index2 = -1, int index3 = -1)
	{
	}

	private static void RemoveSetupStationIndex(int index)
	{
	}

	private static bool ExistSetupStationIndex(int index)
	{
		return default(bool);
	}

	public static void SetupNetworkCb()
	{
	}

	public static void ReleaseNetworkCb()
	{
	}

	private void OnReceivePacketEx(PacketReader pr, TransportType transportType, int receiveStationIndex)
	{
	}

	private void OnReceivePacket_Signal([In] ref Signal data, int stationIndex)
	{
	}

	private void OnReceivePacket_ServerVersion([In] ref ServerVersion data, int stationIndex)
	{
	}

	private void OnReceivePacket_ServerParam([In] ref ServerParam data, int stationIndex)
	{
	}

	private void OnReceivePacket_BattleCommandSC(PacketReader pr)
	{
	}

	private void OnReceivePacket_BattleCommandCS(PacketReader pr)
	{
	}

	private void OnSessionEvent(SessionEventData result)
	{
	}

	private void OnFinishedSession()
	{
	}

	private static void OnReceivePacketExStatic(PacketReader pr, TransportType transportType, int receiveStationIndex)
	{
	}

	private static void OnSessionEventStatic(SessionEventData result)
	{
	}

	private static void OnFinishedSessionStatic()
	{
	}

	public unsafe bool SendToClient(byte clientId, SEND_DATA_BUFFER* sendBuf, ulong sendSize)
	{
		return default(bool);
	}

	public bool CheckReturnFromClient()
	{
		return default(bool);
	}

	public unsafe bool GetRecvClientData(byte clientId, void** pptr)
	{
		return default(bool);
	}

	private int GetCurrentExistingClientNum()
	{
		return default(int);
	}

	public static void IncrementSeq()
	{
	}

	private void sendToServerVersionCoreAll()
	{
	}

	private bool sendServerVersion(int clientID)
	{
		return default(bool);
	}

	private bool isServerVersionReady()
	{
		return default(bool);
	}

	private int sendToClientCoreAll()
	{
		return default(int);
	}

	private int sendToClientCore(byte clientId)
	{
		return default(int);
	}

	public bool IsServerCmdReceived()
	{
		return default(bool);
	}

	public unsafe void GetReceivedCmdData(void** ppDest)
	{
	}

	public unsafe bool ReturnToServer(void* data, uint size)
	{
		return default(bool);
	}

	public void ClearBattleCommandRecvData()
	{
	}

	public bool BroadcastRaidAction(RaidActionIconID actionIconId, BTL_CLIENT_ID clientId)
	{
		return default(bool);
	}

	public RaidActionIconID GetRaidAction(BTL_CLIENT_ID cliendId)
	{
		return default(RaidActionIconID);
	}

	public void ClearRaidAction()
	{
	}

	public bool BroadcastTrainerAction(BTL_CLIENT_ID clientId)
	{
		return default(bool);
	}

	public bool CheckTrainerAction(BTL_CLIENT_ID cliendId)
	{
		return default(bool);
	}

	public void ClearTrainerAction()
	{
	}

	private int GetStationNumFromBSP()
	{
		return default(int);
	}

	private bool IsExistStationIndexOnBSP(int stationIndex)
	{
		return default(bool);
	}

	private int countBits(byte bits)
	{
		return default(int);
	}

	private int SendReliablePacket(PacketWriterRe pwRe, int stationIndex)
	{
		return default(int);
	}

	private int SendReliableData<T>(ANetData<T> data, int stationIndex) where T : struct
	{
		return default(int);
	}
}
