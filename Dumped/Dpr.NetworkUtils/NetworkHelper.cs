using System;
using INL1;
using UnityEngine;

namespace Dpr.NetworkUtils;

public static class NetworkHelper
{
	public static void InitNetworkData()
	{
	}

	public static void CheckOnlineAccountAsync(Action<bool> onComplete)
	{
	}

	public static bool IsFirstConnectInternet()
	{
		return default(bool);
	}

	public static ushort CheckPlayerNum(ushort playerNum)
	{
		return default(ushort);
	}

	public static ushort CreateContestGameMode(MatchingType matchingType, IlcaNetSessionNetworkType connectType)
	{
		return default(ushort);
	}

	public static ushort CreateUnderGroundGameMode(MatchingType matchingType, IlcaNetSessionNetworkType connectType, ushort UgMapGroupID)
	{
		return default(ushort);
	}

	public static ushort CreateUnionGameMode(MatchingType matchingType, IlcaNetSessionNetworkType connectType)
	{
		return default(ushort);
	}

	public static ushort CreateBattleGameMode(MatchingType matchingType, BattleModeID battleModeID, IlcaNetSessionNetworkType connectType)
	{
		return default(ushort);
	}

	private static ushort GetMatchingBitByType(MatchingType matchingType)
	{
		return default(ushort);
	}

	private static ushort GetBattleModeBitByID(BattleModeID battleModeID)
	{
		return default(ushort);
	}

	private static void EmitGameModeLog(ushort gamemode)
	{
	}

	public static SessionErrorType ConvertIlcaNetUtilInternetGoResultToSessionErrorType(IlcaNetUtilInternetGoResult internetGoResult)
	{
		return default(SessionErrorType);
	}

	public static SessionErrorType ConvertIIlcaNetTransportErrorEnumToSessionErrorType(IlcaNetTransportErrorEnum transportError)
	{
		return default(SessionErrorType);
	}

	public static void EmitValidateError(IlcaNetServerValidate.CheckResponse checkResponse)
	{
	}

	public static void EmitNetworkLog(string log, LogType logType = LogType.Log)
	{
	}
}
