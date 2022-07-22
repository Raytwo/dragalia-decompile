namespace Dpr.Battle.Logic;

public sealed class DebugParam
{
	public struct ClientParam
	{
		public bool forceGOnBattleStart;

		public byte forceGPokePosIdx;
	}

	public bool captureMustFail_isEnable;

	public byte captureMustFail_yureCount;

	public int[] yubiWoHuruWaza;

	public int gTurnMax;

	public ClientParam[] clientParam;

	private static DebugParam s_uPtrDebugParam;

	public static void CreateInstance()
	{
	}

	public static void DeleteInstance()
	{
	}

	public static DebugParam GetInstance()
	{
		return null;
	}

	public void IncYubiWoHuruWaza(BtlPokePos pos)
	{
	}
}
