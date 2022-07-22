using System;
using System.Collections.Generic;
using DPData;
using Dpr.BattleMatching;
using Dpr.NetworkUtils;
using UnityEngine;

public class UnionStateController
{
	private UnionMsgBattleWindow BattleMsgWindow;

	private UnionMsgTradeWindow TradeMsgWindow;

	private UnionMsgRecodeWindow RecodeMsgWindow;

	private UnionMsgGreetingsWindow GreetingsMsgWindow;

	private UnionMsgBallDecoWindow BallDecoMsgWindow;

	private BattleRecruitmentStateModel battleRecruitmentModel;

	private BattleJoinStateModel battleJoinStateModel;

	private TradeRecruitmentStateModel tradeRecruitmentStateModel;

	private TradeJoinStateModel tradeJoinStateModel;

	private RecodeRecruitmentStateModel recodeRecruitmentStateModel;

	private RecodeJoinStateModel recodeJoinStateModel;

	private GreetingsRecruitmentStateModel greetingsRecruitmentStateModel;

	private GreetingsJoinStateModel greetingsJoinStateModel;

	private BallDecoRecruitmentStateModel ballDecoRecruitmentStateModel;

	private BallDecoJoinStateModel ballDecoJoinStateModel;

	private NetStateModel _currentModel;

	public UnionSystemController systemController;

	private UnionContextMenu unionContextMenu;

	private NetDataTalkData talkData;

	public OnlinePlayerCharacter playerCharacter;

	public UnionOpcManager unionOpcManager;

	private Action StartFadeOut;

	public Action transitionFunc;

	private UnionStateTransitionController transitionController;

	public Action leaveUnion;

	public Action<int, byte> requestNetData;

	public Action sendIsTransitionAfter;

	public OpcState.OnlineState opcState;

	public List<UnionMatchWaitData> unionMatchWaitDataList;

	public List<UnionMatchWaitData> unionMatchWaitAllDataList;

	public bool isMultiMatchWait;

	private UnionBattleContextMenu unionBattleContextMenu;

	private const float autoCloseMsgWindowTime = 0.5f;

	private float _autoCloseMsgWindowProgressTime;

	[SerializeField]
	private GameObject _dMenu;

	[SerializeField]
	private CanvasGroup _canvasGroup;

	public UnionBattleRuleWindow unionBattleRuleWindow;

	private int debugTargetStationIndex;

	public NetStateModel currentModel
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public UnionStateController(OnlinePlayerCharacter onlinePlayer, UnionOpcManager opcManager, ZoneID zoneID, Action leaveUnionRoom, Action<int, byte> request, Action sendTransitionAfterFunc)
	{
	}

	public void SetCallBack(Action leaveUnionRoom, Action<int, byte> request, Action sendTransitionAfterFunc)
	{
	}

	private void OnTalkEnd()
	{
	}

	public void CreateTransitionController()
	{
	}

	public void Clear()
	{
	}

	public void SetIsTransitionAfter(Action<bool> func)
	{
	}

	public UnionStateTransitionController GetTransitionController()
	{
		return null;
	}

	public bool IsOpenContextMenu()
	{
		return default(bool);
	}

	private void CreateContextMenu(ZoneID zoneID)
	{
	}

	public void CreateSystemContextMenu()
	{
	}

	private void CreateSystemController()
	{
	}

	public void CloseWindow()
	{
	}

	public void CloseContextWindow()
	{
	}

	public void InitPlayerState()
	{
	}

	public void HideBattleStateWindow()
	{
	}

	private void SendSpokenData(int stationIndex)
	{
	}

	private void CreateTalkData()
	{
	}

	private void ChangeTalkData(TalkState talkState, int index)
	{
	}

	private void MessageEndSpokenData()
	{
	}

	private void ChangeJoinGreetings(int selectIndex)
	{
	}

	public void ClearTalkData()
	{
	}

	public bool IsMsgWindowOpen()
	{
		return default(bool);
	}

	public void SetStartFadeOutCallBack(Action fadeFunc)
	{
	}

	public void SetTransitionFunc(Action transFunc)
	{
	}

	private void CreateSelectStateMsgWindow()
	{
	}

	public BattleRecruitmentStateModel GetBattleRecruimentModel()
	{
		return null;
	}

	public BattleJoinStateModel GetBattleJoinModel()
	{
		return null;
	}

	public NetStateModel GetTradeRecruimentModel()
	{
		return null;
	}

	public NetStateModel GetTradeJoinModel()
	{
		return null;
	}

	public NetStateModel GetRecodeRecruimentModel()
	{
		return null;
	}

	public NetStateModel GetRecodeJoinModel()
	{
		return null;
	}

	public NetStateModel GetGreetingRecruimentModel()
	{
		return null;
	}

