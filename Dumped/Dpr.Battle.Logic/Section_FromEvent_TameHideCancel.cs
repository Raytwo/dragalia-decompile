using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_TameHideCancel : Section
{
	public class Description
	{
		public byte targetPokeID;

		public ContFlag flag;

		public StrParam successMessage;
	}

	public class Result
	{
		public bool isSucceeded;
	}

	public Section_FromEvent_TameHideCancel([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}

	private bool cancelHide(BTL_POKEPARAM poke, ContFlag flag)
	{
		return default(bool);
	}
}
