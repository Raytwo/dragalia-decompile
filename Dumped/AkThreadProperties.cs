using System;

public class AkThreadProperties : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public int nPriority
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public uint uStackSize
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public int iIdealCore
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public uint affinityMask
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	internal AkThreadProperties(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static IntPtr getCPtr(AkThreadProperties obj)
	{
		return default(IntPtr);
	}

	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	~AkThreadProperties()
	{
	}

	public virtual void Dispose()
	{
	}

	public AkThreadProperties()
	{
	}
}
