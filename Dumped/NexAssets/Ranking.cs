using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using NexPlugin;

namespace NexAssets;

public class Ranking : Common
{
	private class GETRANK_ARG : CORE_ARG
	{
		public NexPlugin.Ranking.RankingMode rankingMode;

		public uint category;

		public NexPlugin.RankingOrderParam param;

		public ulong uniqueId;

		public bool principalIdUseCurrentLogin;

		public ulong principalId;

		public int timeOut;

		public NexPlugin.Ranking.GetRankingCB callback;
	}

	private class GETRANK_BYPIDLIST_ARG : CORE_ARG
	{
		public NexPlugin.Ranking.RankingMode rankingMode;

		public uint category;

		public NexPlugin.RankingOrderParam param;

		public ulong uniqueId;

		public List<ulong> principalIdList;

		public int timeOut;

		public NexPlugin.Ranking.GetRankingCB callback;
	}

	private class GETRANK_BYUIDLIST_ARG : CORE_ARG
	{
		public NexPlugin.Ranking.RankingMode rankingMode;

		public uint category;

		public NexPlugin.RankingOrderParam param;

		public ulong uniqueId;

		public List<ulong> nexUniqueIdList;

		public int timeOut;

		public NexPlugin.Ranking.GetRankingCB callback;
	}

	private class GET_APPROX_ARG : CORE_ARG
	{
		public uint category;

		public NexPlugin.RankingOrderParam param;

		public uint score;

		public ulong uniqueId;

		public bool principalIdUseCurrentLogin;

		public ulong principalId;

		public int timeOut;

		public NexPlugin.Ranking.GetApproxOrderCB callback;
	}

	private class UPLOADRANK_ARG : CORE_ARG
	{
		public NexPlugin.RankingScoreData param;

		public ulong uniqueId;

		public int timeOut;

		public AsyncResultCB callback;
	}

	private class DELETERANK_ARG : CORE_ARG
	{
		public ulong uniqueId;

		public uint? category;

		public int timeOut;

		public AsyncResultCB callback;
	}

	private class UPLOADCOMMON_ARG : CORE_ARG
	{
		public List<byte> param;

		public ulong uniqueId;

		public int timeOut;

		public AsyncResultCB callback;
	}

	private class GETCOMMON_ARG : CORE_ARG
	{
		public ulong uniqueId;

		public int timeOut;

		public NexPlugin.Ranking.GetCommonDataCB callback;
	}

	private class DELETECOMMON_ARG : CORE_ARG
	{
		public ulong uniqueId;

		public int timeOut;

		public AsyncResultCB callback;
	}

	private class GETSTATS_ARG : CORE_ARG
	{
		public uint category;

		public NexPlugin.RankingOrderParam param;

		public NexPlugin.Ranking.StatsFlag flags;

		public int timeOut;

		public NexPlugin.Ranking.GetStatsCB callback;
	}

	private class CHANGE_ATTRIBUTE_ARG : CORE_ARG
	{
		public uint? category;

		public RankingChangeAttributesParam param;

		public ulong uniqueId;

		public int timeOut;

		public AsyncResultCB callback;
	}

	private class GET_CACHERANK_ARG : CORE_ARG
	{
		public uint category;

		public NexPlugin.RankingOrderParam param;

		public int timeOut;

		public NexPlugin.Ranking.GetCachedTopXRankingCB callback;
	}

	private class GET_CACHERANK_LIST_ARG : CORE_ARG
	{
		public List<uint> categorieList;

		public List<NexPlugin.RankingOrderParam> paramList;

		public int timeOut;

		public NexPlugin.Ranking.GetCachedTopXRankingsCB callback;
	}

	private enum Functions
	{
		Group1,
		Group2,
		GetRanking,
		DeleteScore,
		DeleteAllScores,
		UploadScore,
		GetCommonData,
		DeleteCommonData,
		UploadCommonData,
		GetStats,
		GetApproxOrder,
		GetRankingByPIDList,
		GetRankingByUniqueIdList,
		ChangeAttributes,
		ChangeAllAttributes,
		GetCachedTopXRanking,
		GetCachedTopXRankings
	}

	private static Dictionary<int, FunctionInfo> FunctionInfos;

	private static List<ApiCallsFrequency> s_ApiCallsFrequencyList;

	public ASYNCSTATE GetRankingAsync(RankingGetRankingParam param, ulong uniqueId = 0uL, ulong principalId = 0uL, bool principalIdUseCurrentLogin = false, [Optional] NexPlugin.Ranking.GetRankingCB callback, [Optional] IntPtr pNgsFacade, int timeOut = 0)
	{
		return default(ASYNCSTATE);
	}

