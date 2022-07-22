using System;
using System.Runtime.InteropServices;
using DPData;
using Dpr;

public class FieldNomoseGymWaterEntity : FieldObjectEntity
{
	private enum MovePhase
	{
		None,
		Move1st,
		Move2nd
	}

	public float[] WaterHeightLevel;

	public int WaterHeightDefaultLevel;

	[NonSerialized]
	public int WaterLevel;

	[NonSerialized]
	public FieldFloatMove HeightMove;

	private MovePhase Phase;

	private float SwayTime;

	public bool IsBusy()
	{
		return default(bool);
	}

	protected override void Awake()
	{
	}

	protected override void OnUpdate(float deltaTime)
	{
	}

	public void Setup()
	{
	}

	public void ApplySaveData([In] ref FIELD_OBJ_SAVE_DATA saveData)
	{
	}

	public void CreateSaveData(ref FIELD_OBJ_SAVE_DATA saveData)
	{
	}

	public void MoveHeight(int level)
	{
	}

	private void SetHeight(float height)
	{
	}
}
