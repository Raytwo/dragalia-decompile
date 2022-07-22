using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 2, Size = 4)]
public struct POKETCH_POKE_HISTORY
{
	public ushort monsno;

	public ushort iconPattern;
}
