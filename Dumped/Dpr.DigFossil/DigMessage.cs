using System;
using Dpr.MsgWindow;

namespace Dpr.DigFossil;

public class DigMessage : IDigMessage
{
	public void ShowStartMessage(int depositNum, Action onFinishedShowAllMessage, Action onFinishedCloseWindow)
	{
	}

	public void ShowResultMessage(bool bIsDigOutAllItems, Action onFinishedShowAllMessage, Action onFinishedCloseWindow)
	{
	}

	public void ShowResultCommonItemMessage(int labelId, Action onFinishedShowAllMessage, Action onFinishedCloseWindow)
	{
	}

	public void ShowResultStoneBoxMessage(short boxId, Action onFinishedShowAllMessage, Action onFinishedCloseWindow)
	{
	}

	public void ShowStoneBoxOpenMessage(Action onFinishedShowAllMessage, Action onFinishedCloseWindow)
	{
	}

	public void ShowStatueGetMessage(int labelId, Action onFinishedShowAllMessage, Action onFinishedCloseWindow)
	{
	}

	public void ShowItemMaxMessage(Action onFinishedShowAllMessage, Action onFinishedCloseWindow)
	{
	}

	public void ShowUgItemMaxMessage(Action onFinishedShowAllMessage, Action onFinishedCloseWindow)
	{
	}

	public void Close()
	{
	}

	private MsgWindowParam CreateParam(string labelName, Action onFinishedShowAllMessage, Action onFinishedCloseWindow)
	{
		return null;
	}
}
