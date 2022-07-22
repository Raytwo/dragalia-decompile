using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_PosEffect_Add : Section
{
	public class Description
	{
		public byte userPokeID;

		public BtlPokePos pos;

		public BtlPosEffect effect;

		public PosEffect.EffectParam effectParam;

		public bool isSkipHpRecoverSpFailCheck;
	}

	public class Result
	{
		public bool isAdded;
	}

	public Section_FromEvent_PosEffect_Add([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}

	private void getEventFactorParam(int[] factorParam, ref byte factorParamNum, byte userPokeID, BtlPokePos pos, BtlPosEffect effect, [In] ref PosEffect.EffectParam effectParam, bool isSkipHpRecoverSpFailCheck)
	{
	}
}
