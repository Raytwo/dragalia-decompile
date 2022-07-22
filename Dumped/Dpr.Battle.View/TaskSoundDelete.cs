using Audio;
using Dpr.Battle.View.Objects;

namespace Dpr.Battle.View;

public sealed class TaskSoundDelete : Task
{
	private AudioInstance _audioInstance;

	private BtlvSound _sound;

	protected override bool IsFinishCondition => default(bool);

	public TaskSoundDelete(BtlvSound instance, int lifeTime, int frame = 0)
	{
	}

	protected override void OnDispose()
	{
	}

	protected override void OnFinishTask()
	{
	}
}
