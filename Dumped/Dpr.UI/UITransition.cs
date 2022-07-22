using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Dpr.UI;

public class UITransition : MonoBehaviour
{
	public enum FadeType
	{
		None = -1,
		In,
		Out
	}

	protected readonly int _animStateIn;

	protected readonly int _animStateOut;

	protected Animator _animator;

	protected Coroutine _coroutine;

	protected UnityAction<FadeType> _onComplete;

	protected FadeType _fadeType;

	protected void Awake()
	{
	}

	public virtual void PlayFade(FadeType fadeType, UnityAction<FadeType> onComplete)
	{
	}

	protected virtual IEnumerator OpPlayFade()
	{
		return null;
	}
}
