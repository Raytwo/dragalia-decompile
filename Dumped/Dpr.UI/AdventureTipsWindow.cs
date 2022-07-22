using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Dpr.UI;

public class AdventureTipsWindow : AdventureBase
{
	[SerializeField]
	private Image _image;

	[SerializeField]
	private UIText _text;

	[SerializeField]
	private UIText _title;

	public override void OnCreate()
	{
	}

	public void Open(AdventureNoteID category, UIWindowID prevWindowId)
	{
	}

	public IEnumerator OpOpen(AdventureNoteID category, UIWindowID prevWindowId)
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
