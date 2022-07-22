using System.Collections;
using Dpr.Contest;
using Dpr.EvScript;
using Dpr.NetworkUtils;
using INL1;
using UnityEngine;
using XLSXContent;

namespace Dpr.UI;

public class ContestMatching : UIWindow, IContestUIWindow
{
	public enum FinishPattern
	{
		Success,
		Cancel,
		Dissolution,
		LeavedMember,
		Error
	}

	private enum MatchingState
	{
		RecruitmentMember,
		SelectCategoryAndRank,
		Preparation,
		Resume,
		GoContest,
		Exit
	}

	[SerializeField]
	private ContestMatchingUI contestMatchingUI;

	[SerializeField]
	private UISelectorWindow selectorWindow;

	private ContestMatchingNetwork network;

	private ContestMatchingRecruitmentMember recruitmentMember;

	private ContestMatchingCategoryAndRank selectCategoryAndRank;

	private ContestMatchingPreparation preparation;

	private ContestMatchingResume resume;

	private ContestMasterDatas contMasterData;

	private ContestConfigDatas contConfigData;

	private MatchingState currentState;

	private EvWork.WORK_INDEX resultWorkIndex;

	private bool bIsSuccess;

	private bool bIsActive;

	private bool bIsLoadAssetBundle;

	public ContestMenuEventID ResultEventID => default(ContestMenuEventID);

	public bool IsOpen => default(bool);

	public override void OnCreate()
	{
	}

	public void Open(MatchingParam param, UIWindowID prevWindowId)
	{
	}

	public void OpenResume(int resultWkIndex, UIWindowID prevWindowId)
	{
	}

	private void ResetParam()
	{
	}

	private IEnumerator OpOpen(UIWindowID prevWindowId)
	{
		return null;
	}

	private void AppendContestMasterData()
	{
	}

	private void RequestLoadAssetBundle()
	{
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private void OnFinishRecruitmentMember()
	{
	}

	private void OnFinishSelectCategoryAndRank()
	{
	}

	private void SendNextStepDataToAll()
	{
	}

	private void OnRecievePacket(byte dataID, PacketReader pr)
	{
	}

	private void OnReceiveModelData(PacketReader pr)
	{
	}

	private void OnReceiveCountDownData(PacketReader pr)
	{
	}

	private void OnReceiveSkillPointData(PacketReader pr)
	{
	}

	private void OnReceiveChoiceData(PacketReader pr)
	{
	}

	private void OnReceiveCategoryAndRankData(PacketReader pr)
	{
	}

	private void OnReceiveEntryNPCData(PacketReader pr)
	{
	}

	private void OnReceiveEntryPlayerData(PacketReader pr)
	{
	}

	private void OnReceiveContestInfoData(PacketReader pr)
	{
	}

	private void OnReceiveReadyData(PacketReader pr)
	{
	}

	private bool CheckCanReceiveNoticeData(MultiContestStepID stepID)
	{
		return default(bool);
	}

	private void OnSessionEvent(SessionEventData result)
	{
	}

	private void OnJoinMine(int stationIndex)
	{
	}

	private void OnJoinOtherPlayer(int stationIndex)
	{
	}

	private void OnLeaveMine()
	{
	}

	private void OnLeaveOtherPlayer(int stationIndex)
	{
	}

	private void OnChangeHostMine()
	{
	}

	private void OnChangeHostOtherPlayer(int stationIndex)
	{
	}

	private void OnSessionError()
	{
	}

	private void OnMatchingResult(FinishPattern pattern)
	{
	}

	private void ResultReuccess()
	{
	}

	private void ResultCancel()
	{
	}

	private void ResultDissolution()
	{
	}

	private void ResultLeaveMember()
	{
	}

	private bool CanOpenErrorDialog()
	{
		return default(bool);
	}

	private void StopMatchingProcess()
	{
	}

	private void UpdateExit()
	{
	}

	private void OnFinishSession()
	{
	}

	public void CloseWindow()
	{
	}

	private IEnumerator OpClose()
	{
		return null;
	}

	private void UnloadResources()
	{
	}

	public void ResetContestParam()
	{
	}

	public void SetTimeCount(string minutStr, string secondStr)
	{
	}
}
