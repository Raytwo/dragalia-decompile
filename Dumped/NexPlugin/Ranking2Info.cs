using System.Collections.Generic;

namespace NexPlugin;

public class Ranking2Info
{
	internal uint numRankedIn;

	internal uint lowestRank;

	internal int season;

	internal List<Ranking2RankData> rankDataList;

	public List<Ranking2RankData> GetRankDataList()
	{
		return null;
	}

	public uint GetLowestRank()
	{
		return default(uint);
	}

	public uint GetNumRankedIn()
	{
		return default(uint);
	}

	public int GetSeason()
	{
		return default(int);
	}

	public void Trace()
	{
	}

	public override string ToString()
	{
		return null;
	}
}
