using System;
using System.Collections.Generic;
using NexPlugin;
using UnityEngine;

namespace NexAssets;

[Serializable]
public class DataStoreChangeMetaCompareParam
{
	[SerializeField]
	private DataStore.ComparisonFlag comparisonFlag;

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

	public void Validate()
	{
	}

	public NexPlugin.DataStoreChangeMetaCompareParam GetDataStoreChangeMetaCompareParam()
	{
		return null;
	}
}
