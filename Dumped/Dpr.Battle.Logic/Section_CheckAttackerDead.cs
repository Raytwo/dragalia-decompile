using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_CheckAttackerDead : Section
{
	public class Description
	{
		public BTL_POKEPARAM attacker;

		public WazaParam wazaParam;
	}

	public class Result
	{
	}

	public Section_CheckAttackerDead([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void checkPokeDead(BTL_POKEPARAM poke)
	{
	}
}
