using System;
using UnityEngine;

namespace Dpr.UI;

public class BattleMatchingSelectBattleTeam : MonoBehaviour
{
	private enum State
	{
		None,
		Rule,
		Select,
		Wait
	}

	private UIBattleMatching _battleMatchingUIPtr;

	private UIBattleMatchingTeamSelect _teamSelect;

	private UIInputController _inputController;

	private Action _onFinishState;

	private Action _onLeave;

	private Action _onSelect;

	private Action _onCancel;

	private bool _ready;

	private bool _closed;

	private float _readyWaitTime;

	private float _readyProgressTime;

	private bool _openingWindow;

	private bool _openedTeamSelect;

	private State _currentState;

	public void Initialize(Action onFinishState, Action onLeave, Action onSelect, Action onCancel)
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

	private void ChangeState(State state)
	{
	}

	private void SetPreparationIconReady()
	{
	}

	private void SetPreparationIconWait()
	{
	}

	public void SetPreparationIconReady(int stationIndex)
	{
	}

	public void SetPreparationIconWait(int stationIndex)
	{
	}

	private void ShowSelectLeave()
	{
	}

	private void OnSelectLeave(int index)
	{
	}
}
