using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Dpr.UI;

public class Keyguide : UIWindow
{
	public class Param
	{
		public List<KeyguideItem.Param> itemParams;
	}

	[SerializeField]
	private RectTransform _guideRoot;

	[SerializeField]
	private KeyguideItem _itemPrefab;

	private bool _isOpen;

	private void Awake()
	{
	}

	public void Open(Param param)
	{
	}

	public IEnumerator OpOpen(Param param)
	{
		return null;
	}

	public void Setup(Param param)
	{
	}

	public void Close(UnityAction<UIWindow> onClosed_)
	{
	}

	public IEnumerator OpClose(UnityAction<UIWindow> onClosed_)
	{
		return null;
	}
}
