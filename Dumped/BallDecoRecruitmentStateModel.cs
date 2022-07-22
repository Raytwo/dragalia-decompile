using System;
using System.Runtime.CompilerServices;

public class BallDecoRecruitmentStateModel : NetStateModel
{
	public enum BallDecoRecruitmentState
	{
		NONE,
		BALLDECO_RECRUITMENT,
		SELECT,
		CANCEL_MINE,
		CANCEL_OPPONENT,
		BALLDECO
	}

	public BallDecoRecruitmentState currentState
	{
		[CompilerGenerated]
		get
		{
			return default(BallDecoRecruitmentState);
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

	public void ChangeBallDecoRecruitmentState(BallDecoRecruitmentState state)
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

	public void BallDecoRecruitmentCancel(CancelModel cancelModel)
	{
	}

	public void Cancel()
	{
	}

	public void BallDecoSpokenCancel(CancelModel cancelModel)
	{
	}

	public override void OpenSwitchCancelMsg(bool isCancel)
	{
	}

	public void ShowBalldecoYesNoMenu(int index, Action noFunc)
	{
	}
}
