using System;
using System.Runtime.InteropServices;

namespace DPData.MysteryGift;

[Serializable]
[StructLayout(0, Pack = 4, Size = 16)]
public struct OneDayData
{
	public long timestamp;

	public ushort deliveryId;

	public short reserved_short01;

	public short reserved_short02;

	public short reserved_short03;
}
