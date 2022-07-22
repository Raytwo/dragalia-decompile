using System;
using System.Collections.Generic;
using Dpr.MsgWindow;

public class UnionBaseMsgWindow
{
	public enum TagIndexType
	{
		OTHER_NICKNAME_TAG_INDEX,
		BATTLE_NICKNAME_TAG_INDEX
	}

	protected List<MsgWindowParam> Messages;

	protected Dictionary<int, MsgWindowParam> DefMessages;

	protected MsgWindow _messageWindow;

	protected int nowMessageNo;

	protected MsgWindowParam openDefMessage;

	public int sexId;

	protected bool isMessageFinished => default(bool);

	protected MsgWindowParam nowMSG => null;

	protected bool isEnableInput => default(bool);

	public virtual void Init()
	{
	}

	public void ClearParam()
	{
	}

	public void SetTargetDataMessage(int targetStaitonIndex, int targetSexId, int setTagIndex)
	{
	}

	protected void SetDefMessages()
	{
	}

	public void SetGreetAfterMessage(int id)
	{
	}

	public void SetMessagesData(List<UnionTextData.MsgStringParamData> msgStringParamDatas, bool isNetMode = false, bool isLoadIcon = false)
	{
	}

	public void SetMessagesData(string msgFileName, string labelName, bool isNetMode = false, bool isLoadIcon = false)
	{
	}

	protected MsgWindowParam CreateMsgWindowParam(string msgFileName, string labelName, bool isNetMode = false, bool isLoadIcon = false)
	{
		return null;
	}

	public bool IsOpen()
	{
		return default(bool);
	}

	public void OpenMsgWindow(int index, UnionTextData.SpeakerID speakerID = UnionTextData.SpeakerID.SYSTEM)
	{
	}

	public void CloseWindow()
	{
	}

	public MsgWindowParam GetNowMessage()
	{
		return null;
	}

	public int GetNowMessageNo()
	{
		return default(int);
	}

	public void SetOnCloseCallBack(Action closeEndFunc)
	{
	}

	public void SetOnFinishMsgCallBack(Action finishFunc)
	{
	}

	protected string GetSpeakerName(UnionTextData.SpeakerID speakerID)
	{
		return null;
	}
}
