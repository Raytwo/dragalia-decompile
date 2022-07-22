using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 2056)]
public struct KinomiGrowSaveData
{
	public const int KinomiGrowsCount = 128;

	public KinomiGrow[] kinomiGrows;

	public long LastUpdateMinutes;
}
