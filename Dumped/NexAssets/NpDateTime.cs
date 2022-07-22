using System;
using NexPlugin;
using UnityEngine;

namespace NexAssets;

[Serializable]
public class NpDateTime
{
	[SerializeField]
	private byte day;

	[SerializeField]
	private byte hour;

	[SerializeField]
	private byte minute;

	[SerializeField]
	private byte month;

	[SerializeField]
	private byte second;

	[SerializeField]
	private short year;

	public void Validate()
	{
	}

	public NexPlugin.NpDateTime GetNpDateTime()
	{
		return default(NexPlugin.NpDateTime);
	}
}
