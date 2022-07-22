using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Dpr.UI;

public class DialogWindow : UIWindow
{
	[SerializeField]
	private UIText dialogText;

	[SerializeField]
	private float inputEnableWaitTime;

	private int addSortingOrder;

	public override void OnCreate()
	{
	}

	public void Open(Action<UIText> setDialogText, int addSortingOrder = 0, UIWindowID prevWindowId = (UIWindowID)(-2))
	{
	}

	public IEnumerator OpOpen(UIWindowID prevWindowId)
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
}
