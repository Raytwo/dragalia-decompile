using System;
using System.Runtime.CompilerServices;

public class RecodeJoinStateModel : NetStateModel
{
	public enum RecodeJoinState
	{
		NONE,
		WAIT,
		CANCEL_MINE,
		CANCEL_OPPONENT,
		RECODE
	}

	public RecodeJoinState currentState
	{
		[CompilerGenerated]
		get
		{
			return default(RecodeJoinState);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public UnionMsgRecodeWindow unionMsg
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

	public UnionRecodeContextMenu contextMenu
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

	public void ChangeRecodeJoinState(RecodeJoinState state)
	{
	}

	public void RecodeWaitCancel(CancelModel cancelModel)
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
