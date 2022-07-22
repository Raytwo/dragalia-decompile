using System.Collections.Generic;
using System.Runtime.InteropServices;
using Pml;
using Pml.PokePara;

namespace Dpr;

public static class PokeRegulation
{
	private static readonly MonsNo[] legend_monsno;

	private static readonly MonsNo[] sub_legend_monsno;

	public static bool CheckLegend(MonsNo monsno, byte formno = 0)
	{
		return default(bool);
	}

	public static bool CheckSubLegend(MonsNo monsno)
	{
		return default(bool);
	}

	public static void ModifyLevelPokeParty(PokeParty iPtrPokeParty, Regulation.LevelRangeType levelRangeType, uint modify_level = 50u)
	{
	}

	public static void ModifyLevelPokeParam(PokemonParam pp, Regulation.LevelRangeType levelRangeType, uint modify_level = 50u)
	{
	}

	private static void MakeLevelRevise(PokemonParam iPtrPokePara, int level)
	{
	}

	private static uint ModifyLevelCalc(Regulation.LevelRangeType levelRangeType, uint level, uint modify_level = 50u)
	{
		return default(uint);
	}

	public static bool CheckBothPoke(PokeParty iPtrPokeParty, [Optional] List<MonsNo> bothPoke)
	{
		return default(bool);
	}

	public static bool CheckBothItem(PokeParty iPtrPokeParty, [Optional] List<ItemNo> bothItem)
	{
		return default(bool);
	}
}
