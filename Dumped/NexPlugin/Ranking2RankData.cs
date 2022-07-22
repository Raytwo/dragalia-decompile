namespace NexPlugin;

public class Ranking2RankData
{
	internal ulong misc;

	internal ulong nexUniqueId;

	internal ulong principalId;

	internal uint rank;

	internal uint score;

	internal Ranking2CommonData commonData;

	public uint GetRank()
	{
		return default(uint);
	}

	public uint GetScore()
	{
		return default(uint);
	}

	public ulong GetPrincipalId()
	{
		return default(ulong);
	}

	public ulong GetNexUniqueId()
	{
		return default(ulong);
	}

	public Ranking2CommonData GetCommonData()
	{
		return null;
	}

	public ulong GetMisc()
	{
		return default(ulong);
	}

	public void Trace()
	{
	}

	public override string ToString()
	{
		return null;
	}
}
