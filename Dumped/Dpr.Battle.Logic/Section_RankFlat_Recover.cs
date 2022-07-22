using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_RankFlat_Recover : Section
{
	public class Description
	{
		public byte pokeID;
	}

	public class Result
	{
		public bool isSuccessed;
	}

	public Section_RankFlat_Recover([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}
}
