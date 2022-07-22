using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace NexPlugin;

public static class Ranking
{
	public enum RankingMode
	{
		RANKING_MODE_RANGE,
		RANKING_MODE_NEAR,
		RANKING_MODE_FRIEND_RANGE,
		RANKING_MODE_FRIEND_NEAR,
		RANKING_MODE_USER
	}

	public enum FilterGroupIndex
	{
		FILTER_GROUP_INDEX_0 = 0,
		FILTER_GROUP_INDEX_1 = 1,
		FILTER_GROUP_INDEX_2 = 2,
		FILTER_GROUP_INDEX_3 = 3,
		FILTER_GROUP_INDEX_NONE = 255
	}

	public enum OrderBy
	{
		ORDER_BY_ASC,
		ORDER_BY_DESC
	}

	public enum UpdateMode
	{
		UPDATE_MODE_NORMAL,
		UPDATE_MODE_DELETE_OLD
	}

	public enum OrderCalculation
	{
		ORDER_CALCULATION_113,
		ORDER_CALCULATION_123
	}

	public enum TimeScope
	{
		TIME_SCOPE_CUSTOM_0,
		TIME_SCOPE_CUSTOM_1,
		TIME_SCOPE_ALL
	}

	[Flags]
	public enum ModificationFlag
	{
		MODIFICATION_FLAG_NONE = 0,
		MODIFICATION_FLAG_GROUP0 = 1,
		MODIFICATION_FLAG_GROUP1 = 2,
		MODIFICATION_FLAG_GROUP2 = 4,
		MODIFICATION_FLAG_GROUP3 = 8,
		MODIFICATION_FLAG_PARAM = 0x10
	}

	[Flags]
	public enum StatsFlag
	{
		STATS_FLAG_TOTAL = 1,
		STATS_FLAG_SUM = 2,
		STATS_FLAG_MIN = 4,
		STATS_FLAG_MAX = 8,
		STATS_FLAG_AVERAGE = 0x10
	}

	public delegate void GetCommonDataCB(AsyncResult asyncResult, List<byte> data);

	public delegate void GetRankingCB(AsyncResult asyncResult, RankingResult info);

	public delegate void GetApproxOrderCB(AsyncResult asyncResult, uint rank);

	public delegate void GetStatsCB(AsyncResult asyncResult, RankingStats stats);

	public delegate void GetCachedTopXRankingCB(AsyncResult asyncResult, RankingCachedResult info);

	public delegate void GetCachedTopXRankingsCB(AsyncResult asyncResult, List<RankingCachedResult> info);

	public const byte MAX_COMMON_DATA_SIZE = byte.MaxValue;

	public const uint MAX_RANGE_RANKING_ORDER = 1000u;

	public const uint MAX_ACCURATE_ORDER = 5000u;

	public static bool UploadCommonDataAsync(out uint asyncId, IntPtr pNgsFacade, List<byte> commonData, ulong nexUniqueId = 0uL, int timeOut = 0, [Optional] AsyncResultCB callback)
	{
		return default(bool);
	}

	public static bool DeleteCommonDataAsync(out uint asyncId, IntPtr pNgsFacade, ulong nexUniqueId = 0uL, int timeOut = 0, [Optional] AsyncResultCB callback)
	{
		return default(bool);
	}

	public static bool GetCommonDataAsync(out uint asyncId, IntPtr pNgsFacade, ulong nexUniqueId = 0uL, int timeOut = 0, [Optional] GetCommonDataCB callback)
	{
		return default(bool);
	}

	public static bool UploadScoreAsync(out uint asyncId, IntPtr pNgsFacade, RankingScoreData scoreData, ulong nexUniqueId = 0uL, int timeOut = 0, [Optional] AsyncResultCB callback)
	{
		return default(bool);
	}

	public static bool DeleteScoreAsync(out uint asyncId, IntPtr pNgsFacade, uint category, ulong nexUniqueId = 0uL, int timeOut = 0, [Optional] AsyncResultCB callback)
	{
		return default(bool);
	}

	public static bool DeleteScoreAsync(out uint asyncId, IntPtr pNgsFacade, ulong nexUniqueId = 0uL, int timeOut = 0, [Optional] AsyncResultCB callback)
	{
		return default(bool);
	}

	public static bool GetRankingAsync(out uint asyncId, IntPtr pNgsFacade, RankingMode rankingMode, uint category, RankingOrderParam orderParam, ulong nexUniqueId = 0uL, ulong principalId = 0uL, int timeOut = 0, [Optional] GetRankingCB callback)
	{
		return default(bool);
	}

	public static bool GetRankingByPIDListAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> principalIdList, RankingMode rankingMode, uint category, RankingOrderParam orderParam, ulong nexUniqueId = 0uL, int timeOut = 0, [Optional] GetRankingCB callback)
	{
		return default(bool);
	}

	public static bool GetRankingByUIDListAsync(out uint asyncId, IntPtr pNgsFacade, List<ulong> nexUniqueIdList, RankingMode rankingMode, uint category, RankingOrderParam orderParam, ulong nexUniqueId = 0uL, int timeOut = 0, [Optional] GetRankingCB callback)
	{
		return default(bool);
	}

	public static bool GetApproxOrderAsync(out uint asyncId, IntPtr pNgsFacade, uint category, RankingOrderParam orderParam, uint score, ulong nexUniqueId = 0uL, ulong principalId = 0uL, int timeOut = 0, [Optional] GetApproxOrderCB callback)
	{
		return default(bool);
	}

	public static bool GetStatsAsync(out uint asyncId, IntPtr pNgsFacade, uint category, RankingOrderParam orderParam, StatsFlag flags, int timeOut = 0, [Optional] GetStatsCB callback)
	{
		return default(bool);
	}

	public static bool ChangeAttributesAsync(out uint asyncId, IntPtr pNgsFacade, uint category, RankingChangeAttributesParam changeParam, ulong nexUniqueId = 0uL, int timeOut = 0, [Optional] AsyncResultCB callback)
	{
		return default(bool);
	}

	public static bool ChangeAttributesAsync(out uint asyncId, IntPtr pNgsFacade, RankingChangeAttributesParam changeParam, ulong nexUniqueId = 0uL, int timeOut = 0, [Optional] AsyncResultCB callback)
	{
		return default(bool);
	}

	public static bool GetCachedTopXRankingAsync(out uint asyncId, IntPtr pNgsFacade, uint category, RankingOrderParam orderParam, int timeOut = 0, [Optional] GetCachedTopXRankingCB callback)
	{
		return default(bool);
	}

	public static bool GetCachedTopXRankingsAsync(out uint asyncId, IntPtr pNgsFacade, List<uint> categories, RankingOrderParam orderParam, int timeOut = 0, [Optional] GetCachedTopXRankingsCB callback)
	{
		return default(bool);
	}

	public static bool GetCachedTopXRankingsAsync(out uint asyncId, IntPtr pNgsFacade, List<uint> categories, List<RankingOrderParam> orderParams, int timeOut = 0, [Optional] GetCachedTopXRankingsCB callback)
	{
		return default(bool);
	}
}
