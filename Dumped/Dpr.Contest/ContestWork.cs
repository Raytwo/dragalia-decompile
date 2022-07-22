using DPData;
using Dpr.BallDeco;
using Dpr.EvScript;
using Pml.PokePara;

namespace Dpr.Contest;

public static class ContestWork
{
	public static EntryPlayerData[] entryPlayerDatas;

	public static CategoryID categoryID;

	public static int cassetVersion;

	public static RankID rankID;

	public static ContestMode playMode;

	public static uint selectPartyIndex;

	public static byte selectWazaIndex;

	public static int selectCapsuleNumber;

	public static int contestStageRank;

	public static ushort playerFashion;

	public static MSGSPEED sceneMsgSpeed;

	public static bool IsMultiMode => default(bool);

	public static void SetResultData(ContestRewardDataModel resultDataModel)
	{
	}

	private static void SetSingleModeResultData(ContestRewardDataModel resultDataModel)
	{
	}

	private static void SetMultiModeResultData(ContestRewardDataModel resultDataModel)
	{
	}

	public static bool IsCassetVersionDprB()
	{
		return default(bool);
	}

	public static int GetUserContestPoint()
	{
		return default(int);
	}

	public static void SetUserContestPoint(uint newPoint)
	{
	}

	public static CapsuleData GetSelectCapsuleData()
	{
		return default(CapsuleData);
	}

	public static void ApplyUserDataToEntryPlayerData(int userEntryNumber)
	{
	}

	public static PokemonParam GetEntryMemberPokemon(uint memberIndex)
	{
		return null;
	}

	private static PokemonParam CreateDummyMonster()
	{
		return null;
	}

	public static void AddRewardItem(SealID sealNo, int itemCount)
	{
	}

	public static int CheckContestEntry(CategoryID categoryID, RankID rankID)
	{
		return default(int);
	}

	public static bool CanEntryContest(PokemonParam pokeParam, CategoryID categoryID)
	{
		return default(bool);
	}

	private static bool CheckPokeStatus(PokemonParam pokeParam)
	{
		return default(bool);
	}

	private static bool CheckEntryFurContest(PokemonParam pokeParam)
	{
		return default(bool);
	}

	private static bool CheckRankClearFlag(CategoryID categoryID, RankID rankID)
	{
		return default(bool);
	}

	private static bool IsClearPrevRank(CategoryID categoryID, RankID rankID)
	{
		return default(bool);
	}

	public static void ApplyContestRecord(ContestRewardDataModel resultDataModel)
	{
	}

	private static void UpdateContestEntryCnt()
	{
	}

	private static void UpdateBestPerformerCnt()
	{
	}

	private static void UpdateContestClearRank()
	{
	}

	private static void UpdateWinRate()
	{
	}

	private static void UpdateGetRibbonCnt(bool hasCategoryRibbon, bool hasContestStarRibbon, bool hasTwinkleStarRibbon)
	{
	}

	public static void ApplyContestTVData()
	{
	}

	public static void ApplyReportData_MultiMode(ResultDataModel resultDataModel)
	{
	}

	public static EvWork.SYSFLAG_INDEX FindStandardContestClearFlagIndex(CategoryID categoryID, RankID rankID)
	{
		return default(EvWork.SYSFLAG_INDEX);
	}

	public static EvWork.SYSFLAG_INDEX FindSercretContestClearFlagIndex(RankID rankID)
	{
		return default(EvWork.SYSFLAG_INDEX);
	}

	public static void ResetContestData()
	{
	}

	public static void SaveContestPhotoData(CategoryID categoryID, RankID rankID, CaptureData captureData)
	{
	}

	private static void ResetPhotoFxData(ref CON_PHOTO_FX_DATA targetData)
	{
	}

	private static void SetMonsLanguageID(CategoryID categoryID, byte langID)
	{
	}

	private static void SetPhotoMonsName(CategoryID categoryID, string nickname)
	{
	}
}
