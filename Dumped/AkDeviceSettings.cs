using System;

public class AkDeviceSettings : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public IntPtr pIOMemory
	{
		get
		{
			return default(IntPtr);
		}
		set
		{
		}
	}

	public uint uIOMemorySize
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public uint uIOMemoryAlignment
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public uint ePoolAttributes
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public uint uGranularity
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public uint uSchedulerTypeFlags
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public AkThreadProperties threadProperties
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public float fTargetAutoStmBufferLength
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public uint uMaxConcurrentIO
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public bool bUseStreamCache
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public uint uMaxCachePinnedBytes
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	internal AkDeviceSettings(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static IntPtr getCPtr(AkDeviceSettings obj)
	{
		return default(IntPtr);
	}

	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	~AkDeviceSettings()
	{
	}

	public virtual void Dispose()
	{
	}
}
