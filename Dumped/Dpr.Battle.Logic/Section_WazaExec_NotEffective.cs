using System.Runtime.InteropServices;
using Pml;

namespace Dpr.Battle.Logic;

public sealed class Section_WazaExec_NotEffective : Section
{
	public class Description
	{
		public byte pokeID;

		public WazaNo wazaID;

		public ActionDesc pActionDesc;
	}

	public class Result
	{
	}

	public Section_WazaExec_NotEffective([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}
}
