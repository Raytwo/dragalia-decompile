using System;
using System.Runtime.InteropServices;
using Pml.PokePara;

[Serializable]
[StructLayout(0, Pack = 4, Size = 704)]
public struct AzukariyaData
{
	public SerializedPokemonFull[] pokemonParam;

	public bool eggExist;

	public ulong eggSeed;

	public int eggStepCount;

	public void Get(PokemonParam pp, int index)
	{
	}

	public PokemonParam Get(int index)
	{
		return null;
	}

	public void Set(int index, PokemonParam pp)
	{
	}

	public void Clear()
	{
	}

	public void Initialize()
	{
	}
}
