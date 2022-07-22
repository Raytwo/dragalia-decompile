using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 264)]
public struct HONEY_TREE
{
	public long LastUpdateMinutes;

	public byte TreeNo;

	public HONEY_DATA[] HoneyData;
}
