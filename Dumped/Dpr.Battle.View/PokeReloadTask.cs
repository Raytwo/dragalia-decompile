using System;
using Dpr.Battle.Logic;
using Dpr.SequenceEditor;

namespace Dpr.Battle.View;

public sealed class PokeReloadTask : Task
{
	private enum Sequence
	{
		START_DELETE,
		WAIT_DELETE,
		START_LOAD,
		WAIT_LOAD,
		FINISH
	}

	private ISequenceViewSystem _iPtrBtlvSystem;

	private Sequence _seq;

	private BtlvPos _vPos;

	private BtlvPos _vPosTarget;

	private bool _isMetamorphosus;

	private bool _isSimpleParam;

	private SimpleParam _simpleParam;

	private bool _isPlayPinchSound;

	private Action _onComplete;

	private bool _isFinishLoad;

	public PokeReloadTask(ISequenceViewSystem pBtlvSystem, BtlvPos vPos, Action onComplete)
	{
	}

	public PokeReloadTask(ISequenceViewSystem pBtlvSystem, BtlvPos vPos, BtlvPos vPosTarget, Action onComplete)
	{
	}

	public override void Update(float deltaTime, float currentSeqeunceTime, int step)
	{
	}
}
