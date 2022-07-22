using System.Runtime.CompilerServices;
using Dpr.MsgWindow;

public class UnionMsgBallDecoWindow : UnionBaseMsgWindow
{
	public enum BallDecoMsgState
	{
		ISBALLDECO,
		BALLDECO_BOY,
		BALLDECO_GIRL,
		SORRY_BOY,
		SORRY_GIRL,
		CAMCEL,
		CAMCEL_BOY,
		CAMCEL_GIRL,
		BALLDECO_START,
		BALLDECO_READY_OK_BOY,
		BALLDECO_READY_OK_GIRL,
		NONE
	}

	public int index;

	public BallDecoMsgState _currentState
	{
		[CompilerGenerated]
		get
		{
			return default(BallDecoMsgState);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public override void Init()
	{
	}

	public void OpenMsgWindow(BallDecoMsgState state, UnionTextData.SpeakerID speakerID = UnionTextData.SpeakerID.SYSTEM)
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
