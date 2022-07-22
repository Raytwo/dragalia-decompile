using System;
using System.Collections.Generic;
using NexPlugin;
using UnityEngine;

namespace NexAssets;

[Serializable]
public class DataStoreChangeMetaParam
{
	[SerializeField]
	private DataStore.ModificationFlag modificationFlag;

	[SerializeField]
	private DataStore.DataStatus dataStatus;

	[SerializeField]
	private string name;

	[SerializeField]
	private List<string> tags;

	[SerializeField]
	private ushort period;

	[SerializeField]
	private ushort dataType;

	[SerializeField]
	private DataStore.Permission accessPermission;

	[SerializeField]
	private DataStore.Permission updatePermission;

	[SerializeField]
	private bool isUsePersistenceSlotId;

	[SerializeField]
	private ushort persistenceSlotId;

	[SerializeField]
	private string dataId;

	private ulong dataId_;

	[SerializeField]
	private DataStoreChangeMetaCompareParam dataStoreChangeMetaCompareParam;

	public void Validate()
	{
	}

	public NexPlugin.DataStoreChangeMetaParam GetDataStoreChangeMetaParam()
	{
		return null;
	}
}
