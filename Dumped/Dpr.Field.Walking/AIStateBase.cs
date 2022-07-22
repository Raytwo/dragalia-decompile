using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Dpr.Field.Walking;

public abstract class AIStateBase
{
	public static float Speed;

	private Transform _lookTarget;

	protected AIModel model;

	private List<ActionModel> ActionList;

	protected ActionModel nowAction;

	protected float downTime;

	protected float ActionProbability;

	public float ActionLotteryInterval;

	protected const float DefaultInterval = 2f;

	protected const float DefaultProbability = 0.05f;

	private List<ActionModel> list;

	public Transform LookTarget
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public CorSystem corSys => null;

	protected bool isCanAction => default(bool);

	protected float playerDistance => default(float);

	protected Transform player => null;

	protected float deltaTime => default(float);

	public AIStateBase(AIModel model)
	{
	}

	public virtual void Enter()
	{
	}

	public virtual void Exit()
	{
	}

	public virtual void CommonUpdate()
	{
	}

	protected abstract void StateUpdate();

	public void Play(ActionModel action, [Optional] Action OnFinished)
	{
	}

	public void PlayAnim(int animID, [Optional] Action OnFinished)
	{
	}

	protected ActionModel AddAction(ActionModel action)
	{
		return null;
	}

	public void Destroy()
	{
	}

	public void Cancel()
	{
	}
}
