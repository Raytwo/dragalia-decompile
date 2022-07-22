using System;
using SmartPoint.AssetAssistant;
using UnityEngine;

public class EnterCollision : SingletonMonoBehaviour<EnterCollision>
{
	private const float PLAYER_RADIUS = 0.5f;

	public Action _OnEnterCallBack;

	protected GameObject targetObj;

	protected float radius;

	protected Vector3 center;

	public bool isEnter;

	public void Create(Action enterFunc, float rad, GameObject target)
	{
	}

	public virtual void OnDestroy()
	{
	}

	protected virtual void OnUpdate(float deltaTime)
	{
	}

	public bool IsInCircle()
	{
		return default(bool);
	}

	protected void PlaySE(uint playSEId)
	{
	}
}
