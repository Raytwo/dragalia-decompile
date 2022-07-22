using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_SetPermFlag : Section
{
	public class Description
	{
		public byte pokeID;

		public BTL_POKEPARAM.PermFlag flag;
	}

	public class Result
	{
	}

	public Section_FromEvent_SetPermFlag([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}
}
