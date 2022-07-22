using System;
using System.Runtime.CompilerServices;

public class NetStateModel
{
	public enum StateModelType
	{
		RECRUITMENT,
		JOIN
	}

	public enum TradeJoinState
	{
		NONE,
		WAIT,
		CANCEL_MINE,
		CANCEL_OPPONENT,
		TRADE
	}

	public enum TradeRecruitmentState
	{
		NONE,
		TRADE_RECRUITMENT,
		SELECT,
		CANCEL_MINE,
		CANCEL_OPPONENT,
		TRADE
	}

	private Action<CancelModel> OnCancel;

	public Action OnCancelCallBack;

	public CancelModel currentCancelModel;

	public int nowStateID
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	public bool isOtherWaiting
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	public UnionMsgBattleWindow unionMsgBattleWindow
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

	public UnionBaseMsgWindow msgWindow
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

	protected virtual void Start()
	{
	}

	protected virtual void MyUpdate(float deltaTime)
	{
	}

	public void SetState(int stateID, Action<CancelModel> OnCancel, bool isOtherWaiting)
	{
	}

	public void Cancel(CancelModel model)
	{
	}

	public void SetCancelModel(CancelModel cancelModel)
	{
	}

	public bool IsOtherPlayerCheck()
	{
		return default(bool);
	}

	public virtual void OpenSwitchCancelMsg(bool isCancel)
	{
	}

	public virtual bool IsCancelable()
	{
		return default(bool);
	}
}
