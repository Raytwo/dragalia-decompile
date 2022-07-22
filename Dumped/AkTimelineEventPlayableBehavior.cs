using System;
using AK.Wwise;
using UnityEngine;
using UnityEngine.Playables;

public class AkTimelineEventPlayableBehavior : PlayableBehaviour
{
	[Flags]
	private enum Actions
	{
		None = 0,
		Playback = 1,
		Retrigger = 2,
		DelayedStop = 4,
		Seek = 8,
		FadeIn = 0x10,
		FadeOut = 0x20
	}

	private float currentDuration;

	private float currentDurationProportion;

	private bool eventIsPlaying;

	private bool fadeinTriggered;

	private bool fadeoutTriggered;

	private float previousEventStartTime;

	private const uint CallbackFlags = 9u;

	private Actions requiredActions;

	private const int scrubPlaybackLengthMs = 100;

	public AK.Wwise.Event akEvent;

	public float eventDurationMax;

	public float eventDurationMin;

	public float blendInDuration;

	public float blendOutDuration;

	public float easeInDuration;

	public float easeOutDuration;

	public AkCurveInterpolation blendInCurve;

	public AkCurveInterpolation blendOutCurve;

	public GameObject eventObject;

	public bool retriggerEvent;

	private bool wasScrubbingAndRequiresRetrigger;

	public bool StopEventAtClipEnd;

	private const float alph = 0.05f;

	private void CallbackHandler(object in_cookie, AkCallbackType in_type, AkCallbackInfo in_info)
	{
	}

	private bool IsScrubbing(FrameData info)
	{
		return default(bool);
	}

	public override void PrepareFrame(Playable playable, FrameData info)
	{
	}

	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	private bool ShouldPlay(Playable playable)
	{
		return default(bool);
	}

	private void CheckForFadeInFadeOut(Playable playable)
	{
	}

	private void CheckForFadeOut(Playable playable, double currentClipTime)
	{
	}

	private void TriggerFadeIn(Playable playable)
	{
	}

	private void TriggerFadeOut(Playable playable)
	{
	}

	private void StopEvent(int transition = 0)
	{
	}

	private bool PostEvent()
	{
		return default(bool);
	}

	private void PlayEvent()
	{
	}

	private void RetriggerEvent(Playable playable)
	{
	}

	private float GetProportionalTime(Playable playable)
	{
		return default(float);
	}

	private float SeekToTime(Playable playable)
	{
		return default(float);
	}
}
