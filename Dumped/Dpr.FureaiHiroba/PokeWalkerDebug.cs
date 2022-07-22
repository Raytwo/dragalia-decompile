using System;
using System.Collections.Generic;
using Dpr.Field.Walking;
using UnityEngine;

namespace Dpr.FureaiHiroba;

[Serializable]
internal class PokeWalkerDebug
{
	private WalkingCharacterModel _model;

	private Transform WalkStartArea;

	private Transform RunStartArea;

	private Transform TargetDistance;

	private bool isDebugDraw;

	private List<GameObject> goList;

	public int Button01;

	[SerializeField]
	private float PositionHosei;

	[SerializeField]
	private float WalkHosei;

	[SerializeField]
	private float RunHosei;

	private FureaiPokeModel model => null;

	public PokeWalkerDebug(WalkingCharacterModel model)
	{
	}

	public void CreateTrackPoint()
	{
	}

	public Vector3[] CreateDebugRoute(Transform target, Transform transform, Vector3[] route)
	{
		return null;
	}

	public void ClearRoute()
	{
	}

	public void CreateReactionArea()
	{
	}

	public void Update()
	{
	}

	public void SetActive(bool isActive)
	{
	}
}
