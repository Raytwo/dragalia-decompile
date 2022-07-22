using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_RankReset : Section
{
	public class Description
	{
		public byte pokeCount;

		public byte[] pokeID;
	}

	public class Result
	{
		public bool isSuccessed;
	}

	public Section_FromEvent_RankReset([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}
}
