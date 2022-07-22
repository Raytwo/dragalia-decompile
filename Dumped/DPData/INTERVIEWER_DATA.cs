using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 264)]
public struct INTERVIEWER_DATA
{
	public int[] program_data;

	public int[] int_data;

	public TV_STR_DATA[] str_data;
}
