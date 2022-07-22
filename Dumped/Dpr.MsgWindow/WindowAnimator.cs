using DG.Tweening;
using UnityEngine;

namespace Dpr.MsgWindow;

public sealed class WindowAnimator
{
	public enum AnimType
	{
		Scaling,
		Split,
		Immediate
	}

	public enum AnimState
	{
		Wait,
		Open,
		FinishedOpen,
		Close,
		FinishedClose
	}

	private AnimType wndAnimType;

	private DOTweenAnimation openAnimTween;

	private DOTweenAnimation canvasFadeTween;

	private CanvasGroup canvasGroup;

	private RectTransform contentRect;

	private AnimState currentState;

	private float timer;

	private bool bIsAnimation;

	public bool IsAnimation => default(bool);

	public AnimState CurrentState => default(AnimState);

	public void Initialize(AnimType wndAnimType, GameObject frameObj, GameObject contentObj)
	{
	}

	public void ResetAnim()
	{
	}

	public void SetAnimType(AnimType openAnimType)
	{
	}

	public void OpenWindow()
	{
	}

	public void CloseWindow()
	{
	}

	private void DoPlayScalingAnimation(bool forward)
	{
	}

	private void DOPlayForward()
	{
	}

	private void DOPlayBackwards()
	{
	}

	private void DoPlayImmediateAnimation(bool forward)
	{
	}

	public void ChangeTweenAnimationEnd()
	{
	}

	public void OnUpdate(float deltaTime)
	{
	}

	public void OnCompletedOpen()
	{
	}

	public void OnCompletedClose()
	{
	}
}
