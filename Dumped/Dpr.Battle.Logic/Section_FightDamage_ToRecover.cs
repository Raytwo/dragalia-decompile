using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_FightDamage_ToRecover : Section
{
	public class Description
	{
		public BTL_POKEPARAM attacker;

		public WazaParam wazaParam;

		public PokeSet targets;
	}

	public class Result
	{
	}

	public Section_FightDamage_ToRecover([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}
}
