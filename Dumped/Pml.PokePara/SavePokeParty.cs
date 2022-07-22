using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Pml.PokePara;

[Serializable]
[StructLayout(0, Pack = 4, Size = 2066)]
public struct SavePokeParty
{
	[SerializeField]
	private SerializedPokemonFull[] members;

	[SerializeField]
	private byte memberCount;

	[SerializeField]
	private byte markingIndex;

	public void Serialize_Full(PokeParty party)
	{
	}

	public void Deserialize_Full(PokeParty party)
	{
	}

	public void CreateWorkIfNeed()
	{
	}

	public void Clear()
	{
	}
}
