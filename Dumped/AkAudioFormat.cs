using System;

public class AkAudioFormat : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

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

	public uint uBitsPerSample
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public uint uBlockAlign
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public uint uTypeID
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public uint uInterleaveID
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	internal AkAudioFormat(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static IntPtr getCPtr(AkAudioFormat obj)
	{
		return default(IntPtr);
	}

	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	~AkAudioFormat()
	{
	}

	public virtual void Dispose()
	{
	}

	public uint GetNumChannels()
	{
		return default(uint);
	}

	public uint GetBitsPerSample()
	{
		return default(uint);
	}

	public uint GetBlockAlign()
	{
		return default(uint);
	}

	public uint GetTypeID()
	{
		return default(uint);
	}

	public uint GetInterleaveID()
	{
		return default(uint);
	}

	public void SetAll(uint in_uSampleRate, AkChannelConfig in_channelConfig, uint in_uBitsPerSample, uint in_uBlockAlign, uint in_uTypeID, uint in_uInterleaveID)
	{
	}

	public bool IsChannelConfigSupported()
	{
		return default(bool);
	}

	public AkAudioFormat()
	{
	}
}
