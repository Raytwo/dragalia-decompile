using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.DigFossil;

public class DigFade : MonoBehaviour, IDigFade
{
	public enum Type
	{
		OverUI,
		OverEffect
	}

	[SerializeField]
	private RawImage overUIImage;

	[SerializeField]
	private RawImage overEffectImage;

	private Color endColor;

	private Action onEndCallback;

	private RawImage currentImage;

	private void Start()
	{
	}

	public void FadeStart(Type type, Color startColor, Color endColor, float duration, Action onEndCallback)
	{
	}

	public void Close()
	{
	}

	private IEnumerator Idle(float duration)
	{
		return null;
	}
}
