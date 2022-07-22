using System;
using Dpr.NetworkUtils;
using UnityEngine;

namespace Dpr.UI;

public class BattleMatchingSelectPokemon : MonoBehaviour
{
	private enum State
	{
		None,
		Select,
		Wait
	}

	private UIBattleMatching _battleMatchingUIPtr;

	private UIBattleMatchingPokemonSelect _pokemonSelectUIPtr;

	private UIInputController _inputController;

	private Action _onFinishState;

	private Action _onSelect;

	private Action _onCancel;

	private Action<ushort> _onCountDown;

	private bool _ready;

	private bool _stopped;

	private float _readyWaitTime;

	private float _readyProgressTime;

	private bool _isHost;

	private bool _isCountDown;

	private const int START_UI_COUNTDOWN_COUNT = 10;

	private CountDownTimer _countTimer;

	private State _currentState;

	public void Initialize(Action onFinishState, Action onSelect, Action onCancel, Action<ushort> onCountDown)
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

	public void StartCountDown(float startTime)
	{
	}

	private void UpdateCountDown(float deltaTime)
	{
	}

	private void Timeup()
	{
	}

	private bool UpdateCountDownFlow(float deltaTime)
	{
		return default(bool);
	}

	private void SetCountDownTime()
	{
	}

	public void SetCountDownTime(int timeCount)
	{
	}

	private void CheckShowUICountDown()
	{
	}

	private void UpdateUITimeText()
	{
	}
}
