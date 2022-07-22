using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_RankFlat_Weaken : Section
{
	public class Description
	{
		public byte pokeID;
	}

	public class Result
	{
		public bool isSuccessed;
	}

	public Section_FromEvent_RankFlat_Weaken([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}
}
