using System;
using System.Collections;
using UnityEngine;

namespace Dpr.UI;

public class FatalErrorDialogWindow : UIWindow
{
	[SerializeField]
	private UIText dialogText;

	public override void OnCreate()
	{
	}

	public void Open(Action<UIText> setDialogText, UIWindowID prevWindowId = (UIWindowID)(-2))
	{
	}

	public IEnumerator OpOpen(UIWindowID prevWindowId)
	{
		return null;
	}
}
