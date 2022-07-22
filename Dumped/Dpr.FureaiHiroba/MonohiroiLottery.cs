namespace Dpr.FureaiHiroba;

public class MonohiroiLottery
{
	public enum ItemType
	{
		Item,
		Seal
	}

	public ItemType itemType;

	public bool isSeal;

	private int kinomiNo;

	private int sonotaNo;

	private float kinomiRate;

	private static readonly int[] Sonota_Kakuritu;

	public MonohiroiLottery(FureaiDataManager dataManager, int pokeID)
	{
	}

	public int GetItem()
	{
		return default(int);
	}

	private int GetKinomi()
	{
		return default(int);
	}

	private int GetSonota()
	{
		return default(int);
	}

	private bool CanGetSonota()
	{
		return default(bool);
	}

	private bool GetItemIsKinomi()
	{
		return default(bool);
	}
}
