using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_RecoverPP : Section
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

	public Section_FromEvent_RecoverPP([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}
}
