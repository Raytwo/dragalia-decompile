using System;

public class AkBankCallbackInfo : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public uint bankID => default(uint);

	public IntPtr inMemoryBankPtr => default(IntPtr);

	public AKRESULT loadResult => default(AKRESULT);

	internal AkBankCallbackInfo(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static IntPtr getCPtr(AkBankCallbackInfo obj)
	{
		return default(IntPtr);
	}

	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	~AkBankCallbackInfo()
	{
	}

	public virtual void Dispose()
	{
	}

	public AkBankCallbackInfo()
	{
	}
}
