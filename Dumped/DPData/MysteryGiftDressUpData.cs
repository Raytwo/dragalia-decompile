using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, CharSet = CharSet.Unicode, Pack = 4, Size = 64)]
public struct MysteryGiftDressUpData
{
	public const int InfoSize = 7;

	public uint[] maleDressIds;

	public uint[] femaleDressIds;

	public int reserved_int01;

	public int reserved_int02;
}
