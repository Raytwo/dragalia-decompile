using System.Collections.Generic;
using UnityEngine;

public class ObjectPool<TKey, TValue> where TValue : IObjectPoolInstance, new()
{
	public class Param
	{
		public GameObject _prefab;

		public Transform _parentTransform;

		public List<TValue> _values;
	}

	public Dictionary<TKey, Param> _dict;

	public void Instantiates(int count, TKey key, GameObject prefab, Transform parentTransform)
	{
	}

	public bool Destroies(TKey key)
	{
		return default(bool);
	}

	public TValue Create(TKey key, bool isActived = true)
	{
		return (TValue)null;
	}

	public bool Release(TKey key, TValue value, bool isForceDelete = false)
	{
		return default(bool);
	}
}
