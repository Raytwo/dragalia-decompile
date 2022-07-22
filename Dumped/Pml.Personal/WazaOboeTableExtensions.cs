using XLSXContent;

namespace Pml.Personal;

public static class WazaOboeTableExtensions
{
	private const ushort WAZAOBOE_END_CODE = ushort.MaxValue;

	private const int UNITLEN_AR = 2;

	public static ushort GetLevel(this WazaOboeTable.SheetWazaOboe self, int index)
	{
		return default(ushort);
	}

	public static ushort GetWazaNo(this WazaOboeTable.SheetWazaOboe self, int index)
	{
		return default(ushort);
	}

	public static int GetValidCodeNum(this WazaOboeTable.SheetWazaOboe self)
	{
		return default(int);
	}

	public static OboeWazaKind GetOboeWazaKind(this WazaOboeTable.SheetWazaOboe self, ushort data_index)
	{
		return default(OboeWazaKind);
	}
}
