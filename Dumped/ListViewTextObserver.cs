using System;
using System.Runtime.InteropServices;
using SmartPoint.Components;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class ListViewTextObserver : LayoutCellObserver
{
	[Serializable]
	public class CallbackEvent : UnityEvent<string, WeakReference>
	{
	}

	public class Item
	{
		public string text;

		public CallbackEvent onClick;

		public WeakReference reference;

		public Item([Optional] string text, [Optional] UnityAction<string, WeakReference> callback, [Optional] WeakReference reference)
		{
		}
	}

	public LayoutScrollView.Cell _cell;

	public TextMeshProUGUI _contentText;

	public override Vector2 sizeDelta => default(Vector2);

	public override void OnUpdate(float deltaTime)
	{
	}

	public void OnClick()
	{
	}

	public override bool IsReady()
	{
		return default(bool);
	}

	public override bool OnRebuildLayout()
	{
		return default(bool);
	}

	public override void OnClose()
	{
	}
}
