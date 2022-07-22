using Pml.PokePara;

public static class AzukariyaWork
{
	public const int POKE_MAX = 2;

	private const int LoveLv_Good = 70;

	private const int LoveLv_Normal = 50;

	private const int LoveLv_Bad = 20;

	private const int LoveLv_Worst = 0;

	private const int LoveLv_Good_Ex = 88;

	private const int LoveLv_Normal_Ex = 80;

	private const int LoveLv_Bad_Ex = 40;

	private static readonly int[,] EggPercentRate;

	private const int EggCheckInterval = 180;

	public static void StoreFromTemoti(int temotiIndex)
	{
	}

	public static void RestoreToTemoti(int index)
	{
	}

	public static void StoreFromBox(int tray, int pos)
	{
	}

	public static void RestoreToBox(int index, int tray, int pos)
	{
	}

	public static void RestoreToBox(int index)
	{
	}

	private static void RestoreCommon(int index)
	{
	}

	public static bool IsExistEgg()
	{
		return default(bool);
	}

	public static void GetEggToTemoti()
	{
	}

	public static void GetEggToTemotiReplace(int temotiIndex)
	{
	}

	public static void GetEggToBox()
	{
	}

	public static void AddEggStep(int step)
	{
	}

	public static void CheckLayEgg()
	{
	}

	public static int CalcLoveLevel()
	{
		return default(int);
	}

	public static void SetExistEgg()
	{
	}

	public static void DiscardEgg()
	{
	}

	public static PokemonParam GenerateAndGetEgg()
	{
		return null;
	}

	public static void Clear()
	{
	}

	public static void Set(int index, PokemonParam pp)
	{
	}

	public static PokemonParam Get(int index)
	{
		return null;
	}

	public static void SetEmpty(int index)
	{
	}

	public static int GetUnusedIndex()
	{
		return default(int);
	}

	public static int GetStoredCount()
	{
		return default(int);
	}

	public static bool IsUsed(int index)
	{
		return default(bool);
	}

	public static void Move(int sourceIndex, int targetIndex)
	{
	}

	public static void InitOldmanEvent()
	{
	}

	public static void MoveOldmanEvent()
	{
	}

	public static bool IsExistOldmanZone()
	{
		return default(bool);
	}

	public static bool IsLoadedOldman()
	{
		return default(bool);
	}

	public static FieldObjectEntity GetOldman()
	{
		return null;
	}
}
