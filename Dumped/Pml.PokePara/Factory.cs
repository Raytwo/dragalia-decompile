using Pml.Local;

namespace Pml.PokePara;

public static class Factory
{
	public static byte[] CreateCoreData()
	{
		return null;
	}

	public static byte[] CreateCoreData(MonsNo monsno, ushort level, ulong id)
	{
		return null;
	}

	public static byte[] CreateCoreData(InitialSpec spec)
	{
		return null;
	}

	public static void SetupCoreData(byte[] coreData, InitialSpec spec)
	{
	}

	public static byte[] CreateCalcData(uint personalRnd)
	{
		return null;
	}

	public static PokemonParam CreateNukenin(PokemonParam tutinin)
	{
		return null;
	}

	private static void FixInitSpec(InitialSpec pFixSpec, InitialSpec spec)
	{
	}

	private static Seikaku getSeikakuAtRandom(RandomGenerator pRandom, MonsNo monsno, ushort formno)
	{
		return default(Seikaku);
	}

	private static Seikaku getHighSeikakuAtRandom(RandomGenerator pRandom)
	{
		return default(Seikaku);
	}

	private static Seikaku getLowSeikakuAtRandom(RandomGenerator pRandom)
	{
		return default(Seikaku);
	}

	private static Sex GetSexAtRandomInPersonalDistribution(MonsNo monsno, ushort formno, RandomGenerator pRandom)
	{
		return default(Sex);
	}

	private static short GetSizePersonalValue(short value, RandomGenerator pRandom)
	{
		return default(short);
	}

	private static byte[] AllocCoreData()
	{
		return null;
	}

	private static void ClearCoreData(byte[] coreData)
	{
	}

	private static void InitCoreData(byte[] coreData, InitialSpec spec)
	{
	}

	private static uint GetRandom(RandomGenerator pRandGenerator)
	{
		return default(uint);
	}

	private static uint GetRandom(RandomGenerator pRandGenerator, uint max_range)
	{
		return default(uint);
	}

	public static byte[] AllocFullData()
	{
		return null;
	}

	public static byte[] CreateFullData()
	{
		return null;
	}
}
