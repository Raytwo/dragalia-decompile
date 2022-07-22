using System;

public class AkCallbackSerializer : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	internal AkCallbackSerializer(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static IntPtr getCPtr(AkCallbackSerializer obj)
	{
		return default(IntPtr);
	}

	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	~AkCallbackSerializer()
	{
	}

	public virtual void Dispose()
	{
	}

	public static AKRESULT Init(IntPtr in_pMemory, uint in_uSize)
	{
		return default(AKRESULT);
	}

	public static void Term()
	{
	}

	public static IntPtr Lock()
	{
		return default(IntPtr);
	}

	public static void Unlock()
	{
	}

	public static void SetLocalOutput(uint in_uErrorLevel)
	{
	}

	public static AKRESULT AudioSourceChangeCallbackFunc(bool in_bOtherAudioPlaying, object in_pCookie)
	{
		return default(AKRESULT);
	}

	public AkCallbackSerializer()
	{
	}
}
