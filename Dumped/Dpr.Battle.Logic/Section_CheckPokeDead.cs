using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_CheckPokeDead : Section
{
	public class Description
	{
		public BTL_POKEPARAM poke;

		public bool isDeadMessageDisplay;

		public PGLRecord.RecParam pPglParam;
	}

	public class Result
	{
		public bool isDead;
	}

	public Section_CheckPokeDead([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void incWazaKillCount(PGLRecord.RecParam pPglParam)
	{
	}

	private void recordPokeDead(DeadRec pDeadRec, byte deadPokeID)
	{
	}

	private void putDeadMessage(BTL_POKEPARAM deadPoke)
	{
	}

	private bool isKillCountIncrementEnable(byte deadPokeID, byte deadCausePokeID, DamageCause deadCause)
	{
		return default(bool);
	}

	private bool isKillCountEffectEnable(bool isKillCountInc)
	{
		return default(bool);
	}

	private bool needDeadMessage(BTL_POKEPARAM pDeadPoke)
	{
		return default(bool);
	}

	private bool needDeadAct(BTL_POKEPARAM pDeadPoke)
	{
		return default(bool);
	}

	private void removePokeDependEffect(BTL_POKEPARAM poke)
	{
	}

	private void endGMode(BTL_POKEPARAM poke)
	{
	}

	private void incGGaugeByFriendDead(BTL_POKEPARAM deadPoke)
	{
	}

	private void updateNatsuki(BTL_POKEPARAM deadPoke)
	{
	}

	private uint checkExistEnemyMaxLevel()
	{
		return default(uint);
	}

	private void updateRecord(byte deadPokeID)
	{
	}

	private void updateZukanData(BTL_POKEPARAM pDeadPoke)
	{
	}

	private void notifyPokeMemory(byte deadPokeID, byte deadCausePokeID)
	{
	}

	private void setPokeMemories(byte deadPokeID, byte deadCausePokeID)
	{
	}

	private void allDeadOnRaidBattle(BTL_POKEPARAM deadPoke)
	{
	}
}
