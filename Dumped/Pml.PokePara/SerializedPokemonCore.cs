using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Pml.PokePara;

[Serializable]
[StructLayout(0, Pack = 4, Size = 328)]
public struct SerializedPokemonCore
{
	[SerializeField]
	public byte[] buffer;

	public void CopyFrom([In] ref SerializedPokemonCore src)
	{
	}

	public void CreateWorkIfNeed(bool isRecreate = false)
	{
	}
}
