using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 60)]
public struct WorpPoint
{
	public LOCATION_WORK teleport;

	public LOCATION_WORK zenmetu;

	public LOCATION_WORK ananuke;
}
