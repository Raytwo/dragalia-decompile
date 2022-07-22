using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Dpr.Item;
using Dpr.UI;
using UnityEngine;
using XLSXContent;

namespace Pml.UgFather;

public class UgFatherDataManager
{
	public enum UgUIWindowType
	{
		None,
		TradeUgItemS,
		TradeUgItemL,
		SellItemUg,
		SellUgItem,
		Expantion
	}

	public enum UgShopType
	{
		UgShop_S,
		UgShop_L
	}

	private enum UgItemCategory
	{
		Drill,
		Tama,
		Pedestal,
		WazaMachine
	}

	public class SellItemData
	{
		public Sprite iconSpr;

		public int ugItemID;

		public int price;

		public int unit;

		public int haveCount;
	}

	public class RequiredExpansionItemData
	{
		public int ugItemId;

		public int price;

		public int haveCount;

		public bool IsEnought => default(bool);

		public RequiredExpansionItemData(int ugItemId, int price)
		{
		}
	}

	public const string UNDER_GROUND_MSBT_NAME = "dlp_underground";

	public const int MAX_SHOP_ITEM_NUM = 10;

	private const int MAX_EXPANSION_ITEM_NUM = 5;

	private const int LIMIT_LOOP_COUNT = 100;

	public static UgFatherDataManager Instance
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public UgFatherPos UGFPos
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public UgFatherExpansion UGFExpansion
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public UgFatherShopTable UGFShop
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public UgFatherShopTable.Sheetbuy01[] UGFBuyTamaS => null;

	public UgFatherShopTable.Sheetbuy02[] UGFBuyTamaL => null;

	public UgFatherShopTable.Sheetbuy01diz[] UGFBuyTamaS_Diz => null;

	public UgFatherShopTable.Sheetbuy02diz[] UGFBuyTamaL_Diz => null;

	public UgFatherShopTable.Sheetsale01[] UGFSalePedestal => null;

	public UgFatherShopTable.Sheetsale02[] UGFSaleItem => null;

	public UgFatherShopTable.SheetshopListData[] UGFShopListData => null;

	public bool IsMaxExpansion => default(bool);

	public void Initialize(UgFatherPos ugfPos, UgFatherExpansion ugfExpansion, UgFatherShopTable ugfShop)
	{
	}

	public void SetupUgShopItems(UgShopType shopType, int randomSeed, DayOfWeek dayOfWeek, List<ShopUgExchangeItemItem.Param> itemParamList)
	{
	}

	private int LotShopItemRate(int randomSeed)
	{
		return default(int);
	}

	private void LotShopUgSItemList(List<ShopUgExchangeItemItem.Param> itemList, int randomSeed, byte priceRate, DayOfWeek dayOfWeek)
	{
	}

	private void LotShopUgLItemList(List<ShopUgExchangeItemItem.Param> itemList, int randomSeed, byte priceRate, DayOfWeek dayOfWeek)
	{
	}

	private UgFatherShopTable.SheetBuyBase[] GetUGFBuyDatasByCategory([In] ref UgFatherShopTable.SheetBuyBase[] datas, UgItemCategory category)
	{
		return null;
	}

	private UgFatherShopTable.SheetBuyBase[] GetUGFBuyPedestalDatas([In] ref UgFatherShopTable.SheetBuydizBase[] datas, DayOfWeek dayOfWeek)
	{
		return null;
	}

	private bool CheckZukanFlag(bool isNeedCheckZukanFlag)
	{
		return default(bool);
	}

	private bool CheckBadgeNum(int needBadheNum)
	{
		return default(bool);
	}

	private bool CheckDayOfWeek(UgFatherShopTable.SheetBuydizBase data, DayOfWeek dayOfWeek)
	{
		return default(bool);
	}

	private bool CheckSystemFlag(int systemFlagIndex)
	{
		return default(bool);
	}

	private void LotUGFBuyDatasByCategory([In] ref UgFatherShopTable.SheetBuyBase[] datas, UgItemCategory category, int randomSeed, int lotNum, byte priceRate, List<ShopUgExchangeItemItem.Param> itemList)
	{
	}

	private ShopUgExchangeItemItem.Param CreateShopUgItemParam(UgFatherShopTable.SheetBuyBase data, byte priceRate)
	{
		return null;
	}

	public SellItemData CreateShopUgExchangeItemData(ShopUgExchangeItemItem.Param param)
	{
		return null;
	}

	public SellItemData CreatePedestalSellItemData(int ugItemId)
	{
		return null;
	}

	public ItemInfo.CategoryType[] CreateSellItemCategoryArray()
	{
		return null;
	}

	public SellItemData CreateSellItemDataByIndex(int index)
	{
		return null;
	}

	public RequiredExpansionItemData[] CreateRequierdUgBaseExpantionItemDatas()
	{
		return null;
	}
}
