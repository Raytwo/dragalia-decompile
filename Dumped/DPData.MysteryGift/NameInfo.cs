using System;
using System.Runtime.InteropServices;

namespace DPData.MysteryGift;

[Serializable]
[StructLayout(0, CharSet = CharSet.Unicode, Pack = 4, Size = 32)]
public struct NameInfo
{
	public string name;

	public byte languageId;

	public byte paddding;

	public int reserved_int01;
}
