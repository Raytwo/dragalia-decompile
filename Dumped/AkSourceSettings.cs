using System;

public class AkSourceSettings : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public uint sourceID
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public IntPtr pMediaMemory
	{
		get
		{
			return default(IntPtr);
		}
		set
		{
		}
	}

	public uint uMediaSize
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	internal AkSourceSettings(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static IntPtr getCPtr(AkSourceSettings obj)
	{
		return default(IntPtr);
	}

	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	~AkSourceSettings()
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

	public void Clone(AkSourceSettings other)
	{
	}

	public AkSourceSettings()
	{
	}
}
