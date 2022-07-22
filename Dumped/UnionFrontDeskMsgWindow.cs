using System;
using System.Collections.Generic;

public class UnionFrontDeskMsgWindow : UnionBaseMsgWindow
{
	private const int MESSAGE_INDEX_FRONTDESK = 1;

	private const int MESSAGE_INDEX_NOT_FRONTDESK = 3;

	private bool isFrontDesk;

	public Action _trasitionFunc;

	public Action<bool> _talkEnd;

	public Action _talkStart;

	public void SetFrontDesk(bool flag)
	{
	}

	public void SetMessage(string msgFileName, string[] messageList)
	{
	}

	public void SetMessage(List<UnionTextData.MsgStringParamData> msgStringParamDataList)
	{
	}

	public void ClearMessage()
	{
	}

	public void SetMessageTalkStart()
	{
	}

	public void SetMessageTalkStartColiseum()
	{
	}

	private void SetOhanasiMessage()
	{
	}

	private void SetDescriptionMessage()
	{
	}

	private void SetDescriptionMessageGlobal()
	{
	}

	public void SetTradeMessage()
	{
	}

	public void SetMessageShowIcon(int index, bool isShowIcon)
	{
	}

	public void OpenMsgChangeInternetMode(int index)
	{
	}

	public void OpenMsgInternetCheck(int index)
	{
	}

	public void OpenMessageStartInternetCheck()
	{
	}

	public void OpenMessageStartInternet()
	{
	}

	private void OpenMessageTransitionComm()
	{
	}

	private void SwitchOpenTransitionCommMessage()
	{
	}

	public void OpenMessageStartDescription()
	{
	}

	public void OpenMessageDescription(int index, bool isGlobal)
	{
	}

	public void OpenMessageOhanasi(bool isGlobal)
	{
	}

	public void OpenTradePaneltyMessage()
	{
	}

	public void ReturnStartMenu()
	{
	}

	public void OpenMessageDescriptionColiseum(int index)
	{
	}

	private void SetDescriptionMessageColiseum()
	{
	}

	public void OpenTalkEndMessageColiseum()
	{
	}

	public void OpenTalkNotChangeRuleMessage()
	{
	}

	public void OpenBattleRuleSelectMessage()
	{
	}

	public void OpenMsgChangeRuleCheck()
	{
	}

	public void TalkEnd()
	{
	}

	public void SetStartMessageNo(int startIndex)
	{
	}
}
