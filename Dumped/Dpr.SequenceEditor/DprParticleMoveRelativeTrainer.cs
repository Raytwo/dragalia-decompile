using UnityEngine;

namespace Dpr.SequenceEditor;

public class DprParticleMoveRelativeTrainer : Macro
{
	public SEQ_DEF_TRAINER trg;

	public int nodeIndex;

	public Vector3 pos;

	public bool isRot;

	public bool forceUpdate;

	public SEQ_DEF_MOVETYPE move;

	public DprParticleMoveRelativeTrainer(Macro macro)
	{
	}
}
