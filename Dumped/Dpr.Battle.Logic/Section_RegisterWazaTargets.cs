using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_RegisterWazaTargets : Section
{
	public class Description
	{
		public BTL_POKEPARAM pAttacker;

		public WazaParam pWazaParam;

		public BtlPokePos targetPos;

		public byte aimTargetID;

		public PokeSet pPokeSet;
	}

	public class Result
	{
	}

	public Section_RegisterWazaTargets([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private bool canAimTarget(BTL_POKEPARAM attacker, WazaParam wazaParam, byte aimTargetID)
	{
		return default(bool);
	}

	private bool checkTemptEnable(BTL_POKEPARAM attacker, bool enable)
	{
		return default(bool);
	}

	private BTL_POKEPARAM checkTemptPokemon(BTL_POKEPARAM target, BTL_POKEPARAM attacker, WazaParam wazaParam, ref bool isInterrupted)
	{
		return null;
	}

	private byte checkTemptPokeID(BTL_POKEPARAM attacker, WazaParam wazaParam, byte targetPokeID, ref bool isInterrupted)
	{
		return default(byte);
	}

	private void increaseTarget(BTL_POKEPARAM attacker, PokeSet targets)
	{
	}

	private bool correctTargetDead(BtlRule rule, BTL_POKEPARAM attacker, WazaParam wazaParam, BtlPokePos targetPos, PokeSet rec)
	{
		return default(bool);
	}

	private BTL_POKEPARAM correctTargetDeadSub_decideTarget(BTL_POKEPARAM attacker, BtlPokePos defaultTargetPos, byte targetListCount, BTL_POKEPARAM[] targets)
	{
		return null;
	}

	private byte correctTargetDeadSub_storeNextTargets(BTL_POKEPARAM[] dstNextTarget, BTL_POKEPARAM attacker, WazaParam wazaParam)
	{
		return default(byte);
	}

	private void selectWazaTargets(MainModule mainModule, BattleEnv battleEnv, BTL_POKEPARAM attacker, BtlPokePos targetPos, WazaParam wazaParam, byte intrPokeID, PokeSet rec, ref bool isTargetTemptEnable)
	{
	}

	private void selectWazaTargets_Single(MainModule mainModule, BattleEnv battleEnv, BTL_POKEPARAM attacker, BtlPokePos targetPos, WazaParam wazaParam, byte intrPokeID, PokeSet rec)
	{
	}

	private void selectWazaTargets_Double(MainModule mainModule, BattleEnv battleEnv, BTL_POKEPARAM attacker, BtlPokePos targetPos, WazaParam wazaParam, byte intrPokeID, PokeSet rec, ref bool isTargetTemptEnable)
	{
	}

	private void selectWazaTargets_Raid(MainModule mainModule, BattleEnv battleEnv, BTL_POKEPARAM attacker, BtlPokePos targetPos, WazaParam wazaParam, byte intrPokeID, PokeSet rec, ref bool isTargetTemptEnable)
	{
	}

	private BTL_POKEPARAM getOpponentPokemon(MainModule mainModule, POKECON pokecon, BtlPokePos myPoso, byte opponentPokeIndex)
	{
		return null;
	}

	private BTL_POKEPARAM getNextPokemon(MainModule mainModule, POKECON pokecon, BtlPokePos myPoso)
	{
		return null;
	}

	private BtlPokePos correctNoroiTarget(MainModule mainModule, POKECON pokecon, WazaParam wazaParam, BTL_POKEPARAM attacker, BtlPokePos targetPos)
	{
		return default(BtlPokePos);
	}

	private void removeNotExistTargets(PokeSet targets)
	{
	}
}
