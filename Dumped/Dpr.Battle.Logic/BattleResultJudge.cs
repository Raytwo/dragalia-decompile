using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public static class BattleResultJudge
{
	public static BtlResult CheckBattleResult([In] ref MainModule mainModule, [In] ref POKECON pokecon, [In] ref DeadRec deadRec, [In] ref TimeLimit timeLimit, out ResultCause judgeCause)
	{
		return default(BtlResult);
	}

	private static BtlSide JudgeWinSide([In] ref MainModule mainModule, [In] ref POKECON pokecon, [In] ref DeadRec deadRec, [In] ref TimeLimit timeLimit, out ResultCause judgeCause)
	{
		return default(BtlSide);
	}

	private static void GetPokeCountBySide(byte[] alivePokeCount, byte[] totalPokeCount, byte[] timeOverCount, [In] ref MainModule mainModule, [In] ref POKECON pokecon, [In] ref TimeLimit timeLimit)
	{
	}

	private static BtlSide JudgeWinSide_UniqueAlive([In] ref MainModule mainModule, byte[] alivePokeCount)
	{
		return default(BtlSide);
	}

	private static BtlSide JudgeWinSide_UniqueTimeOver(byte[] timeOverCount, [In] ref MainModule mainModule)
	{
		return default(BtlSide);
	}

	private static BtlSide JudgeWinSide_DeadBoth(byte[] alivePokeCount, byte[] totalPokeCount, [In] ref MainModule mainModule, [In] ref DeadRec deadRec)
	{
		return default(BtlSide);
	}

	private static BtlSide JudgeWinSide_ByDeadPokeCount([In] ref MainModule mainModule, byte[] alivePokeCount, byte[] totalPokeCount)
	{
		return default(BtlSide);
	}

	private static BtlSide JudgeWinSide_ByRemainedHpRatio([In] ref MainModule mainModule, int[] remainedHpRatio)
	{
		return default(BtlSide);
	}

	private static BtlSide JudgeWinSide_ByRemainedHpTotal([In] ref MainModule mainModule, int[] remainedHpTotal)
	{
		return default(BtlSide);
	}

	private static void CalcHPRatio(ref int HP_sum, ref int HP_ratio, [In] ref MainModule mainModule, [In] ref POKECON pokecon, [In] ref BtlSide targetSide)
	{
	}
}
