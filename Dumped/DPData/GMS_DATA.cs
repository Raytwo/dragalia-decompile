using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 201506)]
public struct GMS_DATA
{
	public GMS_POINT_DATA[] pointDatas;

	public ushort tradeListIndex;

	public ushort browsingListIndex;

	public byte achievementStep;
}
