using System;
using System.Collections;
using System.Runtime.InteropServices;
using Dpr.UI;
using SmartPoint.AssetAssistant;
using UnityEngine;
using XLSXContent;

namespace Dpr.MsgWindow;

public class MsgWindowManager : SingletonMonoBehaviour<MsgWindowManager>
{
	private MsgWindowDataContainer dataContainer;

	private MsgWindowData msgWindowData;

	private ContextMenuWindow contextMenu;

	[SerializeField]
	private GameObject msgWindowObj;

	private MsgWindow msgWindow;

	private const string YES_NO_MSBT_NAME = "ss_box";

	private readonly string[] YES_NO_LABEL_ARRAY;

	public MsgWindowDataContainer DataContainer => null;

	public MsgWindow MsgWindow => null;

	public static bool IsOpenWindow => default(bool);

	public static bool IsOpen => default(bool);

	private void Start()
	{
	}

	private IEnumerator IE_StartMsgWindow()
	{
		return null;
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private void Destroy()
	{
	}

	public static void SetMsgWindowData(MsgWindowData msgWindowData)
	{
	}

	public static MsgWindow OpenMsg(MsgWindowParam msgWindowParam)
	{
		return null;
	}

	public static MsgWindow OpenBoardMsg(MsgWindowParam msgWindowParam, int roadsignPattern = 0)
	{
		return null;
	}

	public static MsgWindow OpenItemGetMsg(MsgWindowParam msgWindowParam)
	{
		return null;
	}

	public static MsgWindow OpenBtlMsg(MsgWindowParam msgWindowParam)
	{
		return null;
	}

	public static void CloseMsg()
	{
	}

	public static void ReplaceMsg(MsgWindowParam msgWindowParam)
	{
	}

	public static void ReplaceBtlMsg(MsgWindowParam msgWindowParam)
	{
	}

	public static void MoveNextPage()
	{
	}

	public static void OpenYesNoMenu(Action<int> onSelectChoices, ContextMenuWindow.CursorType cursorType = ContextMenuWindow.CursorType.Arrow, bool useCancel = true, bool initSelectYes = true, [Optional] Action onClosed, uint seDecide = 1570109472u)
	{
	}

	public void OpenContextMenu_YESNO(Action<int> onSelectChoices, ContextMenuWindow.CursorType cursorType, bool selectYes, bool useCancel, Action onClosed, uint seDecide = 1570109472u)
	{
	}

	public static void OpenCustomMenu(string msbtName, string[] labelNameArray, Action<int> onSelectChoices, ContextMenuWindow.CursorType cursorType = ContextMenuWindow.CursorType.Arrow, bool useCancel = true, int initSelectIndex = 0, [Optional] Action onClosed, uint seDecide = 1570109472u)
	{
	}

	public void OpenContextMenu_Custom(string msbtName, string[] labelNameArray, Action<int> onSelectChoices, ContextMenuWindow.CursorType cursorType, bool useCancel, int initSelectIndex, Action onClosed, uint seDecide = 1570109472u)
	{
	}

	public static void OpenCustomMenu(string[] textArray, Action<int> onSelectChoices, ContextMenuWindow.CursorType cursorType = ContextMenuWindow.CursorType.Arrow, bool useCancel = true, int initSelectIndex = 0, [Optional] Action onClosed, uint seDecide = 1570109472u)
	{
	}

	public void OpenContextMenu_Custom(string[] textArray, Action<int> onSelectChoices, ContextMenuWindow.CursorType cursorType, bool useCancel, int initSelectIndex, Action onCloseed, uint seDecide = 1570109472u)
	{
	}

	public void CloseContextMenu()
	{
	}

	private ContextMenuWindow.Param CreateContextMenuParam(string msbtName, string[] labelNameArray, int initSelectIndex, ContextMenuWindow.CursorType cursorType, bool useCancel, uint seDecide)
	{
		return null;
	}

	private ContextMenuWindow.Param CreateContextMenuParam(string[] textArray, int initSelectIndex, ContextMenuWindow.CursorType cursorType, bool useCancel, uint seDecide)
	{
		return null;
	}

	private void OpenContextMenu(ContextMenuWindow.Param menuParam, Action<int> onSelectChoices, Action onClosed)
	{
	}
}
