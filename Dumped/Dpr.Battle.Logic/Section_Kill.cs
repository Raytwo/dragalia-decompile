using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_Kill : Section
{
	public class Description
	{
		public BTL_POKEPARAM target;

		public byte attackerID;

		public DamageCause deadCause;

		public PGLRecord.RecParam pPglParam;

		public bool doDeadProcess;
	}

	public class Result
	{
	}

	public Section_Kill([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void deadProcess(BTL_POKEPARAM target, PGLRecord.RecParam pPglParam)
	{
	}
}
