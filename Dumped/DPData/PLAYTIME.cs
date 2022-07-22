using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 2, Size = 4)]
public struct PLAYTIME
{
	public ushort hour;

	public byte minute;

	public byte second;
}
