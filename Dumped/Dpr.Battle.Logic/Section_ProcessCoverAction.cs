using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_ProcessCoverAction : Section
{
	public class Description
	{
	}

	public class Result
	{
	}

	public Section_ProcessCoverAction([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void processAction_Change(PokeIDRegister inPokeIDRegister)
	{
	}

	private void processAction_Cover(PokeIDRegister inPokeIDRegister)
	{
	}

	private byte memberChange(PokeAction pokeAction)
	{
		return default(byte);
	}

	private void afterMemberIn(PokeIDRegister targets)
	{
	}

	private void checkExpGet()
	{
	}

	private void requestPokeChangeForServer()
	{
	}
}
