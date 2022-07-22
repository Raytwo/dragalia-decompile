using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 24)]
public struct SWAY_GRASS_HIST
{
	public SWAY_GRASS_REC[] SwayGrassRec;
}
