using System;
using System.Runtime.CompilerServices;

public class TradeRecruitmentStateModel : NetStateModel
{
	public TradeRecruitmentState currentState
	{
		[CompilerGenerated]
		get
		{
			return default(TradeRecruitmentState);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public UnionMsgTradeWindow unionMsg
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

	public int sexId
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public OnlinePlayerCharacter opcCharacter
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

	public UnionTradeContextMenu contextMenu
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

	protected override void Start()
	{
	}

	public void ChangeTradeRecruitmentState(TradeRecruitmentState state)
	{
	}

	public void SetFadeCallBack(Action fadeAction)
	{
	}

	public void InitCharaState()
	{
	}

	public void EnablePlayerInputActive()
	{
	}

	public void CloseWindow()
	{
	}

	public void RecruitmentCancel(CancelModel cancelModel)
	{
	}

	public void DefaltCancel()
	{
	}

	public void Cancel()
	{
	}

	public void TradeSpokenCancel(CancelModel cancelModel)
	{
	}

	public override void OpenSwitchCancelMsg(bool isCancel)
	{
	}

	public void ShowTradeYesNoMenu(int index, Action noFunc)
	{
	}
}
