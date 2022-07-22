using UnityEngine;

namespace Dpr.SequenceEditor;

public class ModelMoveSpecialPos : Macro
{
	public SEQ_DEF_SPPOS pos;

	public Vector3 ofs;

	public bool isFlip;

	public bool isRot;

	public SEQ_DEF_MOVETYPE move;

	public ModelMoveSpecialPos(Macro macro)
	{
	}
}
