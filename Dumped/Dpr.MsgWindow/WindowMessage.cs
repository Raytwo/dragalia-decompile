using System;
using Dpr.Message;
using TMPro;
using UnityEngine;

namespace Dpr.MsgWindow;

public sealed class WindowMessage : MonoBehaviour
{
	public enum MsgState
	{
		Wait,
		Playing,
		KeyWait,
		TextScroll,
		End
	}

	[SerializeField]
	private MsgTextContainer textContainer;

	private MessageTextLineDataModel[] textLineDataArray;

	private MessageTextLineDataModel currentLineData;

	private MessageEnumData.MsgEventID currentMsgEventId;

	private WaitTimer waitTimer;

	private MsgState currentMsgState;

	private float playLineMsgTime;

	private float showMsgTime;

	private float fastForwardMagnification;

	private int lineDataIndex;

	private int useTextIndex;

	private int currentLineStrNum;

	private bool isChangeTextColor;

	private bool playSpeedUpFlag;

	private Action<float> onMsgCallBack;

	private Action onFinishedShowOneLine;

	public MsgState CurrentMsgState => default(MsgState);

	public void Initialize(MsgWindowConfig config, Action<float> onMsgCallBack)
	{
	}

	public void ResetMessage()
	{
	}

	public void Clear()
	{
	}

	public void ResetTextColor()
	{
	}

	public void OnFinalize()
	{
	}

	public void SetUseFontAsset(TMP_FontAsset useFontAsset)
	{
	}

	public void ChangeUnknownFont()
	{
	}

	public void SetPlayMsgTime(float playMsgTime)
	{
	}

	public void SetPlaySpeedUpFlag(bool flag)
	{
	}

	public void SetUseMessageLineDataArray(MessageTextLineDataModel[] textLineDataArray)
	{
	}

	private void SetCurrentLineData()
	{
	}

	public void SetTextColor(Color newColor)
	{
	}

	public void CheckTextResize(MessageTextParseDataModel currentMessageData, float fontScale, int windowWidth)
	{
	}

	private float CheckOverText(MessageTextParseDataModel currentMessageData, float fontScale, int windowWidth)
	{
		return default(float);
	}

	public void SetTextParam(float fontSize, float textWidth)
	{
	}

	public void SetFontSize(float fontSize)
	{
	}

	private bool IsRestMessageLine()
	{
		return default(bool);
	}

	private float GetEventValue()
	{
		return default(float);
	}

	public void StartPlayMessage()
	{
	}

	public void RestartMessage()
	{
	}

	public void UpdateMessage(float deltaTime)
	{
	}

	private bool CanUpdateMessage()
	{
		return default(bool);
	}

	private bool CheckWaitEvent(float deltaTime)
	{
		return default(bool);
	}

	private bool CheckWaitState(float deltaTime)
	{
		return default(bool);
	}

	private bool CheckTextScrollState(float deltaTime)
	{
		return default(bool);
	}

	private void UpdateTextView(float deltaTime)
	{
	}

	private float GetDeltaTime(float deltaTime)
	{
		return default(float);
	}

	private string SetLineMessage(int strIndex)
	{
		return null;
	}

	private void CheckLineEvent()
	{
	}

	private void MsgEventEnd()
	{
	}

	private void MsgEventWait()
	{
	}

	private void MsgEventCallBack()
	{
	}

	private void MsgEventNewLine()
	{
	}

	private void MsgEventScrollLine()
	{
	}

	private void MsgEventScrollPage()
	{
	}

	public void DoNextPage()
	{
	}

	private void DoNextLine()
	{
	}

	private void DoScrollPage()
	{
	}
}
