using System;
using Dpr.NetworkUtils;
using Pml;
using Pml.PokePara;

public class TradeSecurityController
{
	public enum TradeParent
	{
		NONE,
		PARENT,
		CHILD
	}

	private const int POKE_RARITY_VERY_RARE = 3;

	private const int POKE_RARITY_LEGEND_RARE = 2;

	private const int POKE_RARITY_SUB_LEGEND_RARE = 1;

	private const int NETWORK_NOT_ERROR = 1;

	private const int NETWORK_ERROR = 0;

	private const int INVALID_MONS_NO = -1;

	private static readonly MonsNo[] very_rare_monsno;

	private static readonly MonsNo[] legend_rare_monsno;

	private static readonly MonsNo[] sub_legend_rare_monsno;

	public TradeParent tradeParent;

	public MonsNo myMonsNo;

	public MonsNo targetMonsNo;

	public PokemonParam targetPokeData;

	public TradeStateModel tradeStateModel;

	private Action initFunc;

	private Action<int, bool> openTradeBoxWindow;

	private bool isRecruiment;

	private UnionTradeManager.BoxPokeData boxPokeData;

	private UnionTradeManager.TargetTranerParam targetTranerParam;

	public void Init(int stationIndex, UnionTradeManager.BoxPokeData boxPokeData)
	{
	}

	public void Clear()
	{
	}

	public void Error()
	{
	}

	public void SetIsRecruiment(bool Recruiment)
	{
	}

	public void SetInitCallBack(Action func, Action<int, bool> startOpenTradeBoxWindow, Action<UnionTradeManager.TradeFlowState> setState)
	{
	}

	public void SetTargetPokeData(PokemonParam pokeData)
	{
	}

	public void SetBoxPokeData(UnionTradeManager.BoxPokeData boxPokeData)
	{
	}

	public void SetTragetTranerParam(UnionTradeManager.TargetTranerParam param)
	{
	}

	public TradeStateModel.TradeState GetCurrentState()
	{
		return default(TradeStateModel.TradeState);
	}

	private void SendState()
	{
	}

	public void ReciveState(NetDataTradeReadyOkData data)
	{
	}

	public void SetTradeParent(TradeParent parent)
	{
	}

	public bool CheckPokeRarity()
	{
		return default(bool);
	}

	private void CreateTradeStateModel(int stationIndex)
	{
	}

	public void ChangeTradeModelState(TradeStateModel.TradeState state)
	{
	}

	public TradeStateModel.TradeState GetTradeState()
	{
		return default(TradeStateModel.TradeState);
	}

	public void SetIsTradeReadyOk(bool isTrade)
	{
	}

	public void DisconnectVictim_ResetSave()
	{
	}
}
