using System;
using System.Runtime.CompilerServices;

public abstract class AkBaseArray<T> : IDisposable
{
	private IntPtr m_Buffer;

	public int Capacity
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	protected abstract int StructureSize { get; }

	public T this[int index]
	{
		get
		{
			return (T)null;
		}
		set
		{
		}
	}

	public AkBaseArray(int capacity)
	{
	}

	public void Dispose()
	{
	}

	~AkBaseArray()
	{
	}

	public virtual int Count()
	{
		return default(int);
	}

	protected virtual void DefaultConstructAtIntPtr(IntPtr address)
	{
	}

	protected virtual void ReleaseAllocatedMemoryFromReferenceAtIntPtr(IntPtr address)
	{
	}

	protected abstract T CreateNewReferenceFromIntPtr(IntPtr address);

	protected abstract void CloneIntoReferenceFromIntPtr(IntPtr address, T other);

	public IntPtr GetBuffer()
	{
		return default(IntPtr);
	}

	protected IntPtr GetObjectPtr(int index)
	{
		return default(IntPtr);
	}
}
