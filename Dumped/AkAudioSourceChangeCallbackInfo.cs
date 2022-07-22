using System;

public class AkAudioSourceChangeCallbackInfo : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public bool bOtherAudioPlaying => default(bool);

	internal AkAudioSourceChangeCallbackInfo(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static IntPtr getCPtr(AkAudioSourceChangeCallbackInfo obj)
	{
		return default(IntPtr);
	}

	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	~AkAudioSourceChangeCallbackInfo()
	{
	}

	public virtual void Dispose()
	{
	}

	public AkAudioSourceChangeCallbackInfo()
	{
	}
}
