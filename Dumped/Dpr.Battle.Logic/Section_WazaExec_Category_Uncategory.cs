using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_WazaExec_Category_Uncategory : Section
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

	public Section_WazaExec_Category_Uncategory([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void skillSwap(BTL_POKEPARAM attacker, PokeSet targets)
	{
	}

	private bool createMigawari(BTL_POKEPARAM attacker)
	{
		return default(bool);
	}
}
