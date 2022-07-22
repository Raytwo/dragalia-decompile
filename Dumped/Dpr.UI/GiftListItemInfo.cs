using System.Runtime.CompilerServices;
using DPData;
using DPData.MysteryGift;

namespace Dpr.UI;

public class GiftListItemInfo
{
	private MysteryGiftData giftData;

	public MysteryGiftData GiftData => default(MysteryGiftData);

	public RecvData RecvData
	{
		[CompilerGenerated]
		get
		{
			return default(RecvData);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public ConvertResult ConvertResult
	{
		[CompilerGenerated]
		get
		{
			return default(ConvertResult);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public GiftListItemInfo(byte[] data)
	{
	}

	public CanReceiveResult CanReceive()
	{
		return default(CanReceiveResult);
	}

	private void Create(byte[] data)
	{
	}
}
