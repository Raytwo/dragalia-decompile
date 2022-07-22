using UnityEngine;

namespace Dpr.SequenceEditor;

public class SubCameraMoveRelativeCameraSp : Macro
{
	public SEQ_DEF_SPPOS posTrg;

	public Vector3 pos;

	public Vector3 trg;

	public float fov;

	public SEQ_DEF_MOVETYPE move;

	public bool isFlip;

	public bool isRot;

	public bool relative;

	public bool[] enableElemPos;

	public bool[] enableElemTrg;

	public SubCameraMoveRelativeCameraSp(Macro macro)
	{
	}
}
