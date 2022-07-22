using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using XLSXContent;

namespace Dpr.FureaiHiroba;

[Serializable]
public sealed class PokeSanpoModel
{
	public bool isLookPlayer;

	public bool isAddWalking;

	public float CollidedRotValue;

	private float LookPlayerDistance;

	private float WalkingAddDistance;

	public int PositionNo;

	public Vector3 InitPos;

	public Vector3 RandomOffsetPos;

	public bool isPairEnd;

	private static List<Vector3> AngleToDirection;

	public bool isPairMode => default(bool);

	public bool isPairPosition => default(bool);

	public PokeSanpoPairModel PairModel
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public Vector3 defaultDirection
	{
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public PokeSanpoActionModel actionModel
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

	public void CreateActionModel(float bodySize, FreeSanpoActionProbability.SheetSheet1 ActionProbability, int nakayoshiRank)
	{
	}

	public void Update(float deltaTime, Transform Player, Transform transform)
	{
	}

	public void SetDefaultDirection(int Angle)
	{
	}

	public void SetPair(bool isMaster, FureaiPokeModel masterPoke, FureaiPokeModel slavePoke)
	{
	}

	public void DeletePair()
	{
	}

	public void Destroy()
	{
	}
}
