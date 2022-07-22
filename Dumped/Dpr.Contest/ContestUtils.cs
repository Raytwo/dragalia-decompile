using Dpr.BallDeco;
using Dpr.Battle.View;
using Dpr.Trainer;
using Pml;
using UnityEngine;
using XLSXContent;

namespace Dpr.Contest;

public static class ContestUtils
{
	public static string CreateTrainerModelPath(int playerFashion)
	{
		return null;
	}

	public static TrainerType CreateTrainerType(bool isOwner, Sex playerSex)
	{
		return default(TrainerType);
	}

	public static TrainerSimpleParam CreateTrainerSimpleParam(TrainerType trainerType, int colorID)
	{
		return default(TrainerSimpleParam);
	}

	public static ContestMasterDatas.SheetRankData FindRankData(int rankPoint, ContestMasterDatas contestMasterDatas)
	{
		return null;
	}

	public static CategoryID LotteryCategory(bool isDpClear)
	{
		return default(CategoryID);
	}

	public static CategoryID[] GetCanEntryCategory(bool isDpClear)
	{
		return null;
	}

	public static RankID LotteryCategory(CategoryID categoryID)
	{
		return default(RankID);
	}

	public static RankID[] GetRankIDsByCategoryID(CategoryID categoryID)
	{
		return null;
	}

	public static string CreateWazaSequencePath(MonsNo monsNo, WazaNo wazaNo, int formNo, PokeType type1, PokeType type2)
	{
		return null;
	}

	public static bool CheckUniqueWaza(MonsNo monsNo, WazaNo wazaNo, int formNo, PokeType type1, PokeType type2)
	{
		return default(bool);
	}

	public static ArenaInfo.SheetArenaData FindArenaDataByID(ArenaID arenaID)
	{
		return null;
	}

	public static LotteryNPCData[] CreateLoatteryNPCDataByCategoryAndRank(ContestMasterDatas.SheetNPCData[] NPCData, CategoryID categoryID, RankID rankID, int createNum)
	{
		return null;
	}

	private static ContestMasterDatas.SheetNPCData[] ChoiceRandomNPCPlayerData(int choiceNum, ContestMasterDatas.SheetNPCData[] npcDatas)
	{
		return null;
	}

	private static int[] CreateShuffledIndexArray(int arrayLength)
	{
		return null;
	}

	public static WazaNo LotNPCUseWazaNo(ContestMasterDatas.SheetNPCData npcData)
	{
		return default(WazaNo);
	}

	public static BtlvBallInfo CreatePlayerBallInfo(BallId ballId)
	{
		return default(BtlvBallInfo);
	}

	public static AffixSealData[] CreateNPCAffixSealDataArray(ContestMasterDatas.SheetNPCCapsuleData npcCapsuleData)
	{
		return null;
	}

	private static AffixSealData CreateAffixSealData(SealID sealID, Vector3 pos)
	{
		return default(AffixSealData);
	}

	public static string CreateNumberIconSprName(int number)
	{
		return null;
	}

	public static string GetCategoryLabelByID(CategoryID categoryID)
	{
		return null;
	}

	public static string GetCategoryLabelByID(CategoryID categoryID, int cassetVersion)
	{
		return null;
	}

	public static string GetCategoryLabelByID(int categoryID)
	{
		return null;
	}

	public static string GetCategoryLabelByID(int categoryID, int cassetVersion)
	{
		return null;
	}

	public static string GetCategoryNameByID(CategoryID categoryID)
	{
		return null;
	}

	public static string GetCategoryNameByID(CategoryID categoryID, int cassetVersion)
	{
		return null;
	}

	public static string GetCategoryNameByID(int categoryID, int cassetVersion)
	{
		return null;
	}

	public static string GetRankLabelByID(RankID rankID)
	{
		return null;
	}

	public static string GetRankLabelByID(int rankID)
	{
		return null;
	}

	public static string GetRankNameByID(RankID rankID)
	{
		return null;
	}

	public static string GetRankNameByID(int rankID)
	{
		return null;
	}

	public static void EmitLog(string log, LogType logType = LogType.Log)
	{
	}
}
