using System;
using System.Runtime.CompilerServices;

public class UnionTradeContextMenu : UnionContextMenu
{
	public Action<int> _TradeOk;

	public Action<int> _TradeNo;

	public TradeRecruitmentStateModel tradeRecruitmentModel
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

	public TradeJoinStateModel TradeJoinStateModel
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

	public void ShowTradeYesNoWindow(int targetIndex, Action noFunc)
	{
	}

	public void SetActionFade(Action fadeFunc)
	{
	}

	public void SetTransitionType()
	{
	}
}
