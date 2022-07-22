using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_CheckExpGet : Section
{
	public class Description
	{
	}

	public class Result
	{
		public bool isExpGet;
	}

	public Section_CheckExpGet([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void calcExp(ExpCalculator.CalcExpContainer pExpContainer)
	{
	}

	private bool isExpProvidePoke(byte deadPokeID)
	{
		return default(bool);
	}

	private bool canPlayWinWildBGM()
	{
		return default(bool);
	}

	private void playWinWildBGM()
	{
	}

	private bool isPlayerSideAlive()
	{
		return default(bool);
	}

	private bool getExp(ExpCalculator.CalcExpContainer pExpContainer)
	{
		return default(bool);
	}
}
