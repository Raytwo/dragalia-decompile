using System;
using NexPlugin;
using UnityEngine;

namespace NexAssets;

[Serializable]
public class RankingOrderParam
{
	[SerializeField]
	private NexPlugin.Ranking.OrderCalculation ordercalc;

	[SerializeField]
	private NexPlugin.Ranking.FilterGroupIndex groupindex;

	[SerializeField]
	private byte groupnum;

	[SerializeField]
	private NexPlugin.Ranking.TimeScope timescope;

	[SerializeField]
	private byte length;

	public NexPlugin.RankingOrderParam GetRankingOrderParam()
	{
		return null;
	}
}
