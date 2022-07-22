using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Dpr.MsgWindow;
using UnityEngine;
using UnityEngine.Events;

namespace Dpr.UI;

public class UIMsgWindowController
{
	public enum MessageFileType
	{
		Bag,
		LevelUp,
		Seal,
		WazaRemember,
		Zukan,
		MysteryGift,
		Evolve
	}

	private Dpr.MsgWindow.MsgWindow msgWindow;

	private Action onCloseMsgWindow;

	private Action onFinishedContinueMessage;

	private bool isWaitMsgWindow;

	private Vector2? windowAnchorPosition;

	private MsgWindowParam msgWindowParam;

	private List<string> continueMessageLabels;

	private List<Action> continueMessageOnSets;

	public bool isOpen => default(bool);

	public static string GetMessageFileName(MessageFileType messageFileType)
	{
		return null;
	}

	public void OpenMsgWindow(MessageFileType messageFileType, string labelName, bool isWait = true, bool isBatchDisplay = false, [Optional] Action onFinishedMessage, [Optional] Action onCloseWindow)
	{
	}

	public void OpenMsgWindow(string messageFileName, string labelName, bool isWait = true, bool isBatchDisplay = false, [Optional] Action onFinishedMessage, [Optional] Action onCloseWindow)
	{
	}

	public void OpenMsgWindow(MessageFileType messageFileType, string[] labelNames, [Optional] Action[] onSets, bool isWait = true, bool isBatchDisplay = false, [Optional] Action onFinishedMessage, [Optional] Action onCloseWindow)
	{
	}

	public void OpenMsgWindow(string messageFileName, string[] labelNames, [Optional] Action[] onSets, bool isWait = true, bool isBatchDisplay = false, [Optional] Action onFinishedMessage, [Optional] Action onCloseWindow)
	{
	}

	public void CloseMsgWindow()
	{
	}

	public void HideKeywaitIcon()
	{
	}

	public void SetAnchorPosition(Vector2? pos)
	{
	}

	public ContextMenuWindow.Param CreateContextMenuParam(MessageFileType messageFileType, string[] labelNames)
	{
		return null;
	}

	public ContextMenuWindow.Param CreateContextMenuParam(string messageFileName, string[] labelNames)
	{
		return null;
	}

	public void OpenContextMenu(ContextMenuWindow.Param param, Action<int> onSelect, [Optional] UnityAction<UIWindow> onClosed)
	{
	}

	public bool OnUpdate(float deltaTime)
	{
		return default(bool);
	}

	private bool NextOpenMsgWindow()
	{
		return default(bool);
	}
}
