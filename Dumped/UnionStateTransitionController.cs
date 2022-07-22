using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Dpr.BattleMatching;
using Dpr.NetworkUtils;

public class UnionStateTransitionController
{
	private const float INIT_FADE_TIME = 1f;

	public OpcState.OnlineState transitionState;

	private int targetIndex;

	private float _FadeInTime;

	private bool isFadeOut;

	public UnionTradeManager tradeManager;

	private Action closeWindowCallback;

	private Action initPlayerStateCallback;

	private Action _startRecodeTradeWait;

	private Action<bool> setisTransitionAfter;

	private Action sendTransitionAfter;

	private bool isRecruiment;

	private List<UnionMatchWaitData> stanbyWaitDataList;

	private BattleMatchingManager battleMatchingManager;

	private RecodeMatching recodeMatchingManager;

	public bool isFade;

	public UnionSystemController systemController
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

	private void MyUpdate(float deltaTime)
	{
	}

	public void Clear()
	{
	}

	public void SetCallback(Action closeWindow, Action initPlayerState, Action sendTransitionAfterFunc, Action startRecodeTradeFunc)
	{
	}

	public void SetIsTransitionAfter(Action<bool> func)
	{
	}

	private void RemoveCallback()
	{
	}

	public void SetTradeManager(UnionTradeManager manager)
	{
	}

	public void SetBattleMatchingManager(BattleMatchingManager manager)
	{
	}

	public void SetTransitionState(OpcState.OnlineState onlineState)
	{
	}

	public void SetIsRecruiment(bool flag)
	{
	}

	public void SetStanbyWaitDataList(List<UnionMatchWaitData> unionMatchWaitDatas)
	{
	}

	public void AddStanbyData(UnionMatchWaitData data)
	{
	}

	public int GetStationIndex()
	{
		return default(int);
	}

	public void StartFadeOut()
	{
	}

	public void StartFadeIn()
	{
	}

	public void ResetBattleMachingReceiveData()
	{
	}

	public void TransitionBattle()
	{
	}

	public void TransitionTradePoke()
	{
	}

	public void TransitionMixRecode()
	{
	}

	public void TransitionShowTrainerCard()
	{
	}

	public void TransitionTradeBallDeco()
	{
	}

	private void SwitchTransition()
	{
	}

	private void SendTranerData(int index)
	{
	}

	private void SendOpcStateData()
	{
	}

	private void CheckSendIsMatchWait(OpcState.OnlineState state)
	{
	}

	private void CreateUIRecodeMatching()
	{
	}

	public void ReceiveRecodeData(INetData netData)
	{
	}

	public void RecodeLeaveMine()
	{
	}

	public void RecodeLeaveOther()
	{
	}

	public void InitRecodeData()
	{
	}

	public bool GetIsFade()
	{
		return default(bool);
	}
}
