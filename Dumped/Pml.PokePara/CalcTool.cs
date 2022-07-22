namespace Pml.PokePara;

public static class CalcTool
{
	private struct ITEM_TYPE_PARAM
	{
		public ItemNo item;

		public PokeType type;

		public ITEM_TYPE_PARAM(ItemNo _item, PokeType _type)
		{
		}
	}

	private struct ITEM_VIEW_PARAM
	{
		public ItemNo item;

		public Cream2ViewID viewID;

		public ITEM_VIEW_PARAM(ItemNo _item, Cream2ViewID _view)
		{
		}
	}

	private const ushort MIN_HP = 10;

	private const ushort HP_BASE_COEFFICIENT = 2;

	private const ushort HP_EXP_COEFFICIENT = 4;

	private const ushort MIN_ATK = 5;

	private const ushort ATK_BASE_COEFFICIENT = 2;

	private const ushort ATK_EXP_COEFFICIENT = 4;

	private const ushort MIN_DEF = 5;

	private const ushort DEF_BASE_COEFFICIENT = 2;

	private const ushort DEF_EXP_COEFFICIENT = 4;

	private const ushort MIN_SPATK = 5;

	private const ushort SPATK_BASE_COEFFICIENT = 2;

	private const ushort SPATK_EXP_COEFFICIENT = 4;

	private const ushort MIN_SPDEF = 5;

	private const ushort SPDEF_BASE_COEFFICIENT = 2;

	private const ushort SPDEF_EXP_COEFFICIENT = 4;

	private const ushort MIN_AGI = 5;

	private const ushort AGI_BASE_COEFFICIENT = 2;

	private const ushort AGI_EXP_COEFFICIENT = 4;

	private const byte NUKENIN_MAX_HP = 1;

	private const byte MAX_POKE_LEVEL = 100;

	private const int VERSION_HOLOHOLO = 34;

	private static sbyte[][] SEIKAKU_ABI_TBL;

	private static Seikaku[] HIGH_SEIKAKU;

	private static Seikaku[] LOW_SEIKAKU;

	private static PokeType[] TYPE_TABLE;

	public static TasteJudge[,] DESIRED_TASTE_TBL;

	private static WazaNo[] ROTOM_WAZA_TBL;

	private static ITEM_TYPE_PARAM[] ITEM_TYPE_ARUSEUSU;

	private static ITEM_TYPE_PARAM[] ITEM_TYPE_Guripusu2;

	private static ITEM_VIEW_PARAM[] CREAM2_ITEM_TABLE;

	public static byte CalcLevel(MonsNo monsno, ushort formno, uint exp)
	{
		return default(byte);
	}

	public static ushort CalcMaxHp(MonsNo monsno, byte level, ushort basev, ushort rnd, ushort exp)
	{
		return default(ushort);
	}

	public static ushort CalcAtk(byte level, ushort basev, ushort rnd, ushort exp, Seikaku seikaku)
	{
		return default(ushort);
	}

	public static ushort CalcDef(byte level, ushort basev, ushort rnd, ushort exp, Seikaku seikaku)
	{
		return default(ushort);
	}

	public static ushort CalcSpAtk(byte level, ushort basev, ushort rnd, ushort exp, Seikaku seikaku)
	{
		return default(ushort);
	}

	public static ushort CalcSpDef(byte level, ushort basev, ushort rnd, ushort exp, Seikaku seikaku)
	{
		return default(ushort);
	}

	public static ushort CalcAgi(byte level, ushort basev, ushort rnd, ushort exp, Seikaku seikaku)
	{
		return default(ushort);
	}

	public static sbyte GetPowerTransformBySeikaku(ushort seikaku, PowerID powerId)
	{
		return default(sbyte);
	}

	private static ushort CalcCorrectedPowerBySeikaku(ushort value, ushort seikaku, PowerID powerId)
	{
		return default(ushort);
	}

	public static bool IsRareColor(uint id, uint rnd)
	{
		return default(bool);
	}

	private static uint CalcRareCheckValue(uint id, uint rnd)
	{
		return default(uint);
	}

	public static uint CorrectColorRndForNormal(uint id, uint rnd)
	{
		return default(uint);
	}

	public static uint CorrectColorRndForRare(uint id, uint rnd)
	{
		return default(uint);
	}

	public static RareType CalcRareColorType(uint id, uint rnd, uint cassetVersion, bool isEventGetPoke)
	{
		return default(RareType);
	}

	public static RareType CalcRareColorTypeByID(uint id, uint rnd)
	{
		return default(RareType);
	}

	public static uint CorrectColorRndForRareType(uint id, uint rnd, RareType type)
	{
		return default(uint);
	}

	public static Sex GetCorrectSexInPersonalData(MonsNo monsno, ushort formno, Sex bothCase)
	{
		return default(Sex);
	}

	public static bool IsSeikakuHigh(Seikaku seikaku)
	{
		return default(bool);
	}

	public static bool IsSeikakuLow(Seikaku seikaku)
	{
		return default(bool);
	}

	public static Seikaku[] GetSeikakuHigh(out byte pNum)
	{
		return null;
	}

	public static Seikaku[] GetSeikakuLow(out byte pNum)
	{
		return null;
	}

	public static ushort GetTokuseiNo(MonsNo monsno, ushort formno, byte tokuseiIndex)
	{
		return default(ushort);
	}

	public static PokeType CalcMezamerupawaaType(byte hp, byte atk, byte def, byte agi, byte spatk, byte spdef)
	{
		return default(PokeType);
	}

	public static uint CalcMezamerupawaaPower(byte hp, byte atk, byte def, byte agi, byte spatk, byte spdef)
	{
		return default(uint);
	}

	public static TasteJudge JudgeTaste(Seikaku seikaku, Taste taste)
	{
		return default(TasteJudge);
	}

	public static bool CanCreateEgg(MonsNo monsno1, Sex sex1, uint eggGroup1_1, uint eggGroup1_2, MonsNo monsno2, Sex sex2, uint eggGroup2_1, uint eggGroup2_2)
	{
		return default(bool);
	}

	public static LoveLevel CalcLoveLevel(MonsNo monsno1, uint id1, MonsNo monsno2, uint id2)
	{
		return default(LoveLevel);
	}

	public static WazaNo GetRotomuWazaNo(ushort formno)
	{
		return default(WazaNo);
	}

	public static PokeType GetAruseusuType(uint itemno)
	{
		return default(PokeType);
	}

	public static PokeType GetGuripusu2Type(uint itemno)
	{
		return default(PokeType);
	}

	public static bool IsAmezaikuForCream2Evolution(uint itemno)
	{
		return default(bool);
	}

	public static Cream2ViewID GetCream2ViewID(uint itemno)
	{
		return default(Cream2ViewID);
	}

	public static bool DecideFormNoFromHoldItem(MonsNo monsno, uint holdItemno, out ushort formno)
	{
		return default(bool);
	}
}
