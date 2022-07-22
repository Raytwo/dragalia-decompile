using Pml;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class ShopExchangeItemItem : ShopItemItem
{
	public class Param
	{
		public class Flower
		{
			public SealID sealId;
		}

		public class Otenki
		{
			public ItemNo itemNo;
		}

		public class PalPark
		{
			public ItemNo itemNo;

			public int parkItemNo;

			public int parkTradeItemNo;
		}

		public ItemNo tradeItemNo;

		public int price;

		public Flower flower;

		public Otenki otenki;

		public PalPark palPark;

		public SealID GetSealId(ShopBase.ShopType shopType)
		{
			return default(SealID);
		}

		public ItemNo GetItemNo(ShopBase.ShopType shopType)
		{
			return default(ItemNo);
		}
	}

	[SerializeField]
	private Image _tradeItemIcon;

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

	public void SetMessageTradeItemName(int argIndex, int amount)
	{
	}

	public void SetMessagePocketName(int argIndex)
	{
	}

	public void AddItem(int amount)
	{
	}
}
