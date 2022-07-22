using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 8)]
public struct SWAY_GRASS_REC
{
	public uint MonsNo;

	public uint Chain;
}
