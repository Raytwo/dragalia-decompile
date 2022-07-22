namespace NexPlugin;

public struct RankingStats
{
	internal double total;

	internal double sum;

	internal double min;

	internal double max;

	internal double avr;

	public double GetValue(Ranking.StatsFlag flag)
	{
		return default(double);
	}

	public void Trace()
	{
	}

	public override string ToString()
	{
		return null;
	}
}
