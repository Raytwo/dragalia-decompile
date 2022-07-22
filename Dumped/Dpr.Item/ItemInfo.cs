using System;
using System.Runtime.CompilerServices;
using Pml;
using Pml.Item;
using Pml.PokePara;
using UnityEngine;

namespace Dpr.Item;

public class ItemInfo : ItemData
{
	public enum SortType
	{
		Type,
		Name,
		New,
		Favorite
	}

	public enum CategoryType
	{
		Heal,
		Ball,
		Battle,
		Nuts,
		Tools,
		WazaMachine,
		Treasure,
		Food,
		Important,
		Length
	}

	public enum eItemType
	{
		Pocket = 0,
		Kusuri = 1,
		Equip = 2,
		Normal = 3,
		Battle = 4,
		Ball = 5,
		Mail = 6,
		WazaMachine = 7,
		Kinomi = 8,
		Event = 9,
		Etc = 10,
		Dummy = 255
	}

	public const int ItemSaveSize = 3000;

	public const int ItemMaxCount = 999;

	public const int ItemShortcutSaveSize = 4;

	public const int ShortcutDirectionNone = -1;

	public const int ShortcutDirectionUp = 0;

	public const int ShortcutDirectionDown = 1;

	public const int ShortcutDirectionLeft = 2;

	public const int ShortcutDirectionRight = 3;

	private static readonly PrmID[] CheckAllowUsePrmIDs;

	private static readonly int[] SeikakuMintItemNos;

	private static readonly Seikaku[] SeikakuMintSeikakuTypes;

	private static readonly Seikaku[] DisabledMajimeMintSeikakuTypes;

	private static readonly ItemNo[] KanpouyakuItemNos;

	private ushort _workNo;

	private bool _isDummy;

	private int _dummyCount;

	private bool _dummyIsVanishNew;

	private bool _dummyIsFavorite;

	private ushort _dummySaveSortNumber;

	private bool _dummyIsShowWazaName;

	private int _id;

	private int _type;

	private CategoryType _categoryType;

	private int _price;

	private int _groupId;

	private int _sortId;

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

	public bool bIsFavorite
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public ushort SaveSortNumber
	{
		get
		{
			return default(ushort);
		}
		set
		{
		}
	}

	public bool IsShowWazaName
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public int Id => default(int);

	public string Name => null;

	public string DescriptionText => null;

	public int Type => default(int);

	public CategoryType Category => default(CategoryType);

	public int Price => default(int);

	public int GroupId => default(int);

	public int SortId => default(int);

	public bool CanSell => default(bool);

	public int SellPrice => default(int);

	public bool IsLevelUp => default(bool);

	public new bool IsNuts => default(bool);

	public bool IsImportant => default(bool);

	public bool IsAllowEquip => default(bool);

	public bool IsUseful => default(bool);

	public bool IsNoSpend => default(bool);

	public int ShortcutId => default(int);

	public bool IsRegisterShorcut => default(bool);

	public BallId BallID => default(BallId);

	public new bool IsJewel => default(bool);

	public bool IsBattleSelect => default(bool);

	public bool IsRecoveryHp => default(bool);

	public int RecoveryHpValue => default(int);

	public bool IsRecoveryPp => default(bool);

	public int RecoveryPpValue => default(int);

	public bool IsRecoveryPpAll => default(bool);

	public bool IsPpUp => default(bool);

	public bool IsPp3Up => default(bool);

	public bool IsRecoveryAllDead => default(bool);

	public bool IsRecoveryDead => default(bool);

	public bool IsRecoveryPoison => default(bool);

	public bool IsRecoveryBurn => default(bool);

	public bool IsRecoveryIce => default(bool);

	public bool IsRecoveryMeroMero => default(bool);

	public bool IsRecoveryPanic => default(bool);

	public bool IsRecoveryParalyze => default(bool);

	public bool IsRecoverySleep => default(bool);

	public bool IsHpExp => default(bool);

	public int HpExpValue => default(int);

	public bool IsAttackExp => default(bool);

	public int AttackExpValue => default(int);

	public bool IsDeffenceExp => default(bool);

	public int DeffenceExpValue => default(int);

	public bool IsSpAttackExp => default(bool);

	public int SpAttackExpValue => default(int);

	public bool IsSpDeffenceExp => default(bool);

	public int SpDeffenceExpValue => default(int);

	public bool IsAgilityExp => default(bool);

	public int AgilityExpValue => default(int);

	public int NameSortOrder
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public ItemInfo(ushort item_no)
	{
	}

	public ItemInfo(ushort item_no, bool is_dummy)
	{
	}

	public int GetParam(PrmID pid)
	{
		return default(int);
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

	public bool IsCategory(CategoryType category)
	{
		return default(bool);
	}

	public bool IsWazaMachine()
	{
		return default(bool);
	}

	public eItemType GetItemType()
	{
		return default(eItemType);
	}

	public FieldFunctionType GetFieldFunctionType()
	{
		return default(FieldFunctionType);
	}

	public static void LoadItemIcon(int itemId, Action<Sprite> onLoadedCallback, bool isUnload = false, bool isLarge = false)
	{
	}

	public bool CheckAllowUse(bool isBattle)
	{
		return default(bool);
	}

	public bool GetSeikaku(out Seikaku seikaku)
	{
		return default(bool);
	}

	public bool IsUsableMajimeMint(Seikaku seikaku)
	{
		return default(bool);
	}

	public bool GetFriendshipValue(uint currentValue, out int addValue, out int maxUsableCount)
	{
		return default(bool);
	}

	public bool IsKanpouyaku()
	{
		return default(bool);
	}
}
