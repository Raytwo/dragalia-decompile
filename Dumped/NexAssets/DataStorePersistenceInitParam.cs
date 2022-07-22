using System;
using NexPlugin;
using UnityEngine;

namespace NexAssets;

[Serializable]
public class DataStorePersistenceInitParam
{
	[SerializeField]
	private bool isPersistence;

	[SerializeField]
	private bool deleteLastObject;

	[SerializeField]
	private ushort persistenceSlotId;

	public void Validate()
	{
	}

	public NexPlugin.DataStorePersistenceInitParam GetDataStorePersistenceInitParam()
	{
		return null;
	}
}
