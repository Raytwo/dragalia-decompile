using Pml.PokePara;

namespace Pml.Battle;

public static class TypeAffinity
{
	public enum AffinityID
	{
		TYPEAFF_0 = 0,
		TYPEAFF_1_64 = 1,
		TYPEAFF_1_32 = 2,
		TYPEAFF_1_16 = 3,
		TYPEAFF_1_8 = 4,
		TYPEAFF_1_4 = 5,
		TYPEAFF_1_2 = 6,
		TYPEAFF_1 = 7,
		TYPEAFF_2 = 8,
		TYPEAFF_4 = 9,
		TYPEAFF_8 = 10,
		TYPEAFF_16 = 11,
		TYPEAFF_32 = 12,
		TYPEAFF_64 = 13,
		TYPEAFF_MAX = 14,
		TYPEAFF_NULL = 14
	}

	public enum AboutAffinityID
	{
		NONE,
		NORMAL,
		ADVANTAGE,
		DISADVANTAGE
	}

	private const byte x0 = 0;

	private const byte xH = 2;

	private const byte x1 = 4;

	private const byte x2 = 8;

	internal static readonly byte[][] TYPE_AFF_TBL;

	private const uint VALUE_0 = 0u;

	private const uint VALUE_1_64 = 1u;

	private const uint VALUE_1_32 = 2u;

	private const uint VALUE_1_16 = 4u;

	private const uint VALUE_1_8 = 8u;

	private const uint VALUE_1_4 = 16u;

	private const uint VALUE_1_2 = 32u;

	private const uint VALUE_1 = 64u;

	private const uint VALUE_2 = 128u;

	private const uint VALUE_4 = 256u;

	private const uint VALUE_8 = 512u;

	private const uint VALUE_16 = 1024u;

	private const uint VALUE_32 = 2048u;

	private const uint VALUE_64 = 4096u;

	private static readonly uint[] VALUE_TABLE;

	private static uint calcLSB(uint value)
	{
		return default(uint);
	}

	public static AffinityID CalcAffinity(PokeType wazaType, PokeType pokeType, bool isSakasaBattle)
	{
		return default(AffinityID);
	}

	public static AffinityID CalcAffinity(PokeType wazaType, PokeType pokeType1, PokeType pokeType2, bool isSakasaBattle)
	{
		return default(AffinityID);
	}

	public static AffinityID CalcAffinity(PokeType wazaType, PokemonParam pokeParam, bool isSakasaBattle)
	{
		return default(AffinityID);
	}

	public static AffinityID MulAffinity(AffinityID aff1, AffinityID aff2)
	{
		return default(AffinityID);
	}

	public static AboutAffinityID ConvAboutAffinity(AffinityID aff)
	{
		return default(AboutAffinityID);
	}

	public static AboutAffinityID TCalcAffinityAbout(PokeType wazaType, PokeType pokeType, bool isSakasaBattle)
	{
		return default(AboutAffinityID);
	}

	public static AboutAffinityID CalcAffinityAbout(PokeType wazaType, PokeType pokeType1, PokeType pokeType2, bool isSakasaBattle)
	{
		return default(AboutAffinityID);
	}

	public static AboutAffinityID CalcAffinityAbout(PokeType wazaType, PokemonParam pokeParam, bool isSakasaBattle)
	{
		return default(AboutAffinityID);
	}
}
