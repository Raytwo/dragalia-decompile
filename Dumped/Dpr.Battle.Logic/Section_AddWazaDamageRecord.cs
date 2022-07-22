using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_AddWazaDamageRecord : Section
{
	public class Description
	{
		public BTL_POKEPARAM defender;

		public BTL_POKEPARAM attacker;

		public BtlPokePos attackerPos;

		public WazaParam wazaParam;

		public ushort damage;
	}

	public class Result
	{
	}

	public Section_AddWazaDamageRecord([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}
}
