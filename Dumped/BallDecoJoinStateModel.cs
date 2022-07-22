using System;
using System.Runtime.CompilerServices;

public class BallDecoJoinStateModel : NetStateModel
{
	public enum BallDecoJoinState
	{
		NONE,
		WAIT,
		CANCEL_MINE,
		CANCEL_OPPONENT,
		BALL_DECO
	}

	public BallDecoJoinState currentState
	{
		[CompilerGenerated]
		get
		{
			return default(BallDecoJoinState);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public UnionMsgBallDecoWindow unionMsg
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

	public UnionBallDecoContextMenu contextMenu
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

	public void ChangeBallDecoJoinState(BallDecoJoinState state)
	{
	}

	public void BallDecoWaitCancel(CancelModel cancelModel)
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
