using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 1972)]
public struct PLAYER_DATA
{
	public CONFIG config;

	public MYSTATUS mystatus;

	public PLAYTIME playtime;

	public CONTEST_DATA contestdata;
}
