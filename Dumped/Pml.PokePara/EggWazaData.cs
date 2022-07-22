using XLSXContent;

namespace Pml.PokePara;

public sealed class EggWazaData
{
	public const uint MAX_EGG_WAZA_NUM = 31u;

	private bool m_isLoaded;

	private TamagoWazaTable.SheetData m_buffer;

	public void Load(MonsNo monsno, ushort formno)
	{
	}

	public uint GetEggWazaNum()
	{
		return default(uint);
	}

	public WazaNo GetEggWazaNo(uint eggWazaIndex)
	{
		return default(WazaNo);
	}

	public bool IsContain(WazaNo wazano)
	{
		return default(bool);
	}

	private static uint GetDataID(MonsNo monsno, ushort formno)
	{
		return default(uint);
	}
}
