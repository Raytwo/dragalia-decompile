using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Dpr.UI;

public class AdventureNoteWindow : AdventureBase
{
	[SerializeField]
	private UIScrollView _itemListScrollView;

	[SerializeField]
	private Cursor _cursor;

	private List<AdventureNoteItem.Param> _itemParams;

	private AdventureNoteItem _selectItem;

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

	private void SetupKeyguide()
	{
	}

	public void Close(UnityAction<UIWindow> onClosed_, UIWindowID nextWindowId)
	{
	}

	public IEnumerator OpClose(UnityAction<UIWindow> onClosed_, UIWindowID nextWindowId)
	{
		return null;
	}

	private void OnRequiredItemData(IUIButton button)
	{
	}

	private void OnSelectItemScrollViewItem(IUIButton button)
	{
	}

	private void OnUnSelectItemScrollViewItem(IUIButton button)
	{
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private bool UpdateSelect(float deltaTime)
	{
		return default(bool);
	}

	private bool MoveSelect(int move)
	{
		return default(bool);
	}
}
