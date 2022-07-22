using System;
using System.Runtime.CompilerServices;
using Dpr.FureaiHiroba;
using UnityEngine;
using XLSXContent;

namespace Dpr.Field.Walking;

[Serializable]
public class WalkData
{
	public Transform TrackTarget;

	public Vector3 Offset;

	public Vector3 RotOffset;

	public bool isStopUpdate;

	public float targetDistanceOffset;

	public float awayDistanceOffset;

	public float farDistanceOffset;

	public bool isLinePosition;

	public float offsetScale;

	public float moveSpeed;

	public float MaxSpeed;

	public float distance;

	public float bodySize;

	public float bodyDistance;

	public float TrackTargetBodySize;

	public int order;

	public int priority;

	public int yoyakuPriority;

	public float PositionHosei;

	public float walkHosei;

	public float runHosei;

	public float walkSpeed;

	public float runSpeed;

	public float baseSpeed;

	public float nowSpeed;

	public bool isNeedWalk;

	public bool isNeedRun;

	public bool isNeedRotate;

	public FieldObjectEntity entity;

	public float totalMoveDistance;

	public Vector3 prevMoveVec;

	public int CollidedCount;

	public static readonly float[] HeavyPushSpeed;

	public int WeightRank;

	private float prevAngle;

	private float angleRate;

	private float NearCount;

	public Transform transform => null;

	public float targetDistance => default(float);

	public float awayDistance => default(float);

	public float farDistance => default(float);

	public float minDistance => default(float);

	public Vector3 TargetPosition
	{
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public float SpeedHosei => default(float);

	public Vector3 moveVec
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public PokeWalkingActionModel actionModel
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public WalkData(FieldObjectEntity entity)
	{
	}

	public void CreateActionModel(PokeWalkingActionNakayoshi.SheetSheet1 nakayoshi, PokeWalkingActionSeikaku.SheetSheet1 seikaku)
	{
	}

	public void Move(float deltaTime, float Accelarate, float BaseSpeed = 2.5f, float otherDistance = 0f)
	{
	}

	public void NPCMove(float deltaTime, float Accelarate, float BaseSpeed = 1.5f)
	{
	}

	public Vector3 MoveSimple(float deltaTime, float speed)
	{
		return default(Vector3);
	}

	public void MoveSimple2(float deltaTime, float speed)
	{
	}

	public void MoveSimple3(float deltaTime, float speed)
	{
	}

	public void LookAtTarget(Vector3 target, float deltaTime, float speed)
	{
	}

	public float GetAngle(Vector3 target)
	{
		return default(float);
	}

	public Vector3 AngleToVector3(float Angle)
	{
		return default(Vector3);
	}

	public void Update(float deltaTime)
	{
	}

	public void UpdateDistance()
	{
	}

	public void UpdateFormation(float deltaTime)
	{
	}

	public Vector3 GetRotateOffset(float angle, float deltaTime)
	{
		return default(Vector3);
	}

	public bool IsNear()
	{
		return default(bool);
	}

	public bool IsAwayTargetPos()
	{
		return default(bool);
	}

	public bool IsAwayTrackTarget()
	{
		return default(bool);
	}

	public bool IsFar()
	{
		return default(bool);
	}

	public bool IsFarTrackTarget()
	{
		return default(bool);
	}

	public void NeedWalkCheck()
	{
	}

	public void NeedRunCheck(float deltaTime)
	{
	}

	public void SetTargetPos(Vector3 pos)
	{
	}

	public float GetAwayDistance()
	{
		return default(float);
	}

	public float GetFarDistance()
	{
		return default(float);
	}
}
