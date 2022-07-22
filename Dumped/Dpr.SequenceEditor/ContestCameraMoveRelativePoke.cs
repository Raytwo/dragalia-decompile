using UnityEngine;

namespace Dpr.SequenceEditor;

public class ContestCameraMoveRelativePoke : Macro
{
	public SEQ_DEF_POS poke;

	public SEQ_DEF_NODE node;

	public Vector3 pos;

	public Vector3 trg;

	public float fov;

	public int rate;

	public bool isFlip;

	public bool isScale;

	public bool isRot;

	public bool forceUpdate;

	public SEQ_DEF_MOVETYPE move;

	public bool[] enableElemPos;

	public bool[] enableElemTrg;

	public ContestCameraMoveRelativePoke(Macro macro)
	{
	}
}
