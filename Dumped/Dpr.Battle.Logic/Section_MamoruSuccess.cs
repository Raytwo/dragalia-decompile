using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_MamoruSuccess : Section
{
	public class Description
	{
		public BTL_POKEPARAM attacker;

		public BTL_POKEPARAM target;

		public WazaParam wazaParam;
	}

	public class Result
	{
	}

	public Section_MamoruSuccess([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}
}
