using System;
using Dpr.Contest;
using XLSXContent;

namespace Dpr.UI;

public class ContestMatchingResume
{
	private enum ResumeState
	{
		LoadModel,
		CheckEntry,
		Ready,
		Finish
	}

	private ContestMatchingUI contestMatchingUIPtr;

	private ContestMatchingNetwork networkPtr;

	private ContestMasterDatas contMasterDataPtr;

	private UIInputController inputController;

	private UISelectorWindow selectorWindowPtr;

	private Action<ContestMatching.FinishPattern> onFinish;

	private ResumeState currentState;

	private int loadCount;

	private bool bIsActive;

	public void Initialize(ContestMatchingUI contestMatchingUI, ContestMatchingNetwork network, Action<ContestMatching.FinishPattern> onFinish)
	{
	}

	public void OnFinalize()
	{
	}

	private void Reset()
	{
	}

	public void StartProcess(int stationIndex, UISelectorWindow selectorWindow, ContestMasterDatas contestMasterDatas)
	{
	}

	private void OnFinishMessage()
	{
	}

	private bool CheckSameMember()
	{
		return default(bool);
	}

	private void LoadCharacterModel(int stationIndex, Action onComplete)
	{
	}

	public void OnUpdate(float deltaTime)
	{
	}

	private void UpdateCheckEntry()
	{
	}

	private void UpdateReady(float deltaTime)
	{
	}

	private void ChangeState(ResumeState newState)
	{
	}

	private void OnChangeState_CheckEntry()
	{
	}

	private void OnChangeState_Ready()
	{
	}

	private void OnChangeState_Finish()
	{
	}

	private void SetReadyFlag(int stationIndex, bool flag)
	{
	}

	public void OnLeaveOtherPlayer(int stationIndex)
	{
	}

	public void Deactivate()
	{
	}

	public bool IsFinishPreparation()
	{
		return default(bool);
	}

	public void OnReceiveReadyData(int stationIndex, NoticeID noticeID)
	{
	}
}
