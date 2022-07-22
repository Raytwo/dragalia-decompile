using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 12)]
public struct HONEY_DATA
{
	public bool Spreaded;

	public int Minutes;

	public byte TblMonsNo;

	public byte RareLv;

	public byte SwayLv;
}
