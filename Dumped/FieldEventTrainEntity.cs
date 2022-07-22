using System;
using Dpr;

public class FieldEventTrainEntity : FieldEventEntity
{
	public enum Define
	{
		TRAIN_POS_1,
		TRAIN_POS_2,
		TRAIN_POS_3,
		MOVE_TYPE_CALL,
		MOVE_TYPE_RIDE,
		TRAIN_SAME_POS,
		TRAIN_DIF_POS
	}

	private enum MovePhase
	{
		Idle,
		Start,
		Acc,
		Move,
		Dec,
		Stop
	}

	private enum AnimationIndex
	{
		Idle,
		Start,
		Move_Low,
		Move_High,
		Stop
	}

	public float[] TrainPosListZ;

	[NonSerialized]
	public int CurrentPosIndex;

	private int NextPosIndex;

	private MovePhase Phase;

	private FieldFloatMove MoveRate;

	private FieldFloatMove WaitArrival;

	private bool IsMoveEnd;

	private bool IsRidePlayer;

	public bool IsBusy => default(bool);

	public void Move(int posIndex, bool isRidePlayer)
	{
	}

	private void Play(AnimationIndex animationIndex)
	{
	}

	private float CalcAccDist(float accTime, float maxSpeed)
	{
		return default(float);
	}

	private float ToWorldValue(float localValue)
	{
		return default(float);
	}

	protected override void Awake()
	{
	}

	protected override void OnUpdate(float deltaTime)
	{
	}
}
