using System;
using System.Runtime.InteropServices;
using DPData.MysteryGift;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 13680)]
public struct MysteryGiftSaveData
{
	public const int RecvDataMax = 50;

	public const int OneDayMax = 10;

	public const int SerialDataNoMax = 895;

	public const int ReserveSize = 66;

	public const int FlagSize = 256;

	public RecvData[] recvDatas;

	public byte[] receiveFlag;

	public OneDayData[] oneDayDatas;

	public long serialLockTimestamp;

	public bool ngFlag;

	public byte ngCounter;

	public ushort[] reserved_ushorts;

	public uint[] reserve;

	public void Clear()
	{
	}
}
