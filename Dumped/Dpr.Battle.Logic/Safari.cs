using Pml;

namespace Dpr.Battle.Logic;

public static class Safari
{
	public const int SAFARI_COUNT_FLAT = 6;

	public const int SAFARI_COUNT_MAX = 12;

	public const int SAFARI_BALL_MAX = 99;

	private const int SAFARI_ATARI = 10;

	private static readonly byte[][] SafariBallRateTable;

	private static readonly byte[][] SafariEscapeRateTable;

	public static void GetSafariGetRatio(int safari_get_count, out int numerator, out int denominator)
	{
	}

	public static bool JudgeSafariEscape(MonsNo monsNo, int formNo, int escape_count)
	{
		return default(bool);
	}

	private static int GetEscapeRatio(MonsNo monsNo, int formNo, int escape_count)
	{
		return default(int);
	}

	private static void GetCounterEscapeRatio(int escape_count, out int numerator, out int denominator)
	{
	}

	private static int GetPersonalEscapeRatio(MonsNo monsNo, int formNo)
	{
		return default(int);
	}

	public static bool IsCritDoroEsa(MainModule mainModule)
	{
		return default(bool);
	}
}
