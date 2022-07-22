using UnityEngine;
using UnityEngine.Playables;

public class TimelineEffectBehaviour : PlayableBehaviour
{
	[SerializeField]
	private GameObject go;

	public override void OnGraphStart(Playable playable)
	{
	}

	public override void OnGraphStop(Playable playable)
	{
	}

	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	public override void PrepareFrame(Playable playable, FrameData info)
	{
	}
}
