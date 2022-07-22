using System;
using System.Runtime.CompilerServices;

public class UnionSystemController
{
	public struct CommunicationTargetData
	{
		public int stationIndex;

		public OpcState.OnlineState state;

		public int sexId;

		public bool isRecruiment;

		public CommunicationTargetData(int index, OpcState.OnlineState opcState, int sexID, bool isRec)
		{
		}
	}

	private const int TRADE_OK_MEMBER_POKE_COUNT = 2;

	public UnionMsgSystemWindow unionMsgSystemWindow;

	public UnionContextMenu contextMenu;

	public OnlinePlayerCharacter onlinePlayer;

	private OpcState.OnlineState onlinePlayerSelectState;

	private OpcState.OnlineState fadeAfterSelectState;

	public Action<OpcState.OnlineState, NetStateModel.StateModelType> createModel;

	public Action<OpcState.OnlineState> SendState;

	public Action OnTalkEnd;

	public Action<int> sendEndSpokeData;

	public Action<int, byte> _requestNetData;

	private Action<int> _setDefaltCancelFunc;

	private Action<int> _startGreetingsFunc;

	private int targetStationIndex;

	public int targetSexId;

	public bool isRecuruiment;

	public CommunicationTargetData targetData;

	private byte PenaltyState;

	public UnionStateTransitionController transitionController
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public void SetOnlinePlayerSelectState(OpcState.OnlineState state)
	{
	}

	public OpcState.OnlineState GetOnlinePlayerSelectState()
	{
		return default(OpcState.OnlineState);
	}

	public void SetFadeAfterSelectState(OpcState.OnlineState state)
	{
	}

	public OpcState.OnlineState GetFadeAfterSelectState()
	{
		return default(OpcState.OnlineState);
	}

	public void SetTargetStationIndex(int index, int cassetVersion = -1, bool isTalkEnd = true)
	{
	}

	public int GetTargetStationIndex()
	{
		return default(int);
	}

	public void Clear()
	{
	}

	public void CreateTargetData(int index, OpcState.OnlineState state, int id, bool isRecruiment)
	{
	}

	public void SetOnlinePlayerCharacter(OnlinePlayerCharacter onlinePlayerCharacter)
	{
	}

	public void MessageFinishChangeOpcState(OpcState.OnlineState state)
	{
	}

	public void MessageFinishChangeOpcState(OpcState.OnlineState state, OpcState.OnlineState fadeAfterState)
	{
	}

	public void ChangeOpcState(OpcState.OnlineState state)
	{
	}

	public void StartMsgBattle()
	{
	}

	public void StartMsgGreeting(Action<int> startGreetings)
	{
	}

	public void SetSystemMessageBattle()
	{
	}

	public void SetSystemMessageTrade()
	{
	}

	public void SetSystemMessageGreeting()
	{
	}

	public void SetSystemMessageBallDeco()
	{
	}

	public void SetSystemMessageCommunicate()
	{
	}

	public void SetSystemMessageNowBattle()
	{
	}

	public void SetSystemMessageNowTrade()
	{
	}

	public void SetSystemMessageNowRecord()
	{
	}

	public void SetSystemMessageNowGreetings()
	{
	}

	public void SetSystemMessageNowBallDecoration()
	{
	}

	private void GetRandomLabelFile(ref string[] labelFile, int num)
	{
	}

	public void OpenMessageTalkBattle(int sexId)
	{
	}

	public void OpenMessageTalkTrade(int sexId)
	{
	}

	public void OpenMessageTalkRecode(int sexId)
	{
	}

	public void OpenMessageTalkGreeting(int sexId)
	{
	}

	public void OpenMessageTalkBallDeco(int sexId)
	{
	}

	public void SetTradeErrorMesage()
	{
	}

	public void StartOpenGreetingMsgWindow(int stationIndex, int sexId, int cassetVersion)
	{
	}

	public void OpenSystemMsgWindow(int index, UnionTextData.SpeakerID speakerID = UnionTextData.SpeakerID.SYSTEM)
	{
	}

	public void CloseSystemMsgWindow()
	{
	}

	public void OpenYesNoWindowRecruiment()
	{
	}

	public void SetNetworkErrorMessage()
	{
	}

	public void RusultGreetJoinYesNoWindow()
	{
	}

	public void RusultGreetRecruimentYesNoWindow(int selectIndex)
	{
	}

	public void RusultGreetJoinYesNoWindow(int selectIndex)
	{
	}

	public bool CheckErrorMessageTrade()
	{
		return default(bool);
	}

	public bool CheckBallDeco()
	{
		return default(bool);
	}

	public void SetEndSpokeEndData(Action<int> endSpokeData)
	{
	}

	public void SetRequestData(Action<int, byte> requestData)
	{
	}

	public void SetIsRecruiment(bool recruiment)
	{
	}

	private void PlayerInputEnabled()
	{
	}

	private void PlayerInputDisabled()
	{
	}

	public void SetDefaltCancelFunc(Action<int> func)
	{
	}

	public void SetCallbackCommunication(Action<int, OpcState.OnlineState, bool> startCommunicationFunc)
	{
	}

	private void PenaltyErrorMsgUpdate(float time)
	{
	}
}
