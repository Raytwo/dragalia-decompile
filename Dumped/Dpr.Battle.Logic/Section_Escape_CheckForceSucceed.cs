using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_Escape_CheckForceSucceed : Section
{
	public class Description
	{
		public BTL_POKEPARAM poke;
	}

	public class Result
	{
		public bool canEscape;
	}

	public Section_Escape_CheckForceSucceed([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}
}
