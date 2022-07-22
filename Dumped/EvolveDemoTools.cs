using System;
using System.Collections;
using System.Runtime.InteropServices;
using Dpr.Demo;
using Pml;
using Pml.PokePara;

public static class EvolveDemoTools
{
	public struct Param
	{
		public PokeParty party;

		public PokemonParam pp;

		public int criticalCount;

		public EvolveSituation situation;
	}

	public static bool CanEvolve(out MonsNo nextMonsNo, out uint evolutionRoot, PokeParty playerParty, PokemonParam poke, EvolveSituation situation, [Optional] PokemonParam pairPoke, ItemNo itemNo = ItemNo.DUMMY_DATA)
	{
		return default(bool);
	}

	public static bool DoEvolve(Param param, [Optional] Action<Demo_Evolve.Result> onResult, [Optional] PokemonParam pairPoke, ItemNo itemNo = ItemNo.DUMMY_DATA, [Optional] Action onEndDemo, bool isUseEndExitFade = true)
	{
		return default(bool);
	}

	public static IEnumerator RegisterZukanCoroutine(PokemonParam capturedPokemon, [Optional] Action onEnd)
	{
		return null;
	}
}
