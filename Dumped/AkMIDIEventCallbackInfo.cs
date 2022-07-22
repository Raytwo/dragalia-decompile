using System;

public class AkMIDIEventCallbackInfo : AkEventCallbackInfo
{
	private IntPtr swigCPtr;

	public byte byChan => default(byte);

	public byte byParam1 => default(byte);

	public byte byParam2 => default(byte);

	public AkMIDIEventTypes byType => default(AkMIDIEventTypes);

	public byte byOnOffNote => default(byte);

	public byte byVelocity => default(byte);

	public AkMIDICcTypes byCc => default(AkMIDICcTypes);

	public byte byCcValue => default(byte);

	public byte byValueLsb => default(byte);

	public byte byValueMsb => default(byte);

	public byte byAftertouchNote => default(byte);

	public byte byNoteAftertouchValue => default(byte);

	public byte byChanAftertouchValue => default(byte);

	public byte byProgramNum => default(byte);

	internal AkMIDIEventCallbackInfo(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static IntPtr getCPtr(AkMIDIEventCallbackInfo obj)
	{
		return default(IntPtr);
	}

	internal override void setCPtr(IntPtr cPtr)
	{
	}

	~AkMIDIEventCallbackInfo()
	{
	}

	public override void Dispose()
	{
	}

	public AkMIDIEventCallbackInfo()
	{
	}
}
