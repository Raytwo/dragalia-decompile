using System;
using System.Runtime.CompilerServices;
using AK.Wwise;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Serializable]
[Obsolete]
public class AkRTPCPlayable : PlayableAsset, ITimelineClipAsset
{
	public bool overrideTrackObject;

	public ExposedReference<GameObject> RTPCObject;

	public bool setRTPCGlobally;

	public AkRTPCPlayableBehaviour template;

	public RTPC Parameter
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

	public TimelineClip OwningClip
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

	ClipCaps ITimelineClipAsset.clipCaps => default(ClipCaps);

	public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
	{
		return default(Playable);
	}
}
