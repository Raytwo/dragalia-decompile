using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_RemovePosEffect : Section
{
	public class Description
	{
		public BtlPokePos pos;

		public BtlPosEffect effect;
	}

	public class Result
	{
	}

	public Section_FromEvent_RemovePosEffect([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}
}
