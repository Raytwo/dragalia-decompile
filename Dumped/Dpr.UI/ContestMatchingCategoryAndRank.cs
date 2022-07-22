using System;
using Dpr.Contest;
using Dpr.Message;
using XLSXContent;

namespace Dpr.UI;

public class ContestMatchingCategoryAndRank
{
	private enum SelectState
	{
		WaitLotteryCategoryAndRank,
		SelectCategoryAndRank,
		WaitAllPlayerReady,
		Finish
	}

	private readonly string[] contextMenuLabels;

	private CategoryID[] categoryIds;

	private RankID[] rankIds;

	private ContestMatchingUI contestMatchingUIPtr;

	private ContestMatchingNetwork networkPtr;

	private UISelectorWindow selectorWindowPtr;

	private ContestConfigDatas contConfigDataPtr;

	private MessageMsgFile msgFile;

	private UIInputController inputController;

	private Action onFinishState;

	private Action<ContestMatching.FinishPattern> onFinish;

	private SelectState currentState;

	private int[] receiveSkillPointArray;

	private int nowSelectPlayerIndex;

	private int transferPlayerIndex;

	private int initSelectPlayerIndex;

	private bool bLockPlayerAction;

	private bool bIsOpenConfirmMsg;

	private bool bIsSelectOwner;

	private bool bIsActive;

	private bool bIsAllMemberDpClear;

	private bool bIsAlreadySelected;

	public void Initialize(ContestMatchingUI contestMatchingUI, ContestMatchingNetwork network, Action onFinishState, Action<ContestMatching.FinishPattern> onFinishMatching)
	{
	}

	public void OnFinalize()
	{
	}

	private void Reset()
	{
	}

	public void StartProcess(UISelectorWindow selectorWindow, ContestConfigDatas contConfigData)
	{
	}

	public void OnUpdate(float deltaTime)
	{
	}

	private void UpdateWaitLotteryCategoryAndRank()
	{
	}

	private int GetReceiveCount()
	{
		return default(int);
	}

	private void UpdateSelectCategoryAndRank(float deltaTime)
	{
	}

	private void UpdateInput()
	{
	}

	private void OnSelectLeaveYes()
	{
	}

	private void OnSelectLeaveNo()
	{
	}

	private void StartSelectCategoryAndRank()
	{
	}

	private void OpenSelectorWindow()
	{
	}

	private void TransforNextPlayer(int nextStationIndex)
	{
	}

	private void OnItemEvent(UISelectorWindow.WindowItemID itemID)
	{
	}

	private void OnChangeCategory()
	{
	}

	private void OnPushDecideButton()
	{
	}

	private T GetWindowItem<T>(UISelectorWindow.WindowItemID itemID) where T : AWindowItem
	{
		return null;
	}

	public void OnReceiveChoice(ChoiceNetData choiceData)
	{
	}

	public void OnReceivePlayerSkillData(SkillPointNetData skillData)
	{
	}

	private bool CanReceivePlayerSkill(int stationIndex)
	{
		return default(bool);
	}

	private void LotCategoryAndRankBySkill()
	{
	}

	private int CalcTotalPlayerSkillPoint()
	{
		return default(int);
	}

	private RankID LotteryEntryRankBySkillPoint(float aveSkillPoint)
	{
		return default(RankID);
	}

	private void LotRandomCategoryAndRank()
	{
	}

	private string[] GetCanEntryCategoryName()
	{
		return null;
	}

	private string[] GetCanEntryRankName(CategoryID categoryID)
	{
		return null;
	}

	private void DecideCategoryAndRank()
	{
	}

	private void UpdateWaitAllPlayerReady(float deltaTime)
	{
	}

	private void UpdateFinish(float deltaTime)
	{
	}

	public void OnLeaveOtherPlayer(int stationIndex)
	{
	}

	public void OnChangeHostMine()
	{
	}

	private int GetSkillPoint(PlayerSkill skillID)
	{
		return default(int);
	}

	public void OnChangeHostOtherPlayer()
	{
	}

	public void Deactivate()
	{
	}

	public void OnReceiveCountDownData(CountDownNetData timeData)
	{
	}

	public void OnReceiveCategoryAndRank(CategoryAndRankNetData categoryAndRankData)
	{
	}

	public void OnReceiveReadyData(int stationIndex, NoticeID noticeID)
	{
	}

	private void SendDecideCategoryAndRank()
	{
	}
}
