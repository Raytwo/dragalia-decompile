using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_RecordWazaDamage : Section
{
	public class Description
	{
		public BTL_POKEPARAM attacker;

		public BtlPokePos attackerPos;

		public WazaParam wazaParam;

		public byte damageTargetNum;

		public DamageProcParams damageProcParams;

		public PokeSet damagedPokeSet;
	}

	public class Result
	{
	}

	public Section_RecordWazaDamage([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void addWazaDamageRecord(BtlPokePos attackerPos, BTL_POKEPARAM attacker, BTL_POKEPARAM defender, WazaParam wazaParam, ushort damage)
	{
	}
}
