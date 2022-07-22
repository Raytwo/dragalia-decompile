using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_FightDamage_SingleCount : Section
{
	public class Description
	{
		public BTL_POKEPARAM pAttacker;

		public ActionDesc pActionDesc;

		public WazaParam pWazaParam;

		public DmgAffRec pDmgAffRec;

		public bool isDelayAttack;

		public PokeSet pTargets;

		public PokeSet pDamagedPokeSet;

		public HITCHECK_PARAM pHitCheckParam;

		public WazaEffectReservedPos pWazaEffectReservedPos;

		public AffCounter pAffCounter;
	}

	public class Result
	{
		public uint dmgSum;

		public SectionUtil.GWallUpdateResult gWallUpdateResult;
	}

	public Section_FightDamage_SingleCount([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private int getDamageRatioByTargetCount([In] ref PokeSet targets)
	{
		return default(int);
	}

	private void calcDamage(DamageCalcResult dmgRec, BTL_POKEPARAM attacker, PokeSet targets, WazaParam wazaParam, DmgAffRec affRec, AffCounter affCounter, int damageRatio)
	{
	}

	private uint damageWithFriend(DamageCalcResult pDamageRec, ActionDesc pActionDesc, WazaParam pWazaParam, BTL_POKEPARAM pAttacker, HITCHECK_PARAM pHitCheckParam, PokeSet pDamagedPokeSet, bool isPluralHitWaza)
	{
		return default(uint);
	}

	private uint damageSide(DamageCalcResult pDamageRec, ActionDesc pActionDesc, WazaParam pWazaParam, BTL_POKEPARAM pAttacker, HITCHECK_PARAM pHitCheckParam, PokeSet pDamagedPokeSet, bool isPluralHitWaza)
	{
		return default(uint);
	}

	private SectionUtil.GWallUpdateResult updateGWallGauge(BTL_POKEPARAM pAttacker, PokeSet pDamagedPokeSet, WazaParam wazaParam)
	{
		return null;
	}
}
