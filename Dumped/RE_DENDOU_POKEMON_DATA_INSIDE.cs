using System;
using System.Runtime.InteropServices;

[Serializable]
[StructLayout(0, CharSet = CharSet.Unicode, Pack = 4, Size = 32)]
public struct RE_DENDOU_POKEMON_DATA_INSIDE
{
	public string nickname;

	public short reserved_short01;

	public int reserved_int01;
}
