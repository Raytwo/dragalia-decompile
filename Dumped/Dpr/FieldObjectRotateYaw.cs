using System;

namespace Dpr;

public class FieldObjectRotateYaw
{
	private WeakReference<FieldObjectEntity> _Entity;

	public FieldFloatMove FloatMove;

	private float BaseYawAngle;

	private float TargetYawAngle;

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

	public void SetYawAngle(float yawAngle)
	{
	}

	public void MoveTime(float targetYawAngle, float moveTime)
	{
	}

	public void MoveSpeed(float targetYawAngle, float moveSpeed)
	{
	}
}
