using System.Runtime.CompilerServices;
using XLSXContent;

namespace Pml.Item;

public class UgItemManager
{
	private UgItemTable m_ugItemTable;

	private TamaTable m_tamaTable;

	private PedestalTable m_pedestalTable;

	private StoneStatuEeffect m_stoneStatuEeffect;

	public static UgItemManager Instance
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public int UgItemTotal => default(int);

	public void Initialize(UgItemTable ugItemTable, TamaTable tamaTable, PedestalTable pedestalTable, StoneStatuEeffect stoneStatuEeffect)
	{
	}

	public bool IsExclusiveUseUG(int ugItemId)
	{
		return default(bool);
	}

	public int GetItemId(int ugItemId)
	{
		return default(int);
	}

	public UgItemTable.Sheettable GetUgItemData(int ugItemId)
	{
		return null;
	}

	public TamaTable.Sheettable GetTamaData(int ugItemId)
	{
		return null;
	}

	public PedestalTable.SheetInfo GetPedestalData(int ugItemId)
	{
		return null;
	}

	public StoneStatuEeffect.Sheettable GetStoneStatuEeffectData(int ugItemId)
	{
		return null;
	}

	public UgItemTable.Sheettable GetUgItemDataFromPedestalId(int pedestalId)
	{
		return null;
	}

	public UgItemTable.Sheettable GetUgItemDataFromTamaId(int tamaId)
	{
		return null;
	}

	public UgItemTable.Sheettable GetUgItemDataStatueId(int statueId)
	{
		return null;
	}

	private UgItemTable.Sheettable GetUgItemDataRaw(int ugItemId)
	{
		return null;
	}

	public int GetNumStatueKInd()
	{
		return default(int);
	}

	public bool IsTama(int ugItemId)
	{
		return default(bool);
	}

	public bool IsPedestal(int ugItemId)
	{
		return default(bool);
	}

	public bool IsStatue(int ugItemId)
	{
		return default(bool);
	}
}
