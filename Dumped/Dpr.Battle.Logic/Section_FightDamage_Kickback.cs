using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_FightDamage_Kickback : Section
{
	public class Description
	{
		public BTL_POKEPARAM pAttacker;

		public WazaParam pWazaParam;

		public uint damageSum;
	}

	public class Result
	{
	}

	public Section_FightDamage_Kickback([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private uint calcKickBackDamage(BTL_POKEPARAM attacker, WazaParam wazaParam, uint wazaDamage, out bool pIsMustEnable)
	{
		return default(uint);
	}

	private bool isKickbackDamageEnable(BTL_POKEPARAM attacker, uint damage)
	{
		return default(bool);
	}

	private void addDamage(BTL_POKEPARAM poke, uint damage)
	{
	}
}
