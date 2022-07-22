using System;
using System.Collections;
using System.Collections.Generic;
using DPData;
using UnityEngine;
using UnityEngine.Events;

namespace Dpr.UI;

public class ReportWindowBase : UIWindow
{
	[SerializeField]
	protected float _closeWaitTimeBySave;

	[SerializeField]
	protected UIText _place;

	[SerializeField]
	protected UIText _nowDatetime;

	[SerializeField]
	protected UIText _name;

	[SerializeField]
	protected UIText _badge;

	[SerializeField]
	protected RectTransform _zukanRoot;

	[SerializeField]
	protected UIText _zukanRegistNum;

	[SerializeField]
	protected UIText _playTime;

	[SerializeField]
	protected UIText _saveDatetime;

	[SerializeField]
	protected RectTransform _iconContent;

	private DateTime _prevNow;

	private PLAYTIME _prevPlayTime;

	public override void OnCreate()
	{
	}

	public virtual void Open(UIWindowID prevWindowId)
	{
	}

	public virtual IEnumerator OpOpen(UIWindowID prevWindowId)
	{
		return null;
	}

	public virtual void Close(UnityAction<UIWindow> onClosed_, UIWindowID nextWindowId)
	{
	}

	public virtual IEnumerator OpClose(UnityAction<UIWindow> onClosed_, UIWindowID nextWindowId)
	{
		return null;
	}

	protected virtual void Setup()
	{
	}

	protected virtual void OnUpdate(float deltaTime)
	{
	}

	protected virtual void SaveReport()
	{
	}

	protected virtual IEnumerator OpSave()
	{
		return null;
	}

	protected virtual IEnumerator OpWaitingClose()
	{
		return null;
	}

	protected override void OnAddContextMenuYesNoItemParams(List<ContextMenuItem.Param> contextMenuItemParams)
	{
	}
}
