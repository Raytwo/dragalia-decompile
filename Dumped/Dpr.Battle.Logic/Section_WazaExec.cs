using System.Runtime.InteropServices;
using Pml;
using Pml.WazaData;

namespace Dpr.Battle.Logic;

public sealed class Section_WazaExec : Section
{
	public class Description
	{
		public BTL_POKEPARAM pAttacker;

		public ActionDesc pActionDesc;

		public WazaParam pWazaParam;

		public PokeSet pTargets;
	}

	public class Result
	{
		public bool isSuccess;
	}

	public Section_WazaExec([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void updateWazaExecRecord(BTL_POKEPARAM attacker, WazaNo waza)
	{
	}

	private TameWazaResult execTameWaza(BTL_POKEPARAM attacker, WazaParam wazaParam, PokeSet taragets)
	{
		return default(TameWazaResult);
	}

	private void section_CheckWazaInvalid(ref bool pIsWazaValid, DmgAffRec pAffinityRecorder, BTL_POKEPARAM pAttacker, WazaParam pWazaParam, ActionDesc actionDesc, PokeSet pTaragets)
	{
	}

	private void section_WazaExecCategory(BTL_POKEPARAM pAttacker, ActionDesc actionDesc, WazaParam pWazaParam, DmgAffRec pAffinityRecorder, PokeSet pTaragets, bool isDamageWaza, WazaCategory wazaCategory)
	{
	}

	private void section_WazaExecedEffect(BTL_POKEPARAM pAttacker, WazaParam pWazaParam, ActionDesc pActionDesc, WazaEffectReservedPos pQueReservePos, bool isWazaValid)
	{
	}

	private void event_WazaExeDone(byte pokeID, WazaNo waza, ActionDesc actionDesc)
	{
	}

	private void incWazaUsedCount(BTL_POKEPARAM pAttacker, WazaNo wazano)
	{
	}

	private void checkPokeDead(BTL_POKEPARAM poke)
	{
	}
}
