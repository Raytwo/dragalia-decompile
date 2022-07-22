using System;

public class AkChannelEmitter : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public AkTransform position
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public uint uInputChannels
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	internal AkChannelEmitter(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static IntPtr getCPtr(AkChannelEmitter obj)
	{
		return default(IntPtr);
	}

	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	~AkChannelEmitter()
	{
	}

	public virtual void Dispose()
	{
	}
}
