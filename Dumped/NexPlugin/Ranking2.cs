using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace NexPlugin;

public static class Ranking2
{
	public enum Ranking2SortFlags
	{
		NOTHING = 0,
		MOVE_TO_TOP_IN_TIE = 4
	}

	public enum Ranking2GetOptionFlags
	{
		NOTHING
	}

	public enum Ranking2Mode : byte
	{
		USER_RANKING = 0,
		NEAR_RANKING = 1,
		RANGE_RANKING = 2,
		FRIEND_RANKING = 3,
		MIN = 0,
		MAX = 3
	}

	public enum Ranking2ResetMode : byte
	{
		NOTHING = 0,
		EVERYDAY = 1,
		EVERYWEEK = 2,
		MULTI_MONTH = 3,
		MULTI_MONTH_WEEKDAY = 4,
		MIN = 0,
		MAX = 4
	}

	public delegate void GetCommonDataCB(AsyncResult asyncResult, Ranking2CommonData data);

	public delegate void GetRankingCB(AsyncResult asyncResult, Ranking2Info info);

	public delegate void GetCategorySettingCB(AsyncResult asyncResult, Ranking2CategorySetting setting);

	public delegate void GetRanking2ChartInfoCB(AsyncResult asyncResult, Ranking2ChartInfo info);

	public delegate void GetRanking2ChartInfoListCB(AsyncResult asyncResult, List<Ranking2ChartInfo> info);

	public delegate void GetRanking2EstimateScoreRankCB(AsyncResult asyncResult, Ranking2EstimateScoreRankOutput info);

	public const int MAX_BINARY_DATA_LENGTH = 100;

	public const uint MAX_CHART_GET_LENGTH = 20u;

	public const uint MAX_PUT_MULTI_SCORES = 20u;

	public const uint MAX_RANKING_LENGTH = 100u;

	public const int MAX_USERNAME_LENGTH = 20;

	public const bool SCORE_ORDER_ASC = false;

	public const bool SCORE_ORDER_DESC = true;

	public static bool PutScoreAsync(out uint asyncId, IntPtr pNgsFacade, Ranking2ScoreData scoreData, ulong nexUniqueId = 0uL, int timeOut = 0, [Optional] AsyncResultCB callback)
	{
		return default(bool);
	}

	public static bool PutScoreAsync(out uint asyncId, IntPtr pNgsFacade, List<Ranking2ScoreData> scoreDataList, ulong nexUniqueId = 0uL, int timeOut = 0, [Optional] AsyncResultCB callback)
	{
		return default(bool);
	}

	public static bool PutCommonDataAsync(out uint asyncId, IntPtr pNgsFacade, Ranking2CommonData commonData, ulong nexUniqueId = 0uL, int timeOut = 0, [Optional] AsyncResultCB callback)
	{
		return default(bool);
	}

	public static bool GetCommonDataAsync(out uint asyncId, IntPtr pNgsFacade, Ranking2GetOptionFlags optionFlags = Ranking2GetOptionFlags.NOTHING, ulong principalId = 0uL, ulong nexUniqueId = 0uL, int timeOut = 0, [Optional] GetCommonDataCB callback)
	{
		return default(bool);
	}

	public static bool DeleteCommonDataAsync(out uint asyncId, IntPtr pNgsFacade, ulong nexUniqueId = 0uL, int timeOut = 0, [Optional] AsyncResultCB callback)
	{
		return default(bool);
	}

	public static bool GetRankingAsync(out uint asyncId, IntPtr pNgsFacade, Ranking2GetParam getParam, int timeOut = 0, [Optional] GetRankingCB callback)
	{
		return default(bool);
	}

	public static bool GetRankingAsync(out uint asyncId, IntPtr pNgsFacade, Ranking2GetByListParam getParam, List<ulong> principalIdList, int timeOut = 0, [Optional] GetRankingCB callback)
	{
		return default(bool);
	}

	public static bool GetCategorySettingAsync(out uint asyncId, IntPtr pNgsFacade, uint category, int timeOut = 0, [Optional] GetCategorySettingCB callback)
	{
		return default(bool);
	}

	public static bool GetRankingChartAsync(out uint asyncId, IntPtr pNgsFacade, Ranking2ChartInfoInput info, int timeOut = 0, [Optional] GetRanking2ChartInfoCB callback)
	{
		return default(bool);
	}

	public static bool GetRankingChartAsync(out uint asyncId, IntPtr pNgsFacade, List<Ranking2ChartInfoInput> info, int timeOut = 0, [Optional] GetRanking2ChartInfoListCB callback)
	{
		return default(bool);
	}

	public static bool GetEstimateScoreRankAsync(out uint asyncId, IntPtr pNgsFacade, Ranking2EstimateScoreRankInput info, int timeOut = 0, [Optional] GetRanking2EstimateScoreRankCB callback)
	{
		return default(bool);
	}
}
