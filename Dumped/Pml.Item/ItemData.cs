namespace Pml.Item;

public class ItemData
{
	public enum PrmID
	{
		ITEMNUMBER = 0,
		PRICE = 1,
		WAT_PRICE = 2,
		BP_PRICE = 3,
		ICONID = 4,
		EQUIP = 5,
		ATTACK = 6,
		TUIBAMU_EFF = 7,
		NAGE_EFF = 8,
		NAGE_ATC = 9,
		SIZEN_ATC = 10,
		SIZEN_TYPE = 11,
		IMP = 12,
		CNV = 13,
		F_POCKET = 14,
		F_FUNC = 15,
		B_FUNC = 16,
		WORK_TYPE = 17,
		ITEM_TYPE = 18,
		SPEND = 19,
		USE_SPEND = 20,
		SORT = 21,
		GROUP = 22,
		GROUPID = 23,
		SET_TO_POKE = 24,
		B_SELECTABLE = 25,
		INACTIVE = 26,
		WORK = 27,
		SLEEP_RCV = 27,
		POISON_RCV = 28,
		BURN_RCV = 29,
		ICE_RCV = 30,
		PARALYZE_RCV = 31,
		PANIC_RCV = 32,
		MEROMERO_RCV = 33,
		ABILITY_GUARD = 34,
		DEATH_RCV = 35,
		ALL_DEATH_RCV = 36,
		LV_UP = 37,
		EVOLUTION = 38,
		ATTACK_UP = 39,
		DEFENCE_UP = 40,
		SP_ATTACK_UP = 41,
		SP_DEFENCE_UP = 42,
		AGILITY_UP = 43,
		HIT_UP = 44,
		CRITICAL_UP = 45,
		PP_UP = 46,
		PP_3UP = 47,
		PP_RCV = 48,
		ALL_PP_RCV = 49,
		HP_RCV = 50,
		HP_EXP = 51,
		POWER_EXP = 52,
		DEFENCE_EXP = 53,
		AGILITY_EXP = 54,
		SP_ATTACK_EXP = 55,
		SP_DEFENCE_EXP = 56,
		EXP_LIMIT_FLAG = 57,
		FRIEND1 = 58,
		FRIEND2 = 59,
		FRIEND3 = 60,
		HP_EXP_POINT = 61,
		POWER_EXP_POINT = 62,
		DEFENCE_EXP_POINT = 63,
		AGILITY_EXP_POINT = 64,
		SP_ATTACK_EXP_POINT = 65,
		SP_DEFENCE_EXP_POINT = 66,
		HP_RCV_POINT = 67,
		PP_RCV_POINT = 68,
		FRIEND1_POINT = 69,
		FRIEND2_POINT = 70,
		FRIEND3_POINT = 71
	}

	public enum WorkType
	{
		NORMAL,
		POKEUSE,
		BALL
	}

	public enum HpRecoverType
	{
		FULL = 255,
		HALF = 254,
		QUOT = 253
	}

	public enum PpRecoverType
	{
		FULL = 127
	}

	public enum ItemType
	{
		ALLDETH_RCV,
		LV_UP,
		NEMURI_RCV,
		DOKU_RCV,
		YAKEDO_RCV,
		KOORI_RCV,
		MAHI_RCV,
		KONRAN_RCV,
		ALL_ST_RCV,
		MEROMERO_RCV,
		HP_RCV,
		DEATH_RCV,
		HP_UP,
		ATC_UP,
		DEF_UP,
		SPA_UP,
		SPD_UP,
		AGI_UP,
		HP_DOWN,
		ATC_DOWN,
		DEF_DOWN,
		SPA_DOWN,
		SPD_DOWN,
		AGI_DOWN,
		EVO,
		PP_UP,
		PP_3UP,
		PP_RCV,
		ETC
	}

	public enum FieldFunctionType
	{
		NONE,
		ITEMUSE_FLD_RECOVER,
		ITEMUSE_FLD_WAZA,
		ITEMUSE_FLD_CYCLE,
		ITEMUSE_FLD_MITSU,
		ITEMUSE_FLD_BAG_MSG,
		ITEMUSE_FLD_EVOLUTION,
		ITEMUSE_FLD_ANANUKE,
		ITEMUSE_FLD_APPLICATION,
		ITEMUSE_FLD_FLY,
		ITEMUSE_FLD_VIDRO,
		ITEMUSE_FLD_MAIL,
		ITEMUSE_FLD_KINOMI,
		ITEMUSE_FLD_FISHING_ROD_GREAT,
		ITEMUSE_FLD_BATTLE_REC,
		ITEMUSE_FLD_FORM_CHANGE,
		ITEMUSE_FLD_DOWSING_MACHINE,
		ITEMUSE_FLD_UNION,
		ITEMUSE_FLD_ROTOPON,
		ITEMUSE_FLD_TANKENSETTO,
		ITEMUSE_FLD_BOUKENNOOTO,
		ITEMUSE_FLD_POFINKEESU,
		ITEMUSE_FLD_POKETORE,
		ITEMUSE_FLD_KODAKKUZYOURO,
		ITEMUSE_FLD_BATORUSAATYAA,
		ITEMUSE_FLD_FISHING_ROD_BORO,
		ITEMUSE_FLD_FISHING_ROD_II,
		ITEMUSE_FLD_TENKAINOHUE,
		ITEMUSE_FLD_POINTOKAADO,
		ITEMUSE_FLD_DS_PLAYER
	}

