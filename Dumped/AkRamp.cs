using System;

public class AkRamp : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public float fPrev
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public float fNext
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	internal AkRamp(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static IntPtr getCPtr(AkRamp obj)
	{
		return default(IntPtr);
	}

	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	~AkRamp()
	{
	}

	public virtual void Dispose()
	{
	}

	public AkRamp()
	{
	}

	public AkRamp(float in_fPrev, float in_fNext)
	{
	}
}
