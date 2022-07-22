using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 8)]
public struct HILL_BACK_DATA
{
	public bool TalkFlg;

	public ushort EncTblIdx1;

	public ushort EncTblIdx2;
}
