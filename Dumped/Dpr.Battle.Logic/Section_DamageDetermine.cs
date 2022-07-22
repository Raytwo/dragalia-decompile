using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_DamageDetermine : Section
{
	public class Description
	{
		public BTL_POKEPARAM pAttacker;

		public HITCHECK_PARAM pHitCheckParam;

		public DamageCalcResult pDamageRecord;

		public WazaParam pWazaParam;
	}

	public class Result
	{
	}

	public Section_DamageDetermine([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void damageDetermineEvent(DamageCalcResult damageRec, BTL_POKEPARAM attacker, WazaParam wazaParam)
	{
	}

	private void udpateCriticalCount(BTL_POKEPARAM pAttacker, DamageCalcResult pDamageRec)
	{
	}

	private void updateTotalDamageRecieved(DamageCalcResult pDamageRec)
	{
	}
}
