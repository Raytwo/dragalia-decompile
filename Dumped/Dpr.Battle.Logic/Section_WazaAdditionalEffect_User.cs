using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_WazaAdditionalEffect_User : Section
{
	public class Description
	{
		public ActionDesc actionDesc;

		public WazaParam wazaParam;

		public BTL_POKEPARAM attacker;
	}

	public class Result
	{
	}

	public Section_WazaAdditionalEffect_User([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void addRankEffect(BTL_POKEPARAM attacker, WazaParam wazaParam, ActionDesc actionDesc)
	{
	}
}
