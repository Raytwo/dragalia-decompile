using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, CharSet = CharSet.Unicode, Pack = 4, Size = 32)]
public struct MysteryGiftCommonData
{
	public long timestamp;

	public uint deliveryID;

	public ushort eventTextID;

	public ushort romVersion;

	public byte receiveFlag;

	public byte dataType;

	public byte cardMessageID;

	public byte[] padding;

	public bool IsReceiveOnce => default(bool);

	public bool IsReceiveOneDay => default(bool);
}
