using System;

public class AkMonitoringCallbackInfo : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public AkMonitorErrorCode errorCode => default(AkMonitorErrorCode);

	public AkMonitorErrorLevel errorLevel => default(AkMonitorErrorLevel);

	public uint playingID => default(uint);

	public ulong gameObjID => default(ulong);

	public string message => null;

	internal AkMonitoringCallbackInfo(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static IntPtr getCPtr(AkMonitoringCallbackInfo obj)
	{
		return default(IntPtr);
	}

	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	~AkMonitoringCallbackInfo()
	{
	}

	public virtual void Dispose()
	{
	}

	public AkMonitoringCallbackInfo()
	{
	}
}
