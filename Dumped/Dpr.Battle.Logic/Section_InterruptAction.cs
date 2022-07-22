using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_InterruptAction : Section
{
	public class Description
	{
		public byte interruptPokeID;

		public byte targetPokeID;
	}

	public class Result
	{
		public bool isInterrupted;
	}

	public Section_InterruptAction([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}

	private PokeAction getInterruptPokeAction(byte interruptPokeID)
	{
		return null;
	}

	private void processAction(PokeAction pokeAction)
	{
	}
}
