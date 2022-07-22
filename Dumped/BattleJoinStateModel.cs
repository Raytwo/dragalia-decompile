using System;
using System.Runtime.CompilerServices;
using Dpr.Message;
using Dpr.NetworkUtils;

public class BattleJoinStateModel : NetStateModel
{
	public enum BattleJoinState
	{
		NONE,
		RULE_APPROVAL,
		RULE_SELECT,
		CANCEL_MINE,
		CANCEL_OPPONENT,
		BATTLE_RULE_SELECT_END,
		BATTLE
	}

	public BattleJoinState currentState
	{
		[CompilerGenerated]
		get
		{
			return default(BattleJoinState);
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

	public UnionBattleContextMenu contextMenu
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

	public UnionBattleRuleWindow unionBattleRuleWindow
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

	public void ChangeBattleJoinState(BattleJoinState state)
	{
	}

	public void BattleRuleApprovalCancel(CancelModel cancelModel)
	{
	}

	public void BattleRuleSelectCancel(CancelModel cancelModel)
	{
	}

	public void BattleRuleSelectEndCancel(CancelModel cancelModel)
	{
	}

	public void CloseWindow()
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

	public void ShowBattleJoinYesNoMenu(int staIndex)
	{
	}

	public void SetBattleStateDebugWindowText(string nameTxt, BattleModeID battleModeId, MessageEnumData.MsgLangId langId)
	{
	}

	public void ShowBattleStateWindow(int index, BattleModeID battleModeId)
	{
	}

	public void HideBattleStateWindow()
	{
	}

	private void Decide(int targetIndex, BattleModeID battleModeID)
	{
	}

	private void Cancel(int targetIndex)
	{
	}

	public override bool IsCancelable()
	{
		return default(bool);
	}
}
