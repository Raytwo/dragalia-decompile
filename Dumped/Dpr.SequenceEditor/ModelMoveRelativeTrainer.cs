using UnityEngine;

namespace Dpr.SequenceEditor;

public class ModelMoveRelativeTrainer : Macro
{
	public SEQ_DEF_TRAINER trg;

	public string node;

	public Vector3 pos;

	public bool isRot;

	public bool forceUpdate;

	public SEQ_DEF_MOVETYPE move;

	public ModelMoveRelativeTrainer(Macro macro)
	{
	}
}
