using System.Runtime.InteropServices;
using Pml;

namespace Dpr.Battle.Logic;

public sealed class Section_CheckWazaAvoid : Section
{
	public class Description
	{
		public BTL_POKEPARAM attacker;

		public WazaParam wazaParam;

		public PokeSet targets;

		public ActionRecorder actionRecorder;

		public bool isDelayAttack;
	}

	public class Result
	{
	}

	public Section_CheckWazaAvoid([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void checkHit(out bool pIsHit, out bool pIsFriendshipActive, BTL_POKEPARAM attacker, BTL_POKEPARAM target, WazaParam wazaParam)
	{
	}

	private void putAvoidMessage(BTL_POKEPARAM avoidPoke, WazaNo waza, bool byFriendship)
	{
	}

	private void wazaAvoid(BTL_POKEPARAM attacker, bool fDelayAttack)
	{
	}
}
