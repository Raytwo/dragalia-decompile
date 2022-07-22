using System.Collections;
using System.Collections.Generic;
using Dpr.Message;
using UnityEngine;
using UnityEngine.Events;

namespace Dpr.UI;

public class SelectLanguageWindow : SelectOpeningBase
{
	[SerializeField]
	private RectTransform _content;

	[SerializeField]
	private Cursor _cursor;

	private const int _columnNum = 2;

	private const int _rowNum = 5;

	private List<SelectLanguageItem> _items;

	private int _selectIndex;

	private int _reloadAllMsbtState;

	public UnityAction onReloadLanguage;

	public int selectIndex => default(int);

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

	public void Destroy(UnityAction<UIWindow> onClosed_)
	{
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private void SetLanguage(MessageEnumData.MsgLangId lang, bool isKanji, UnityAction callback)
	{
	}

	private void OpenConfirmMessageWindow()
	{
	}

	private void OpenSelectLangMessageWindow()
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
