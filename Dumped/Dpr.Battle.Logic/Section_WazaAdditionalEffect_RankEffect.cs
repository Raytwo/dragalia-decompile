using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_WazaAdditionalEffect_RankEffect : Section
{
	public class Description
	{
		public ActionDesc actionDesc;

		public WazaParam wazaParam;

		public BTL_POKEPARAM attacker;

		public BTL_POKEPARAM target;
	}

	public class Result
	{
	}

	public Section_WazaAdditionalEffect_RankEffect([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private bool isRankEffectOccur(WazaParam wazaParam, BTL_POKEPARAM attacker, BTL_POKEPARAM target)
	{
		return default(bool);
	}

	private void addRankEffect(ActionDesc actionDesc, WazaParam wazaParam, BTL_POKEPARAM attacker, BTL_POKEPARAM target)
	{
	}
}
