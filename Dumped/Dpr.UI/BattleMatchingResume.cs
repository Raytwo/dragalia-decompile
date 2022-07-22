using System;
using UnityEngine;

namespace Dpr.UI;

public class BattleMatchingResume : MonoBehaviour
{
	private UIBattleMatching _battleMatchingUIPtr;

	private Action _onFinishState;

	private Action<bool> _onSelect;

	private Action _onLeve;

	private bool _resume;

	private bool _ready;

	private bool _closed;

	private bool _finished;

	private float _readyWaitTime;

	private float _readyProgressTime;

	private UIInputController _inputController;

	public void Initialize(Action onFinishState, Action<bool> onSelect, Action onLeve)
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

	private void ShowSelectResume()
	{
	}

	private void OnSelectResume(int index)
	{
	}

	private void ShowSelectLeave()
	{
	}

	private void OnSelectLeave(int index)
	{
	}

	private void OnSelect(bool resume)
	{
	}

	public void Resume()
	{
	}
}
