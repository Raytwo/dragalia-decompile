using Ug;
using UnityEngine;

namespace Dpr.Field.Walking;

public class UGBaseState : AIStateBase
{
	protected const int DOOR_DONT_MOVE_RANGE = 5;

	protected const int MOVE_AREA_RANGE = 8;

	protected Vector3 NextMovePoint;

	protected float rotSpeed;

	protected float waitTime;

	protected float changeTargetTime;

	protected int colideStopCount;

	public float searchWait;

	protected new AIUgModel model => null;

	public UGBaseState(AIModel model)
	{
	}

	protected override void StateUpdate()
	{
	}

	protected void Move(float speed, float otherDist = 0f)
	{
	}

	public bool LookPlayerIfNear(WalkData walkModel)
	{
		return default(bool);
	}

	protected bool CheckArrive()
	{
		return default(bool);
	}

	protected void LookAtTarget(Vector3 pos, float rotSpeed)
	{
	}

	protected bool isDontEnterArea(Vector3 NextPos, float addRange = 0f)
	{
		return default(bool);
	}

	protected Vector3 GetRandomPoint(Ug.MoveType moveType)
	{
		return default(Vector3);
	}

	protected bool InSearchArea(Vector3 pos)
	{
		return default(bool);
	}
}
