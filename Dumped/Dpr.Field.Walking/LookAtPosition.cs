using System.Collections;
using UnityEngine;

namespace Dpr.Field.Walking;

public class LookAtPosition : ActionModel
{
	private Vector3 offset;

	private float speed;

	private float duration;

	public LookAtPosition(Vector3 offset, float speed, float duration)
	{
	}

	public override IEnumerator DoAction(AIModel model)
	{
		return null;
	}
}
