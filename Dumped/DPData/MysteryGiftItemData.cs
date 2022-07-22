using System;
using System.Runtime.InteropServices;
using DPData.MysteryGift;

namespace DPData;

[Serializable]
[StructLayout(0, CharSet = CharSet.Unicode, Pack = 4, Size = 112)]
public struct MysteryGiftItemData
{
	public const int InfoSize = 7;

	public ItemInfo[] itemInfos;
}
