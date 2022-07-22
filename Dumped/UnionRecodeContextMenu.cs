using System;
using System.Runtime.CompilerServices;

public class UnionRecodeContextMenu : UnionContextMenu
{
	public Action<int, int, int> _setMatchPlayerData;

	public Action<int> _sendMatchWait;

	public Action<int> _TradeOk;

	public Action<int> _TradeNo;

	public RecodeRecruitmentStateModel recodeRecruitmentModel
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

	public RecodeJoinStateModel recodeJoinStateModel
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

	public void SetCallBack(Action<int, int, int> setMacthFunc)
	{
	}

	public void ClearCallBack()
	{
	}

	public void ShowRecodeYesNoWindow(int targetIndex, Action noFunc)
	{
	}

	public void SetActionFade(Action fadeFunc)
	{
	}

	public void SetTransitionType()
	{
	}
}
