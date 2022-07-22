using System;
using NexPlugin;
using UnityEngine;

namespace NexAssets;

[Serializable]
public class Ranking2ScoreData
{
	[SerializeField]
	private uint category;

	[SerializeField]
	private string misc;

	private ulong misc_;

	public void Validate()
	{
	}

	public NexPlugin.Ranking2ScoreData GetScoreData()
	{
		return null;
	}
}
