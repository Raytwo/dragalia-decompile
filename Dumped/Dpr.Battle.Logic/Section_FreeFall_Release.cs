using System.Runtime.InteropServices;
using Pml.WazaData;

namespace Dpr.Battle.Logic;

public sealed class Section_FreeFall_Release : Section
{
	public class Description
	{
		public BTL_POKEPARAM attacker;

		public bool canAppearSelf;

		public bool canAppearTarget;
	}

	public class Result
	{
	}

	public Section_FreeFall_Release([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private BTL_POKEPARAM getCapturedPoke(BTL_POKEPARAM attacker)
	{
		return null;
	}

	private void freeFallEnd_Captured(BTL_POKEPARAM capturedPoke, bool canAppear)
	{
	}

	private void cureSick(BTL_POKEPARAM poke, WazaSick sick)
	{
	}

	private void freeFallEnd_Attacker(BTL_POKEPARAM attacker, bool canAppear)
	{
	}
}
