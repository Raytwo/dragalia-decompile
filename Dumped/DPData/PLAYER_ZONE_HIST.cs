using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 8)]
public struct PLAYER_ZONE_HIST
{
	public int BeforeZone;

	public int OldZone;
}
