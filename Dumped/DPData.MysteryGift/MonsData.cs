using System;
using System.Runtime.InteropServices;

namespace DPData.MysteryGift;

[Serializable]
[StructLayout(0, CharSet = CharSet.Unicode, Pack = 4, Size = 48)]
public struct MonsData
{
	public ushort no;

	public ushort form;

	public ushort itemId;

	public ushort[] wazaNos;

	public string parentName;

	public byte parentSex;

	public byte isEgg;

	public byte twoRibbonId;

	public byte sex;

	public byte pokemonLangId;

	public byte reserved_byte01;

	public byte reserved_byte02;

	public byte reserved_byte03;

	public void Clear()
	{
	}
}
