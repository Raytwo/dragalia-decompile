using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 2, Size = 8)]
public struct TR_BATTLE_DATA
{
	public bool IsWin;

	public bool IsBattleSearcher;
}
