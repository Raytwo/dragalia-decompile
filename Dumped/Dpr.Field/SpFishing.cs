using System.Collections;
using Pml;
using UnityEngine;
using XLSXContent;

namespace Dpr.Field;

public static class SpFishing
{
	public const int FISH_POINT_MAX = 4;

	private const int SP_FISH_LV_MAX = 20;

	private const int SP_FISH_LV_MIN = 10;

	private const MonsNo SP_MONS_NO = MonsNo.HINBASU;

	private static RareFishTable _rareFishTable;

	public static bool CheckPoint(ref Vector2Int position)
	{
		return default(bool);
	}

	private static void LotPoint(ref int[] point)
	{
	}

	public static void SpFishing_GetMaxMinLv(out int outMaxLv, out int outMinLv)
	{
	}

	public static void SpFishing_GetMonsNo(out MonsNo outMonsNo)
	{
	}

	public static IEnumerator LoadFishingData()
	{
		return null;
	}

	public static void UnloadFishngData()
	{
	}
}
