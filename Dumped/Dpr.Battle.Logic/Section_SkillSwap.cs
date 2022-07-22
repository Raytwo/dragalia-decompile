using System.Runtime.InteropServices;
using Pml;

namespace Dpr.Battle.Logic;

public sealed class Section_SkillSwap : Section
{
	public class Description
	{
		public BTL_POKEPARAM attacker;

		public PokeSet targets;

		public bool needFailMessageDisplay;

		public TokuseiChangeCause cause;
	}

	public class Result
	{
	}

	public Section_SkillSwap([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description desc)
	{
	}

	private bool checkFail(BTL_POKEPARAM pAttacker, BTL_POKEPARAM pTarget, TokuseiChangeCause cause)
	{
		return default(bool);
	}

	private void afterTokuseiChanged_Event(BTL_POKEPARAM poke)
	{
	}

	private void afterTokuseiChanged_Item(BTL_POKEPARAM poke, TokuseiNo prevTokusei, TokuseiNo nextTokusei)
	{
	}
}
