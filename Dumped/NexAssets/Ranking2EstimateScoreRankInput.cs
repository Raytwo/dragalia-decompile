using System;
using NexPlugin;
using UnityEngine;

namespace NexAssets;

[Serializable]
public class Ranking2EstimateScoreRankInput
{
	[SerializeField]
	private uint category;

	[SerializeField]
	private byte numSeasonsToGoBack;

	public NexPlugin.Ranking2EstimateScoreRankInput GetRanking2EstimateScoreRankInput()
	{
		return default(NexPlugin.Ranking2EstimateScoreRankInput);
	}
}
