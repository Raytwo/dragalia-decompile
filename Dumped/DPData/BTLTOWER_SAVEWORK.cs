using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 440)]
public struct BTLTOWER_SAVEWORK
{
	public uint max_master_rank;

	public int play_mode;

	public int old_playmode;

	public uint btl_point;

	public uint day_challeng_cnt;

	public BTLTOWER_CLASSDATA[] class_data;

	public uint challenge_cnt;
}
