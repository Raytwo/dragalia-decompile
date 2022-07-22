using System.Runtime.InteropServices;
using Pml;

namespace Dpr.Battle.Logic;

public static class SectionUtil
{
	public class GWallUpdateResult
	{
		public bool isBroken;

		public bool isBecameMax;

		public void CopyFrom(GWallUpdateResult src)
		{
		}
	}

	public static bool CheckShowdown(MainModule mainModule, BattleEnv battleEnv)
	{
		return default(bool);
	}

	private static bool checkShowdown_Raid(MainModule mainModule, BattleEnv battleEnv)
	{
		return default(bool);
	}

	private static bool checkAllDeadSideExist(MainModule mainModule, BattleEnv battleEnv)
	{
		return default(bool);
	}

	public static bool CheckAllDeadSide(MainModule mainModule, BattleEnv battleEnv, BtlSide checkSide)
	{
		return default(bool);
	}

	private static bool checkAllDeadClient(BattleEnv pBattleEnv, BTL_CLIENT_ID clientID)
	{
		return default(bool);
	}

	public static bool CheckSkipBattleAfterShowdown(MainModule mainModule)
	{
		return default(bool);
	}

	public static bool CheckTurnEnd(InterruptCode interruptCode)
	{
		return default(bool);
	}

	public static bool CheckPlayersClient(MainModule mainModule, BTL_CLIENT_ID clientID)
	{
		return default(bool);
	}

	public static byte GetFriendship(MainModule mainModule, BTL_POKEPARAM poke)
	{
		return default(byte);
	}

	public static bool CheckPlayersPoke(MainModule mainModule, BTL_POKEPARAM poke)
	{
		return default(bool);
	}

	public static bool CheckPlayersFriendPoke(MainModule mainModule, BTL_POKEPARAM poke)
	{
		return default(bool);
	}

	public static bool CheckMustHit(MainModule mainModule, BTL_POKEPARAM attacker, BTL_POKEPARAM target, [In] ref PosPoke posPoke)
	{
		return default(bool);
	}

	public static bool CheckSkyBattleFailWaza(MainModule mainModule, WazaNo waza)
	{
		return default(bool);
	}

	public static WazaNo CheckEncoreWazaChange(PokeAction action)
	{
		return default(WazaNo);
	}
}
