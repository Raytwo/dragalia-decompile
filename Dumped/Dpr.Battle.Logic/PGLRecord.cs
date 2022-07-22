using Pml;

namespace Dpr.Battle.Logic;

public static class PGLRecord
{
	public sealed class RecParam
	{
		public BTL_POKEPARAM attacker;

		public WazaNo wazaID;

		public RecParam(BTL_POKEPARAM _attacker, WazaNo _wazaID)
		{
		}
	}

	public static bool IsNeed(MainModule pMainModule)
	{
		return default(bool);
	}

	public static void PokeIDtoRecordIdx(out bool pIsPlayerSide, out byte pRecordIdx, MainModule pMainModule, byte pokeID)
	{
	}

	public static void Record(BATTLE_PGL_RECORD_SET pBuffer, MainModule pMainModule, BTL_POKEPARAM pDeadPoke, RecParam pRecParam)
	{
	}

	public static void Record(BATTLE_PGL_RECORD_SET pBuffer, MainModule pMainModule, BattleEnv pBattleEnv)
	{
	}

	private static BATTLE_PGL_RECORD GetTargetRecord(BATTLE_PGL_RECORD_SET pBuffer, MainModule pMainModule, byte pokeID)
	{
		return null;
	}
}
