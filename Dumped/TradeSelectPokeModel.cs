using System;
using System.Collections;
using System.Runtime.InteropServices;
using Dpr.NetworkUtils;
using Dpr.UI;
using INL1;
using Pml.PokePara;
using UnityEngine;

public class TradeSelectPokeModel
{
	public enum TradeSelectState
	{
		NONE,
		WAIT,
		COMPLETE,
		CANCAL_MINE,
		CANCAL_OTHER,
		ERROR_MINE,
		ERROR_OTHER
	}

	private static readonly string MESSAGE_ID_TRADE_ERROR_MINE;

	private static readonly string MESSAGE_ID_TRADE_ERROR_OTHER;

	private static readonly string MESSAGE_ID_TRADE_CANCEL;

	private Action<PokemonParam> _SendPokeParam;

	private Action<PokemonParam> _SetTargetSelectPokeData;

	private Action<UnionTradeManager.BoxPokeData> _SetBoxData;

	private Action _ReStart;

	private Action _Cancel;

	private Action _Error;

	private Action _OpenErrorDialog;

	private Action _LeaveUnion;

	private int tradeTargetIndex;

	private BoxWindow boxWindow;

	private BoxWindow.SelectedPokemon selectPokemon;

	private BoxWindow.NetTradePhase nextTradePhase;

	private PokemonParam targetPokemonParam;

	private bool isRecivePokeParam;

	private bool isSendPokeParam;

	private bool isTrading;

	private TradeStateModel.TradeState myTradeState;

	private TradeStateModel.TradeState targetTradeState;

	private TradeSelectState currentState;

	private Coroutine currentCoroutine;

	public UnionTradeManager.TargetTranerParam targetTranerParam;

	public void Init()
	{
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private void CheckCloseUIWindowOnErrorDialog()
	{
	}

	public void Clear()
	{
	}

	public void InitParam()
	{
	}

	public void SetCallback(Action<PokemonParam> send, Action<PokemonParam> setTargetSelectPokeData, Action<UnionTradeManager.BoxPokeData> setBoxData, Action cancal, Action error, Action openErrorDiaolog, [Optional] Action leaveUnion)
	{
	}

	public void ClearCallback()
	{
	}

	public void SetStationIndex(int index)
	{
	}

	public int GetStationIndex()
	{
		return default(int);
	}

	public void SetTargetPokeParam(PokemonParam param)
	{
	}

	public void SetIsRecivePokeParam(bool isRecive)
	{
	}

	public void SetIsSendPokeParam(bool isSend)
	{
	}

	public bool GetIsSendPokeParam()
	{
		return default(bool);
	}

	private bool IsOpenModelView()
	{
		return default(bool);
	}

	public TradeStateModel.TradeState GetMyTradeState()
	{
		return default(TradeStateModel.TradeState);
	}

	public TradeStateModel.TradeState GetTargetTradeState()
	{
		return default(TradeStateModel.TradeState);
	}

	public void SetTradeSelectState(TradeSelectState state)
	{
	}

	public void SetNextTradePhase(BoxWindow.NetTradePhase phase)
	{
	}

	public TradeSelectState GetTradeSelectState()
	{
		return default(TradeSelectState);
	}

	public BoxWindow GetBoxWindow()
	{
		return null;
	}

	public void SetTargetTranerParam(UnionTradeManager.TargetTranerParam param)
	{
	}

	private IEnumerator PokeSelectWait(BoxWindow window)
	{
		return null;
	}

	private IEnumerator TradePokeCheckOkWait(BoxWindow boxWindow)
	{
		return null;
	}

	private UnionTradeManager.BoxPokeData SettingBoxPokeData(BoxWindow.SelectedPokemon selectData)
	{
		return default(UnionTradeManager.BoxPokeData);
	}

	private void CheckComplete(BoxWindow window)
	{
	}

	private void BoxCloseComplete()
	{
	}

	private void BoxCloseCancel()
	{
	}

	private void BoxCloseError()
	{
	}

	public void BoxOpenError()
	{
	}

	public void OpenTradeBoxWindow(bool isFirst, UnionTradeManager.TargetTranerParam param)
	{
	}

	private void OnSelectBoxPoke(BoxWindow window, bool isFirst, bool isReceived)
	{
	}

	public void OnFinishTrade()
	{
	}

	public void SetBoxMessage(BoxWindow window, string messageId)
	{
	}

	private void CheckCancelSelect()
	{
	}

	private void TradeCheckPokeResult(ValidateCheckResult checkResult)
	{
	}

	private void SendRequestPokeData()
	{
	}

	private void SendRequestCancelData()
	{
	}

	private void SendCancel()
	{
	}

	public void SendReadyOk(TradeStateModel.TradeState state)
	{
	}

	private void MyReadyOk()
	{
	}

	public void SendReturnSelectPoke(bool received = false)
	{
	}

	public void SendTradePokeCheckOk()
	{
	}

	private void ResetTradeState()
	{
	}

	public void ReciveReadyOk(NetDataTradeReadyOkData data)
	{
	}

	public void ReciveCancel(NetDataCurrentFlowCancelData data)
	{
	}

	public void ReciveReturnSelectPoke(NetDataReturnSelectData data)
	{
	}

	public void ReciveTradePokeCheckOk(NetDataTradePokeCheckOkData data)
	{
	}

	private void Close(UIWindow window)
	{
	}

	private void CloseUIWindow()
	{
	}

	private string GetCheckTargetName(IlcaNetGamer targetData)
	{
		return null;
	}

	private bool IsBattleTeamPoke(BoxWindow.SelectedPokemon selectPoke)
	{
		return default(bool);
	}

	private int GetTradeOkPokeCount()
	{
		return default(int);
	}
}
