using System;
using Dpr.MsgWindow;

namespace Dpr.UnderGround.UgFather;

public static class UgFatherMessage
{
	public static void ShowHealingChoices(Action onFinishedShowAllMessage, Action onFinishedCloseWindow)
	{
	}

	public static void ShowHealingBegin(Action onFinishedShowAllMessage, Action onFinishedCloseWindow)
	{
	}

	public static void ShowHealingEnd(Action onFinishedShowAllMessage, Action onFinishedCloseWindow)
	{
	}

	public static void Close()
	{
	}

	private static MsgWindowParam CreateParam(string labelName, Action onFinishedShowAllMessage, Action onFinishedCloseWindow)
	{
		return null;
	}
}
