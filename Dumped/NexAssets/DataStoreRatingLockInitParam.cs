using System;
using NexPlugin;
using UnityEngine;

namespace NexAssets;

[Serializable]
public class DataStoreRatingLockInitParam
{
	[SerializeField]
	private RatingLockType ratingLockType;

	[SerializeField]
	private short periodDuration;

	[SerializeField]
	private DataStore.RatingLockPeriod periodDurationFlag;

	[SerializeField]
	private sbyte periodHour;

	[SerializeField]
	private short periodDays;

	public NexPlugin.DataStoreRatingLockInitParam GetDataStoreRatingLockInitParam()
	{
		return null;
	}
}
