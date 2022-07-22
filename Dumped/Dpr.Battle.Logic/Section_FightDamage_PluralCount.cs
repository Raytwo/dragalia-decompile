using System.Runtime.InteropServices;
using Pml.PokePara;

namespace Dpr.Battle.Logic;

public sealed class Section_FightDamage_PluralCount : Section
{
	public class Description
	{
		public BTL_POKEPARAM attacker;

		public ActionDesc actionDesc;

		public WazaParam wazaParam;

		public DmgAffRec affRec;

		public PokeSet targets;

		public PokeSet damagedPokeSet;

		public HITCHECK_PARAM hitCheckParam;
	}

	public class Result
	{
		public uint dmgSum;

		public SectionUtil.GWallUpdateResult gWallUpdateResult;

		public WazaEffectReservedPos wazaEffectReservePos;
	}

	public Section_FightDamage_PluralCount([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void calcDamage(DamageCalcResult dmgRec, BTL_POKEPARAM attacker, PokeSet targets, WazaParam wazaParam, DmgAffRec affRec, HITCHECK_PARAM hitCheckParam, uint hitCountIdx)
	{
	}

	private int getDamageRatio([In] ref HITCHECK_PARAM hitCheckParam, uint hitCountIndex)
	{
		return default(int);
	}

	private uint damageSide(BTL_POKEPARAM attacker, ActionDesc actionDesc, WazaParam wazaParam, DamageCalcResult damageRecord, HITCHECK_PARAM hitCheckParam, PokeSet pDamagedPokeSet)
	{
		return default(uint);
	}

	private SectionUtil.GWallUpdateResult updateGWallGauge(BTL_POKEPARAM pAttacker, PokeSet pDamagedPokeSet, WazaParam wazaParam)
	{
		return null;
	}

	private void checkItemReaction(BTL_POKEPARAM poke)
	{
	}

	public bool canContinueNextHit(BTL_POKEPARAM attacker, PokeSet targets, WazaParam wazaParam, HITCHECK_PARAM hitCheckParam, Sick attackerPrevSick, uint hitCountIdx)
	{
		return default(bool);
	}

	private void checkBattleTalk(byte pokeID)
	{
	}

	private BTL_POKEPARAM getTarget(PokeSet pTargets, uint hitCountIdx)
	{
		return null;
	}

	private bool isTargetEnable(BTL_POKEPARAM pPoke)
	{
		return default(bool);
	}
}
