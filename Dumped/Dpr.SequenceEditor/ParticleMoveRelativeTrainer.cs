using UnityEngine;

namespace Dpr.SequenceEditor;

public class ParticleMoveRelativeTrainer : Macro
{
	public SEQ_DEF_TRAINER trg;

	public string node;

	public Vector3 pos;

	public bool isRot;

	public bool forceUpdate;

	public SEQ_DEF_MOVETYPE move;

	public ParticleMoveRelativeTrainer(Macro macro)
	{
	}
}
