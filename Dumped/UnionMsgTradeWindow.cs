using System.Runtime.CompilerServices;
using Dpr.MsgWindow;

public class UnionMsgTradeWindow : UnionBaseMsgWindow
{
	public enum TradeMsgState
	{
		ISTRADE,
		TRADE_BOY,
		TRADE_GIRL,
		SORRY_BOY,
		SORRY_GIRL,
		CAMCEL,
		CAMCEL_BOY,
		CAMCEL_GIRL,
		TRADE_START,
		TRADE_READY_OK_BOY,
		TRADE_READY_OK_GIRL,
		NONE
	}

	public int index;

	public TradeMsgState _currentState
	{
		[CompilerGenerated]
		get
		{
			return default(TradeMsgState);
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

	private void SetMessages()
	{
	}
}
