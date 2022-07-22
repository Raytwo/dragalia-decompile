using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_ProcessInterruptPokeChangeAction : Section
{
	public class Description
	{
		public PokeActionContainer pokeActionContainer;
	}

	public class Result
	{
	}

	public Section_ProcessInterruptPokeChangeAction([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void processAction_OnlyPokeChange(PokeIDRegister inPokeIDRegister, PokeActionContainer pokeActionContainer)
	{
	}

	private byte section_MemberChange(byte clientID, byte outPosIndex, byte inPokeIndex)
	{
		return default(byte);
	}

	private void afterMemberIn(PokeIDRegister targets)
	{
	}

	private bool checkExpGet()
	{
		return default(bool);
	}
}