	public NetStateModel GetGreetingJoinModel()
	{
		return null;
	}

	public NetStateModel GetBallDecoRecruimentModel()
	{
		return null;
	}

	public NetStateModel GetBallDecoJoinModel()
	{
		return null;
	}

	public void CreateSelectStateModel(OpcState.OnlineState state, NetStateModel.StateModelType stateModelType)
	{
	}

	public void DefaltTradeCancelModel(int index)
	{
	}

	public void DefaltBattleCancelModel(int index)
	{
	}

	public void DefaltRecodeCancelModel(int index)
	{
	}

	public void DefaltGreetingCancelModel(int index)
	{
	}

	public void DefaltBallDecoCancelModel(int index)
	{
	}

	public void CreateRecruitmentBattleCancelModel(int index = -1)
	{
	}

	private void CreateJoinBattleCancelModel(int index)
	{
	}

	private void CreateRecruitmentTradeCancelModel(int index)
	{
	}

	private void CreateJoinTradeCancelModel(int index)
	{
	}

	private void CreateRecruitmentRecodeCancelModel(int index)
	{
	}

	private void CreateJoinRecodeCancelModel(int index)
	{
	}

	private void CreateRecruitmentGreetingsCancelModel(int index)
	{
	}

	private void CreateJoinGreetingsCancelModel(int index)
	{
	}

	private void CreateRecruitmentBallDecoCancelModel(int index)
	{
	}

	private void CreateJoinBallDecoCancelModel(int index)
	{
	}

	public void SwitchTransitionMessage(int type, int sexId, int fromStationIndex, bool isRecruitment = false)
	{
	}

	public bool SwitchTalkStateMine(OpcState.OnlineState state, OpcController controller)
	{
		return default(bool);
	}

	private void StartAutoCloseMsgWindow()
	{
	}

	private void CompleteAutoCloseMsgWindow()
	{
	}

	private void UpdateAutoCloseMsgWindow(float deltaTime)
	{
	}

	public void SwitchSpokenStateMine(int index, TalkState talkState)
	{
	}

	public void SwitchCancelEnd()
	{
	}

	public void SettingCurrentState(int targetStationIndex, OpcState.OnlineState onlineState, bool isRecruiment)
	{
	}

	public void StartCommunication(int targetStationIndex, OpcState.OnlineState onlineState, bool isRecruiment)
	{
	}

	public void SwitchTransitionAfterTalk(OpcState.OnlineState state, OpcController controller)
	{
	}

	public void ShowDebugMenu()
	{
	}

	public void HideDebugMenu()
	{
	}

	private OpcState.OnlineState GetSelectMenuOpcState(int id)
	{
		return default(OpcState.OnlineState);
	}

	public void SetBattleStateWindowText(List<UnionMatchWaitData> matchWaitDataList, BattleModeID battleModeId)
	{
	}

	public void ShowBattleJoinYesNoMenu(int staIndex)
	{
	}

	public void Decide(int stationIndex)
	{
	}

	public void Cancel()
	{
	}

	private void ShowBattleStateWindow(List<UnionMatchWaitData> matchWaitDataList, BattleModeID battleModeId)
	{
	}

	public void SwitchBatttleStateTalk(int stationIndex, BattleModeID battleModeID)
	{
	}

	private void ShowJoinRecodeCheck(int targetStationIndex)
	{
	}

	public void ReciveIsMatchWait(NetDataIsMatchWaitData data)
	{
	}

	public void ReciveMatchWaitListData(NetDataStandbyWaitListData data)
	{
	}

	public void ReciveMatchWaitData(NetDataStandbyWaitData data)
	{
	}

	private void AddMacthPlayerData(int targetStationIndex)
	{
	}

	private void AddMacthPlayerDataInMine(int hostIndex, int joinPlayerIndex, int sendTargetIndex)
	{
	}

	public void AddMatchWait(UnionMatchWaitData waitData)
	{
	}

	public void RemoveMatchWait(int removeIndex)
	{
	}

	public void RemoveMatchWaitStationIndex(int stationIndex)
	{
	}

	public void ClearMatchWait()
	{
	}

	public List<UnionMatchWaitData> GetMatchWaitList()
	{
		return null;
	}

	private void SendRequestIsMatchWait(int stationIndex)
	{
	}

	private void SendRequestMatchPlayerListData(int stationIndex)
	{
	}

	private void SendRequestBattleRule(int stationIndex)
	{
	}

	private void SendIsMatchWait()
	{
	}

	private void SendAddStanbyPlayer()
	{
	}

	private void SendRecodeData(RECORD recodeData, int targetStationIndex)
	{
	}

	private void SendStandbyPlayerData(int stationIndex)
	{
	}

	private void ClearMatchPlayerDataList()
	{
	}
}
