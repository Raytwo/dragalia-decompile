using Dpr.Trainer;
using Pml;
using XLSXContent;

public class TowerLotResult
{
	public int matchingID;

	public uint stockID;

	public TowerTrID[] trainerID;

	public ulong[] personalRand;

	public TowerTrID GetTrainerID(int index)
	{
		return default(TowerTrID);
	}

	public TrainerType GetTrainerType(int index)
	{
		return default(TrainerType);
	}

	public TowerTrainerTable.SheetTrainerData GetTrainerData(int index)
	{
		return null;
	}

	public PokeParty CreatePokeParty(int trainerIndex)
	{
		return null;
	}

	public SealTemplateID[] GetSealTemplates(int trainerIndex)
	{
		return null;
	}

	public bool IsSingle()
	{
		return default(bool);
	}

	public void GetBGM(out string battleBGM, out string winBGM)
	{
	}
}
