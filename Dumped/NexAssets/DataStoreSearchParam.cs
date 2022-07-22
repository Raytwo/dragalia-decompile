using System;
using System.Collections.Generic;
using NexPlugin;
using UnityEngine;

namespace NexAssets;

[Serializable]
public class DataStoreSearchParam
{
	[SerializeField]
	private DataStore.SearchType searchTarget;

	[SerializeField]
	private DataStore.SearchTarget ownerType;

	[SerializeField]
	private List<ushort> dataTypes;

	[SerializeField]
	private DataStore.SearchSortColumn resultOrderColumn;

	[SerializeField]
	private DataStore.SearchSortOrder resultOrder;

	[SerializeField]
	private ResultRange resultRange;

	[SerializeField]
	private DataStore.ResultFlag resultOption;

	[SerializeField]
	private List<string> tags;

	[SerializeField]
	private uint minimalRatingFrequency;

	[SerializeField]
	private bool totalCountEnabled;

	[SerializeField]
	private bool useCache;

	public void Validate()
	{
	}

	public NexPlugin.DataStoreSearchParam GetDataStoreSearchParam(bool isSearchLight = false)
	{
		return null;
	}
}
