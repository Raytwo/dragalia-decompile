using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_CalcAgility : Section
{
	public class Description
	{
		public BTL_POKEPARAM poke;

		public bool isTrickRoomApply;
	}

	public class Result
	{
		public ushort agility;
	}

	public Section_FromEvent_CalcAgility([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}
}
