using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_DeadCheck : Section
{
	public class Description
	{
		public byte pokeID;
	}

	public class Result
	{
		public bool isChecked;
	}

	public Section_FromEvent_DeadCheck([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}

	private void checkPokeDead(BTL_POKEPARAM poke)
	{
	}
}
