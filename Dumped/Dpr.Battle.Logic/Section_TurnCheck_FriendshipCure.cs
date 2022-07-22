using System.Runtime.InteropServices;
using Pml.WazaData;

namespace Dpr.Battle.Logic;

public sealed class Section_TurnCheck_FriendshipCure : Section
{
	public class Description
	{
	}

	public class Result
	{
	}

	public Section_TurnCheck_FriendshipCure([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void storeFrontPokeByAgilityOrder(PokeSet pPokeSet)
	{
	}

	private void cureSick(BTL_POKEPARAM poke, WazaSick sick)
	{
	}
}
