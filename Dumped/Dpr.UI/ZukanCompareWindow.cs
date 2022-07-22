using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Dpr.UI;

public class ZukanCompareWindow : UIWindow
{
	public class Param
	{
		public ZukanInfo CurrentZukanInfo;

		public List<ZukanInfo> SelectableZukanInfoList;
	}

	private enum State
	{
		None,
		FadeOut,
		WaitFadeOut,
		WaitLoad,
		Show
	}

	private const int StopLoadModelCount = -1;

	private const int StartLoadModelCount = 3;

	private static readonly int TransAnimatorStateInitialize;

	private static readonly int TransAnimatorStateWait;

	private static readonly int TransAnimatorParamTransId;

	private const string TransAnimatorLayerName = "Trans";

	private const int TransIdIn = 1;

	private const int TransIdOut = 2;

	[SerializeField]
	private ZukanCompareStatusPanel statusPanel;

	[SerializeField]
	private ZukanCompareHeightController zukanCompareHeightController;

	[SerializeField]
	private ZukanCompareWeightController zukanCompareWeightController;

	[SerializeField]
	private Image arrowLeftImage;

	[SerializeField]
	private Image arrowRightImage;

	[SerializeField]
	private Image arrowUpImage;

	[SerializeField]
	private Image arrowDownImage;

	[SerializeField]
	private Animator transAnimator;

	[SerializeField]
	private ZukanCompareAnimationEvent zukanCompareAnimationEvent;

	private List<ZukanInfo> selectableZukanInfoList;

	private IndexSelector indexSelector;

	private bool isShowHeightPanel;

	private int animatorTransLayer;

	private int loadModelCount;

	private State currentState;

	private bool isSwitchPanel;

	public ZukanInfo CurrentZukanInfo
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public override void OnCreate()
	{
	}

	public void Open(Param param, UIWindowID prevWindowId)
	{
	}

	public IEnumerator OpOpen(Param param, UIWindowID prevWindowId)
	{
		return null;
	}

	public void Close(UnityAction<UIWindow> onClosed_, UIWindowID nextWindowId)
	{
	}

	public IEnumerator OpClose(UnityAction<UIWindow> onClosed_, UIWindowID nextWindowId)
	{
		return null;
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private void UpdateTrans(float deltaTime)
	{
	}

	private void UpdatePokemonSelect(float deltaTime)
	{
	}

	private void UpdateFormSelect(float deltaTime)
	{
	}

	private void UpdateLoadModelRequest(float deltaTime)
	{
	}

	private void UpdateKeyGuide()
	{
	}

	private void ShowHeightWeightPanel(bool isShowHeight)
	{
	}

	private void Setup()
	{
	}

	private void RequestLoadModel()
	{
	}
}
