using System;
using System.Collections;
using System.Runtime.InteropServices;
using Dpr.MsgWindow;
using Dpr.NetworkUtils;
using Dpr.SubContents;
using Dpr.Trainer;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class UIBattleMatching : UIWindow
{
	[SerializeField]
	private UIText _textTitle;

	[SerializeField]
	private UIBattleMatchingPlayer _player;

	[SerializeField]
	private UIBattleMatchingPlayer _playerVS;

	[SerializeField]
	private UIBattleMatchingRule _rule;

	[SerializeField]
	private UIBattleMatchingTimer _timer;

	[SerializeField]
	private GameObject _objResult;

	[SerializeField]
	private Image _imageResultA;

	[SerializeField]
	private Image _imageResultB;

	[SerializeField]
	private Image _imageResultDraw;

	[SerializeField]
	private Sprite _spriteResultWin;

	[SerializeField]
	private Sprite _spriteResultLose;

	[SerializeField]
	private GameObject _objLoading;

	[SerializeField]
	private GameObject _objVS;

	[SerializeField]
	private GameObject _objBgVS;

	[SerializeField]
	private MultiModelView _modelView;

	private ShowMessageWindow _msgWindow;

	private MsgWindowManager _msgWindowManager;

	private float _showMsgTime;

	private readonly string[] YESNO_CONTEXTMENU_LABELS;

	private readonly Vector2 MSG_WINDOW_ANCHOR_POS;

	public int GetNowViewModelCount => default(int);

	public void Initialize()
	{
	}

	public void Setup()
	{
	}

	public void OpenUnionRoom(UIWindowID prevWindowId = (UIWindowID)(-2))
	{
	}

	public void OpenColiseum(UIWindowID prevWindowId = (UIWindowID)(-2))
	{
	}

	public void OpenResume(UIWindowID prevWindowId = (UIWindowID)(-2))
	{
	}

	public IEnumerator OpOpen(UIWindowID prevWindowId)
	{
		return null;
	}

	public void Close()
	{
	}

	public IEnumerator OpClose()
	{
		return null;
	}

	public void SetKeyGuide(bool decide = true, bool back = true, bool cancel = false, bool complete = false)
	{
	}

	public void OpenKeyguide(bool decide = true, bool back = true, bool cancel = false)
	{
	}

	public void CloseKeyGuide()
	{
	}

	private void SetTitle(BattleModeID type)
	{
	}

	public void SetPlayer(BattleModeID type)
	{
	}

	public void SetPlayerVS(BattleModeID type)
	{
	}

	public void SetPlayerName(int index, string name, uint language)
	{
	}

	public void SetPlayerNameVS(int index, string name, uint language)
	{
	}

	public void OpenVSWait()
	{
	}

	public void CloseVSWait()
	{
	}

	public void ShowPreparationIconReady(int index)
	{
	}

	public void ShowPreparationIconWait(int index)
	{
	}

	public void HidePreparationIcon(int index)
	{
	}

	public void ResetPreparationIcon()
	{
	}

	public void OnJoinMine(int playerIndex)
	{
	}

	public void OnLeavePlayer(int index)
	{
	}

	public bool IsShowAllPlayerModel()
	{
		return default(bool);
	}

	public bool HasViewModelByIndex(int index)
	{
		return default(bool);
	}

	public void LoadCharacterModel(int index, Action<GameObject> onComplete)
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

	public void SetTimerMessage(string label)
	{
	}

	public void SetTimerMessage(string msbt, string label)
	{
	}

	public void SetActiveTimer(bool active)
	{
	}

	public void SetActiveRemainingText(bool active)
	{
	}

	public void RemainingWarningText(bool warning = true)
	{
	}

	public void UpdateUITimeText(string minutes, string seconds)
	{
	}

	public void OpenRuleWindow()
	{
	}

	public void CloseRuleWindow()
	{
	}

	public void OpenSelectRuleWindow()
	{
	}

	public void OnRuleMoveX(bool left)
	{
	}

	public void OnRuleMoveY(bool up)
	{
	}

	public bool OnRuleDecide()
	{
		return default(bool);
	}

	public void ShowVS(Action onEnd)
	{
	}

	private IEnumerator WaitVS(Action onEnd)
	{
		return null;
	}

	public void OpenResult()
	{
	}

	public void CloseResult()
	{
	}

	public bool IsWindowOpen()
	{
		return default(bool);
	}

	public void SetShowMsgTime(float time)
	{
	}

	public void ShowMessageWindow(string label, [Optional] Action onFinishMessage, bool isShowloadingIcon = false)
	{
	}

	public void ShowMsgWindowAndContextMenu(string label, string[] contextLabels, [Optional] Action<int> onSelect)
	{
	}

	public void ShowMsgWindowAndContextMenu_Custom(string label, string[] contextLabels, [Optional] Action<int> onSelect)
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

	public void ShowInputCloseMessageWindow(string label, [Optional] Action onClosed)
	{
	}

	public new void CloseMessageWindow()
	{
	}

	public void OpenContextMenu(string[] contextLabels, Action<int> onSelect)
	{
	}

	public void OpenContextMenu_Custom(string[] contextLabels, Action<int> onSelect)
	{
	}

	public void CloseContextMenu()
	{
	}
}
