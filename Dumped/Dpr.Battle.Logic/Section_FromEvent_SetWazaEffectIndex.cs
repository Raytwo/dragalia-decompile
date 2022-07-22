using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_SetWazaEffectIndex : Section
{
	public class Description
	{
		public byte effectIndex;
	}

	public class Result
	{
	}

	public Section_FromEvent_SetWazaEffectIndex([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}
}
