using System;
using NexPlugin;
using UnityEngine;

namespace NexAssets;

[Serializable]
public class ResultRange
{
	[SerializeField]
	private uint offset;

	[SerializeField]
	private uint size;

	[SerializeField]
	private bool useAnyOffset;

	public void Validate()
	{
	}

	public NexPlugin.ResultRange GetResultRange()
	{
		return null;
	}
}
