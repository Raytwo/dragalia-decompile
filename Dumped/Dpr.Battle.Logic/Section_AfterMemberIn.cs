using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_AfterMemberIn : Section
{
	public class Description
	{
		public PokeIDRegister targets;
	}

	public class Result
	{
	}

	public Section_AfterMemberIn([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void getTargets(PokeSet pokeSet, PokeIDRegister targetPokemons)
	{
	}

	private void sortByAgility(PokeSet pokeSet)
	{
	}

	private void event_DefaultPowerUp(PokeSet targets)
	{
	}

	private void event_BattonTouch(PokeSet targets)
	{
	}

	private void event_MemberIn(PokeSet targets)
	{
	}
}
