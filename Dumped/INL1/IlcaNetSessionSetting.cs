using System;
using nn.account;

namespace INL1;

[Serializable]
public class IlcaNetSessionSetting
{
	public Uid playerId;

	public UserHandle userHandle;

	public string playerName;

	public byte nameStringLanguage;

	public IlcaNetSessionNetworkType networkType;

	public IlcaNetSessionInitMode matchingMode;

	public ushort gameMode;

	public string matchmakeKeyword;

	public bool attributeValueEnable;

	public const int attributeMax = 6;

	public uint[] createSessionAttributeValue;

	public uint[] searchSessionAttributeValueMin;

	public uint[] searchSessionAttributeValueMax;

	public bool bSetOpenedOnly;

	public bool bSetVacantOnly;

	public ushort playerNumMax;

	public bool bAutoSessionClose;

	public bool bAutoSessionOpen;

	public bool bOpenSession;

	public bool playerNumFreeSearchLocalOnly;

	public IlcaNetSessionCallbackLastEventLeave lastEventLeave;

	public IlcaNetSessionAutoRetryMode autoRetryMode;

	public int autoRetryRandomMatchmakeMaxNum;

	public int autoRetryRandomMatchmakeMaxNumAddLocal;

	public uint localRandomMatchmakeTimeUp;

	public uint localRandomMatchmakeHostWaitTime;

	public ushort localRandomMatchmakeHostWaitTimeMask;

	public uint searchSessionPropertyMax;

	public IlcaNetSessionGamingStartMode gamingStartMode;

	public IlcaNetSessionPacketBundlingMode packetBundlingMode;

	public const int IlcaNetApplicationDataSystemBufferSizeMax = 360;

	public byte[] applicationData;

	public byte[] cryptoKeyDataSeed;

	public string wirelessCryptoKey;

	public ulong localCommunicationId;

	public ushort stationNumMax;

	public bool isAnalysisResultPrintEnabled;

	public int measurementInterval;

	public ushort sendProtocolBufferNumPerStation;

	public ushort receiveProtocolBufferNumPerStation;

	public ushort sendThreadBufferNumPerStation;

	public ushort receiveThreadBufferNumPerStation;

	public ushort unreliableProtocolNum;

	public ushort reliableProtocolNum;

	public ushort broadcastReliableProtocolNum;

	public ushort streamBroadcastReliableProtocolNum;

	public int networkTopologyRelayMeshNum;

	public ushort browsedSessionPropertyListNum;

	public ushort relayRouteNumMax;

	public ushort relayRouteRttMax;

	public uint silenceTimeMax;

	public uint keepAliveSendingInterval;

	public int updateMeshSendingInterval;

	public bool isAutoInitializeLdn;

	public bool isLocalhostMatchmakeEnabled;

	public bool bSSCrashMode;

	public bool bNexUse;

	public bool bExcludeUserPassword;

	public IlcaNetSessionSetting DeepClone()
	{
		return null;
	}
}
