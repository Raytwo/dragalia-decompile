using System;
using System.Runtime.CompilerServices;

public class GreetingsRecruitmentStateModel : NetStateModel
{
	public enum GreetingsRecruitmentState
	{
		NONE,
		GREETINGS_RECRUITMENT,
		SELECT,
		CANCEL_MINE,
		CANCEL_OPPONENT,
		GREETINGS
	}

	public GreetingsRecruitmentState currentState
	{
		[CompilerGenerated]
		get
		{
			return default(GreetingsRecruitmentState);
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

	public void ChangeGreetingsRecruitmentState(GreetingsRecruitmentState state)
	{
	}

	public void CloseWindow()
	{
	}

	public void GreetingRecruimentcancel(CancelModel cancelModel)
	{
	}

	public void Cancel()
	{
	}

	public void GreetingsSpokenCancel(CancelModel cancelModel)
	{
	}

	public override void OpenSwitchCancelMsg(bool isCancel)
	{
	}

	public void ShowGreetingsYesNoMenu(int index, Action noFunc)
	{
	}
}
