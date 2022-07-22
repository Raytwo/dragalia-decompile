using System.Runtime.InteropServices;
using Pml;

namespace Dpr.Battle.Logic;

public sealed class Section_WazaExec_CheckFail_1st : Section
{
	public class Description
	{
		public BTL_POKEPARAM attacker;

		public WazaParam wazaParam;

		public bool isWazaLock;

		public ActionDesc actionDesc;
	}

	public class Result
	{
		public bool isFailed;
	}

	public Section_WazaExec_CheckFail_1st([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private WazaFailCause checkFail(BTL_POKEPARAM attacker, WazaParam wazaParam, bool isWazaLock, ActionDesc actionDesc)
	{
		return default(WazaFailCause);
	}

	private void cureNemuriCheck(BTL_POKEPARAM attacker)
	{
	}

	private bool cureKooriCheck(BTL_POKEPARAM attacker, WazaNo waza)
	{
		return default(bool);
	}

	private bool isWazaFailByKodawariLock(BTL_POKEPARAM attacker, WazaNo waza)
	{
		return default(bool);
	}

	private SabotageType checkSabotageType(BTL_POKEPARAM poke)
	{
		return default(SabotageType);
	}

	private bool isSabotageEnable(BTL_POKEPARAM poke)
	{
		return default(bool);
	}

	private SabotageType checkSabotageType_ByLevel(BTL_POKEPARAM poke)
	{
		return default(SabotageType);
	}

	private bool konranCheck(BTL_POKEPARAM attacker, SabotageType sabotageType)
	{
		return default(bool);
	}

	private void cureSick_KONRAN(BTL_POKEPARAM poke)
	{
	}

	private void cureSick_NEMURI(BTL_POKEPARAM poke)
	{
	}

	private void cureSick_KOORI(BTL_POKEPARAM poke)
	{
	}

	private void cureSick_KOORI_ByWaza(BTL_POKEPARAM poke, WazaNo wazano)
	{
	}

	private bool meromeroCheck(BTL_POKEPARAM attacker)
	{
		return default(bool);
	}

	private void wazaExecFailed(BTL_POKEPARAM attacker, WazaParam wazaParam, WazaFailCause failCause)
	{
	}

	private void wazaExecSucceeded(BTL_POKEPARAM attacker, WazaParam wazaParam)
	{
	}
}
