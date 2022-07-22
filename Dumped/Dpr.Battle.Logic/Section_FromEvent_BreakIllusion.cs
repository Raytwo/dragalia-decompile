using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_BreakIllusion : Section
{
	public class Description
	{
		public byte targetPokeID;

		public StrParam successMessage;
	}

	public class Result
	{
		public bool isSucceeded;
	}

	public Section_FromEvent_BreakIllusion([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}
}
