using System;
using DPData;
using Dpr.EvScript;
using Dpr.Message;
using Pml;
using Pml.PokePara;
using XLSXContent;

public static class TvWork
{
	public class RecordData
	{
		public class PersonalityData
		{
			public int BranchData;

			public TV_STR_DATA PlayerName;
		}

		public class BallDecorationData
		{
			public int BranchData;

			public int Trainer;
		}

		public class KasekihoriData
		{
			public int BranchData;

			public int ItemNo;

			public TV_STR_DATA PlayerName;
		}

		public class StatueData
		{
			public int BranchData;

			public int StatueCount;

			public TV_STR_DATA PlayerName;
		}

		public class FashionData
		{
			public int BranchData;

			public int Style;

			public int PlaceNo;

			public TV_STR_DATA PlayerName;
		}

		public PersonalityData Personality;

		public BallDecorationData BallDecoration;

		public KasekihoriData Kasekihori;

		public StatueData Statue;

		public FashionData Fashion;
	}

	public static MessageEnumData.GenderID CurrentStrDataGenderId;

	private static ZoneID[] WeatherReportZone;

	private static readonly int[] IgnoreDouguMotteruYasei;

	public static int RandRange(int min, int max)
	{
		return default(int);
	}

	public static void GetLinkRecord(TV_PROGRAM tvProgram, out TV_DATA_ID_INT[] recordInt, out TV_DATA_ID_STR[] recordStr)
	{
	}

	public static void Initialize()
	{
	}

	public static void RecordTvIntDataSet(TV_DATA_ID_INT index, int value)
	{
	}

	public static void RecordTvIntDataSet(TV_DATA_ID_INT_DEF index, int value)
	{
	}

	public static void RecordTvStrDataSet(TV_DATA_ID_STR index, string value)
	{
	}

	public static void RecordTvStrDataSet(TV_DATA_ID_STR index, string value, byte language)
	{
	}

	public static void RecordTvStrDataSet(TV_DATA_ID_STR index, string value, byte language, byte genderId)
	{
	}

	public static void RecordTvStrDataSet(TV_DATA_ID_STR_DEF index, string value)
	{
	}

	public static void RecordTvStrDataSet(TV_DATA_ID_STR_DEF index, string value, byte language)
	{
	}

	public static void RecordTvStrDataSet(TV_DATA_ID_STR_DEF index, string value, byte language, byte genderId)
	{
	}

	public static void TvBranchDataSet(TV_PROGRAM index, int value)
	{
	}

	public static void TVTpicEnable(TV_PROGRAM index)
	{
	}

	public static void TVTpicDisable(TV_PROGRAM index)
	{
	}

	public static int GetRecordTvIntData(TV_DATA_ID_INT index)
	{
		return default(int);
	}

	public static int GetRecordTvIntData(TV_DATA_ID_INT_DEF index)
	{
		return default(int);
	}

	public static string GetRecordTvStrData(TV_DATA_ID_STR index)
	{
		return null;
	}

	public static string GetRecordTvStrData(TV_DATA_ID_STR_DEF index)
	{
		return null;
	}

	public static void GetRecordTvStrData(TV_DATA_ID_STR index, out string str, out MessageEnumData.MsgLangId langId)
	{
	}

	public static void GetRecordTvStrData(TV_DATA_ID_STR_DEF index, out string str, out MessageEnumData.MsgLangId langId)
	{
	}

	public static void GetRecordTvStrData(TV_DATA_ID_STR index, out string str, out MessageEnumData.MsgLangId langId, out MessageEnumData.GenderID genderId)
	{
	}

	public static void GetRecordTvStrData(TV_DATA_ID_STR_DEF index, out string str, out MessageEnumData.MsgLangId langId, out MessageEnumData.GenderID genderId)
	{
	}

	public static int GetTvBranchData(TV_PROGRAM index)
	{
		return default(int);
	}

	public static bool GetTVTpicCreate(TV_PROGRAM index)
	{
		return default(bool);
	}

	public static void AddTvWatchCount()
	{
	}

	public static int GetTvWatchCount()
	{
		return default(int);
	}

	public static EvWork.WORK_INDEX GetOverSaveDataIntMyWorkIndex(TV_DATA_ID_INT index)
	{
		return default(EvWork.WORK_INDEX);
	}