	public ASYNCSTATE GetRankingAsync(NexPlugin.Ranking.RankingMode rankingMode, uint category, NexPlugin.RankingOrderParam param, ulong uniqueId = 0uL, ulong principalId = 0uL, bool principalIdUseCurrentLogin = false, [Optional] NexPlugin.Ranking.GetRankingCB callback, [Optional] IntPtr pNgsFacade, int timeOut = 0)
	{
		return default(ASYNCSTATE);
	}

	private ASYNCSTATE GetRankingAsync_(AsyncResult asyncResult, CORE_ARG param)
	{
		return default(ASYNCSTATE);
	}

	public ASYNCSTATE GetRankingByPIDListAsync(RankingGetRankingParam param, List<ulong> principalIdList, ulong uniqueId = 0uL, [Optional] NexPlugin.Ranking.GetRankingCB callback, [Optional] IntPtr pNgsFacade, int timeOut = 0)
	{
		return default(ASYNCSTATE);
	}

	public ASYNCSTATE GetRankingByPIDListAsync(List<ulong> principalIdList, NexPlugin.Ranking.RankingMode rankingMode, uint category, NexPlugin.RankingOrderParam param, ulong uniqueId = 0uL, [Optional] NexPlugin.Ranking.GetRankingCB callback, [Optional] IntPtr pNgsFacade, int timeOut = 0)
	{
		return default(ASYNCSTATE);
	}

	private ASYNCSTATE GetRankingByPIDListAsync_(AsyncResult asyncResult, CORE_ARG param)
	{
		return default(ASYNCSTATE);
	}

	public ASYNCSTATE GetRankingByUIDListAsync(RankingGetRankingParam param, List<ulong> nexUniqueIdList, ulong uniqueId = 0uL, [Optional] NexPlugin.Ranking.GetRankingCB callback, [Optional] IntPtr pNgsFacade, int timeOut = 0)
	{
		return default(ASYNCSTATE);
	}

	public ASYNCSTATE GetRankingByUIDListAsync(List<ulong> nexUniqueIdList, NexPlugin.Ranking.RankingMode rankingMode, uint category, NexPlugin.RankingOrderParam param, ulong uniqueId = 0uL, [Optional] NexPlugin.Ranking.GetRankingCB callback, [Optional] IntPtr pNgsFacade, int timeOut = 0)
	{
		return default(ASYNCSTATE);
	}

	private ASYNCSTATE GetRankingByUIDListAsync_(AsyncResult asyncResult, CORE_ARG param)
	{
		return default(ASYNCSTATE);
	}

	public ASYNCSTATE GetApproxOrderAsync(RankingGetRankingParam param, uint score, ulong uniqueId = 0uL, ulong principalId = 0uL, bool principalIdUseCurrentLogin = false, [Optional] NexPlugin.Ranking.GetApproxOrderCB callback, [Optional] IntPtr pNgsFacade, int timeOut = 0)
	{
		return default(ASYNCSTATE);
	}

	public ASYNCSTATE GetApproxOrderAsync(uint category, NexPlugin.RankingOrderParam param, uint score, ulong uniqueId = 0uL, ulong principalId = 0uL, bool principalIdUseCurrentLogin = false, [Optional] NexPlugin.Ranking.GetApproxOrderCB callback, [Optional] IntPtr pNgsFacade, int timeOut = 0)
	{
		return default(ASYNCSTATE);
	}

	private ASYNCSTATE GetApproxOrderAsync_(AsyncResult asyncResult, CORE_ARG param)
	{
		return default(ASYNCSTATE);
	}

	public ASYNCSTATE UploadScoreAsync(RankingScoreData scoreData, uint score, ulong uniqueId = 0uL, [Optional] AsyncResultCB callback, [Optional] IntPtr pNgsFacade, int timeOut = 0)
	{
		return default(ASYNCSTATE);
	}

	public ASYNCSTATE UploadScoreAsync(NexPlugin.RankingScoreData param, ulong uniqueId = 0uL, [Optional] AsyncResultCB callback, [Optional] IntPtr pNgsFacade, int timeOut = 0)
	{
		return default(ASYNCSTATE);
	}

	private ASYNCSTATE UploadScoreAsync_(AsyncResult asyncResult, CORE_ARG param)
	{
		return default(ASYNCSTATE);
	}

	public ASYNCSTATE DeleteScoreAsync(uint category, ulong uniqueId = 0uL, [Optional] AsyncResultCB callback, [Optional] IntPtr pNgsFacade, int timeOut = 0)
	{
		return default(ASYNCSTATE);
	}

