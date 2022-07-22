namespace NexPlugin;

public class DataStoreRatingInitParam
{
	internal long initialValue;

	internal int rangeMin;

	internal int rangeMax;

	internal DataStore.RatingFlag flag;

	internal DataStore.RatingInternalFlag internalFlag;

	internal DataStore.RatingLockType lockType;

	internal short periodDuration;

	internal sbyte periodHour;

	internal sbyte slot;

	public void SetInitialValue(long initialValue_)
	{
	}

	public void SetRangeMin(int min_)
	{
	}

	public void SetRangeMax(int max)
	{
	}

	public void SetLock(DataStoreRatingLockInitParam ratingLockInitParam)
	{
	}

	public void SetFlag(DataStore.RatingFlag flag_)
	{
	}

	public void Reset()
	{
	}

	public void Trace()
	{
	}

	public override string ToString()
	{
		return null;
	}
}
