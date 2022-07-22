using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_CheckWazaAvoid_ByHide : Section
{
	public class Description
	{
		public WazaParam wazaParam;

		public BTL_POKEPARAM attacker;

		public PokeSet targets;
	}

	public class Result
	{
	}

	public Section_CheckWazaAvoid_ByHide([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}
}
