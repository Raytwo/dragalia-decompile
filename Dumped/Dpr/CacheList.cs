using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Dpr;

public class CacheList<T> where T : class
{
	private List<T> _caches;

	private int _num;

	public List<T> caches => null;

	public int maxNum => default(int);

	public T this[int i] => null;

	public CacheList(int num)
	{
	}

	public void Add(T item)
	{
	}

	public void Remove(T item)
	{
	}

	public T Find(Func<T, bool> onCompare)
	{
		return null;
	}

	public void MoveLast(T item, [Optional] Func<T, bool> onRemove)
	{
	}

	public void Clear([Optional] Action<T> onRemove)
	{
	}

	public void Reset(int num = 0, [Optional] Action<T> onRemove)
	{
	}

	public int Count()
	{
		return default(int);
	}
}
