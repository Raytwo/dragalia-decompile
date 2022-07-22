using System.Runtime.CompilerServices;

public class UnionMsgGreetingsWindow : UnionBaseMsgWindow
{
	public enum GreetingsMsgState
	{
		ISGREETINGS,
		GREETINGS_BOY,
		GREETINGS_GIRL,
		SORRY_BOY,
		SORRY_GIRL,
		CAMCEL,
		CAMCEL_BOY,
		CAMCEL_GIRL,
		GREETINGS_START,
		GREETINGS_READY_OK_BOY,
		GREETINGS_READY_OK_GIRL,
		NONE
	}

	public int index;

	public GreetingsMsgState _currentState
	{
		[CompilerGenerated]
		get
		{
			return default(GreetingsMsgState);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public override void Init()
	{
	}

	public void OpenMsgWindow(GreetingsMsgState state, UnionTextData.SpeakerID speakerID = UnionTextData.SpeakerID.SYSTEM)
	{
	}

	public void CloseMsgWindow()
	{
	}

	public bool GetIsFinishMessage()
	{
		return default(bool);
	}

	private void SetMessages()
	{
	}
}
