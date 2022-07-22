using System.Runtime.InteropServices;
using Pml;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_Kill : Section
{
	public class Description
	{
		public byte userPokeID;

		public byte targetPokeID;

		public bool isDeadPokeEnable;

		public bool isDisableDeadProcess;

		public WazaNo recordWazaID;

		public DamageCause deadCause;

		public StrParam message;
	}

	public class Result
	{
		public bool isKilled;
	}

	public Section_FromEvent_Kill([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}

	private void kill(BTL_POKEPARAM target, byte attackerID, DamageCause deadCause, PGLRecord.RecParam pPglParam, bool doDeadProcess)
	{
	}
}
