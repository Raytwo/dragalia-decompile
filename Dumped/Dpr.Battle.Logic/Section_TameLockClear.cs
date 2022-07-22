using System.Runtime.InteropServices;
using Pml.WazaData;

namespace Dpr.Battle.Logic;

public sealed class Section_TameLockClear : Section
{
	public class Description
	{
		public BTL_POKEPARAM poke;
	}

	public class Result
	{
	}

	public Section_TameLockClear([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void clearTameLock(BTL_POKEPARAM poke)
	{
	}

	private void cureSick(BTL_POKEPARAM poke, WazaSick sick)
	{
	}

	private void clearHide(BTL_POKEPARAM poke)
	{
	}
}
