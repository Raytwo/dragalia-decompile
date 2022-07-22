using System;
using UnityEngine;

public class OpcState : MonoBehaviour
{
	public enum OnlineState
	{
		NONE,
		DIG_FOSILL,
		SECRETBASE_ACTION,
		RECRUITMENT_BATTLE,
		RECRUITMENT_TRADE,
		RECRUITMENT_RECORD,
		RECRUITMENT_GREETINGS,
		RECRUITMENT_BALL_DECORATION,
		COMMUNICATE,
		LIKES,
		CROSS,
		EXCLAMATION,
		TOGETHER,
		GET,
		NOW_DIG_FOSILE,
		NOW_MENU,
		NOW_BATTLE,
		NOW_BATTLE_UNION,
		NOW_TRADE,
		NOW_RECORD,
		NOW_GREETINGS,
		NOW_BALL_DECORATION,
		_NULL
	}

	public OnlineState _curretOnlineState;

	private Action<OnlineState> _OnChangeState;

	public void SetOnChangeState(Action<OnlineState> action)
	{
	}

	public void OnChangeOnlineState(OnlineState state)
	{
	}

	public OnlineState GetOnlineState()
	{
		return default(OnlineState);
	}

	public bool IsCanTalkState()
	{
		return default(bool);
	}
}
