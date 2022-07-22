using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_WazaExec_CheckFail_2nd : Section
{
	public class Description
	{
		public BTL_POKEPARAM attacker;

		public WazaParam wazaParam;

		public PokeSet targets;
	}

	public class Result
	{
		public bool isFailed;
	}

	public Section_WazaExec_CheckFail_2nd([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private WazaFailCause checkWazaFail(BTL_POKEPARAM attacker, WazaParam wazaParam, PokeSet targets)
	{
		return default(WazaFailCause);
	}

	private void wazaExecFailed(BTL_POKEPARAM attacker, WazaParam wazaParam, WazaFailCause failCause)
	{
	}
}
