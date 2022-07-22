using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 1032)]
public struct TV_RECORD
{
	public int[] int_data;

	public TV_STR_DATA[] str_data;
}
