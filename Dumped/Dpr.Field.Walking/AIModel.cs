using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dpr.Field.Walking;

public class AIModel
{
	public delegate bool EndCheck();

	public delegate AI GetAI();

	public WalkingCharacterModel charaModel;

	public WalkingCharacterView view;

	public Transform transform;

	public CorSystem corSys;

	private GetAI _GetAI;

	public List<Vector3> route => null;

	public WalkData walkData => null;

	public Transform player => null;

	public float playerDistance => default(float);

	public AI AI => null;

	public AIModel(WalkingCharacterController controller)
	{
	}

	public virtual void Destroy()
	{
	}

	public IEnumerator Loop(EndCheck EndCheck, Action action)
	{
		return null;
	}
}
