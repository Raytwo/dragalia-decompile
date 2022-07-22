using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_Root_Cover : Section
{
	public class Description
	{
		public SVCL_ACTION pClientInstructions;
	}

	public class Result
	{
		public InterruptCode interrupt;
	}

	public Section_Root_Cover([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void storePokeActions(SVCL_ACTION pClientInstructions)
	{
	}

	private void sortPokeActionOrder()
	{
	}

	private void processCoverAction()
	{
	}

	private void onTurnEnd()
	{
	}
}
