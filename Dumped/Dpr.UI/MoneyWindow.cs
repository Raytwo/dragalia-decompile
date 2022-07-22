using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Dpr.UI;

public class MoneyWindow : UIWindow
{
	[SerializeField]
	private UIText _money;

	private int _prevMoney;

	public override void OnCreate()
	{
	}

	public void Open(UIWindowID prevWindowId)
	{
	}

	public IEnumerator OpOpen(UIWindowID prevWindowId)
	{
		return null;
	}

	private void SetupMoney(bool isInitialized = false)
	{
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
