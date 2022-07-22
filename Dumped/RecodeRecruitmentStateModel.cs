using System;
using System.Runtime.CompilerServices;

public class RecodeRecruitmentStateModel : NetStateModel
{
	public enum RecodeRecruitmentState
	{
		NONE,
		RECODE_RECRUITMENT,
		SELECT,
		CANCEL_MINE,
		CANCEL_OPPONENT,
		TRADE
	}

	public RecodeRecruitmentState currentState
	{
		[CompilerGenerated]
		get
		{
			return default(RecodeRecruitmentState);
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

	public void ChangeRecodeRecruitmentState(RecodeRecruitmentState state)
	{
	}

	public void EnablePlayerInputActive()
	{
	}

	public void CloseWindow()
	{
	}

	public void RecodeRecruitmentCancel(CancelModel cancelModel)
	{
	}

	public void Cancel()
	{
	}

	public void RecodeSpokenCancel(CancelModel cancelModel)
	{
	}

	public override void OpenSwitchCancelMsg(bool isCancel)
	{
	}

	public void ShowRecodeYesNoMenu(int index, Action noFunc)
	{
	}
}
