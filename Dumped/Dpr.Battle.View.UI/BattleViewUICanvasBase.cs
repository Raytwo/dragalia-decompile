using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;
using UnityEngine;

namespace Dpr.Battle.View.UI;

public abstract class BattleViewUICanvasBase : MonoBehaviour
{
	public enum TransitionType : byte
	{
		FadeInOut,
		SlideInOut,
		Animator
	}

	public enum BattleUIAnimationState
	{
		None,
		Opening,
		Opened,
		closing,
		Closed
	}

	[Serializable]
	public struct TransitionParams
	{
		public Vector2 HideAnchorPosition;

		public Vector2 ShowAnchorPosition;

		public Ease Ease;

		public float Duration;

		public float Delay;

		public static TransitionParams Factory()
		{
			return default(TransitionParams);
		}
	}

	[SerializeField]
	protected TransitionType _transitionType;

	[SerializeField]
	protected TransitionParams _transitionParams;

	private RectTransform _cachedRectTransform;

	protected CanvasGroup _canvasGroup;

	protected Action _onShowComplete;

	protected Action _onHideComplete;

	public RectTransform RectTransform => null;

	protected int MaxIndex
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public CanvasGroup CanvasGroup => null;

	public int CurrentIndex
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	public bool IsFocus
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	public bool IsShow
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	public bool IsValid
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	public bool IsTransition
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	public BattleUIAnimationState animationState
	{
		[CompilerGenerated]
		get
		{
			return default(BattleUIAnimationState);
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	public bool isOpenState => default(bool);

	public bool isCloseState => default(bool);

	private void OnDestroy()
	{
	}

	public virtual void Startup()
	{
	}

	public virtual void Reset()
	{
	}

	public virtual void UnInitialize()
	{
	}

	public abstract void OnUpdate(float deltaTime);

	public void Show([Optional] Action onComplete)
	{
	}

	public void Hide(bool isForce = false, [Optional] Action onComplete)
	{
	}

	protected void PlayTransitionAnimation(bool isShow)
	{
	}

	private IEnumerator OnPlayAnimationCor(float time)
	{
		return null;
	}

	protected virtual void PreparaNext(bool isForward)
	{
	}

	public virtual void ForceHide()
	{
	}

	protected virtual void OnShow()
	{
	}

	protected virtual void OnHide()
	{
	}

	protected virtual void OnPlayAnimation()
	{
	}

	protected virtual void SetAlpha(float alpha, float duration = 0f)
	{
	}

	protected void SelectButton<T>(ICollection<T> buttons, int index, bool isPlaySe = true) where T : BUIButtonBase<T>
	{
	}
}
