using System;
using System.Runtime.InteropServices;

namespace DPData.MysteryGift;

[Serializable]
[StructLayout(0, Pack = 4, Size = 224)]
public struct RecvData
{
	public long timestamp;

	public ushort deliveryId;

	public ushort textId;

	public byte dataType;

	public byte reserved_byte01;

	public short reserved_short01;

	public MonsData monsData;

	public ItemInfo[] itemDatas;

	public uint[] dressIds;

	public uint moneyData;

	public int reserved_int01;

	public int reserved_int02;

	public int reserved_int03;

	public int reserved_int04;

	public void Clear()
	{
	}
}
