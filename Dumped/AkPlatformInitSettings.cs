using System;

public class AkPlatformInitSettings : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public AkThreadProperties threadLEngine
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public AkThreadProperties threadOutputMgr
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public AkThreadProperties threadBankManager
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public AkThreadProperties threadMonitor
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public AkThreadProperties threadOpusDecoder
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public uint uSampleRate
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public ushort uNumRefillsInVoice
	{
		get
		{
			return default(ushort);
		}
		set
		{
		}
	}

	public bool bAutoPanningRule
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	internal AkPlatformInitSettings(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static IntPtr getCPtr(AkPlatformInitSettings obj)
	{
		return default(IntPtr);
	}

	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	~AkPlatformInitSettings()
	{
	}

	public virtual void Dispose()
	{
	}
}
