using System;
using UnityEngine;

namespace Dpr.UI;

public class BattleMatchingResult : MonoBehaviour
{
	private UIBattleMatching _battleMatchingUIPtr;

	private Action _onFinishState;

	private bool _ready;

	private float _readyWaitTime;

	private float _readyProgressTime;

	public void Initialize(Action onFinishState)
	{
	}

	public void Setup(UIBattleMatching battleMatchingUI)
	{
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

	private void LoadModel()
	{
	}
}
