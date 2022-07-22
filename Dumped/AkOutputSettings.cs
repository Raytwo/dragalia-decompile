using System;

public class AkOutputSettings : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public uint audioDeviceShareset
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

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

	public AkPanningRule ePanningRule
	{
		get
		{
			return default(AkPanningRule);
		}
		set
		{
		}
	}

	public AkChannelConfig channelConfig
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal AkOutputSettings(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static IntPtr getCPtr(AkOutputSettings obj)
	{
		return default(IntPtr);
	}

	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	~AkOutputSettings()
	{
	}

	public virtual void Dispose()
	{
	}

	public AkOutputSettings()
	{
	}

	public AkOutputSettings(string in_szDeviceShareSet, uint in_idDevice, AkChannelConfig in_channelConfig, AkPanningRule in_ePanning)
	{
	}

	public AkOutputSettings(string in_szDeviceShareSet, uint in_idDevice, AkChannelConfig in_channelConfig)
	{
	}

	public AkOutputSettings(string in_szDeviceShareSet, uint in_idDevice)
	{
	}

	public AkOutputSettings(string in_szDeviceShareSet)
	{
	}
}
