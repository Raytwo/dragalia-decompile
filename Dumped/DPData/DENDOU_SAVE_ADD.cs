using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 1440)]
public struct DENDOU_SAVE_ADD
{
	public DENDOU_SAVE_ADD_POKE_MEMBER[] data;

	public DENDOU_SAVE_ADD(int langid)
	{
	}
}
