using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 312)]
public struct TV_TOPIC
{
	public int[] int_data;

	public int reserved_int1;

	public int reserved_int2;

	public int reserved_int3;

	public bool[] view_flag;

	public byte reserved_byte1;

	public byte reserved_byte2;

	public byte reserved_byte3;
}
