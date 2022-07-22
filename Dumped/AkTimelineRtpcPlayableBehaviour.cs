using System;
using System.Runtime.CompilerServices;
using AK.Wwise;
using UnityEngine;
using UnityEngine.Playables;

[Serializable]
public class AkTimelineRtpcPlayableBehaviour : PlayableBehaviour
{
	[SerializeField]
	private float value;

	public RTPC RTPC
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public bool setGlobally
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public GameObject gameObject
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public override void ProcessFrame(Playable playable, FrameData frameData, object playerData)
	{
	}
}
