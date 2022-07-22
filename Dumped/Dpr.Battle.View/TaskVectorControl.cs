using System;
using DG.Tweening;
using UnityEngine;

namespace Dpr.Battle.View;

public sealed class TaskVectorControl : TaskValueControl<Vector3>
{
	protected override bool IsFinishCondition => default(bool);

	public TaskVectorControl(Vector3 from, Vector3 to, Ease easingType, int lifeTime, Action<Vector3> onUpdate)
	{
	}

	protected override void OnUpdate(int frame, float raito)
	{
	}
}
