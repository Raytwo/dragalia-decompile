using UnityEngine;

namespace Dpr.SequenceEditor;

public class SubCameraMoveRelativeTrainer : Macro
{
	public SEQ_DEF_TRAINER_ADD trgChara;

	public string node;

	public Vector3 pos;

	public Vector3 trg;

	public float fov;

	public int rate;

	public bool isFlip;

	public bool isRot;

	public bool forceUpdate;

	public SEQ_DEF_MOVETYPE move;

	public bool[] enableElemPos;

	public bool[] enableElemTrg;

	public SubCameraMoveRelativeTrainer(Macro macro)
	{
	}
}
