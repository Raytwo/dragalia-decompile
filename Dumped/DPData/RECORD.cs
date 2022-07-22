using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 120)]
public struct RECORD
{
	public uint[] record;
}
