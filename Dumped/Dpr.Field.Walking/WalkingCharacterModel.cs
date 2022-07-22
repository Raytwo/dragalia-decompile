using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Dpr.RouteSearch;
using Pml.PokePara;
using UnityEngine;

namespace Dpr.Field.Walking;

public class WalkingCharacterModel
{
	public delegate bool CancelCheck();

	public WalkingCharacterController controller;

	public WalkData walkData;

	public WalkingCollisionModelBase collisionModel;

	public Func<FieldObjectEntity[]> GetWalkers;

	public PokemonParam pokePara;

	public Action<WalkingCharacterModel> OnWarp;

	public AnimationPlayer animPlayer;

	public Transform LookTarget;

	public bool isForceAnimation;

	public int PrevSleepLevel;

	public int SleepLevel;

	public bool isCanSleepAnimation;

	public List<Vector3> route;

	private Vector3 PokeDefaultScale;

	public bool isWarping;

	public MoveType moveType;

	private NodeData nodeData;

	public float bodySize
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public int CollidedCount
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public bool isStopUpdate
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public Type nowState => null;

	public AI AI => null;

	public FieldObjectEntity entity => null;

	public Transform transform => null;

	public bool isDestroyed
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	public bool isIgnoreJump => default(bool);

	public event Action OnChangeState
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public bool CheckState<T>() where T : AIStateBase
	{
		return default(bool);
	}

	public void Update(WalkingCharacterModel Target, float baseOffsetScale, float baseSpeed)
	{
	}

	public WalkingCharacterModel(WalkData walkData)
	{
	}

	public void SetController(WalkingCharacterController controller)
	{
	}

	public void SetPokemonParam(PokemonParam pokePara)
	{
	}

	public virtual void Destroy()
	{
	}

	protected virtual void GetBodySize()
	{
	}

	public List<Vector3> GetRoute(Vector3 goalPos, int SearchDistance)
	{
		return null;
	}

	public void CreateRoute(Vector3 goalPos, int SearchDistance)
	{
	}

	public IEnumerator WaitforAnimationFinish(CancelCheck cancelCheck)
	{
		return null;
	}

	public void Warp(Vector3 pos, bool immidiate = false)
	{
	}

	public Tweener Enter(Vector3 pos, bool dontSE = false)
	{
		return null;
	}

	public Tweener Enter(bool dontSE = false)
	{
		return null;
	}

	public Tween Exit(bool dontSE)
	{
		return null;
	}

	public void CreateWarpEffect()
	{
	}

	public Transform CreateEffectPosTransform(Vector3 pos, float duration)
	{
		return null;
	}
}
