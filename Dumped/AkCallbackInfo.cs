using System;

public class AkCallbackInfo : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public IntPtr pCookie => default(IntPtr);

	public ulong gameObjID => default(ulong);

	internal AkCallbackInfo(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static IntPtr getCPtr(AkCallbackInfo obj)
	{
		return default(IntPtr);
	}

	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	~AkCallbackInfo()
	{
	}

	public virtual void Dispose()
	{
	}

	public AkCallbackInfo()
	{
	}
}
