using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_TokuseiDisabled : Section
{
	public class Description
	{
		public BTL_POKEPARAM target;
	}

	public class Result
	{
	}

	public Section_TokuseiDisabled([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}

	private void onKintyoukanMoved(BTL_POKEPARAM poke)
	{
	}
}
