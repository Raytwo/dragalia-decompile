using System.Runtime.InteropServices;
using Pml;

namespace Dpr.Battle.Logic;

public sealed class Section_WazaExec_Category_PushOut : Section
{
	public class Description
	{
		public WazaNo waza;

		public BTL_POKEPARAM attacker;

		public PokeSet targets;
	}

	public class Result
	{
	}

	public Section_WazaExec_Category_PushOut([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void pushOut(out bool isSuccessed, out bool isFailMsgDisplayed, BTL_POKEPARAM attacker, BTL_POKEPARAM target, ushort effectNo)
	{
	}
}
