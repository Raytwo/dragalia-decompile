using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_RecoverHP_CheckFailBase : Section
{
	public class Description
	{
		public BTL_POKEPARAM poke;
	}

	public class Result
	{
		public bool isFailed;
	}

	public Section_RecoverHP_CheckFailBase([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}
}
