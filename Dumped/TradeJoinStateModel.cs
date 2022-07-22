using System;
using System.Runtime.CompilerServices;

public class TradeJoinStateModel : NetStateModel
{
	public new enum TradeJoinState
	{
		NONE,
		WAIT,
		CANCEL_MINE,
		CANCEL_OPPONENT,
		TRADE
	}

	public TradeJoinState currentState
	{
		[CompilerGenerated]
		get
		{
			return default(TradeJoinState);
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

	public void ChangeTradeJoinState(TradeJoinState state)
	{
	}

	public void DefaltCancel()
	{
	}

	public void TradeWaitCancel(CancelModel cancelModel)
	{
	}

	public void OpenSwitchMsg(int sexId)
	{
	}

	public void OpenSwitchFadeMsg(int sexId)
	{
	}

	public override void OpenSwitchCancelMsg(bool isCancel)
	{
	}
}
