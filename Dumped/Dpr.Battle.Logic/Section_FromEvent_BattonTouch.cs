using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_BattonTouch : Section
{
	public class Description
	{
		public byte userPokeID;

		public byte targetPokeID;
	}

	public class Result
	{
	}

	public Section_FromEvent_BattonTouch([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}
}
