using System;
using System.Runtime.InteropServices;
using Dpr.Message;
using Dpr.MsgWindow;
using Dpr.NetworkUtils;
using Dpr.SubContents;
using Dpr.Trainer;
using UnityEngine;

namespace Dpr.UI;

public class ContestMatchingUI : MonoBehaviour
{
	private const string WAIT_ICON_TEX_NAME = "cmn_net_pl_wait_02";

	private const string READY_ICON_TEX_NAME = "cmn_net_pl_wait_01";

	private const string SEARCH_PLAYER_LABEL = "DP_contest_602";

	private const string EMPTY_PLAYER_LABEL = "DP_contest_666";

	private const float SHOW_MSG_TIME = 2f;

	private const int START_UI_COUNTDOWN_COUNT = 10;

	private readonly string[] YESNO_CONTEXTMENU_LABELS;

	private readonly Vector2 MSG_WINDOW_ANCHOR_POS;

	[SerializeField]
	private UIContMatchingPlayerBoard[] _playerBoardArray;

	[SerializeField]
	private MultiModelView modelView;

	[SerializeField]
	private UIRemainingCountDown remainigCountDown;

	[SerializeField]
	private UIText countTimeText;

	[SerializeField]
	private GameObject timerObj;

	private CountDownTimer countTimer;

	private ShowMessageWindow msgWindow;

	private KeyGuideCreater _keyGuideCreator;

	private MessageMsgFile msgFile;

	private MsgWindowManager msgWindowManager;

	private Transform keyguideParent;

	public int GetNowViewModelCount => default(int);

	public int CountTime => default(int);

	public bool IsFinishCountDown => default(bool);

	public void Initialize()
	{
	}

	private Sprite GetSprite(string texName)
	{
		return null;
	}

	public void OnFinalize()
	{
	}

	public bool HasViewModelByIndex(int index)
	{
		return default(bool);
	}

	public void ShowKeyGuide(SubContentsPatternID patternID)
	{
	}

	public void CloseKeyGuide(Action onClosed)
	{
	}

	public void OnJoinMine(int playerIndex)
	{
	}

	public void OnLeavePlayer(int index)
	{
	}

	public void OnExitPlayer(int index)
	{
	}

	public void LoadCharacterModel(int index, TrainerType trainerType, int colorID, string modelPath, Action<GameObject> onComplete)
	{
	}

	public void DestroyAllCahracterModel()
	{
	}

	public void DestroyCharacterModel(int index)
	{
	}

	public void ChangeAllModelMotion(int motionIndex)
	{
	}

	public void ChangeModelMotion(int index, int motionIndex)
	{
	}

	public void ResetAllPlayerName()
	{
	}

	public void SetPlayerName(int index, string name)
	{
	}

	public void SetPlayerName(int index, string name, MessageEnumData.MsgLangId langId)
	{
	}

	public void SetEmptyPlayerName(int index)
	{
	}

	public void ShowPreparatioIconReady(int index)
	{
	}

	public void ShowPreparatioIconWait(int index)
	{
	}

	public void HidePreparatioIcon(int index)
	{
	}

	public void ResetPreparatioIcon()
	{
	}

	public string GetCountDownMinutStr()
	{
		return null;
	}

	public string GetCountDownSecondStr()
	{
		return null;
	}

	public void StartCountDown(float startTime)
	{
	}

	public bool UpdateCountDown(float startTime)
	{
		return default(bool);
	}

	public void SetCountDownTime(int timeCount)
	{
	}

	private void CheckShowUICountDown()
	{
	}

	private void UpdateUITimeText()
	{
	}

	public void ShowCountDownTimer()
	{
	}

	public void HideCountDownTimer()
	{
	}

	private void SetTimerActive(bool active)
	{
	}

	public void SetTimerObjActive(bool active)
	{
	}

	public bool IsWindowOpen()
	{
		return default(bool);
	}

	public MsgWindowDataModel.MsgWindowState GetMsgState()
	{
		return default(MsgWindowDataModel.MsgWindowState);
	}

	public void ShowMessageWindow(string label, [Optional] Action onFinishMessage, bool isShowloadingIcon = false)
	{
	}

	public void ShowMsgWindowAndContextMenu(string label, string[] contextLabels, [Optional] Action<int> onSelect)
	{
	}

	public void ShowConfirmYesNoMsg(string message, [Optional] Action onSelectYes, [Optional] Action onSelectNo)
	{
	}

	public void ShowConfirmLeaveSessionMsg([Optional] Action onSelectYes, [Optional] Action onSelectNo)
	{
	}

	public void ShowAutoCloseMessageWindow(string label, [Optional] Action onClosed)
	{
	}

	public void ShowInputCloseMessageWindow(string label, [Optional] Action onCloseed)
	{
	}

	public void CloseMessageWindow()
	{
	}

	public void OpenContextMenu(string[] contextLabels, Action<int> onSelect)
	{
	}

	public void CloseContextMenu()
	{
	}
}
