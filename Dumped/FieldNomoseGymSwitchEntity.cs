using System;
using Dpr;

public class FieldNomoseGymSwitchEntity : FieldEventEntity
{
	public int WaterLevel;

	public string WaterEventLabel;

	[NonSerialized]
	public FieldFloatMove HeightMove;

	private float DefaultHeightValue;

	private float PushedHeightValue;

	protected override void Awake()
	{
	}

	protected override void OnUpdate(float deltaTime)
	{
	}

	public bool IsPushed()
	{
		return default(bool);
	}

	public void Setup()
	{
	}

	public void ChangeState(int level)
	{
	}

	private float GetHeightValue(bool pushed)
	{
		return default(float);
	}

	private void SetHeight(float height)
	{
	}
}
