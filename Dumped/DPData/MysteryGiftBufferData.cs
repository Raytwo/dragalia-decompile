using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, CharSet = CharSet.Unicode, Pack = 4, Size = 688)]
public struct MysteryGiftBufferData
{
	public const int BufferSize = 688;

	public byte[] buffer;
}
