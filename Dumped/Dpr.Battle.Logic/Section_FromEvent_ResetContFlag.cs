using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_ResetContFlag : Section
{
	public class Description
	{
		public byte pokeID;

		public ContFlag flag;
	}

	public class Result
	{
		public bool isSuccessed;
	}

	public Section_FromEvent_ResetContFlag([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}
}
