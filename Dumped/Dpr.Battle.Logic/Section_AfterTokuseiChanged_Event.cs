using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_AfterTokuseiChanged_Event : Section
{
	public class Description
	{
		public BTL_POKEPARAM poke;
	}

	public class Result
	{
	}

	public Section_AfterTokuseiChanged_Event([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description desc)
	{
	}
}
