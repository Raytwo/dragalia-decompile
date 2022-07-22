using System;

public class AkPlaylist : AkPlaylistArray
{
	private IntPtr swigCPtr;

	internal AkPlaylist(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static IntPtr getCPtr(AkPlaylist obj)
	{
		return default(IntPtr);
	}

	internal override void setCPtr(IntPtr cPtr)
	{
	}

	~AkPlaylist()
	{
	}

	public override void Dispose()
	{
	}

	public AKRESULT Enqueue(uint in_audioNodeID, int in_msDelay, IntPtr in_pCustomInfo, uint in_cExternals, AkExternalSourceInfoArray in_pExternalSources)
	{
		return default(AKRESULT);
	}

	public AKRESULT Enqueue(uint in_audioNodeID, int in_msDelay, IntPtr in_pCustomInfo, uint in_cExternals)
	{
		return default(AKRESULT);
	}

	public AKRESULT Enqueue(uint in_audioNodeID, int in_msDelay, IntPtr in_pCustomInfo)
	{
		return default(AKRESULT);
	}

	public AKRESULT Enqueue(uint in_audioNodeID, int in_msDelay)
	{
		return default(AKRESULT);
	}

	public AKRESULT Enqueue(uint in_audioNodeID)
	{
		return default(AKRESULT);
	}

	public AkPlaylist()
	{
	}
}
