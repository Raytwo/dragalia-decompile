using System;
using System.Runtime.InteropServices;

namespace DPData.MysteryGift;

[Serializable]
[StructLayout(0, Pack = 4, Size = 16)]
public struct ItemInfo
{
	public ushort itemNo;

	public ushort num;

	public int reserved_int01;

	public int reserved_int02;

	public int reserved_int03;
}
