using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Dpr.UI;

public class SelectPlayerVisualWindow : SelectOpeningBase
{
	[SerializeField]
	private RectTransform _content;

	[SerializeField]
	private Cursor _cursor;

	private const int _columnNum = 4;

	private const int _rowNum = 2;

	private List<SelectPlayerVisualItem> _items;

	private int _selectIndex;

	public SelectPlayerVisualItem selectItem => null;

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

	private void UpdateSelect(float deltaTime)
	{
	}

	private bool SetSelectIndex(int index, bool isInitialized = false)
	{
		return default(bool);
	}

	protected override void OnAddContextMenuYesNoItemParams(List<ContextMenuItem.Param> contextMenuItemParams)
	{
	}
}
