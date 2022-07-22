using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_AfterItemEquip : Section
{
	public class Description
	{
		public BTL_POKEPARAM poke;

		public ushort itemID;

		public bool isKinomiCheckEnable;
	}

	public class Result
	{
	}

	public Section_AfterItemEquip([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}
}
