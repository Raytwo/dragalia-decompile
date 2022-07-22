using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using nn;
using nn.account;
using nn.err;

public class PiaPlugin
{
	public enum ResultValue : uint
	{
		ResultAllocationFailed = 68609u,
		ResultAlreadyInitialized = 68610u,
		ResultBufferShortage = 68612u,
		ResultBrokenData = 11267u,
		ResultCancelled = 27653u,
		ResultNetworkConnectionIsLost = 50182u,
		ResultInvalidArgument = 68615u,
		ResultInvalidState = 68616u,
		ResultNoData = 11273u,
		ResultNotFound = 11274u,
		ResultNotImplemented = 3083u,
		ResultNotInitialized = 68620u,
		ResultBufferIsFull = 19469u,
		ResultTimeout = 27662u,
		ResultAlreadyExists = 68623u,
		ResultContainerIsFull = 3088u,
		ResultTemporaryUnavailable = 19473u,
		ResultNotSet = 68627u,
		ResultMemoryLeak = 68628u,
		ResultInvalidNode = 3094u,
		ResultNegligibleFault = 11288u,
		ResultInvalidConnection = 27673u,
		ResultLocalCommunicationInvalidState = 27675u,
		ResultNetworkIsNotFound = 27676u,
		ResultNetworkIsFull = 27677u,
		ResultLocalCommunicationLowerVersion = 25630u,
		ResultLocalCommunicationHigherVersion = 25631u,
		ResultWifiOff = 50208u,
		ResultSleep = 50209u,
		ResultWirelessControllerCountLimitation = 25634u,
		ResultConnectionFailed = 3108u,
		ResultCreateStationFailed = 3109u,
		ResultIncompatibleFormat = 68646u,
		ResultNotInCommunication = 11303u,
		ResultTableIsFull = 3112u,
		ResultDataIsNotArrivedYet = 19500u,
		ResultDataIsNotSet = 68658u,
		ResultNatCheckFailed = 25652u,
		ResultInUse = 3125u,
		ResultDnsFailed = 25654u,
		ResultNexInternalError = 58423u,
		ResultJoinRequestDenied = 26680u,
		ResultStationConnectionFailed = 25657u,
		ResultMeshIsFull = 27709u,
		ResultInvalidSystemMessage = 68670u,
		ResultStationConnectionNatTraversalFailedUnknown = 25663u,
		ResultNatTraversalFailedBothEim = 25666u,
		ResultNatTraversalFailedLocalEimRemoteEdm = 25667u,
		ResultNatTraversalFailedLocalEdmRemoteEim = 25668u,
		ResultNatTraversalFailedBothEdm = 25669u,
		ResultRelayFailedNoCandidate = 26694u,
		ResultRelayFailedRttLimit = 26695u,
		ResultRelayFailedRelayNumLimit = 26696u,
		ResultRelayFailedUnknown = 26697u,
		ResultNatTraversalRequestTimeout = 25674u,
		ResultSessionIsNotFound = 27723u,
		ResultMatchmakeSessionIsFull = 27724u,
		ResultDeniedByParticipant = 27725u,
		ResultParticipantInBlockList = 27726u,
		ResultGameServerMaintenance = 42063u,
		ResultSessionUserPasswordUnmatch = 27729u,
		ResultSessionSystemPasswordUnmatch = 27730u,
		ResultMeshConnectionIsLost = 27728u,
		ResultSessionIsClosed = 27731u,
		ResultCompanionStationIsOffline = 27732u,
		ResultHostIsNotFriend = 27733u,
		ResultSessionConnectionIsLost = 35926u,
		ResultCompanionStationIsLeft = 27735u,
		ResultSessionMigrationFailed = 27737u,
		ResultGameServerProcessAborted = 44122u,
		ResultSessionConnectionIsLostByHost = 35960u,
		ResultSessionConnectionIsLostByHostMigrationFailure = 35958u,
		ResultSessionConnectionIsLostByInconsistentInfo = 35959u,
		ResultKickedOutFromSessionByInconsistentInfo = 35962u,
		ResultKickedOutFromSessionByUser = 35961u,
		ResultSessionWrongState = 27739u,
		ResultCreateCommunityFailedUpperLimit = 27743u,
		ResultJoinCommunityFailedUpperLimit = 27744u,
		ResultCommunityIsFull = 27745u,
		ResultCommunityIsNotFound = 27746u,
		ResultCommunityIsClosed = 27747u,
		ResultCommunityUserPasswordUnmatch = 27750u,
		ResultAlreadyJoinedCommunity = 11364u,
		ResultUserAccountNotExisted = 27749u,
		ResultNatTraversalFailedBothEimSamePublicAddress = 25703u,
		ResultNatTraversalFailedBothEdmSamePublicAddress = 25706u,
		ResultNatTraversalFailedLocalEimRemoteEdmSamePublicAddress = 25704u,
		ResultNatTraversalFailedLocalEdmRemoteEimSamePublicAddress = 25705u,
		ResultSdkError = 60523u,
		ResultSdkViewerResultError = 42094u,
		ResultCancelledByUser = 44141u,
		ResultSystemLowerVersion = 25711u,
		ResultSystemHigherVersion = 25712u,
		ResultNetworkConnectionIsLostByDuplicateLogin = 42097u,
		ResultLicenseForNetworkServiceNotAvailable = 42098u,
		ResultLicenseForNetworkServiceError = 42099u,
		ResultLicenseForNetworkServiceSubscriptionError = 42100u,
		ResultLicenseForNetworkServiceSubscriptionError2 = 42101u,
		ResultOutOfMemory = 60539u,
		ResultNetworkInterfaceIsNotFound = 27774u,
		ResultInvalidClock = 27772u,
		ResultIncreaseDataSize = 11389u,
		ResultSuccess = 0u
	}

