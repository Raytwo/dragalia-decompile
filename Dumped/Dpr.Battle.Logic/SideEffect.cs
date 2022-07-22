namespace Dpr.Battle.Logic;

public static class SideEffect
{
	private struct ELEM
	{
		public BtlSideEffect sideEffect;

		public uint maxAddCount;

		public ELEM(BtlSideEffect sideEffect, uint maxAddCount)
		{
		}
	}

	private static readonly ELEM[] SIDE_EFFECT_DESC;

	public static uint GetMaxAddCount(BtlSideEffect sideEffect)
	{
		return default(uint);
	}
}
