using System;

public class AkPlaylistItem : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public uint audioNodeID
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public int msDelay
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public IntPtr pCustomInfo
	{
		get
		{
			return default(IntPtr);
		}
		set
		{
		}
	}

	internal AkPlaylistItem(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static IntPtr getCPtr(AkPlaylistItem obj)
	{
		return default(IntPtr);
	}

	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	~AkPlaylistItem()
	{
	}

	public virtual void Dispose()
	{
	}

	public AkPlaylistItem()
	{
	}

	public AkPlaylistItem(AkPlaylistItem in_rCopy)
	{
	}

	public AkPlaylistItem Assign(AkPlaylistItem in_rCopy)
	{
		return null;
	}

	public bool IsEqualTo(AkPlaylistItem in_rCopy)
	{
		return default(bool);
	}

	public AKRESULT SetExternalSources(uint in_nExternalSrc, AkExternalSourceInfoArray in_pExternalSrc)
	{
		return default(AKRESULT);
	}
}
