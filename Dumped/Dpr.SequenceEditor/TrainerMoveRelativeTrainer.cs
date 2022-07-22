using UnityEngine;

namespace Dpr.SequenceEditor;

public class TrainerMoveRelativeTrainer : Macro
{
	public SEQ_DEF_TRAINER moveTrg;

	public string moveNode;

	public SEQ_DEF_TRAINER posTrg;

	public string posNode;

	public Vector3 pos;

	public bool isRot;

	public bool forceUpdate;

	public SEQ_DEF_MOVETYPE move;

	public TrainerMoveRelativeTrainer(Macro macro)
	{
	}
}
