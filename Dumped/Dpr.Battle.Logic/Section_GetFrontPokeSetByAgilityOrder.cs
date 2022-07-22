using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_GetFrontPokeSetByAgilityOrder : Section
{
	public class Description
	{
		public PokeSet pPokeSet;
	}

	public class Result
	{
	}

	public Section_GetFrontPokeSetByAgilityOrder([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void storeFrontPoke(PokeSet pPokeSet)
	{
	}

	private void sortByAgility(PokeSet pPokeSet)
	{
	}
}
