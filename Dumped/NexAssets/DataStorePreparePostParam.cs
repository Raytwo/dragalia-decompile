using System;
using System.Collections.Generic;
using NexPlugin;
using UnityEngine;

namespace NexAssets;

[Serializable]
public class DataStorePreparePostParam
{
	[SerializeField]
	private string name;

	[SerializeField]
	private List<string> tags;

	[SerializeField]
	private ushort period;

	[SerializeField]
	private ushort dataType;

	[SerializeField]
	private DataStore.DataFlag dataFlag;

	[SerializeField]
	private DataStore.Permission accessPermission;

	[SerializeField]
	private DataStore.Permission updatePermission;

	[SerializeField]
	private DataStorePersistenceInitParam persistenceInitParam;

	[SerializeField]
	private List<DataStoreRatingInitParam> dataStoreRatingInitParamList;

	public void Validate()
	{
	}

	public NexPlugin.DataStorePreparePostParam GetDataStorePreparePostParam()
	{
		return null;
	}
}
