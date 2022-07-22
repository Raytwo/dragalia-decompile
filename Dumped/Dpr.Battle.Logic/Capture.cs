using System.Runtime.InteropServices;
using Pml;

namespace Dpr.Battle.Logic;

public static class Capture
{
	public class JudgeParam
	{
		public MainModule mainModule;

		public BattleEnv battleEnv;

		public BTL_POKEPARAM userPoke;

		public BTL_POKEPARAM targetPoke;

		public ushort itemID;

		public int captureValueCoef;

		public bool isMustSuccess;

		public bool isCriticalEnable;
	}

	public class JudgeResult
	{
		public bool isCaptured;

		public bool isCritical;

		public byte yureCount;
	}

	public const uint FRIENDBALL_FRIENDSHIP = 150u;

	public static void JudgeCapture(JudgeResult result, [In] ref JudgeParam param)
	{
	}

	private static bool isMustCapureSuccess(MainModule mainModule, ushort itemID)
	{
		return default(bool);
	}

	private static int calcCaptureIndicator(MainModule mainModule, BattleEnv battleEnv, BTL_POKEPARAM userPoke, BTL_POKEPARAM targetPoke, ushort itemID, int captureValueCoef)
	{
		return default(int);
	}

	private static int getZukanCaptureRatio(MainModule mainModule)
	{
		return default(int);
	}

	private static int calcBallCaptureRatio(MainModule mainModule, BattleEnv battleEnv, BTL_POKEPARAM userPoke, BTL_POKEPARAM targetPoke, ushort itemID)
	{
		return default(int);
	}

	private static int getBallCaptureRatio(MainModule mainModule, BattleEnv battleEnv, BTL_POKEPARAM userPoke, BTL_POKEPARAM targetPoke, ushort itemID)
	{
		return default(int);
	}

	private static bool checkCaptureCritical(MainModule mainModule, int captureIndicator)
	{
		return default(bool);
	}

	private static int calcCaptureValue(int capture_value)
	{
		return default(int);
	}

	private static void checkCapureSuccessByRandom(out bool pIsCaptured, out byte pYureCount, int captureValue, bool isCritical)
	{
	}

	private static short getHeavyBallCaptureCorrectValue(ushort weight)
	{
		return default(short);
	}

	private static bool checkMoonBallEffective(MonsNo monsno, ushort formno)
	{
		return default(bool);
	}

	private static int getLevelBallCaptureRatio(byte myLevel, byte targetLevel)
	{
		return default(int);
	}

	private static bool IsEnableDarkBallOnEventTimeZone()
	{
		return default(bool);
	}
}
