using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 16)]
public struct POKETCH_POKETORE_COUNT
{
	public ushort monsno;

	public ushort reserve;

	public int count;

	public int reserve1;

	public int reserve2;
}
