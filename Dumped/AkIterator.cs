using System;

public class AkIterator : IDisposable
{
	private IntPtr swigCPtr;

	protected bool swigCMemOwn;

	public AkPlaylistItem pItem
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal AkIterator(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static IntPtr getCPtr(AkIterator obj)
	{
		return default(IntPtr);
	}

	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	~AkIterator()
	{
	}

	public virtual void Dispose()
	{
	}

	public AkIterator NextIter()
	{
		return null;
	}

	public AkIterator PrevIter()
	{
		return null;
	}

	public AkPlaylistItem GetItem()
	{
		return null;
	}

	public bool IsEqualTo(AkIterator in_rOp)
	{
		return default(bool);
	}

	public bool IsDifferentFrom(AkIterator in_rOp)
	{
		return default(bool);
	}

	public AkIterator()
	{
	}
}
