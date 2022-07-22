using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_SetContFlag : Section
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

	public Section_FromEvent_SetContFlag([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}
}