	public const uint ITEM_WAZAMACHINE_ERROR = uint.MaxValue;

	public const byte NUTS_ID_ERROR = byte.MaxValue;

	public const int FLAG0_MASK_NAGE_EFF = 1;

	public const int FLAG0_MASK_IMP = 2;

	public const int FLAG0_MASK_CNV_BTN = 4;

	public const int FLAG0_MASK_SPEND = 8;

	public const int FLAG0_MASK_BATTLE_SELECTABLE = 16;

	public const int FLAG0_MASK_USE_NO_SPEND = 32;

	public const int FLAG0_MASK_SET_TO_POKE = 64;

	public const int FLAG0_MASK_WORK_TYPE = 128;

	public const int FLAG0_MASK_ABILITY_GUARD = 256;

	public const int FLAG0_MASK_LV_UP = 512;

	public const int FLAG0_MASK_PP_RCV = 1024;

	public const int FLAG0_MASK_ALLPP_RCV = 2048;

	public const int FLAG0_MASK_PP_UP = 4096;

	public const int FLAG0_MASK_PP_3UP = 8192;

	public const int FLAG0_MASK_EXP_LIMIT = 16384;

	public const int FLAG0_MASK_SLEEP_RCV = 32768;

	public const int FLAG0_MASK_POISON_RCV = 65536;

	public const int FLAG0_MASK_BURN_RCV = 131072;

	public const int FLAG0_MASK_ICE_RCV = 262144;

	public const int FLAG0_MASK_PARALAYZE_RCV = 524288;

	public const int FLAG0_MASK_PANIC_RCV = 1048576;

	public const int FLAG0_MASK_MEROMERO_RCV = 2097152;

	public const int FLAG0_MASK_DEATH_RCV = 4194304;

	public const int FLAG0_MASK_ALLDEATH_RCV = 8388608;

	public const int FLAG0_MASK_EVOLUTION = 16777216;

	public const int FLAG0_MASK_INACTIVE = int.MinValue;

	public static int GetParam(ushort itemno, PrmID prmID)
	{
		return default(int);
	}

	public static uint GetHealingItemType(ushort itemno)
	{
		return default(uint);
	}

	public static bool IsNeedSelectSkill(ushort itemno)
	{
		return default(bool);
	}

	public static bool IsDeathRecoverAllItem(ushort itemno)
	{
		return default(bool);
	}

	public static bool IsSale(ushort itemno)
	{
		return default(bool);
	}

	public static bool IsEventItem(ushort itemno)
	{
		return default(bool);
	}

	public static int GetGroupId(ushort itemno)
	{
		return default(int);
	}

	public static BallId GetBallID(ushort itemno)
	{
		return default(BallId);
	}

	public static ushort BallId2ItemId(BallId ballId)
	{
		return default(ushort);
	}

	public static bool IsWazaMachine(ushort itemno)
	{
		return default(bool);
	}

	public static WazaNo GetWazaNo(ushort itemno)
	{
		return default(WazaNo);
	}

	public static uint GetWazaMashineNo(ushort item)
	{
		return default(uint);
	}

	public static uint GetWazaMashineMax()
	{
		return default(uint);
	}

	public static WazaNo GetWazaMashineWaza(byte machine_no)
	{
		return default(WazaNo);
	}

	public static ItemNo GetWazaMashineItemNo(byte machine_no)
	{
		return default(ItemNo);
	}

	public static bool IsWazaRecord(ushort itemno)
	{
		return default(bool);
	}

	public static bool IsNuts(ushort itemno)
	{
		return default(bool);
	}

	public static byte GetNutsNo(ushort itemno)
	{
		return default(byte);
	}

	public static ushort NutsIDToItemNo(byte nutsid)
	{
		return default(ushort);
	}

	public static bool IsGroupOf(ushort itemno, byte itemgroup)
	{
		return default(bool);
	}

	public static bool IsMegaStone(ushort itemno)
	{
		return default(bool);
	}

	public static bool IsJewel(ushort itemno)
	{
		return default(bool);
	}

	public static bool IsPiece(ushort itemno)
	{
		return default(bool);
	}

	public static bool IsBeads(ushort itemno)
	{
		return default(bool);
	}

	public static bool IsHeart(ushort itemno)
	{
		return default(bool);
	}

	public static bool CanPokeHave(ushort itemno)
	{
		return default(bool);
	}

	public static bool IsValid(ushort item)
	{
		return default(bool);
	}

	public static uint GetTypeSortNumber(ushort itemno)
	{
		return default(uint);
	}
}
