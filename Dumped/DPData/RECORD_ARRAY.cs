using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 1440)]
public struct RECORD_ARRAY
{
	public RECORD[] records;
}
