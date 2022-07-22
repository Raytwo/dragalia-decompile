using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 1584)]
public struct _RANDOM_GROUP
{
	public RANDOM_SEED[] group;
}