	public static EvWork.WORK_INDEX GetOverSaveDataIntUseWorkIndex(TV_DATA_ID_INT index)
	{
		return default(EvWork.WORK_INDEX);
	}

	public static RecordData CreateRecordData()
	{
		return null;
	}

	public static void ApplyRecordData(RecordData recordData)
	{
	}

	private static bool CheckEnableRecordProgram(TV_PROGRAM tvProgram)
	{
		return default(bool);
	}

	private static int GetMyBranchData(TV_PROGRAM tvProgram)
	{
		return default(int);
	}

	private static TV_STR_DATA GetMyStrData(TV_DATA_ID_STR_DEF index)
	{
		return default(TV_STR_DATA);
	}

	private static int GetMyIntData(TV_DATA_ID_INT_DEF index)
	{
		return default(int);
	}

	private static void SetUseBranchData(TV_PROGRAM tvProgram, int value)
	{
	}

	private static void SetUseStrData(TV_DATA_ID_STR_DEF index, TV_STR_DATA value)
	{
	}

	private static void SetUseIntData(TV_DATA_ID_INT_DEF index, int value)
	{
	}

	public static TvDataTable.Sheetdata GetTableData(TV_PROGRAM tvProgram)
	{
		return null;
	}

	public static TvDataTable.Sheetdata GetTableData(int tvProgram)
	{
		return null;
	}

	public static int GetChannel()
	{
		return default(int);
	}

	public static int GetChannel(int hour, int minute, DayOfWeek dayOfWeek)
	{
		return default(int);
	}

	public static TV_PROGRAM FindEnableProgram()
	{
		return default(TV_PROGRAM);
	}

	public static bool CheckEnableProgram(TV_PROGRAM id)
	{
		return default(bool);
	}

	public static int[] GetCommercialIndexArray()
	{
		return null;
	}

	private static bool FlagCheck(EvWork.SYSFLAG_INDEX flagIndex)
	{
		return default(bool);
	}

	public static void CapturePokemon(PokemonParam param, int ballcnt)
	{
	}

	public static void CaptureFailed(int ballcnt, bool isWin)
	{
	}

	public static void SetFishing(FishingRod rod, MonsNo monsno)
	{
	}

	public static void ChangeGroupName()
	{
	}

	public static void HiddenItem(ItemNo itemNo)
	{
	}

	public static void EggHatch(PokemonParam param, int placeNo)
	{
	}

	public static void Seimeihandan(PokemonParam param)
	{
	}

	public static void Kasekihori(int itemNo)
	{
	}

	public static void Safari(MonsNo monsNo, int safariCount)
	{
	}

	public static void Ryouyaku(PokemonParam param, ItemNo itemNo)
	{
	}

	public static void KinomiHousaku(ItemNo itemNo, int itemCount)
	{
	}

	public static void NewGroup()
	{
	}

	public static void CustumBallSakusei(int sealName, MonsNo monsNo)
	{
	}

	public static void RareMonohiroi(ItemNo itemNo, PokemonParam param)
	{
	}

	public static void HimitsukichiReceiveNice(int niceCount)
	{
	}

	public static void HimitsukichiSendNice(int niceCount)
	{
	}

	public static void BtlTowerRensyouKousin(MonsNo monsNo, int winCount, bool isDouble)
	{
	}

	public static void OokisasokuteiKousin(MonsNo monsNo, int sizeValue)
	{
	}

	public static void KinomiMeijin(ItemNo itemNo)
	{
	}

	public static void SafariMeijin(int pokemonCount)
	{
	}

	public static void SekizouHakkutunin(int statueCount)
	{
	}

	public static void Hikariishi(int hikariishiCount)
	{
	}

	public static void GroupSyoukai(int groupPokemonType, string groupName, string memberName)
	{
	}

	public static void WeatherReport(int weatherNo, int placeNo)
	{
	}

	public static void TairyouHassei(int placeNo, MonsNo monsNo)
	{
	}

	public static void PokemonAisyou(int aisyou, int pokemonType, int effectivePokemonType)
	{
	}

	public static void KinomiJouhou(int state, int placeNo)
	{
	}

	public static void DouguMotteruYasei(MonsNo monsNo, ItemNo itemNo)
	{
	}

	public static void FashionChange(int style, int placeNo)
	{
	}

	public static void MakeDailyTopic()
	{
	}

	public static void MakeTairyouhasseiTopic()
	{
	}
}
