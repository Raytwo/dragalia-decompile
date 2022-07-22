using System.Runtime.InteropServices;
using Pml.Battle;

namespace Dpr.Battle.Logic;

public sealed class Section_FightDamageSide_MigawariDamage : Section
{
	public class Description
	{
		public DamageCalcResult damageRecord;

		public ActionDesc actionDesc;

		public WazaParam wazaParam;

		public BTL_POKEPARAM attacker;

		public PokeSet pDamagedPokeSet;
	}

	public class Result
	{
	}

	public Section_FightDamageSide_MigawariDamage([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private uint storeMigawariHitInfo(DamageProcParams damageProcParams, DamageCalcResult damageRecord)
	{
		return default(uint);
	}

	public ushort addDamageToMigawari(ActionDesc actionDesc, WazaParam wazaParam, BTL_POKEPARAM attacker, BTL_POKEPARAM target, ushort damage, TypeAffinity.AffinityID affinity, CriticalType criticalType)
	{
		return default(ushort);
	}
}
