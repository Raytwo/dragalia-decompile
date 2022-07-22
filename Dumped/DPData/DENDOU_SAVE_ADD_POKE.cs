using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 8)]
public struct DENDOU_SAVE_ADD_POKE
{
	public int langId;

	public int pastParentsLangId;
}
