using UnityEngine;

namespace Dpr.SequenceEditor;

public class CameraMoveSpecialPos : Macro
{
	public SEQ_DEF_SPPOS posTrg;

	public Vector3 pos;

	public Vector3 trg;

	public float fov;

	public bool isFlip;

	public bool isRot;

	public SEQ_DEF_MOVETYPE move;

	public CameraMoveSpecialPos(Macro macro)
	{
	}
}
