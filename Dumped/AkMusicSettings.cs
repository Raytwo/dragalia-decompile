using System;

public class AkMusicSettings : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public float fStreamingLookAheadRatio
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	internal AkMusicSettings(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static IntPtr getCPtr(AkMusicSettings obj)
	{
		return default(IntPtr);
	}

	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	~AkMusicSettings()
	{
	}

	public virtual void Dispose()
	{
	}
}
