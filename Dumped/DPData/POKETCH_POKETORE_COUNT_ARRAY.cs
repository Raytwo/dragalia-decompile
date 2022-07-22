using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 48)]
public struct POKETCH_POKETORE_COUNT_ARRAY
{
	public POKETCH_POKETORE_COUNT[] data;

	public static void CreatePoketoreData()
	{
	}
}
