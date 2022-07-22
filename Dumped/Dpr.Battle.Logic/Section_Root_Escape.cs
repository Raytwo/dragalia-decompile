using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_Root_Escape : Section
{
	public class Description
	{
	}

	public class Result
	{
		public bool isSuccessed;
	}

	public Section_Root_Escape([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private bool escape()
	{
		return default(bool);
	}

	private void onTurnEnd()
	{
	}
}
