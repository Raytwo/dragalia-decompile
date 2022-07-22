using System.Collections.Generic;
using UnityEngine;

namespace Dpr.Contest;

public class ObjectPoolSystem<T> where T : Component, IPoolObject
{
	private T prefab;

	private Transform parent;

	private List<T> prefabPool;

	public int PoolCount => default(int);

	public List<T> PrefabPoolList => null;

	~ObjectPoolSystem()
	{
	}

	public void GeneratePoolFromPrefab(T prefab, int count)
	{
	}

	public void GeneratePoolFromPrefab(T prefab, int count, Transform parent)
	{
	}

	public int SetPoolCount(int count)
	{
		return default(int);
	}

	public T AddPoolFromPrefab(T prefab)
	{
		return null;
	}

	public T Get()
	{
		return null;
	}

	public T GetCurrentlyUsed()
	{
		return null;
	}

	public List<T> GetAllCurrentlyUsed()
	{
		return null;
	}

	public List<T> GetAllDeactived()
	{
		return null;
	}

	public void RemoveFromPool(T prefab)
	{
	}

	public void RemoveAllNullElement()
	{
	}

	public void DeactivateAll()
	{
	}

	public void ClearPool()
	{
	}
}
