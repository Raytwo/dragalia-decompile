using System.Collections.Generic;
using DPData;
using Dpr.Message;
using Pml;
using Pml.PokePara;
using XLSXContent;

public class InterviewWork
{
	public enum Type
	{
		None,
		_Dummy_1,
		BattleTower,
		_Dummy_3,
		YourPokemon,
		_Dummy_5,
		Poketch,
		Contest,
		_Dummy_8,
		_Dummy_9,
		Personality,
		Poffin,
		_Dummy_12,
		Tsurearuki,
		BallDecoration
	}

	public enum PoffineTaste
	{
		Kotteri = 1,
		Kudoi,
		Mazui,
		Maroyaka,
		Etc
	}

	private static Dictionary<int, int> TypeToProgramDict;

	private static TV_PROGRAM TypeToProgram(Type type)
	{
		return default(TV_PROGRAM);
	}

	private static Type ProgramToType(TV_PROGRAM tvProgram)
	{
		return default(Type);
	}

	private static INTERVIEWER_PROGRAM TypeToInterviewBranchProgram(Type type)
	{
		return default(INTERVIEWER_PROGRAM);
	}

	private static TV_DATA_ID_INT_DEF InterviewToTvRecordInt(INTERVIEWER_DATA_ID_INT_DEF index)
	{
		return default(TV_DATA_ID_INT_DEF);
	}

	private static INTERVIEWER_DATA_ID_INT_DEF TvToInterviewRecordInt(TV_DATA_ID_INT_DEF index)
	{
		return default(INTERVIEWER_DATA_ID_INT_DEF);
	}

	private static TV_DATA_ID_STR_DEF InterviewToTvRecordStr(INTERVIEWER_DATA_ID_STR_DEF index)
	{
		return default(TV_DATA_ID_STR_DEF);
	}

	private static INTERVIEWER_DATA_ID_STR_DEF TvToInterviewRecordStr(TV_DATA_ID_STR_DEF index)
	{
		return default(INTERVIEWER_DATA_ID_STR_DEF);
	}

	public static TvDataTable.Sheetdata GetTableData(Type type)
	{
		return null;
	}

	public static void SetInterviewBranchData(INTERVIEWER_PROGRAM index, int value)
	{
	}

	public static void SetInterviewRecordStr(INTERVIEWER_DATA_ID_STR_DEF index, string value)
	{
	}

	public static void SetInterviewRecordStr(INTERVIEWER_DATA_ID_STR_DEF index, string value, byte language)
	{
	}

	public static void SetInterviewRecordStr(INTERVIEWER_DATA_ID_STR_DEF index, string value, byte language, byte genderId)
	{
	}

	public static void SetInterviewRecordInt(INTERVIEWER_DATA_ID_INT_DEF index, int value)
	{
	}

	public static void ApplyInterviewToTopic(Type type)
	{
	}

	public static void ApplyInterviewBranchData(INTERVIEWER_PROGRAM index)
	{
	}

	public static void ApplyInterviewRecordStr(INTERVIEWER_DATA_ID_STR_DEF index)
	{
	}

	public static void ApplyInterviewRecordInt(INTERVIEWER_DATA_ID_INT_DEF index)
	{
	}

	public static int GetInterviewBranchData(INTERVIEWER_PROGRAM index)
	{
		return default(int);
	}

	public static void GetInterviewRecordStr(INTERVIEWER_DATA_ID_STR_DEF index, out string str, out MessageEnumData.MsgLangId langId)
	{
	}

	public static bool Check(Type type)
	{
		return default(bool);
	}

	public static void SetTopicRecord(Type type)
	{
	}

	public static void SetAndEnableTopicPersonality(int pokeType)
	{
	}

	public static void SetAndEnableTopicBallDecoration(int ballDecorationTrainer)
	{
	}

	public static void SetTopicRecordBattleTower(int winCount, bool win)
	{
	}

	public static void SetTopicRecordContest(PokemonParam param, int contestName, int contestRank, int contestRankingNumber)
	{
	}

	public static void SetTopicRecordPoffin(PoffineTaste poffineTaste, int poffinType)
	{
	}

	public static void SetTopicRecordTsureArukiPokemon(PokemonParam param)
	{
	}

	public static void SetTopicRecordTsureArukiItemNo(ItemNo itemNo)
	{
	}
}
