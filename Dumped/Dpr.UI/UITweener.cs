using System;
using UnityEngine;

namespace Dpr.UI;

public static class UITweener
{
	public enum ArrowDirection
	{
		Up,
		Down,
		Left,
		Right
	}

	private const float ArrowTweenMoveValue = 20f;

	private const float ArrowTweenMoveDuration = 0.05f;

	public static void PlayArrowTween(RectTransform rectTransform, ArrowDirection direction)
	{
	}

	public static Coroutine StartRemoveNewIcon(Action onRemove)
	{
		return null;
	}
}
