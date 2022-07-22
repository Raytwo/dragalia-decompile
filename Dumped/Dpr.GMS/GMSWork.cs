using DPData;
using UnityEngine;

namespace Dpr.GMS;

public static class GMSWork
{
	public static ushort GetStartTradeListIndex => default(ushort);

	public static ushort GetStartBrowsingListIndex => default(ushort);

	public static byte GetUserAchievementStep => default(byte);

	public static void SetStartTradeListIndex(ushort index)
	{
	}

	public static void SetStartBrowsingListIndex(ushort index)
	{
	}

	public static void SetUserAchievementStep(byte step)
	{
	}

	public static int CalcPointExtDataIndex(int pointIndex, int historyIndex)
	{
		return default(int);
	}

	public static void OverwriteHistoryData(int pointIndex, int dataIndex, IntermediatePointData newHistoryData)
	{
	}

	public static void SwapHistoryData(int srcPointIndex, int srcDataIndex, int destPointIndex, int destDataIndex)
	{
	}

	public static void DeleteHistoryData(int pointIndex, int dataIndex)
	{
	}

	public static void SortHistoryData(int pointIndex)
	{
	}

	public static IntermediatePointData ConvertPointData(GMS_POINT_HISTORY_DATA hitsoryData, GMS_POINT_HISTORY_EXT_DATA extData)
	{
		return null;
	}

	public static IntermediatePointData ConvertPointData(TradeResultData resultData)
	{
		return null;
	}

	public static void ResetGMSData()
	{
	}

	public static void ResetAllPointHistoryData()
	{
	}

	private static void SetHistoryData(ref GMS_POINT_HISTORY_DATA historyData, ref GMS_POINT_HISTORY_EXT_DATA extData, IntermediatePointData newHistoryData)
	{
	}

	private static void ResetHistoryData(ref GMS_POINT_HISTORY_DATA historyData)
	{
	}

	public static void ApplyReportData_MagicalTrade(TradeResultData tradeResult)
	{
	}

	public static void EmitLog(string log, LogType logType = LogType.Log)
	{
	}
}
