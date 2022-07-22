using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_MsgAfterWazaDamage : Section
{
	public class Description
	{
		public DamageProcParams damageProcParam;

		public WazaParam wazaParam;

		public BTL_POKEPARAM attacker;

		public HITCHECK_PARAM hitCheckParam;

		public byte targetCount;

		public bool isPluralHitWaza;
	}

	public class Result
	{
	}

	public Section_MsgAfterWazaDamage([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void putCriticalMessage(BTL_POKEPARAM attacker, WazaParam wazaParam, uint targetNum, BTL_POKEPARAM[] targets, CriticalType[] criticalTypes, bool isPluralHitWaza)
	{
	}

	private void checkBattleTalk(byte pokeID)
	{
	}
}
