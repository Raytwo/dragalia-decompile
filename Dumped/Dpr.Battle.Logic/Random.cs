using Xoroshiro128Plus;

namespace Dpr.Battle.Logic;

public class Random
{
	private global::Xoroshiro128Plus.Xoroshiro128Plus m_randomEngine;

	private ulong m_seed;

	public void Initialize()
	{
	}

	public void Initialize(ulong seed)
	{
	}

	public ulong GetSeed()
	{
		return default(ulong);
	}

	public ulong GetValue()
	{
		return default(ulong);
	}

	public ulong GetValue(ulong max)
	{
		return default(ulong);
	}

	private static ulong GenerateSeed()
	{
		return default(ulong);
	}

	public static int GetPublicRand(int range)
	{
		return default(int);
	}
}
