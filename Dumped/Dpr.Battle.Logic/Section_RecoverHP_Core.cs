using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_RecoverHP_Core : Section
{
	public class Description
	{
		public BTL_POKEPARAM poke;

		public ushort recoverHP;

		public bool isEffectEnable;
	}

	public class Result
	{
	}

	public Section_RecoverHP_Core([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}
}
