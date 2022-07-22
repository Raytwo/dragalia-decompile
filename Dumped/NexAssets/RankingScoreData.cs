using System;
using NexPlugin;
using UnityEngine;

namespace NexAssets;

[Serializable]
public class RankingScoreData
{
	[SerializeField]
	private uint category;

	[SerializeField]
	private NexPlugin.Ranking.OrderBy orderby;

	[SerializeField]
	private NexPlugin.Ranking.UpdateMode mode;

	[SerializeField]
	private byte group0;

	[SerializeField]
	private byte group1;

	[SerializeField]
	private string param;

	private ulong param_;

	public void Validate()
	{
	}

	public NexPlugin.RankingScoreData GetRankingScoreData()
	{
		return null;
	}
}
