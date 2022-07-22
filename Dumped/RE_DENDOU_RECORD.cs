using System;
using System.Runtime.InteropServices;

[Serializable]
[StructLayout(0, Pack = 4, Size = 192)]
public struct RE_DENDOU_RECORD
{
	public RE_DENDOU_POKEMON_DATA_INSIDE[] pokemon;
}
