using System;
using System.Runtime.InteropServices;

namespace DPData;

[Serializable]
[StructLayout(0, Pack = 4, Size = 416)]
public struct POKETCH_DATA
{
	public bool get_flag;

	public bool pedometer_flag;

	public bool dotart_modified_flag;

	public POKETCH_COLOR color_type;

	public sbyte app_count;

	public sbyte app_index;

	public bool[] app_flag;

	public uint pedometer;

	public byte[] dotart_data;

	public uint[] calendar_markbit;

	public MARK_MAP_POS[] mark_map_pos;

	public POKETCH_POKE_HISTORY[] poke_history;

	private static POKETCH_POKETORE_COUNT tempPoketore_count;

	private static int tempPoketoreSaveDataIndex;

	public POKETCH_DATA(int a)
	{
	}

	public void PokeHistoryAdd(ushort monsno, ushort pattern)
	{
	}

	public int PokeHistoryGetRecordCount()
	{
		return default(int);
	}

	public (int, int) PokeHistoryGetRecord(int index)
	{
		return default((int, int));
	}

	public void ResetTempPoketore()
	{
	}

	public void PoketoreSetCount(ushort monsNo, int count)
	{
	}
}
