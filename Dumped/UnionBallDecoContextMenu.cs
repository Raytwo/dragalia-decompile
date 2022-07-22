using System;
using System.Runtime.CompilerServices;

public class UnionBallDecoContextMenu : UnionContextMenu
{
	public static readonly int TAG_INDEX;

	public Action<int> _TradeOk;

	public Action<int> _TradeNo;

	public BallDecoRecruitmentStateModel ballDecoRecruitmentModel
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

	public BallDecoJoinStateModel ballDecoJoinStateModel
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

	public void ShowBallDecoYesNoWindow(int targetIndex, Action noFunc)
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
