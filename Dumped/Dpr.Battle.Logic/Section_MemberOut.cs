using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_MemberOut : Section
{
	public class Description
	{
		public BTL_POKEPARAM outPoke;

		public bool isInterruptDisable;
	}

	public class Result
	{
		public bool isOutSuccessed;
	}

	public Section_MemberOut([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void memberOut(BTL_POKEPARAM outPoke)
	{
	}
}
