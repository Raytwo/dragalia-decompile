using System;
using System.Collections.Generic;
using Dpr.MsgWindow;

public class UnionMsgSystemWindow : UnionBaseMsgWindow
{
	public enum SystemBattleMessageType
	{
		CHECK_NICKNAME,
		INTERNET,
		NONE
	}

	public enum MessageStateTalkBattle
	{
		TALK_RANDOM_BOY01,
		TALK_RANDOM_BOY02,
		TALK_RANDOM_BOY03,
		TALK_RANDOM_BOY04,
		TALK_RANDOM_GIRL01,
		TALK_RANDOM_GIRL02,
		TALK_RANDOM_GIRL03,
		TALK_RANDOM_GIRL04
	}

	public enum MessageStateTalkTrade
	{
		TALK_RANDOM_BOY01,
		TALK_RANDOM_BOY02,
		TALK_RANDOM_GIRL01,
		TALK_RANDOM_GIRL02
	}

	public enum MessageStateTalkRecode
	{
		TALK_RANDOM_BOY01,
		TALK_RANDOM_BOY02,
		TALK_RANDOM_BOY03,
		TALK_RANDOM_BOY04,
		TALK_RANDOM_GIRL01,
		TALK_RANDOM_GIRL02,
		TALK_RANDOM_GIRL03,
		TALK_RANDOM_GIRL04
	}

	public enum MessageStateGreeting
	{
		TALK_RANDOM_BOY01,
		TALK_RANDOM_BOY02,
		TALK_RANDOM_GIRL01,
		TALK_RANDOM_GIRL02
	}

	public enum MessageStateBallDeco
	{
		TALK_RANDOM_BOY01,
		TALK_RANDOM_GIRL01
	}

	public OpcState.OnlineState playerOnlineState;

	public int stationIndex;

	public bool isRecruiment;

	public Action<OpcState.OnlineState> _setOpcState;

	public Action<OpcState.OnlineState, NetStateModel.StateModelType> _createModel;

	public Action<int, OpcState.OnlineState, bool> _startCommunication;

	public void SetOnlineState(OpcState.OnlineState state)
	{
	}

	public void SetStationIndex(int index)
	{
	}

	public void SetIsRecruiment(bool flag)
	{
	}

	public void OpenGreetingMsgWindow(int index)
	{
	}

	public void SetMessage(string msgFileName, string[] messageList)
	{
	}

	public void SetMessage(List<UnionTextData.MsgStringParamData> msgStringParamDataList)
	{
	}

	public void SetMessageTalkBattle()
	{
	}

	public void SetMessageTalkTrade()
	{
	}

	public void SetMessageTalkRecode()
	{
	}

	public void SetMessageTalkGreeting()
	{
	}

	public void SetMessageTalkBallDeco()
	{
	}

	public void OpenMessageTalkBattle(int sexId)
	{
	}

	public void OpenMessageTalkTrade(int sexId)
	{
	}

	public void OpenMessageTalkRecode(int sexId)
	{
	}

	public void OpenMessageTalkGreeting(int sexId)
	{
	}

	public void OpenMessageTalkBallDeco(int sexId)
	{
	}

	public void ClearMessage()
	{
	}

	public void StateAction()
	{
	}

	public MsgWindowParam GetDefMassageParam()
	{
		return null;
	}

	public void SetAfterInputCallBack()
	{
	}

	public void SetCloseWindowCallBackChangeOpcState()
	{
	}

	public void OpenGreetAfterMeesage()
	{
	}

	public void StateCommunication()
	{
	}
}
