using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class PiaPluginSession
{
	public enum EventType
	{
		EventJoin = 0,
		EventLeave = 1,
		SessionHostChanged = 2,
		JointSessionHostChanged = 4,
		StartSessionCreateJoint = 11,
		EndSessionCreateJoint = 12,
		StartSessionJoinJoint = 13,
		EndSessionJoinJoint = 14,
		StartSessionJointRandom = 15,
		EndSessionJointRandom = 16,
		StartSessionDestroyJoint = 17,
		EndSessionDestroyJoint = 18,
		StartSessionLeaveJoint = 19,
		EndSessionLeaveJoint = 20,
		SetSessionSystemPassword = 22,
		ClearSessionSystemPassword = 23,
		InconsistentNotice = 24
	}

	public enum Status
	{
		NotConnected,
		ConnectedSession,
		MigratingSession,
		ConnectedJointSession,
		DisconnectedSession,
		DisconnectedNetwork
	}

	public enum DisconnectReason
	{
		UnknownReason,
		NotYetCommunicated,
		OperationOfOwn,
		OperationOfOther,
		KickoutByUser,
		KickoutBySystem,
		InconsistentInfo,
		MigrationFail,
		ExternalFactor,
		MigrationFatalError
	}

	public enum NetworkTopology
	{
		FullMesh,
		RelayMesh
	}

	public enum SelectionMethod
	{
		Random,
		BroadenRangeWithSelectionPriority,
		ScoreBased
	}

	public enum SessionOpenStatus
	{
		Unknown,
		Open,
		Close
	}

	[StructLayout(0)]
	public class SessionEvent
	{
		public EventType eventType;

		public ulong constantId;

		public int stationIndex;
	}

	[Serializable]
	public class CreateSessionSetting
	{
		private enum CondMask
		{
			GameMode,
			ParticipantNumMin,
			ParticipantNumMax,
			ApplicationData,
			OpenSession,
			MatchmakeSessionOption,
			ScoreBasedSettingIndex,
			ScoreBasedRatingValue,
			ScoreBasedDisconnectionRate,
			ScoreBasedViolationRate,
			ScoreBasedCountryCode,
			ScoreBasedGeoIp,
			SessionUserPassword,
			MatchmakeKeyword,
			Attribute,
			Max
		}

		[Serializable]
		[StructLayout(0)]
		public class Attribute
		{
			public uint index;

			public uint value;
		}

		public uint setCondMask;

		private ushort participantNumMin;

		private ushort participantNumMax;

		private ushort gameMode;

		private List<Attribute> attributeList;

		private byte[] applicationData;

		private bool isOpenSession;

		private uint matchmakeSessionOption;

		private string countryCode;

		private uint ratingValue;

		private uint disconnectionRate;

		private uint violationRate;

		private bool isGeoIpUsed;

		private string wirelessCryptoKey;

		private ulong localCommunicationId;

		private string sessionUserPassword;

		private string matchmakeKeyword;

		private ushort localCommunicationChannel;

		public void SetParticipantNumMin(ushort participantNumMin)
		{
		}

		public ushort GetParticipantNumMin()
		{
			return default(ushort);
		}

		public void SetParticipantNumMax(ushort participantNumMax)
		{
		}

		public ushort GetParticipantNumMax()
		{
			return default(ushort);
		}

		public void SetGameMode(ushort gameMode)
		{
		}

		public ushort GetGameMode()
		{
			return default(ushort);
		}

		public void SetApplicationData(byte[] applicationData)
		{
		}

		public byte[] GetApplicationData()
		{
			return null;
		}

		public void SetOpenSession(bool isOpenSession)
		{
		}

		public bool IsOpenSession()
		{
			return default(bool);
		}

		public void SetMatchmakeSessionOption(uint matchmakeSessionOption)
		{
		}

		public uint GetMatchmakeSessionOption()
		{
			return default(uint);
		}

		public void SetCountryCode(string countryCode)
		{
		}

		public string GetCountryCode()
		{
			return null;
		}

		public void SetRatingValue(uint ratingValue)
		{
		}

		public uint GetRatingValue()
		{
			return default(uint);
		}

		public void SetDisconnectionRate(uint disconnectionRate)
		{
		}

		public uint GetDisconnectionRate()
		{
			return default(uint);
		}

		public void SetViolationRate(uint violationRate)
		{
		}

		public uint GetViolationRate()
		{
			return default(uint);
		}

		public void SetUseGeoIp(bool isGeoIpUsed)
		{
		}

		public bool IsGeoIpUsed()
		{
			return default(bool);
		}

		public void SetWirelessCryptoKey(string wirelessCryptoKey)
		{
		}

		public string GetWirelessCryptoKey()
		{
			return null;
		}

		public PiaPlugin.Result SetAttributeList(List<Attribute> attributeList)
		{
			return default(PiaPlugin.Result);
		}

		public List<Attribute> GetAttributeList()
		{
			return null;
		}

		public void SetLocalCommunicationId(ulong localCommunicationId)
		{
		}

		public ulong GetLocalCommunicationId()
		{
			return default(ulong);
		}

		public PiaPlugin.Result SetSessionUserPassword(string userPassword)
		{
			return default(PiaPlugin.Result);
		}

		public string GetSessionUserPassword()
		{
			return null;
		}

		public PiaPlugin.Result SetSessionMatchmakeKeyword(string keyword)
		{
			return default(PiaPlugin.Result);
		}

		public string GetSessionMatchmakeKeyword()
		{
			return null;
		}

		public void SetLocalCommunicationChannel(ushort localCommunicationChannel)
		{
		}

		public ushort GetLocalCommunicationChannel()
		{
			return default(ushort);
		}
	}

	[StructLayout(0)]
	public class CreateSessionSettingNative : IDisposable
	{
		public uint setCondMask;

		public ushort participantNumMin;

		public ushort participantNumMax;

		public ushort gameMode;

		public IntPtr pAttributeArray;

		public int attributeNum;

		public IntPtr pApplicationData;

		public int applicationDataSize;

		public bool isOpenSession;

		public uint matchmakeSessionOption;

		public IntPtr pCountryCode;

		public uint ratingValue;

		private uint disconnectionRate;

		private uint violationRate;

		public bool isGeoIpUsed;

		public IntPtr pWirelessCryptoKey;

		private ulong localCommunicationId;

		public IntPtr pSessionUserPassword;

		private IntPtr pMmatchmakeKeyword;

		private ushort localCommunicationChannel;

		internal CreateSessionSettingNative()
		{
		}

		internal CreateSessionSettingNative(CreateSessionSetting setting)
		{
		}

		public void Dispose()
		{
		}
	}

	[Serializable]
	public class SessionSearchCriteria
	{
		private enum CondMask
		{
			ParticipantNumMin,
			ParticipantNumMax,
			OpenedOnly,
			VacantOnly,
			GameMode,
			RandomSessionSelectionMethod,
			ScoreBasedSettingIndex,
			ScoreBasedRatingValue,
			ScoreBasedDisconnectionRate,
			ScoreBasedViolationRate,
			ScoreBasedCountryCode,
			ScoreBasedGeoIp,
			ExcludeUserPasswordSet,
			MatchmakeKeyword,
			Attribute,
			AttributeRange,
			Max
		}

		[Serializable]
		public class Attribute
		{
			public uint index;

			public List<uint> valueList;
		}

		[Serializable]
		[StructLayout(0)]
		public class AttributeRange
		{
			public uint index;

			public uint min;

			public uint max;
		}

		public uint setCondMask;

		private ushort participantNumMin;

		private ushort participantNumMax;

		private bool isOpenedOnly;

		private bool isVacantOnly;

		private ushort gameMode;

		private List<Attribute> attributeList;

		private List<AttributeRange> attributeRangeList;

		public uint[] resultRange;

		private string countryCode;

		private uint ratingValue;

		private uint disconnectionRate;

		private uint violationRate;

		private bool isGeoIpUsed;

		private uint scoreSettingIndex;

		private SelectionMethod selectionMethod;

		private ulong localCommunicationId;

		private string matchmakeKeyword;

		private bool isExcludeUserPasswordSet;

		public void SetParticipantNumMin(ushort participantNumMin)
		{
		}

		public ushort GetParticipantNumMin()
		{
			return default(ushort);
		}

		public void SetParticipantNumMax(ushort participantNumMax)
		{
		}

		public ushort GetParticipantNumMax()
		{
			return default(ushort);
		}

		public void SetOpenedOnly(bool isOpenedOnly)
		{
		}

		public bool IsOpenedOnly()
		{
			return default(bool);
		}

		public void SetVacantOnly(bool isVacantOnly)
		{
		}

		public bool IsVacantOnly()
		{
			return default(bool);
		}

		public void SetGameMode(ushort gameMode)
		{
		}

		public ushort GetGameMode()
		{
			return default(ushort);
		}

		public void SetCountryCode(string countryCode)
		{
		}

		public string GetCountryCode()
		{
			return null;
		}

		public void SetRatingValue(uint ratingValue)
		{
		}

		public uint GetRatingValue()
		{
			return default(uint);
		}

		public void SetDisconnectionRate(uint disconnectionRate)
		{
		}

		public uint GetDisconnectionRate()
		{
			return default(uint);
		}

		public void SetViolationRate(uint violationRate)
		{
		}

		public uint GetViolationRate()
		{
			return default(uint);
		}

		public void SetUseGeoIp(bool isGeoIpUsed)
		{
		}

		public bool IsGeoIpUsed()
		{
			return default(bool);
		}

		public void SetScoreSettingIndex(uint scoreSettingIndex)
		{
		}

		public uint GetScoreSettingIndex()
		{
			return default(uint);
		}

		public void SetSelectionMethod(SelectionMethod selectionMethod)
		{
		}

		public SelectionMethod GetSelectionMethod()
		{
			return default(SelectionMethod);
		}

		public PiaPlugin.Result SetAttributeList(List<Attribute> attributeList)
		{
			return default(PiaPlugin.Result);
		}

		public List<Attribute> GetAttributeList()
		{
			return null;
		}

		public PiaPlugin.Result SetAttributeRangeList(List<AttributeRange> attributeRangeList)
		{
			return default(PiaPlugin.Result);
		}

		public List<AttributeRange> GetAttributeRangeList()
		{
			return null;
		}

		public void SetLocalCommunicationId(ulong localCommunicationId)
		{
		}

		public ulong GetLocalCommunicationId()
		{
			return default(ulong);
		}

		public PiaPlugin.Result SetSessionMatchmakeKeyword(string keyword)
		{
			return default(PiaPlugin.Result);
		}

		public string GetSessionMatchmakeKeyword()
		{
			return null;
		}

		public void SetExcludeUserPasswordSet(bool isExcludeUserPasswordSet)
		{
		}

		public bool IsExcludeUserPasswordSet()
		{
			return default(bool);
		}
	}

	public struct SessionSearchCriteriaNative : IDisposable
	{
		[StructLayout(0)]
		public class AttributeNative : IDisposable
		{
			public uint index;

			public IntPtr pValueArray;

			public int valueNum;

			public AttributeNative()
			{
			}

			public AttributeNative(SessionSearchCriteria.Attribute attribute)
			{
			}

			public void Dispose()
			{
			}
		}

		private uint setCondMask;

		public ushort participantNumMin;

		public ushort participantNumMax;

		public bool isOpenedOnly;

		public bool isVacantOnly;

		public ushort gameMode;

		public IntPtr pAttributeNativeArray;

		public int attributeNativeNum;

		public IntPtr pAttributeRangeArray;

		public int attributeRangeNum;

		public uint resultOffset;

		public uint resultSize;

		public IntPtr pCountryCode;

		public uint ratingValue;

		private uint disconnectionRate;

		private uint violationRate;

		public bool isGeoIpUsed;

		public uint scoreSettingIndex;

		public int selectionMethod;

		private ulong localCommunicationId;

		private IntPtr pMmatchmakeKeyword;

		public bool isExcludeUserPasswordSet;

		public void Reset()
		{
		}

		internal SessionSearchCriteriaNative(SessionSearchCriteria criteria)
		{
		}

		public void Dispose()
		{
		}
	}

	[Serializable]
	public class SessionSearchCriteriaOwner
	{
		private ulong ownerConstantId;

		public uint[] resultRange;

		public void SetOwnerConstantId(ulong ownerConstantId)
		{
		}

		public ulong GetOwnerConstantId()
		{
			return default(ulong);
		}
	}

	[StructLayout(0)]
	public class SessionSearchCriteriaOwnerNative : IDisposable
	{
		public ulong ownerConstantId;

		public uint resultOffset;

		public uint resultSize;

		internal SessionSearchCriteriaOwnerNative()
		{
		}

		internal SessionSearchCriteriaOwnerNative(SessionSearchCriteriaOwner criteria)
		{
		}

		public void Dispose()
		{
		}
	}

	[Serializable]
	public class SessionSearchCriteriaParticipant
	{
		public List<ulong> participantConstantIdList;

		public bool isApplicationDataEnabled;
	}

	[StructLayout(0)]
	public class SessionSearchCriteriaParticipantNative : IDisposable
	{
		public IntPtr pConstantIdList;

		public int constantIdNum;

		public bool isApplicationDataEnabled;

		internal SessionSearchCriteriaParticipantNative()
		{
		}

		internal SessionSearchCriteriaParticipantNative(SessionSearchCriteriaParticipant criteria)
		{
		}

		public void Dispose()
		{
		}
	}

	public class SessionSearchCriteriaSessionId
	{
		public uint[] sessionIdArray;
	}

	public struct SessionSearchCriteriaSessionIdNative : IDisposable
	{
		private IntPtr pSessionIdArray;

		private uint sessionIdArraySize;

		internal SessionSearchCriteriaSessionIdNative(SessionSearchCriteriaSessionId criteria)
		{
		}

		public void Dispose()
		{
		}
	}

	public class StationInfo
	{
		public ulong constantId
		{
			[CompilerGenerated]
			get
			{
				return default(ulong);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int stationIndex
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

		public ushort playerNum
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

		public List<PiaPlugin.PlayerInfo> playerInfoList
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

		public int rtt
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

		public float unicastPacketLossRate
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float broadcastPacketLossRate
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public StationInfo()
		{
		}

		internal StationInfo(StationInfoNative stationInfoNative)
		{
		}
	}

	internal struct StationInfoNative : IDisposable
	{
		public ulong constantId
		{
			[CompilerGenerated]
			get
			{
				return default(ulong);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int stationIndex
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

		public ushort playerNum
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

		public IntPtr pStationInfoArray
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

		public int rtt
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

		public float unicastPacketLossRate
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float broadcastPacketLossRate
		{
			[CompilerGenerated]
			get
			{
				return default(float);
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

	public class SessionStatus
	{
		public uint sessionId
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

		public ushort stationNum
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

		public ushort playerNum
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

		public ushort matchmakeSessionStationNum
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

		public ushort matchmakeSessionParticipantNum
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

		public ulong hostConstantId
		{
			[CompilerGenerated]
			get
			{
				return default(ulong);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public ulong localConstantId
		{
			[CompilerGenerated]
			get
			{
				return default(ulong);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public uint jointSessionId
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

		public ulong jointSessionHostConstantId
		{
			[CompilerGenerated]
			get
			{
				return default(ulong);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public List<StationInfo> stationInfoList
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

		public Status status
		{
			[CompilerGenerated]
			get
			{
				return default(Status);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public DisconnectReason disconnectReason
		{
			[CompilerGenerated]
			get
			{
				return default(DisconnectReason);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public SessionStatus()
		{
		}

		internal SessionStatus(SessionStatusNative sessionNative)
		{
		}
	}

	internal struct SessionStatusNative : IDisposable
	{
		public uint sessionId
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

		public ushort stationNum
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

		public ushort playerNum
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

		public ushort matchmakeSessionStationNum
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

		public ushort matchmakeSessionParticipantNum
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

		public ulong hostConstantId
		{
			[CompilerGenerated]
			get
			{
				return default(ulong);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public ulong localConstantId
		{
			[CompilerGenerated]
			get
			{
				return default(ulong);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public uint jointSessionId
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

		public ulong jointSessionHostConstantId
		{
			[CompilerGenerated]
			get
			{
				return default(ulong);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public IntPtr pStationInfoList
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

		public Status status
		{
			[CompilerGenerated]
			get
			{
				return default(Status);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public DisconnectReason disconnectReason
		{
			[CompilerGenerated]
			get
			{
				return default(DisconnectReason);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal SessionStatusNative(SessionStatus sessionStatus)
		{
		}

		public void Dispose()
		{
		}
	}

	[StructLayout(0)]
	public class JoinSessionSetting
	{
		public uint selectJoinSessionNum;

		public uint sessionId;

		public string wirelessCryptoKey;

		public string sessionUserPassword;
	}

	[StructLayout(0)]
	internal class JoinSessionSettingNative : IDisposable
	{
		public uint selectJoinSessionNum;

		public uint sessionId;

		public IntPtr pWirelessCryptoKey;

		public IntPtr pSessionUserPassword;

		internal JoinSessionSettingNative(JoinSessionSetting setting)
		{
		}

		public void Dispose()
		{
		}
	}

	[StructLayout(0)]
	public class UpdateSessionSetting
	{
		private enum CondMask
		{
			ApplicationData,
			SelectionPriority,
			ParticipantNumMin,
			ParticipantNumMax,
			ScoreBasedRatingValue,
			ScoreBasedDisconnectionRate,
			ScoreBasedViolationRate,
			ScoreBasedCountryCode,
			ScoreBasedUpdateGeoIp,
			MatchmakeKeyword,
			Attribute,
			Max
		}

		[Serializable]
		[StructLayout(0)]
		public class Attribute
		{
			public uint index;

			public uint value;
		}

		public uint setCondMask;

		private byte[] applicationData;

		private int applicationDataSize;

		public byte priority;

		private ushort participantNumMin;

		private ushort participantNumMax;

		private List<Attribute> attributeList;

		private string countryCode;

		private uint ratingValue;

		private uint disconnectionRate;

		private uint violationRate;

		private bool isUpdateGeoIp;

		private PiaPlugin.DateTime startedTime;

		private string sessionUserPassword;

		private string matchmakeKeyword;

		public void SetApplicationData(byte[] applicationData, int applicationDataSize)
		{
		}

		public byte[] GetApplicationData()
		{
			return null;
		}

		public int GetApplicationDataSize()
		{
			return default(int);
		}

		public void SetSelectionPriority(byte selectionPriority)
		{
		}

		public byte GetSelectionPriority()
		{
			return default(byte);
		}

		public void SetParticipantNumMin(ushort participantNumMin)
		{
		}

		public ushort GetParticipantNumMin()
		{
			return default(ushort);
		}

		public void SetParticipantNumMax(ushort participantNumMax)
		{
		}

		public ushort GetParticipantNumMax()
		{
			return default(ushort);
		}

		public void SetCountryCode(string countryCode)
		{
		}

		public string GetCountryCode()
		{
			return null;
		}

		public void SetRatingValue(uint ratingValue)
		{
		}

		public uint GetRatingValue()
		{
			return default(uint);
		}

		public void SetDisconnectionRate(uint disconnectionRate)
		{
		}

		public uint GetDisconnectionRate()
		{
			return default(uint);
		}

		public void SetViolationRate(uint violationRate)
		{
		}

		public uint GetViolationRate()
		{
			return default(uint);
		}

		public void SetUpdateGeoIp(bool isUpdateGeoIp)
		{
		}

		public bool IsUpdateGeoIp()
		{
			return default(bool);
		}

		public PiaPlugin.Result SetAttributeList(List<Attribute> attributeList)
		{
			return default(PiaPlugin.Result);
		}

		public List<Attribute> GetAttributeList()
		{
			return null;
		}

		public PiaPlugin.Result SetSessionUserPassword(string userPassword)
		{
			return default(PiaPlugin.Result);
		}

		public string GetSessionUserPassword()
		{
			return null;
		}

		public PiaPlugin.Result SetSessionMatchmakeKeyword(string keyword)
		{
			return default(PiaPlugin.Result);
		}

		public string GetSessionMatchmakeKeyword()
		{
			return null;
		}

		public PiaPlugin.Result SetStartedTime(PiaPlugin.DateTime dateTime)
		{
			return default(PiaPlugin.Result);
		}

		public PiaPlugin.DateTime GetStartedTime()
		{
			return default(PiaPlugin.DateTime);
		}
	}

	[StructLayout(0)]
	internal class UpdateSessionSettingNative : IDisposable
	{
		public uint setCondMask;

		public IntPtr pApplicationData;

		public int applicationDataSize;

		public byte priority;

		public ushort participantNumMin;

		public ushort participantNumMax;

		public IntPtr pAttributeArray;

		public int attributeNum;

		public uint ratingValue;

		public uint disconnectionRate;

		public uint violationRate;

		public IntPtr pCountryCode;

		public bool isUpdateGeoIp;

		public IntPtr pSessionUserPassword;

		private IntPtr pMmatchmakeKeyword;

		internal UpdateSessionSettingNative()
		{
		}

		internal UpdateSessionSettingNative(UpdateSessionSetting setting)
		{
		}

		public void Dispose()
		{
		}
	}

	[StructLayout(0)]
	public class SessionProperty
	{
		public ushort gameMode;

		public uint sessionId;

		public ushort currentParticipantNum;

		public ushort participantNumMin;

		public ushort participantNumMax;

		public bool isOpened;

		public bool isRestrictedByUserPassword;

		public byte[] applicationData;

		public uint applicationDataSize;

		public ulong targetConstantId;

		public SessionProperty()
		{
		}

		internal SessionProperty(SessionPropertyNative sessionPropertyNative)
		{
		}
	}

	internal struct SessionPropertyNative : IDisposable
	{
		public ushort gameMode;

		public uint sessionId;

		public ushort currentParticipantNum;

		public ushort participantNumMin;

		public ushort participantNumMax;

		public bool isOpened;

		public bool isRestrictedByUserPassword;

		public byte[] applicationData;

		public uint applicationDataSize;

		public ulong targetConstantId;

		public void Dispose()
		{
		}
	}

	private const int AttributeSizeMax = 6;

	public const int DefaultSessionKeepAliveInterval = 1000;

	public const int DefaultSessionSilenceTimeMax = 10000;

	public const int LanApplicationDataBufferSizeMax = 384;

	public const int UpdateMeshSendingIntervalDefault = 1000;

	private const int SessionUserPasswordLengthMax = 8;

	public const int InetApplicationDataBufferSizeMax = 512;

	public const int LocalApplicationDataBufferSizeMax = 360;

	private const int ApplicationDataSystemBufferSizeMax = 512;

	private const int SessionMatchmakeKeywordLength = 32;

	private static extern PiaPlugin.Result OpenSessionAsyncNative();

	public static PiaPlugin.Result OpenSessionAsync()
	{
		return default(PiaPlugin.Result);
	}

	private static extern PiaPlugin.Result UpdateAndOpenSessionAsyncNative([In] UpdateSessionSettingNative setting, [In] PiaPlugin.DateTime startedTime);

	public static PiaPlugin.Result UpdateAndOpenSessionAsync(UpdateSessionSetting setting)
	{
		return default(PiaPlugin.Result);
	}

	private static extern PiaPlugin.Result CloseSessionAsyncNative();

	public static PiaPlugin.Result CloseSessionAsync()
	{
		return default(PiaPlugin.Result);
	}

	private static extern PiaPlugin.Result GetSessionStatusNative(ref SessionStatusNative sessionStatusNative);

	public static PiaPlugin.Result GetSessionStatus(ref SessionStatus sessionStatus)
	{
		return default(PiaPlugin.Result);
	}

	private static extern PiaPlugin.Result KickoutStationNative(ulong constantId);

	public static PiaPlugin.Result KickoutStation(ulong constantId)
	{
		return default(PiaPlugin.Result);
	}

	private static extern PiaPlugin.Result BrowseSessionAsyncNative([In] SessionSearchCriteriaNative criteria);

	public static PiaPlugin.Result BrowseSessionAsync(SessionSearchCriteria criteria)
	{
		return default(PiaPlugin.Result);
	}

	private static extern PiaPlugin.Result BrowseSessionAsyncWithOwnerNative([In] SessionSearchCriteriaOwnerNative criteria);

	public static PiaPlugin.Result BrowseSessionAsync(SessionSearchCriteriaOwner criteria)
	{
		return default(PiaPlugin.Result);
	}

	private static extern PiaPlugin.Result BrowseSessionAsyncWithParticipantNative([In] SessionSearchCriteriaParticipantNative criteria);

	public static PiaPlugin.Result BrowseSessionAsync(SessionSearchCriteriaParticipant criteria)
	{
		return default(PiaPlugin.Result);
	}

	private static extern PiaPlugin.Result BrowseSessionAsyncWithSessionIdNative([In] SessionSearchCriteriaSessionIdNative criteria);

	public static PiaPlugin.Result BrowseSessionAsync(SessionSearchCriteriaSessionId criteria)
	{
		return default(PiaPlugin.Result);
	}

	private static extern PiaPlugin.Result CreateSessionAsyncNative([In] CreateSessionSettingNative setting);

	public static PiaPlugin.Result CreateSessionAsync(CreateSessionSetting setting)
	{
		return default(PiaPlugin.Result);
	}

	private static extern PiaPlugin.Result JoinSessionAsyncNative([In] JoinSessionSettingNative setting);

	public static PiaPlugin.Result JoinSessionAsync(JoinSessionSetting setting)
	{
		return default(PiaPlugin.Result);
	}

	private static extern PiaPlugin.Result UpdateSessionSettingAsyncNative([In] UpdateSessionSettingNative setting, [In] PiaPlugin.DateTime startedTime);

	public static PiaPlugin.Result UpdateSessionSettingAsync(UpdateSessionSetting setting)
	{
		return default(PiaPlugin.Result);
	}

	private static extern SessionPropertyNative GetSessionPropertyNative();

	public static SessionProperty GetSessionProperty()
	{
		return null;
	}

	private static extern PiaPlugin.Result RequestSessionPropertyAsyncNative();

	public static PiaPlugin.Result RequestSessionPropertyAsync()
	{
		return default(PiaPlugin.Result);
	}

	private static extern uint GetBrowsedSessionPropertyListSizeNative();

	public static uint GetBrowsedSessionPropertyListSize()
	{
		return default(uint);
	}

	private static extern SessionPropertyNative GetBrowsedSessionPropertyNative([In] uint listIndex);

	public static SessionProperty GetBrowsedSessionProperty(uint listIndex)
	{
		return null;
	}

	private static extern PiaPlugin.Result GetConstantIdListNative(out IntPtr pConstantIdNativeList, out int constantIdNativeListLength);

	public static PiaPlugin.Result GetConstantIdList(List<ulong> constantIdList)
	{
		return default(PiaPlugin.Result);
	}

	private static extern PiaPlugin.Result DestroyJointSessionAsyncNative();

	public static PiaPlugin.Result DestroyJointSessionAsync()
	{
		return default(PiaPlugin.Result);
	}

	private static extern PiaPlugin.Result OpenJointSessionAsyncNative();

	public static PiaPlugin.Result OpenJointSessionAsync()
	{
		return default(PiaPlugin.Result);
	}

	private static extern PiaPlugin.Result UpdateAndOpenJointSessionAsyncNative([In] UpdateSessionSettingNative setting, [In] PiaPlugin.DateTime startedTime);

	public static PiaPlugin.Result UpdateAndOpenJointSessionAsync(UpdateSessionSetting setting)
	{
		return default(PiaPlugin.Result);
	}

	private static extern PiaPlugin.Result CloseJointSessionAsyncNative();

	public static PiaPlugin.Result CloseJointSessionAsync()
	{
		return default(PiaPlugin.Result);
	}

	private static extern PiaPlugin.Result UpdateJointSessionSettingAsyncNative([In] UpdateSessionSettingNative setting, [In] PiaPlugin.DateTime startedTime);

	public static PiaPlugin.Result UpdateJointSessionSettingAsync(UpdateSessionSetting setting)
	{
		return default(PiaPlugin.Result);
	}

	private static extern SessionPropertyNative GetJointSessionPropertyNative();

	public static SessionProperty GetJointSessionProperty()
	{
		return null;
	}

	private static extern PiaPlugin.Result RequestJointSessionPropertyAsyncNative();

	public static PiaPlugin.Result RequestJointSessionPropertyAsync()
	{
		return default(PiaPlugin.Result);
	}

	private static extern bool IsHostNative();

	public static bool IsHost()
	{
		return default(bool);
	}

	private static extern bool IsJointSessionHostNative();

	public static bool IsJointSessionHost()
	{
		return default(bool);
	}

	private static extern uint GetSessionOpenStatusNative();

	public static SessionOpenStatus GetSessionOpenStatus()
	{
		return default(SessionOpenStatus);
	}

	private static extern uint GetJointSessionOpenStatusNative();

	public static SessionOpenStatus GetJointSessionOpenStatus()
	{
		return default(SessionOpenStatus);
	}

	private static extern int GetInetSearchCriteriaListSizeMaxNative();

	public static int GetInetSearchCriteriaListSizeMax()
	{
		return default(int);
	}

	private static extern int GetLanSearchCriteriaListSizeMaxNative();

	public static int GetLanSearchCriteriaListSizeMax()
	{
		return default(int);
	}
}
