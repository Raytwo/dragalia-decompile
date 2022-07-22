using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 104)]
public struct BTLTOWER_CLASSDATA
{
	public byte clear_flag;

	public bool suspension_flag;

	public ulong btl_play_rand_seed;

	public uint rank;

	public uint rank_down_lose;

	public int tower_round;

	public ulong[] trainer_random;

	public uint total_wins;

	public uint total_wins_loop;

	public uint total_lose;

	public uint old_renshou_cnt;

	public uint renshou_cnt;
}
