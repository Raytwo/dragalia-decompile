using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 14768)]
public struct _DENDOU_SAVEDATA
{
	public DENDOU_RECORD[] record;

	public uint savePoint;

	public uint latestNumber;

	public _DENDOU_SAVEDATA(int a)
	{
	}
}
