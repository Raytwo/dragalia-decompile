using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_Root_ProcessActions : Section
{
	public class Description
	{
		public SVCL_ACTION pClientInstructions;
	}

	public class Result
	{
		public InterruptCode interrupt;
	}

	public Section_Root_ProcessActions([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void onTurnStart()
	{
	}

	private void storePokeActions(SVCL_ACTION pClientInstructions)
	{
	}

	private void sortPokeActionOrder()
	{
	}

	private void setSpActPriority()
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

	private void turnEnd()
	{
	}
}
