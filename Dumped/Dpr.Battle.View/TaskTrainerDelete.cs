using Dpr.Battle.Logic;
using Dpr.SequenceEditor;

namespace Dpr.Battle.View;

public sealed class TaskTrainerDelete : Task
{
	private enum Sequence
	{
		START_DELETE,
		WAIT_DELETE,
		FINISH
	}

	private ISequenceViewSystem _iPtrBtlvSystem;

	private BtlvPos _vPos;

	private Sequence _seq;

	public TaskTrainerDelete(ISequenceViewSystem pBtlvSystem, BtlvPos vPos)
	{
	}

	public override void Update(float deltaTime, float currentSequenceTime, int step)
	{
	}
}
