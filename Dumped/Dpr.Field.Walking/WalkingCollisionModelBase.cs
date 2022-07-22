using System.Collections.Generic;
using Dpr.FureaiHiroba;
using UnityEngine;

namespace Dpr.Field.Walking;

public abstract class WalkingCollisionModelBase
{
	protected WalkData walkData;

	public bool isIgnoreCollision;

	public bool isCollidedAdd;

	protected float bodySize
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	protected FieldObjectEntity entity => null;

	protected int CollidedCount
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	protected Transform transform => null;

	protected WalkingCollisionModelBase(WalkData walkData)
	{
	}

	public virtual void CollisionUpdate(float deltaTime)
	{
	}

	public virtual void ExCollisionUpdate(float deltaTime, List<FureaiPokeModel> characters)
	{
	}

	public virtual bool ObjectCollisionUpdate(float deltaTime, bool isIgnoreJump = false)
	{
		return default(bool);
	}

	public void UpdateCollisionCount()
	{
	}

	public bool CheckCollision(FieldObjectEntity target, float radius, float speed, bool CheckWeight = false, bool isCheckOnly = false, int targetPriority = 999, bool isCheckHeight = false)
	{
		return default(bool);
	}

	public virtual void LateUpdate(float deltaTime)
	{
	}
}
