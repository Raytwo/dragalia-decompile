using System;
using Dpr.Contest;
using Dpr.NetworkUtils;

namespace Dpr.UI;

public class ContestMatchingRecruitmentMember
{
	private enum RecruitmentState
	{
		WaitJoinMember,
		WaitAllReady,
		WaitSkip,
		Retry,
		Finish
	}

	private class JoinPlayerData
	{
		public string playerName;

		public int cassetVersion;

		public ushort fashion;

		public bool isDpClear;

		public void Clear()
		{
		}
	}

	private JoinPlayerData[] joinPlayerDataArray;

	private ContestMatchingUI contestMatchingUIPtr;

	private ContestMatchingNetwork networkPtr;

	private UIInputController inputController;

	private NetworkManager networkManager;

	private Action onFinishState;

	private Action<ContestMatching.FinishPattern> onFinish;

	private RecruitmentState currentState;

	private int loadCount;

	private bool bLockPlayerAction;

	private bool bIsOpenConfirmMsg;

	private bool bIsActive;

	public void Initialize(ContestMatchingUI contestMatchingUI, ContestMatchingNetwork network, Action onFinishState, Action<ContestMatching.FinishPattern> onFinishMatching)
	{
	}

	public void OnFinalize()
	{
	}

	private void Reset()
	{
	}

	public void StartProcess(int stationIndex, float startCountDown)
	{
	}

	private void CheckModelLoadCompleted()
	{
	}

	public void OnUpdate(float deltaTime)
	{
	}

	private void UpdateWaitJoinMember(float deltaTime)
	{
	}

	private void UpdateWaitSkip()
	{
	}

	private void UpdateWaitAllReady()
	{
	}

	private void FixSessionPlayerUIInfo()
	{
	}

	private bool CheckMemberReady()
	{
		return default(bool);
	}

	private void FinishRecruitmentMember()
	{
	}

	private void CheckMemberActive()
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

	private void HideMatchingUI()
	{
	}

	private void SetSkipFlag(int stationIndex, bool flag)
	{
	}

	private void ChangeState_WaitAllReady()
	{
	}

	public void OnJoinOtherPlayer(int stationIndex)
	{
	}

	public void OnLeaveMine()
	{
	}

	public void OnLeaveOtherPlayer(int stationIndex)
	{
	}

	public void OnChangeHostMine()
	{
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

	public void OnReceivePlayerData(NetPlayerInfo playerInfo)
	{
	}

	public void OnReceiveReadyData(int stationIndex, NoticeID noticeID)
	{
	}
}
