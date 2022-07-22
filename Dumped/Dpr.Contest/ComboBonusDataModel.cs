using Pml;
using XLSXContent;

namespace Dpr.Contest;

public sealed class ComboBonusDataModel : ComboBonusData
{
	public PokeType PrevWazaType => default(PokeType);

	public ComboBonusDataModel(ContestConfigDatas.SheetComboBonusData[] bonusDataArray)
	{
	}

	public void Reset()
	{
	}

	public bool CanGetChainBonus(int count)
	{
		return default(bool);
	}

	public void SetWazaType(PokeType wazaType)
	{
	}

	public void ResetWazaType()
	{
	}

	public int CalcComboBonus(int chainCount, PokeType wazaType)
	{
		return default(int);
	}
}
