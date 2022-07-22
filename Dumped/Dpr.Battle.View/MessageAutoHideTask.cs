using Dpr.SequenceEditor;

namespace Dpr.Battle.View;

public sealed class MessageAutoHideTask : Task
{
	private ISequenceViewSystem _iPtrBtlvSystem;

	protected override bool IsFinishCondition => default(bool);

	public MessageAutoHideTask(ISequenceViewSystem pBtlvSystem)
	{
	}

	protected override void OnDispose()
	{
	}

	protected override void OnFinishTask()
	{
	}
}
