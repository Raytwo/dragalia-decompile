using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_TurnEnd : Section
{
	public class Description
	{
	}

	public class Result
	{
	}

	public Section_TurnEnd([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void removeRaidBossReinforceHandler()
	{
	}

	private void updateRaidBossReinforceTurn()
	{
	}

	private void updateRaidBossGWazaUseSchedule()
	{
	}

	private void updateRaidBossGWall()
	{
	}

	private void updateGGauge()
	{
	}

	private void updateGMode()
	{
	}

	private void updateGMode(BTL_POKEPARAM poke)
	{
	}

	private bool needEndG(BTL_POKEPARAM pPoke)
	{
		return default(bool);
	}

	private void reliveAllDeadPartyOnRaidBattle()
	{
	}

	private void reliveAllDeadPartyOnRaidBattle(BTL_CLIENT_ID clientID)
	{
	}

	private void updateGRights()
	{
	}

	private void updateGRights(BtlSide side)
	{
	}

	private bool checkTransferGRights(BtlSide side)
	{
		return default(bool);
	}

	private void transferGRights(BtlSide side)
	{
	}

	private void clearPokeTurnFlag()
	{
	}

	private void storeFrontPokeByAgilityOrder(PokeSet pPokeSet)
	{
	}

	private void incPokeTurnCount()
	{
	}

	private bool checkForceQuitByTurnOver()
	{
		return default(bool);
	}

	private void checkBattleTalk()
	{
	}

	private bool checkRaidBattleForceQuit()
	{
		return default(bool);
	}
}
