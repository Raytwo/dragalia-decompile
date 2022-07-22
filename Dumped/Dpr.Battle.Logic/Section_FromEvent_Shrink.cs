using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_Shrink : Section
{
	public class Description
	{
		public byte pokeID;

		public byte percentage;
	}

	public class Result
	{
		public bool isSucceeded;
	}

	public Section_FromEvent_Shrink([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}

	private bool shrink(byte pokeID, byte percentage)
	{
		return default(bool);
	}
}
