using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_CheckFloating : Section
{
	public class Description
	{
		public BTL_POKEPARAM target;

		public bool isIncludeHikouType;
	}

	public class Result
	{
		public bool isFloating;
	}

	public Section_CheckFloating([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}
}
