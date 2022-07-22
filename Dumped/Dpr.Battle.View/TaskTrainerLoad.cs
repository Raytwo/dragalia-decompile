using Dpr.Battle.Logic;
using Dpr.SequenceEditor;

namespace Dpr.Battle.View;

public sealed class TaskTrainerLoad : Task
{
	private enum Sequence
	{
		START_LOAD,
		WAIT_LOAD,
		FINISH
	}

	private ISequenceViewSystem _iPtrBtlvSystem;

	private BtlvPos _vPos;

	private string _name;

	private Sequence _seq;

	public TaskTrainerLoad(ISequenceViewSystem pBtlvSystem, BtlvPos vPos, string name)
	{
	}

	protected override void OnDispose()
	{
	}

	public override void Update(float deltaTime, float currentSequenceTime, int step)
	{
	}
}
