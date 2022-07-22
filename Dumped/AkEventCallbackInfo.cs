using System;

public class AkEventCallbackInfo : AkCallbackInfo
{
	private IntPtr swigCPtr;

	public uint playingID => default(uint);

	public uint eventID => default(uint);

	internal AkEventCallbackInfo(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static IntPtr getCPtr(AkEventCallbackInfo obj)
	{
		return default(IntPtr);
	}

	internal override void setCPtr(IntPtr cPtr)
	{
	}

	~AkEventCallbackInfo()
	{
	}

	public override void Dispose()
	{
	}

	public AkEventCallbackInfo()
	{
	}
}
