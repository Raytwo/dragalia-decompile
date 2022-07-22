using System;

public class AkDurationCallbackInfo : AkEventCallbackInfo
{
	private IntPtr swigCPtr;

	public float fDuration => default(float);

	public float fEstimatedDuration => default(float);

	public uint audioNodeID => default(uint);

	public uint mediaID => default(uint);

	public bool bStreaming => default(bool);

	internal AkDurationCallbackInfo(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static IntPtr getCPtr(AkDurationCallbackInfo obj)
	{
		return default(IntPtr);
	}

	internal override void setCPtr(IntPtr cPtr)
	{
	}

	~AkDurationCallbackInfo()
	{
	}

	public override void Dispose()
	{
	}

	public AkDurationCallbackInfo()
	{
	}
}
