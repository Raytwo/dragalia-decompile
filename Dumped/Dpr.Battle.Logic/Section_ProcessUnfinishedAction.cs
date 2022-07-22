using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_ProcessUnfinishedAction : Section
{
	public class Description
	{
		public PokeActionContainer pokeActionContainer;
	}

	public class Result
	{
	}

	public Section_ProcessUnfinishedAction([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void sortActionOrder(PokeActionContainer actionContainer)
	{
	}

	private void processAction(PokeAction pokeAction)
	{
	}

	private void onAllActionDone()
	{
	}

	private bool raidboss_checkAngryWazaEnable()
	{
		return default(bool);
	}

	private void raidboss_addAngryWazaAction()
	{
	}
}
