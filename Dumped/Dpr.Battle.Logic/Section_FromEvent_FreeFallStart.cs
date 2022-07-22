using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_FreeFallStart : Section
{
	public class Description
	{
		public byte attackerID;

		public byte targetID;

		public WazaParam wazaParam;
	}

	public class Result
	{
		public bool isSucceeded;

		public bool isFailMessageDisplayed;
	}

	public Section_FromEvent_FreeFallStart([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}

	private uint getWeight(BTL_POKEPARAM poke)
	{
		return default(uint);
	}

	private void onMamoruSuccess(BTL_POKEPARAM attacker, BTL_POKEPARAM target, WazaParam wazaParam)
	{
	}

	private bool checkGuard(BTL_POKEPARAM attacker, BTL_POKEPARAM target, WazaParam wazaParam)
	{
		return default(bool);
	}

	private void setFreeFallSick(BTL_POKEPARAM attacker, BTL_POKEPARAM target)
	{
	}
}
