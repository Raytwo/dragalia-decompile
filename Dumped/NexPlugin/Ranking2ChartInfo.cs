using System.Collections.Generic;

namespace NexPlugin;

public class Ranking2ChartInfo
{
	internal uint index;

	internal uint category;

	internal uint season;

	internal uint samplingRate;

	internal bool scoreOrder;

	internal uint estimateLength;

	internal uint estimateHighestScore;

	internal uint estimateLowestScore;

	internal uint estimateMedianScore;

	internal uint highestBinsScore;

	internal uint lowestBinsScore;

	internal uint binsWidth;

	internal uint attribute1;

	internal uint attribute2;

	internal NpDateTime createTime;

	internal double estimateAverageScore;

	internal List<uint> quantities;

	internal byte binsSize;

	public NpDateTime GetCreateTime()
	{
		return default(NpDateTime);
	}

	public uint GetIndex()
	{
		return default(uint);
	}

	public uint GetCategory()
	{
		return default(uint);
	}

	public uint GetSeason()
	{
		return default(uint);
	}

	public uint GetBinsSize()
	{
		return default(uint);
	}

	public bool IsValid()
	{
		return default(bool);
	}

	public uint GetSamplingRate()
	{
		return default(uint);
	}

	public bool GetScoreOrder()
	{
		return default(bool);
	}

	public uint GetEstimateLength()
	{
		return default(uint);
	}

	public uint GetEstimateHighestScore()
	{
		return default(uint);
	}

	public uint GetEstimateLowestScore()
	{
		return default(uint);
	}

	public uint GetEstimateMedianScore()
	{
		return default(uint);
	}

	public double GetEstimateAverageScore()
	{
		return default(double);
	}

	public uint GetHighestBinsScore()
	{
		return default(uint);
	}

	public uint GetLowestBinsScore()
	{
		return default(uint);
	}

	public uint GetBinsWidth()
	{
		return default(uint);
	}

	public uint GetAttribute1()
	{
		return default(uint);
	}

	public uint GetAttribute2()
	{
		return default(uint);
	}

	public List<uint> GetQuantities()
	{
		return null;
	}

	public void Trace()
	{
	}

	public override string ToString()
	{
		return null;
	}
}
