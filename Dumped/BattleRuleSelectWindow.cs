using System;
using System.Collections.Generic;
using Dpr.MsgWindow;
using Dpr.NetworkUtils;
using Dpr.UI;
using UnityEngine;

public class BattleRuleSelectWindow : UIWindow
{
	private const float WINDOW_CLOSE_TIME = 1f;

	[SerializeField]
	private UIText titleText;

	[SerializeField]
	private UIText detielText;

	private Action<BattleModeID> _onDecide;

	private Action _onCancel;

	private List<BattleModeID> battleModeIDList;

	private bool _cancelFade;

	private int _currentIndex;

	private WaitTimer waitTimer;

	private static readonly string[] BATTLE_RULE;

	private static readonly string[] BATTLE_RULE_NAIYOU;

	public void Open(List<BattleModeID> battleMode, Action<BattleModeID> onDecide, Action onCancel, bool fadeIn = false, bool cancelFade = false, UIWindowID prevWindowId = (UIWindowID)(-2))
	{
	}

	public void Close()
	{
	}

	private void OnUpdate(float deltaTime)
	{
	}

	public override void OnCreate()
	{
	}

	public int GetCurrentSelectIndex()
	{
		return default(int);
	}

	private void SetKeyguide()
	{
	}

	private void MoveSelectRule(bool right)
	{
	}

	private void SelectRule(int index)
	{
	}

	private int GetPrevIndex()
	{
		return default(int);
	}

	private int GetNextIndex()
	{
		return default(int);
	}

	private void DecideRule()
	{
	}

	private void Decide()
	{
	}

	private void Back()
	{
	}

	private string[] GetMsbtFileLabel(string label)
	{
		return null;
	}
}
