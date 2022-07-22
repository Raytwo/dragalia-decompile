using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_WazaExec_CheckFail_Funjin : Section
{
	public class Description
	{
		public BTL_POKEPARAM attacker;

		public WazaParam wazaParam;
	}

	public class Result
	{
		public bool isFailed;
	}

	public Section_WazaExec_CheckFail_Funjin([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private bool doFunjinExplode(BTL_POKEPARAM attacker, WazaParam wazaParam)
	{
		return default(bool);
	}

	private void putFunjinExplodeCommand(BTL_POKEPARAM attacker, WazaParam wazaParam)
	{
	}

	private bool isDamageEnable(BTL_POKEPARAM poke, uint damage)
	{
		return default(bool);
	}

	private void addDamage(BTL_POKEPARAM damagePoke, uint damage)
	{
	}

	private void checkPokeDead(BTL_POKEPARAM poke)
	{
	}
}
