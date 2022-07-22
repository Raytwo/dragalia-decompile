using UnityEngine;

namespace Dpr.SequenceEditor;

public class TrainerMove : Macro
{
	public SEQ_DEF_TRAINER_ADD trg;

	public Vector3 pos;

	public bool relative;

	public SEQ_DEF_MOVETYPE move;

	public TrainerMove(Macro macro)
	{
	}
}
