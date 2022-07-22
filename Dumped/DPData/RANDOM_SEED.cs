using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, CharSet = CharSet.Unicode, Pack = 4, Size = 132)]
public struct RANDOM_SEED
{
	public string group_name;

	public string name;

	public int sex;

	public int region_code;

	public ulong seed;

	public ulong random;

	public long time_stmp;

	public int user_id;
}
