using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_ConfDamage : Section
{
	public class Description
	{
		public BTL_POKEPARAM attacker;
	}

	public class Result
	{
		public ushort damage;
	}

	public Section_ConfDamage([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private ushort calcDamage(BTL_POKEPARAM poke)
	{
		return default(ushort);
	}

	private ushort fixDamage(BTL_POKEPARAM poke, ushort damage)
	{
		return default(ushort);
	}

	private void checkKoraeru(out KoraeruCause koraeCause, out ushort fixedDamage, BTL_POKEPARAM poke, ushort damage)
	{
	}

	private void section_Koraeru(BTL_POKEPARAM poke, KoraeruCause cause)
	{
	}
}
