using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_CheckNotEffect_Tokusei : Section
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

	public Section_CheckNotEffect_Tokusei([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void checkNoEffect_Tokusei(BTL_POKEPARAM attacker, WazaParam wazaParam, DmgAffRec affinityRecorder, PokeSet targets)
	{
	}
}
