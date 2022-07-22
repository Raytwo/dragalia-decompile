using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_SideEffect_Swap : Section
{
	public delegate bool SidefEffectSwapCheck(BtlSideEffect effect);

	public class Description
	{
		public BtlSide side1;

		public BtlSide side2;

		public SidefEffectSwapCheck checkFunc;
	}

	public class Result
	{
		public bool isChanged;
	}

	public Section_SideEffect_Swap([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}
}
