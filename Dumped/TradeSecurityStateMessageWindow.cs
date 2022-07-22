using System;
using System.Collections.Generic;
using Dpr.MsgWindow;

public class TradeSecurityStateMessageWindow
{
	private const int NET_WAITING_MESSAGE_INDEX = 0;

	private const int NET_ERORR_TRADE_MESSAGE_INDEX = 1;

	public MsgWindow msgWindow;

	private List<MsgWindowParam> messageParamList;

	private int messageIndex;

	private Action _Error;

	public void InitMessage()
	{
	}

	public void OpenMessageNetWaiting()
	{
	}

	public void OpenMessageNetErrorTrade()
	{
	}

	public void OpenMessage(int index, bool isShowIcon)
	{
	}

	public void CloseWindow()
	{
	}

	private MsgWindowParam CreateMsgWindowParam(string msgFileName, string labelName)
	{
		return null;
	}

	public MsgWindowParam GetCurrentMessageParam()
	{
		return null;
	}
}
