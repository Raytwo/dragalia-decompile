using System;
using UnityEngine;

namespace Dpr.UI;

public class BattleMatchingSelectRule : MonoBehaviour
{
	private UIBattleMatching _battleMatchingUIPtr;

	private UIInputController _inputController;

	private Action _onSelectMember;

	private Action _onDecideMember;

	private Action _onRule;

	private Action _onFinishState;

	private bool _isSelectingRule;

	private bool _ready;

	private float _readyWaitTime;

	private float _readyProgressTime;

	public void Initialize(Action onFinishState, Action onSelectMember, Action onDecideMember, Action onRule)
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

	public void SelectMember()
	{
	}

	private void OnSelectMember(int index)
	{
	}

	private void WaitSelectMember()
	{
	}

	private void SelectRule()
	{
	}

	public void WaitSelectRule(int stationIndex)
	{
	}

	public void SetReady()
	{
	}
}
