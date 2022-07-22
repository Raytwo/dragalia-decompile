using System.Runtime.CompilerServices;
using Dpr.MsgWindow;

public class UnionMsgBattleWindow : UnionBaseMsgWindow
{
	public enum BattleMsgState
	{
		ISBATTLE,
		BATTLE_BOY,
		BATTLE_GIRL,
		TARGET_SELECT_WAIT,
		SORRY_BOY,
		SORRY_GIRL,
		CAMCEL,
		CAMCEL_BOY,
		CAMCEL_GIRL,
		BATTLE_START,
		BATTLE_READY_OK_BOY,
		BATTLE_READY_OK_GIRL,
		NONE
	}

	public int index;

	public BattleMsgState _currentState
	{
		[CompilerGenerated]
		get
		{
			return default(BattleMsgState);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public OnlinePlayerCharacter onlinePlayer
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

	public new int sexId
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

	public override void Init()
	{
	}

	public void CloseMsgWindow()
	{
	}

	public new MsgWindowParam GetNowMessage()
	{
		return null;
	}

	public bool GetIsFinishMessage()
	{
		return default(bool);
	}

	public void OpenSwitchMsg(int sexId)
	{
	}

	public void OpenSwitchFadeMsg(int sexId)
	{
	}

	private void SetMessages()
	{
	}
}
