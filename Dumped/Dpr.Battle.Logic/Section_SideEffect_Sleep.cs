using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_SideEffect_Sleep : Section
{
	public class Description
	{
		public BtlSide side;

		public byte[] flags;

		public bool wakeUpFlag;
	}

	public class Result
	{
		public bool isSuccessed;
	}

	public Section_SideEffect_Sleep([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}

	private bool sleepSideEffects(BtlSide side, byte[] sideEffectBitFlag, bool wakeUpFlag)
	{
		return default(bool);
	}

	private bool sleepSideEffect(BtlSide side, BtlSideEffect effect, bool wakeUpFlag)
	{
		return default(bool);
	}
}
