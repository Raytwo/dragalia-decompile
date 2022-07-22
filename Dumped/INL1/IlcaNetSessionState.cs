namespace INL1;

public enum IlcaNetSessionState
{
	SS_NoInit,
	SS_WorkingAsync,
	SS_MatchingWait,
	SS_MatchingBlock,
	SS_GamingFront,
	SS_Gaming,
	SS_GamingLeave,
	SS_GamingError,
	SS_Final,
	SS_Crash
}
