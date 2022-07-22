using System.Collections;
using DPData;
using UnityEngine;

namespace Dpr.MsgWindow;

public class MsgWindow : MonoBehaviour
{
	[SerializeField]
	private bool autoResize;

	[SerializeField]
	private MsgWindowConfig config;

	private WindowMessage windowMessage;

	private WindowUIContents uiContents;

	private WindowAnimator windowAnimator;

	private MsgWindowDataModel dataModel;

	private MsgWindowSoundPlayer soundPlayer;

	private MsgWindowInput wndInput;

	private RectTransform contextMenuRect;

	private WaitTimer waitAutoTimer;

	private bool bInitialize;

	private bool bIsAutoMessage;

	public bool IsOpen => default(bool);

	public MsgWindowDataModel.MsgWindowState MsgState => default(MsgWindowDataModel.MsgWindowState);

	public bool IsEnabledInput => default(bool);

	public bool IsEnabledCloseSelf => default(bool);

	public int SortingOrder => default(int);

	public bool IsNetwork => default(bool);

	public bool IsAuto => default(bool);

	private void Start()
	{
	}

	public void Initialize()
	{
	}

	private IEnumerator IE_Initialize()
	{
		return null;
	}

	private void SetComponents()
	{
	}

	public void OnFinalize()
	{
	}

	public Vector2 CalcContextMenuPos()
	{
		return default(Vector2);
	}

	public void SetInputEnable(bool enabled)
	{
	}

	private void ChangeWndType(WINTYPE wndType)
	{
	}

	private void ChangeMsgSpeed(MSGSPEED msgSpeed)
	{
	}

	public void HideKeywaitIcon()
	{
	}

	public void OpenWindow(MsgWindowParam msgWindowParam)
	{
	}

	private void NormalMsgDataSetting(MsgWindowParam msgWindowParam)
	{
	}

	private void NormalLayoutSetting()
	{
	}

	public void ReplaceMessage(MsgWindowParam msgWindowParam)
	{
	}

	public void OpenBoardWindow(MsgWindowParam msgWindowParam, int roadsignPattern)
	{
	}

	private void BoardMsgDataSetting(MsgWindowParam msgWindowParam)
	{
	}

	private void BoardLayoutSetting(int roadsignPattern)
	{
	}

	public void OpenItemGetWindow(MsgWindowParam msgWindowParam)
	{
	}

	private void ItemGetMsgDataSetting(MsgWindowParam msgWindowParam)
	{
	}

	private void ItemGetWindowLayoutSetting()
	{
	}

	public void OpenBtlMsgWindow(MsgWindowParam btlMsgWindowParam)
	{
	}

	private void BtlMsgLayoutSetting()
	{
	}

	public void ReplaceBtlMessage(MsgWindowParam btlMsgWindowParam)
	{
	}

	private bool CanOpenMsgWindow(MsgWindowParam msgWindowParam)
	{
		return default(bool);
	}

	private void SetMsgWindowParam()
	{
	}

	private void SetupWindowLayout()
	{
	}

	private void ChangeFontAsset()
	{
	}

	private void SetMessageLineData()
	{
	}

	private void DoAutoResize()
	{
	}

	private void StartOpenAnimation()
	{
	}

	public void DoOnCloseCallback()
	{
	}

	public void CloseWindow()
	{
	}

	public void MoveNextPage()
	{
	}

	public void OnUpdate(float deltaTime)
	{
	}

	private void UpdateMsgWindow(float deltaTime)
	{
	}

	private void UpdateStatePlayingOpen(float deltaTime)
	{
	}

	private void UpdateStateFinishedOpen(float deltaTime)
	{
	}

	private void UpdateStatePlayingMessage(float deltaTime)
	{
	}

	private void CheckPlayMsgSpeedUp()
	{
	}

	private void UpdateStateEnterkeywait()
	{
	}

	private void UpdateStateKeywait(float deltaTime)
	{
	}

	private void DoNextPage()
	{
	}

	private void UpdateStateWaitFinishMessage(float deltaTime)
	{
	}

	private void UpdateStateFinishedMessage(float deltaTime)
	{
	}

	private void UpdateStatePlayingClose(float deltaTime)
	{
	}

	private void OnFoundCallbackOneTag(float value)
	{
	}

	private void OnChangedConfig(ConfigID configID, int value)
	{
	}

	private void SetActive(bool active)
	{
	}

	public void EnableAutoMode(MSGSPEED msgSpeed, float waitTime = 0f)
	{
	}

	public void DisableAutoMode()
	{
	}

	private bool UpdateAutoMessageWait(float deltaTime)
	{
		return default(bool);
	}
}
