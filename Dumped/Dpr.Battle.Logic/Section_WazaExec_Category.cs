using System.Runtime.InteropServices;
using Pml.WazaData;

namespace Dpr.Battle.Logic;

public sealed class Section_WazaExec_Category : Section
{
	public class Description
	{
		public BTL_POKEPARAM attacker;

		public ActionDesc actionDesc;

		public WazaParam wazaParam;

		public bool isDamageWaza;

		public WazaCategory wazaCategory;

		public DmgAffRec affinityRecorder;

		public PokeSet targets;
	}

	public class Result
	{
	}

	public Section_WazaExec_Category([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void damageWaza(BTL_POKEPARAM attacker, ActionDesc actionDesc, WazaParam wazaParam, DmgAffRec affinityRecorder, PokeSet targets)
	{
	}

	private void simpleEffect(ActionDesc actionDesc, BTL_POKEPARAM attacker, WazaParam wazaParam, PokeSet targets)
	{
	}

	private void simpleSick(BTL_POKEPARAM attacker, WazaParam wazaParam, PokeSet targets)
	{
	}

	private void simpleRecover(BTL_POKEPARAM attacker, WazaParam wazaParam, PokeSet targets)
	{
	}

	private void effectSick(ActionDesc actionDesc, BTL_POKEPARAM attacker, WazaParam wazaParam, PokeSet targets)
	{
	}

	private void pushOut(BTL_POKEPARAM attacker, WazaParam wazaParam, PokeSet targets)
	{
	}

	private void fieldEffect(BTL_POKEPARAM attacker, WazaParam wazaParam)
	{
	}

	private void uncategory(BTL_POKEPARAM attacker, WazaParam wazaParam, PokeSet targets)
	{
	}

	private void event_UnDamageProcEnd(BTL_POKEPARAM attacker, WazaParam wazaParam)
	{
	}
}
