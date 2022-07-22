using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_Root_FirstPokeIn : Section
{
	public class Description
	{
	}

	public class Result
	{
		public InterruptCode interrupt;
	}

	public Section_Root_FirstPokeIn([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void changeWeather()
	{
	}

	private void changeGround()
	{
	}

	private void memberInAll()
	{
	}

	private void memberInAll(PokeIDRegister inPokeIDRegister, byte clientID)
	{
	}

	private void memberIn(PokeIDRegister inPokeIDRegister, byte clientID, byte posIdx, byte nextPokeIdx)
	{
	}

	private void afterMemberIn(PokeIDRegister inPokeIDRegister)
	{
	}

	private void firstPokeInEnd()
	{
	}
}
