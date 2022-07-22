using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_WazaAdditionalEffect_Target : Section
{
	public class Description
	{
		public ActionDesc actionDesc;

		public WazaParam wazaParam;

		public BTL_POKEPARAM attacker;

		public BTL_POKEPARAM defender;

		public uint damage;

		public bool fMigawriHit;
	}

	public class Result
	{
	}

	public Section_WazaAdditionalEffect_Target([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void addRankEffect(ActionDesc actionDesc, WazaParam wazaParam, BTL_POKEPARAM attacker, BTL_POKEPARAM target)
	{
	}

	private void addSick(WazaParam wazaParam, BTL_POKEPARAM attacker, BTL_POKEPARAM target)
	{
	}
}
