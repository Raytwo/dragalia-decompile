using Pml;
using Ug;
using XLSXContent;

public class UgEncountProc
{
	public enum ResultCode
	{
		Success,
		Fail
	}

	public struct LotReuest
	{
		public int RandMarkID;
	}

	public struct LotResult
	{
		public ResultCode ResultCode;

		public int[] UgEncountIndex;
	}

	public static LotResult EncountLot(LotReuest lot)
	{
		return default(LotResult);
	}

	private static PokeType LotType(UgRandMark.Sheettable tbl)
	{
		return default(PokeType);
	}

	private static MonsSize[] LotSize(UgRandMark.Sheettable tbl, int lotcount)
	{
		return null;
	}

	private static int LotMonster(UgRandMark.Sheettable tbl, MonsSize size, PokeType type)
	{
		return default(int);
	}
}
