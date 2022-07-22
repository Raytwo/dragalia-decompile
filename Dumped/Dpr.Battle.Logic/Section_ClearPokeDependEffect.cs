using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_ClearPokeDependEffect : Section
{
	public class Description
	{
		public BTL_POKEPARAM poke;
	}

	public class Result
	{
	}

	public Section_ClearPokeDependEffect([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void releaseFreeFall(BTL_POKEPARAM poke)
	{
	}

	private void removeHandlers(BTL_POKEPARAM poke)
	{
	}

	private void cureDependPokeSick(BTL_POKEPARAM causePoke)
	{
	}

	private void removeDependPokeField(BTL_POKEPARAM causePoke)
	{
	}

	private void onKintyoukanMoved(BTL_POKEPARAM poke)
	{
	}
}
