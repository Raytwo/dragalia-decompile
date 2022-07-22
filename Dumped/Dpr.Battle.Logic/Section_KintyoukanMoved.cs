using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_KintyoukanMoved : Section
{
	public class Description
	{
		public BTL_POKEPARAM movedPoke;
	}

	public class Result
	{
	}

	public Section_KintyoukanMoved([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void checkItemReaction(BTL_POKEPARAM poke)
	{
	}
}
