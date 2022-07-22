using System;

public class AkSerializedCallbackHeader : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public IntPtr pPackage => default(IntPtr);

	public AkSerializedCallbackHeader pNext => null;

	public AkCallbackType eType => default(AkCallbackType);

	internal AkSerializedCallbackHeader(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static IntPtr getCPtr(AkSerializedCallbackHeader obj)
	{
		return default(IntPtr);
	}

	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	~AkSerializedCallbackHeader()
	{
	}

	public virtual void Dispose()
	{
	}

	public IntPtr GetData()
	{
		return default(IntPtr);
	}

	public AkSerializedCallbackHeader()
	{
	}
}
