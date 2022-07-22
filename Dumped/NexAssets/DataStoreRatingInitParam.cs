using System;
using NexPlugin;
using UnityEngine;

namespace NexAssets;

[Serializable]
public class DataStoreRatingInitParam
{
	[SerializeField]
	private sbyte slot;

	[SerializeField]
	private long initialValue;

	[SerializeField]
	private int rangeMin;

	[SerializeField]
	private int rangeMax;

	[SerializeField]
	private DataStore.RatingFlag flag;

	[SerializeField]
	private bool isUseMin;

	[SerializeField]
	private bool isUseMax;

	[SerializeField]
	private DataStoreRatingLockInitParam dataStoreRatingLockInitParam;

	public sbyte GetSlot()
	{
		return default(sbyte);
	}

	public NexPlugin.DataStoreRatingInitParam GetDataStoreRatingInitParam()
	{
		return null;
	}
}
