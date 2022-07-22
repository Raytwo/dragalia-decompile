using System.Runtime.InteropServices;
using Pml.WazaData;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_CheckJuryoku : Section
{
	public class Description
	{
		public byte userPokeID;
	}

	public class Result
	{
	}

	public Section_FromEvent_CheckJuryoku([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}

	private void getAllFrontPokeID(byte[] pokeIDArray, out uint pokeCount, byte basePokeID)
	{
	}

	private void cancelSoraWoTobu(BTL_POKEPARAM poke)
	{
	}

	private void freefallRelease(BTL_POKEPARAM poke)
	{
	}

	private void cureSick(BTL_POKEPARAM poke, WazaSick sick)
	{
	}
}
