using System;

public class AkObjectInfo : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public uint objID
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public uint parentID
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public int iDepth
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	internal AkObjectInfo(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static IntPtr getCPtr(AkObjectInfo obj)
	{
		return default(IntPtr);
	}

	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	~AkObjectInfo()
	{
	}

	public virtual void Dispose()
	{
	}

	public void Clear()
	{
	}

	public static int GetSizeOf()
	{
		return default(int);
	}

	public void Clone(AkObjectInfo other)
	{
	}

	public AkObjectInfo()
	{
	}
}
