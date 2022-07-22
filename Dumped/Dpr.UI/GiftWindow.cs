using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Dpr.UI;

public class GiftWindow : UIWindow
{
	private static readonly Vector2 MsgWindowAnchorPos;

	[SerializeField]
	private GiftNetworkController networkController;

	[SerializeField]
	private GiftMainMenuWindow mainMenuWindow;

	[SerializeField]
	private GiftSerialCodeWindow serialCodeWindow;

	[SerializeField]
	private GiftDownloadWindow downloadWindow;

	[SerializeField]
	private GiftListWindow listWindow;

	[SerializeField]
	private GiftCompleteWindow completeWindow;

	[SerializeField]
	private GiftHistoryWindow historyWindow;

	[SerializeField]
	private GiftErrorWindow errorWindow;

	private UIMsgWindowController msgWindowController;

	private GiftSubWindow beforeSubWindow;

	private GiftSubWindow currentSubWindow;

	private bool isFirstShowSerialCode;

	private bool isSuccessInternetGo;

	public override void OnCreate()
	{
	}

	protected override void OnAddContextMenuYesNoItemParams(List<ContextMenuItem.Param> contextMenuItemParams)
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

	private void HideAllSubWindows()
	{
	}

	private void ShowMainMenuWindow()
	{
	}

	private void ShowSerialCodeWindow(bool isClear)
	{
	}

	private void ShowDownloadWindow(int min, int max)
	{
	}

	private void ShowListWindow(GiftListItemInfo[] giftListItemInfos, Action onReceivedGift, bool isSerial)
	{
	}

	private void ShowCompleteWindow()
	{
	}

	private void ShowHistoryWindow()
	{
	}

	private void ShowErrorWindow(string labelName, UnityAction<UIWindow> onCloseCallback)
	{
	}

	private void OnCloseMainMenuWindow(UIWindow subWindow)
	{
	}

	private void OnCloseSerialCodeWindow(UIWindow subWindow)
	{
	}

	private void OnCloseListWindow(UIWindow subWindow)
	{
	}

	private void OnCloseHistoryWindow(UIWindow subWindow)
	{
	}

	private IEnumerator StartReceiveInternet()
	{
		return null;
	}

	private IEnumerator StartReceiveSerialCode()
	{
		return null;
	}

	private IEnumerator ConnectInternet(bool isShowWarningSerialCode)
	{
		return null;
	}

	private IEnumerator StartAuthenticateSerialCode(string inputCode)
	{
		return null;
	}

	private IEnumerator DownloadList(ushort dataNo, bool isSerial)
	{
		return null;
	}

	private List<GiftListItemInfo> ConvertGiftDatas(byte[] data)
	{
		return null;
	}

	private IEnumerator StartProgress(int max)
	{
		return null;
	}
}
