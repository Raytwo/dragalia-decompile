using System;

public class AkMusicPlaylistCallbackInfo : AkEventCallbackInfo
{
	private IntPtr swigCPtr;

	public uint playlistID => default(uint);

	public uint uNumPlaylistItems => default(uint);

	public uint uPlaylistSelection => default(uint);

	public uint uPlaylistItemDone => default(uint);

	internal AkMusicPlaylistCallbackInfo(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static IntPtr getCPtr(AkMusicPlaylistCallbackInfo obj)
	{
		return default(IntPtr);
	}

	internal override void setCPtr(IntPtr cPtr)
	{
	}

	~AkMusicPlaylistCallbackInfo()
	{
	}

	public override void Dispose()
	{
	}

	public AkMusicPlaylistCallbackInfo()
	{
	}
}
