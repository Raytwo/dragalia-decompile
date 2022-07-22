using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Dpr.UI;

public class GiftListWindow : GiftSubWindow
{
	private static readonly Vector2 MsgWindowAnchorPos;

	[SerializeField]
	private UIScrollView scrollView;

	[SerializeField]
	private Cursor cursor;

	private List<GiftListItemInfo> giftListItemInfoList;

	private GiftCompleteWindow completeWindow;

	private GiftErrorWindow errorWindow;

	private int selectIndex;

	private bool isShowComplete;

	private bool isShowError;

	private bool isSerialUsed;

	private Action onReceivedGift;

	public bool IsNoItem
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	protected override void OnAddContextMenuYesNoItemParams(List<ContextMenuItem.Param> contextMenuItemParams)
	{
	}

	protected override void OnDestroy()
	{
	}

	protected override void OnInitialize()
	{
	}

	public override void OnUpdate(float deltaTime)
	{
	}

	public override void Show()
	{
	}

	public void Setup(GiftListItemInfo[] giftListItemInfos, Action onReceivedGift, GiftCompleteWindow completeWindow, GiftErrorWindow errorWindow, bool isSerialUsed)
	{
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

	private void RefreshScrollView()
	{
	}

	private void ShowListMessage()
	{
	}

	private void CloseWindow()
	{
	}

	private void ShowErrorWindow(string labelName)
	{
	}

	private IEnumerator ReceiveGift(int selectIndex)
	{
		return null;
	}
}
