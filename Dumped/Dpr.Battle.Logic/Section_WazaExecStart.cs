using System.Runtime.InteropServices;
using Pml;
using Pml.WazaData;

namespace Dpr.Battle.Logic;

public sealed class Section_WazaExecStart : Section
{
	public enum ResultCode
	{
		FAILED,
		SUCCESSED,
		DELAY_WAZA_SET,
		COMBI_WAZA_READY,
		ROBBED
	}

	public class Description
	{
		public PokeAction pPokemonAction;
	}

	public class Result
	{
		public ResultCode resultCode;

		public bool isWazaEffective;

		public bool isPPUsed;

		public WazaParam wazaParam;

		public BtlPokePos targetPos;

		public PokeSet targets;

		public WazaRobParam robParam;
	}

	public Section_WazaExecStart([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void event_StartWazaSeq(BTL_POKEPARAM attacker, WazaNo waza)
	{
	}

	private bool checkWazaFail_1st(BTL_POKEPARAM attacker, WazaParam wazaParam, ActionDesc actionDesc, bool isWazaLock, bool isTameLock)
	{
		return default(bool);
	}

	private void registerWazaTargets(BTL_POKEPARAM pAttacker, WazaParam pWazaParam, BtlPokePos targetPos, byte aimTargetID, PokeSet pTargets)
	{
	}

	private bool decrementPP(BTL_POKEPARAM attacker, WazaNo orgWaza, WazaNo actWaza, PokeSet targets)
	{
		return default(bool);
	}

	private void onFailed(BTL_POKEPARAM attacker, WazaNo waza, WazaFailCause failCause)
	{
	}

	private BtlPokePos correctReqWazaTargetPos(WazaNo orgWaza, BtlPokePos defaultTargetPos)
	{
		return default(BtlPokePos);
	}

	private WazaFailCause checkReqWazaFail(BTL_POKEPARAM attacker, WazaParam wazaParam)
	{
		return default(WazaFailCause);
	}

	private void event_WazaCallDecide(BTL_POKEPARAM attacker, WazaParam wazaParamOrg, WazaParam wazaParamAct)
	{
	}

	private void putWazaMessage(BTL_POKEPARAM pAttacker, WazaNo orgWazaID, WazaNo actWazaID, BtlPokePos actTargetPos)
	{
	}

	private bool checkWazaMsgCustom(BTL_POKEPARAM pAttacker, WazaNo orgWazaID, WazaNo actWazaID, StrParam pStrParam)
	{
		return default(bool);
	}

	private bool checkWazaFail_2nd(BTL_POKEPARAM attacker, WazaParam wazaParam, PokeSet targets)
	{
		return default(bool);
	}

	private bool checkWazaFail_Funjin(BTL_POKEPARAM attacker, WazaParam wazaParam)
	{
		return default(bool);
	}

	private bool checkWazaFail_3rd(BTL_POKEPARAM attacker, WazaParam wazaParam, PokeSet targets)
	{
		return default(bool);
	}

	private void cureSick(BTL_POKEPARAM poke, WazaSick sick)
	{
	}

	private bool setDelayWazaReady(ref bool pIsWazaEnable, BTL_POKEPARAM attacker, WazaParam wazaParam, BtlPokePos targetPos)
	{
		return default(bool);
	}

	private bool setCombiWazaReady(BTL_POKEPARAM attacker, WazaNo waza, BtlPokePos targetPos)
	{
		return default(bool);
	}

	private void event_WazaExecDecide(BTL_POKEPARAM attacker, WazaParam wazaParam)
	{
	}

	private bool checkWazaRob(BTL_POKEPARAM attacker, WazaNo waza, PokeSet targets, WazaRobParam robParam)
	{
		return default(bool);
	}

	public void checkBattleTalk(byte pokeID, WazaNo waza)
	{
	}
}
