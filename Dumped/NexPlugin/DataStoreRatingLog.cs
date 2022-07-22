namespace NexPlugin;

public class DataStoreRatingLog
{
	internal NpDateTime lockExpirationTime;

	internal ulong pid;

	internal int ratingValue;

	internal bool isRated;

	public bool IsRated()
	{
		return default(bool);
	}

	public ulong GetPrincipalId()
	{
		return default(ulong);
	}

	public int GetRatingValue()
	{
		return default(int);
	}

	public NpDateTime GetLockExpirationTime()
	{
		return default(NpDateTime);
	}

	public void Trace()
	{
	}

	public override string ToString()
	{
		return null;
	}
}
