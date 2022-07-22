using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_Shrink : Section
{
	public class Description
	{
		public BTL_POKEPARAM target;

		public uint percentage;
	}

	public class Result
	{
		public bool isSuccess;
	}

	public Section_Shrink([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}
}
