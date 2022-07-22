using System.Runtime.InteropServices;
using Pml.WazaData;

namespace Dpr.Battle.Logic;

public sealed class Section_WazaExec_Category_SimpleSick : Section
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

	public Section_WazaExec_Category_SimpleSick([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private bool sectionWazaSickCore(BTL_POKEPARAM attacker, BTL_POKEPARAM target, WazaSick sick, [In] ref BTL_SICKCONT sickCont)
	{
		return default(bool);
	}
}
