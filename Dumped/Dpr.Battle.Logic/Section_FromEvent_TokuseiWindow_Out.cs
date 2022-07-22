using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_TokuseiWindow_Out : Section
{
	public class Description
	{
		public byte pokeID;
	}

	public class Result
	{
		public bool isVanished;
	}

	public Section_FromEvent_TokuseiWindow_Out([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}
}
