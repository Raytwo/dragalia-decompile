using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_WazaExec_DelayWazaReady : Section
{
	public class Description
	{
		public BTL_POKEPARAM pAttacker;

		public WazaParam pWazaParam;

		public BtlPokePos targetPos;
	}

	public class Result
	{
		public bool isReadyProcessed;

		public bool isWazaEnable;
	}

	public Section_WazaExec_DelayWazaReady([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void putWazaEffect(BtlPokePos attackerPos, BtlPokePos targetPos, [In] ref WazaParam pWazaParam)
	{
	}

	private void event_DecideDelayWaza([In] ref BTL_POKEPARAM pAttacker)
	{
	}
}
