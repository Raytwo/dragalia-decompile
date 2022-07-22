using System.Runtime.InteropServices;
using Pml.Battle;

namespace Dpr.Battle.Logic;

public sealed class Section_FightDamage_Ichigeki : Section
{
	public class Description
	{
		public DmgAffRec pAffinityRecorder;

		public WazaParam pWazaParam;

		public BTL_POKEPARAM pAttacker;

		public PokeSet pTargets;

		public PokeSet pDamagedPokeSet;
	}

	public class Result
	{
		public SectionUtil.GWallUpdateResult gWallUpdateResult;
	}

	public Section_FightDamage_Ichigeki([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	public ushort addDamage(BTL_POKEPARAM pAttacker, BTL_POKEPARAM pTarget, WazaParam pWazaParam, PokeSet pTargetPokeSet, PokeSet pDamagedPokeSet, TypeAffinity.AffinityID affinity, bool isMigawariHit)
	{
		return default(ushort);
	}

	private bool checkMigawariHit(BTL_POKEPARAM attacker, BTL_POKEPARAM defender, WazaParam wazaParam)
	{
		return default(bool);
	}

	public ushort damageWithMigawari(BTL_POKEPARAM target, WazaParam wazaParam, TypeAffinity.AboutAffinityID affinityAbout)
	{
		return default(ushort);
	}

	private void deleteMigawari(BTL_POKEPARAM poke)
	{
	}

	private bool checkGuardEnable(BTL_POKEPARAM attacker, BTL_POKEPARAM defender, WazaParam wazaParam)
	{
		return default(bool);
	}

	private KoraeruCause checkKoraeruEnable(ref ushort pDamage, BTL_POKEPARAM attacker, BTL_POKEPARAM defender)
	{
		return default(KoraeruCause);
	}

	public void onSucceeded(BTL_POKEPARAM target, BTL_POKEPARAM attacker, WazaParam wazaParam, TypeAffinity.AboutAffinityID affAbout)
	{
	}

	public void onKoraeru(BTL_POKEPARAM target, BTL_POKEPARAM attacker, WazaParam wazaParam, TypeAffinity.AboutAffinityID affAbout, KoraeruCause koraeruCause, ushort damage)
	{
	}

	private void section_Koraeru(BTL_POKEPARAM pPoke, KoraeruCause cause)
	{
	}

	private void addWazaDamageRecord(BtlPokePos attackerPos, BTL_POKEPARAM pAttacker, BTL_POKEPARAM pDefender, WazaParam pWazaParam, ushort damage)
	{
	}

	public void damageReaction(BTL_POKEPARAM attacker, BTL_POKEPARAM defender, WazaParam wazaParam, TypeAffinity.AffinityID affinity, uint damage, bool isHitMigawari)
	{
	}

	private void checkPokeDead(BTL_POKEPARAM pPoke, BTL_POKEPARAM attacker, WazaParam wazaParam)
	{
	}

	private SectionUtil.GWallUpdateResult updateGWallGauge(BTL_POKEPARAM pAttacker, PokeSet pDamagedPokeSet, WazaParam wazaParam)
	{
		return null;
	}
}
