using System;
using DG.Tweening;
using UnityEngine;

namespace Dpr.Battle.View;

public sealed class TaskVector4Control : TaskValueControl<Vector4>
{
	protected override bool IsFinishCondition => default(bool);

	public TaskVector4Control(Vector4 from, Vector4 to, Ease easingType, int lifeTime, Action<Vector4> onUpdate)
	{
	}

	protected override void OnUpdate(int frame, float raito)
	{
	}
}
