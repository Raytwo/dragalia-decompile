using System;
using System.Runtime.InteropServices;

[Serializable]
[StructLayout(0, Pack = 4, Size = 248)]
public struct PLAYREPORT_DATA
{
	public long capture_symbol;

	public long capture_wild;

	public long capture_fishing;

	public long dress_up;

	public long training;

	public long personal_change;

	public long npc_trade;

	public long chain_encount;

	public long fossil_restore;

	public long wild_pokemon_encount;

	public long trade;

	public long magical_trade;

	public long total_walk;

	public long total_all_battle;

	public long battle_point;

	public long use_skill_record;

	public long evolution;

	public long net_battle;

	public long cooking;

	public long get_kinomi;

	public long btl_lose_cnt;

	public long total_money;

	public long btower_win_single;

	public long btower_win_double;

	public long btower_win_single_master;

	public long btower_win_double_master;

	public long go_to_underground;

	public long fossildigging;

	public long balldeko_open;

	public long statue_set;

	public long poketch_open;
}
