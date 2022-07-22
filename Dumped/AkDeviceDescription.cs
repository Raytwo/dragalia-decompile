using System;

public class AkDeviceDescription : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public uint idDevice
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public string deviceName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public AkAudioDeviceState deviceStateMask
	{
		get
		{
			return default(AkAudioDeviceState);
		}
		set
		{
		}
	}

	public bool isDefaultDevice
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	internal AkDeviceDescription(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static IntPtr getCPtr(AkDeviceDescription obj)
	{
		return default(IntPtr);
	}

	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	~AkDeviceDescription()
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

	public void Clone(AkDeviceDescription other)
	{
	}

	public AkDeviceDescription()
	{
	}
}
