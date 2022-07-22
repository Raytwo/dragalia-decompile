using System.Collections.Generic;

namespace NexPlugin;

public class RankingResult
{
	internal uint totalCount;

	internal List<RankingRankData> rankDataList;

	internal NpDateTime sinceTime;

	public uint GetTotalCount()
	{
		return default(uint);
	}

	public List<RankingRankData> GetRankDataList()
	{
		return null;
	}

	public NpDateTime GetSinceTime()
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
