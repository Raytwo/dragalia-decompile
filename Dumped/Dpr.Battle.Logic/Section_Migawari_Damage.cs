using System.Runtime.InteropServices;
using Pml.Battle;

namespace Dpr.Battle.Logic;

public sealed class Section_Migawari_Damage : Section
{
	public class Description
	{
		public BTL_POKEPARAM attacker;

		public BTL_POKEPARAM target;

		public ushort damage;

		public TypeAffinity.AffinityID affinity;

		public CriticalType criticalType;

		public ActionDesc actionDesc;

		public WazaParam wazaParam;
	}

	public class Result
	{
		public ushort damage;
	}

	public Section_Migawari_Damage([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	public void putDamageEffect(BTL_POKEPARAM attacker, BTL_POKEPARAM target, [In] ref WazaParam wazaParam, ushort damage, TypeAffinity.AffinityID affinity, CriticalType criticalType)
	{
	}

	private void putCricicalMessage(BTL_POKEPARAM attacker, BTL_POKEPARAM target, WazaParam wazaParam, [In] ref CriticalType criticalType)
	{
	}

	private ushort addDamage(BTL_POKEPARAM target, ushort damage)
	{
		return default(ushort);
	}

	private void deleteMigawari(BTL_POKEPARAM poke)
	{
	}

	private void drainHP(BTL_POKEPARAM attacker, BTL_POKEPARAM target, WazaParam wazaParam, ushort damage)
	{
	}

	private void additionalEffect(BTL_POKEPARAM attacker, BTL_POKEPARAM target, WazaParam wazaParam, ActionDesc actionDesc, ushort damage)
	{
	}

	private void additionalEffect_User(BTL_POKEPARAM attacker, WazaParam wazaParam, ActionDesc actionDesc)
	{
	}

	public void damageReaction(BTL_POKEPARAM attacker, BTL_POKEPARAM target, WazaParam wazaParam, TypeAffinity.AffinityID affinity, ushort damage, CriticalType criticalType)
	{
	}
}
