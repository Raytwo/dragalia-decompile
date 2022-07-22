using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_CheckNotEffect_Affinity : Section
{
	public class Description
	{
		public BTL_POKEPARAM attacker;

		public WazaParam wazaParam;

		public DmgAffRec affinityRecorder;

		public PokeSet targets;
	}

	public class Result
	{
	}

	public Section_CheckNotEffect_Affinity([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void checkNoEffect_Lv1(BTL_POKEPARAM attacker, WazaParam wazaParam, DmgAffRec affinityRecorder, PokeSet targets)
	{
	}

	private void checkNoEffect_Lv2(BTL_POKEPARAM attacker, WazaParam wazaParam, DmgAffRec affinityRecorder, PokeSet targets)
	{
	}

	private void checkNoEffect_Type(BTL_POKEPARAM attacker, WazaParam wazaParam, PokeSet targets)
	{
	}

	private bool isNoEffectByType(BTL_POKEPARAM attacker, BTL_POKEPARAM target, WazaParam wazaParam)
	{
		return default(bool);
	}
}
