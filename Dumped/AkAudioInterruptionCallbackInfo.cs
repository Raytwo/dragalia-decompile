using System;

public class AkAudioInterruptionCallbackInfo : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public bool bEnterInterruption => default(bool);

	internal AkAudioInterruptionCallbackInfo(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static IntPtr getCPtr(AkAudioInterruptionCallbackInfo obj)
	{
		return default(IntPtr);
	}

	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	~AkAudioInterruptionCallbackInfo()
	{
	}

	public virtual void Dispose()
	{
	}

	public AkAudioInterruptionCallbackInfo()
	{
	}
}
