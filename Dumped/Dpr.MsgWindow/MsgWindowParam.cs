using System;
using DPData;
using Dpr.Message;
using UnityEngine;

namespace Dpr.MsgWindow;

public class MsgWindowParam
{
	public string labelName;

	public int labelIndex;

	public MessageMsgFile useMsgFile;

	public MessageTextParseDataModel textDataModel;

	public bool bBatchDisplay;

	public int dataValue;

	public bool inputEnabled;

	public bool inputCloseEnabled;

	public bool playTextFeedSe;

	public MsgWindowDataModel.WindowFrameType frameTypeIndex;

	public Vector2? wndAnchorPos;

	public int sortingOrder;

	public MSGSPEED forceSetMsgSpeed;

	public string originalSpeakerName;

	public bool showLastKeywaitIcon;

	public bool isNetwork;

	public bool showLoadingIcon;

	public Action onFinishedOpenWindow;

	public Action onFinishedCloseWindow;

	public Action onFinishedShowAllMessage;

	public Action onAfterInput;

	public bool HasLabelName => default(bool);

	public MessageTextParseDataModel GetTextParseDataModel()
	{
		return null;
	}

	public string SDMessageGetLabelName()
	{
		return null;
	}

	public bool IsPlayTextFeedSe()
	{
		return default(bool);
	}
}
