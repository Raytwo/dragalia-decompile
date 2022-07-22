using XLSXContent;

namespace Pml.PokePara;

public sealed class EvolveManager
{
	public const ushort EVOLVE_FRIENDSHIP = 160;

	public MonsNo GetEvolvedMonsNo_byLevelUp(CoreParam poke, PokeParty party, EvolveSituation situation, ref uint root_num)
	{
		return default(MonsNo);
	}

	public MonsNo GetEvolvedMonsNo_byEvent(CoreParam poke, PokeParty party, EvolveSituation situation, ref uint root_num)
	{
		return default(MonsNo);
	}

	public MonsNo GetEvolvedMonsNo_byItem(CoreParam poke, EvolveSituation situation, uint use_item, ref uint root_num)
	{
		return default(MonsNo);
	}

	public MonsNo GetEvolvedMonsNo_byTrade(CoreParam poke, CoreParam pair_poke, ref uint root_num)
	{
		return default(MonsNo);
	}

	public bool HaveEvolutionRoot(CoreParam poke)
	{
		return default(bool);
	}

	protected bool CheckItem_KAWARAZUNOISHI(uint item)
	{
		return default(bool);
	}

	private bool canEvolve(CoreParam poke)
	{
		return default(bool);
	}

	private bool IsSatisfyEvolveConditionLevelUp(CoreParam poke, PokeParty party, EvolveSituation situation, EvolveTable.SheetEvolve evolveData, int evolveRouteIndex)
	{
		return default(bool);
	}

	private bool IsSatisfyEvolveConditionEvent(CoreParam poke, PokeParty party, EvolveSituation situation, EvolveTable.SheetEvolve evolveData, int evolveRouteIndex)
	{
		return default(bool);
	}

	private bool IsSatisfyEvolveConditionItem(CoreParam poke, EvolveSituation situation, uint use_item, EvolveTable.SheetEvolve evolveData, int evolveRouteIndex)
	{
		return default(bool);
	}

	private bool IsSatisfyEvolveConditionTrade(CoreParam poke, CoreParam pair_poke, EvolveTable.SheetEvolve evolveData, int evolveRouteIndex)
	{
		return default(bool);
	}
}
