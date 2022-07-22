using System;

public class AkMarkerCallbackInfo : AkEventCallbackInfo
{
	private IntPtr swigCPtr;

	public uint uIdentifier => default(uint);

	public uint uPosition => default(uint);

	public string strLabel => null;

	internal AkMarkerCallbackInfo(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static IntPtr getCPtr(AkMarkerCallbackInfo obj)
	{
		return default(IntPtr);
	}

	internal override void setCPtr(IntPtr cPtr)
	{
	}

	~AkMarkerCallbackInfo()
	{
	}

	public override void Dispose()
	{
	}

	public AkMarkerCallbackInfo()
	{
	}
}
