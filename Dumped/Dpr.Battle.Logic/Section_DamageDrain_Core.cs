using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_DamageDrain_Core : Section
{
	public class Description
	{
		public BTL_POKEPARAM attacker;

		public BTL_POKEPARAM target;

		public ushort drainHP;

		public bool skipSpFailCheck;
	}

	public class Result
	{
		public bool isHpRecovered;
	}

	public Section_DamageDrain_Core([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private ushort recalcDrainVolume(BTL_POKEPARAM attacker, BTL_POKEPARAM target, ushort drainHP)
	{
		return default(ushort);
	}

	private bool recoverHP(BTL_POKEPARAM poke, ushort drainHP, bool skipSpFailCheck)
	{
		return default(bool);
	}
}
