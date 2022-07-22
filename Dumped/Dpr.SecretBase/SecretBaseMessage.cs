using System;
using Dpr.MsgWindow;

namespace Dpr.SecretBase;

public static class SecretBaseMessage
{
	public static void ShowDontHaveStatue(Action onFinishedShowAllMessage, Action onFinishedCloseWindow)
	{
	}

	public static void ShowNothingStatueEffect(Action onFinishedShowAllMessage, Action onFinishedCloseWindow)
	{
	}

	public static void ShowSetThisSecretBase(Action onFinishedShowAllMessage, Action onFinishedCloseWindow)
	{
	}

	public static void ShowUnsetThisSecretBase(Action onFinishedShowAllMessage, Action onFinishedCloseWindow)
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
