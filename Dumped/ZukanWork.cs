using DPData;
using Dpr.Message;
using Pml;
using Pml.PokePara;

public static class ZukanWork
{
	public static int[] ShinouZukanNos;

	private static int[] ShinouZukanCompSeeExcludeNos;

	private static int[] ZenkokuZukanCompGetExcludeNos;

	private static int[] ZukanRatingExcludeNos;

	private const uint No_Unknown = 201u;

	private const uint No_Powarun = 351u;

	private const uint No_Deokisisu = 386u;

	private const uint No_Mino = 412u;

	private const uint No_MinoManadam = 413u;

	private const uint No_Gaameiru = 414u;

	private const uint No_Therimu = 421u;

	private const uint No_Karanakusi = 422u;

	private const uint No_Toritodon = 423u;

	private const uint No_Rotom = 479u;

	private const uint No_Girathina = 487u;

	private const uint No_Sheimi = 492u;

	private const uint No_Aruseusu = 493u;

	private static ZUKAN_SORT_TYPE zukanSortType;

	private static int[] viewModelUniqueIDs;

	public static int ListIndex;

	public static float ListScrollPosition;

	public static int SelectLanguageIndex;

	public static bool IsShowFootPrintBoth;

	public static bool IsShowDescription;

	public static bool IsShowShinouZukan;

	public static ZUKAN_WORK work => default(ZUKAN_WORK);

	public static void Reset()
	{
	}

	public static void ZukanON()
	{
	}

	public static void ZenkokuON()
	{
	}

	public static void ZenkokuReset()
	{
	}

	public static bool GetZenkokuFlag()
	{
		return default(bool);
	}

	public static int GetCount(bool isRating = false)
	{
		return default(int);
	}

	public static int GetSinouCount(bool isRating = false)
	{
		return default(int);
	}

	public static int SeeCount(bool isRating = false)
	{
		return default(int);
	}

	public static int SeeSinouCount(bool isRating = false)
	{
		return default(int);
	}

	public static void SetPoke(uint monsno, GET_STATUS get, Sex sex, int form, bool color)
	{
	}

	public static void SetPoke(PokemonParam mons, GET_STATUS get)
	{
	}

	public static bool IsGet(uint monsno)
	{
		return default(bool);
	}

	public static bool IsSee(uint monsno)
	{
		return default(bool);
	}

	public static bool IsUwasa(uint monsno)
	{
		return default(bool);
	}

	public static GET_STATUS GetStatus(uint monsno)
	{
		return default(GET_STATUS);
	}

	public static bool IsGet(uint monsno, Sex sex, int form, bool color)
	{
		return default(bool);
	}

	public static ZUKAN_SORT_TYPE GetSortType()
	{
		return default(ZUKAN_SORT_TYPE);
	}

	public static void SetSortType(ZUKAN_SORT_TYPE sortType)
	{
	}

	public static int GetViewModelUniqueID(uint monsno)
	{
		return default(int);
	}

	public static void SetViewModelUniqueID(uint monsno, int uniqueID)
	{
	}

	public static void IncrementBattleCount(uint no, bool isCaptured)
	{
	}

	public static bool CheckShinouZukanCompSee()
	{
		return default(bool);
	}

	public static bool CheckZenkokuZukanCompGet()
	{
		return default(bool);
	}

	public static bool IsLangFlag(uint monsno, MessageEnumData.MsgLangId msglang)
	{
		return default(bool);
	}

	public static void AddLangFlag(uint monsno, MessageEnumData.MsgLangId msglang)
	{
	}

	public static uint GetPersonalRnd(MonsNo monsNo, Sex sex, ushort formNo, bool isRare)
	{
		return default(uint);
	}

	public static void CheckLangFlags()
	{
	}

	private static void UpdatePersonalRnd(PokemonParam pokemonParam, GET_STATUS get)
	{
	}

	private static int GetPersonalRndIndex(Sex sex, ushort formNo, bool isRare)
	{
		return default(int);
	}

	private static bool[] GetFormFlags(uint monsno, Sex sex, bool color)
	{
		return null;
	}

	public static void DebugSet(uint monsno, GET_STATUS get, Sex sex, int form, bool color, bool isGet)
	{
	}

	public static void DebugSetLangFlag(uint monsno, MessageEnumData.MsgLangId msglang, bool flag)
	{
	}

	public static int GetZukanNo(PokemonParam pokemonParam)
	{
		return default(int);
	}
}
