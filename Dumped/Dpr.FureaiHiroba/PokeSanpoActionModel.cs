using System.Collections.Generic;
using XLSXContent;

namespace Dpr.FureaiHiroba;

public sealed class PokeSanpoActionModel : PokeFureaiActionModel
{
	public enum PokeAction
	{
		WaitKyoro,
		UroUro,
		Run,
		Sleep,
		Engi,
		Dotuki,
		Hoe,
		Watya,
		_None
	}

	private PokeAction PrevAction;

	private static readonly Dictionary<int, List<int>> ActionFlow;

	private List<PokeActionWhight> pokeActionWhights;

	public PokeSanpoActionModel(FreeSanpoActionProbability.SheetSheet1 actionProbability)
	{
	}

	public void Destroy()
	{
	}
}
