namespace Pml.PokePara;

public class EggGenerator
{
	public delegate uint SavedRandomFunc(uint maxValue);

	public class Setting
	{
		public uint IDNo;

		public string parentName;

		public bool haveItem_HIKARUOMAMORI;

		public SavedRandomFunc randFunc;

		public byte realRegionFormNo;
	}

	private static readonly uint[][] BABY_TABLE;

	private static readonly uint[] POWER_ITEMS;

	public static PokemonParam CreateEgg(CoreParam poke1, CoreParam poke2, Setting setting)
	{
		return null;
	}

	public static CoreParam CreateEgg_CoreParam(CoreParam poke1, CoreParam poke2, Setting setting)
	{
		return null;
	}

	private static void DecideParents(Parents parents, CoreParam poke1, CoreParam poke2)
	{
	}

	private static void CorrectParents_SEX(Parents parents)
	{
	}

	private static void CorrectParents_METAMON(Parents parents)
	{
	}

	private static void ReverseParents(Parents parents)
	{
	}

	private static CoreParam GetBasePokemon_forMonsNo(Parents parents)
	{
		return null;
	}

	private static CoreParam GetBasePokemon_forForm(Parents parents)
	{
		return null;
	}

	private static void DecideEggParams(EggParam egg_param, Parents parents, Setting setting)
	{
	}

	private static void DecideEggParam_MonsNo_BASIC(EggParam egg, Parents parents)
	{
	}

	private static void DecideEggParam_MonsNo_NIDORAN(EggParam egg, Parents parents, SavedRandomFunc randFunc)
	{
	}

	private static void DecideEggParam_MonsNo_BARUBIITO(EggParam egg, Parents parents, SavedRandomFunc randFunc)
	{
	}

	private static void DecideEggParam_MonsNo_FIONE(EggParam egg, Parents parents)
	{
	}

	private static void DecideEggParam_MonsNo_FormNo_BABY(EggParam egg, Parents parents)
	{
	}

	private static void DecideEggParam_Form_BASIC(EggParam egg, Parents parents)
	{
	}

	private static void DecideEggParam_Form_KAWARAZUNOISHI(EggParam egg, Parents parents)
	{
	}

	private static void DecideEggParam_Form_REGION(EggParam egg, Parents parents, Setting setting)
	{
	}

	private static void DecideEggParam_Form_SIRUKII(EggParam egg, Parents parents, SavedRandomFunc randFunc)
	{
	}

	private static void DecideEggParam_Form_MINOMUTTI(EggParam egg, Parents parents)
	{
	}

	private static void DecideEggParam_Sex(EggParam egg, MonsNo monsno, ushort formno, SavedRandomFunc randFunc)
	{
	}

	private static void DecideEggParam_Seikaku_BASIC(EggParam egg, Parents parents, SavedRandomFunc randFunc)
	{
	}

	private static void DecideEggParam_Seikaku_KAWARAZUNOISI(EggParam egg, Parents parents, SavedRandomFunc randFunc)
	{
	}

	private static void DecideEggParam_TokuseiIndex(EggParam egg, Parents parents, SavedRandomFunc randFunc)
	{
	}

	private static void DecideEggParam_BirthCount(EggParam egg)
	{
	}

	private static void DecideDerivedTalentPower_AKAIITO(EggParam egg, Parents parents)
	{
	}

	private static void DecideDerivedTalentPower_ITEM(EggParam egg, Parents parents, SavedRandomFunc randFunc)
	{
	}

	private static void DecideDerivedTalentPower_RANDOM(EggParam egg, Parents parents, SavedRandomFunc randFunc)
	{
	}

	private static void DecideEggParam_TalentPower_RANDOM(EggParam egg, Parents parents, SavedRandomFunc randFunc)
	{
	}

	private static void DecideEggParam_TalentPower_DERIVE(EggParam egg, Parents parents)
	{
	}

	private static void DecideEggParam_PersonalRnd(EggParam egg, Parents parents, SavedRandomFunc randFunc)
	{
	}

	private static void DecideEggParam_RareRnd(EggParam egg, Parents parents, bool have_HIKARUOMAMORI, SavedRandomFunc randFunc)
	{
	}

	private static void DecideEggParam_Waza_DEFAULT(EggParam egg)
	{
	}

	private static void PushWaza_to_EggParam(EggParam egg, WazaNo wazano)
	{
	}

	private static void PushEggWaza_to_EggParam(EggParam egg, CoreParam parent, EggWazaData eggWazaData)
	{
	}

	private static void DecideEggParam_Waza_EGG(EggParam egg, Parents parents)
	{
	}

	private static void DecideEggParam_Waza_PARENTS(EggParam egg, Parents parents)
	{
	}

	private static void DecideEggParam_Waza_PITYUU(EggParam egg, Parents parents)
	{
	}

	private static void DecideEggParam_Waza_MACHINE(EggParam egg, Parents parents)
	{
	}

	private static void DecideEggParam_BallID(EggParam egg, Parents parents, SavedRandomFunc randFunc)
	{
	}

	private static bool IsWazaMachineAbleToUse(MonsNo monsno, ushort formno, ushort itemno)
	{
		return default(bool);
	}

	private static void SetupEggParam(CoreParam egg, EggParam egg_param, Parents parents, Setting setting)
	{
	}

	private static bool isFormInheritEnableByKawarazuNoIshi(ref ushort pFormNo, CoreParam pParent)
	{
		return default(bool);
	}

	private static MonsNo GetSeedMonsNo(MonsNo monsno, ushort formno)
	{
		return default(MonsNo);
	}
}
