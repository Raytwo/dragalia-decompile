using System;

public class AkTaskContext : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public uint uIdxThread
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	internal AkTaskContext(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static IntPtr getCPtr(AkTaskContext obj)
	{
		return default(IntPtr);
	}

	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	~AkTaskContext()
	{
	}

	public virtual void Dispose()
	{
	}

	public AkTaskContext()
	{
	}
}
