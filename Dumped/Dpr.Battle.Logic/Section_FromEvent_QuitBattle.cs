using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_QuitBattle : Section
{
	public class Description
	{
		public byte userPokeID;

		public bool isForceSuccess;

		public bool isDisplayTokuseiWindow;
	}

	public class Result
	{
		public bool isSucceeded;
	}

	public Section_FromEvent_QuitBattle([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}

	private bool escape(BTL_POKEPARAM poke, bool isForceSuccess)
	{
		return default(bool);
	}
}
