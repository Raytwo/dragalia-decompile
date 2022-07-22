using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 1824)]
public struct CONTEST_DATA
{
	public CON_PHOTO_DATA[] photoDatas;

	public uint contestRankPoint;
}
