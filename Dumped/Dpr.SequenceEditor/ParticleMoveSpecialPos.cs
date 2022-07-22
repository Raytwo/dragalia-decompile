using UnityEngine;

namespace Dpr.SequenceEditor;

public class ParticleMoveSpecialPos : Macro
{
	public SEQ_DEF_SPPOS pos;

	public Vector3 ofs;

	public bool isFlip;

	public bool isRot;

	public SEQ_DEF_MOVETYPE move;

	public ParticleMoveSpecialPos(Macro macro)
	{
	}
}
