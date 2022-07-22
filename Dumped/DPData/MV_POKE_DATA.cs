using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 32)]
public struct MV_POKE_DATA
{
	public int ZoneIDIndex;

	public ulong RndSeed;

	public uint MonsNo;

	public uint Hp;

	public byte Lv;

	public uint Sick;

	public byte EncountStatus;
}
