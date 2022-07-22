using System.Collections.Generic;
using Dpr.Item;
using Dpr.UI;
using Pml;
using XLSXContent;

public class ItemWork
{
	private static ItemWork _instance;

	private static ItemWork _temp_instance;

	private ItemInfo[] _items;

	private List<ItemInfo>[] _categorizedItems;

	private ItemListMemory[] _itemListMemories;

	private bool _bagIconSex;

	private bool _isShowWazaName;

	public static void Create()
	{
	}

	public static void EnableDummyWork()
	{
	}

	public static void DisableDummyWork()
	{
	}

	public static int AddItem(int itemno, int num = 1)
	{
		return default(int);
	}

	public static int SubItem(int itemno, int num = 1)
	{
		return default(int);
	}

	public static bool IsAddItem(int itemno, int num = 1)
	{
		return default(bool);
	}

	public static ItemInfo GetItemInfo(int itemno)
	{
		return null;
	}

	public static List<ItemInfo> GetItemInfosByCategory(ItemInfo.CategoryType category)
	{
		return null;
	}

	public static List<ItemInfo> GetItemInfosByCategory(int categoryId)
	{
		return null;
	}

	public static ItemTable.SheetItem GetItemData(ushort id)
	{
		return null;
	}

	public static bool IsIncludeNewItem(ItemInfo.CategoryType category)
	{
		return default(bool);
	}

	public static bool IsIncludeNewItem(int categoryId)
	{
		return default(bool);
	}

	public static bool IsIncludeFavoriteItem(ItemInfo.CategoryType category)
	{
		return default(bool);
	}

	public static bool IsIncludeFavoriteItem(int categoryId)
	{
		return default(bool);
	}

	public static List<ItemInfo> GetBagItem()
	{
		return null;
	}

	public static void SortItemInfosByCategory(ItemInfo.CategoryType category, ItemInfo.SortType sortType)
	{
	}

	public static void SortItemInfosByCategory(int categoryId, ItemInfo.SortType sortType)
	{
	}

	public static bool IsCategory(int itemno, ItemInfo.CategoryType category)
	{
		return default(bool);
	}

	public static bool IsWazaMachine(int itemno)
	{
		return default(bool);
	}

	public static ItemListMemory GetItemListMemory(UIBag.BootType bootType)
	{
		return null;
	}

	public static void ResetItemListMemory(UIBag.BootType bootType)
	{
	}

	public static bool IsDsPlayer()
	{
		return default(bool);
	}

	public static void SetDsPlayer(bool flag)
	{
	}

	public static bool GetBagIconSex()
	{
		return default(bool);
	}

	public static void SetBagIconSex(bool sex)
	{
	}

	public static bool IsUseSpray(out ItemNo itemno)
	{
		return default(bool);
	}

	public static void SetSpray(ItemNo itemno, short value)
	{
	}

	public static short GetSprayCount()
	{
		return default(short);
	}

	public static void SubSprayCount(short subval)
	{
	}

	public static int GetValidSaveSortNumberCount(ItemInfo.CategoryType category)
	{
		return default(int);
	}

	public static int GetValidSaveSortNumberCount(int category)
	{
		return default(int);
	}

	public static void UpdateListSort(ItemInfo itemInfo)
	{
	}

	public static bool IsShowWazaName()
	{
		return default(bool);
	}

	private ItemWork(bool isDummy = false)
	{
	}
}
