using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_DrainHP : Section
{
	public class Description
	{
		public ushort recoverHP;

		public byte recoverPokeID;

		public byte damagedPokeID;

		public bool isSkipFailCheckSP;

		public StrParam successMessage;
	}

	public class Result
	{
		public bool isSuccessed;
	}

	public Section_FromEvent_DrainHP([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}

	private bool drain(BTL_POKEPARAM attacker, BTL_POKEPARAM target, ushort drainHP, bool skipSpFailCheck)
	{
		return default(bool);
	}
}
