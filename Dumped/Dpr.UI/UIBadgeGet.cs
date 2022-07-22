using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Dpr.UI;

public class UIBadgeGet : UIWindow
{
	[SerializeField]
	private GameObject modelViewPrefab;

	[SerializeField]
	private RawImage modelViewRawImage;

	private GameObject modelViewObject;

	private BadgeGetViewController modelViewController;

	private int badgeNo;

	public override void OnCreate()
	{
	}

	public void Open(UIWindowID prevWindowId, int no)
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

	private void StartBadgeGet()
	{
	}

	private string GetBadgeAnimation()
	{
		return null;
	}
}
