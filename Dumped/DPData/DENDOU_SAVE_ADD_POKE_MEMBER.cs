using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 48)]
public struct DENDOU_SAVE_ADD_POKE_MEMBER
{
	public DENDOU_SAVE_ADD_POKE[] member;
}
