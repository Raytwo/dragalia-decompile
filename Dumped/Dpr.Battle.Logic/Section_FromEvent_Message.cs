using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_Message : Section
{
	public class Description
	{
		public byte pokeID;

		public bool isDisplayTokuseiWindow;

		public StrParam message;
	}

	public class Result
	{
	}

	public Section_FromEvent_Message([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}
}
