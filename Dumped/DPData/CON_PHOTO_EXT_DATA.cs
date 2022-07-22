using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, CharSet = CharSet.Unicode)]
public struct CON_PHOTO_EXT_DATA
{
	public string nickname;

	public ushort reserved_ushort01;

	public int reserved_int01;
}
