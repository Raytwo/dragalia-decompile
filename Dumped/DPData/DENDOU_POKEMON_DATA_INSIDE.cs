using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, CharSet = CharSet.Unicode, Pack = 4, Size = 80)]
public struct DENDOU_POKEMON_DATA_INSIDE
{
	public uint monsno;

	public byte level;

	public ushort formNumber;

	public uint personalRandom;

	public uint idNumber;

	public int sex;

	public int rareType;

	public string nickname;

	public string oyaname;

	public ushort[] waza;
}
