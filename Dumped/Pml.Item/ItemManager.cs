using XLSXContent;

namespace Pml.Item;

public class ItemManager
{
	private static ItemManager s_Instance;

	private ItemTable m_alldata;

	public static ItemManager Instance => null;

	public void Load(ItemTable data)
	{
	}

	public int GetParam(ushort itemno, ItemData.PrmID prmID, bool isCheckActive = true)
	{
		return default(int);
	}

	public BallId ItemID2BallID(ushort itemno)
	{
		return default(BallId);
	}

	public ushort BallID2ItemID(BallId ballid)
	{
		return default(ushort);
	}

	public WazaNo GetWazaNo(ushort itemno)
	{
		return default(WazaNo);
	}

	private byte ItemNoToWazaMachineID(ushort itemno)
	{
		return default(byte);
	}

	public WazaNo WazaMachineIDToWazaID(byte machine_no)
	{
		return default(WazaNo);
	}

	public ItemNo WazaMachineIDToItemNo(byte machine_no)
	{
		return default(ItemNo);
	}

	public uint GetWazaMachineItemNum()
	{
		return default(uint);
	}

	private int GetIconId(ushort itemno)
	{
		return default(int);
	}

	public bool IsGroupOf(ushort itemno, byte itemgroup)
	{
		return default(bool);
	}

	public bool GroupIdToItemNo(byte itemgroup, byte groupid, out ushort o_pItemNo)
	{
		return default(bool);
	}

	public ItemTable.SheetItem Get(ushort itemno, bool isCheckActive = true)
	{
		return null;
	}

	public static bool IsStrangeBall(BallId ballid)
	{
		return default(bool);
	}
}
