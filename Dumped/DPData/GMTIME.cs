using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 12)]
public struct GMTIME
{
	public uint saveCount;

	public long timestmp;
}
