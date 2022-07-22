using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_ChangeItem : Section
{
	public class Description
	{
		public BTL_POKEPARAM poke;

		public ushort nextItemID;

		public bool isPrevItemConsumed;
	}

	public class Result
	{
	}

	public Section_ChangeItem([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}
}
