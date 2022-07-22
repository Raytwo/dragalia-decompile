using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_CheckNotEffect_Guard : Section
{
	public class Description
	{
		public BTL_POKEPARAM attacker;

		public WazaParam wazaParam;

		public DmgAffRec affinityRecorder;

		public PokeSet targets;

		public ActionRecorder actionRecorder;
	}

	public class Result
	{
	}

	public Section_CheckNotEffect_Guard([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void check_Field(BTL_POKEPARAM attacker, WazaParam wazaParam, DmgAffRec affinityRecorder, PokeSet targets)
	{
	}

	private void check_Side(BTL_POKEPARAM attacker, WazaParam wazaParam, DmgAffRec affinityRecorder, PokeSet targets)
	{
	}

	private void check_Mamoru(BTL_POKEPARAM attacker, WazaParam wazaParam, DmgAffRec affinityRecorder, PokeSet targets)
	{
	}

	private bool isNoEffectByMamoru(BTL_POKEPARAM attacker, BTL_POKEPARAM target, WazaParam wazaParam, DmgAffRec affinityRecorder)
	{
		return default(bool);
	}

	private bool isNoEffectByMamoru_Others(BTL_POKEPARAM attacker, BTL_POKEPARAM target, WazaParam wazaParam, DmgAffRec affinityRecorder)
	{
		return default(bool);
	}

	private void onMamoruSuccess(BTL_POKEPARAM attacker, BTL_POKEPARAM target, WazaParam wazaParam)
	{
	}

	private void check_Others(BTL_POKEPARAM attacker, WazaParam wazaParam, DmgAffRec affinityRecorder, PokeSet targets)
	{
	}
}
