using System.Runtime.CompilerServices;
using Dpr.MsgWindow;

public class UnionMsgRecodeWindow : UnionBaseMsgWindow
{
	public enum RecodeMsgState
	{
		ISRECODE,
		RECODE_BOY,
		RECODE_GIRL,
		SORRY_BOY,
		SORRY_GIRL,
		CAMCEL,
		CAMCEL_BOY,
		CAMCEL_GIRL,
		RECODE_START,
		RECODE_READY_OK_BOY,
		RECODE_READY_OK_GIRL,
		NONE
	}

	public int index;

	public RecodeMsgState _currentState
	{
		[CompilerGenerated]
		get
		{
			return default(RecodeMsgState);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public override void Init()
	{
	}

	public void OpenMsgWindow(RecodeMsgState state, UnionTextData.SpeakerID speakerID = UnionTextData.SpeakerID.SYSTEM)
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
