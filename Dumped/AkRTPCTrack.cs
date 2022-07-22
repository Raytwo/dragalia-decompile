using System;
using AK.Wwise;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Obsolete]
public class AkRTPCTrack : TrackAsset
{
	public RTPC Parameter;

	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	public void setPlayableProperties()
	{
	}

	public void OnValidate()
	{
	}
}