	public enum TraceFlag : short
	{
		Always = 0,
		Common = 1,
		CommonSocketDetail = 2,
		CommonDetail = 3,
		Local = 4,
		LocalMigration = 5,
		LocalDetail = 6,
		Net = 7,
		NetMigration = 8,
		Direct = 9,
		DirectConnect = 10,
		DirectDetail = 11,
		Nex = 12,
		NexMigration = 13,
		NexJoint = 14,
		NexTransport = 15,
		NexRelay = 16,
		NexRelayTransport = 17,
		NexNat = 18,
		NexNatProbe = 19,
		Nat = 20,
		NatProbe = 21,
		Cloud = 22,
		CloudConnectionDetail = 23,
		CloudTransport = 24,
		CloudHeapDetail = 25,
		CloudDetail = 26,
		Wan = 27,
		WanNat = 28,
		WanTransport = 29,
		WanDetail = 30,
		Lan = 31,
		LanMigration = 32,
		LanTransport = 33,
		Transport = 34,
		TransportInit = 35,
		TransportKeepAlive = 36,
		TransportRtt = 37,
		TransportBufferDetail = 38,
		TransportPacketDetail = 39,
		TransportProtocolDetail = 40,
		TransportRelay = 41,
		TransportRelayDetail = 42,
		TransportReliableDetail = 43,
		TransportDebug = 44,
		Mesh = 45,
		MeshMigration = 46,
		MeshUpdate = 47,
		MeshClock = 48,
		Session = 49,
		SessionMigration = 50,
		SessionJoint = 51,
		SessionReserved = 52,
		Lobby = 53,
		LobbyDetail = 54,
		Sync = 55,
		SyncFrameDrop = 56,
		SyncDetail = 57,
		Clone = 58,
		CloneUpdate = 59,
		CloneEvent = 60,
		CloneEventDetail = 61,
		CloneAtomic = 62,
		CloneClock = 63,
		Reckoning = 64,
		Chat = 65,
		ChatDetail = 66,
		Framework = 67,
		FrameworkDetail = 68,
		Emulation = 69,
		EmulationDetail = 70,
		Brain = 71,
		BrainDetail = 72,
		Plugin = 73,
		Report = 74,
		Terminate = 75,
		Default = 0,
		All = -1
	}

	public enum HandlingType
	{
		Void,
		Ignorable,
		Retry,
		Cleanup,
		CleanupWithLeave,
		LogoutWithLeave,
		ShutdownNetwork,
		Finalize,
		ProgrammingError
	}

	public enum ViewerType
	{
		Void,
		ShouldUse,
		MayUse,
		ShouldNotUse
	}

	public enum NetworkType
	{
		Local,
		Internet,
		Lan
	}

	public enum State
	{
		NotInitialized = 0,
		NetworkStartedUp = 1,
		LoggedIn = 2,
		SessionInitialized = 3,
		SessionStartedUp = 4,
		SessionJoined = 5,
		SessionStartedBrowseMatchmake = 7,
		SessionLeft = 4,
		SessionCleanedUp = 3,
		SessionFinalized = 2,
		LoggedOut = 1,
		NetworkCleanedUp = 0,
		JointSessionJoined = 6,
		JointSessionLeft = 4
	}

