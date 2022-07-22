using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_SetSpActPriority : Section
{
	public class Description
	{
		public PokeActionContainer actionContainer;
	}

	public class Result
	{
	}

	public Section_SetSpActPriority([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}
}
