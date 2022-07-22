using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Dpr.UI;

public class FloorWindow : UIWindow
{
	[SerializeField]
	private UIText _number;

	public override void OnCreate()
	{
	}

	public void Open(FLOOR_DISPLAY floorId, UIWindowID prevWindowId)
	{
	}

	public IEnumerator OpOpen(FLOOR_DISPLAY floorId, UIWindowID prevWindowId)
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
