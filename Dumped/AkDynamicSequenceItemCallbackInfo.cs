using System;

public class AkDynamicSequenceItemCallbackInfo : AkCallbackInfo
{
	private IntPtr swigCPtr;

	public uint playingID => default(uint);

	public uint audioNodeID => default(uint);

	public IntPtr pCustomInfo => default(IntPtr);

	internal AkDynamicSequenceItemCallbackInfo(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static IntPtr getCPtr(AkDynamicSequenceItemCallbackInfo obj)
	{
		return default(IntPtr);
	}

	internal override void setCPtr(IntPtr cPtr)
	{
	}

	~AkDynamicSequenceItemCallbackInfo()
	{
	}

	public override void Dispose()
	{
	}

	public AkDynamicSequenceItemCallbackInfo()
	{
	}
}
