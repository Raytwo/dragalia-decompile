using System;
using System.Runtime.InteropServices;
using DPData;
using Dpr.Message;
using Dpr.MsgWindow;
using UnityEngine;

namespace Dpr.SubContents;

public class ShowMessageWindow
{
	public enum ShowMode
	{
		AutoClose,
		InputClose,
		WaitClosed
	}

	private MessageMsgFile msgFile;

	private MsgWindowInput input;

	private MsgWindowParam msgWindowParam;

	private Dpr.MsgWindow.MsgWindow msgWindow;

	private Vector2? wndAnchorPos;

	private Action onClosedWindow;

	private ShowMode currentMode;

	private MSGSPEED msgSpeed;

	private float showDuration;

	private float timer;

	private bool isNetworkMode;

	public bool IsOpen => default(bool);

	public MsgWindowParam MsgWindowParam => null;

	public MsgWindowDataModel.MsgWindowState MsgWindowState => default(MsgWindowDataModel.MsgWindowState);

	public void Setup(string msbtName, MSGSPEED msgSpeed, bool isNetwork = false)
	{
	}

	public void Setup(string msbtName, bool batchDisplayFlag, bool isNetwork = false)
	{
	}

	private void Initialize(string msbtName)
	{
	}

	public void OnFinalize()
	{
	}

	public void ChangeMSBTFile(string newMsbtName)
	{
	}

	public void SetWndAnchorPos(Vector2? anchorPos)
	{
	}

	public void SetMsgSpeed(MSGSPEED msgSpeed)
	{
	}

	public void SetBatchDisplayFlag(bool flag)
	{
	}

	public void SetNetworkMode(bool isNetwork)
	{
	}

	public void ShowMessage(string labelName, [Optional] Action onFinishMessage, bool isShowloadingIcon = false, bool inputEnabled = false)
	{
	}

	public void ShowAutoCloseMessage(string labelName, float showDuration, [Optional] Action onFinishMessage, [Optional] Action onClosedWindow)
	{
	}

	public void ShowInputCloseMessage(string labelName, [Optional] Action onFinishMessage, [Optional] Action onClosedWindow)
	{
	}

	private void OpenMsgWindow(string labelName, bool inputEnabled, Action onFinishMessage, bool isShowloadingIcon = false)
	{
	}

	public void ShowInputCloseItemPocketMessage(string labelName, int itemNo, [Optional] Action onFinishMessage, [Optional] Action onClosedWindow)
	{
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private void UpdateAutoClose(float deltaTime)
	{
	}

	private bool CheckTime(float deltaTime)
	{
		return default(bool);
	}

	private void UpdateInputClose()
	{
	}

	private void WaitCloseWindow()
	{
	}

	public void CloseMsgWindow()
	{
	}
}
