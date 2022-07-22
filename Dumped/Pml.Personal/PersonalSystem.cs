using Dpr.Message;
using XLSXContent;

namespace Pml.Personal;

public static class PersonalSystem
{
	private static PersonalTable m_alldata;

	private static GrowTable m_allGrowData;

	private static EvolveTable m_allEvolveData;

	private static WazaOboeTable m_allWazaOboeData;

	private static PersonalTable.SheetPersonal s_PersonalData;

	private static GrowTable.SheetData s_GrowTable;

	private static EvolveTable.SheetEvolve s_EvolutionTable;

	private static WazaOboeTable.SheetWazaOboe s_WazaOboeData;

	private static readonly WazaNo[] OSHIE_WAZA;

	public static void Initialize(PersonalTable personalTotal, WazaOboeTable wazaoboeTotal, GrowTable growTableTotal, EvolveTable evolveTableTotal)
	{
	}

	public static int GetMonsLabel(MonsNo monsno)
	{
		return default(int);
	}

	public static string GetMonsName(MonsNo monsNo)
	{
		return null;
	}

	public static string GetMonsName(MonsNo monsNo, MessageEnumData.MsgLangId langId)
	{
		return null;
	}

	public static bool CheckPokeExist(MonsNo monsno, ushort formno)
	{
		return default(bool);
	}

	public static void LoadPersonalData(MonsNo monsno, ushort formno)
	{
	}

	public static PersonalTable.SheetPersonal GetPersonalData(MonsNo monsno, ushort formno)
	{
		return null;
	}

	private static uint GetDataID(MonsNo monsno, ushort formno)
	{
		return default(uint);
	}

	public static uint GetPersonalParam(ParamID paramId)
	{
		return default(uint);
	}

	public static bool CheckPersonalWazaMachine(ushort machineNo)
	{
		return default(bool);
	}

	public static bool CheckPersonalWazaRecord(ushort recordNo)
	{
		return default(bool);
	}

	public static bool CheckPersonalWazaOshie(ushort oshieNo)
	{
		return default(bool);
	}

	public static SexType GetPersonalSexType()
	{
		return default(SexType);
	}

	public static TokuseiPattern GetTokuseiPattern()
	{
		return default(TokuseiPattern);
	}

	public static void LoadGrowTable(MonsNo monsno, ushort formno)
	{
	}

	public static void LoadGrowTable(uint grow_type)
	{
	}

	public static GrowTable.SheetData GetGrowTable(MonsNo monsno, ushort formno)
	{
		return null;
	}

	public static GrowTable.SheetData GetGrowTable(uint grow_type)
	{
		return null;
	}

	public static uint GetMinExp(byte level)
	{
		return default(uint);
	}

	public static void LoadWazaOboeData(MonsNo monsno, ushort formno)
	{
	}

	public static WazaOboeTable.SheetWazaOboe GetWazaOboeData(MonsNo monsno, ushort formno)
	{
		return null;
	}

	public static byte GetWazaOboeNum()
	{
		return default(byte);
	}

	public static ushort GetWazaOboeLevel(ushort index)
	{
		return default(ushort);
	}

	public static ushort GetWazaOboeWazaNo(ushort index)
	{
		return default(ushort);
	}

	public static OboeWazaKind GetWazaOboeKind(ushort index)
	{
		return default(OboeWazaKind);
	}

	public static int GetOshieWazaNum()
	{
		return default(int);
	}

	public static WazaNo GetOshieWazaNo(int idx)
	{
		return default(WazaNo);
	}

	public static void LoadEvolutionTable(MonsNo monsno, ushort formno)
	{
	}

	public static EvolveTable.SheetEvolve GetEvolutionTable(MonsNo monsno, ushort formno)
	{
		return null;
	}

	public static byte GetEvolutionRouteNum()
	{
		return default(byte);
	}

	public static EvolveCond GetEvolutionCondition(byte route_index)
	{
		return default(EvolveCond);
	}

	public static EvolveCond GetEvolutionCondition(MonsNo next_monsno)
	{
		return default(EvolveCond);
	}

	public static ushort GetEvolutionParam(byte route_index)
	{
		return default(ushort);
	}

	public static MonsNo GetEvolvedMonsNo(byte route_index)
	{
		return default(MonsNo);
	}

	public static ushort GetEvolvedFormNo(byte route_index)
	{
		return default(ushort);
	}

	public static bool IsEvolvedFormNoSpecified(byte route_index)
	{
		return default(bool);
	}

	public static byte GetEvolveEnableLevel(byte route_index)
	{
		return default(byte);
	}

	public static AddPersonalTable.SheetAddPersonal GetAddPersonalData(MonsNo monsno, ushort formno)
	{
		return null;
	}

	private static uint GetDataID_AddPersonal(MonsNo monsno, ushort formno)
	{
		return default(uint);
	}
}
