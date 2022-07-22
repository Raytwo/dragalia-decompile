using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_FightDamage_ProcEnd : Section
{
	public class Description
	{
		public ActionDesc actionDesc;

		public WazaParam wazaParam;

		public BTL_POKEPARAM attacker;

		public PokeSet targets;

		public bool byDelayAttack;
	}

	public class Result
	{
	}

	public Section_FightDamage_ProcEnd([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void cureKori(WazaParam wazaParam, BTL_POKEPARAM attacker, PokeSet targets)
	{
	}

	private void cureSick_KOORI(BTL_POKEPARAM poke)
	{
	}

	private void friendPinchAction(PokeSet targets)
	{
	}

	private bool IsPinch(uint now_value, uint max_value)
	{
		return default(bool);
	}

	private void checkItemReaction_ForTargets(PokeSet targets)
	{
	}

	private void checkItemReaction(BTL_POKEPARAM poke)
	{
	}
}
