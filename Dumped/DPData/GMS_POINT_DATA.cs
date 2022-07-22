using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 310)]
public struct GMS_POINT_DATA
{
	public GMS_POINT_HISTORY_DATA[] historyDatas;
}
