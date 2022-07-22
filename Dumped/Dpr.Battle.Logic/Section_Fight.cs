using System.Runtime.InteropServices;
using Pml;

namespace Dpr.Battle.Logic;

public sealed class Section_Fight : Section
{
	public class Description
	{
		public PokeAction pokeAction;
	}

	public class Result
	{
	}

	public Section_Fight([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void beforeFirstFight()
	{
	}

	private void wazaExecStart(out Section_WazaExecStart.ResultCode pResultCode, out bool pIsWazaEffective, out bool pIsPPUsed, WazaParam pActWaza, out BtlPokePos pTargetPos, PokeSet pTargets, WazaRobParam pRobParam, PokeAction pokeAction)
	{
	}

	private bool wazaExec(BTL_POKEPARAM attacker, WazaParam wazaParam, ActionDesc actionDesc, PokeSet targets)
	{
		return default(bool);
	}

	private void wazaRob(WazaRobParam robParam, BTL_POKEPARAM attacker, WazaNo waza)
	{
	}

	private void putWazaMessage(BTL_POKEPARAM pAttacker, WazaParam pWazaParam, BtlPokePos targetPos)
	{
	}

	private bool needWazaMessageDisplay([In] ref WazaNo wazaID)
	{
		return default(bool);
	}

	private void wazaExecEnd(ActionDesc actionDesc, BTL_POKEPARAM attacker, WazaNo orgWaza, WazaParam wazaParam, BtlPokePos targetPos, bool isWazaHide, bool isWazaLock, bool isPPUsed, bool isWazaEffective)
	{
	}

	private void magicCoat(WazaNo waza)
	{
	}

	private void setPokeMemories(BTL_POKEPARAM pAttacker, PokeSet pTargets, WazaNo wazano, bool isSuccessWazaExecStart, bool isWazaEffective)
	{
	}
}
