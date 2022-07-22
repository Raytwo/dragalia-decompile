using System;
using System.Collections;
using DG.Tweening;
using DPData;
using Dpr.Demo;
using Dpr.MsgWindow;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class UIPofinResult : UIWindow
{
	[SerializeField]
	private CanvasGroup group;

	[SerializeField]
	private UIText timeText;

	[SerializeField]
	private UIText koboshiText;

	[SerializeField]
	private UIText kogashiText;

	[SerializeField]
	private Image pofinImage;

	[SerializeField]
	private UIText pofinInfo;

	[SerializeField]
	private Image Kekka;

	private bool isEnableInput;

	public Action OnExit;

	private PofinCookModel model;

	private PoffinData pofinData;

	private int poffinNum;

	private Demo_ModelViewer pofin3D_Demo;

	private int DebugModelNo;

	private int nowStateID;

	private MsgWindowParam msgParam;

	private DemoSceneManager demoMng;

	public int Button02;

	private IEnumerator Start()
	{
		return null;
	}

	public void SetData(PofinCookModel model)
	{
	}

	public void UpdateInput(float deltaTime)
	{
	}

	private void NextState()
	{
	}

	private void GetPoffinMessage()
	{
	}

	private void ContinueConfirmation()
	{
	}

	private void EndCooking()
	{
	}

	private Tweener Enter()
	{
		return null;
	}

	public Tweener Exit()
	{
		return null;
	}
}
