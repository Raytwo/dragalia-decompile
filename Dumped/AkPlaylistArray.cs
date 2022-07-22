using System;

public class AkPlaylistArray : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	internal AkPlaylistArray(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static IntPtr getCPtr(AkPlaylistArray obj)
	{
		return default(IntPtr);
	}

	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	~AkPlaylistArray()
	{
	}

	public virtual void Dispose()
	{
	}

	public AkPlaylistArray()
	{
	}

	public AkIterator Begin()
	{
		return null;
	}

	public AkIterator End()
	{
		return null;
	}

	public AkIterator FindEx(AkPlaylistItem in_Item)
	{
		return null;
	}

	public AkIterator Erase(AkIterator in_rIter)
	{
		return null;
	}

	public void Erase(uint in_uIndex)
	{
	}

	public AkIterator EraseSwap(AkIterator in_rIter)
	{
		return null;
	}

	public bool IsGrowingAllowed()
	{
		return default(bool);
	}

	public AKRESULT Reserve(uint in_ulReserve)
	{
		return default(AKRESULT);
	}

	public uint Reserved()
	{
		return default(uint);
	}

	public void Term()
	{
	}

	public uint Length()
	{
		return default(uint);
	}

	public AkPlaylistItem Data()
	{
		return null;
	}

	public bool IsEmpty()
	{
		return default(bool);
	}

	public AkPlaylistItem Exists(AkPlaylistItem in_Item)
	{
		return null;
	}

	public AkPlaylistItem AddLast()
	{
		return null;
	}

	public AkPlaylistItem AddLast(AkPlaylistItem in_rItem)
	{
		return null;
	}

	public AkPlaylistItem Last()
	{
		return null;
	}

	public void RemoveLast()
	{
	}

	public AKRESULT Remove(AkPlaylistItem in_rItem)
	{
		return default(AKRESULT);
	}

	public AKRESULT RemoveSwap(AkPlaylistItem in_rItem)
	{
		return default(AKRESULT);
	}

	public void RemoveAll()
	{
	}

	public AkPlaylistItem ItemAtIndex(uint uiIndex)
	{
		return null;
	}

	public AkPlaylistItem Insert(uint in_uIndex)
	{
		return null;
	}

	public bool GrowArray()
	{
		return default(bool);
	}

	public bool GrowArray(uint in_uGrowBy)
	{
		return default(bool);
	}

	public bool Resize(uint in_uiSize)
	{
		return default(bool);
	}

	public void Transfer(AkPlaylistArray in_rSource)
	{
	}

	public AKRESULT Copy(AkPlaylistArray in_rSource)
	{
		return default(AKRESULT);
	}
}
