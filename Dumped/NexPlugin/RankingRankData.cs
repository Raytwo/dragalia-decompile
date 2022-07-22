using System.Collections.Generic;

namespace NexPlugin;

public class RankingRankData
{
	internal ulong principalId;

	internal uint order;

	internal ulong uniqueId;

	internal uint category;

	internal uint score;

	internal ulong param;

	internal NpDateTime updateTime;

	internal List<byte> commonData;

	internal byte group0;

	internal byte group1;

	public ulong GetPrincipalId()
	{
		return default(ulong);
	}

	public ulong GetUniqueId()
	{
		return default(ulong);
	}

	public uint GetOrder()
	{
		return default(uint);
	}

	public uint GetCategory()
	{
		return default(uint);
	}

	public uint GetScore()
	{
		return default(uint);
	}

	public byte GetGroup0()
	{
		return default(byte);
	}

	public byte GetGroup1()
	{
		return default(byte);
	}

	public ulong GetParam()
	{
		return default(ulong);
	}

	public List<byte> GetCommonData()
	{
		return null;
	}

	public NpDateTime GetUpdateTime()
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
