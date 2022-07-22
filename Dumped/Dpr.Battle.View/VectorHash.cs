using System;
using System.Collections.Generic;

namespace Dpr.Battle.View;

public class VectorHash<TKey, TElement> : IDisposable
{
	private Dictionary<TKey, HashSet<TElement>> _elements;

	public Dictionary<TKey, HashSet<TElement>> RawElements => null;

	public VectorHash(int capacity = 0)
	{
	}

	public void Dispose()
	{
	}

	public void CreateVector(TKey key, HashSet<TElement> elements)
	{
	}

	public bool DeleteVector(TKey key)
	{
		return default(bool);
	}

	public void DeleteAllVector()
	{
	}

	public void AddVector(TKey key, HashSet<TElement> elements)
	{
	}

	public bool HasVector(TKey key)
	{
		return default(bool);
	}

	public HashSet<TElement> GetVector(TKey key)
	{
		return null;
	}

	public bool TryGetVector(TKey key, out HashSet<TElement> value)
	{
		return default(bool);
	}
}
