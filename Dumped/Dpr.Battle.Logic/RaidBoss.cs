using System.Runtime.InteropServices;
using Pml;

namespace Dpr.Battle.Logic;

public static class RaidBoss
{
	public class SelectTargetParam
	{
		public BattleEnv pBattleEnv;

		public Random pRandom;

		public bool[] isSelectEnable;

		public bool equalizeWeight;
	}

	private struct GetCaptureValueCoefForSpGDuplicationTableElem
	{
		public MonsNo monsno;

		public int coef;

		public GetCaptureValueCoefForSpGDuplicationTableElem(MonsNo monsno, int coef)
		{
		}
	}

	private struct GetCaptureValueCoefByCaptureDifficultyTableElem
	{
		public RaidBossCaptureDifficulty difficulty;

		public int coef;

		public GetCaptureValueCoefByCaptureDifficultyTableElem(RaidBossCaptureDifficulty difficulty, int coef)
		{
		}
	}

	public const byte REINFORCE_TURN_MIN = 1;

	public const byte REINFORCE_TURN_MAX = 3;

	private static readonly GetCaptureValueCoefForSpGDuplicationTableElem[] GetCaptureValueCoefForSpGDuplicationTable;

	private static readonly GetCaptureValueCoefByCaptureDifficultyTableElem[] GetCaptureValueCoefByCaptureDifficultyTable;

	public static BtlPokePos SelectTargetPos([In] ref SelectTargetParam param)
	{
		return default(BtlPokePos);
	}

	private static uint calcTargetWeight(BTL_POKEPARAM target)
	{
		return default(uint);
	}

	public static bool CheckAngryCondition(BTL_POKEPARAM boss)
	{
		return default(bool);
	}

	public static uint CalcNextAngryHP(BTL_POKEPARAM boss)
	{
		return default(uint);
	}

	public static void GetCaptureValueCoef(ref int pCoef, ref bool pIsMustSuccess, MainModule pMainModule, BTL_POKEPARAM pBoss)
	{
	}

	public static int GetCaptureValueCoefForSpGDuplication(MonsNo monsno)
	{
		return default(int);
	}

	public static void GetCaptureValueCoefByCaptureDifficulty(ref int pCoef, ref bool pIsMustSuccess, RaidBossCaptureDifficulty difficulty)
	{
	}

	public static bool ShouldSkipCaptureSequence(MainModule pMainModule)
	{
		return default(bool);
	}
}
