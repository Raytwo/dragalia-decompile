using System;
using NexPlugin;
using UnityEngine;

namespace NexAssets;

[Serializable]
public class Ranking2ChartInfoInput
{
	[SerializeField]
	private uint chartIndex;

	[SerializeField]
	private byte numSeasonsToGoBack;

	public NexPlugin.Ranking2ChartInfoInput GetRanking2ChartInfoInput()
	{
		return default(NexPlugin.Ranking2ChartInfoInput);
	}
}
