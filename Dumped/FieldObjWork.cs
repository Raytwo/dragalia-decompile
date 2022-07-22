using System.Collections.Generic;
using DPData;

public class FieldObjWork
{
	private bool isBuild;

	private Dictionary<int, int> _find_index;

	private static FieldObjWork _instance;

	private static FieldObjWork Inst => null;

	private void BuildData()
	{
	}

	public static FIELD_OBJ_SAVE_DATA Get(int hash, out bool flag)
	{
		return default(FIELD_OBJ_SAVE_DATA);
	}

	public static void Set(FIELD_OBJ_SAVE_DATA data)
	{
	}

	public static void Clear()
	{
	}
}
