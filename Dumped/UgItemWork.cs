using System.Collections.Generic;
using Dpr.Item;
using XLSXContent;

public class UgItemWork
{
	private static UgItemWork _instance;

	private UgItemInfo[] _items;

	public static void Create()
	{
	}

	private static int AddItem(int itemno, int num = 1)
	{
		return default(int);
	}

	private static int SubItem(int itemno, int num = 1)
	{
		return default(int);
	}

	public static int AddUgItem(int ugItemNo, int num = 1)
	{
		return default(int);
	}

	public static int SubUgItem(int ugItemNo, int num = 1)
	{
		return default(int);
	}

	public static bool IsAddItem(int ugItemNo, int num = 1)
	{
		return default(bool);
	}

	public static UgItemInfo GetItemInfo(int itemno)
	{
		return null;
	}

	public static ItemTable.SheetItem GetItemData(ushort id)
	{
		return null;
	}

	public static bool hasStatue()
	{
		return default(bool);
	}

	public static List<UgItemInfo> GetBagItem()
	{
		return null;
	}

	public static List<UgItemInfo> GetDoNotHaveStatue()
	{
		return null;
	}

	public static int GetHaveStatueKindNum()
	{
		return default(int);
	}

	private UgItemWork()
	{
	}
}
