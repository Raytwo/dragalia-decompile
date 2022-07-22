using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_TurnCheck_Event : Section
{
	public class Description
	{
		public EventID eventID;
	}

	public class Result
	{
		public bool isExpGet;
	}

	public Section_TurnCheck_Event([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void storeFrontPokeByAgilityOrder(PokeSet pokeSet)
	{
	}

	private void checkPokeDead(BTL_POKEPARAM poke)
	{
	}

	private bool checkExpGet()
	{
		return default(bool);
	}
}
