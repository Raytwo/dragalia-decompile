using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 1, Size = 32)]
public struct RECORD_RANKING
{
	public byte[] activeFlag;
}
