using System;
using System.Collections.Generic;
using Dpr.Message;
using UnityEngine;

namespace Dpr.UI;

public class BattleMatchingSelectTeamMember : MonoBehaviour
{
	private UIBattleMatching _battleMatchingUIPtr;

	private Action _onFinishState;

	private Action<int, int> _onSelect;

	private Action _onDecide;

	private List<int> _orderPlayers;

	private MessageMsgFile _msgFile;

	private UIInputController _inputController;

	private bool _closed;

	public void Initialize(Action onFinishState, Action<int, int> onSelect, Action onDecide)
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

	public void DecideTeam()
	{
	}

	private void ShowSelectMessage()
	{
	}

	private void OnSelectMessage(int index)
	{
	}

	private void DecidePlayer(int index, int stationIndex)
	{
	}

	public void LoadModel(int index, int stationIndex)
	{
	}

	public void UnloadModel(int index)
	{
	}

	private void SetKeyGuide(bool complete = false)
	{
	}
}
