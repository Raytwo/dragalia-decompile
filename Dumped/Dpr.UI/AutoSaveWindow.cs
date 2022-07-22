using System.Collections;
using UnityEngine.Events;

namespace Dpr.UI;

public class AutoSaveWindow : UIWindow
{
	public const int SORTING_ORDER = 16484;

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
