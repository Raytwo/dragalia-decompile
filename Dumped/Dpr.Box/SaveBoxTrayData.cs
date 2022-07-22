using System;
using System.Runtime.InteropServices;
using Pml.PokePara;

namespace Dpr.Box;

[Serializable]
[StructLayout(0, Pack = 4, Size = 10320)]
public struct SaveBoxTrayData
{
	public SerializedPokemonFull[] pokemonParam;

	public static void Swap(ref SaveBoxTrayData lhs, ref SaveBoxTrayData rhs)
	{
	}

	public void Clear()
	{
	}
}
