using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Pml.PokePara;

[Serializable]
[StructLayout(0, Pack = 4, Size = 344)]
public struct SerializedPokemonFull
{
	[SerializeField]
	public byte[] buffer;

	public void CopyFrom([In] ref SerializedPokemonFull src)
	{
	}

	public static void Swap(ref SerializedPokemonFull lhs, ref SerializedPokemonFull rhs)
	{
	}

	public void CreateWorkIfNeed()
	{
	}
}
