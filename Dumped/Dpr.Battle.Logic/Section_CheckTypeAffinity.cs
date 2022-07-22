using System.Runtime.InteropServices;
using Pml.Battle;

namespace Dpr.Battle.Logic;

public sealed class Section_CheckTypeAffinity : Section
{
	public class Description
	{
		public WazaParam wazaParam;

		public BTL_POKEPARAM attacker;

		public PokeSet targets;

		public DmgAffRec affinityRecorder;
	}

	public class Result
	{
	}

	public Section_CheckTypeAffinity([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	public void checkTypeAffinity(out TypeAffinity.AffinityID pTypeAffinity, out bool pIsNoEffectByFloatingStatus, BTL_POKEPARAM attacker, BTL_POKEPARAM defender, WazaParam wazaParam)
	{
	}
}
