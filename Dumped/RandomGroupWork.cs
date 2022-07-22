using DPData;

public static class RandomGroupWork
{
	public static int RandomRange(int min, int max)
	{
		return default(int);
	}

	public static int RandomValue(int max = 10000)
	{
		return default(int);
	}

	public static float Value()
	{
		return default(float);
	}

	public static float RandomRangeF(float min, float max)
	{
		return default(float);
	}

	public static int GetWorkSize()
	{
		return default(int);
	}

	public static void Copy(RANDOMGROUP from, RANDOMGROUP to)
	{
	}

	public static void Init()
	{
	}

	public static void Update(long days)
	{
	}

	public static ulong GetRandomSeed(RANDOMGROUP no)
	{
		return default(ulong);
	}

	public static void SetRandomSeed(RANDOMGROUP no, ulong seed)
	{
	}

	public static ulong GetRandom(RANDOMGROUP no)
	{
		return default(ulong);
	}

	public static ulong GetDefaultRandom()
	{
		return default(ulong);
	}

	public static void SetRandom(RANDOMGROUP no)
	{
	}

	public static string GetNamePtr(RANDOMGROUP no, RANDOMGROUP_NAME type)
	{
		return null;
	}

	public static void SetName(RANDOMGROUP no, RANDOMGROUP_NAME type, string str)
	{
	}

	public static void SetSex(RANDOMGROUP no, int sex)
	{
	}

	public static int GetSex(RANDOMGROUP no)
	{
		return default(int);
	}

	public static int GetRegionCode(RANDOMGROUP no)
	{
		return default(int);
	}

	public static void SetRegionCode(RANDOMGROUP no, int region_code)
	{
	}

	public static _RANDOM_GROUP SaveData_GetRandomGroup()
	{
		return default(_RANDOM_GROUP);
	}

	public static bool ExistCheck(RANDOMGROUP no)
	{
		return default(bool);
	}

	public static bool EntryCheck(RANDOMGROUP no)
	{
		return default(bool);
	}

	public static bool SameGroupNameCheck(string group_name)
	{
		return default(bool);
	}

	private static bool IsNullData(ref RANDOM_SEED rs)
	{
		return default(bool);
	}

	public static bool Compare(RANDOMGROUP no, ref RANDOM_SEED s1)
	{
		return default(bool);
	}

	private static bool Compare(ref RANDOM_SEED s1, ref RANDOM_SEED s2)
	{
		return default(bool);
	}

	public static bool RandomGroup_IsNullData(RANDOMGROUP no)
	{
		return default(bool);
	}

	public static ulong gf_fix_rand(ulong seed)
	{
		return default(ulong);
	}

	public static void TestRandomDiff(int groupA, int groupB, int loopDay)
	{
	}

	public static void SetTimeStmp(RANDOMGROUP no, long timestmp)
	{
	}

	public static long GetTimeStmp(RANDOMGROUP no)
	{
		return default(long);
	}

	public static void SetUserID(RANDOMGROUP no, int userid)
	{
	}

	public static int GetUserID(RANDOMGROUP no)
	{
		return default(int);
	}

	public static void ChangeGroupData(RANDOMGROUP no, ref RANDOM_SEED seed)
	{
	}

	private static void SetDailyRandom()
	{
	}

	public static int GetDailyRandom()
	{
		return default(int);
	}

	public static bool IsEqualName(string name)
	{
		return default(bool);
	}
}
