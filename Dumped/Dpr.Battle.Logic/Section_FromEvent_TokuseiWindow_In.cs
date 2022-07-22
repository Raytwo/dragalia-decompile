using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_TokuseiWindow_In : Section
{
	public class Description
	{
		public byte pokeID;
	}

	public class Result
	{
		public bool isDisplayed;
	}

	public Section_FromEvent_TokuseiWindow_In([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}
}
