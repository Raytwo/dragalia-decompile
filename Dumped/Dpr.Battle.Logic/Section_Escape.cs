using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_Escape : Section
{
	public class Description
	{
		public BTL_POKEPARAM poke;
	}

	public class Result
	{
		public bool isSucceeded;
	}

	public Section_Escape([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private bool escape(BTL_POKEPARAM poke)
	{
		return default(bool);
	}

	private void onEscapeFailed(BTL_POKEPARAM poke)
	{
	}
}
