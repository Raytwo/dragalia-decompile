using System;
using DPData;
using Pml;
using XLSXContent;

public class KinomiWork
{
	public enum GrowPhase
	{
		Empty,
		Seed,
		Sprout,
		Trunk,
		Flower,
		Fruit,
		Invalid
	}

	private static DateTime? LastUpdateTime;

	public static KinomiPlaceData.SheetSheet1 GetPlaceData(int placeIndex)
	{
		return null;
	}

	public static KinomiPlaceData.SheetSheet1[] GetPlaceDataByAreaId(AreaID areaId)
	{
		return null;
	}

	public static int GetPlaceDataCount()
	{
		return default(int);
	}

	public static KinomiData.SheetData GetKinomiData(int tagNo)
	{
		return null;
	}

	public static int GetKinomiDataCount()
	{
		return default(int);
	}

	public static KinomiData.SheetData FindKinomiDataByItemNo(ItemNo itemNo)
	{
		return null;
	}

	public static KinomiGrow GetGrowByRawIndex(int growIndex)
	{
		return default(KinomiGrow);
	}

	public static void SetGrowByRawIndex(int growIndex, KinomiGrow grow)
	{
	}

	public static KinomiGrow GetGrow(int placeIndex)
	{
		return default(KinomiGrow);
	}

	public static void SetGrow(int placeIndex, KinomiGrow grow)
	{
	}

	public static KinomiData.SheetData GetKinomiDataByPlaceIndex(int placeIndex)
	{
		return null;
	}

	public static void UpdateGrowTime()
	{
	}

	public static void UpdateGrowTime(int minute)
	{
	}

	public static void PlantKinomi(int placeIndex, ItemNo itemNo)
	{
	}

	public static void HarvestKinomi(int placeIndex)
	{
	}

	public static void GiveWater(int placeIndex)
	{
	}

	public static void SetDefault()
	{
	}

	public static GrowPhase CalcGrowPhase(KinomiGrow kinomiGrow)
	{
		return default(GrowPhase);
	}

	public static bool CalcGrowCompleted(KinomiGrow kinomiGrow)
	{
		return default(bool);
	}

	public static int CalcGrowCompletedTime(KinomiData.SheetData kinomiData)
	{
		return default(int);
	}

	public static int GrowIndexToPlaceIndex(int growIndex)
	{
		return default(int);
	}

	public static int PlaceIndexToGrowIndex(int placeIndex)
	{
		return default(int);
	}

	public static bool IsKinomiContact()
	{
		return default(bool);
	}

	public static FieldKinomiGrowEntity IsKinomiContactEntity()
	{
		return null;
	}

	public static FieldKinomiGrowEntity IsWaterContactEntity()
	{
		return null;
	}

	public static FieldKinomiGrowEntity IsKinomiContactEntityCommon(GrowPhase phase)
	{
		return null;
	}
}
