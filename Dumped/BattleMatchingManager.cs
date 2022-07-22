using System;
using System.Collections;
using System.Collections.Generic;
using Dpr.NetworkUtils;
using Dpr.UI;

public class BattleMatchingManager
{
	public enum FinishPattern
	{
		Success,
		Cancel,
		Dissolution,
		LeavedMember,
		ProgramError,
		NetworkError
	}

	private enum MatchingState
	{
		None,
		Initialize,
		Load,
		RecruitmentMember,
		SelectTeamMember,
		SelectRule,
		SelectBattleTeam,
		SelectPokemon,
		GoBattle,
		Result,
		Resume,
		Closing,
		LeavedOtherMembers
	}

	private UIBattleMatching _battleMatchingUI;

	private BattleMatchingRecruitmentMember _recruitmentMember;

	private BattleMatchingSelectTeamMember _selectTeamMember;

	private BattleMatchingSelectRule _selectRule;

	private BattleMatchingSelectBattleTeam _selectBattleTeam;

	private BattleMatchingSelectPokemon _selectPokemon;

	private BattleMatchingResult _result;

	private BattleMatchingResume _resume;

	private NetDataBattleMatchingCountDown _countDownData;

	private Queue<INetData> _loadingRecieveData;

	private Action _onFinish;

	private bool _isError;

	private MatchingState _currentState;

	public bool IsError => default(bool);

	public bool IsStateNone => default(bool);

	public bool IsStateBattle => default(bool);

	public bool IsStateClosing => default(bool);

	public static IEnumerator LoadBattleMatchingUI(Action<UIBattleMatching> onCompletedLoad)
	{
		return null;
	}

	public static void UnloadBattleMatchingUI()
	{
	}

	public static IEnumerator LoadBattleTowerUI(Action onCompletedLoad)
	{
		return null;
	}

	public static void UnloadBattleTowerUI()
	{
	}

	public void Initialize(Action onFinish)
	{
	}

	public void ResetData()
	{
	}

	public void StartProcess()
	{
	}

	private bool IsNetworkError()
	{
		return default(bool);
	}

	private void FinishProcess()
	{
	}

	private void PreClose()
	{
	}

	private void Close()
	{
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private void OnUpdateClose()
	{
	}

	private void FinishMatching()
	{
	}

	private MatchingState NextState()
	{
		return default(MatchingState);
	}

	private void ChangeNextState()
	{
	}

	private void ChangeState(MatchingState state)
	{
	}

	private void ShowVS()
	{
	}

	private void GoBattle()
	{
	}

	public void ReturnBattle()
	{
	}

	public void ReturnBattleError()
	{
	}

	private void LeaveMine()
	{
	}

	public void LeaveOther(int index)
	{
	}

	public void OnError()
	{
	}

	public void SendJoinMineData(int targetStationIndex)
	{
	}

	public void SendJoinMemberData(int index, NetDataBattleMatchingJoin data)
	{
	}

	public void SendLeaveData()
	{
	}

	public void SendReadyData()
	{
	}

	public void SendStateData()
	{
	}

	public void SendSelectTeamData(int index, int stationIndex)
	{
	}

	public void SendDecideTeamData()
	{
	}

	public void SendSelectRuleMemberData()
	{
	}

	public void SendDecideRuleMemberData()
	{
	}

	public void SendRuleData()
	{
	}

	public void SendSelectPokemonData()
	{
	}

	public void SendCancelPokemonData()
	{
	}

	public void SendResumeData(bool resume)
	{
	}

	public void SendCountDownData(ushort timeCount)
	{
	}

	public void ReceiveData(INetData netData)
	{
	}

	private void ReceiveJoinData(NetDataBattleMatchingJoin data)
	{
	}

	private void ReceiveLeaveData(NetDataBattleMatchingLeave data)
	{
	}

	private void ReceiveReadyData(NetDataBattleMatchingReady data)
	{
	}

	private void ReceiveStateData(NetDataBattleMatchingState data)
	{
	}

	private void ReceiveSelectTeamData(NetDataBattleMatchingSelectTeam data)
	{
	}

	private void ReceiveDecideTeamData(NetDataBattleMatchingDecideTeam data)
	{
	}

	private void ReceiveSelectRuleMemberData(NetDataBattleMatchingSelectRuleMember data)
	{
	}

	private void ReceiveDecideRuleMemberData(NetDataBattleMatchingDecideRuleMember data)
	{
	}

	private void ReceiveRuleData(NetDataBattleMatchingRule data)
	{
	}

	private void ReceiveSelectPokemonData(NetDataBattleMatchingSelectPokemon data)
	{
	}

	private void ReceiveCancelPokemonData(NetDataBattleMatchingCancelPokemon data)
	{
	}

	private void ReceiveResumeData(NetDataBattleMatchingResume data)
	{
	}

	private void ReceiveCountDownData(NetDataBattleMatchingCountDown data)
	{
	}

	private void SetPlayReport()
	{
	}

	private void CheckReceivedPacket()
	{
	}
}
