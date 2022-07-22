using System.Runtime.InteropServices;
using Pml;

namespace Dpr.Battle.Logic;

public sealed class Section_WazaExecEnd : Section
{
	public class Description
	{
		public ActionDesc actionDesc;

		public BTL_POKEPARAM attacker;

		public WazaParam wazaParam;

		public bool isPPUsed;

		public bool isWazaEffective;

		public bool isWazaLocked;

		public bool isWazaHide;

		public WazaNo orgWaza;

		public BtlPokePos actTargetPos;
	}

	public class Result
	{
	}

	public Section_WazaExecEnd([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void tameLockClear(BTL_POKEPARAM poke)
	{
	}

	private void freefallRelease(BTL_POKEPARAM poke)
	{
	}

	private void event_EndWazaSeq(ActionDesc actionDesc, BTL_POKEPARAM attacker, WazaNo waza, bool isWazaEffective)
	{
	}
}
