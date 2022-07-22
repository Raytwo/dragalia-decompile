using System;
using System.Runtime.CompilerServices;

public class UnionGreetingsContextMenu : UnionContextMenu
{
	public static readonly int TAG_INDEX;

	public Action<int> _TradeOk;

	public Action<int> _TradeNo;

	public GreetingsRecruitmentStateModel GreetingsRecruitmentModel
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

	public GreetingsJoinStateModel GreetingsJoinStateModel
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

	public void ShowGreetingsYesNoWindow(int targetIndex, Action noFunc)
	{
	}

	public void SetActionFade(Action fadeFunc)
	{
	}

	public void SetTransitionType()
	{
	}

	public int GetTagIndex()
	{
		return default(int);
	}
}
