using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_WazaAdditionalEffect : Section
{
	public class Description
	{
		public DamageProcParams pParams;

		public ActionDesc actionDesc;

		public WazaParam pWazaParam;

		public BTL_POKEPARAM pAttacker;

		public byte pokeCnt;
	}

	public class Result
	{
	}

	public Section_WazaAdditionalEffect([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void shrink(WazaParam wazaParam, BTL_POKEPARAM attacker, BTL_POKEPARAM defender)
	{
	}

	private void drain(WazaParam wazaParam, BTL_POKEPARAM attacker, BTL_POKEPARAM defender, ushort damage)
	{
	}

	private void additionalEffect(ActionDesc actionDesc, WazaParam wazaParam, BTL_POKEPARAM attacker, BTL_POKEPARAM defender, ushort damage)
	{
	}

	private void additionalEffect_User(ActionDesc actionDesc, WazaParam wazaParam, BTL_POKEPARAM attacker)
	{
	}
}
