using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Dpr.RouteSearch;

public class FieldObjectRouteMove
{
	private enum AnimationType
	{
		Invalid,
		Idle,
		Walk
	}

	private readonly FieldObjectEntity Entity;

	private readonly RouteMove RouteMove;

	private AnimationType CurrentAnimType;

	private Action<RouteMoveResult> OnCompletedEvent;

	private Vector3 LastPos;

	private float StopTime;

	private bool IsRotating;

	private float RotateTarget;

	private static readonly float MovingMinimumRate;

	private static readonly float FailedStopTime;

	public ObjectType ObjectType
	{
		[CompilerGenerated]
		get
		{
			return default(ObjectType);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public float MoveSpeed
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public float RotateSpeed
	{
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public bool IsBusy
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public FieldObjectRouteMove(FieldObjectEntity entity)
	{
	}

	public void StartRoute(Vector3 goalPos, [Optional] Action<RouteMoveResult> completedEvent)
	{
	}

	public void Stop()
	{
	}

	public void Update(float deltaTime)
	{
	}

	private void StopCore(RouteMoveResult result)
	{
	}

	private void StartRotate(float targetAngle)
	{
	}

	private void UpdateRotate(float deltaTime)
	{
	}

	private void UpdateAnimation()
	{
	}

	private void UpdatePokemonAnimation(AnimationType animType)
	{
	}

	private void UpdateCharacterAnimation(AnimationType animType)
	{
	}

	private void Complete(RouteMoveResult result)
	{
	}

	private static float CalcYawAngle(float x, float z)
	{
		return default(float);
	}

	private static float MoveAngle(float baseAngle, float targetAngle, float moveAngle, out bool complete)
	{
		return default(float);
	}
}
