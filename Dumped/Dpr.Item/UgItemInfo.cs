using System;
using UnityEngine;

namespace Dpr.Item;

public class UgItemInfo
{
	public enum CategoryType
	{
		Tama,
		Pedestal,
		Statue,
		Unknown,
		Length
	}

	public const int ItemSaveSize = 999;

	public const int ItemMaxCount = 999;

	public const int StatueMaxCount = 99;

	private int _workNo;

	private int _dummyCount;

	private bool _dummyIsVanishNew;

	private int _sortNum;

	public int count
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public bool bIsNew
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public int UgItemId => default(int);

	public string Name => null;

	public string DescriptionText => null;

	public CategoryType Category => default(CategoryType);

	public int SortNumber => default(int);

	public UgItemInfo(int item_no)
	{
	}

	public int AddItem(int num = 1)
	{
		return default(int);
	}

	public int SubItem(int num = 1)
	{
		return default(int);
	}

	public bool IsAddItem(int num = 1)
	{
		return default(bool);
	}

	private int GetMaxCount()
	{
		return default(int);
	}

	public static void LoadItemIcon(int itemId, Action<Sprite> onLoadedCallback)
	{
	}

	public static void LoadItemIconL(int itemId, Action<Sprite> onLoadedCallback)
	{
	}
}
