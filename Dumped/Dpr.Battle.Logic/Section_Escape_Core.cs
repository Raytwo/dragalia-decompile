using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_Escape_Core : Section
{
	public class Description
	{
		public BTL_POKEPARAM escapePoke;

		public bool isForceSuccess;

		public bool isSpMessageCheckEnable;
	}

	public class Result
	{
		public bool isSucceeded;
	}

	public Section_Escape_Core([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private bool checkEscapeForbid(BTL_POKEPARAM escapePoke)
	{
		return default(bool);
	}

	private bool putSpEscapeMessage(BTL_POKEPARAM escapePoke)
	{
		return default(bool);
	}

	private void putDefaultEscapeMessage(BTL_POKEPARAM escapePoke)
	{
	}
}
