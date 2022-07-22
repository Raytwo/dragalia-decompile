using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 128)]
public struct PLAYER_SAVE_DATA
{
	public bool gear_type;

	public bool shoes_flag;

	public uint form;

	public byte bic_color;

	public WorpPoint worpPoint;

	public float walkcount;

	public int natuki_walkcnt;

	public LOCATION_WORK TownMapLocation;

	public bool isTokushuLocation;

	public LOCATION_WORK TokushuLocation;

	public PLAYER_SAVE_DATA(int a)
	{
	}
}
