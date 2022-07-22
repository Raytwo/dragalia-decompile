using System;
using System.Runtime.InteropServices;
using Dpr.NetworkUtils;
using Pml.PokePara;

public class TradeStateModel
{
	public enum TradeState
	{
		NONE,
		INIT,
		WAIT,
		SEND_POKE,
		WAIT_POKE,
		SEND_READYOK,
		WAIT_READYOK,
		START_WRITE_SAVE,
		WRITEING_SAVE,
		END_SAVE,
		END,
		ERROR
	}

	private const int INVALID_INDEX = -1;

	private const int WAIT_RND_TIME_MAX = 30;

	protected int targetStationIndex;

	public PokemonParam myPokeData;

	public PokemonParam targetPokeData;

	protected PokemonParam myPokeParam;

	protected PokemonParam targetPokeParam;

	protected PokemonParam myPokeCopyData;

	private UnionTradeManager.BoxPokeData evolvedTargetPokeParam;

	public TradeSecurityStateMessageWindow msgWindow;

	protected Action errorFunc;

	protected Action disconnectFunc;

	protected Action initFunc;

	protected Action<int, bool> openTradeBoxWindow;

	protected Action<UnionTradeManager.TradeFlowState> setTradeFlowState;

	public TradeState currentState;

	public TradeState targetState;

	public bool targetIsTradeReadyOk;

	public TradeSecurityController.TradeParent tradeParent;

	private uint myPokeUniqeId;

	private uint targetPokeUniqeId;

	private UnionTradeManager.BoxPokeData boxPokeData;

	private UnionTradeManager.TargetTranerParam targetTranerParam;

	private bool IsGetMonsNo;

	private bool IsGetEvolvedMonsNo;

	public int waitRndTime;

	public virtual void Init()
	{
	}

	public void Clear()
	{
	}

	public void FirstSave()
	{
	}

	public void SecondSave()
	{
	}

	public void DisconnectVictim_ResetSave()
	{
	}

	public void PlayerSave()
	{
	}

	public void SetInitCallBack(Action func, Action<int, bool> startOpenTradeBoxWindow, Action<UnionTradeManager.TradeFlowState> setState)
	{
	}

	public void SetTargetTransitionIndex(int index)
	{
	}

	public int GetTargetTransitionIndex()
	{
		return default(int);
	}

	public void SetTargetTranerParam(UnionTradeManager.TargetTranerParam param)
	{
	}

	public void SetTragetPokeData(PokemonParam pokemonParam)
	{
	}

	public void SetBoxPokeData(UnionTradeManager.BoxPokeData boxPoke)
	{
	}

	public void SetTradeParent(TradeSecurityController.TradeParent parentState)
	{
	}

	public TradeSecurityController.TradeParent GetTradeParent()
	{
		return default(TradeSecurityController.TradeParent);
	}

	protected virtual void SendPokeData()
	{
	}

	protected virtual void RecivePokeData(byte[] pokeData)
	{
	}

	public virtual void SendTradeState()
	{
	}

	protected virtual void WriteSaveData()
	{
	}

	public bool CheckReplacePokeData()
	{
		return default(bool);
	}

	public void InitState()
	{
	}

	public virtual void OnUpdate(float deltaTime)
	{
	}

	public void PlayTradeDemo()
	{
	}

	private void ReturnTradePokeSelectWindow()
	{
	}

	public void SetNetModelState(TradeState tradeState)
	{
	}

	public TradeState GetCurrentTradeState()
	{
		return default(TradeState);
	}

	public bool IsTargetPokeData()
	{
		return default(bool);
	}

	public bool IsShowFatalError()
	{
		return default(bool);
	}

	public bool CheckNetworkConnect()
	{
		return default(bool);
	}

	public void OpenErrorMessage([Optional] ErrorAppletResult errorAppletResult)
	{
	}

	public bool IsNetworkCheck()
	{
		return default(bool);
	}

	private void TradeCancelReturn()
	{
	}

	public void ReplacePoke()
	{
	}

	private void SetPlayReport()
	{
	}
}
