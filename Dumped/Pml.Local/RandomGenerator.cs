using Xoroshiro128Plus;

namespace Pml.Local;

public sealed class RandomGenerator
{
	private global::Xoroshiro128Plus.Xoroshiro128Plus m_rng;

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

	public static ulong GenerateSeed()
	{
		return default(ulong);
	}

	public uint GetRand()
	{
		return default(uint);
	}

	public uint GetRand(uint max)
	{
		return default(uint);
	}
}
