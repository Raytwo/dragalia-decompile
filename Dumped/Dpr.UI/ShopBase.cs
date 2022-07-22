using Dpr.Item;
using UnityEngine;

namespace Dpr.UI;

public class ShopBase : UIWindow
{
	public enum ShopType
	{
		Friendly,
		Fixed,
		Seal,
		BattlePark,
		TobariDepart4F,
		Flower,
		Otenki,
		PalPark,
		Boutique,
		Underground
	}

	[SerializeField]
	protected UIScrollView _itemListScrollView;

	[SerializeField]
	protected Cursor _cursor;

	[SerializeField]
	protected ShopItemDescriptionPanel _itemDescriptionPanel;

	[SerializeField]
	protected ShopItemSelectAmount _selectAmount;

	protected const int _wazaItemDescriptionNum = 3;

	protected int _wazaItemDescriptionType;

	protected void UpdateWazaDescription(ItemInfo itemInfo)
	{
	}

	public (string, string) GetShopMessageData(SHOP_MESSAGEID shopMessageId, ShopType shopType, int fixedShopId)
	{
		return default((string, string));
	}

	public bool IsBuy(ShopType shopType)
	{
		return default(bool);
	}

	public string GetSelectAmountDescriptionText(ShopType shopType, string messageFile)
	{
		return null;
	}

	protected virtual bool UpdateSelect(float deltaTime, int pagedItemNum, bool enableButtonLR = true)
	{
		return default(bool);
	}

	private bool MoveSelectScrollView(int button, int move)
	{
		return default(bool);
	}

	private bool MovePageScrollView(int button, bool move)
	{
		return default(bool);
	}
}
