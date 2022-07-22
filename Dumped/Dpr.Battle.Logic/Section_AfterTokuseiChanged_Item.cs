using System.Runtime.InteropServices;
using Pml;

namespace Dpr.Battle.Logic;

public sealed class Section_AfterTokuseiChanged_Item : Section
{
	public class Description
	{
		public BTL_POKEPARAM poke;

		public TokuseiNo prevTokusei;

		public TokuseiNo nextTokusei;
	}

	public class Result
	{
	}

	public Section_AfterTokuseiChanged_Item([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description desc)
	{
	}

	private void checkItemReaction(BTL_POKEPARAM poke)
	{
	}

	private void onKintyoukanMoved(BTL_POKEPARAM poke)
	{
	}
}
