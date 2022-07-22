using System;

public class AkChannelConfig : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public uint uNumChannels
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public uint eConfigType
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public uint uChannelMask
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	internal AkChannelConfig(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static IntPtr getCPtr(AkChannelConfig obj)
	{
		return default(IntPtr);
	}

	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	~AkChannelConfig()
	{
	}

	public virtual void Dispose()
	{
	}

	public AkChannelConfig()
	{
	}

	public AkChannelConfig(uint in_uNumChannels, uint in_uChannelMask)
	{
	}

	public void Clear()
	{
	}

	public void SetStandard(uint in_uChannelMask)
	{
	}

	public void SetStandardOrAnonymous(uint in_uNumChannels, uint in_uChannelMask)
	{
	}

	public void SetAnonymous(uint in_uNumChannels)
	{
	}

	public void SetAmbisonic(uint in_uNumChannels)
	{
	}

	public bool IsValid()
	{
		return default(bool);
	}

	public uint Serialize()
	{
		return default(uint);
	}

	public void Deserialize(uint in_uChannelConfig)
	{
	}

	public AkChannelConfig RemoveLFE()
	{
		return null;
	}

	public AkChannelConfig RemoveCenter()
	{
		return null;
	}

	public bool IsChannelConfigSupported()
	{
		return default(bool);
	}
}
