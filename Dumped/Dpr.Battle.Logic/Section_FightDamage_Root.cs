using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_FightDamage_Root : Section
{
	public class Description
	{
		public BTL_POKEPARAM pAttacker;

		public WazaParam pWazaParam;

		public ActionDesc pActionDesc;

		public DmgAffRec pDmgAffRec;

		public PokeSet pTargets;

		public bool isDelayAttack;
	}

	public class Result
	{
	}

	public Section_FightDamage_Root([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void event_DamageProcStart(BTL_POKEPARAM attacker, WazaParam wazaParam, PokeSet targets)
	{
	}

	private void event_GetHitCheckParam(HITCHECK_PARAM pHitCheckParam, BTL_POKEPARAM attacker, WazaParam wazaParam, bool isDelayAttack)
	{
	}

	private void damageToRecover(BTL_POKEPARAM attacker, WazaParam wazaParam, PokeSet targets)
	{
	}

	private uint damage([In] ref Description description, HITCHECK_PARAM pHitCheckParam, PokeSet pDamagedPokeSet, WazaEffectReservedPos pWazaEffectReservedPos, SectionUtil.GWallUpdateResult pGWallUpdateResult)
	{
		return default(uint);
	}

	private void damage_Single(ref uint pDamageSum, WazaEffectReservedPos pWazaEffectReservePos, BTL_POKEPARAM pAttacker, ActionDesc pActionDesc, WazaParam pWazaParam, DmgAffRec pDmgAffRec, bool isDelayAttack, PokeSet pTargets, PokeSet pDamagedPokeSet, HITCHECK_PARAM pHitCheckParam, SectionUtil.GWallUpdateResult pGWallUpdateResult)
	{
	}

	private void damage_Prural(ref uint pDamageSum, WazaEffectReservedPos pWazaEffectReservePos, HITCHECK_PARAM hitCheckParam, PokeSet pDamagedPokeSet, BTL_POKEPARAM pAttacker, ActionDesc actionDesc, WazaParam pWazaParam, DmgAffRec pDmgAffRec, PokeSet pTargets, SectionUtil.GWallUpdateResult pGWallUpdateResult)
	{
	}

	private void damage_Ichigeki(BTL_POKEPARAM attacker, WazaParam wazaParam, DmgAffRec affinityRecorder, PokeSet targets, PokeSet damagedPokeSet, SectionUtil.GWallUpdateResult pGWallUpdateResult)
	{
	}

	private void kickbackDamage(BTL_POKEPARAM attacker, WazaParam wazaParam, uint wazaDamage)
	{
	}

	private void damageProcEnd(ActionDesc actionDesc, WazaParam wazaParam, BTL_POKEPARAM attacker, PokeSet targets, bool fDelayAttack)
	{
	}

	private void putWazaEffectOperation([In] ref WazaParam wazaParam, [In] ref WazaEffectReservedPos reservedPos)
	{
	}

	private void breakGWall()
	{
	}

	private void addRaidBossExtraAction()
	{
	}

	private void checkBattleTalk(PokeSet damagedPokeSet)
	{
	}
}
