using System;

public class AkMusicSyncCallbackInfo : AkCallbackInfo
{
	private IntPtr swigCPtr;

	public uint playingID => default(uint);

	public int segmentInfo_iCurrentPosition => default(int);

	public int segmentInfo_iPreEntryDuration => default(int);

	public int segmentInfo_iActiveDuration => default(int);

	public int segmentInfo_iPostExitDuration => default(int);

	public int segmentInfo_iRemainingLookAheadTime => default(int);

	public float segmentInfo_fBeatDuration => default(float);

	public float segmentInfo_fBarDuration => default(float);

	public float segmentInfo_fGridDuration => default(float);

	public float segmentInfo_fGridOffset => default(float);

	public AkCallbackType musicSyncType => default(AkCallbackType);

	public string userCueName => null;

	internal AkMusicSyncCallbackInfo(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static IntPtr getCPtr(AkMusicSyncCallbackInfo obj)
	{
		return default(IntPtr);
	}

	internal override void setCPtr(IntPtr cPtr)
	{
	}

	~AkMusicSyncCallbackInfo()
	{
	}

	public override void Dispose()
	{
	}

	public AkMusicSyncCallbackInfo()
	{
	}
}
