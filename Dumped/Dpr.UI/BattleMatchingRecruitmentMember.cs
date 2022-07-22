using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Dpr.NetworkUtils;
using UnityEngine;

namespace Dpr.UI;

public class BattleMatchingRecruitmentMember : MonoBehaviour
{
	private UIBattleMatching _battleMatchingUIPtr;

	private UIInputController _inputController;

	private Action _onFinishState;

	private Action _onLeave;

	private int _loadingModelCount;

	private Queue<int> _waitLoadModelList;

	private bool _ready;

	private bool _closed;

	private float _readyWaitTime;

	private float _readyProgressTime;

	public void Initialize(Action onFinishState, Action onLeave)
	{
	}

	public void Setup(UIBattleMatching battleMatchingUI)
	{
	}

	public bool CanClose()
	{
		return default(bool);
	}

	public void PreClose()
	{
	}

	public void Close()
	{
	}

	public void OnUpdate(float deltaTime)
	{
	}

	public void JoinMember(int index, int stationIndex, [Optional] NetDataBattleMatchingJoin data)
	{
	}

	private void LoadModel(int index)
	{
	}
}
