using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_Escape_Sub : Section
{
	public class Description
	{
		public BTL_POKEPARAM escapePoke;

		public bool isSkipAgiCheck;

		public bool isForceSuccess;
	}

	public class Result
	{
		public bool isSucceeded;
	}

	public Section_Escape_Sub([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void checkForceSucceed(ref bool pIsForceSuccess, ref bool pIsSkipAgiCheck, [In] ref Description description)
	{
	}

	private bool section_Escape_CheckForceSucceed(BTL_POKEPARAM pPoke)
	{
		return default(bool);
	}

	private bool checkEscapeEnableByAgi(BTL_POKEPARAM escapePoke, byte tryCount)
	{
		return default(bool);
	}

	private bool section_Escape_Core(BTL_POKEPARAM pPoke, bool isForceSuccess)
	{
		return default(bool);
	}
}
