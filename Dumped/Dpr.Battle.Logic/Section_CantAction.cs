using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_CantAction : Section
{
	public class Description
	{
		public BTL_POKEPARAM poke;
	}

	public class Result
	{
	}

	public Section_CantAction([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}
}
