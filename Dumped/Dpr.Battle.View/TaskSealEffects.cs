using System.Collections.Generic;
using Dpr.Battle.View.Objects;
using UnityEngine;

namespace Dpr.Battle.View;

public sealed class TaskSealEffects : Task
{
	private ObjectEntity _ballEntity;

	private List<BtlvEffectInstance> _ballEffectInstances;

	private FromToPair<Vector3>[] _ballPositions;

	protected override bool IsFinishCondition => default(bool);

	public TaskSealEffects(ObjectEntity entity, List<BtlvEffectInstance> sealEffects, float adjustHeight, int frame)
	{
	}

	protected override void OnDispose()
	{
	}

	protected override void OnUpdate(int frame, float raito)
	{
	}
}
