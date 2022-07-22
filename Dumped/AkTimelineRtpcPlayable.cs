using System.Runtime.CompilerServices;
using AK.Wwise;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class AkTimelineRtpcPlayable : PlayableAsset, ITimelineClipAsset
{
	public RTPC RTPC;

	public bool setGlobally;

	public AkTimelineRtpcPlayableBehaviour template;

	public TimelineClip owningClip
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

	public void SetupClipDisplay()
	{
	}

	public override Playable CreatePlayable(PlayableGraph graph, GameObject gameObject)
	{
		return default(Playable);
	}
}
