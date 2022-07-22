using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, CharSet = CharSet.Unicode, Pack = 1, Size = 32)]
public struct GMS_POINT_HISTORY_EXT_DATA
{
	public string receiveMonsNickname;

	public ushort reserved_ushort01;

	public int reserved_int01;
}
