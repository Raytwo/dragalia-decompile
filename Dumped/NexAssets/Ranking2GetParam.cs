using System;
using NexPlugin;
using UnityEngine;

namespace NexAssets;

[Serializable]
public class Ranking2GetParam
{
	[SerializeField]
	private uint category;

	[SerializeField]
	private uint length;

	[SerializeField]
	private NexPlugin.Ranking2.Ranking2GetOptionFlags optionFlag;

	[SerializeField]
	private NexPlugin.Ranking2.Ranking2SortFlags sortFlag;

	[SerializeField]
	private Ranking2Mode mode;

	[SerializeField]
	private byte period;

	public NexPlugin.Ranking2GetParam GetRanking2GetParam()
	{
		return null;
	}
}
