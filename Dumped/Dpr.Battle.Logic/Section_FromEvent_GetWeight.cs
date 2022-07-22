using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_GetWeight : Section
{
	public class Description
	{
		public byte pokeID;
	}

	public class Result
	{
		public uint weight;
	}

	public Section_FromEvent_GetWeight([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}
}
