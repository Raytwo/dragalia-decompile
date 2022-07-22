using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_Root_InterruptPokeChange : Section
{
	public class Description
	{
		public SVCL_ACTION pClientInstructions;
	}

	public class Result
	{
		public InterruptCode interrupt;
	}

	public Section_Root_InterruptPokeChange([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void storePokeActions(PokeActionContainer pokeActionContainer, SVCL_ACTION pClientInstructions)
	{
	}

	private void processInterruptPokeChangeAction(PokeActionContainer pokeActionContainer)
	{
	}

	private void processUnfinishedAction()
	{
	}

	private void turnCheck()
	{
	}

	private void coverCheck()
	{
	}

	private void onTurnEnd()
	{
	}
}
