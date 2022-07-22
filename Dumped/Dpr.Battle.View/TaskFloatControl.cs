using System;
using DG.Tweening;

namespace Dpr.Battle.View;

public sealed class TaskFloatControl : TaskValueControl<float>
{
	protected override bool IsFinishCondition => default(bool);

	public TaskFloatControl(int lifeTime, Ease easingType, Action<float> onUpdate)
	{
	}

	public TaskFloatControl(float from, float to, int lifeTime, Ease easingType, Action<float> onUpdate)
	{
	}

	protected override void OnUpdate(int frame, float raito)
	{
	}
}
