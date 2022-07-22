using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_ResetTurnFlag : Section
{
	public class Description
	{
		public byte pokeID;

		public BTL_POKEPARAM.TurnFlag flag;
	}

	public class Result
	{
		public bool isSuccessed;
	}

	public Section_FromEvent_ResetTurnFlag([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}
}
