using UnityEngine;

namespace Dpr.SequenceEditor;

public class DprCameraMoveRelativeModel : Macro
{
	public int grpNo;

	public int nodeIndex;

	public Vector3 pos;

	public Vector3 trg;

	public float fov;

	public int rate;

	public SEQ_DEF_POS dirPoke;

	public bool isFlip;

	public bool isRot;

	public bool forceUpdate;

	public SEQ_DEF_MOVETYPE move;

	public bool[] enableElemPos;

	public bool[] enableElemTrg;

	public DprCameraMoveRelativeModel(Macro macro)
	{
	}
}
