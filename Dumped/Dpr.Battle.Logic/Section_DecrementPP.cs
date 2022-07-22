using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_DecrementPP : Section
{
	public class Description
	{
		public BTL_POKEPARAM poke;

		public byte wazaIndex;

		public byte volume;
	}

	public class Result
	{
		public bool isDecrement;
	}

	public Section_DecrementPP([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}
}
