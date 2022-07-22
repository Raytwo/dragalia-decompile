using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_Migawari_Delete : Section
{
	public class Description
	{
		public BTL_POKEPARAM poke;

		public bool canPutDefaultMessage;
	}

	public class Result
	{
	}

	public Section_Migawari_Delete([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}
}
