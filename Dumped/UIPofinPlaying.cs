using System;
using System.Collections;
using DG.Tweening;
using Dpr.UI;
using UnityEngine;
using UnityEngine.UI;

public class UIPofinPlaying : MonoBehaviour
{
	public enum MessageType
	{
		TooSlow,
		TooFast,
		LittleSlow,
		LittleFast,
		VerySlow,
		_None
	}

	[SerializeField]
	private Image Arrow;

	[SerializeField]
	private Sprite rightArrow;

	[SerializeField]
	private Sprite leftArrow;

	[SerializeField]
	private Image CountDigit;

	[SerializeField]
	private RectTransform CountFrame;

	[SerializeField]
	private Sprite[] DigitSprite;

	[SerializeField]
	private Image StartImage;

	[SerializeField]
	private Image CompleteImage;

	[SerializeField]
	private CanvasGroup MessageFrame;

	[SerializeField]
	private UIText MessageText;

	[SerializeField]
	private Image[] KinomiImages;

	public bool isStart;

	private static readonly string[] textLabels;

	public int Button0;

	private Sequence seq;

	public int Button01;

	public int Button02;

	public int Button03;

	public int Button04;

	public int Button05;

	[SerializeField]
	private Ease ease;

	public int Button06;

	public int Button07;

	public int Button08;

	private Tweener tw_scale;

	private Tweener tw_fade;

	private Tween delay;

	private MessageType nowMessage;

	public int Button09;

	public int Button10;

	private void Start()
	{
	}

	public void PlayStart(int[] kinomiIDs, Action KinomiInEffect)
	{
	}

	public IEnumerator StartCor(int[] kinomiIDs, Action KinomiInEffect)
	{
		return null;
	}

	public Tween RightArrow()
	{
		return null;
	}

	public Tween LeftArrow()
	{
		return null;
	}

	public Tweener ArrowClear()
	{
		return null;
	}

	public Tweener CountDown(int digit)
	{
		return null;
	}

	public Tweener KinomiIn()
	{
		return null;
	}

	public Tweener StartText()
	{
		return null;
	}

	public Tweener CompleteText()
	{
		return null;
	}

	public void TextInit()
	{
	}

	public void TextExit()
	{
	}

	public void PlayMessage(MessageType type)
	{
	}

	public void EndMessage()
	{
	}
}
