using System.Runtime.InteropServices;
using Pml;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_InterruptAction_ByWaza : Section
{
	public class Description
	{
		public WazaNo waza;
	}

	public class Result
	{
		public bool isSucceeded;
	}

	public Section_FromEvent_InterruptAction_ByWaza([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}
}
