namespace Dpr.Battle.Logic;

public static class BattleAiSystem
{
	public const int BASIC_RAND_RANGE = 256;

	private static bool[] s_isTokuseiOpened;

	private static ulong s_commonRandValue;

	public static void InitSystem()
	{
	}

	public static void QuitSystem()
	{
	}

	public static void NotifyTokuseiOpen(byte pokeID)
	{
	}

	public static bool IsTokuseiOpened(byte pokeID)
	{
		return default(bool);
	}

	public static void SetCommonRand(ulong randValue)
	{
	}

	public static ulong GetCommonRand()
	{
		return default(ulong);
	}
}
