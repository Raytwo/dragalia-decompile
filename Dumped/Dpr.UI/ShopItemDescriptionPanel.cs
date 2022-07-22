using System;
using Dpr.Item;
using Pml;
using UnityEngine;

namespace Dpr.UI;

public class ShopItemDescriptionPanel : ItemDescriptionPanel
{
	[Serializable]
	private class Stock
	{
		public UIText num;

		public BagIconPanel bag;
	}

	[SerializeField]
	private Stock _stock;

	[SerializeField]
	private Vector2[] _iconSizes;

	private ShopBase.ShopType _shopType;

	private ShopItemItem _itemItem;

	public void Set(ShopBase.ShopType shopType, ShopItemItem itemItem)
	{
	}

	private void Set(ShopBase.ShopType shopType, SealInfo item)
	{
	}

	private void Set(SealInfo item, bool isChangeShowWaza = true)
	{
	}

	public void Set(ShopBase.ShopType shopType, ItemInfo item)
	{
	}

	public void SetWazaDescriptionType(int type)
	{
	}

	protected override void SetWazaPower(WazaNo wazaNo, string messageLabel, string messageLabelInvalid)
	{
	}

	protected override void SetWazaHitPer(WazaNo wazaNo, string messageLabel, string messageLabelInvalid)
	{
	}

	public void Set(ShopBase.ShopType shopType, UgItemInfo ugItem)
	{
	}

	private void Set(UgItemInfo ugItem, bool isChangeShowWaza = true)
	{
	}

	private void SetUnderGround(UgItemInfo ugItemInfo)
	{
	}
}
