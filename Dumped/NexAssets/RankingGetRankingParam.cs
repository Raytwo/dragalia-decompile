using System;
using NexPlugin;
using UnityEngine;

namespace NexAssets;

[Serializable]
public class RankingGetRankingParam
{
	[SerializeField]
	private uint category;

	[SerializeField]
	private NexPlugin.Ranking.RankingMode mode;

	[SerializeField]
	private NexPlugin.Ranking.StatsFlag statsflag;

	[SerializeField]
	private RankingOrderParam rankingOrderParam;

	public uint GetCategory()
	{
		return default(uint);
	}

	public NexPlugin.Ranking.RankingMode GetRankingMode()
	{
		return default(NexPlugin.Ranking.RankingMode);
	}

	public NexPlugin.Ranking.StatsFlag GetStatsFlag()
	{
		return default(NexPlugin.Ranking.StatsFlag);
	}

	public NexPlugin.RankingOrderParam GetRankingOrderParam()
	{
		return null;
	}
}
