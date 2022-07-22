using System.Runtime.InteropServices;
using Pml;

namespace Dpr.Battle.Logic;

public sealed class Section_WazaExec_CheckWazaInvalid : Section
{
	public class Description
	{
		public ActionDesc actionDesc;

		public WazaParam wazaParam;

		public BTL_POKEPARAM attacker;

		public PokeSet targets;

		public bool isMigawariCheckDisable;

		public bool isTypeAffCheckForce;

		public bool isDelayAttack;

		public ActionRecorder actionRecorder;

		public DmgAffRec affinityRecorder;
	}

	public class Result
	{
		public bool isWazaInvalid;
	}

	private static bool isHitMigawari(WazaNo waza)
	{
		return default(bool);
	}

	public Section_WazaExec_CheckWazaInvalid([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void removeMovedSelfTarget(PokeSet targets, BTL_POKEPARAM attacker, WazaParam wazaParam)
	{
	}

	private bool isValidWazaToMovedSelf(WazaParam wazaParam)
	{
		return default(bool);
	}

	private void checkAvoidByHide(BTL_POKEPARAM attacker, PokeSet targets, WazaParam wazaParam)
	{
	}

	private void checkTypeAffinity(DmgAffRec affinityRecorder, BTL_POKEPARAM attacker, PokeSet targets, WazaParam wazaParam)
	{
	}

	private void checkNoEffect_Guard(BTL_POKEPARAM attacker, PokeSet targets, WazaParam wazaParam, DmgAffRec affinityRecorder, ActionRecorder actionRecorder)
	{
	}

	private void checkNoEffect_Tokusei(BTL_POKEPARAM attacker, PokeSet targets, WazaParam wazaParam, DmgAffRec affinityRecorder, ActionRecorder actionRecorder)
	{
	}

	private void checkNoEffect_TypeAffinity(BTL_POKEPARAM attacker, PokeSet targets, WazaParam wazaParam, DmgAffRec affinityRecorder, ActionRecorder actionRecorder, bool isTypeAffCheckForce)
	{
	}

	private void checkNoEffect_Affinity(BTL_POKEPARAM attacker, PokeSet targets, WazaParam wazaParam, DmgAffRec affinityRecorder)
	{
	}

	private void checkNoEffect_SimpleSick(BTL_POKEPARAM attacker, PokeSet targets, WazaParam wazaParam)
	{
	}

	private void checkNoEffect_SimpleEffect(ActionDesc actionDesc, BTL_POKEPARAM attacker, PokeSet targets, WazaParam wazaParam)
	{
	}

	private void checkNoEffect_Avoid(BTL_POKEPARAM attacker, PokeSet targets, WazaParam wazaParam, ActionRecorder actionRecorder, bool isDelayAttack)
	{
	}

	private void checkNoEffect_Avoid_Others(BTL_POKEPARAM attacker, PokeSet targets, WazaParam wazaParam, ActionRecorder actionRecorder, bool isDelayAttack)
	{
	}

	private void checkNoEffect_Avoid_Ichigeki(WazaParam wazaParam, BTL_POKEPARAM attacker, PokeSet targets)
	{
	}

	private bool isAllTargetRemoved(BTL_POKEPARAM attacker, PokeSet targets, WazaParam wazaParam)
	{
		return default(bool);
	}

	private void removeMigawariTarget(BTL_POKEPARAM attacker, WazaParam wazaParam, PokeSet targets)
	{
	}

	private void onNotEffective(BTL_POKEPARAM attacker, WazaParam wazaParam, ActionDesc actionDesc)
	{
	}
}
