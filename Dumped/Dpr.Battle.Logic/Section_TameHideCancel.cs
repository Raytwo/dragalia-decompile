using System.Runtime.InteropServices;
using Pml.WazaData;

namespace Dpr.Battle.Logic;

public sealed class Section_TameHideCancel : Section
{
	public class Description
	{
		public BTL_POKEPARAM poke;

		public ContFlag hideContFlag;

		public bool isOmitCancelAction;
	}

	public class Result
	{
		public bool isCanceled;
	}

	public Section_TameHideCancel([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void cureSick(BTL_POKEPARAM poke, WazaSick sick)
	{
	}
}
