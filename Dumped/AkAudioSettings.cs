using System;

public class AkAudioSettings : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public uint uNumSamplesPerFrame
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public uint uNumSamplesPerSecond
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	internal AkAudioSettings(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static IntPtr getCPtr(AkAudioSettings obj)
	{
		return default(IntPtr);
	}

	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	~AkAudioSettings()
	{
	}

	public virtual void Dispose()
	{
	}

	public AkAudioSettings()
	{
	}
}
