using System;
using System.Runtime.InteropServices;
using DPData;
using Pml;
using XLSXContent;

public class HoneyWork
{
	public enum State
	{
		Invalid,
		HONEY_SPREAD_OK,
		HONEY_SPREAD_ALREADY,
		HONEY_SPREAD_ENCOUNT
	}

	public enum TableType
	{
		Normal,
		Rare,
		SuperRare,
		Miss,
		Count
	}

	public enum SwayType
	{
		Normal,
		Big,
		Super,
		None,
		Count
	}

	private static DateTime? LastUpdateTime;

	private const int EncountTime = 360;

	private const int VanishTime = 1440;

	public const int RareTreeCount = 4;

	public const int ContinueProbability = 90;

	public static int GetTblMonsCount()
	{
		return default(int);
	}

	public static int GetRareLvCount()
	{
		return default(int);
	}

	public static int GetSwayLvCount()
	{
		return default(int);
	}

	public static HONEY_DATA? GetHoneyData(ZoneID zoneId)
	{
		return null;
	}

	public static HONEY_DATA GetHoneyDataByIndex(int treeIndex)
	{
		return default(HONEY_DATA);
	}

	public static void SetHoneyData(ZoneID zoneId, [In] ref HONEY_DATA honeyData)
	{
	}

	public static void SetHoneyDataByIndex(int treeIndex, [In] ref HONEY_DATA honeyData)
	{
	}

	public static ZoneID IndexToZoneId(int treeIndex)
	{
		return default(ZoneID);
	}

	public static int ZoneIdToIndex(ZoneID zoneId)
	{
		return default(int);
	}

	public static HoneyTree.SheetHoneyTreeIndex[] GetIndexToZoneIdTable()
	{
		return null;
	}

	public static int GetTreeCount()
	{
		return default(int);
	}

	public static void UpdateTime()
	{
	}

	public static void UpdateTime(int minute)
	{
	}

	public static void Spread(int treeIndex)
	{
	}

	public static bool IsRateTree(int checkTreeIndex)
	{
		return default(bool);
	}

	public static TableType LotteryTableType(bool isRareTree)
	{
		return default(TableType);
	}

	public static int LotteryTableMonsNo()
	{
		return default(int);
	}

	public static MonsNo GetMonsNo(TableType tableType, int tblMonsNo)
	{
		return default(MonsNo);
	}

	public static SwayType LotterySwayType(TableType tableType)
	{
		return default(SwayType);
	}

	public static State CalcState([In] ref HONEY_DATA data)
	{
		return default(State);
	}
}
