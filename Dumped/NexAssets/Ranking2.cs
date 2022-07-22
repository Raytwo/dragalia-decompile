using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using NexPlugin;

namespace NexAssets;

public class Ranking2 : Common
{
	private class GETRANKING_ARG : CORE_ARG
	{
		public NexPlugin.Ranking2GetParam param;

		public int timeOut;

		public NexPlugin.Ranking2.GetRankingCB callback;
	}

	private class GETRANKINGBYLIST_ARG : CORE_ARG
	{
		public Ranking2GetByListParam param;

		public List<ulong> principalIdList;

		public int timeOut;

		public NexPlugin.Ranking2.GetRankingCB callback;
	}

	private class PUTSCORE_ARG : CORE_ARG
	{
		public NexPlugin.Ranking2ScoreData param;

		public ulong uniqueId;

		public int timeOut;

		public AsyncResultCB callback;
	}

	private class PUTSCORELIST_ARG : CORE_ARG
	{
		public List<NexPlugin.Ranking2ScoreData> paramList;

		public ulong uniqueId;

		public int timeOut;

		public AsyncResultCB callback;
	}

	private class PUTCOMMON_ARG : CORE_ARG
	{
		public Ranking2CommonData param;

		public ulong uniqueId;

		public int timeOut;

		public AsyncResultCB callback;
	}

	private class GETCOMMON_ARG : CORE_ARG
	{
		public NexPlugin.Ranking2.Ranking2GetOptionFlags optionFlags;

		public ulong uniqueId;

		public bool principalIdUseCurrentLogin;

		public ulong principalId;

		public int timeOut;

		public NexPlugin.Ranking2.GetCommonDataCB callback;
	}

	private class DELETECOMMON_ARG : CORE_ARG
	{
		public ulong uniqueId;

		public int timeOut;

		public AsyncResultCB callback;
	}

	private class GETCATEGORY_ARG : CORE_ARG
	{
		public uint category;

		public int timeOut;

		public NexPlugin.Ranking2.GetCategorySettingCB callback;
	}

	private class GETESTIMATESCORERANK_ARG : CORE_ARG
	{
		public NexPlugin.Ranking2EstimateScoreRankInput param;

		public int timeOut;

		public NexPlugin.Ranking2.GetRanking2EstimateScoreRankCB callback;
	}

	private class GETRANKINGCHART_ARG : CORE_ARG
	{
		public NexPlugin.Ranking2ChartInfoInput param;

		public int timeOut;

		public NexPlugin.Ranking2.GetRanking2ChartInfoCB callback;
	}

	private class GETRANKINGCHARTS_ARG : CORE_ARG
	{
		public List<NexPlugin.Ranking2ChartInfoInput> param;

		public int timeOut;

		public NexPlugin.Ranking2.GetRanking2ChartInfoListCB callback;
	}

	private enum Functions
	{
		GetRanking,
		GetRankingPid,
		GetCategorySetting,
		PutScore,
		PutCommonData,
		GetCommonData,
		DeleteCommonData,
		GetEstimateScoreRank,
		GetRankingChart,
		GetRankingCharts
	}

	private static Dictionary<int, FunctionInfo> FunctionInfos;

	private static List<ApiCallsFrequency> s_ApiCallsFrequencyList;

	public ASYNCSTATE GetRankingAsync(NexPlugin.Ranking2GetParam param, [Optional] NexPlugin.Ranking2.GetRankingCB callback, [Optional] IntPtr pNgsFacade, int timeOut = 0)
	{
		return default(ASYNCSTATE);
	}

	private ASYNCSTATE GetRankingAsync_(AsyncResult asyncResult, CORE_ARG param)
	{
		return default(ASYNCSTATE);
	}

	public ASYNCSTATE GetRankingByPIDListAsync(Ranking2GetByListParam param, List<ulong> principalIdList, [Optional] NexPlugin.Ranking2.GetRankingCB callback, [Optional] IntPtr pNgsFacade, int timeOut = 0)
	{
		return default(ASYNCSTATE);
	}

	private ASYNCSTATE GetRankingByPIDListAsync_(AsyncResult asyncResult, CORE_ARG param)
	{
		return default(ASYNCSTATE);
	}

	public ASYNCSTATE PutScoreAsync(Ranking2ScoreData param, uint score, ulong uniqueId = 0uL, [Optional] AsyncResultCB callback, [Optional] IntPtr pNgsFacade, int timeOut = 0)
	{
		return default(ASYNCSTATE);
	}