	public enum AsyncProcessId
	{
		Nothing,
		ChangeState,
		HandleError,
		CreateSession,
		BrowseSession,
		JoinSession,
		OpenSession,
		UpdateAndOpenSession,
		CloseSession,
		UpdateSessionSetting,
		RequestSessionProperty,
		DestroyJointSession,
		OpenJointSession,
		UpdateAndOpenJointSession,
		CloseJointSession,
		UpdateJointSessionSetting,
		RequestJointSessionProperty
	}

	public struct Result
	{
		public ResultValue resultValue
		{
			[CompilerGenerated]
			get
			{
				return default(ResultValue);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private uint innerErrorCode
		{
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public ViewerType viewerType
		{
			[CompilerGenerated]
			get
			{
				return default(ViewerType);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public HandlingType handlingType
		{
			[CompilerGenerated]
			get
			{
				return default(HandlingType);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private nn.Result sdkViewerResult
		{
			[CompilerGenerated]
			get
			{
				return default(nn.Result);
			}
		}

		public Result(HandlingType _handlingType)
		{
		}

		public Result(ResultValue _resultValue, uint _innerErrorCode, ViewerType _viewerType, HandlingType _handlingType)
		{
		}

		public bool IsSuccess()
		{
			return default(bool);
		}

		public bool IsFailure()
		{
			return default(bool);
		}

		public ErrorCode GetErrorCode()
		{
			return default(ErrorCode);
		}

		public nn.Result GetErrorResult()
		{
			return default(nn.Result);
		}

		public void Trace()
		{
		}
	}

	[Serializable]
	public class PlayerInfo
	{
		public byte nameStringLanguage;

		public string playerName;

		public Uid playerId;

		public PlayerInfo()
		{
		}

		internal PlayerInfo(PlayerInfoNative playerInfoNative)
		{
		}
	}

	public struct PlayerInfoNative : IDisposable
	{
		public byte nameStringLanguage;

		public IntPtr playerName;

		public int playerNameSize;

		public Uid playerId;

		internal PlayerInfoNative(PlayerInfo playerInfo)
		{
		}

		public void Dispose()
		{
		}
	}

	internal struct DispatchResultNative : IDisposable
	{
		public Result result
		{
			[CompilerGenerated]
			get
			{
				return default(Result);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public IntPtr pSessionEventArray
		{
			[CompilerGenerated]
			get
			{
				return default(IntPtr);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int sessionEventNum
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public void Dispose()
		{
		}
	}

	public struct SessionEventListNative : IDisposable
	{
		public IntPtr pSessionEventArray
		{
			[CompilerGenerated]
			get
			{
				return default(IntPtr);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int sessionEventNum
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public void Dispose()
		{
		}
	}

	public struct AsyncState
	{
		public bool isCompleted;

		public Result result
		{
			[CompilerGenerated]
			get
			{
				return default(Result);
			}
			[CompilerGenerated]
			private set
			{
			}
		}
	}

	public struct CryptoSetting
	{
		public enum Mode
		{
			Nothing,
			Aes128
		}

		public Mode mode;

		public IntPtr pKeyData;
	}

	[StructLayout(0)]
	public class TraceFlagSetting
	{
		public const uint ArraySize = 75u;

		public uint count;

		public TraceFlag[] flags;

		public TraceFlagSetting add(TraceFlag value)
		{
			return null;
		}
	}

	[Serializable]
	[StructLayout(0)]
	public class TraceFlagSettingNative : IDisposable
	{
		private const uint ArraySize = 75u;

		private TraceFlag[] flags;

		public uint count
		{
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal TraceFlagSettingNative(TraceFlagSetting setting)
		{
		}

		public void Dispose()
		{
		}
	}

	[StructLayout(0)]
	public class InitializeFrameworkSetting
	{
		public enum CoreId
		{
			CoreId_Default,
			CoreId_0,
			CoreId_1,
			CoreId_2
		}

		public uint piaBufferSize;

		public NetworkType networkType;

		public int backgroundThreadPriority;

		public TraceFlagSetting traceFlags;

		public CoreId threadCoreId;
	}

	[StructLayout(0)]
	public class InitializeFrameworkSettingNative : IDisposable
	{
		public uint piaBufferSize;

		public int networkType;

		public int backgroundThreadPriority;

		public IntPtr unityVersion;

		public int threadCoreId;

		internal InitializeFrameworkSettingNative(InitializeFrameworkSetting setting)
		{
		}

		public void Dispose()
		{
		}
	}

	[StructLayout(0)]
	public class InitializeInternetSetting
	{
		public uint totalMemorySize;

		public uint emergencyMemorySize;

		public uint gameId;

		public string accessKey;

		public UserHandle userHandle;

		public byte nexVersionMajor;

		public byte nexVersionMinor;

		public byte nexVersionMicro;
	}

	[StructLayout(0)]
	public class InitializeInternetSettingNative : IDisposable
	{
		public uint totalMemorySize;

		public uint emergencyMemorySize;

		public uint gameId;

		public IntPtr accessKey;

		public UserHandle userHandle;

		public byte nexVersionMajor;

		public byte nexVersionMinor;

		public byte nexVersionMicro;

		internal InitializeInternetSettingNative(InitializeInternetSetting setting)
		{
		}

		public void Dispose()
		{
		}
	}

	[Serializable]
	[StructLayout(0)]
	public class InitializeLanSetting
	{
	}

	[Serializable]
	[StructLayout(0)]
	public class InitializeLocalSetting
	{
		public int localCommunicationVersion;
	}

	[Serializable]
	[StructLayout(0)]
	public class InitializeTransportSetting
	{
		public ushort stationNumMax;

		public int measurementInterval;

		public ushort sendProtocolBufferNumPerStation;

		public ushort receiveProtocolBufferNumPerStation;

		public ushort sendThreadBufferNumPerStation;

		public ushort receiveThreadBufferNumPerStation;

		public ushort unreliableProtocolNum;

		public ushort reliableProtocolNum;

		public ushort broadcastReliableProtocolNum;

		public ushort streamBroadcastReliableProtocolNum;

		public bool isAnalysisResultPrintEnabled;
	}

	[Serializable]
	[StructLayout(0)]
	public class InitializeCloneSetting
	{
		public bool isEnable;

		public ushort broadcastEventProtocolNum;

		public ushort broadcastEventProtocolBufferNum;

		public uint atomicProtocolIdMax;
	}

	[Serializable]
	[StructLayout(0)]
	public class InitializeSyncSetting
	{
		public bool isEnable;

		public bool isChangeDelayEnabled;

		public uint[] dataUnitSize;
	}

	[Serializable]
	[StructLayout(0)]
	public class InitializeReckoningSetting
	{
		public bool isEnable;

		public ushort reckoning1dProtocolNum;

		public ushort reckoning3dProtocolNum;

		public ushort reckoningProtocolBufferNum;
	}

	[Serializable]
	[StructLayout(0)]
	public class InitializeSessionSetting
	{
		public PiaPluginSession.NetworkTopology networkTopology;

		public ushort browsedSessionPropertyListNum;
	}

	[Serializable]
	[StructLayout(0)]
	public class StartupNetworkSetting
	{
		public bool isAutoInitializeNetworkInterface;
	}

	[Serializable]
	public class StartupSessionSetting
	{
		public ushort relayRouteNumMax;

		public ushort relayRouteRttMax;

		public bool isEachPlayerCountedAsParticipant;

		public bool isAutoInitializeLdn;

		public uint silenceTimeMax;

		public uint keepAliveSendingInterval;

		public int updateMeshSendingInterval;

		public CryptoSetting cryptoSetting;

		public string localAddress;

		public uint v4Subnetmask;

		public int v6InterfaceIndex;

		public bool useBroadcastOnSendingToAllStation;
	}

	[StructLayout(0)]
	private class StartupSessionSettingNative : IDisposable
	{
		public ushort relayRouteNumMax;

		public ushort relayRouteRttMax;

		public bool isAutoInitializeLdn;

		public uint silenceTimeMax;

		public uint keepAliveSendingInterval;

		public int updateMeshSendingInterval;

		public bool isEachPlayerCountedAsParticipant;

		public CryptoSetting cryptoSetting;

		public IntPtr pLocalAddress;

		public uint v4Subnetmask;

		public int v6InterfaceIndex;

		public bool useBroadcastOnSendingToAllStation;

		internal StartupSessionSettingNative(StartupSessionSetting setting)
		{
		}

		public void Dispose()
		{
		}
	}

	[Serializable]
	[StructLayout(0)]
	public class JoinRandomSessionSetting
	{
		public PiaPluginSession.CreateSessionSetting createSessionSetting;

		public PiaPluginSession.SessionSearchCriteria[] sessionSearchCriteriaList;

		public bool isMyBlockListUsed;

		public bool isOthersBlockListUsed;

		public bool isUniqueKeywordEnabled;
	}

	[Serializable]
	[StructLayout(0)]
	public class NatDebugSetting
	{
		public byte natTraversalFailureRatioForHost;

		public byte natTraversalFailureRatioForClient;

		public bool isNatTypeCheckFailure;

		public bool isDnsResolutionFailure;
	}

	public class Watermark
	{
		public string name
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public long valueMax
		{
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public long valueMin
		{
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public long latestValue
		{
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public long updateCount
		{
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Watermark()
		{
		}

		internal Watermark(WatermarkNative watermarkNative)
		{
		}
	}

	[StructLayout(0)]
	internal class WatermarkNative : IDisposable
	{
		public IntPtr pName
		{
			[CompilerGenerated]
			get
			{
				return default(IntPtr);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int nameSize
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public long valueMax
		{
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public long valueMin
		{
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public long latestValue
		{
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public long updateCount
		{
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public void Dispose()
		{
		}
	}

	public struct DateTime
	{
		public ushort year;

		public byte month;

		public byte day;

		public byte hour;

		public byte minute;

		public byte second;

		private bool isRegistered;

		public DateTime(ushort year_, byte month_, byte day_, byte hour_, byte minute_, byte second_)
		{
		}

		public bool IsRegistered()
		{
			return default(bool);
		}
	}

	[Serializable]
	[StructLayout(0)]
	public class LocalAdressInfo
	{
		public string address6;

		public uint interfaceIndex;

		public string address4;

		public uint subnetMask;

		public LocalAdressInfo()
		{
		}

		internal LocalAdressInfo(LocalAdressInfoNative localAdressInfoNative)
		{
		}
	}

	[StructLayout(0)]
	internal class LocalAdressInfoNative : IDisposable
	{
		public IntPtr address6
		{
			[CompilerGenerated]
			get
			{
				return default(IntPtr);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public ushort address6Length
		{
			[CompilerGenerated]
			get
			{
				return default(ushort);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public uint interfaceIndex
		{
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public IntPtr address4
		{
			[CompilerGenerated]
			get
			{
				return default(IntPtr);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public ushort address4Length
		{
			[CompilerGenerated]
			get
			{
				return default(ushort);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public uint subnetMask
		{
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal LocalAdressInfoNative()
		{
		}

		internal LocalAdressInfoNative(LocalAdressInfo localAddressInfo)
		{
		}

		public void Reset()
		{
		}

		public void Dispose()
		{
		}
	}

	public class Debug
	{
		private static extern Result EnableBroadcastOnSendingToAllStationForDebugNative();

		public static Result EnableBroadcastOnSendingToAllStationForDebug()
		{
			return default(Result);
		}
	}

	public const ulong InvalidConstantId = 0uL;

	public const int InvalidStationIndex = 253;

	public const uint PlayerNameLengthMax = 20u;

	public const int LocalCommunicationVersionMin = 0;

	public const int LocalCommunicationVersionMax = 32767;

	public const int PlayerInfoSizeMax = 4;

	private static List<PiaPluginSession.SessionEvent> s_SessionEventList;

	public static readonly Result SuccessResult;

	public static readonly Result ProgrammingErrorResult;

	public static readonly Result InvalidArgumentResult;

	public static readonly Result AllocationFailedResult;

	private static void RegisterPiaLogNative()
	{
	}

	private static extern Result InitializeFrameworkNative([In] InitializeFrameworkSettingNative setting, [In] TraceFlagSettingNative traceFlags);

	public static Result InitializeFramework(InitializeFrameworkSetting setting)
	{
		return default(Result);
	}

	private static void UnregisterPiaLogNative()
	{
	}

	private static extern void FinalizeAllNative();

	public static void FinalizeAll()
	{
	}

	private static extern Result RegisterInitializeInternetSettingNative([In] InitializeInternetSettingNative setting);

	public static Result RegisterInitializeInternetSetting(InitializeInternetSetting setting)
	{
		return default(Result);
	}

	private static extern Result RegisterInitializeLanSettingNative([In] InitializeLanSetting setting);

	public static Result RegisterInitializeLanSetting(InitializeLanSetting setting)
	{
		return default(Result);
	}

	private static extern Result RegisterInitializeLocalSettingNative([In] InitializeLocalSetting setting);

	public static Result RegisterInitializeLocalSetting(InitializeLocalSetting setting)
	{
		return default(Result);
	}

	private static extern Result RegisterInitializeTransportSettingNative([In] InitializeTransportSetting setting);

	public static Result RegisterInitializeTransportSetting(InitializeTransportSetting setting)
	{
		return default(Result);
	}

	private static extern Result RegisterInitializeCloneSettingNative([In] InitializeCloneSetting setting);

	public static Result RegisterInitializeCloneSetting(InitializeCloneSetting setting)
	{
		return default(Result);
	}

	private static extern Result RegisterInitializeSyncSettingNative([In] InitializeSyncSetting setting);

	public static Result RegisterInitializeSyncSetting(InitializeSyncSetting setting)
	{
		return default(Result);
	}

	private static extern Result RegisterInitializeReckoningSettingNative([In] InitializeReckoningSetting setting);

	public static Result RegisterInitializeReckoningSetting(InitializeReckoningSetting setting)
	{
		return default(Result);
	}

	private static extern Result RegisterInitializeSessionSettingNative([In] InitializeSessionSetting setting);

	public static Result RegisterInitializeSessionSetting(InitializeSessionSetting setting)
	{
		return default(Result);
	}

	private static extern Result RegisterStartupNetworkSettingNative([In] StartupNetworkSetting setting);

	public static Result RegisterStartupNetworkSetting(StartupNetworkSetting setting)
	{
		return default(Result);
	}

	private static extern Result RegisterStartupSessionSettingNative([In] StartupSessionSettingNative settingNative, [In] PlayerInfoNative[] playerInfo, int infoNum);

	public static Result RegisterStartupSessionSetting(StartupSessionSetting setting, PlayerInfo[] playerInfo)
	{
		return default(Result);
	}

	private static extern Result RegisterJoinRandomSessionSettingNative([In] PiaPluginSession.CreateSessionSettingNative createSessionSetting, [In] PiaPluginSession.SessionSearchCriteriaNative[] sessionSearchCriteriaList, int sessionSerachCriteriaListSize, [In] bool isMyBlockListUsed, [In] bool isOthersBlockListUsed, [In] bool isUniqueKeywordEnabled);

	public static Result RegisterJoinRandomSessionSetting(JoinRandomSessionSetting setting)
	{
		return default(Result);
	}

	private static extern Result RegisterJoinRandomJointSessionSettingNative([In] PiaPluginSession.CreateSessionSettingNative createSessionSetting, [In] PiaPluginSession.SessionSearchCriteriaNative[] sessionSearchCriteriaList, int sessionSerachCriteriaListSize, [In] bool isMyBlockListUsed, [In] bool isOthersBlockListUsed, [In] bool isUniqueKeywordEnabled);

	public static Result RegisterJoinRandomJointSessionSetting(JoinRandomSessionSetting setting)
	{
		return default(Result);
	}

	private static extern Result RegisterNatDebugSettingNative([In] NatDebugSetting setting);

	public static Result RegisterNatDebugSetting(NatDebugSetting setting)
	{
		return default(Result);
	}

	private static extern Result UnregisterInitializeInternetSettingNative();

	public static Result UnregisterInitializeInternetSetting()
	{
		return default(Result);
	}

	private static extern Result UnregisterInitializeLanSettingNative();

	public static Result UnregisterInitializeLanSetting()
	{
		return default(Result);
	}

	private static extern Result UnregisterInitializeLocalSettingNative();

	public static Result UnregisterInitializeLocalSetting()
	{
		return default(Result);
	}

	private static extern Result UnregisterInitializeTransportSettingNative();

	public static Result UnregisterInitializeTransportSetting()
	{
		return default(Result);
	}

	private static extern Result UnregisterInitializeCloneSettingNative();

	public static Result UnregisterInitializeCloneSetting()
	{
		return default(Result);
	}

	private static extern Result UnregisterInitializeSyncSettingNative();

	public static Result UnregisterInitializeSyncSetting()
	{
		return default(Result);
	}

	private static extern Result UnregisterInitializeReckoningSettingNative();

	public static Result UnregisterInitializeReckoningSetting()
	{
		return default(Result);
	}

	private static extern Result UnregisterInitializeSessionSettingNative();

	public static Result UnregisterInitializeSessionSetting()
	{
		return default(Result);
	}

	private static extern Result UnregisterStartupNetworkSettingNative();

	public static Result UnregisterStartupNetworkSetting()
	{
		return default(Result);
	}

	private static extern Result UnregisterStartupSessionSettingNative();

	public static Result UnregisterStartupSessionSetting()
	{
		return default(Result);
	}

	private static extern Result UnregisterJoinRandomSessionSettingNative();

	public static Result UnregisterJoinRandomSessionSetting()
	{
		return default(Result);
	}

	private static extern Result UnregisterJoinRandomJointSessionSettingNative();

	public static Result UnregisterJoinRandomJointSessionSetting()
	{
		return default(Result);
	}

	private static extern Result UnregisterNatDebugSettingNative();

	public static Result UnregisterNatDebugSetting()
	{
		return default(Result);
	}

	private static extern void DispatchNative();

	public static void Dispatch()
	{
	}

	private static extern Result CheckDispatchErrorNative();

	public static Result CheckDispatchError()
	{
		return default(Result);
	}

	private static extern SessionEventListNative GetSessionEventListNative();

	public static List<PiaPluginSession.SessionEvent> GetSessionEventList()
	{
		return null;
	}

	private static extern void FinalizeNetworkNative();

	public static void FinalizeNetwork()
	{
	}

	private static extern Result ChangeStateAsyncNative(State state);

	public static Result ChangeStateAsync(State state)
	{
		return default(Result);
	}

	private static extern Result GetCurrentHandlingResultNative();

	public static Result GetCurrentHandlingResult()
	{
		return default(Result);
	}

	private static extern Result HandleErrorAsyncNative(Result result);

	public static Result HandleErrorAsync(Result result)
	{
		return default(Result);
	}

	private static extern State ConvertHandlingTypeToStateNative(HandlingType handlingType);

	public static State ConvertHandlingTypeToState(HandlingType handlingType)
	{
		return default(State);
	}

	private static extern State GetJoinProcessStateNative();

	public static State GetJoinProcessState()
	{
		return default(State);
	}

	private static extern AsyncState GetAsyncProcessStateNative(AsyncProcessId id);

	public static AsyncState GetAsyncProcessState(AsyncProcessId id)
	{
		return default(AsyncState);
	}

	private static extern AsyncProcessId GetAsyncProcessIdNative();

	public static AsyncProcessId GetAsyncProcessId()
	{
		return default(AsyncProcessId);
	}

	private static extern bool IsSessionMigratingNative();

	public static bool IsSessionMigrating()
	{
		return default(bool);
	}

	private static extern uint GetMemoryUsageNative();

	public static uint GetMemoryUsage()
	{
		return default(uint);
	}

	private static extern void StartWatermarkNative();

	public static void StartWatermark()
	{
	}

	private static extern void StopWatermarkNative();

	public static void StopWatermark()
	{
	}

	private static extern void GetWatermarkArrayNative(out IntPtr pWatermarkNativeArray, out int watermarkNativeArrayLength);

	public static List<Watermark> GetWatermarkList()
	{
		return null;
	}

	private static extern int GetRttNative(ulong constantId);

	public static int GetRtt(ulong constantId)
	{
		return default(int);
	}

	private static extern IntPtr GetNexNgsFacadeNative();

	public static IntPtr GetNexNgsFacade()
	{
		return default(IntPtr);
	}

	private static extern IntPtr GetNexCredentialsNative();

	public static IntPtr GetNexCredentials()
	{
		return default(IntPtr);
	}

	private static extern int GetCryptoKeySizeNative();

	public static int GetCryptoKeySize()
	{
		return default(int);
	}

	private static extern void AssertNative(bool flag);

	public static void Assert(bool flag)
	{
	}

	private static extern Result GetServerTimeNative(out DateTime dateTime);

	public static Result GetServerTime(out DateTime dateTime)
	{
		return default(Result);
	}

	private static extern Result GetLocalAddressNative([Out] LocalAdressInfoNative localAddressInfo);

	public static Result GetLocalAddress(ref LocalAdressInfo localAddressInfo)
	{
		return default(Result);
	}

	private static extern void TraceNative(IntPtr mes);

	public static void Trace(string msg, string memberName = "", string sourceFilePath = "", int sourceLineNumber = 0)
	{
	}
}
