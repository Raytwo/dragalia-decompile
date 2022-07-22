using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Dpr.NetworkUtils;
using Pml.PokePara;

public class UnionTradeManager
{
	public struct BoxPokeData
	{
		public PokemonParam pokeParam;

		public bool isTeam;

		public int teamIndex;

		public int teamPos;
	}

	public class TargetTranerParam
	{
		public uint tranerId;

		public int cassetVersion;

		public string tranerName;
	}

	public enum TradeFlowState
	{
		NONE,
		SELECT_WINDOW,
		SECURIY_TRADE,
		PLAY_DEMO,
		END
	}

	private OnlinePlayerCharacter myPlayer;

	public TradeSecurityController securityController;

	private int tradeTargetIndex;

	public TradeSelectPokeModel tradeSelectModel;

	private BoxPokeData boxMyPokeData;

	private PokemonParam targetPokemonParam;

	private TargetTranerParam targetTranerParam;

	private PokemonParam selectMyPokemonParam;

	public bool isRecruiment;

	private TradeFlowMsgWindow msgWindow;

	public bool isError;

	private Action _LeaveUnion;

	public TradeFlowState currentState;

	public bool isLoadingBox
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public void Init()
	{
	}

	private void OnUpdate(float deltaTime)
	{
	}

	public void SetTargetTranerParam(uint id, string name, int cassetVersion)
	{
	}

	public void SetIsError(bool error)
	{
	}

	public bool GetIsError()
	{
		return default(bool);
	}

	private void SetWaitMessage()
	{
	}

	public void CreateTradeSelectModel(Action reStartFunc, Action networkErrorFunc, Action leaveFunc)
	{
	}

	private void WaitBoxWindowComplete()
	{
	}

	public void SetBoxData(BoxPokeData boxData)
	{
	}

	public BoxPokeData GetBoxPokeData()
	{
		return default(BoxPokeData);
	}

	public void Clear()
	{
	}

	public void Cancel()
	{
	}

	public void Error()
	{
	}

	public TradeSelectPokeModel GetTradeSlectPokeModel()
	{
		return null;
	}

	public TradeFlowState GetCurrentState()
	{
		return default(TradeFlowState);
	}

	public void NextState()
	{
	}

	public void SetCurrentState(TradeFlowState state)
	{
	}

	public void SetTargetIndex(int index)
	{
	}

	private void SetTargetConfirmPokeParam(PokemonParam param)
	{
	}

	public PokemonParam GetTargetConfirmPokeParam()
	{
		return null;
	}

	public void SetIsRecruiment(bool isRec)
	{
	}

	public PokemonParam GetSelectMyPokemonParam()
	{
		return null;
	}

	private void SendPokeParam(PokemonParam param)
	{
	}

	public void RecivePokeData(PokemonParam param)
	{
	}

	public void ReciveCancelData(NetDataCurrentFlowCancelData data)
	{
	}

	public void ReciveTradeReadyOkData(NetDataTradeReadyOkData data)
	{
	}

	public void ReciveReturnSelectPoke(NetDataReturnSelectData data)
	{
	}

	public void ReciveTradePokeCheckOk(NetDataTradePokeCheckOkData data)
	{
	}

	private void SetTargetTradePoke(PokemonParam param)
	{
	}

	public void SetSecurityTradeParam()
	{
	}

	private void SettingSecurityControllerParam(int stationIndex, BoxPokeData boxPokeData)
	{
	}

	public void StartOpenTradeBoxWindow(int index, bool isFirst = true)
	{
	}

	public void InitPlayerState()
	{
	}

	public void OnFinishedTradeInternal()
	{
	}

	public void TradeError([Optional] ErrorAppletResult errorAppletResult)
	{
	}

	public void TradeSecurityError()
	{
	}

	public void TradeSelectError()
	{
	}

	public void CheckTragetNetworkError(int targetIndex)
	{
	}

	public void SecurtyTradeClear()
	{
	}

	public void OpenTradeCancelMsg()
	{
	}

	public void CloseBoxMenuWindow()
	{
	}

	public void CloseStatusWindow()
	{
	}
}
