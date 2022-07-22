using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_WazaExec_Category_SimpleEffect : Section
{
	public class Description
	{
		public ActionDesc actionDesc;

		public WazaParam wazaParam;

		public BTL_POKEPARAM attacker;

		public PokeSet targets;
	}

	public class Result
	{
	}

	public Section_WazaExec_Category_SimpleEffect([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private bool rankEffect(ActionDesc actionDesc, WazaParam wazaParam, BTL_POKEPARAM attacker, BTL_POKEPARAM target)
	{
		return default(bool);
	}
}
