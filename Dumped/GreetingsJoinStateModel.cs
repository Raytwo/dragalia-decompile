using System;
using System.Runtime.CompilerServices;

public class GreetingsJoinStateModel : NetStateModel
{
	public enum GreetingsJoinState
	{
		NONE,
		WAIT,
		CANCEL_MINE,
		CANCEL_OPPONENT,
		GREETINGS
	}

	public GreetingsJoinState currentState
	{
		[CompilerGenerated]
		get
		{
			return default(GreetingsJoinState);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public UnionMsgGreetingsWindow unionMsg
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

	public UnionGreetingsContextMenu contextMenu
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

	public void ChangeGreetingsJoinState(GreetingsJoinState state)
	{
	}

	public void GreetingsWaitCancel(CancelModel cancelModel)
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
