using System;
using UnityEngine;
using UnityEngine.Events;

namespace Dpr.UI;

public class UIAnimationEvent : MonoBehaviour
{
	[Serializable]
	public class AnimationEventBase
	{
		public enum EventType
		{
			Hoge
		}

		public EventType type;
	}

	[Serializable]
	public class AnimationEventHoge : AnimationEventBase
	{
		public int hoge;
	}

	public UnityAction<AnimationEventBase> onAnimationEvent;

	public UnityAction<TransitionID, UITransition.FadeType> onTransition;

	private void OnAnimEvent(string json)
	{
	}

	private void OnAnimEventTransitionIn(int transitionId)
	{
	}

	private void OnAnimEventTransitionOut(int transitionId)
	{
	}
}
