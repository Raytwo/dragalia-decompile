using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_SwapPoke : Section
{
	public class Description
	{
		public byte pokeID1;

		public byte pokeID2;

		public StrParam successMessage;
	}

	public class Result
	{
		public bool isSwapped;
	}

	public Section_FromEvent_SwapPoke([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}

	private void afterMoveEvent(BTL_POKEPARAM poke)
	{
	}
}
