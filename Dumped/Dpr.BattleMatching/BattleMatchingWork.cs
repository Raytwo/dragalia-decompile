using Dpr.Battle.Logic;
using Dpr.NetworkUtils;
using INL1;
using Pml.PokePara;
using UnityEngine;

namespace Dpr.BattleMatching;

public static class BattleMatchingWork
{
	public static int stationIndex;

	public static int opponentStationIndex;

	public static int hostStationIndex;

	public static IlcaNetSessionNetworkType networkType;

	public static BattleModeID battleModeID;

	public static bool isColiseum;

	public static int coliseumTeam;

	public static BtlResult battleResult;

	public static BattleMatchingPlayerData[] playerDataList;

	public static PokemonNum pokemonNum;

	public static Regulation.LevelRangeType pokemonLevel;

	public static bool isBanLegendPokemon;

	public static bool isBanSamePokemon;

	public static bool isBanSameItem;

	public static bool isBanIllegal;

	public static PokemonParam[] pokemonParams;

	public static int[] orderIndexList;

	public static int battleTeamIndex;

	public static void Init()
	{
	}

	public static void SetBattleMatchingRule(BattleModeID battleModeID, bool coliseum)
	{
	}

	public static void SetBattleTowerRule(bool single)
	{
	}

	public static int GetPlayerNum()
	{
		return default(int);
	}

	public static int GetPokemonNumMin(PokemonNum type)
	{
		return default(int);
	}

	public static int GetPokemonNumMax(PokemonNum type)
	{
		return default(int);
	}

	public static int GetIndexMine()
	{
		return default(int);
	}

	public static int GetIndex(int stationIndex)
	{
		return default(int);
	}

	public static int[] GetOtherStationIndex()
	{
		return null;
	}

	public static void SetReadyPlayer(int stationIndex)
	{
	}

	public static void ResetReadyPlayer()
	{
	}

	public static bool GetReadyAllPlayers()
	{
		return default(bool);
	}

	public static void SetResumePlayer(int stationIndex, bool resume)
	{
	}

	public static void ResetResumePlayer()
	{
	}

	public static bool GetSelectResumeAllPlayer()
	{
		return default(bool);
	}

	public static bool GetResumeAllPlayers()
	{
		return default(bool);
	}

	public static bool GetNotResumePlayer()
	{
		return default(bool);
	}

	public static int[] GetReadyBattleTeams()
	{
		return null;
	}

	public static bool GetReadyAllBattleTeams()
	{
		return default(bool);
	}

	public static int[] GetReadyBattlePokemons()
	{
		return null;
	}

	public static bool GetReadyAllBattlePokemons()
	{
		return default(bool);
	}

	public static void ResetPokemon()
	{
	}

	public static void EmitLog(string log, LogType logType = LogType.Log)
	{
	}
}
