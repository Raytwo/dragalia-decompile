using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_CheckDeadAfterWazaDamage : Section
{
	public class Description
	{
		public DamageProcParams damageParams;

		public WazaParam wazaParam;

		public HITCHECK_PARAM hitCheckParam;

		public BTL_POKEPARAM attacker;

		public byte hitPokeCount;
	}

	public class Result
	{
	}

	public Section_CheckDeadAfterWazaDamage([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void checkTargetDead(HITCHECK_PARAM hitCheckParam, BTL_POKEPARAM attacker, WazaParam wazaParam, BTL_POKEPARAM target)
	{
	}

	private void checkAttackerDead_Before(BTL_POKEPARAM poke, WazaParam wazaParam)
	{
	}

	private void checkAttackerDead_After(BTL_POKEPARAM poke)
	{
	}
}
