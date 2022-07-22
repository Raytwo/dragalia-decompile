namespace Dpr.NetworkUtils;

public enum SessionErrorType
{
	InternetGo_Error,
	InternetGo_DoNotInet,
	InternetGo_DoNotNSO,
	InternetGo_DoNotGetNexUID,
	InternetGo_DoNotGetNSAID,
	InternetGo_DoNotLogin,
	InternetGo_Crash,
	Failed_NetworkInitAsync,
	Failed_SessionCreateAsync,
	Failed_SessionJoinAsync,
	Failed_SessionRandomAsync,
	Failed_SettingSet,
	Failed_SessionRestartRequestAsync,
	Failed_CheckRequestAutoAsync,
	Session_NotFind,
	Cannot_CallStartSession,
	DoNot_StateWait,
	GamingError_InPolling,
	Crash_InPolling,
	DoNot_FindSessionIndex,
	SendPacket_NotSessionInitialized,
	SendPacket_AloneSession,
	SendPacket_InvalidIlcaNetPacketType,
	SendPacket_PacketWriterReNotUseUn,
	SendPacket_SendSocketResultFailure,
	SendPacket_SendSocketBufferFull,
	SendPacket_InvalidStationIndex,
	SendPacket_SessionInfoFuncFailure,
	SendPacket_SendToSelf,
	SendPacket_RecvCrash,
	SendPacket_RecvSocketResultFailure,
	SendPacket_NetGamerIsNotActive,
	SendPacket_NetGamerIsNotHomeGamer,
	Validate_RequestResultFailed,
	Validate_CallDifferentRequest,
	Validate_FailedGetPublicKey,
	Validate_FailedGetIllegalData,
	Validate_FindIllegalData,
	Failed_NotPerformValidate,
	Failed_CallGMStationTrade,
	Sercretbase_FailedCallIineGetAsync,
	Sercretbase_FailedGetGoodCount,
	Sercretbase_FailedCallIineSetAsync,
	Sercretbase_FailedSendGood,
	Error_NotFoundErrorCode,
	Warning,
	None
}
