using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class AkTimelineRtpcTrack : TrackAsset
{
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject gameObject, int inputCount)
	{
		return default(Playable);
	}

	public void OnValidate()
	{
	}
}
