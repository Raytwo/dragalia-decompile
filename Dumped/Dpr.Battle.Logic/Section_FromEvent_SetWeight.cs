using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_SetWeight : Section
{
	public class Description
	{
		public byte pokeID;

		public ushort weight;

		public StrParam successMessage;
	}

	public class Result
	{
	}

	public Section_FromEvent_SetWeight([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}
}
