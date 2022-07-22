using System.Runtime.CompilerServices;
using Dpr;

public class FieldElevatorBackgroundEntity : FieldObjectEntity
{
	public float[] BackgroundFloorHeight;

	private FieldObjectMove Move;

	public int CurrentFloorIndex
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public bool IsBusy => default(bool);

	protected override void Awake()
	{
	}

	public void Setup()
	{
	}

	public void SetCurrentFloorHeight()
	{
	}

	public void MoveNextFloorHeight(int nextFloor)
	{
	}

	protected override void ProcessSequence(float deltaTime)
	{
	}

	private void UpdateHeight(float deltaTime)
	{
	}

	private int GetFloorIndex()
	{
		return default(int);
	}

	private float ToWorldValue(float localValue)
	{
		return default(float);
	}
}
