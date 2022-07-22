using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_SortByAgility : Section
{
	public class Description
	{
		public PokeSet targets;
	}

	public class Result
	{
	}

	public Section_SortByAgility([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}
}
