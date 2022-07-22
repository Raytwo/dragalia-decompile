namespace NexPlugin;

public class DataStoreRatingLockInitParam
{
	internal DataStore.RatingLockType lockType;

	internal short periodDuration;

	internal sbyte periodHour;

	private void Reset()
	{
	}

	public void SetIntervalLock(short intervalSec)
	{
	}

	public void SetPeriodicLock(DataStore.RatingLockPeriod period, sbyte hour)
	{
	}

	public void SetDaysAfterLock(short days, sbyte hour)
	{
	}

	public void SetPermanentLock()
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
