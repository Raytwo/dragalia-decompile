using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 492)]
public struct DENDOU_RECORD
{
	public DENDOU_POKEMON_DATA_INSIDE[] pokemon;

	public GMTIME time;
}
