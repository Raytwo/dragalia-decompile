using System;
using System.Runtime.InteropServices;
using DPData;
using Dpr.Message;
using Dpr.MsgWindow;
using Dpr.UI;
using UnityEngine;
using XLSXContent;

namespace Dpr.GMS;

public class GMSMessageWindow
{
	private readonly Vector2 CENTER_WINDOW_POS;

	private readonly Vector2 MSG_WINDOW_POS;

	private string[] choiceYesNoTexts;

	private string[] choiceGMSModeTexts;

	private string[] choiceTradeTexts;

	private string[] choiceMarkedMonsDataTexts;

	private string[] choiceMonsDataTexts;

	private GMSMasterData.SheetWindowMessage[] windowMsgDatas;

	private Dpr.MsgWindow.MsgWindow msgWindow;

	private MessageMsgFile useMsgFile;

	private MsgWindowParam msgWindowParam;

	private ContextMenuWindow.Param contextParam;

	private WaitTimer waitTimer;

	private MSGSPEED msgSpeed;

	private int prevUseMsgFileNameHash;

	private bool bIsAutoCloseMsg;

	private bool bIsOpenWindow;

	public bool IsOpen => default(bool);

	public void Initialize()
	{
	}

	public void OnFinalize()
	{
	}

	public void SetMessageDatas(GMSMasterData.SheetWindowMessage[] windowMessage)
	{
	}

	private void SetChoiceYesNoTexts()
	{
	}

	private void SetChoiceGMSModeTexts()
	{
	}

	private void SetChoiceTradeTexts()
	{
	}

	private void SetChoiceMarkedMonsDataTexts()
	{
	}

	private void SetChoiceMonsDataTexts()
	{
	}

	public void SetMsgSpeed(MSGSPEED msgSpeed)
	{
	}

	public void ShowMessage(MessageID messageID, bool canInputClose = false, [Optional] Action onFinishedMessage, [Optional] Action onClosedWindow, bool defaultPos = false)
	{
	}

	public void ShowAutoCloseMessage(MessageID messageID, float showMsgTime, Action onClosedWindow, bool defaultPos = false)
	{
	}

	private void OpenMsgWindow(Action onClosedWindow, bool defaultPos)
	{
	}

	private void SettingMsbtData(MessageID messageID)
	{
	}

	public void CloseMsgWindow()
	{
	}

	public void OpenYesNoMenu(Action<int> onChoiced, [Optional] Action onClosed)
	{
	}

	public void OpenChoiceModeSelectMenu(int initSelectIndex, Action<int> onChoiced, [Optional] Action onClosed)
	{
	}

	public void OpenChoiceTradeMenu(Action<int> onChoiced, [Optional] Action onClosed)
	{
	}

	public void OpenChoiceMonsDataMenu(Action<int> onChoiced, [Optional] Action onClosed)
	{
	}

	public void OpenChoiceMarkedMonsDataMenu(Action<int> onChoiced, [Optional] Action onClosed)
	{
	}

	private void OpenContextMenu(string[] menuLabels, int initSelectIndex, Action<int> onChoiced, Action onClosed, uint seDecide = 321217264u)
	{
	}

	private void OpenContextMenuFromMsgWindowManager(string[] textArray, int initSelectIndex, Action<int> onChoiced, Action onClosed)
	{
	}

	private void OpenContextMenuFromUIManager(Vector3 windowPos, string[] textArray, int initSelectIndex, Action<int> onChoiced, Action onClosed, uint seDecide = 321217264u)
	{
	}

	private void OnUpdate(float deltaTime)
	{
	}
}
