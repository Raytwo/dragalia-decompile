using System.Runtime.InteropServices;
using Pml;
using Pml.PokePara;

namespace Dpr.Battle.Logic;

public static class BattleResult
{
	public static void ApplyBattlePartyStateOnly(BATTLE_SETUP_PARAM setupParam, BattleEnv pBattleEnvForServer, BattleEnv pBattleEnvForClient, MainModule mainModule, byte myClientId)
	{
	}

	public static void ApplyBattlePartyData(BATTLE_SETUP_PARAM setupParam, BattleEnv pBattleEnvForServer, BattleEnv pBattleEnvForClient, MainModule mainModule, byte myClientId)
	{
	}

	private static bool isBossBattle(MainModule pMainModule, BATTLE_SETUP_PARAM pSetupParam)
	{
		return default(bool);
	}

	private static void addFriendshipByBossBattle(PokeParty pParty)
	{
	}

	private static bool needRevertItem(MainModule mainModule, BATTLE_SETUP_PARAM pSetupParam)
	{
		return default(bool);
	}

	private static void revertItem(PokeParty pSrcParty, PokeParty pOrgParty)
	{
	}

	private static void adjustMaxHP(PokeParty pSrcParty, PokeParty pOrgParty)
	{
	}

	private static void resetForm(PokeParty party, PokeParty orgParty)
	{
	}

	private static void resetForm(PokemonParam pokeParam, [In] ref PokemonParam orgParam)
	{
	}

	private static void clearUnknownUBNickName(MainModule mainModule, PokeParty party)
	{
	}

	public static void ApplyRecordHeader(BATTLE_SETUP_PARAM setupParam, MainModule mainModule, byte myClientId, BtlResult result)
	{
	}

	private unsafe static uint GetRecTurnCount(byte* recordData, uint recordDataSize)
	{
		return default(uint);
	}

	private static BtlRecordResult1 GetRecResult1(BtlResult result)
	{
		return default(BtlRecordResult1);
	}

	private static BtlRecordResult2 GetRecResult2(MainModule mainModule, BtlResult result)
	{
		return default(BtlRecordResult2);
	}
}
