using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_CheckAllTargetRemoved : Section
{
	public class Description
	{
		public BTL_POKEPARAM attacker;

		public WazaParam wazaParam;

		public PokeSet targets;
	}

	public class Result
	{
		public bool isFailed;
	}

	public Section_CheckAllTargetRemoved([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}
}
