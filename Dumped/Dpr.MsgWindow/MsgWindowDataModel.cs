using System.Collections.Generic;
using DPData;
using Dpr.Message;
using TMPro;
using UnityEngine;

namespace Dpr.MsgWindow;

public class MsgWindowDataModel
{
	public enum MsgWindowState
	{
		Inactive,
		PlayingOpen,
		FinishedOpen,
		PlayingMessage,
		EnterKeywait,
		Keywait,
		WaitFinishMessage,
		FinishedShowMessage,
		PlayingClose
	}

	public enum WindowFrameType
	{
		Frame_Brown,
		Frame_Green,
		Frame_Gray,
		Frame_Blue,
		Num,
		Default
	}

	private const int SPEAKR_NAME_CHAR_NUM = 10;

	private const string USER_LABEL = "HERO";

	private const string RIVAL_LABEL = "RIVAL";

	private const string RIVAL_MOTHER_LABEL = "RIVALMAMA";

	private const string ORIGINAL_NAME_LABEL = "ORIGINAL";

	private MsgWindowParam currentMsgParam;

	private MessageTextParseDataModel currentMessageDataModel;

	private Dictionary<int, RoadsignViewData> roadsignViewDataTable;

	private Dictionary<int, string> speakerNameTable;

	private float[] msgSpeedArray;

	private TMP_FontAsset useFontAsset;

	private MsgWindowState msgState;

	private WaitTimer waitTimer;

	private string speakerName;

	private float showOneFontTimeSec;

	private float defaultShowOneFontTimeSec;

	private float fontSize;

	private bool inputEnabled;

	public bool IsOpen => default(bool);

	public MsgWindowState MsgState => default(MsgWindowState);

	public bool InputEnabled => default(bool);

	public bool IsShowLastKeywaitIcon => default(bool);

	public bool IsShowLoadingIcon => default(bool);

	public bool CanInputClose => default(bool);

	public string LabelName => null;

	public string SpeakerName => null;

	public MessageTextParseDataModel MessageData => null;

	public float ShowOneFontTimeSec => default(float);

	public bool IsUnknownMessage => default(bool);

	public bool HasBattleOnelineTag => default(bool);

	public bool IsNetwork => default(bool);

	public Vector2? WndAnchorPosition => null;

	public int TextWidth => default(int);

	public float FrameWidth => default(float);

	public int SortingOrder => default(int);

	public float SpeakerFrameWidth => default(float);

	public float SpeakerNameFontSize => default(float);

	public float FontSize => default(float);

	public float FontScale => default(float);

	public Color FontColor => default(Color);

	public Color NetworkFonrColor => default(Color);

	public TMP_FontAsset FontAsset
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public void Initialize(float[] msgSpeedArray, int waitFinishFrame, MsgWindowDataContainer dataContainer)
	{
	}

	public void OnFinalize()
	{
	}

	public void Clear()
	{
	}

	public void ChangeMsgState(MsgWindowState nextState)
	{
	}

	public void ChangeMsgSpeed(MSGSPEED msgSpeed)
	{
	}

	public void SetInputEnabled(bool enabled)
	{
	}

	public bool HasSpeakerName()
	{
		return default(bool);
	}

	public void ClearSpeakerName()
	{
	}

	public void FormatTextData()
	{
	}

	public void FormatItemGetTextData()
	{
	}

	private void SetPocketIconData()
	{
	}

	public void SetBtlMsgWindowParam(MsgWindowParam btlMsgWindowParam)
	{
	}

	public void ResetParam()
	{
	}

	public void SetMsgWindowParam(MsgWindowParam msgWindowParam)
	{
	}

	public void SetBoardMsgWindowParam(MsgWindowParam msgWindowParam)
	{
	}

	private void SetWindowParameters()
	{
	}

	private string CreateSpeakerName()
	{
		return null;
	}

	private void SetWindowDataFromMessageData()
	{
	}

	public void OnStartOpen()
	{
	}

	public void OnFinishedOpen()
	{
	}

	public void OnFinishedMessage()
	{
	}

	public void CheckWaitFinishTime(float deltaTime)
	{
	}

	public void OnClose()
	{
	}

	public void OnFinishedClose()
	{
	}

	public void CallFinishedCallback()
	{
	}

	public void OnAfterInput()
	{
	}

	public bool CheckShowRoadsignByPattern(int pattern)
	{
		return default(bool);
	}

	public RoadsignViewData GetRoadsignViewDataByPattern(int pattern)
	{
		return null;
	}
}
