using System;
using Dpr.Battle.View.Objects;
using Dpr.SequenceEditor;

namespace Dpr.Battle.View;

public sealed class TaskParticleDelete : Task
{
	private BtlvEffectInstance _effectInstance;

	private Action _onFinishAction;

	private SEQ_DEF_PARTICLE_DELETE _deleteType;

	protected override bool IsFinishCondition => default(bool);

	public TaskParticleDelete(BtlvEffectInstance instance, SEQ_DEF_PARTICLE_DELETE deleteType, Action finishAction, int lifeTime, int frame = 0)
	{
	}

	protected override void OnDispose()
	{
	}

	protected override void OnFinishTask()
	{
	}
}
