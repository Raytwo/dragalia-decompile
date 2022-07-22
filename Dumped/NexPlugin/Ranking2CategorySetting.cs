namespace NexPlugin;

public class Ranking2CategorySetting
{
	internal uint minScore;

	internal uint maxScore;

	internal ushort lowestRank;

	internal byte maxSeasonsToGoBack;

	internal byte resetMode;

	internal byte resetHour;

	internal byte resetDay;

	internal ushort resetMonth;

	internal bool scoreOrder;

	public uint GetMinScore()
	{
		return default(uint);
	}

	public uint GetMaxScore()
	{
		return default(uint);
	}

	public bool GetScoreOrder()
	{
		return default(bool);
	}

	public uint GetLowestRank()
	{
		return default(uint);
	}

	public byte GetMaxSeasonsToGoBack()
	{
		return default(byte);
	}

	public byte GetResetMode()
	{
		return default(byte);
	}

	public byte GetResetHour()
	{
		return default(byte);
	}

	public byte GetResetDay()
	{
		return default(byte);
	}

	public ushort GetResetMonth()
	{
		return default(ushort);
	}

	public void Trace()
	{
	}

	public override string ToString()
	{
		return null;
	}
}
