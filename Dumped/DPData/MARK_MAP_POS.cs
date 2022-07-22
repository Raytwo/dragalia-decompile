using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 2, Size = 4)]
public struct MARK_MAP_POS
{
	public ushort x;

	public ushort y;
}
