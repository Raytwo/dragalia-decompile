namespace Dpr.Battle.Logic;

public sealed class Kawaigari
{
	public const byte BATTLE_START_NATSUKI_1 = byte.MaxValue;

	public const byte BATTLE_START_NATSUKI_2 = 220;

	public const byte BATTLE_START_NATSUKI_3 = 180;

	public const byte FIRST_READY_MSG_NATSUKI_1 = byte.MaxValue;

	public const byte FIRST_READY_MSG_NATSUKI_2 = 220;

	public const byte FIRST_READY_MSG_NATSUKI_3 = 180;

	public const byte FIRST_READY_MSG_PERCENTAGE = 20;

	public const byte READY_MSG_NATSUKI = 220;

	public const byte CRITICAL_NATSUKI = byte.MaxValue;

	public const byte AVOID_NATSUKI = byte.MaxValue;

	public const byte AVOID_VALUE = 10;

	public const byte KORAERU_NATSUKI_1 = byte.MaxValue;

	public const byte KORAERU_NATSUKI_2 = 220;

	public const byte KORAERU_NATSUKI_3 = 180;

	public const byte KORAERU_PERCENTAGE_1 = 20;

	public const byte KORAERU_PERCENTAGE_2 = 15;

	public const byte KORAERU_PERCENTAGE_3 = 10;

	public const byte CURE_SICK_NATSUKI = 220;

	public const byte CURE_SICK_PERCENTAGE = 20;

	public const byte EXP_UP_NATSUKI = 220;

	public const byte PINCH_NATSUKI = byte.MaxValue;

	public const byte CAPTURE_NATSUKI = byte.MaxValue;

	public const byte BATSUGUN_NATSUKI = byte.MaxValue;

	public const byte MEMBER_IN_NATSUKI = 220;

	public const byte MEMBER_OUT_NATSUKI = 220;

	public const byte SLEEP_NATSUKI = byte.MaxValue;

	public const byte HP_RECOVER_NATSUKI = byte.MaxValue;

	private const uint MAX_KAWAIGARI_READY_MESSAGE_NUM = 5u;

	public static int Check1stReadyMessage(MainModule pMainModule, BTL_POKEPARAM pPoke, Random pRand)
	{
		return default(int);
	}

	private static bool CheckSpecial1stReadyMessage(MainModule pMainModule)
	{
		return default(bool);
	}

	private static void GetReadyMessage_Friendship_1(ref uint destMessageNum, ushort[] destMessageArray, uint destMessageArraySize, BTL_POKEPARAM poke)
	{
	}

	private static void GetReadyMessage_Friendship_2(ref uint destMessageNum, ushort[] destMessageArray, uint destMessageArraySize, BTL_POKEPARAM poke)
	{
	}

	private static void GetReadyMessage_Friendship_3(ref uint destMessageNum, ushort[] destMessageArray, uint destMessageArraySize, BTL_POKEPARAM poke)
	{
	}

	private static void GetReadyMessage_Common(ref uint destMessageNum, ushort[] destMessageArray, uint destMessageArraySize, BTL_POKEPARAM poke, ushort[] defaultMessageArray, uint defaultMessageNum)
	{
	}
}
