namespace NexPlugin;

public class RankingOrderParam
{
	internal Ranking.OrderCalculation orderCalculation;

	internal Ranking.FilterGroupIndex groupIndex;

	internal byte groupNum;

	internal Ranking.TimeScope timeScope;

	internal uint offset;

	internal byte length;

	public void SetOrderCalculation(Ranking.OrderCalculation orderCalculation_)
	{
	}

	public Ranking.OrderCalculation GetOrderCalculation()
	{
		return default(Ranking.OrderCalculation);
	}

	public void SetFilterGroupIndex(Ranking.FilterGroupIndex groupIndex_)
	{
	}

	public Ranking.FilterGroupIndex GetFilterGroupIndex()
	{
		return default(Ranking.FilterGroupIndex);
	}

	public void SetFilterGroupNum(byte groupNum_)
	{
	}

	public byte GetFilterGroupNum()
	{
		return default(byte);
	}

	public void SetTimeScope(Ranking.TimeScope timeScope_)
	{
	}

	public Ranking.TimeScope GetTimeScope()
	{
		return default(Ranking.TimeScope);
	}

	public void SetOffset(uint offset_)
	{
	}

	public uint GetOffset()
	{
		return default(uint);
	}

	public void SetLength(byte length_)
	{
	}

	public byte GetLength()
	{
		return default(byte);
	}

	public void Trace()
	{
	}

	public override string ToString()
	{
		return null;
	}
}
