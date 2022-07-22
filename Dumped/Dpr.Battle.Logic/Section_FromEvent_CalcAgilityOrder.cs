using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_CalcAgilityOrder : Section
{
	public class Description
	{
		public BTL_POKEPARAM target;

		public bool isTrickRoomApply;
	}

	public class Result
	{
		public byte order;
	}

	public Section_FromEvent_CalcAgilityOrder([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}

	private ushort calcAgility(BTL_POKEPARAM poke, bool isTrickRoomApply)
	{
		return default(ushort);
	}
}
