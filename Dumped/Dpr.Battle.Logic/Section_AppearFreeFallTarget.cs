using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_AppearFreeFallTarget : Section
{
	public class Description
	{
		public byte targetPokeID;
	}

	public class Result
	{
	}

	public Section_AppearFreeFallTarget([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}
}