	public ASYNCSTATE DeleteScoreAsync(ulong uniqueId = 0uL, [Optional] AsyncResultCB callback, [Optional] IntPtr pNgsFacade, int timeOut = 0)
	{
		return default(ASYNCSTATE);
	}

	private ASYNCSTATE DeleteScoreAsync_(AsyncResult asyncResult, CORE_ARG param)
	{
		return default(ASYNCSTATE);
	}

	public ASYNCSTATE UploadCommonDataAsync(List<byte> param, ulong uniqueId = 0uL, [Optional] AsyncResultCB callback, [Optional] IntPtr pNgsFacade, int timeOut = 0)
	{
		return default(ASYNCSTATE);
	}

	private ASYNCSTATE UploadCommonDataAsync_(AsyncResult asyncResult, CORE_ARG param)
	{
		return default(ASYNCSTATE);
	}

	public ASYNCSTATE GetCommonDataAsync(ulong uniqueId = 0uL, [Optional] NexPlugin.Ranking.GetCommonDataCB callback, [Optional] IntPtr pNgsFacade, int timeOut = 0)
	{
		return default(ASYNCSTATE);
	}

	private ASYNCSTATE GetCommonDataAsync_(AsyncResult asyncResult, CORE_ARG param)
	{
		return default(ASYNCSTATE);
	}

	public ASYNCSTATE DeleteCommonDataAsync(ulong uniqueId = 0uL, [Optional] AsyncResultCB callback, [Optional] IntPtr pNgsFacade, int timeOut = 0)
	{
		return default(ASYNCSTATE);
	}

	private ASYNCSTATE DeleteCommonDataAsync_(AsyncResult asyncResult, CORE_ARG param)
	{
		return default(ASYNCSTATE);
	}

	public ASYNCSTATE GetStatsAsync(RankingGetRankingParam param, [Optional] NexPlugin.Ranking.GetStatsCB callback, [Optional] IntPtr pNgsFacade, int timeOut = 0)
	{
		return default(ASYNCSTATE);
	}

	public ASYNCSTATE GetStatsAsync(uint category, NexPlugin.RankingOrderParam param, NexPlugin.Ranking.StatsFlag flags, [Optional] NexPlugin.Ranking.GetStatsCB callback, [Optional] IntPtr pNgsFacade, int timeOut = 0)
	{
		return default(ASYNCSTATE);
	}

	private ASYNCSTATE GetStatsAsync_(AsyncResult asyncResult, CORE_ARG param)
	{
		return default(ASYNCSTATE);
	}

	public ASYNCSTATE ChangeAttributesAsync(uint category, RankingChangeAttributesParam param, ulong uniqueId = 0uL, [Optional] AsyncResultCB callback, [Optional] IntPtr pNgsFacade, int timeOut = 0)
	{
		return default(ASYNCSTATE);
	}

	public ASYNCSTATE ChangeAttributesAsync(RankingChangeAttributesParam param, ulong uniqueId = 0uL, [Optional] AsyncResultCB callback, [Optional] IntPtr pNgsFacade, int timeOut = 0)
	{
		return default(ASYNCSTATE);
	}

	private ASYNCSTATE ChangeAttributesAsync_(AsyncResult asyncResult, CORE_ARG param)
	{
		return default(ASYNCSTATE);
	}

	public ASYNCSTATE GetCachedTopXRankingAsync(uint category, NexPlugin.RankingOrderParam param, [Optional] NexPlugin.Ranking.GetCachedTopXRankingCB callback, [Optional] IntPtr pNgsFacade, int timeOut = 0)
	{
		return default(ASYNCSTATE);
	}

	private ASYNCSTATE GetCachedTopXRankingAsync_(AsyncResult asyncResult, CORE_ARG param)
	{
		return default(ASYNCSTATE);
	}

	public ASYNCSTATE GetCachedTopXRankingsAsync(List<uint> categorieList, NexPlugin.RankingOrderParam param, [Optional] NexPlugin.Ranking.GetCachedTopXRankingsCB callback, [Optional] IntPtr pNgsFacade, int timeOut = 0)
	{
		return default(ASYNCSTATE);
	}

	public ASYNCSTATE GetCachedTopXRankingsAsync(List<uint> categorieList, List<NexPlugin.RankingOrderParam> paramList, [Optional] NexPlugin.Ranking.GetCachedTopXRankingsCB callback, [Optional] IntPtr pNgsFacade, int timeOut = 0)
	{
		return default(ASYNCSTATE);
	}

	private ASYNCSTATE GetCachedTopXRankingsAsync_(AsyncResult asyncResult, CORE_ARG param)
	{
		return default(ASYNCSTATE);
	}

	private bool ApiCallsFrequencyCheck(int type)
	{
		return default(bool);
	}
}
