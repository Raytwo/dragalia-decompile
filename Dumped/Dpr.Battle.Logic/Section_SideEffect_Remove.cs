using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_SideEffect_Remove : Section
{
	public class Description
	{
		public byte pokeID;

		public BtlSide side;

		public byte[] flags;

		public bool isTokuseiWindowDisplay;
	}

	public class Result
	{
		public bool isSuccessed;
	}

	private class RemoveResult
	{
		public bool[][] isRemoved;

		public bool isRemovedAny()
		{
			return default(bool);
		}
	}

	public Section_SideEffect_Remove([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}

	private bool removeSideEffects(RemoveResult pResult, BtlSide side, byte[] sideEffectBitFlag)
	{
		return default(bool);
	}

	private bool removeSideEffect(BtlSide side, BtlSideEffect effect)
	{
		return default(bool);
	}
}
