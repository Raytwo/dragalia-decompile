using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Dpr.UI;

public class TownmapWindow : TownmapWindowBase
{
	[Serializable]
	private class GuideNavi
	{
		public RectTransform root;

		public UIText text;
	}

	public class Param
	{
		public Townmap.TownmapType type;
	}

	[SerializeField]
	private Townmap _townmap;

	[SerializeField]
	private Cursor _cursor;

	[SerializeField]
	private GuideNavi _guide;

	[SerializeField]
	private TownmapFacility _facility;

	[SerializeField]
	private TownmapInfo _info;

	[SerializeField]
	private TownmapSymbolName _symbolName;

	private Townmap.NoticeType _noticeType;

	private Param _param;

	public override void OnCreate()
	{
	}

	public void Open(Param param, UIWindowID prevWindowId)
	{
	}

	public IEnumerator OpOpen(Param param, UIWindowID prevWindowId)
	{
		return null;
	}

	private void SetupKeyguide(Townmap.Cell cell)
	{
	}

	protected override bool IsFly(Townmap.Cell cell)
	{
		return default(bool);
	}

	public override void Close(UnityAction<UIWindow> onClosed_, UIWindowID nextWindowId)
	{
	}

	public IEnumerator OpClose(UnityAction<UIWindow> onClosed_, UIWindowID nextWindowId)
	{
		return null;
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private void UpdateCursor()
	{
	}

	private void OnCellChanged(Townmap.Cell cell, bool isReset)
	{
	}

	private void OnNoticeChanged(Townmap.NoticeType type)
	{
	}
}
