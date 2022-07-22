using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_DecrementPP : Section
{
	public class Description
	{
		public byte pokeID;

		public byte wazaIdx;

		public byte volume;

		public bool isSurfacePP;

		public bool isDeadPokeEnable;

		public StrParam successMessage;
	}

	public class Result
	{
		public bool isSuccessed;
	}

	public Section_FromEvent_DecrementPP([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}

	private bool decrementPP(BTL_POKEPARAM poke, byte wazaIndex, byte volume)
	{
		return default(bool);
	}

	private void useItem(BTL_POKEPARAM poke)
	{
	}
}
