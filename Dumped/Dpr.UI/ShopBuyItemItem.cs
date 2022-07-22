using Pml;
using UnityEngine;

namespace Dpr.UI;

public class ShopBuyItemItem : ShopItemItem
{
	public class Param
	{
		public int itemId;

		public int price;

		public ItemNo GetItemNo()
		{
			return default(ItemNo);
		}

		public SealID GetSealId()
		{
			return default(SealID);
		}

		public int GetUgItemId()
		{
			return default(int);
		}
	}

	[SerializeField]
	private Vector2[] _iconSizes;

	private Param _param;

	public Param param => null;

	public void Setup(ShopBase.ShopType shopType, Param param)
	{
	}

	public void SetMessageItemName(int argIndex, int amount)
	{
	}

	public void SetMessagePocketName(int argIndex)
	{
	}

	public void AddItem(int amount)
	{
	}
}
