using System.Runtime.InteropServices;
using Pml.Battle;

namespace Dpr.Battle.Logic;

public sealed class Section_FightDamageSide : Section
{
	public class Description
	{
		public BTL_POKEPARAM pAttacker;

		public ActionDesc pActionDesc;

		public DamageCalcResult pDmgRec;

		public WazaParam pWazaParam;

		public HITCHECK_PARAM pHitCheckParam;

		public bool isPluralHitWaza;

		public PokeSet pDamagedPokeSet;
	}

	public class Result
	{
		public uint dmgSum;
	}

	public Section_FightDamageSide([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void migawariDamage(PokeSet pDamagedPokeSet, BTL_POKEPARAM pAttacker, ActionDesc pActionDesc, WazaParam pWazaParam, DamageCalcResult pDamageRec)
	{
	}

	private void damageDetermine(HITCHECK_PARAM pHitCheckParam, BTL_POKEPARAM pAttacker, WazaParam pWazaParam, DamageCalcResult pDamageRec)
	{
	}

	private byte checkRealHitPoke(DamageProcParams pDamageProcParam, DamageCalcResult pDamageRec)
	{
		return default(byte);
	}

	private void checkAttackerDead(BTL_POKEPARAM attacker, WazaParam wazaParam)
	{
	}

	private void putWazaDamageCommand(DamageProcParams pDamageProcParam, BTL_POKEPARAM pAttacker, WazaParam pWazaParam, byte hitPokeCount)
	{
	}

	private void msgAfterWazaDamage(DamageProcParams pDamageProcParam, BTL_POKEPARAM pAttacker, WazaParam pWazaParam, HITCHECK_PARAM pHitCheckParam, byte targetPokeCount, bool isPluralHitWaza)
	{
	}

	private void recordWazaDamage(DamageProcParams pDamageProcParam, BTL_POKEPARAM pAttacker, WazaParam pWazaParam, BtlPokePos attackerPos, byte targetPokeCount, PokeSet pDamagedPokeSet)
	{
	}

	private void koraeru(BTL_POKEPARAM pPoke, KoraeruCause cause)
	{
	}

	private void additionalEffect(DamageProcParams pDamageProcParam, ActionDesc pActionDesc, WazaParam pWazaParam, BTL_POKEPARAM pAttacker, byte targetPokeCount)
	{
	}

	private void gShockEffect(BTL_POKEPARAM pAttacker, BTL_POKEPARAM pDefender, ActionDesc pActionDesc, WazaParam pWazaParam)
	{
	}

	public void damageReaction(BTL_POKEPARAM attacker, BTL_POKEPARAM defender, WazaParam wazaParam, TypeAffinity.AffinityID affinity, uint damage, CriticalType criticalType)
	{
	}

	private void checkDeadAfterWazaDamage(DamageProcParams pDamageProcParam, HITCHECK_PARAM pHitCheckParam, WazaParam pWazaParam, BTL_POKEPARAM pAttacker, byte targetPokeCount)
	{
	}
}
