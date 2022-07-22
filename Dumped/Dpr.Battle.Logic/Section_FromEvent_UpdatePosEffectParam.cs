using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_UpdatePosEffectParam : Section
{
	public class Description
	{
		public BtlPokePos pos;

		public BtlPosEffect effect;

		public PosEffect.EffectParam effectParam;
	}

	public class Result
	{
	}

	public Section_FromEvent_UpdatePosEffectParam([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}
}
