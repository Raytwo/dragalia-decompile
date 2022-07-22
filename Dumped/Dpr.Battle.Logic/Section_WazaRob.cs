using System.Runtime.InteropServices;
using Pml;

namespace Dpr.Battle.Logic;

public sealed class Section_WazaRob : Section
{
	public class Description
	{
		public WazaRobParam robParam;

		public BTL_POKEPARAM attacker;

		public WazaNo actWaza;
	}

	public class Result
	{
	}

	public Section_WazaRob([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void event_WazaRob(BTL_POKEPARAM robPoke, BTL_POKEPARAM originalPoke, WazaNo waza)
	{
	}

	private void getWazaParam(WazaParam pWazaParam, BTL_POKEPARAM attacker, WazaNo waza)
	{
	}

	private void registerTarget(PokeSet pPokeSet, BTL_POKEPARAM pAttacker, WazaParam pWazaParam, BtlPokePos targetPos)
	{
	}

	private bool isFailedByKaihukuHuuji(BTL_POKEPARAM attacker, WazaParam wazaParam)
	{
		return default(bool);
	}

	private void putFailedMessageByKaihukuHuuji(BTL_POKEPARAM attacker, WazaParam wazaParam)
	{
	}

	private bool isFailedByZigokuDuki(BTL_POKEPARAM attacker, WazaParam wazaParam)
	{
		return default(bool);
	}

	private void putFailedMessageByZigokuDuki(BTL_POKEPARAM attacker, WazaParam wazaParam)
	{
	}

	private void wazaExec(BTL_POKEPARAM attacker, WazaParam wazaParam, PokeSet targets)
	{
	}
}
