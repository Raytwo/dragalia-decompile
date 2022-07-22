using System;
using System.Runtime.CompilerServices;
using Dpr.Message;
using Dpr.NetworkUtils;

public class BattleRecruitmentStateModel : NetStateModel
{
	public enum BattleRecruitmentState
	{
		NONE,
		BATTLE_RECRUITMENT,
		SPOKEN,
		BATTLE_RULE_CHECK_TARGET,
		BATTLE_RULE_SELECT_WAIT,
		BATTLE_RULE_CHECK_MINE,
		CANCEL_MINE,
		CANCEL_OPPONENT,
		BATTLE
	}

	public int targetStationIndex;

	public BattleRecruitmentState currentState
	{
		[CompilerGenerated]
		get
		{
			return default(BattleRecruitmentState);
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

	public void SetMsgWindow()
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

	public void ChangeBattleRecruitmentState(BattleRecruitmentState state)
	{
	}

	public void ShowMessageBattleRecuruiment()
	{
	}

	private void ShowMessageSpoken()
	{
	}

	public override bool IsCancelable()
	{
		return default(bool);
	}

	public void BattleRecruitmentCancel(CancelModel cancelModel)
	{
	}

	public void BattleSpokenCancel(CancelModel cancelModel)
	{
	}

	public void TargetBattleRuleCheckCancel(CancelModel cancelModel)
	{
	}

	public void BattleRuleSelectWait(CancelModel cancelModel)
	{
	}

	public void BattleRuleCheckCancel(CancelModel cancelModel)
	{
	}

	public void CancelMine()
	{
	}

	public void CancelOpponent()
	{
	}

	public void Battle()
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

	public void ShowBattleRecruitmentYesNoMenu(int stationIndex)
	{
	}

	public void SetBattleStateWindowText(string nameTxt, BattleModeID battleModeID, MessageEnumData.MsgLangId langId)
	{
	}

	public void ShowBattleStateWindow(int index, BattleModeID battleModeID)
	{
	}

	public void HideBattleStateWindow()
	{
	}
}
