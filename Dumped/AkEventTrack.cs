using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Obsolete]
public class AkEventTrack : TrackAsset
{
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}
}
