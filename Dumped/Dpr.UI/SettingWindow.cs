using System.Collections;
using System.Collections.Generic;
using Audio;
using DPData;
using Dpr.MsgWindow;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Dpr.UI;

public class SettingWindow : UIWindow
{
	[SerializeField]
	private Cursor _cursor;

	[SerializeField]
	private ScrollRect _scrollRect;

	[SerializeField]
	private int _viewMenuItemNum;

	[SerializeField]
	private RectTransform _messageWindowRoot;

	private int _selectIndex;

	private List<SettingMenuItem> _activeItems;

	private int _scrollIndex;

	private CONFIG _tempConfig;

	private AudioInstance _voiceInstance;

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

	private void OnMenuItemValueChaged(SettingMenuItem menuItem)
	{
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

	private void RevertSettings()
	{
	}

	private void InitializeSettings()
	{
	}

	private void AcceptSettings()
	{
	}

	protected override void OpenMessageWindow(MsgWindowParam messageParam)
	{
	}

	protected override void OnAddContextMenuYesNoItemParams(List<ContextMenuItem.Param> contextMenuItemParams)
	{
	}

	private bool UpdateSelect(float deltaTime)
	{
		return default(bool);
	}

	private bool UpdateSelectValue(float deltaTime)
	{
		return default(bool);
	}

	private bool SetSelectIndex(int selectIndex, bool isInitialize = false)
	{
		return default(bool);
	}

	private void SetDucking(ConfigID configId = (ConfigID)(-1))
	{
	}

	private bool SetSelectValue(int selectValue)
	{
		return default(bool);
	}

	private void OpenDescriptionMessageWindow()
	{
	}

	private void SetupScrollPosition()
	{
	}
}
