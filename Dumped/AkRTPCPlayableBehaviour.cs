using System;
using System.Runtime.CompilerServices;
using AK.Wwise;
using UnityEngine;
using UnityEngine.Playables;

[Serializable]
[Obsolete]
public class AkRTPCPlayableBehaviour : PlayableBehaviour
{
	[SerializeField]
	private float RTPCValue;

	public bool setRTPCGlobally
	{
		[CompilerGenerated]
		private get
		{
			return default(bool);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public bool overrideTrackObject
	{
		[CompilerGenerated]
		private get
		{
			return default(bool);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public GameObject rtpcObject
	{
		[CompilerGenerated]
		private get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public RTPC parameter
	{
		[CompilerGenerated]
		private get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}
}
