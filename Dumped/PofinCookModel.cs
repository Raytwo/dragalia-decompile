using System.Collections.Generic;
using DPData;
using Dpr.Item;
using XLSXContent;

public class PofinCookModel
{
	private enum Aji
	{
		Spicy,
		Dry,
		Sweet,
		Bitter,
		Sour
	}

	public const int POFIN_ID_KOTTERI = 25;

	public const int POFIN_ID_KUDOI = 26;

	public const int POFIN_ID_MAZUI = 27;

	public const int POFIN_ID_MAROYAKA = 28;

	public const int POFIN_ID_CHYOUMAROYAKA = 29;

	public static readonly string MESSAGE_NAME;

	public static readonly string LABEL_NAME;

	private ItemInfo[] kinomiInfo;

	public List<KinomiData.SheetData> kinomiData;

	private byte[] AjiParam;

	private byte Taste;

	public float CookedTime;

	public int SearCount;

	public int SpillCount;

	public int TeamHosei;

	private int MinusCount;

	private int PlusCount;

	private int SameKinomiCount;

	public PofinCookModel(float time, int sear, int spill, int teamHosei, ItemInfo[] kinomi)
	{
	}

	private void Init()
	{
	}

	private void CalcParam()
	{
	}

	private List<KeyValuePair<int, int>> GetPlusParam()
	{
		return null;
	}

	public KeyValuePair<PoffinData, int> GetPofinData()
	{
		return default(KeyValuePair<PoffinData, int>);
	}

	private bool[] GetRandomFlavor3()
	{
		return null;
	}
}
