namespace Dpr.Battle.Logic;

public static class BattleRule
{
	public static byte GetClientNum(BtlRule rule, BtlMultiMode multiMode)
	{
		return default(byte);
	}

	public static byte GetFriendClientNum(BtlRule rule, BtlMultiMode multiMode, BTL_CLIENT_ID myClientId)
	{
		return default(byte);
	}

	public static byte GetEnemyClientNum(BtlRule rule, BtlMultiMode multiMode, BTL_CLIENT_ID myClientId)
	{
		return default(byte);
	}

	public static bool IsClientExist(BtlRule rule, BtlMultiMode multiMode, BTL_CLIENT_ID clientId)
	{
		return default(bool);
	}

	public static bool IsClientAi(BtlRule rule, BtlCommMode commMode, BtlMultiMode multiMode, BTL_CLIENT_ID clientId)
	{
		return default(bool);
	}

	public static bool IsClientAi_Single(BtlCommMode commMode, BTL_CLIENT_ID clientId)
	{
		return default(bool);
	}

	public static bool IsClientAi_Double(BtlCommMode commMode, BtlMultiMode multiMode, BTL_CLIENT_ID clientId)
	{
		return default(bool);
	}

	public static bool IsClientAi_Double_MultiMode_NONE(BtlCommMode commMode, BTL_CLIENT_ID clientId)
	{
		return default(bool);
	}

	public static bool IsClientAi_Double_MultiMode_PP_AA(BtlCommMode commMode, BTL_CLIENT_ID clientId)
	{
		return default(bool);
	}

	public static bool IsClientAi_Double_MultiMode_PA_AA(BtlCommMode commMode, BTL_CLIENT_ID clientId)
	{
		return default(bool);
	}

	public static bool IsClientAi_Double_MultiMode_P_AA(BtlCommMode commMode, BTL_CLIENT_ID clientId)
	{
		return default(bool);
	}

	public static bool IsClientAi_Double_MultiMode_PA_A(BtlCommMode commMode, BTL_CLIENT_ID clientId)
	{
		return default(bool);
	}

	public static bool IsClientAi_Raid(BtlCommMode commMode, BtlMultiMode multiMode, BTL_CLIENT_ID clientId)
	{
		return default(bool);
	}

	public static bool IsFriendClient(BtlRule rule, BTL_CLIENT_ID clientId_0, BTL_CLIENT_ID clientId_1)
	{
		return default(bool);
	}

	public static bool IsOpponentClient(BtlRule rule, BTL_CLIENT_ID clientId_0, BTL_CLIENT_ID clientId_1)
	{
		return default(bool);
	}

	public static BTL_CLIENT_ID GetFriendClientId(BtlRule rule, BtlMultiMode multiMode, BTL_CLIENT_ID myClientID, byte opponentIndex)
	{
		return default(BTL_CLIENT_ID);
	}

	public static BTL_CLIENT_ID GetOpponentClientId(BtlRule rule, BtlMultiMode multiMode, BTL_CLIENT_ID myClientID, byte opponentIndex)
	{
		return default(BTL_CLIENT_ID);
	}

	public static bool IsResultStrictJudge(BtlRule rule, BtlCompetitor competitor)
	{
		return default(bool);
	}

	public static bool IsDummyClientSwitchEnable(BtlRule rule)
	{
		return default(bool);
	}

	public static bool IsSkipBattleAfterShowdown(BtlRule rule)
	{
		return default(bool);
	}

	public static bool NeedPGLRecord(BtlRule rule)
	{
		return default(bool);
	}
}