	public ASYNCSTATE PutScoreAsync(NexPlugin.Ranking2ScoreData param, ulong uniqueId = 0uL, [Optional] AsyncResultCB callback, [Optional] IntPtr pNgsFacade, int timeOut = 0)
	{
		return default(ASYNCSTATE);
	}

	private ASYNCSTATE PutScoreAsync_(AsyncResult asyncResult, CORE_ARG param)
	{
		return default(ASYNCSTATE);
	}

	public ASYNCSTATE PutScoreListAsync(List<NexPlugin.Ranking2ScoreData> paramList, ulong uniqueId = 0uL, [Optional] AsyncResultCB callback, [Optional] IntPtr pNgsFacade, int timeOut = 0)
	{
		return default(ASYNCSTATE);
	}

	private ASYNCSTATE PutScoreListAsync_(AsyncResult asyncResult, CORE_ARG param)
	{
		return default(ASYNCSTATE);
	}

	public ASYNCSTATE PutCommonDataAsync(Ranking2CommonData param, ulong uniqueId = 0uL, [Optional] AsyncResultCB callback, [Optional] IntPtr pNgsFacade, int timeOut = 0)
	{
		return default(ASYNCSTATE);
	}

	private ASYNCSTATE PutCommonDataAsync_(AsyncResult asyncResult, CORE_ARG param)
	{
		return default(ASYNCSTATE);
	}

	public ASYNCSTATE GetCommonDataAsync(NexPlugin.Ranking2.Ranking2GetOptionFlags optionFlags, ulong principalId = 0uL, ulong uniqueId = 0uL, bool principalIdUseCurrentLogin = false, [Optional] NexPlugin.Ranking2.GetCommonDataCB callback, [Optional] IntPtr pNgsFacade, int timeOut = 0)
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

	public ASYNCSTATE GetCategorySettingAsync(uint category, [Optional] NexPlugin.Ranking2.GetCategorySettingCB callback, [Optional] IntPtr pNgsFacade, int timeOut = 0)
	{
		return default(ASYNCSTATE);
	}

	private ASYNCSTATE GetCategorySettingAsync_(AsyncResult asyncResult, CORE_ARG param)
	{
		return default(ASYNCSTATE);
	}

	public ASYNCSTATE GetEstimateScoreRankAsync(Ranking2EstimateScoreRankInput param, uint score, [Optional] NexPlugin.Ranking2.GetRanking2EstimateScoreRankCB callback, [Optional] IntPtr pNgsFacade, int timeOut = 0)
	{
		return default(ASYNCSTATE);
	}

	public ASYNCSTATE GetEstimateScoreRankAsync(NexPlugin.Ranking2EstimateScoreRankInput param, [Optional] NexPlugin.Ranking2.GetRanking2EstimateScoreRankCB callback, [Optional] IntPtr pNgsFacade, int timeOut = 0)
	{
		return default(ASYNCSTATE);
	}

	private ASYNCSTATE GetEstimateScoreRankAsync_(AsyncResult asyncResult, CORE_ARG param)
	{
		return default(ASYNCSTATE);
	}

	public ASYNCSTATE GetRankingChartAsync(Ranking2ChartInfoInput param, [Optional] NexPlugin.Ranking2.GetRanking2ChartInfoCB callback, [Optional] IntPtr pNgsFacade, int timeOut = 0)
	{
		return default(ASYNCSTATE);
	}

	public ASYNCSTATE GetRankingChartAsync(NexPlugin.Ranking2ChartInfoInput param, [Optional] NexPlugin.Ranking2.GetRanking2ChartInfoCB callback, [Optional] IntPtr pNgsFacade, int timeOut = 0)
	{
		return default(ASYNCSTATE);
	}

	private ASYNCSTATE GetRankingChartAsync_(AsyncResult asyncResult, CORE_ARG param)
	{
		return default(ASYNCSTATE);
	}

	public ASYNCSTATE GetRankingChartsAsync(List<NexPlugin.Ranking2ChartInfoInput> param, [Optional] NexPlugin.Ranking2.GetRanking2ChartInfoListCB callback, [Optional] IntPtr pNgsFacade, int timeOut = 0)
	{
		return default(ASYNCSTATE);
	}

	private ASYNCSTATE GetRankingChartsAsync_(AsyncResult asyncResult, CORE_ARG param)
	{
		return default(ASYNCSTATE);
	}

	private bool ApiCallsFrequencyCheck(int type)
	{
		return default(bool);
	}
}
