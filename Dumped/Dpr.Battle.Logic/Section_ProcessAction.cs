using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_ProcessAction : Section
{
	public class Description
	{
		public PokeAction pokeAction;
	}

	public class Result
	{
	}

	public Section_ProcessAction([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void processActionCore(PokeAction pokeAction)
	{
	}

	private bool checkExpGet()
	{
		return default(bool);
	}

	private void raidboss_updateGwazaUseSchedule(PokeAction pokeAction)
	{
	}

	private void raidboss_angry()
	{
	}

	private bool raidboss_checkAngryWazaEnable(PokeAction pokeAction)
	{
		return default(bool);
	}

	private void raidboss_addAngryWazaAction()
	{
	}
}
