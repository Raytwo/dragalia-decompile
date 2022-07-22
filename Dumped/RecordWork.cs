using DPData;

public static class RecordWork
{
	private const int MAX = 999999;

	public static void Create()
	{
	}

	public static void CreateAddData()
	{
	}

	public static void PatchLanguage()
	{
	}

	public static void Add(RECORD_ID index, uint add = 1u)
	{
	}

	public static void Add(int index, uint add = 1u)
	{
	}

	public static void Sub(RECORD_ID index, uint add = 1u)
	{
	}

	public static void Sub(int index, uint add = 1u)
	{
	}

	public static void Set(RECORD_ID index, uint value)
	{
	}

	public static void Set(int index, uint value)
	{
	}

	public static uint Get(RECORD_ID index)
	{
		return default(uint);
	}

	public static uint Get(int index)
	{
		return default(uint);
	}

	public static uint MaxValue(RECORD_ID index, out int recordindex)
	{
		return default(uint);
	}

	public static uint MaxValue(int index, out int recordindex)
	{
		return default(uint);
	}

	public static int CheckHeadData(ref RECORD_HEAD recodeHeadData)
	{
		return default(int);
	}

	public static int CheckHeadAndGroupData(ref RECORD_HEAD recodeHeadData, ref RANDOM_SEED seed)
	{
		return default(int);
	}

	public static int GetNullGroup()
	{
		return default(int);
	}

	private static void SetHeadRecord(int index, ref RECORD_HEAD recodeHeadData)
	{
	}

	private static int GetOldRecordIndex()
	{
		return default(int);
	}

	public static int SetOtherRecord(RANDOM_SEED seed, ref RECORD record, ref RECORD_HEAD recodeHeadData)
	{
		return default(int);
	}

	public static void AddDataMineNull()
	{
	}

	public static string GetUserName(RANDOMGROUP index)
	{
		return null;
	}

	public static uint GetUniqueID(RANDOMGROUP index)
	{
		return default(uint);
	}

	public static int GetLanguage(RANDOMGROUP index)
	{
		return default(int);
	}

	public static byte GetSex(RANDOMGROUP index)
	{
		return default(byte);
	}

	public static int GetBodyType(RANDOMGROUP index)
	{
		return default(int);
	}

	public static byte GetRankingActive(RANDOMGROUP index, int uiIndex)
	{
		return default(byte);
	}

	public static void SetRankingDisable(RANDOMGROUP index, int uiIndex)
	{
	}

	private static void LimitCheck(ref uint data, uint limit)
	{
	}

	public static void IllegalDataCheck()
	{
	}
}
