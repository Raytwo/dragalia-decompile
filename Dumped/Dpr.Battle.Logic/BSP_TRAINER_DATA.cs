using Dpr.Trainer;
using Pml;
using XLSXContent;

namespace Dpr.Battle.Logic;

public class BSP_TRAINER_DATA
{
	private class CORE_DATA
	{
		public TrainerID tr_id;

		public TrainerType tr_type;

		public TrainerTable.SheetTrainerType tr_type_data;

		public TrainerTable.SheetTrainerData trainer_data;

		public TowerTrainerTable.SheetTrainerData inst_trainer_data;

		public BattleSetupEffectId btl_eff_id;

		public TrainerTypeGroup tr_group;

		public Sex tr_sex;

		public string model_id;

		public int color_id;

		public uint ai_bit;

		public byte gold;

		public ushort[] use_item;

		public string trtype_name_label;

		public string name_label;
	}

	public const int USE_ITEM_MAX = 4;

	private CORE_DATA mCore;

	public TrainerID GetTrainerID()
	{
		return default(TrainerID);
	}

	public uint GetAIBit()
	{
		return default(uint);
	}

	public BattleSetupEffectId GetBattleEffectID()
	{
		return default(BattleSetupEffectId);
	}

	public TrainerType GetTrainerType()
	{
		return default(TrainerType);
	}

	public TrainerTypeGroup GetTrainerGroup()
	{
		return default(TrainerTypeGroup);
	}

	public Sex GetTrainerSex()
	{
		return default(Sex);
	}

	public byte GetGoldParam()
	{
		return default(byte);
	}

	public string GetModelID()
	{
		return null;
	}

	public int GetColorID()
	{
		return default(int);
	}

	public ushort GetUseItem(int index)
	{
		return default(ushort);
	}

	public string GetNameLabel()
	{
		return null;
	}

	public string GetTrTypeNameLabel()
	{
		return null;
	}

	public void SetTrainerID(TrainerID id)
	{
	}

	public void SetAIBit(uint bit)
	{
	}

	public void SetGoldParam(byte gold)
	{
	}

	public void SetModelID(string modelID)
	{
	}

	public void SetColorID(int color_id)
	{
	}

	public void Dispose()
	{
	}

	public void LoadTrTypeData(TrainerType trainerType)
	{
	}

	public void SetupTrainerData(TrainerTable.SheetTrainerData trainerData)
	{
	}

	public void SetupTrainerData(TowerTrainerTable.SheetTrainerData trainerData)
	{
	}

	public void ReloadTrTypeData()
	{
	}

	public TrainerTable.SheetTrainerType GetTrTypeData()
	{
		return null;
	}

	public TrainerTable.SheetTrainerData GetTrainerData()
	{
		return null;
	}

	public TowerTrainerTable.SheetTrainerData GetInstTrainerData()
	{
		return null;
	}

	public void SetUseItem(ushort[] items)
	{
	}

	public void SetNameLabel(string name_label)
	{
	}

	public void SetTrTypeNameLabel(string trtype_name_label)
	{
	}
}
