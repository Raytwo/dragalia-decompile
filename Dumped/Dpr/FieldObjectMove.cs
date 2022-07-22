using System;
using UnityEngine;

namespace Dpr;

public class FieldObjectMove
{
	public bool IgnoreY;

	public float JumpHeight;

	private WeakReference<FieldObjectEntity> _Entity;

	public FieldFloatMove FloatMove;

	private Vector3 BaseWldPos;

	private Vector3 TargetWldPos;

	public bool IsBusy => default(bool);

	private FieldObjectEntity Entity
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public void SetObjectEntity(FieldObjectEntity entity)
	{
	}

	public void Reset()
	{
	}

	public void Update(float deltaTime)
	{
	}

	public void Stop()
	{
	}

	public void SetWorldPos(Vector3 wldPos)
	{
	}

	public void MoveTime(Vector3 targetWldPos, float moveTime)
	{
	}

	public void MoveSpeed(Vector3 targetWldPos, float moveSpeed)
	{
	}
}
